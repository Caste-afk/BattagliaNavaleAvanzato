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

        private bool turno;//true = attacco del giocatore
        private CGiocatore player;
        private CGiocatore nemico;
        private int naviCpuAffondate;
        private int naviPlayerAffondate;
        //private DataGridView d1;

        // Campi per la logica del bot
        private List<(int x, int y)> celleColpite;
        private List<(int x, int y)> celleInAttesa;
        private (int x, int y)? ultimoColpo;
        private bool modalitaCaccia;

        public FMainBattaglia()
        {
            InitializeComponent();
            
            MettiMusica(3);

            CreaCampoCPU();
            this.player = player;
            naviCpuAffondate = 0;
            naviPlayerAffondate = 0;

            celleColpite = new List<(int x, int y)>();
            celleInAttesa = new List<(int x, int y)>();//celle da colpire per cercare la nave
            ultimoColpo = null;
            modalitaCaccia = false;//ha colpito la nave e la sta cercando
        }


        public void RiceviGiocatore(object sender, CGiocatore player)
        {
            this.player = player;
        }

        public void RiceviDataGridView(object sender, DataGridView dgv)
        {
            ImpostaDGV(dgv_Main, dgv);
            ImpostaDGV(dgv_CPU, dgv);
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
                }
            }

            nemico = new CGiocatore(navi);
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

        private async void dgv_CPU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Tag == "cliccato")
            {
                return;
            }

            CNave naveAffondata = VerificaColpo(nemico, e.RowIndex, e.ColumnIndex, (DataGridView)sender);

            if (naveAffondata != null)
            {
                nemico.navi.Remove(naveAffondata);
                MessageBox.Show("Nave affondata!");
                naviCpuAffondate++;

                if (nemico.navi.Count == 0)
                {
                    MessageBox.Show("Hai vinto! Tutte le navi nemiche sono affondate!");
                    Application.Exit();
                    return;
                }
            }

            await Task.Delay(500);

            // Turno della CPU
            CapisciDoveAttaccare();
        }


        private void CapisciDoveAttaccare()
        {
            int x, y;

            if (modalitaCaccia && celleInAttesa.Count > 0)
            {
                //cerca la cella
                var prossimaCella = celleInAttesa[0];
                celleInAttesa.RemoveAt(0);
                x = prossimaCella.x;
                y = prossimaCella.y;
            }
            else
            {
                //cerca la cella sparando a random
                (x, y) = TrovaCellaCasuale();
            }

            
            CNave naveAffondata = VerificaColpo(player, x, y, dgv_Main);
            celleColpite.Add((x, y));

            if (naveAffondata != null)
            {
                //nave affondata e reset della modalità di ricerca
                player.navi.Remove(naveAffondata);
                MessageBox.Show("La CPU ha affondato una tua nave!");
                naviPlayerAffondate++;
                modalitaCaccia = false;
                celleInAttesa.Clear();

                if (player.navi.Count == 0)
                {
                    MessageBox.Show("Hai perso! Tutte le tue navi sono affondate!");
                }
            }
            else if (dgv_Main.Rows[x].Cells[y].Style.BackColor == Color.Red)
            {
                //nave solo colpita e continua a cercarla
                modalitaCaccia = true;
                ultimoColpo = (x, y);
                AggiungiCelleAdiacenti(x, y);
            }
            else
            {
                //nave mancata
                if (!modalitaCaccia)
                {
                    celleInAttesa.Clear();
                }
            }
        }

        private void AggiungiCelleAdiacenti(int x, int y)
        {
            List<(int x, int y)> adiacenti = new List<(int x, int y)>//posizioni delle celle vicine
            {
                (x - 1, y), 
                (x + 1, y), 
                (x, y - 1), 
                (x, y + 1)  
            };

            foreach (var cella in adiacenti)
            {
                if (cella.x >= 0 && cella.x < 10 &&
                    cella.y >= 0 && cella.y < 10 &&
                    !celleColpite.Contains(cella) &&
                    !celleInAttesa.Contains(cella))
                {
                    celleInAttesa.Add(cella);
                }
            }
        }

        private (int x, int y) TrovaCellaCasuale()
        {
            Random rnd = new Random();
            int x, y;
            
            x = rnd.Next(0, 10);
            y = rnd.Next(0, 10);
            return (x, y);
        }

        private void Colpito(DataGridView target, int r, int c)
        {
            target.Rows[r].Cells[c].Style.BackColor = Color.Red;
            target.Rows[r].Cells[c].Style.ForeColor = Color.White;
            target.Rows[r].Cells[c].Value = "X";
            target.Rows[r].Cells[c].Tag = "cliccato";
            MettiMusica(1);
            lbx_Main.Items.Add( $"Colpito a {r}, {c}!") ;
        }

        private void Mancato(DataGridView target, int r, int c)
        {
            target.Rows[r].Cells[c].Style.BackColor = Color.LightBlue;
            target.Rows[r].Cells[c].Style.ForeColor = Color.White;
            target.Rows[r].Cells[c].Value = "O";
            target.Rows[r].Cells[c].Tag = "cliccato";
            MettiMusica(0);
            lbx_Main.Items.Add($"Acqua!");
        }

        private void MettiMusica(int n)
        {
            //0 = acqua
            //1 = colpito
            //2 = affondato
            //3 = musica di sottofondo
            string path = @"suoni\";
            if (n != 3)
            {
                System.Media.SoundPlayer musica = new System.Media.SoundPlayer($"{path}{n}.wav");
                musica.Play();
            }
            else
            {
                System.Media.SoundPlayer musica = new System.Media.SoundPlayer($"{path}{n}.wav");
                musica.PlayLooping();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}