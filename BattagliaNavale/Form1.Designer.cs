namespace BattagliaNavale
{
    partial class Form1
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
            this.lbl_Titolo = new System.Windows.Forms.Label();
            this.btn_1v0 = new System.Windows.Forms.Button();
            this.btn_1v1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Titolo
            // 
            this.lbl_Titolo.AutoSize = true;
            this.lbl_Titolo.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titolo.Location = new System.Drawing.Point(188, 138);
            this.lbl_Titolo.Name = "lbl_Titolo";
            this.lbl_Titolo.Size = new System.Drawing.Size(477, 56);
            this.lbl_Titolo.TabIndex = 0;
            this.lbl_Titolo.Text = "BATTAGLIA NAVALE!";
            // 
            // btn_1v0
            // 
            this.btn_1v0.Font = new System.Drawing.Font("MV Boli", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1v0.Location = new System.Drawing.Point(56, 307);
            this.btn_1v0.Name = "btn_1v0";
            this.btn_1v0.Size = new System.Drawing.Size(343, 164);
            this.btn_1v0.TabIndex = 1;
            this.btn_1v0.Text = "Giocatore singolo";
            this.btn_1v0.UseVisualStyleBackColor = true;
            // 
            // btn_1v1
            // 
            this.btn_1v1.Font = new System.Drawing.Font("MV Boli", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1v1.Location = new System.Drawing.Point(472, 307);
            this.btn_1v1.Name = "btn_1v1";
            this.btn_1v1.Size = new System.Drawing.Size(343, 164);
            this.btn_1v1.TabIndex = 2;
            this.btn_1v1.Text = "1 V.S. 1";
            this.btn_1v1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 698);
            this.Controls.Add(this.btn_1v1);
            this.Controls.Add(this.btn_1v0);
            this.Controls.Add(this.lbl_Titolo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titolo;
        private System.Windows.Forms.Button btn_1v0;
        private System.Windows.Forms.Button btn_1v1;
    }
}

