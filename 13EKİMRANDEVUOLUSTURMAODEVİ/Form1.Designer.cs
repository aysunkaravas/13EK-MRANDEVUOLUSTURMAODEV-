namespace _13EKİMRANDEVUOLUSTURMAODEVİ
{
    partial class tabControl1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl2 = new TabControl();
            tabPage1 = new TabPage();
            lblRandevuBil = new Label();
            cbBölümler = new ComboBox();
            lblPolikinlik = new Label();
            dateTimetTarih = new DateTimePicker();
            lblTarih = new Label();
            grpSaat = new GroupBox();
            rb12 = new RadioButton();
            rb14 = new RadioButton();
            rb13 = new RadioButton();
            rb15 = new RadioButton();
            grphastabilgileri = new GroupBox();
            txtTc = new TextBox();
            txtAdSoyad = new TextBox();
            masTelefon = new MaskedTextBox();
            lblTelefon = new Label();
            lblAdSoyad = new Label();
            lblTc = new Label();
            grpCinsiyet = new GroupBox();
            rbdErkek = new RadioButton();
            rbdKadın = new RadioButton();
            btnRandevuOlustur = new Button();
            tabPage2 = new TabPage();
            lstrandevubilgeri = new ListBox();
            tabControl2.SuspendLayout();
            tabPage1.SuspendLayout();
            grpSaat.SuspendLayout();
            grphastabilgileri.SuspendLayout();
            grpCinsiyet.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage1);
            tabControl2.Controls.Add(tabPage2);
            tabControl2.Location = new Point(0, 0);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(438, 724);
            tabControl2.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblRandevuBil);
            tabPage1.Controls.Add(cbBölümler);
            tabPage1.Controls.Add(lblPolikinlik);
            tabPage1.Controls.Add(dateTimetTarih);
            tabPage1.Controls.Add(lblTarih);
            tabPage1.Controls.Add(grpSaat);
            tabPage1.Controls.Add(grphastabilgileri);
            tabPage1.Controls.Add(btnRandevuOlustur);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(430, 691);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Randevu Bilgileri";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // lblRandevuBil
            // 
            lblRandevuBil.AutoSize = true;
            lblRandevuBil.Location = new Point(106, 312);
            lblRandevuBil.Name = "lblRandevuBil";
            lblRandevuBil.Size = new Size(121, 20);
            lblRandevuBil.TabIndex = 47;
            lblRandevuBil.Text = "Randevu Bilgileri";
            // 
            // cbBölümler
            // 
            cbBölümler.FormattingEnabled = true;
            cbBölümler.Items.AddRange(new object[] { "Diş", "Acil", "Göz", "İç Hastalıkları" });
            cbBölümler.Location = new Point(119, 363);
            cbBölümler.Name = "cbBölümler";
            cbBölümler.Size = new Size(151, 28);
            cbBölümler.TabIndex = 48;
            // 
            // lblPolikinlik
            // 
            lblPolikinlik.AutoSize = true;
            lblPolikinlik.Location = new Point(23, 366);
            lblPolikinlik.Name = "lblPolikinlik";
            lblPolikinlik.Size = new Size(67, 20);
            lblPolikinlik.TabIndex = 46;
            lblPolikinlik.Text = "Polikinlik";
            // 
            // dateTimetTarih
            // 
            dateTimetTarih.Location = new Point(116, 413);
            dateTimetTarih.Name = "dateTimetTarih";
            dateTimetTarih.Size = new Size(250, 27);
            dateTimetTarih.TabIndex = 45;
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Location = new Point(23, 418);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(40, 20);
            lblTarih.TabIndex = 44;
            lblTarih.Text = "Tarih";
            // 
            // grpSaat
            // 
            grpSaat.Controls.Add(rb12);
            grpSaat.Controls.Add(rb14);
            grpSaat.Controls.Add(rb13);
            grpSaat.Controls.Add(rb15);
            grpSaat.Location = new Point(106, 459);
            grpSaat.Name = "grpSaat";
            grpSaat.Size = new Size(250, 105);
            grpSaat.TabIndex = 43;
            grpSaat.TabStop = false;
            // 
            // rb12
            // 
            rb12.AutoSize = true;
            rb12.Location = new Point(17, 26);
            rb12.Name = "rb12";
            rb12.Size = new Size(65, 24);
            rb12.TabIndex = 38;
            rb12.TabStop = true;
            rb12.Text = "12:00";
            rb12.UseVisualStyleBackColor = true;
            // 
            // rb14
            // 
            rb14.AutoSize = true;
            rb14.Location = new Point(17, 65);
            rb14.Name = "rb14";
            rb14.Size = new Size(65, 24);
            rb14.TabIndex = 37;
            rb14.TabStop = true;
            rb14.Text = "14:00";
            rb14.UseVisualStyleBackColor = true;
            // 
            // rb13
            // 
            rb13.AutoSize = true;
            rb13.Location = new Point(115, 26);
            rb13.Name = "rb13";
            rb13.Size = new Size(65, 24);
            rb13.TabIndex = 39;
            rb13.TabStop = true;
            rb13.Text = "13:00";
            rb13.UseVisualStyleBackColor = true;
            // 
            // rb15
            // 
            rb15.AutoSize = true;
            rb15.Location = new Point(115, 62);
            rb15.Name = "rb15";
            rb15.Size = new Size(65, 24);
            rb15.TabIndex = 36;
            rb15.TabStop = true;
            rb15.Text = "15:00";
            rb15.UseVisualStyleBackColor = true;
            // 
            // grphastabilgileri
            // 
            grphastabilgileri.Controls.Add(txtTc);
            grphastabilgileri.Controls.Add(txtAdSoyad);
            grphastabilgileri.Controls.Add(masTelefon);
            grphastabilgileri.Controls.Add(lblTelefon);
            grphastabilgileri.Controls.Add(lblAdSoyad);
            grphastabilgileri.Controls.Add(lblTc);
            grphastabilgileri.Controls.Add(grpCinsiyet);
            grphastabilgileri.Location = new Point(8, 6);
            grphastabilgileri.Name = "grphastabilgileri";
            grphastabilgileri.Size = new Size(250, 294);
            grphastabilgileri.TabIndex = 42;
            grphastabilgileri.TabStop = false;
            grphastabilgileri.Text = "Hasta Bilgileri";
            // 
            // txtTc
            // 
            txtTc.Location = new Point(98, 50);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(125, 27);
            txtTc.TabIndex = 6;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(98, 88);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(125, 27);
            txtAdSoyad.TabIndex = 5;
            // 
            // masTelefon
            // 
            masTelefon.Location = new Point(98, 135);
            masTelefon.Mask = "(999) 000-0000";
            masTelefon.Name = "masTelefon";
            masTelefon.Size = new Size(125, 27);
            masTelefon.TabIndex = 4;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(12, 138);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(58, 20);
            lblTelefon.TabIndex = 3;
            lblTelefon.Text = "Telefon";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(12, 91);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(73, 20);
            lblAdSoyad.TabIndex = 2;
            lblAdSoyad.Text = "Ad Soyad";
            // 
            // lblTc
            // 
            lblTc.AutoSize = true;
            lblTc.Location = new Point(12, 57);
            lblTc.Name = "lblTc";
            lblTc.Size = new Size(25, 20);
            lblTc.TabIndex = 1;
            lblTc.Text = "TC";
            // 
            // grpCinsiyet
            // 
            grpCinsiyet.Controls.Add(rbdErkek);
            grpCinsiyet.Controls.Add(rbdKadın);
            grpCinsiyet.Location = new Point(12, 203);
            grpCinsiyet.Name = "grpCinsiyet";
            grpCinsiyet.Size = new Size(250, 67);
            grpCinsiyet.TabIndex = 0;
            grpCinsiyet.TabStop = false;
            grpCinsiyet.Text = "Cinsiyet";
            // 
            // rbdErkek
            // 
            rbdErkek.AutoSize = true;
            rbdErkek.Location = new Point(99, 26);
            rbdErkek.Name = "rbdErkek";
            rbdErkek.Size = new Size(65, 24);
            rbdErkek.TabIndex = 7;
            rbdErkek.TabStop = true;
            rbdErkek.Text = "Erkek";
            rbdErkek.UseVisualStyleBackColor = true;
            // 
            // rbdKadın
            // 
            rbdKadın.AutoSize = true;
            rbdKadın.Location = new Point(6, 26);
            rbdKadın.Name = "rbdKadın";
            rbdKadın.Size = new Size(68, 24);
            rbdKadın.TabIndex = 8;
            rbdKadın.TabStop = true;
            rbdKadın.Text = "Kadın";
            rbdKadın.UseVisualStyleBackColor = true;
            // 
            // btnRandevuOlustur
            // 
            btnRandevuOlustur.Location = new Point(116, 583);
            btnRandevuOlustur.Name = "btnRandevuOlustur";
            btnRandevuOlustur.Size = new Size(212, 29);
            btnRandevuOlustur.TabIndex = 41;
            btnRandevuOlustur.Text = "Randevu Oluştur";
            btnRandevuOlustur.UseVisualStyleBackColor = true;
            btnRandevuOlustur.Click += btnRandevuOlustur_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lstrandevubilgeri);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(430, 691);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Randevularım";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstrandevubilgeri
            // 
            lstrandevubilgeri.FormattingEnabled = true;
            lstrandevubilgeri.ItemHeight = 20;
            lstrandevubilgeri.Location = new Point(8, 24);
            lstrandevubilgeri.Name = "lstrandevubilgeri";
            lstrandevubilgeri.Size = new Size(370, 264);
            lstrandevubilgeri.TabIndex = 1;
            lstrandevubilgeri.SelectedIndexChanged += lstrandevubilgeri_SelectedIndexChanged;
            lstrandevubilgeri.DoubleClick += lstrandevubilgeri_DoubleClick;
            // 
            // tabControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 752);
            Controls.Add(tabControl2);
            Name = "tabControl1";
            Text = "Form1";
            tabControl2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            grpSaat.ResumeLayout(false);
            grpSaat.PerformLayout();
            grphastabilgileri.ResumeLayout(false);
            grphastabilgileri.PerformLayout();
            grpCinsiyet.ResumeLayout(false);
            grpCinsiyet.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl2;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label lblRandevuBil;
        private ComboBox cbBölümler;
        private Label lblPolikinlik;
        private DateTimePicker dateTimetTarih;
        private Label lblTarih;
        private GroupBox grpSaat;
        private RadioButton rb12;
        private RadioButton rb14;
        private RadioButton rb13;
        private RadioButton rb15;
        private GroupBox grphastabilgileri;
        private TextBox txtTc;
        private TextBox txtAdSoyad;
        private MaskedTextBox masTelefon;
        private Label lblTelefon;
        private Label lblAdSoyad;
        private Label lblTc;
        private GroupBox grpCinsiyet;
        private RadioButton rbdErkek;
        private RadioButton rbdKadın;
        private Button btnRandevuOlustur;
        private ListBox lstrandevubilgeri;
    }
}