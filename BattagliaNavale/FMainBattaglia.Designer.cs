namespace BattagliaNavale
{
    partial class FMainBattaglia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_Main = new System.Windows.Forms.DataGridView();
            this.lbl_Campo1 = new System.Windows.Forms.Label();
            this.lbl_Campo2 = new System.Windows.Forms.Label();
            this.lbl_Istruzioni = new System.Windows.Forms.Label();
            this.lbl_NaviRimaste = new System.Windows.Forms.Label();
            this.lbl_Colpito = new System.Windows.Forms.Label();
            this.dgv_CPU = new System.Windows.Forms.DataGridView();
            this.lbx_Main = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CPU)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Main
            // 
            this.dgv_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Main.Location = new System.Drawing.Point(22, 142);
            this.dgv_Main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Main.Name = "dgv_Main";
            this.dgv_Main.RowHeadersWidth = 72;
            this.dgv_Main.RowTemplate.Height = 31;
            this.dgv_Main.Size = new System.Drawing.Size(1086, 1069);
            this.dgv_Main.TabIndex = 1;
            // 
            // lbl_Campo1
            // 
            this.lbl_Campo1.AutoSize = true;
            this.lbl_Campo1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Campo1.Location = new System.Drawing.Point(52, 40);
            this.lbl_Campo1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Campo1.Name = "lbl_Campo1";
            this.lbl_Campo1.Size = new System.Drawing.Size(336, 50);
            this.lbl_Campo1.TabIndex = 3;
            this.lbl_Campo1.Text = "Campo Giocatore";
            // 
            // lbl_Campo2
            // 
            this.lbl_Campo2.AutoSize = true;
            this.lbl_Campo2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Campo2.Location = new System.Drawing.Point(2046, 60);
            this.lbl_Campo2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Campo2.Name = "lbl_Campo2";
            this.lbl_Campo2.Size = new System.Drawing.Size(240, 50);
            this.lbl_Campo2.TabIndex = 4;
            this.lbl_Campo2.Text = "Campo CPU";
            // 
            // lbl_Istruzioni
            // 
            this.lbl_Istruzioni.AutoSize = true;
            this.lbl_Istruzioni.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Istruzioni.Location = new System.Drawing.Point(1238, 313);
            this.lbl_Istruzioni.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Istruzioni.Name = "lbl_Istruzioni";
            this.lbl_Istruzioni.Size = new System.Drawing.Size(377, 50);
            this.lbl_Istruzioni.TabIndex = 5;
            this.lbl_Istruzioni.Text = "Colpisci l\'avversario";
            // 
            // lbl_NaviRimaste
            // 
            this.lbl_NaviRimaste.AutoSize = true;
            this.lbl_NaviRimaste.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NaviRimaste.Location = new System.Drawing.Point(1238, 488);
            this.lbl_NaviRimaste.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_NaviRimaste.Name = "lbl_NaviRimaste";
            this.lbl_NaviRimaste.Size = new System.Drawing.Size(334, 50);
            this.lbl_NaviRimaste.TabIndex = 6;
            this.lbl_NaviRimaste.Text = "Navi affondate: ";
            // 
            // lbl_Colpito
            // 
            this.lbl_Colpito.AutoSize = true;
            this.lbl_Colpito.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Colpito.Location = new System.Drawing.Point(1238, 717);
            this.lbl_Colpito.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Colpito.Name = "lbl_Colpito";
            this.lbl_Colpito.Size = new System.Drawing.Size(171, 50);
            this.lbl_Colpito.TabIndex = 7;
            this.lbl_Colpito.Text = "Colpisci!";
            // 
            // dgv_CPU
            // 
            this.dgv_CPU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CPU.Location = new System.Drawing.Point(1703, 142);
            this.dgv_CPU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_CPU.Name = "dgv_CPU";
            this.dgv_CPU.RowHeadersWidth = 72;
            this.dgv_CPU.RowTemplate.Height = 31;
            this.dgv_CPU.Size = new System.Drawing.Size(1086, 1069);
            this.dgv_CPU.TabIndex = 8;
            this.dgv_CPU.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CPU_CellClick);
            // 
            // lbx_Main
            // 
            this.lbx_Main.FormattingEnabled = true;
            this.lbx_Main.ItemHeight = 25;
            this.lbx_Main.Location = new System.Drawing.Point(810, 1256);
            this.lbx_Main.Name = "lbx_Main";
            this.lbx_Main.Size = new System.Drawing.Size(1200, 304);
            this.lbx_Main.TabIndex = 9;
            // 
            // FMainBattaglia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2884, 1748);
            this.Controls.Add(this.lbx_Main);
            this.Controls.Add(this.dgv_CPU);
            this.Controls.Add(this.lbl_Colpito);
            this.Controls.Add(this.lbl_NaviRimaste);
            this.Controls.Add(this.lbl_Istruzioni);
            this.Controls.Add(this.lbl_Campo2);
            this.Controls.Add(this.lbl_Campo1);
            this.Controls.Add(this.dgv_Main);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FMainBattaglia";
            this.Text = "FMainBattaglia";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Main;
        private System.Windows.Forms.Label lbl_Campo1;
        private System.Windows.Forms.Label lbl_Campo2;
        private System.Windows.Forms.Label lbl_Istruzioni;
        private System.Windows.Forms.Label lbl_NaviRimaste;
        private System.Windows.Forms.Label lbl_Colpito;
        private System.Windows.Forms.DataGridView dgv_CPU;
        private System.Windows.Forms.ListBox lbx_Main;
    }
}