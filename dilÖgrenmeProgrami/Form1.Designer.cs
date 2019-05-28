namespace dilÖgrenmeProgrami
{
	partial class anaEkran
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
			this.tabControlAnaEkran = new MetroFramework.Controls.MetroTabControl();
			this.tabControlOgrenilmemis = new MetroFramework.Controls.MetroTabPage();
			this.listOgrenilmemisIng = new System.Windows.Forms.ListBox();
			this.tileOgrenmeyeBasla = new MetroFramework.Controls.MetroTile();
			this.tabControlOgrenilmis = new MetroFramework.Controls.MetroTabPage();
			this.tileIstatistik = new MetroFramework.Controls.MetroTile();
			this.listOgrenilmis = new System.Windows.Forms.ListBox();
			this.tileSinavaGit = new MetroFramework.Controls.MetroTile();
			this.tabControlYeniEkle = new MetroFramework.Controls.MetroTabPage();
			this.tileAra = new MetroFramework.Controls.MetroTile();
			this.txtBoxArama = new System.Windows.Forms.TextBox();
			this.tileYeniKelimeEkle = new MetroFramework.Controls.MetroTile();
			this.txtBoxTrCumleEkle = new MetroFramework.Controls.MetroTextBox();
			this.txtBoxIngCumleEkle = new MetroFramework.Controls.MetroTextBox();
			this.txtBoxTurEkle = new MetroFramework.Controls.MetroTextBox();
			this.txtBoxTrEkle = new MetroFramework.Controls.MetroTextBox();
			this.txtBoxIngEkle = new MetroFramework.Controls.MetroTextBox();
			this.lblIngCumle = new MetroFramework.Controls.MetroLabel();
			this.lblTrCumle = new MetroFramework.Controls.MetroLabel();
			this.lblKelimeTuru = new MetroFramework.Controls.MetroLabel();
			this.lblTrHaliEkle = new MetroFramework.Controls.MetroLabel();
			this.lblIngHaliEkle = new MetroFramework.Controls.MetroLabel();
			this.lblEklemeBaslik = new MetroFramework.Controls.MetroLabel();
			this.lblAnaEkran = new MetroFramework.Controls.MetroLabel();
			this.tileListeYenile = new MetroFramework.Controls.MetroTile();
			this.tabControlAnaEkran.SuspendLayout();
			this.tabControlOgrenilmemis.SuspendLayout();
			this.tabControlOgrenilmis.SuspendLayout();
			this.tabControlYeniEkle.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlAnaEkran
			// 
			this.tabControlAnaEkran.Controls.Add(this.tabControlOgrenilmemis);
			this.tabControlAnaEkran.Controls.Add(this.tabControlOgrenilmis);
			this.tabControlAnaEkran.Controls.Add(this.tabControlYeniEkle);
			this.tabControlAnaEkran.Location = new System.Drawing.Point(23, 63);
			this.tabControlAnaEkran.Name = "tabControlAnaEkran";
			this.tabControlAnaEkran.SelectedIndex = 0;
			this.tabControlAnaEkran.Size = new System.Drawing.Size(754, 364);
			this.tabControlAnaEkran.TabIndex = 0;
			this.tabControlAnaEkran.UseSelectable = true;
			// 
			// tabControlOgrenilmemis
			// 
			this.tabControlOgrenilmemis.Controls.Add(this.tileListeYenile);
			this.tabControlOgrenilmemis.Controls.Add(this.listOgrenilmemisIng);
			this.tabControlOgrenilmemis.Controls.Add(this.tileOgrenmeyeBasla);
			this.tabControlOgrenilmemis.HorizontalScrollbarBarColor = true;
			this.tabControlOgrenilmemis.HorizontalScrollbarHighlightOnWheel = false;
			this.tabControlOgrenilmemis.HorizontalScrollbarSize = 10;
			this.tabControlOgrenilmemis.Location = new System.Drawing.Point(4, 38);
			this.tabControlOgrenilmemis.Name = "tabControlOgrenilmemis";
			this.tabControlOgrenilmemis.Size = new System.Drawing.Size(746, 322);
			this.tabControlOgrenilmemis.TabIndex = 0;
			this.tabControlOgrenilmemis.Text = "Öğrenilmemiş Kelimeler";
			this.tabControlOgrenilmemis.VerticalScrollbarBarColor = true;
			this.tabControlOgrenilmemis.VerticalScrollbarHighlightOnWheel = false;
			this.tabControlOgrenilmemis.VerticalScrollbarSize = 10;
			this.tabControlOgrenilmemis.Click += new System.EventHandler(this.tabControlOgrenilmemis_Click);
			// 
			// listOgrenilmemisIng
			// 
			this.listOgrenilmemisIng.FormattingEnabled = true;
			this.listOgrenilmemisIng.ImeMode = System.Windows.Forms.ImeMode.On;
			this.listOgrenilmemisIng.Location = new System.Drawing.Point(3, 13);
			this.listOgrenilmemisIng.Name = "listOgrenilmemisIng";
			this.listOgrenilmemisIng.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.listOgrenilmemisIng.Size = new System.Drawing.Size(522, 303);
			this.listOgrenilmemisIng.TabIndex = 5;
			this.listOgrenilmemisIng.SelectedIndexChanged += new System.EventHandler(this.listOgrenilmemisIng_SelectedIndexChanged);
			// 
			// tileOgrenmeyeBasla
			// 
			this.tileOgrenmeyeBasla.ActiveControl = null;
			this.tileOgrenmeyeBasla.Location = new System.Drawing.Point(553, 13);
			this.tileOgrenmeyeBasla.Name = "tileOgrenmeyeBasla";
			this.tileOgrenmeyeBasla.Size = new System.Drawing.Size(176, 208);
			this.tileOgrenmeyeBasla.TabIndex = 4;
			this.tileOgrenmeyeBasla.Text = "Öğrenmeye Başla";
			this.tileOgrenmeyeBasla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.tileOgrenmeyeBasla.UseSelectable = true;
			this.tileOgrenmeyeBasla.Click += new System.EventHandler(this.tileOgrenmeyeBasla_Click);
			// 
			// tabControlOgrenilmis
			// 
			this.tabControlOgrenilmis.Controls.Add(this.tileIstatistik);
			this.tabControlOgrenilmis.Controls.Add(this.listOgrenilmis);
			this.tabControlOgrenilmis.Controls.Add(this.tileSinavaGit);
			this.tabControlOgrenilmis.HorizontalScrollbarBarColor = true;
			this.tabControlOgrenilmis.HorizontalScrollbarHighlightOnWheel = false;
			this.tabControlOgrenilmis.HorizontalScrollbarSize = 10;
			this.tabControlOgrenilmis.Location = new System.Drawing.Point(4, 38);
			this.tabControlOgrenilmis.Name = "tabControlOgrenilmis";
			this.tabControlOgrenilmis.Size = new System.Drawing.Size(746, 322);
			this.tabControlOgrenilmis.TabIndex = 1;
			this.tabControlOgrenilmis.Text = "Öğrenilecek Kelimeler";
			this.tabControlOgrenilmis.VerticalScrollbarBarColor = true;
			this.tabControlOgrenilmis.VerticalScrollbarHighlightOnWheel = false;
			this.tabControlOgrenilmis.VerticalScrollbarSize = 10;
			// 
			// tileIstatistik
			// 
			this.tileIstatistik.ActiveControl = null;
			this.tileIstatistik.Location = new System.Drawing.Point(553, 176);
			this.tileIstatistik.Name = "tileIstatistik";
			this.tileIstatistik.Size = new System.Drawing.Size(176, 143);
			this.tileIstatistik.TabIndex = 6;
			this.tileIstatistik.Text = "İstatistikler";
			this.tileIstatistik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.tileIstatistik.UseSelectable = true;
			// 
			// listOgrenilmis
			// 
			this.listOgrenilmis.FormattingEnabled = true;
			this.listOgrenilmis.Location = new System.Drawing.Point(3, 16);
			this.listOgrenilmis.Name = "listOgrenilmis";
			this.listOgrenilmis.Size = new System.Drawing.Size(525, 303);
			this.listOgrenilmis.TabIndex = 5;
			// 
			// tileSinavaGit
			// 
			this.tileSinavaGit.ActiveControl = null;
			this.tileSinavaGit.Location = new System.Drawing.Point(553, 13);
			this.tileSinavaGit.Name = "tileSinavaGit";
			this.tileSinavaGit.Size = new System.Drawing.Size(176, 143);
			this.tileSinavaGit.TabIndex = 4;
			this.tileSinavaGit.Text = "Sınava Git";
			this.tileSinavaGit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.tileSinavaGit.UseSelectable = true;
			this.tileSinavaGit.Click += new System.EventHandler(this.tileSinavaGit_Click);
			// 
			// tabControlYeniEkle
			// 
			this.tabControlYeniEkle.Controls.Add(this.tileAra);
			this.tabControlYeniEkle.Controls.Add(this.txtBoxArama);
			this.tabControlYeniEkle.Controls.Add(this.tileYeniKelimeEkle);
			this.tabControlYeniEkle.Controls.Add(this.txtBoxTrCumleEkle);
			this.tabControlYeniEkle.Controls.Add(this.txtBoxIngCumleEkle);
			this.tabControlYeniEkle.Controls.Add(this.txtBoxTurEkle);
			this.tabControlYeniEkle.Controls.Add(this.txtBoxTrEkle);
			this.tabControlYeniEkle.Controls.Add(this.txtBoxIngEkle);
			this.tabControlYeniEkle.Controls.Add(this.lblIngCumle);
			this.tabControlYeniEkle.Controls.Add(this.lblTrCumle);
			this.tabControlYeniEkle.Controls.Add(this.lblKelimeTuru);
			this.tabControlYeniEkle.Controls.Add(this.lblTrHaliEkle);
			this.tabControlYeniEkle.Controls.Add(this.lblIngHaliEkle);
			this.tabControlYeniEkle.Controls.Add(this.lblEklemeBaslik);
			this.tabControlYeniEkle.Controls.Add(this.lblAnaEkran);
			this.tabControlYeniEkle.HorizontalScrollbarBarColor = true;
			this.tabControlYeniEkle.HorizontalScrollbarHighlightOnWheel = false;
			this.tabControlYeniEkle.HorizontalScrollbarSize = 10;
			this.tabControlYeniEkle.Location = new System.Drawing.Point(4, 38);
			this.tabControlYeniEkle.Name = "tabControlYeniEkle";
			this.tabControlYeniEkle.Size = new System.Drawing.Size(746, 322);
			this.tabControlYeniEkle.TabIndex = 2;
			this.tabControlYeniEkle.Text = "Yeni Kelime Ekle";
			this.tabControlYeniEkle.VerticalScrollbarBarColor = true;
			this.tabControlYeniEkle.VerticalScrollbarHighlightOnWheel = false;
			this.tabControlYeniEkle.VerticalScrollbarSize = 10;
			// 
			// tileAra
			// 
			this.tileAra.ActiveControl = null;
			this.tileAra.Location = new System.Drawing.Point(256, 83);
			this.tileAra.Name = "tileAra";
			this.tileAra.Size = new System.Drawing.Size(101, 70);
			this.tileAra.TabIndex = 32;
			this.tileAra.Text = "Ara";
			this.tileAra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.tileAra.UseSelectable = true;
			this.tileAra.Click += new System.EventHandler(this.tileAra_Click);
			// 
			// txtBoxArama
			// 
			this.txtBoxArama.Location = new System.Drawing.Point(16, 116);
			this.txtBoxArama.Name = "txtBoxArama";
			this.txtBoxArama.Size = new System.Drawing.Size(200, 20);
			this.txtBoxArama.TabIndex = 31;
			this.txtBoxArama.TextChanged += new System.EventHandler(this.txtBoxArama_TextChanged);
			// 
			// tileYeniKelimeEkle
			// 
			this.tileYeniKelimeEkle.ActiveControl = null;
			this.tileYeniKelimeEkle.Location = new System.Drawing.Point(473, 218);
			this.tileYeniKelimeEkle.Name = "tileYeniKelimeEkle";
			this.tileYeniKelimeEkle.Size = new System.Drawing.Size(185, 37);
			this.tileYeniKelimeEkle.TabIndex = 29;
			this.tileYeniKelimeEkle.Text = "Ekle";
			this.tileYeniKelimeEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.tileYeniKelimeEkle.UseSelectable = true;
			this.tileYeniKelimeEkle.Visible = false;
			this.tileYeniKelimeEkle.Click += new System.EventHandler(this.tileYeniKelimeEkle_Click);
			// 
			// txtBoxTrCumleEkle
			// 
			// 
			// 
			// 
			this.txtBoxTrCumleEkle.CustomButton.Image = null;
			this.txtBoxTrCumleEkle.CustomButton.Location = new System.Drawing.Point(147, 1);
			this.txtBoxTrCumleEkle.CustomButton.Name = "";
			this.txtBoxTrCumleEkle.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtBoxTrCumleEkle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtBoxTrCumleEkle.CustomButton.TabIndex = 1;
			this.txtBoxTrCumleEkle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtBoxTrCumleEkle.CustomButton.UseSelectable = true;
			this.txtBoxTrCumleEkle.CustomButton.Visible = false;
			this.txtBoxTrCumleEkle.Lines = new string[0];
			this.txtBoxTrCumleEkle.Location = new System.Drawing.Point(541, 171);
			this.txtBoxTrCumleEkle.MaxLength = 32767;
			this.txtBoxTrCumleEkle.Name = "txtBoxTrCumleEkle";
			this.txtBoxTrCumleEkle.PasswordChar = '\0';
			this.txtBoxTrCumleEkle.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtBoxTrCumleEkle.SelectedText = "";
			this.txtBoxTrCumleEkle.SelectionLength = 0;
			this.txtBoxTrCumleEkle.SelectionStart = 0;
			this.txtBoxTrCumleEkle.ShortcutsEnabled = true;
			this.txtBoxTrCumleEkle.Size = new System.Drawing.Size(169, 23);
			this.txtBoxTrCumleEkle.TabIndex = 28;
			this.txtBoxTrCumleEkle.UseSelectable = true;
			this.txtBoxTrCumleEkle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtBoxTrCumleEkle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtBoxIngCumleEkle
			// 
			// 
			// 
			// 
			this.txtBoxIngCumleEkle.CustomButton.Image = null;
			this.txtBoxIngCumleEkle.CustomButton.Location = new System.Drawing.Point(147, 1);
			this.txtBoxIngCumleEkle.CustomButton.Name = "";
			this.txtBoxIngCumleEkle.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtBoxIngCumleEkle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtBoxIngCumleEkle.CustomButton.TabIndex = 1;
			this.txtBoxIngCumleEkle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtBoxIngCumleEkle.CustomButton.UseSelectable = true;
			this.txtBoxIngCumleEkle.CustomButton.Visible = false;
			this.txtBoxIngCumleEkle.Lines = new string[0];
			this.txtBoxIngCumleEkle.Location = new System.Drawing.Point(541, 141);
			this.txtBoxIngCumleEkle.MaxLength = 32767;
			this.txtBoxIngCumleEkle.Name = "txtBoxIngCumleEkle";
			this.txtBoxIngCumleEkle.PasswordChar = '\0';
			this.txtBoxIngCumleEkle.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtBoxIngCumleEkle.SelectedText = "";
			this.txtBoxIngCumleEkle.SelectionLength = 0;
			this.txtBoxIngCumleEkle.SelectionStart = 0;
			this.txtBoxIngCumleEkle.ShortcutsEnabled = true;
			this.txtBoxIngCumleEkle.Size = new System.Drawing.Size(169, 23);
			this.txtBoxIngCumleEkle.TabIndex = 27;
			this.txtBoxIngCumleEkle.UseSelectable = true;
			this.txtBoxIngCumleEkle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtBoxIngCumleEkle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtBoxTurEkle
			// 
			// 
			// 
			// 
			this.txtBoxTurEkle.CustomButton.Image = null;
			this.txtBoxTurEkle.CustomButton.Location = new System.Drawing.Point(147, 1);
			this.txtBoxTurEkle.CustomButton.Name = "";
			this.txtBoxTurEkle.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtBoxTurEkle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtBoxTurEkle.CustomButton.TabIndex = 1;
			this.txtBoxTurEkle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtBoxTurEkle.CustomButton.UseSelectable = true;
			this.txtBoxTurEkle.CustomButton.Visible = false;
			this.txtBoxTurEkle.Lines = new string[0];
			this.txtBoxTurEkle.Location = new System.Drawing.Point(542, 112);
			this.txtBoxTurEkle.MaxLength = 32767;
			this.txtBoxTurEkle.Name = "txtBoxTurEkle";
			this.txtBoxTurEkle.PasswordChar = '\0';
			this.txtBoxTurEkle.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtBoxTurEkle.SelectedText = "";
			this.txtBoxTurEkle.SelectionLength = 0;
			this.txtBoxTurEkle.SelectionStart = 0;
			this.txtBoxTurEkle.ShortcutsEnabled = true;
			this.txtBoxTurEkle.Size = new System.Drawing.Size(169, 23);
			this.txtBoxTurEkle.TabIndex = 26;
			this.txtBoxTurEkle.UseSelectable = true;
			this.txtBoxTurEkle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtBoxTurEkle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtBoxTrEkle
			// 
			// 
			// 
			// 
			this.txtBoxTrEkle.CustomButton.Image = null;
			this.txtBoxTrEkle.CustomButton.Location = new System.Drawing.Point(147, 1);
			this.txtBoxTrEkle.CustomButton.Name = "";
			this.txtBoxTrEkle.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtBoxTrEkle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtBoxTrEkle.CustomButton.TabIndex = 1;
			this.txtBoxTrEkle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtBoxTrEkle.CustomButton.UseSelectable = true;
			this.txtBoxTrEkle.CustomButton.Visible = false;
			this.txtBoxTrEkle.Lines = new string[0];
			this.txtBoxTrEkle.Location = new System.Drawing.Point(542, 83);
			this.txtBoxTrEkle.MaxLength = 32767;
			this.txtBoxTrEkle.Name = "txtBoxTrEkle";
			this.txtBoxTrEkle.PasswordChar = '\0';
			this.txtBoxTrEkle.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtBoxTrEkle.SelectedText = "";
			this.txtBoxTrEkle.SelectionLength = 0;
			this.txtBoxTrEkle.SelectionStart = 0;
			this.txtBoxTrEkle.ShortcutsEnabled = true;
			this.txtBoxTrEkle.Size = new System.Drawing.Size(169, 23);
			this.txtBoxTrEkle.TabIndex = 25;
			this.txtBoxTrEkle.UseSelectable = true;
			this.txtBoxTrEkle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtBoxTrEkle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtBoxIngEkle
			// 
			// 
			// 
			// 
			this.txtBoxIngEkle.CustomButton.Image = null;
			this.txtBoxIngEkle.CustomButton.Location = new System.Drawing.Point(147, 1);
			this.txtBoxIngEkle.CustomButton.Name = "";
			this.txtBoxIngEkle.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtBoxIngEkle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtBoxIngEkle.CustomButton.TabIndex = 1;
			this.txtBoxIngEkle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtBoxIngEkle.CustomButton.UseSelectable = true;
			this.txtBoxIngEkle.CustomButton.Visible = false;
			this.txtBoxIngEkle.Lines = new string[0];
			this.txtBoxIngEkle.Location = new System.Drawing.Point(542, 54);
			this.txtBoxIngEkle.MaxLength = 32767;
			this.txtBoxIngEkle.Name = "txtBoxIngEkle";
			this.txtBoxIngEkle.PasswordChar = '\0';
			this.txtBoxIngEkle.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtBoxIngEkle.SelectedText = "";
			this.txtBoxIngEkle.SelectionLength = 0;
			this.txtBoxIngEkle.SelectionStart = 0;
			this.txtBoxIngEkle.ShortcutsEnabled = true;
			this.txtBoxIngEkle.Size = new System.Drawing.Size(169, 23);
			this.txtBoxIngEkle.TabIndex = 24;
			this.txtBoxIngEkle.UseSelectable = true;
			this.txtBoxIngEkle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtBoxIngEkle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lblIngCumle
			// 
			this.lblIngCumle.AutoSize = true;
			this.lblIngCumle.Location = new System.Drawing.Point(435, 143);
			this.lblIngCumle.Name = "lblIngCumle";
			this.lblIngCumle.Size = new System.Drawing.Size(100, 19);
			this.lblIngCumle.TabIndex = 23;
			this.lblIngCumle.Text = "İngilizce Cümle:";
			// 
			// lblTrCumle
			// 
			this.lblTrCumle.AutoSize = true;
			this.lblTrCumle.Location = new System.Drawing.Point(435, 171);
			this.lblTrCumle.Name = "lblTrCumle";
			this.lblTrCumle.Size = new System.Drawing.Size(90, 19);
			this.lblTrCumle.TabIndex = 22;
			this.lblTrCumle.Text = "Türkçe Cümle:";
			// 
			// lblKelimeTuru
			// 
			this.lblKelimeTuru.AutoSize = true;
			this.lblKelimeTuru.Location = new System.Drawing.Point(435, 115);
			this.lblKelimeTuru.Name = "lblKelimeTuru";
			this.lblKelimeTuru.Size = new System.Drawing.Size(96, 19);
			this.lblKelimeTuru.TabIndex = 21;
			this.lblKelimeTuru.Text = "Kelimenin Türü:";
			// 
			// lblTrHaliEkle
			// 
			this.lblTrHaliEkle.AutoSize = true;
			this.lblTrHaliEkle.Location = new System.Drawing.Point(435, 87);
			this.lblTrHaliEkle.Name = "lblTrHaliEkle";
			this.lblTrHaliEkle.Size = new System.Drawing.Size(91, 19);
			this.lblTrHaliEkle.TabIndex = 20;
			this.lblTrHaliEkle.Text = "Türkçe Kelime:";
			// 
			// lblIngHaliEkle
			// 
			this.lblIngHaliEkle.AutoSize = true;
			this.lblIngHaliEkle.Location = new System.Drawing.Point(435, 58);
			this.lblIngHaliEkle.Name = "lblIngHaliEkle";
			this.lblIngHaliEkle.Size = new System.Drawing.Size(101, 19);
			this.lblIngHaliEkle.TabIndex = 19;
			this.lblIngHaliEkle.Text = "İngilizce Kelime:";
			// 
			// lblEklemeBaslik
			// 
			this.lblEklemeBaslik.AutoSize = true;
			this.lblEklemeBaslik.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblEklemeBaslik.Location = new System.Drawing.Point(435, 15);
			this.lblEklemeBaslik.Name = "lblEklemeBaslik";
			this.lblEklemeBaslik.Size = new System.Drawing.Size(155, 25);
			this.lblEklemeBaslik.TabIndex = 18;
			this.lblEklemeBaslik.Text = "Yeni Kelime Ekleyin";
			// 
			// lblAnaEkran
			// 
			this.lblAnaEkran.AutoSize = true;
			this.lblAnaEkran.Location = new System.Drawing.Point(16, 83);
			this.lblAnaEkran.Name = "lblAnaEkran";
			this.lblAnaEkran.Size = new System.Drawing.Size(152, 19);
			this.lblAnaEkran.TabIndex = 2;
			this.lblAnaEkran.Text = "Aradığınız kelimeyi girin:";
			// 
			// tileListeYenile
			// 
			this.tileListeYenile.ActiveControl = null;
			this.tileListeYenile.Location = new System.Drawing.Point(553, 246);
			this.tileListeYenile.Name = "tileListeYenile";
			this.tileListeYenile.Size = new System.Drawing.Size(176, 70);
			this.tileListeYenile.TabIndex = 6;
			this.tileListeYenile.Text = "Listeyi Yenile";
			this.tileListeYenile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.tileListeYenile.UseSelectable = true;
			// 
			// anaEkran
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControlAnaEkran);
			this.Name = "anaEkran";
			this.Text = "Welcome(Hoş Geldiniz!)";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControlAnaEkran.ResumeLayout(false);
			this.tabControlOgrenilmemis.ResumeLayout(false);
			this.tabControlOgrenilmis.ResumeLayout(false);
			this.tabControlYeniEkle.ResumeLayout(false);
			this.tabControlYeniEkle.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroTabControl tabControlAnaEkran;
		private MetroFramework.Controls.MetroTabPage tabControlOgrenilmemis;
		private MetroFramework.Controls.MetroTabPage tabControlOgrenilmis;
		private MetroFramework.Controls.MetroTabPage tabControlYeniEkle;
		private MetroFramework.Controls.MetroLabel lblAnaEkran;
		private MetroFramework.Controls.MetroTile tileOgrenmeyeBasla;
		private MetroFramework.Controls.MetroTile tileSinavaGit;
		private MetroFramework.Controls.MetroTextBox txtBoxTrCumleEkle;
		private MetroFramework.Controls.MetroTextBox txtBoxIngCumleEkle;
		private MetroFramework.Controls.MetroTextBox txtBoxTurEkle;
		private MetroFramework.Controls.MetroTextBox txtBoxTrEkle;
		private MetroFramework.Controls.MetroTextBox txtBoxIngEkle;
		private MetroFramework.Controls.MetroLabel lblIngCumle;
		private MetroFramework.Controls.MetroLabel lblTrCumle;
		private MetroFramework.Controls.MetroLabel lblKelimeTuru;
		private MetroFramework.Controls.MetroLabel lblTrHaliEkle;
		private MetroFramework.Controls.MetroLabel lblIngHaliEkle;
		private MetroFramework.Controls.MetroLabel lblEklemeBaslik;
		private System.Windows.Forms.ListBox listOgrenilmemisIng;
		private MetroFramework.Controls.MetroTile tileIstatistik;
		private System.Windows.Forms.ListBox listOgrenilmis;
		private MetroFramework.Controls.MetroTile tileYeniKelimeEkle;
		private System.Windows.Forms.TextBox txtBoxArama;
		private MetroFramework.Controls.MetroTile tileAra;
		private MetroFramework.Controls.MetroTile tileListeYenile;
	}
}

