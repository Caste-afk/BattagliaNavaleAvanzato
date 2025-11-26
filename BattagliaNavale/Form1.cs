using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattagliaNavale
{
    public partial class Form1 : Form
    {
        
        private FPosizioneBasi posizioneBasi;
        public FMainBattaglia mainBattaglia;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1v0_Click(object sender, EventArgs e)
        {
            posizioneBasi = new FPosizioneBasi();
            mainBattaglia = new FMainBattaglia();

            posizioneBasi.inviaGiocatore += mainBattaglia.RiceviGiocatore;
            posizioneBasi.inviaDataGridView += mainBattaglia.RiceviDataGridView;

            posizioneBasi.SetBattaglia(mainBattaglia);

            DialogResult result = posizioneBasi.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.Close();
            }
            this.Hide();
        }


    }
}