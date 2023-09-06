namespace Proje_Hastane
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTChasta = new System.Windows.Forms.MaskedTextBox();
            this.txtSifreHasta = new System.Windows.Forms.TextBox();
            this.linkLblUyelik = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // mskTChasta
            // 
            this.mskTChasta.Location = new System.Drawing.Point(154, 51);
            this.mskTChasta.Margin = new System.Windows.Forms.Padding(4);
            this.mskTChasta.Mask = "00000000000";
            this.mskTChasta.Name = "mskTChasta";
            this.mskTChasta.Size = new System.Drawing.Size(127, 26);
            this.mskTChasta.TabIndex = 0;
            // 
            // txtSifreHasta
            // 
            this.txtSifreHasta.Location = new System.Drawing.Point(154, 108);
            this.txtSifreHasta.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifreHasta.Name = "txtSifreHasta";
            this.txtSifreHasta.Size = new System.Drawing.Size(127, 26);
            this.txtSifreHasta.TabIndex = 1;
            this.txtSifreHasta.UseSystemPasswordChar = true;
            // 
            // linkLblUyelik
            // 
            this.linkLblUyelik.AutoSize = true;
            this.linkLblUyelik.Location = new System.Drawing.Point(133, 221);
            this.linkLblUyelik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLblUyelik.Name = "linkLblUyelik";
            this.linkLblUyelik.Size = new System.Drawing.Size(213, 19);
            this.linkLblUyelik.TabIndex = 3;
            this.linkLblUyelik.TabStop = true;
            this.linkLblUyelik.Text = "Buraya tıklayarak üye olabilirsiniz.";
            this.linkLblUyelik.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblUyelik_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(164, 155);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proje_Hastane.Properties.Resources._848688_200;
            this.pictureBox1.Location = new System.Drawing.Point(320, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmHastaGiris
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(513, 259);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLblUyelik);
            this.Controls.Add(this.txtSifreHasta);
            this.Controls.Add(this.mskTChasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmHastaGiris";
            this.Text = "Hasta Giriş Paneli";
            this.Load += new System.EventHandler(this.FrmHastaGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTChasta;
        private System.Windows.Forms.TextBox txtSifreHasta;
        private System.Windows.Forms.LinkLabel linkLblUyelik;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}