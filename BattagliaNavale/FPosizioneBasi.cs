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
            primo = false;
            lunghezzaNavi = new List<int>() { 4, 3, 3, 2, 2, 1 };
        }

        private void FPosizioneBasi_Load(object sender, EventArgs e)
        {
            ImpostaDGV();
            lbl_naviPosizionate.Text = $"Navi posizionate: {navi.Count}/5";
            lbl_indicazioni.Text = $"posiziona la nave lunga {lunghezzaNavi[0]}";
        }

        private void ImpostaDGV()
        {
            string lettere = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            dgv_Main.Rows.Clear();

            for (int i = 0; i < 10; i++)
            {
                string valore = $"{lettere[i]}";
                dgv_Main.Rows.Add();
                dgv_Main.Columns.Add(valore, valore);

            }

        }

        private void btn_invia_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (primo)
            {
                x1 = e.RowIndex;
                y1 = e.ColumnIndex;
                primo = false;
            }
            else
            {
                CNave nave = new CNave((x1, y1), (e.RowIndex, e.ColumnIndex));
                if(nave.Locazione.Count != lunghezzaNavi[0])
                {
                    return;
                }
                navi.Add(nave);
                lunghezzaNavi.RemoveAt(0);
                lbl_indicazioni.Text = $"posiziona la nave lunga {lunghezzaNavi[0]}";
            }
        }
    }
}
