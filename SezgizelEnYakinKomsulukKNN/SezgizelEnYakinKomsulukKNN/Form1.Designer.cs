namespace SezgizelEnYakinKomsulukKNN
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxSecilenler = new System.Windows.Forms.ListBox();
            this.groupBoxIslemAdimlari = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxIslemler = new System.Windows.Forms.ListBox();
            this.listBoxPopulasyon = new System.Windows.Forms.ListBox();
            this.textBoxMutasyonKatsayi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxIslemleriGor = new System.Windows.Forms.CheckBox();
            this.comboBoxBireySec = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxGenAdeti = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxMutosyon = new System.Windows.Forms.ComboBox();
            this.comboBoxFonksiyon = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIterasyonSayisi = new System.Windows.Forms.TextBox();
            this.listBoxSonPopulasyon = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.testBtn = new System.Windows.Forms.Button();
            this.egitimBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPopulasyonSayisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxGrafik = new System.Windows.Forms.GroupBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBoxIslemAdimlari.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxGrafik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(711, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Son  Populasyon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "İlk Populasyon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(885, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Populasyonlar";
            // 
            // listBoxSecilenler
            // 
            this.listBoxSecilenler.FormattingEnabled = true;
            this.listBoxSecilenler.HorizontalScrollbar = true;
            this.listBoxSecilenler.Location = new System.Drawing.Point(608, 37);
            this.listBoxSecilenler.Name = "listBoxSecilenler";
            this.listBoxSecilenler.Size = new System.Drawing.Size(649, 238);
            this.listBoxSecilenler.TabIndex = 15;
            // 
            // groupBoxIslemAdimlari
            // 
            this.groupBoxIslemAdimlari.Controls.Add(this.label5);
            this.groupBoxIslemAdimlari.Controls.Add(this.listBoxSecilenler);
            this.groupBoxIslemAdimlari.Controls.Add(this.label3);
            this.groupBoxIslemAdimlari.Controls.Add(this.listBoxIslemler);
            this.groupBoxIslemAdimlari.Location = new System.Drawing.Point(0, -1);
            this.groupBoxIslemAdimlari.Name = "groupBoxIslemAdimlari";
            this.groupBoxIslemAdimlari.Size = new System.Drawing.Size(1267, 287);
            this.groupBoxIslemAdimlari.TabIndex = 23;
            this.groupBoxIslemAdimlari.TabStop = false;
            this.groupBoxIslemAdimlari.Text = "Yeni Populasyon İçin Genetik Algoritma İşlemleri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(229, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yapılan İşlemler";
            // 
            // listBoxIslemler
            // 
            this.listBoxIslemler.FormattingEnabled = true;
            this.listBoxIslemler.HorizontalScrollbar = true;
            this.listBoxIslemler.Location = new System.Drawing.Point(6, 37);
            this.listBoxIslemler.Name = "listBoxIslemler";
            this.listBoxIslemler.Size = new System.Drawing.Size(596, 238);
            this.listBoxIslemler.TabIndex = 5;
            // 
            // listBoxPopulasyon
            // 
            this.listBoxPopulasyon.FormattingEnabled = true;
            this.listBoxPopulasyon.HorizontalScrollbar = true;
            this.listBoxPopulasyon.Location = new System.Drawing.Point(6, 38);
            this.listBoxPopulasyon.Name = "listBoxPopulasyon";
            this.listBoxPopulasyon.Size = new System.Drawing.Size(482, 264);
            this.listBoxPopulasyon.TabIndex = 7;
            // 
            // textBoxMutasyonKatsayi
            // 
            this.textBoxMutasyonKatsayi.Location = new System.Drawing.Point(155, 114);
            this.textBoxMutasyonKatsayi.Name = "textBoxMutasyonKatsayi";
            this.textBoxMutasyonKatsayi.Size = new System.Drawing.Size(140, 20);
            this.textBoxMutasyonKatsayi.TabIndex = 18;
            this.textBoxMutasyonKatsayi.Text = "0,02";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Mutasyon Katsayısı";
            // 
            // checkBoxIslemleriGor
            // 
            this.checkBoxIslemleriGor.AutoSize = true;
            this.checkBoxIslemleriGor.Location = new System.Drawing.Point(155, 242);
            this.checkBoxIslemleriGor.Name = "checkBoxIslemleriGor";
            this.checkBoxIslemleriGor.Size = new System.Drawing.Size(129, 17);
            this.checkBoxIslemleriGor.TabIndex = 16;
            this.checkBoxIslemleriGor.Text = "Yapılan Her Adımı Gör";
            this.checkBoxIslemleriGor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxIslemleriGor.UseVisualStyleBackColor = true;
            // 
            // comboBoxBireySec
            // 
            this.comboBoxBireySec.FormattingEnabled = true;
            this.comboBoxBireySec.Items.AddRange(new object[] {
            "Karisik",
            "Rulet",
            "Rastgele",
            "Turnuva",
            "Deterministik"});
            this.comboBoxBireySec.Location = new System.Drawing.Point(155, 137);
            this.comboBoxBireySec.Name = "comboBoxBireySec";
            this.comboBoxBireySec.Size = new System.Drawing.Size(140, 21);
            this.comboBoxBireySec.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Birey Seç";
            // 
            // textBoxGenAdeti
            // 
            this.textBoxGenAdeti.Location = new System.Drawing.Point(155, 13);
            this.textBoxGenAdeti.Name = "textBoxGenAdeti";
            this.textBoxGenAdeti.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGenAdeti.Size = new System.Drawing.Size(140, 20);
            this.textBoxGenAdeti.TabIndex = 1;
            this.textBoxGenAdeti.Text = "5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Gen Sayısı";
            // 
            // comboBoxMutosyon
            // 
            this.comboBoxMutosyon.FormattingEnabled = true;
            this.comboBoxMutosyon.Items.AddRange(new object[] {
            "Karisik",
            "Toplama",
            "Cikarma"});
            this.comboBoxMutosyon.Location = new System.Drawing.Point(155, 87);
            this.comboBoxMutosyon.Name = "comboBoxMutosyon";
            this.comboBoxMutosyon.Size = new System.Drawing.Size(140, 21);
            this.comboBoxMutosyon.TabIndex = 5;
            // 
            // comboBoxFonksiyon
            // 
            this.comboBoxFonksiyon.FormattingEnabled = true;
            this.comboBoxFonksiyon.Items.AddRange(new object[] {
            "Oklit",
            "Manhattan",
            "Minkovski"});
            this.comboBoxFonksiyon.Location = new System.Drawing.Point(155, 61);
            this.comboBoxFonksiyon.Name = "comboBoxFonksiyon";
            this.comboBoxFonksiyon.Size = new System.Drawing.Size(140, 21);
            this.comboBoxFonksiyon.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Fonksiyon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "İterasyon Sayısı";
            // 
            // textBoxIterasyonSayisi
            // 
            this.textBoxIterasyonSayisi.Location = new System.Drawing.Point(155, 163);
            this.textBoxIterasyonSayisi.Name = "textBoxIterasyonSayisi";
            this.textBoxIterasyonSayisi.Size = new System.Drawing.Size(140, 20);
            this.textBoxIterasyonSayisi.TabIndex = 7;
            this.textBoxIterasyonSayisi.Text = "1";
            // 
            // listBoxSonPopulasyon
            // 
            this.listBoxSonPopulasyon.FormattingEnabled = true;
            this.listBoxSonPopulasyon.HorizontalScrollbar = true;
            this.listBoxSonPopulasyon.Location = new System.Drawing.Point(495, 38);
            this.listBoxSonPopulasyon.Name = "listBoxSonPopulasyon";
            this.listBoxSonPopulasyon.Size = new System.Drawing.Size(452, 264);
            this.listBoxSonPopulasyon.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBoxIslemleriGor);
            this.groupBox1.Controls.Add(this.testBtn);
            this.groupBox1.Controls.Add(this.egitimBtn);
            this.groupBox1.Controls.Add(this.textBoxMutasyonKatsayi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxBireySec);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBoxGenAdeti);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.comboBoxMutosyon);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBoxFonksiyon);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxIterasyonSayisi);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxPopulasyonSayisi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 318);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 52);
            this.button2.TabIndex = 25;
            this.button2.Text = "Grafik";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "9";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "k:";
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(111, 260);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(109, 23);
            this.testBtn.TabIndex = 20;
            this.testBtn.Text = "Test Verisi";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // egitimBtn
            // 
            this.egitimBtn.Location = new System.Drawing.Point(11, 260);
            this.egitimBtn.Name = "egitimBtn";
            this.egitimBtn.Size = new System.Drawing.Size(94, 23);
            this.egitimBtn.TabIndex = 19;
            this.egitimBtn.Text = "Eğitim Verisi";
            this.egitimBtn.UseVisualStyleBackColor = true;
            this.egitimBtn.Click += new System.EventHandler(this.egitimBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Mutosyon";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPopulasyonSayisi
            // 
            this.textBoxPopulasyonSayisi.Location = new System.Drawing.Point(155, 36);
            this.textBoxPopulasyonSayisi.Name = "textBoxPopulasyonSayisi";
            this.textBoxPopulasyonSayisi.Size = new System.Drawing.Size(140, 20);
            this.textBoxPopulasyonSayisi.TabIndex = 3;
            this.textBoxPopulasyonSayisi.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Populasyon Büyüklüğü";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxPopulasyon);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.listBoxSonPopulasyon);
            this.groupBox3.Location = new System.Drawing.Point(311, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(957, 318);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Populasyon";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBoxGrafik
            // 
            this.groupBoxGrafik.Controls.Add(this.groupBoxIslemAdimlari);
            this.groupBoxGrafik.Controls.Add(this.chart2);
            this.groupBoxGrafik.Controls.Add(this.chart1);
            this.groupBoxGrafik.Controls.Add(this.label10);
            this.groupBoxGrafik.Controls.Add(this.label14);
            this.groupBoxGrafik.Location = new System.Drawing.Point(1, 327);
            this.groupBoxGrafik.Name = "groupBoxGrafik";
            this.groupBoxGrafik.Size = new System.Drawing.Size(1267, 281);
            this.groupBoxGrafik.TabIndex = 24;
            this.groupBoxGrafik.TabStop = false;
            this.groupBoxGrafik.Text = "Sezgizel K-NN Grafik";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(545, 37);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(710, 192);
            this.chart2.TabIndex = 18;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineWidth = 2;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(28, 37);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(441, 192);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(784, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(249, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Populasyonlardaki Değişim Grafiği";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(163, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(273, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "İlk ve Son Populasyon Değişim Grafigi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 609);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxGrafik);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxIslemAdimlari.ResumeLayout(false);
            this.groupBoxIslemAdimlari.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxGrafik.ResumeLayout(false);
            this.groupBoxGrafik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxSecilenler;
        private System.Windows.Forms.GroupBox groupBoxIslemAdimlari;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox listBoxIslemler;
        private System.Windows.Forms.ListBox listBoxPopulasyon;
        private System.Windows.Forms.TextBox textBoxMutasyonKatsayi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxIslemleriGor;
        private System.Windows.Forms.ComboBox comboBoxBireySec;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxGenAdeti;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxMutosyon;
        private System.Windows.Forms.ComboBox comboBoxFonksiyon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIterasyonSayisi;
        public System.Windows.Forms.ListBox listBoxSonPopulasyon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPopulasyonSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Button egitimBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBoxGrafik;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

