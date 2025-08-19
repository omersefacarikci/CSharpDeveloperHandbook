namespace File_Operations
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnfolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbelgeadi = new System.Windows.Forms.TextBox();
            this.btnsec = new System.Windows.Forms.Button();
            this.btnolustur = new System.Windows.Forms.Button();
            this.btnoku = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnfolder
            // 
            this.btnfolder.BackColor = System.Drawing.Color.Firebrick;
            this.btnfolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfolder.Location = new System.Drawing.Point(12, 62);
            this.btnfolder.Name = "btnfolder";
            this.btnfolder.Size = new System.Drawing.Size(196, 60);
            this.btnfolder.TabIndex = 0;
            this.btnfolder.Text = "Folder Browser";
            this.btnfolder.UseVisualStyleBackColor = false;
            this.btnfolder.Click += new System.EventHandler(this.btnfolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seçilen Dizin";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seçilen Dosya";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kayıt Yeri";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(12, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save File";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Belge Adı";
            // 
            // txtbelgeadi
            // 
            this.txtbelgeadi.Location = new System.Drawing.Point(371, 24);
            this.txtbelgeadi.Name = "txtbelgeadi";
            this.txtbelgeadi.Size = new System.Drawing.Size(177, 22);
            this.txtbelgeadi.TabIndex = 7;
            // 
            // btnsec
            // 
            this.btnsec.BackColor = System.Drawing.Color.Firebrick;
            this.btnsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsec.Location = new System.Drawing.Point(274, 62);
            this.btnsec.Name = "btnsec";
            this.btnsec.Size = new System.Drawing.Size(114, 60);
            this.btnsec.TabIndex = 8;
            this.btnsec.Text = "Konum Seç";
            this.btnsec.UseVisualStyleBackColor = false;
            this.btnsec.Click += new System.EventHandler(this.btnsec_Click);
            // 
            // btnolustur
            // 
            this.btnolustur.BackColor = System.Drawing.Color.Firebrick;
            this.btnolustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnolustur.Location = new System.Drawing.Point(453, 62);
            this.btnolustur.Name = "btnolustur";
            this.btnolustur.Size = new System.Drawing.Size(114, 60);
            this.btnolustur.TabIndex = 9;
            this.btnolustur.Text = "Oluştur";
            this.btnolustur.UseVisualStyleBackColor = false;
            this.btnolustur.Click += new System.EventHandler(this.btnolustur_Click);
            // 
            // btnoku
            // 
            this.btnoku.BackColor = System.Drawing.Color.Firebrick;
            this.btnoku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnoku.Location = new System.Drawing.Point(274, 207);
            this.btnoku.Name = "btnoku";
            this.btnoku.Size = new System.Drawing.Size(293, 60);
            this.btnoku.TabIndex = 10;
            this.btnoku.Text = "Oku";
            this.btnoku.UseVisualStyleBackColor = false;
            this.btnoku.Click += new System.EventHandler(this.btnoku_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(274, 273);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(293, 132);
            this.listBox1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(614, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kullanıcı adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnoku);
            this.Controls.Add(this.btnolustur);
            this.Controls.Add(this.btnsec);
            this.Controls.Add(this.txtbelgeadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnfolder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnfolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbelgeadi;
        private System.Windows.Forms.Button btnsec;
        private System.Windows.Forms.Button btnolustur;
        private System.Windows.Forms.Button btnoku;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
    }
}

