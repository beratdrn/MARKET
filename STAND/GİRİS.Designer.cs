namespace STAND
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nck = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_psw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_kayıt = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_grs = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "BERAT MARKETE  HOŞGELDİNİZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "KULLANICI ADI";
            // 
            // txt_nck
            // 
            this.txt_nck.Location = new System.Drawing.Point(101, 70);
            this.txt_nck.MaxLength = 15;
            this.txt_nck.Name = "txt_nck";
            this.txt_nck.Size = new System.Drawing.Size(134, 20);
            this.txt_nck.TabIndex = 3;
            this.txt_nck.TextChanged += new System.EventHandler(this.txt_nck_TextChanged);
            this.txt_nck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nıck);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ŞİFRE";
            // 
            // txt_psw
            // 
            this.txt_psw.Location = new System.Drawing.Point(63, 104);
            this.txt_psw.MaxLength = 20;
            this.txt_psw.Name = "txt_psw";
            this.txt_psw.PasswordChar = '*';
            this.txt_psw.Size = new System.Drawing.Size(135, 20);
            this.txt_psw.TabIndex = 5;
            this.txt_psw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_psww);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "SİPARİŞ VERİCEK HESABIN YOK MU?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_kayıt
            // 
            this.lbl_kayıt.AutoSize = true;
            this.lbl_kayıt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_kayıt.Location = new System.Drawing.Point(21, 361);
            this.lbl_kayıt.Name = "lbl_kayıt";
            this.lbl_kayıt.Size = new System.Drawing.Size(123, 13);
            this.lbl_kayıt.TabIndex = 7;
            this.lbl_kayıt.TabStop = true;
            this.lbl_kayıt.Text = "buraya tıklayarak kayıt ol";
            this.lbl_kayıt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_kayıt_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::STAND.Properties.Resources.indir__1_1;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_grs
            // 
            this.btn_grs.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_grs.Location = new System.Drawing.Point(277, 70);
            this.btn_grs.Name = "btn_grs";
            this.btn_grs.Size = new System.Drawing.Size(143, 56);
            this.btn_grs.TabIndex = 8;
            this.btn_grs.Text = "GIRIS YAP";
            this.btn_grs.UseVisualStyleBackColor = false;
            this.btn_grs.Click += new System.EventHandler(this.btn_grs_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::STAND.Properties.Resources.indir__2_;
            this.pictureBox2.Location = new System.Drawing.Point(1, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(477, 172);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 420);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_grs);
            this.Controls.Add(this.lbl_kayıt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_psw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "GİRİS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_psw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lbl_kayıt;
        private System.Windows.Forms.Button btn_grs;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

