﻿namespace parcalar
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
            this.lstSebze = new System.Windows.Forms.ListBox();
            this.lstMeyve = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAktar = new System.Windows.Forms.Button();
            this.lstMahsul = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstSebze
            // 
            this.lstSebze.FormattingEnabled = true;
            this.lstSebze.Location = new System.Drawing.Point(186, 63);
            this.lstSebze.Name = "lstSebze";
            this.lstSebze.Size = new System.Drawing.Size(125, 160);
            this.lstSebze.TabIndex = 0;
            // 
            // lstMeyve
            // 
            this.lstMeyve.FormattingEnabled = true;
            this.lstMeyve.Location = new System.Drawing.Point(362, 63);
            this.lstMeyve.Name = "lstMeyve";
            this.lstMeyve.Size = new System.Drawing.Size(127, 160);
            this.lstMeyve.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(183, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sebze";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(359, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Meyve";
            // 
            // btnAktar
            // 
            this.btnAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAktar.Location = new System.Drawing.Point(186, 241);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(109, 38);
            this.btnAktar.TabIndex = 5;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // lstMahsul
            // 
            this.lstMahsul.FormattingEnabled = true;
            this.lstMahsul.Items.AddRange(new object[] {
            "Brokoli",
            "Pırasa",
            "Havuç"});
            this.lstMahsul.Location = new System.Drawing.Point(12, 63);
            this.lstMahsul.Name = "lstMahsul";
            this.lstMahsul.Size = new System.Drawing.Size(120, 160);
            this.lstMahsul.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mahsul";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 291);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstMahsul);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMeyve);
            this.Controls.Add(this.lstSebze);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSebze;
        private System.Windows.Forms.ListBox lstMeyve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.ListBox lstMahsul;
        private System.Windows.Forms.Label label3;
    }
}

