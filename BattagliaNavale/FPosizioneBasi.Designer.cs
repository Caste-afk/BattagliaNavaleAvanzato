namespace BattagliaNavale
{
    partial class FPosizioneBasi
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
            this.lbl_naviPosizionate = new System.Windows.Forms.Label();
            this.lbl_indicazioni = new System.Windows.Forms.Label();
            this.btn_invia = new System.Windows.Forms.Button();
            this.lbl_quit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Main
            // 
            this.dgv_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Main.Location = new System.Drawing.Point(7, 21);
            this.dgv_Main.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Main.Name = "dgv_Main";
            this.dgv_Main.RowHeadersWidth = 72;
            this.dgv_Main.RowTemplate.Height = 31;
            this.dgv_Main.Size = new System.Drawing.Size(543, 539);
            this.dgv_Main.TabIndex = 0;
            this.dgv_Main.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Main_CellClick);
            // 
            // lbl_naviPosizionate
            // 
            this.lbl_naviPosizionate.AutoSize = true;
            this.lbl_naviPosizionate.Font = new System.Drawing.Font("MV Boli", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_naviPosizionate.Location = new System.Drawing.Point(587, 69);
            this.lbl_naviPosizionate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_naviPosizionate.Name = "lbl_naviPosizionate";
            this.lbl_naviPosizionate.Size = new System.Drawing.Size(0, 25);
            this.lbl_naviPosizionate.TabIndex = 1;
            // 
            // lbl_indicazioni
            // 
            this.lbl_indicazioni.AutoSize = true;
            this.lbl_indicazioni.Font = new System.Drawing.Font("MV Boli", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_indicazioni.Location = new System.Drawing.Point(592, 196);
            this.lbl_indicazioni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_indicazioni.Name = "lbl_indicazioni";
            this.lbl_indicazioni.Size = new System.Drawing.Size(0, 25);
            this.lbl_indicazioni.TabIndex = 2;
            // 
            // btn_invia
            // 
            this.btn_invia.Font = new System.Drawing.Font("MV Boli", 14.14286F, System.Drawing.FontStyle.Bold);
            this.btn_invia.Location = new System.Drawing.Point(597, 338);
            this.btn_invia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_invia.Name = "btn_invia";
            this.btn_invia.Size = new System.Drawing.Size(211, 74);
            this.btn_invia.TabIndex = 3;
            this.btn_invia.Text = "invia!";
            this.btn_invia.UseVisualStyleBackColor = true;
            this.btn_invia.Click += new System.EventHandler(this.btn_invia_Click);
            // 
            // lbl_quit
            // 
            this.lbl_quit.Font = new System.Drawing.Font("MV Boli", 14.14286F, System.Drawing.FontStyle.Bold);
            this.lbl_quit.Location = new System.Drawing.Point(597, 438);
            this.lbl_quit.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_quit.Name = "lbl_quit";
            this.lbl_quit.Size = new System.Drawing.Size(211, 74);
            this.lbl_quit.TabIndex = 4;
            this.lbl_quit.Text = "esci";
            this.lbl_quit.UseVisualStyleBackColor = true;
            this.lbl_quit.Click += new System.EventHandler(this.lbl_quit_Click);
            // 
            // FPosizioneBasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 572);
            this.Controls.Add(this.lbl_quit);
            this.Controls.Add(this.btn_invia);
            this.Controls.Add(this.lbl_indicazioni);
            this.Controls.Add(this.lbl_naviPosizionate);
            this.Controls.Add(this.dgv_Main);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FPosizioneBasi";
            this.Text = "FPosizioneBasi";
            this.Load += new System.EventHandler(this.FPosizioneBasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Main;
        private System.Windows.Forms.Label lbl_naviPosizionate;
        private System.Windows.Forms.Label lbl_indicazioni;
        private System.Windows.Forms.Button btn_invia;
        private System.Windows.Forms.Button lbl_quit;
    }
}