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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Main
            // 
            this.dgv_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Main.Location = new System.Drawing.Point(12, 39);
            this.dgv_Main.Name = "dgv_Main";
            this.dgv_Main.RowHeadersWidth = 72;
            this.dgv_Main.RowTemplate.Height = 31;
            this.dgv_Main.Size = new System.Drawing.Size(995, 995);
            this.dgv_Main.TabIndex = 0;
            this.dgv_Main.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Main_CellClick);
            // 
            // lbl_naviPosizionate
            // 
            this.lbl_naviPosizionate.AutoSize = true;
            this.lbl_naviPosizionate.Font = new System.Drawing.Font("MV Boli", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_naviPosizionate.Location = new System.Drawing.Point(1077, 127);
            this.lbl_naviPosizionate.Name = "lbl_naviPosizionate";
            this.lbl_naviPosizionate.Size = new System.Drawing.Size(0, 45);
            this.lbl_naviPosizionate.TabIndex = 1;
            // 
            // lbl_indicazioni
            // 
            this.lbl_indicazioni.AutoSize = true;
            this.lbl_indicazioni.Font = new System.Drawing.Font("MV Boli", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_indicazioni.Location = new System.Drawing.Point(1086, 362);
            this.lbl_indicazioni.Name = "lbl_indicazioni";
            this.lbl_indicazioni.Size = new System.Drawing.Size(0, 45);
            this.lbl_indicazioni.TabIndex = 2;
            // 
            // btn_invia
            // 
            this.btn_invia.Font = new System.Drawing.Font("MV Boli", 14.14286F, System.Drawing.FontStyle.Bold);
            this.btn_invia.Location = new System.Drawing.Point(1094, 668);
            this.btn_invia.Name = "btn_invia";
            this.btn_invia.Size = new System.Drawing.Size(387, 136);
            this.btn_invia.TabIndex = 3;
            this.btn_invia.Text = "invia!";
            this.btn_invia.UseVisualStyleBackColor = true;
            this.btn_invia.Click += new System.EventHandler(this.btn_invia_Click);
            // 
            // FPosizioneBasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1587, 1056);
            this.Controls.Add(this.btn_invia);
            this.Controls.Add(this.lbl_indicazioni);
            this.Controls.Add(this.lbl_naviPosizionate);
            this.Controls.Add(this.dgv_Main);
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
    }
}