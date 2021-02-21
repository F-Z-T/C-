
namespace Shopping.WebFormUl
{
    partial class UyeAlısverıs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeAlısverıs));
            this.dgwMusterı = new System.Windows.Forms.DataGridView();
            this.gbxCategoryAra = new System.Windows.Forms.GroupBox();
            this.cbxUCategoryId = new System.Windows.Forms.ComboBox();
            this.lblKategorı = new System.Windows.Forms.Label();
            this.gbxUrunAra = new System.Windows.Forms.GroupBox();
            this.tbxUrunAra = new System.Windows.Forms.TextBox();
            this.lblUrunAra = new System.Windows.Forms.Label();
            this.gbxMUrunEkle = new System.Windows.Forms.GroupBox();
            this.btnAlıcıEkle = new System.Windows.Forms.Button();
            this.cbxCategoryId = new System.Windows.Forms.ComboBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnMusterıCıkıs = new System.Windows.Forms.Button();
            this.gbxKargoTakıp = new System.Windows.Forms.GroupBox();
            this.cbxGonderıSehrı = new System.Windows.Forms.ComboBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKargoSırketı = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgwEklenenUrunler = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusterı)).BeginInit();
            this.gbxCategoryAra.SuspendLayout();
            this.gbxUrunAra.SuspendLayout();
            this.gbxMUrunEkle.SuspendLayout();
            this.gbxKargoTakıp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEklenenUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwMusterı
            // 
            this.dgwMusterı.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusterı.Location = new System.Drawing.Point(12, 12);
            this.dgwMusterı.Name = "dgwMusterı";
            this.dgwMusterı.RowHeadersWidth = 51;
            this.dgwMusterı.RowTemplate.Height = 24;
            this.dgwMusterı.Size = new System.Drawing.Size(889, 266);
            this.dgwMusterı.TabIndex = 1;
            this.dgwMusterı.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellContentClick);
            // 
            // gbxCategoryAra
            // 
            this.gbxCategoryAra.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gbxCategoryAra.Controls.Add(this.cbxUCategoryId);
            this.gbxCategoryAra.Controls.Add(this.lblKategorı);
            this.gbxCategoryAra.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCategoryAra.ForeColor = System.Drawing.SystemColors.Control;
            this.gbxCategoryAra.Location = new System.Drawing.Point(918, 13);
            this.gbxCategoryAra.Name = "gbxCategoryAra";
            this.gbxCategoryAra.Size = new System.Drawing.Size(291, 112);
            this.gbxCategoryAra.TabIndex = 2;
            this.gbxCategoryAra.TabStop = false;
            this.gbxCategoryAra.Text = "Kategoriye Göre Ara";
            this.gbxCategoryAra.Enter += new System.EventHandler(this.gbxCategoryAra_Enter);
            // 
            // cbxUCategoryId
            // 
            this.cbxUCategoryId.BackColor = System.Drawing.Color.CadetBlue;
            this.cbxUCategoryId.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbxUCategoryId.FormattingEnabled = true;
            this.cbxUCategoryId.Location = new System.Drawing.Point(103, 41);
            this.cbxUCategoryId.Name = "cbxUCategoryId";
            this.cbxUCategoryId.Size = new System.Drawing.Size(164, 30);
            this.cbxUCategoryId.TabIndex = 11;
            // 
            // lblKategorı
            // 
            this.lblKategorı.AutoSize = true;
            this.lblKategorı.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorı.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKategorı.Location = new System.Drawing.Point(-2, 44);
            this.lblKategorı.Name = "lblKategorı";
            this.lblKategorı.Size = new System.Drawing.Size(99, 22);
            this.lblKategorı.TabIndex = 0;
            this.lblKategorı.Text = "Kategori :";
            // 
            // gbxUrunAra
            // 
            this.gbxUrunAra.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gbxUrunAra.Controls.Add(this.tbxUrunAra);
            this.gbxUrunAra.Controls.Add(this.lblUrunAra);
            this.gbxUrunAra.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUrunAra.ForeColor = System.Drawing.SystemColors.Control;
            this.gbxUrunAra.Location = new System.Drawing.Point(918, 146);
            this.gbxUrunAra.Name = "gbxUrunAra";
            this.gbxUrunAra.Size = new System.Drawing.Size(291, 112);
            this.gbxUrunAra.TabIndex = 3;
            this.gbxUrunAra.TabStop = false;
            this.gbxUrunAra.Text = "Ürüne Göre Ara";
            // 
            // tbxUrunAra
            // 
            this.tbxUrunAra.BackColor = System.Drawing.Color.CadetBlue;
            this.tbxUrunAra.Location = new System.Drawing.Point(103, 44);
            this.tbxUrunAra.Name = "tbxUrunAra";
            this.tbxUrunAra.Size = new System.Drawing.Size(164, 35);
            this.tbxUrunAra.TabIndex = 6;
            // 
            // lblUrunAra
            // 
            this.lblUrunAra.AutoSize = true;
            this.lblUrunAra.ImageIndex = 0;
            this.lblUrunAra.Location = new System.Drawing.Point(16, 57);
            this.lblUrunAra.Name = "lblUrunAra";
            this.lblUrunAra.Size = new System.Drawing.Size(67, 22);
            this.lblUrunAra.TabIndex = 0;
            this.lblUrunAra.Text = "Ürün :";
            // 
            // gbxMUrunEkle
            // 
            this.gbxMUrunEkle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gbxMUrunEkle.Controls.Add(this.btnAlıcıEkle);
            this.gbxMUrunEkle.Controls.Add(this.cbxCategoryId);
            this.gbxMUrunEkle.Controls.Add(this.tbxUnitPrice);
            this.gbxMUrunEkle.Controls.Add(this.tbxProductName);
            this.gbxMUrunEkle.Controls.Add(this.lblUnitPrice);
            this.gbxMUrunEkle.Controls.Add(this.lblCategoryID);
            this.gbxMUrunEkle.Controls.Add(this.lblProductName);
            this.gbxMUrunEkle.Location = new System.Drawing.Point(12, 304);
            this.gbxMUrunEkle.Name = "gbxMUrunEkle";
            this.gbxMUrunEkle.Size = new System.Drawing.Size(314, 196);
            this.gbxMUrunEkle.TabIndex = 4;
            this.gbxMUrunEkle.TabStop = false;
            this.gbxMUrunEkle.Text = "Sepete Ürün Ekle";
            // 
            // btnAlıcıEkle
            // 
            this.btnAlıcıEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAlıcıEkle.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlıcıEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlıcıEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlıcıEkle.ImageIndex = 0;
            this.btnAlıcıEkle.Location = new System.Drawing.Point(19, 133);
            this.btnAlıcıEkle.Name = "btnAlıcıEkle";
            this.btnAlıcıEkle.Size = new System.Drawing.Size(263, 42);
            this.btnAlıcıEkle.TabIndex = 11;
            this.btnAlıcıEkle.Text = "Sepete ekle";
            this.btnAlıcıEkle.UseVisualStyleBackColor = false;
            // 
            // cbxCategoryId
            // 
            this.cbxCategoryId.BackColor = System.Drawing.Color.SteelBlue;
            this.cbxCategoryId.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbxCategoryId.FormattingEnabled = true;
            this.cbxCategoryId.Location = new System.Drawing.Point(118, 58);
            this.cbxCategoryId.Name = "cbxCategoryId";
            this.cbxCategoryId.Size = new System.Drawing.Size(164, 24);
            this.cbxCategoryId.TabIndex = 10;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.BackColor = System.Drawing.Color.SteelBlue;
            this.tbxUnitPrice.Location = new System.Drawing.Point(118, 96);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(164, 22);
            this.tbxUnitPrice.TabIndex = 7;
            // 
            // tbxProductName
            // 
            this.tbxProductName.BackColor = System.Drawing.Color.SteelBlue;
            this.tbxProductName.Location = new System.Drawing.Point(118, 30);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(164, 22);
            this.tbxProductName.TabIndex = 5;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(16, 101);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(101, 17);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Toplam Tutar :";
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Location = new System.Drawing.Point(16, 67);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(69, 17);
            this.lblCategoryID.TabIndex = 1;
            this.lblCategoryID.Text = "Kategori :";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(16, 36);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(71, 17);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Ürün Adı :";
            // 
            // btnMusterıCıkıs
            // 
            this.btnMusterıCıkıs.BackColor = System.Drawing.Color.Brown;
            this.btnMusterıCıkıs.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusterıCıkıs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMusterıCıkıs.Location = new System.Drawing.Point(938, 457);
            this.btnMusterıCıkıs.Name = "btnMusterıCıkıs";
            this.btnMusterıCıkıs.Size = new System.Drawing.Size(273, 43);
            this.btnMusterıCıkıs.TabIndex = 5;
            this.btnMusterıCıkıs.Text = " Çıkış yap";
            this.btnMusterıCıkıs.UseVisualStyleBackColor = false;
            this.btnMusterıCıkıs.Click += new System.EventHandler(this.btnMusterıCıkıs_Click);
            // 
            // gbxKargoTakıp
            // 
            this.gbxKargoTakıp.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gbxKargoTakıp.Controls.Add(this.cbxGonderıSehrı);
            this.gbxKargoTakıp.Controls.Add(this.btnGonder);
            this.gbxKargoTakıp.Controls.Add(this.comboBox1);
            this.gbxKargoTakıp.Controls.Add(this.textBox1);
            this.gbxKargoTakıp.Controls.Add(this.label3);
            this.gbxKargoTakıp.Controls.Add(this.lblKargoSırketı);
            this.gbxKargoTakıp.Controls.Add(this.label5);
            this.gbxKargoTakıp.Location = new System.Drawing.Point(587, 304);
            this.gbxKargoTakıp.Name = "gbxKargoTakıp";
            this.gbxKargoTakıp.Size = new System.Drawing.Size(314, 198);
            this.gbxKargoTakıp.TabIndex = 6;
            this.gbxKargoTakıp.TabStop = false;
            this.gbxKargoTakıp.Text = "Kargo Takip";
            this.gbxKargoTakıp.Enter += new System.EventHandler(this.gbxKargoTakıp_Enter);
            // 
            // cbxGonderıSehrı
            // 
            this.cbxGonderıSehrı.BackColor = System.Drawing.Color.SteelBlue;
            this.cbxGonderıSehrı.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbxGonderıSehrı.FormattingEnabled = true;
            this.cbxGonderıSehrı.Location = new System.Drawing.Point(143, 28);
            this.cbxGonderıSehrı.Name = "cbxGonderıSehrı";
            this.cbxGonderıSehrı.Size = new System.Drawing.Size(164, 24);
            this.cbxGonderıSehrı.TabIndex = 12;
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGonder.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGonder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGonder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGonder.ImageIndex = 0;
            this.btnGonder.Location = new System.Drawing.Point(19, 142);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(288, 33);
            this.btnGonder.TabIndex = 11;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox1.Location = new System.Drawing.Point(143, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tutar :";
            // 
            // lblKargoSırketı
            // 
            this.lblKargoSırketı.AutoSize = true;
            this.lblKargoSırketı.Location = new System.Drawing.Point(16, 67);
            this.lblKargoSırketı.Name = "lblKargoSırketı";
            this.lblKargoSırketı.Size = new System.Drawing.Size(97, 17);
            this.lblKargoSırketı.TabIndex = 1;
            this.lblKargoSırketı.Text = "Kargo Şirketi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Göderilecek Şehir :";
            // 
            // dgwEklenenUrunler
            // 
            this.dgwEklenenUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEklenenUrunler.Location = new System.Drawing.Point(332, 304);
            this.dgwEklenenUrunler.Name = "dgwEklenenUrunler";
            this.dgwEklenenUrunler.RowHeadersWidth = 51;
            this.dgwEklenenUrunler.RowTemplate.Height = 24;
            this.dgwEklenenUrunler.Size = new System.Drawing.Size(249, 196);
            this.dgwEklenenUrunler.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(938, 283);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // UyeAlısverıs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1234, 525);
            this.Controls.Add(this.dgwEklenenUrunler);
            this.Controls.Add(this.gbxKargoTakıp);
            this.Controls.Add(this.btnMusterıCıkıs);
            this.Controls.Add(this.gbxMUrunEkle);
            this.Controls.Add(this.gbxUrunAra);
            this.Controls.Add(this.gbxCategoryAra);
            this.Controls.Add(this.dgwMusterı);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UyeAlısverıs";
            this.Text = "UyeAlısverıs";
            this.Load += new System.EventHandler(this.UyeAlısverıs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusterı)).EndInit();
            this.gbxCategoryAra.ResumeLayout(false);
            this.gbxCategoryAra.PerformLayout();
            this.gbxUrunAra.ResumeLayout(false);
            this.gbxUrunAra.PerformLayout();
            this.gbxMUrunEkle.ResumeLayout(false);
            this.gbxMUrunEkle.PerformLayout();
            this.gbxKargoTakıp.ResumeLayout(false);
            this.gbxKargoTakıp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEklenenUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMusterı;
        private System.Windows.Forms.GroupBox gbxCategoryAra;
        private System.Windows.Forms.Label lblKategorı;
        private System.Windows.Forms.GroupBox gbxUrunAra;
        private System.Windows.Forms.Label lblUrunAra;
        private System.Windows.Forms.ComboBox cbxUCategoryId;
        private System.Windows.Forms.TextBox tbxUrunAra;
        private System.Windows.Forms.GroupBox gbxMUrunEkle;
        private System.Windows.Forms.Button btnAlıcıEkle;
        private System.Windows.Forms.ComboBox cbxCategoryId;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnMusterıCıkıs;
        private System.Windows.Forms.GroupBox gbxKargoTakıp;
        private System.Windows.Forms.ComboBox cbxGonderıSehrı;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKargoSırketı;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgwEklenenUrunler;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}