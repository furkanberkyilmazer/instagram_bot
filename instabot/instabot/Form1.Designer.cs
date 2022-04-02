namespace instabot
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGuvenlikKodu = new System.Windows.Forms.TextBox();
            this.btnKod = new System.Windows.Forms.Button();
            this.btnTakipGor = new System.Windows.Forms.Button();
            this.btnTakipEdilen = new System.Windows.Forms.Button();
            this.btnYakala = new System.Windows.Forms.Button();
            this.lblYakala = new System.Windows.Forms.Label();
            this.lbTakipci = new System.Windows.Forms.ListBox();
            this.lbTakip = new System.Windows.Forms.ListBox();
            this.lbYakala = new System.Windows.Forms.ListBox();
            this.lblTakipci = new System.Windows.Forms.Label();
            this.lblTakip = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCik = new System.Windows.Forms.Button();
            this.lblSecilen = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(99, 130);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 23);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(88, 36);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(132, 23);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(88, 77);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(132, 23);
            this.txtParola.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parola:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Güvenlik Kodu:";
            // 
            // txtGuvenlikKodu
            // 
            this.txtGuvenlikKodu.Location = new System.Drawing.Point(111, 24);
            this.txtGuvenlikKodu.Name = "txtGuvenlikKodu";
            this.txtGuvenlikKodu.Size = new System.Drawing.Size(100, 23);
            this.txtGuvenlikKodu.TabIndex = 5;
            // 
            // btnKod
            // 
            this.btnKod.Location = new System.Drawing.Point(136, 53);
            this.btnKod.Name = "btnKod";
            this.btnKod.Size = new System.Drawing.Size(75, 23);
            this.btnKod.TabIndex = 7;
            this.btnKod.Text = "Kod Gir";
            this.btnKod.UseVisualStyleBackColor = true;
            this.btnKod.Click += new System.EventHandler(this.btnKod_Click);
            // 
            // btnTakipGor
            // 
            this.btnTakipGor.Location = new System.Drawing.Point(29, 22);
            this.btnTakipGor.Name = "btnTakipGor";
            this.btnTakipGor.Size = new System.Drawing.Size(120, 23);
            this.btnTakipGor.TabIndex = 8;
            this.btnTakipGor.Text = "Takipçilerimi Gör";
            this.btnTakipGor.UseVisualStyleBackColor = true;
            this.btnTakipGor.Click += new System.EventHandler(this.btnTakipGor_Click);
            // 
            // btnTakipEdilen
            // 
            this.btnTakipEdilen.Location = new System.Drawing.Point(185, 22);
            this.btnTakipEdilen.Name = "btnTakipEdilen";
            this.btnTakipEdilen.Size = new System.Drawing.Size(120, 23);
            this.btnTakipEdilen.TabIndex = 11;
            this.btnTakipEdilen.Text = "Takip Edilenleri Gör";
            this.btnTakipEdilen.UseVisualStyleBackColor = true;
            this.btnTakipEdilen.Click += new System.EventHandler(this.btnTakipEdilen_Click);
            // 
            // btnYakala
            // 
            this.btnYakala.Location = new System.Drawing.Point(29, 179);
            this.btnYakala.Name = "btnYakala";
            this.btnYakala.Size = new System.Drawing.Size(138, 23);
            this.btnYakala.TabIndex = 12;
            this.btnYakala.Text = "Takip Etmeyenleri Gör";
            this.btnYakala.UseVisualStyleBackColor = true;
            this.btnYakala.Click += new System.EventHandler(this.btnYakala_Click);
            // 
            // lblYakala
            // 
            this.lblYakala.AutoSize = true;
            this.lblYakala.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYakala.ForeColor = System.Drawing.Color.White;
            this.lblYakala.Location = new System.Drawing.Point(176, 289);
            this.lblYakala.Name = "lblYakala";
            this.lblYakala.Size = new System.Drawing.Size(0, 15);
            this.lblYakala.TabIndex = 13;
            // 
            // lbTakipci
            // 
            this.lbTakipci.FormattingEnabled = true;
            this.lbTakipci.ItemHeight = 15;
            this.lbTakipci.Location = new System.Drawing.Point(29, 58);
            this.lbTakipci.Name = "lbTakipci";
            this.lbTakipci.Size = new System.Drawing.Size(120, 94);
            this.lbTakipci.TabIndex = 14;
            // 
            // lbTakip
            // 
            this.lbTakip.FormattingEnabled = true;
            this.lbTakip.ItemHeight = 15;
            this.lbTakip.Location = new System.Drawing.Point(185, 58);
            this.lbTakip.Name = "lbTakip";
            this.lbTakip.Size = new System.Drawing.Size(120, 94);
            this.lbTakip.TabIndex = 15;
            // 
            // lbYakala
            // 
            this.lbYakala.FormattingEnabled = true;
            this.lbYakala.ItemHeight = 15;
            this.lbYakala.Location = new System.Drawing.Point(30, 212);
            this.lbYakala.Name = "lbYakala";
            this.lbYakala.Size = new System.Drawing.Size(137, 94);
            this.lbYakala.TabIndex = 16;
            this.lbYakala.SelectedIndexChanged += new System.EventHandler(this.lbYakala_SelectedIndexChanged);
            // 
            // lblTakipci
            // 
            this.lblTakipci.AutoSize = true;
            this.lblTakipci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTakipci.ForeColor = System.Drawing.Color.White;
            this.lblTakipci.Location = new System.Drawing.Point(30, 157);
            this.lblTakipci.Name = "lblTakipci";
            this.lblTakipci.Size = new System.Drawing.Size(0, 13);
            this.lblTakipci.TabIndex = 17;
            // 
            // lblTakip
            // 
            this.lblTakip.AutoSize = true;
            this.lblTakip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTakip.ForeColor = System.Drawing.Color.White;
            this.lblTakip.Location = new System.Drawing.Point(185, 157);
            this.lblTakip.Name = "lblTakip";
            this.lblTakip.Size = new System.Drawing.Size(0, 13);
            this.lblTakip.TabIndex = 18;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.progressBar1.Location = new System.Drawing.Point(6, 330);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(565, 18);
            this.progressBar1.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnCik);
            this.groupBox1.Controls.Add(this.lblSecilen);
            this.groupBox1.Controls.Add(this.lblTakip);
            this.groupBox1.Controls.Add(this.lblTakipci);
            this.groupBox1.Controls.Add(this.lbYakala);
            this.groupBox1.Controls.Add(this.lbTakip);
            this.groupBox1.Controls.Add(this.lbTakipci);
            this.groupBox1.Controls.Add(this.lblYakala);
            this.groupBox1.Controls.Add(this.btnYakala);
            this.groupBox1.Controls.Add(this.btnTakipEdilen);
            this.groupBox1.Controls.Add(this.btnTakipGor);
            this.groupBox1.Location = new System.Drawing.Point(255, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 317);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // btnCik
            // 
            this.btnCik.Location = new System.Drawing.Point(185, 240);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(89, 23);
            this.btnCik.TabIndex = 20;
            this.btnCik.Text = "Takipten Çık";
            this.btnCik.UseVisualStyleBackColor = true;
            this.btnCik.Click += new System.EventHandler(this.btnCik_Click);
            // 
            // lblSecilen
            // 
            this.lblSecilen.AutoSize = true;
            this.lblSecilen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecilen.ForeColor = System.Drawing.Color.White;
            this.lblSecilen.Location = new System.Drawing.Point(190, 219);
            this.lblSecilen.Name = "lblSecilen";
            this.lblSecilen.Size = new System.Drawing.Size(0, 15);
            this.lblSecilen.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtParola);
            this.groupBox2.Controls.Add(this.txtKullaniciAdi);
            this.groupBox2.Controls.Add(this.btnGiris);
            this.groupBox2.Location = new System.Drawing.Point(6, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 177);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(61, 226);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(182, 19);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Güvenlik Kodu Girmem Gerek";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnKod);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtGuvenlikKodu);
            this.groupBox3.Location = new System.Drawing.Point(6, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 82);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(578, 351);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "instaBot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGiris;
        private TextBox txtKullaniciAdi;
        private TextBox txtParola;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtGuvenlikKodu;
        private Button btnKod;
        private Button btnTakipGor;
        private Button btnTakipEdilen;
        private Button btnYakala;
        private Label lblYakala;
        private ListBox lbTakipci;
        private ListBox lbTakip;
        private ListBox lbYakala;
        private Label lblTakipci;
        private Label lblTakip;
        private ProgressBar progressBar1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox checkBox1;
        private GroupBox groupBox3;
        private Button btnCik;
        private Label lblSecilen;
    }
}