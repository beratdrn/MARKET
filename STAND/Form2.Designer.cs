namespace STAND
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.txt_add = new System.Windows.Forms.TextBox();
            this.txt_syd = new System.Windows.Forms.TextBox();
            this.txt_no = new System.Windows.Forms.TextBox();
            this.txt_cvv = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::STAND.Properties.Resources.gg;
            this.pictureBox1.Location = new System.Drawing.Point(250, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADINIZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SOYADINIZ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "KART NO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "SON KULLANMA TARİHİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "CVV";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 190);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(204, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Sözleşmeyi ve Şartları Kabul Ediyorum";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "ONAYLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(24, 213);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(83, 17);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Kartı Kaydet";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // txt_add
            // 
            this.txt_add.Location = new System.Drawing.Point(70, 31);
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(100, 20);
            this.txt_add.TabIndex = 9;
            this.txt_add.TextChanged += new System.EventHandler(this.txt_add_TextChanged);
            this.txt_add.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ad);
            // 
            // txt_syd
            // 
            this.txt_syd.Location = new System.Drawing.Point(92, 61);
            this.txt_syd.Name = "txt_syd";
            this.txt_syd.Size = new System.Drawing.Size(100, 20);
            this.txt_syd.TabIndex = 10;
            this.txt_syd.TextChanged += new System.EventHandler(this.txt_syd_TextChanged);
            this.txt_syd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sydky);
            // 
            // txt_no
            // 
            this.txt_no.Location = new System.Drawing.Point(82, 87);
            this.txt_no.MaxLength = 11;
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(100, 20);
            this.txt_no.TabIndex = 11;
            this.txt_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_noKeyPress);
            // 
            // txt_cvv
            // 
            this.txt_cvv.Location = new System.Drawing.Point(55, 146);
            this.txt_cvv.MaxLength = 3;
            this.txt_cvv.Name = "txt_cvv";
            this.txt_cvv.Size = new System.Drawing.Size(72, 20);
            this.txt_cvv.TabIndex = 13;
            this.txt_cvv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cvvKeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::STAND.Properties.Resources.fff;
            this.pictureBox2.Location = new System.Drawing.Point(250, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 120);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 12, 8, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2023, 12, 8, 0, 0, 0, 0);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(424, 367);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_cvv);
            this.Controls.Add(this.txt_no);
            this.Controls.Add(this.txt_syd);
            this.Controls.Add(this.txt_add);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "KARTONAY";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox txt_add;
        private System.Windows.Forms.TextBox txt_syd;
        private System.Windows.Forms.TextBox txt_no;
        private System.Windows.Forms.TextBox txt_cvv;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}