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
        public Form1()
        {
            InitializeComponent();
            ReimpostaTesto();
        }

        private void btn_1v0_Click(object sender, EventArgs e)
        {
            FPosizioneBasi nuovoForm = new FPosizioneBasi();

            nuovoForm.scrivi += scriviLogs;

            DialogResult result = nuovoForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.Close();
            }
            this.Hide();
        }

        private void ReimpostaTesto()
        {
            string dir = Path.Combine(Application.StartupPath, "data");
            Directory.CreateDirectory(dir);
            string path = Path.Combine(dir, "Log.txt");
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("");
            }
        }


        private void scrittore(string testo)
        {
            string dir = Path.Combine(Application.StartupPath, "data");
            Directory.CreateDirectory(dir);
            string path = Path.Combine(dir, "Log.txt");

            File.AppendAllText(path, testo + Environment.NewLine);
        }

        private void scriviLogs(object sender, string testo)
        {
            scrittore(testo);
        }

    }
}