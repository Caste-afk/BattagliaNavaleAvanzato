using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattagliaNavale
{
    public partial class FMainBattaglia : Form
    {
        private CGiocatore player;
        private CGiocatore nemico;
        private int naviCpuAffondate;
        private int naviPlayerAffondate;

        public FMainBattaglia(DataGridView d1, CGiocatore player)
        {
            InitializeComponent();
            ImpostaDGV(dgv_Main, d1);
            ImpostaDGV(dgv_CPU, d1);
            CreaCampoCPU();
            this.player = player;
            naviCpuAffondate = 0;
            naviPlayerAffondate = 0;
        }

        private void ImpostaDGV(DataGridView target, DataGridView source)
        {
            target.Rows.Clear();
            target.Columns.Clear();

            // Rimuove header delle righe
            target.RowHeadersVisible = false;
            target.AllowUserToAddRows = false;
            target.ScrollBars = ScrollBars.None;

            // AUMENTO FONT per permettere l'adattamento reale
            target.DefaultCellStyle.Font = new Font("Segoe UI", 14);
            target.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);

            // Adattamento automatico al form
            target.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            target.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            target.AllowUserToResizeColumns = false;
            target.AllowUserToResizeRows = false;
            target.SelectionMode = DataGridViewSelectionMode.CellSelect;
            target.ReadOnly = true;

            // Copia le colonne da source
            foreach (DataGridViewColumn col in source.Columns)
            {
                target.Columns.Add((DataGridViewColumn)col.Clone());
            }

            // Copia le righe da source
            foreach (DataGridViewRow row in source.Rows)
            {
                if (!row.IsNewRow)
                {
                    target.Rows.Add(row.Clone() as DataGridViewRow);
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        target.Rows[target.Rows.Count - 1].Cells[i].Value = row.Cells[i].Value;
                        // Resetta i colori a bianco
                        target.Rows[target.Rows.Count - 1].Cells[i].Style.BackColor = Color.White;
                        target.Rows[target.Rows.Count - 1].Cells[i].Style.ForeColor = Color.Black;
                    }
                }
            }

            // Calcola e imposta l'altezza delle righe per riempire lo spazio disponibile
            int availableHeight = target.Height - target.ColumnHeadersHeight;
            int rowHeight = availableHeight / target.Rows.Count;
            foreach (DataGridViewRow row in target.Rows)
            {
                row.Height = rowHeight;
            }
        }

        private void CreaCampoCPU()
        {
            List<CNave> navi = new List<CNave>();
            List<int> lunghezzaNavi = new List<int>() { 4, 3, 3, 2, 2, 1 };
            int max = 10, min = 0;

            Random rnd = new Random();

            for (int i = 0; i < lunghezzaNavi.Count; i++)
            {
                bool posizionata = false;

                while (!posizionata)
                {
                    // Genera orientamento casuale (0 = orizzontale, 1 = verticale)
                    int orientamento = rnd.Next(0, 2);

                    int x, y;
                    (int x, int y) c1, c2;

                    if (orientamento == 0) // Orizzontale
                    {
                        y = rnd.Next(min, max);
                        x = rnd.Next(min, max - lunghezzaNavi[i] + 1);

                        c1 = (x, y);
                        c2 = (x + lunghezzaNavi[i] - 1, y);
                    }
                    else // Verticale
                    {
                        x = rnd.Next(min, max);
                        y = rnd.Next(min, max - lunghezzaNavi[i] + 1);

                        c1 = (x, y);
                        c2 = (x, y + lunghezzaNavi[i] - 1);
                    }

                    // Verifica se la posizione è valida
                    if (PosizionamentoValido(c1, c2, navi))
                    {
                        CNave nuovaNave = new CNave(c1, c2);
                        navi.Add(nuovaNave);
                        posizionata = true;
                    }
                    nemico = new CGiocatore(navi);
                }
            }
        }

        private bool PosizionamentoValido((int x, int y) c1, (int x, int y) c2, List<CNave> naviEsistenti)
        {
            List<(int x, int y)> celleDaOccupare = new List<(int x, int y)>();

            if (c1.y == c2.y)
            {
                int xStart = Math.Min(c1.x, c2.x);
                int xEnd = Math.Max(c1.x, c2.x);
                for (int x = xStart; x <= xEnd; x++)
                    celleDaOccupare.Add((x, c1.y));
            }
            else if (c1.x == c2.x)
            {
                int yStart = Math.Min(c1.y, c2.y);
                int yEnd = Math.Max(c1.y, c2.y);
                for (int y = yStart; y <= yEnd; y++)
                    celleDaOccupare.Add((c1.x, y));
            }

            foreach (CNave nave in naviEsistenti)
            {
                foreach (var cella in nave.locazione)
                {
                    if (celleDaOccupare.Contains(cella))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        #region comportamento campo del bot

        private void dgv_CPU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CNave naveAffondata = VerificaColpo(nemico, e.RowIndex, e.ColumnIndex, (DataGridView)sender);

            if (naveAffondata != null)
            {
                nemico.navi.Remove(naveAffondata);
                MessageBox.Show("Nave affondata!");
                naviCpuAffondate++;
                lbl_NaviRimaste.Text = $"Navi affondate: {naviCpuAffondate}";

                if (nemico.navi.Count == 0)
                {
                    MessageBox.Show("Hai vinto! Tutte le navi nemiche sono affondate!");
                }
            }
            AttaccoCPU();
        }


        private void Colpito(DataGridView target, int r, int c)
        {
            target.Rows[r].Cells[c].Style.BackColor = Color.Red;
        }

        private void Mancato(DataGridView target, int r, int c)
        {
            target.Rows[r].Cells[c].Style.BackColor = Color.LightBlue;
        }
        #endregion


        #region bot che colpisce il campo del giocatore


        private void AttaccoCPU()
        {
            Random rnd = new Random();
            int riga = rnd.Next(0, 10);
            int colonna = rnd.Next(0, 10);

            CNave naveAffondata = VerificaColpo(player, riga, colonna, dgv_Main);

            if (naveAffondata != null)
            {
                player.navi.Remove(naveAffondata);
                MessageBox.Show("La CPU ha affondato una tua nave!");
                naviPlayerAffondate++;

                if (player.navi.Count == 0)
                {
                    MessageBox.Show("Hai perso! Tutte le tue navi sono affondate!");
                }
            }
        }

        private void CapisciDoveAttaccare(int x, int y)
        {

        }


        #endregion

        private CNave VerificaColpo(CGiocatore bersaglio, int riga, int colonna, DataGridView target)
        {
            CNave naveAffondata = null;
            bool colpito = false;

            foreach (var n in bersaglio.navi)
            {
                foreach (var cella in n.locazione)
                {
                    if (cella.x == riga && cella.y == colonna)
                    {
                        colpito = true;
                        Colpito(target, riga, colonna);

                        bool affondata = n.Colpito((riga, colonna));

                        if (affondata)
                        {
                            naveAffondata = n;
                        }
                        break;
                    }
                }
                if (colpito) break;
            }

            if (!colpito)
            {
                Mancato(target, riga, colonna);
            }

            return naveAffondata;
        }

    }
}
