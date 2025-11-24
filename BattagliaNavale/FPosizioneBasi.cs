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
    public partial class FPosizioneBasi : Form
    {
        private bool primo;// serve per indicare se è la prima coordinata della nave
        private List<CNave> navi;
        private List<int> lunghezzaNavi;
        private int x1, y1;

        public FPosizioneBasi()
        {
            InitializeComponent();
            primo = true;
            lunghezzaNavi = new List<int>() { 4, 3, 3, 2, 2, 1 };
            navi = new List<CNave>();
            btn_invia.Hide();
        }
        private void FPosizioneBasi_Load(object sender, EventArgs e)
        {
            ImpostaDGV();
            AggiornaScritte();
        }
        private void ImpostaDGV()
        {
            string lettere = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            dgv_Main.Rows.Clear();
            dgv_Main.Columns.Clear();
            // Rimuove header delle righe
            dgv_Main.RowHeadersVisible = false;
            dgv_Main.AllowUserToAddRows = false;
            // AUMENTO FONT per permettere l'adattamento reale
            dgv_Main.DefaultCellStyle.Font = new Font("Segoe UI", 14);
            dgv_Main.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            // Adattamento automatico al form
            dgv_Main.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Main.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv_Main.AllowUserToResizeColumns = false;
            dgv_Main.AllowUserToResizeRows = false;
            dgv_Main.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv_Main.ReadOnly = true;
            // Crea colonne
            for (int i = 0; i < 10; i++)
            {
                string header = lettere[i].ToString();
                dgv_Main.Columns.Add(header, header);
            }
            // Crea righe
            for (int r = 0; r < 10; r++)
            {
                dgv_Main.Rows.Add();
            }
            // Calcola e imposta l'altezza delle righe per riempire lo spazio disponibile
            int availableHeight = dgv_Main.Height - dgv_Main.ColumnHeadersHeight;
            int rowHeight = availableHeight / dgv_Main.Rows.Count;
            foreach (DataGridViewRow row in dgv_Main.Rows)
            {
                row.Height = rowHeight;
            }
        }
        private void AggiornaScritte()
        {
            lbl_naviPosizionate.Text = $"Navi posizionate: {navi.Count}/6";
            if (lunghezzaNavi.Count > 0)
            {
                lbl_indicazioni.Text = $"posiziona la nave lunga {lunghezzaNavi[0]}";
            }
            else
            {
                lbl_indicazioni.Text = "Premi sul pulsante invia";
                btn_invia.Show();
            }
        }

        private void ColoraNavi()
        {
            foreach (DataGridViewRow row in dgv_Main.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                }
            }

            foreach (CNave nave in navi)
            {
                foreach (var coord in nave.Locazione)
                {
                    dgv_Main.Rows[coord.Item1].Cells[coord.Item2].Style.BackColor = Color.LightGreen;
                }
            }
        }

        private void btn_invia_Click(object sender, EventArgs e)
        {

        }
        private void dgv_Main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lunghezzaNavi.Count ==0)
            {
                return;
            }
            if (primo)
            {
                x1 = e.RowIndex;
                y1 = e.ColumnIndex;
            }
            else
            {
                CNave nave = new CNave((x1, y1), (e.RowIndex, e.ColumnIndex));
                if (nave.Locazione.Count != lunghezzaNavi[0])
                {
                    MessageBox.Show($"La nave deve essere lunga {lunghezzaNavi[0]} celle!");
                    primo = true;
                    return;
                }
                navi.Add(nave);
                lunghezzaNavi.RemoveAt(0);
                ColoraNavi();
                AggiornaScritte();
            }
            primo = !primo;
        }
    }
}