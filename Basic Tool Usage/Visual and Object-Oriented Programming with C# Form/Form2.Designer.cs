namespace Visual_and_Object_Oriented_Programming_with_C__Form
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbders = new System.Windows.Forms.ComboBox();
            this.txtsinav1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsinav2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtortalama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsinav3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.listbox1 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedtxtnumara = new System.Windows.Forms.MaskedTextBox();
            this.txtdurum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btncizgi = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapBilgilerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koyuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güvenlikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izinlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btndurdur = new System.Windows.Forms.Button();
            this.btnbaslat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kişiselleştirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(334, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Not Kayıt Sistemi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad:";
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadsoyad.Location = new System.Drawing.Point(107, 76);
            this.txtadsoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(303, 30);
            this.txtadsoyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(46, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ders:";
            // 
            // cbders
            // 
            this.cbders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbders.FormattingEnabled = true;
            this.cbders.Items.AddRange(new object[] {
            "Görsel Programlama",
            "İnternet Programcılığı",
            "Mobil Programlama",
            "Ağ Güvenliği"});
            this.cbders.Location = new System.Drawing.Point(107, 140);
            this.cbders.Margin = new System.Windows.Forms.Padding(4);
            this.cbders.Name = "cbders";
            this.cbders.Size = new System.Drawing.Size(303, 33);
            this.cbders.TabIndex = 4;
            // 
            // txtsinav1
            // 
            this.txtsinav1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsinav1.Location = new System.Drawing.Point(105, 251);
            this.txtsinav1.Margin = new System.Windows.Forms.Padding(4);
            this.txtsinav1.Name = "txtsinav1";
            this.txtsinav1.Size = new System.Drawing.Size(92, 30);
            this.txtsinav1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sınav 1:";
            // 
            // txtsinav2
            // 
            this.txtsinav2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsinav2.Location = new System.Drawing.Point(105, 308);
            this.txtsinav2.Margin = new System.Windows.Forms.Padding(4);
            this.txtsinav2.Name = "txtsinav2";
            this.txtsinav2.Size = new System.Drawing.Size(92, 30);
            this.txtsinav2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(28, 315);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sınav 2:";
            // 
            // txtortalama
            // 
            this.txtortalama.Enabled = false;
            this.txtortalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtortalama.Location = new System.Drawing.Point(318, 308);
            this.txtortalama.Margin = new System.Windows.Forms.Padding(4);
            this.txtortalama.Name = "txtortalama";
            this.txtortalama.Size = new System.Drawing.Size(92, 30);
            this.txtortalama.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(272, 315);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ort:";
            // 
            // txtsinav3
            // 
            this.txtsinav3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsinav3.Location = new System.Drawing.Point(319, 249);
            this.txtsinav3.Margin = new System.Windows.Forms.Padding(4);
            this.txtsinav3.Name = "txtsinav3";
            this.txtsinav3.Size = new System.Drawing.Size(91, 30);
            this.txtsinav3.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(242, 256);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sınav 3:";
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnkaydet.Location = new System.Drawing.Point(0, 428);
            this.btnkaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(112, 51);
            this.btnkaydet.TabIndex = 13;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnhesapla
            // 
            this.btnhesapla.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnhesapla.Location = new System.Drawing.Point(120, 428);
            this.btnhesapla.Margin = new System.Windows.Forms.Padding(4);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(121, 51);
            this.btnhesapla.TabIndex = 14;
            this.btnhesapla.Text = "Hesapla";
            this.btnhesapla.UseVisualStyleBackColor = false;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btntemizle.Location = new System.Drawing.Point(249, 428);
            this.btntemizle.Margin = new System.Windows.Forms.Padding(4);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(112, 51);
            this.btntemizle.TabIndex = 15;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = false;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // listbox1
            // 
            this.listbox1.FormattingEnabled = true;
            this.listbox1.ItemHeight = 20;
            this.listbox1.Location = new System.Drawing.Point(488, 72);
            this.listbox1.Margin = new System.Windows.Forms.Padding(4);
            this.listbox1.Name = "listbox1";
            this.listbox1.Size = new System.Drawing.Size(496, 224);
            this.listbox1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(24, 205);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Numara:";
            // 
            // maskedtxtnumara
            // 
            this.maskedtxtnumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedtxtnumara.Location = new System.Drawing.Point(107, 195);
            this.maskedtxtnumara.Margin = new System.Windows.Forms.Padding(4);
            this.maskedtxtnumara.Mask = "0000";
            this.maskedtxtnumara.Name = "maskedtxtnumara";
            this.maskedtxtnumara.Size = new System.Drawing.Size(303, 30);
            this.maskedtxtnumara.TabIndex = 18;
            // 
            // txtdurum
            // 
            this.txtdurum.Enabled = false;
            this.txtdurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdurum.Location = new System.Drawing.Point(208, 359);
            this.txtdurum.Margin = new System.Windows.Forms.Padding(4);
            this.txtdurum.Name = "txtdurum";
            this.txtdurum.Size = new System.Drawing.Size(92, 30);
            this.txtdurum.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(135, 366);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Durum:";
            // 
            // btncizgi
            // 
            this.btncizgi.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btncizgi.Location = new System.Drawing.Point(369, 428);
            this.btncizgi.Margin = new System.Windows.Forms.Padding(4);
            this.btncizgi.Name = "btncizgi";
            this.btncizgi.Size = new System.Drawing.Size(112, 51);
            this.btncizgi.TabIndex = 21;
            this.btncizgi.Text = "Çiz";
            this.btncizgi.UseVisualStyleBackColor = false;
            this.btncizgi.Click += new System.EventHandler(this.btncizgi_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem,
            this.webBrowserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapBilgilerimToolStripMenuItem,
            this.güvenlikToolStripMenuItem,
            this.izinlerToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // hesapBilgilerimToolStripMenuItem
            // 
            this.hesapBilgilerimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temaToolStripMenuItem});
            this.hesapBilgilerimToolStripMenuItem.Name = "hesapBilgilerimToolStripMenuItem";
            this.hesapBilgilerimToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.hesapBilgilerimToolStripMenuItem.Text = "Hesap Bilgilerim";
            // 
            // temaToolStripMenuItem
            // 
            this.temaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.koyuToolStripMenuItem,
            this.açıkToolStripMenuItem});
            this.temaToolStripMenuItem.Name = "temaToolStripMenuItem";
            this.temaToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.temaToolStripMenuItem.Text = "Tema";
            // 
            // koyuToolStripMenuItem
            // 
            this.koyuToolStripMenuItem.Name = "koyuToolStripMenuItem";
            this.koyuToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.koyuToolStripMenuItem.Text = "Koyu";
            this.koyuToolStripMenuItem.Click += new System.EventHandler(this.koyuToolStripMenuItem_Click);
            // 
            // açıkToolStripMenuItem
            // 
            this.açıkToolStripMenuItem.Name = "açıkToolStripMenuItem";
            this.açıkToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.açıkToolStripMenuItem.Text = "Açık";
            this.açıkToolStripMenuItem.Click += new System.EventHandler(this.açıkToolStripMenuItem_Click);
            // 
            // güvenlikToolStripMenuItem
            // 
            this.güvenlikToolStripMenuItem.Name = "güvenlikToolStripMenuItem";
            this.güvenlikToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.güvenlikToolStripMenuItem.Text = "Güvenlik";
            // 
            // izinlerToolStripMenuItem
            // 
            this.izinlerToolStripMenuItem.Name = "izinlerToolStripMenuItem";
            this.izinlerToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.izinlerToolStripMenuItem.Text = "İzinler";
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            // 
            // webBrowserToolStripMenuItem
            // 
            this.webBrowserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.googleToolStripMenuItem});
            this.webBrowserToolStripMenuItem.Name = "webBrowserToolStripMenuItem";
            this.webBrowserToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.webBrowserToolStripMenuItem.Text = "Web Browser";
            // 
            // googleToolStripMenuItem
            // 
            this.googleToolStripMenuItem.Name = "googleToolStripMenuItem";
            this.googleToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.googleToolStripMenuItem.Text = "Google";
            this.googleToolStripMenuItem.Click += new System.EventHandler(this.googleToolStripMenuItem_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(488, 303);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(496, 208);
            this.webBrowser1.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(28, 547);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 175);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(247, 547);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 175);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(468, 547);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 175);
            this.panel3.TabIndex = 26;
            // 
            // btndurdur
            // 
            this.btndurdur.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btndurdur.Location = new System.Drawing.Point(698, 631);
            this.btndurdur.Margin = new System.Windows.Forms.Padding(4);
            this.btndurdur.Name = "btndurdur";
            this.btndurdur.Size = new System.Drawing.Size(112, 51);
            this.btndurdur.TabIndex = 28;
            this.btndurdur.Text = "Durdur";
            this.btndurdur.UseVisualStyleBackColor = false;
            this.btndurdur.Click += new System.EventHandler(this.btndurdur_Click);
            // 
            // btnbaslat
            // 
            this.btnbaslat.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnbaslat.Location = new System.Drawing.Point(698, 572);
            this.btnbaslat.Margin = new System.Windows.Forms.Padding(4);
            this.btnbaslat.Name = "btnbaslat";
            this.btnbaslat.Size = new System.Drawing.Size(112, 51);
            this.btnbaslat.TabIndex = 27;
            this.btnbaslat.Text = "Başlat";
            this.btnbaslat.UseVisualStyleBackColor = false;
            this.btnbaslat.Click += new System.EventHandler(this.btnbaslat_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kişiselleştirmeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 28);
            // 
            // kişiselleştirmeToolStripMenuItem
            // 
            this.kişiselleştirmeToolStripMenuItem.Name = "kişiselleştirmeToolStripMenuItem";
            this.kişiselleştirmeToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.kişiselleştirmeToolStripMenuItem.Text = "Kişiselleştirme";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1000, 743);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btndurdur);
            this.Controls.Add(this.btnbaslat);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btncizgi);
            this.Controls.Add(this.txtdurum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.maskedtxtnumara);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listbox1);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.txtsinav3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtortalama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtsinav2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsinav1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtadsoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbders;
        private System.Windows.Forms.TextBox txtsinav1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsinav2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtortalama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsinav3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.ListBox listbox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedtxtnumara;
        private System.Windows.Forms.TextBox txtdurum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btncizgi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapBilgilerimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güvenlikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izinlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem temaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koyuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açıkToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btndurdur;
        private System.Windows.Forms.Button btnbaslat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kişiselleştirmeToolStripMenuItem;
    }
}