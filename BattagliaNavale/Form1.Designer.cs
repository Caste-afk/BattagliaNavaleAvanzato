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
            this.SuspendLayout();
            // 
            // lbl_Titolo
            // 
            this.lbl_Titolo.AutoSize = true;
            this.lbl_Titolo.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titolo.Location = new System.Drawing.Point(206, 144);
            this.lbl_Titolo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Titolo.Name = "lbl_Titolo";
            this.lbl_Titolo.Size = new System.Drawing.Size(543, 63);
            this.lbl_Titolo.TabIndex = 0;
            this.lbl_Titolo.Text = "BATTAGLIA NAVALE!";
            // 
            // btn_1v0
            // 
            this.btn_1v0.Font = new System.Drawing.Font("MV Boli", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1v0.Location = new System.Drawing.Point(293, 269);
            this.btn_1v0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_1v0.Name = "btn_1v0";
            this.btn_1v0.Size = new System.Drawing.Size(374, 171);
            this.btn_1v0.TabIndex = 1;
            this.btn_1v0.Text = "Gioca!";
            this.btn_1v0.UseVisualStyleBackColor = true;
            this.btn_1v0.Click += new System.EventHandler(this.btn_1v0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 727);
            this.Controls.Add(this.btn_1v0);
            this.Controls.Add(this.lbl_Titolo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titolo;
        private System.Windows.Forms.Button btn_1v0;
    }
}

