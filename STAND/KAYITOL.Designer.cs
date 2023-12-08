namespace STAND
{
    partial class KAYITOL
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
            this.LBLAD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_kyt = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_sfr = new System.Windows.Forms.TextBox();
            this.tx_kadi = new System.Windows.Forms.TextBox();
            this.tx_syd = new System.Windows.Forms.TextBox();
            this.tx_sfr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLAD
            // 
            this.LBLAD.AutoSize = true;
            this.LBLAD.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LBLAD.Location = new System.Drawing.Point(12, 36);
            this.LBLAD.Name = "LBLAD";
            this.LBLAD.Size = new System.Drawing.Size(22, 13);
            this.LBLAD.TabIndex = 1;
            this.LBLAD.Text = "AD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SOYAD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::STAND.Properties.Resources.images__2_;
            this.pictureBox1.Location = new System.Drawing.Point(232, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "KULLANICI ADI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SİFRE";
            // 
            // btn_kyt
            // 
            this.btn_kyt.Location = new System.Drawing.Point(12, 226);
            this.btn_kyt.Name = "btn_kyt";
            this.btn_kyt.Size = new System.Drawing.Size(114, 47);
            this.btn_kyt.TabIndex = 5;
            this.btn_kyt.Text = "KAYIT OL";
            this.btn_kyt.UseVisualStyleBackColor = true;
            this.btn_kyt.Click += new System.EventHandler(this.btn_kyt_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::STAND.Properties.Resources.indir__1_1;
            this.pictureBox2.Location = new System.Drawing.Point(232, 214);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 160);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // txt_sfr
            // 
            this.txt_sfr.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_sfr.Location = new System.Drawing.Point(56, 141);
            this.txt_sfr.MaxLength = 20;
            this.txt_sfr.Name = "txt_sfr";
            this.txt_sfr.PasswordChar = '*';
            this.txt_sfr.Size = new System.Drawing.Size(100, 20);
            this.txt_sfr.TabIndex = 7;
            this.txt_sfr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sfr_KeyPress);
            // 
            // tx_kadi
            // 
            this.tx_kadi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tx_kadi.Location = new System.Drawing.Point(101, 106);
            this.tx_kadi.MaxLength = 11;
            this.tx_kadi.Name = "tx_kadi";
            this.tx_kadi.Size = new System.Drawing.Size(100, 20);
            this.tx_kadi.TabIndex = 8;
            this.tx_kadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // tx_syd
            // 
            this.tx_syd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tx_syd.Location = new System.Drawing.Point(71, 67);
            this.tx_syd.MaxLength = 10;
            this.tx_syd.Name = "tx_syd";
            this.tx_syd.Size = new System.Drawing.Size(100, 20);
            this.tx_syd.TabIndex = 9;
            this.tx_syd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // tx_sfr
            // 
            this.tx_sfr.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tx_sfr.Location = new System.Drawing.Point(51, 33);
            this.tx_sfr.MaxLength = 15;
            this.tx_sfr.Name = "tx_sfr";
            this.tx_sfr.Size = new System.Drawing.Size(100, 20);
            this.tx_sfr.TabIndex = 10;
            this.tx_sfr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_sfr_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Location = new System.Drawing.Point(3, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "LUTFEN SIFRENIZ 8 HANEDEN AZ OLSUN";
            // 
            // KAYITOL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(411, 386);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_sfr);
            this.Controls.Add(this.tx_syd);
            this.Controls.Add(this.tx_kadi);
            this.Controls.Add(this.txt_sfr);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_kyt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBLAD);
            this.Controls.Add(this.pictureBox1);
            this.Name = "KAYITOL";
            this.Text = "KAYITOL";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBLAD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_kyt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_sfr;
        private System.Windows.Forms.TextBox tx_kadi;
        private System.Windows.Forms.TextBox tx_syd;
        private System.Windows.Forms.TextBox tx_sfr;
        private System.Windows.Forms.Label label4;
    }
}