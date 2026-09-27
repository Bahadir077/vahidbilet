namespace vahid_bilet
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblBasliq;
        private System.Windows.Forms.Label lblMenbe;
        private System.Windows.Forms.Label lblTeyinat;
        private System.Windows.Forms.Label lblTarix;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblYer;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefon;

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker tarix;
        private System.Windows.Forms.ComboBox saat;
        private System.Windows.Forms.TextBox yer;
        private System.Windows.Forms.TextBox adsoyad;
        private System.Windows.Forms.TextBox fin;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.MaskedTextBox telefon;

        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblBasliq = new Label();
            lblMenbe = new Label();
            lblTeyinat = new Label();
            lblTarix = new Label();
            lblSaat = new Label();
            lblYer = new Label();
            lblAdSoyad = new Label();
            lblFin = new Label();
            lblEmail = new Label();
            lblTelefon = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            tarix = new DateTimePicker();
            saat = new ComboBox();
            yer = new TextBox();
            adsoyad = new TextBox();
            fin = new TextBox();
            email = new TextBox();
            telefon = new MaskedTextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // lblBasliq
            // 
            lblBasliq.AutoSize = true;
            lblBasliq.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblBasliq.Location = new Point(270, 20);
            lblBasliq.Name = "lblBasliq";
            lblBasliq.Size = new Size(323, 41);
            lblBasliq.TabIndex = 0;
            lblBasliq.Text = "VAHİD BİLET SİSTEMİ";
            // 
            // lblMenbe
            // 
            lblMenbe.AutoSize = true;
            lblMenbe.Location = new Point(35, 85);
            lblMenbe.Name = "lblMenbe";
            lblMenbe.Size = new Size(69, 20);
            lblMenbe.TabIndex = 1;
            lblMenbe.Text = "Haradan:";
            // 
            // lblTeyinat
            // 
            lblTeyinat.AutoSize = true;
            lblTeyinat.Location = new Point(415, 85);
            lblTeyinat.Name = "lblTeyinat";
            lblTeyinat.Size = new Size(59, 20);
            lblTeyinat.TabIndex = 4;
            lblTeyinat.Text = "Haraya:";
            // 
            // lblTarix
            // 
            lblTarix.AutoSize = true;
            lblTarix.Location = new Point(35, 130);
            lblTarix.Name = "lblTarix";
            lblTarix.Size = new Size(42, 20);
            lblTarix.TabIndex = 6;
            lblTarix.Text = "Tarix:";
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.Location = new Point(415, 130);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(41, 20);
            lblSaat.TabIndex = 8;
            lblSaat.Text = "Saat:";
            // 
            // lblYer
            // 
            lblYer.AutoSize = true;
            lblYer.Location = new Point(35, 175);
            lblYer.Name = "lblYer";
            lblYer.Size = new Size(89, 20);
            lblYer.TabIndex = 10;
            lblYer.Text = "Yer nömrəsi:";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(415, 175);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(93, 20);
            lblAdSoyad.TabIndex = 12;
            lblAdSoyad.Text = "Ad və soyad:";
            // 
            // lblFin
            // 
            lblFin.AutoSize = true;
            lblFin.Location = new Point(35, 220);
            lblFin.Name = "lblFin";
            lblFin.Size = new Size(63, 20);
            lblFin.TabIndex = 14;
            lblFin.Text = "FIN kod:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(415, 220);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Email:";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(35, 265);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(61, 20);
            lblTelefon.TabIndex = 18;
            lblTelefon.Text = "Telefon:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bakı", "Gəncə", "Sumqayıt", "Şəki", "Qəbələ", "Lənkəran" });
            comboBox1.Location = new Point(140, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 28);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Bakı", "Gəncə", "Sumqayıt", "Şəki", "Qəbələ", "Lənkəran" });
            comboBox2.Location = new Point(510, 82);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 28);
            comboBox2.TabIndex = 5;
            // 
            // tarix
            // 
            tarix.Format = DateTimePickerFormat.Short;
            tarix.Location = new Point(140, 127);
            tarix.Name = "tarix";
            tarix.Size = new Size(200, 27);
            tarix.TabIndex = 7;
            tarix.ValueChanged += tarix_ValueChanged;
            // 
            // saat
            // 
            saat.DropDownStyle = ComboBoxStyle.DropDownList;
            saat.Items.AddRange(new object[] { "08:00", "10:00", "12:00", "14:00", "16:00", "18:00", "20:00" });
            saat.Location = new Point(510, 127);
            saat.Name = "saat";
            saat.Size = new Size(200, 28);
            saat.TabIndex = 9;
            // 
            // yer
            // 
            yer.Location = new Point(140, 172);
            yer.Name = "yer";
            yer.Size = new Size(200, 27);
            yer.TabIndex = 11;
            // 
            // adsoyad
            // 
            adsoyad.Location = new Point(510, 172);
            adsoyad.Name = "adsoyad";
            adsoyad.Size = new Size(200, 27);
            adsoyad.TabIndex = 13;
            // 
            // fin
            // 
            fin.Location = new Point(140, 217);
            fin.MaxLength = 7;
            fin.Name = "fin";
            fin.Size = new Size(200, 27);
            fin.TabIndex = 15;
            // 
            // email
            // 
            email.Location = new Point(510, 217);
            email.Name = "email";
            email.Size = new Size(200, 27);
            email.TabIndex = 17;
            // 
            // telefon
            // 
            telefon.Location = new Point(140, 262);
            telefon.Mask = "+000 (00) 000-00-00";
            telefon.Name = "telefon";
            telefon.Size = new Size(200, 27);
            telefon.TabIndex = 19;
            telefon.MaskInputRejected += telefon_MaskInputRejected;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.Location = new Point(35, 320);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.Size = new Size(675, 184);
            listBox1.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(355, 80);
            button1.Name = "button1";
            button1.Size = new Size(45, 28);
            button1.TabIndex = 3;
            button1.Text = "⇄";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(510, 258);
            button2.Name = "button2";
            button2.Size = new Size(200, 32);
            button2.TabIndex = 20;
            button2.Text = "Bilet əlavə et";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(35, 540);
            button3.Name = "button3";
            button3.Size = new Size(200, 35);
            button3.TabIndex = 22;
            button3.Text = "Seçilmiş bileti sil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(510, 540);
            button4.Name = "button4";
            button4.Size = new Size(200, 35);
            button4.TabIndex = 23;
            button4.Text = "Çıxış";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 610);
            Controls.Add(lblBasliq);
            Controls.Add(lblMenbe);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(lblTeyinat);
            Controls.Add(comboBox2);
            Controls.Add(lblTarix);
            Controls.Add(tarix);
            Controls.Add(lblSaat);
            Controls.Add(saat);
            Controls.Add(lblYer);
            Controls.Add(yer);
            Controls.Add(lblAdSoyad);
            Controls.Add(adsoyad);
            Controls.Add(lblFin);
            Controls.Add(fin);
            Controls.Add(lblEmail);
            Controls.Add(email);
            Controls.Add(lblTelefon);
            Controls.Add(telefon);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vahid Bilet";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}