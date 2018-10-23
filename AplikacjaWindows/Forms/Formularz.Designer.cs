namespace AplikacjaWindows.Forms {
    partial class Formularz {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			this.Cenniki = new System.Windows.Forms.TabPage();
			this.UsunCennikBtn = new System.Windows.Forms.Button();
			this.EdytujCennikBtn = new System.Windows.Forms.Button();
			this.DodajCennikBtn = new System.Windows.Forms.Button();
			this.CennikiGrid = new System.Windows.Forms.DataGridView();
			this.CennikIDc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CennikNazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Data_Od = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Data_Do = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ceny = new System.Windows.Forms.TabPage();
			this.UsunCeneBtn = new System.Windows.Forms.Button();
			this.EdytujCeneBtn = new System.Windows.Forms.Button();
			this.DodajCeneBtn = new System.Windows.Forms.Button();
			this.CenyGrid = new System.Windows.Forms.DataGridView();
			this.CenaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CennikID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TowarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Rabat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Towary = new System.Windows.Forms.TabPage();
			this.UsunTowarBtn = new System.Windows.Forms.Button();
			this.EdytujTowarBtn = new System.Windows.Forms.Button();
			this.DodajTowarBtn = new System.Windows.Forms.Button();
			this.TowaryGrid = new System.Windows.Forms.DataGridView();
			this.TabControl = new System.Windows.Forms.TabControl();
			this.Podsumowanie = new System.Windows.Forms.TabPage();
			this.Wydruk = new System.Windows.Forms.Button();
			this.PodsumowanieGrid = new System.Windows.Forms.DataGridView();
			this.TowarNazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KodTowaru = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RabatTowaru = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MasaTowaru = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.JMasy = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CenaTowaruX = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Promocja = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PromocjaOd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PromocjaDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CenaZRabatem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Masa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.JM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Data_Utworzenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Data_Modyfikacji = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cenniki.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CennikiGrid)).BeginInit();
			this.Ceny.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CenyGrid)).BeginInit();
			this.Towary.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TowaryGrid)).BeginInit();
			this.TabControl.SuspendLayout();
			this.Podsumowanie.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PodsumowanieGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// Cenniki
			// 
			this.Cenniki.Controls.Add(this.UsunCennikBtn);
			this.Cenniki.Controls.Add(this.EdytujCennikBtn);
			this.Cenniki.Controls.Add(this.DodajCennikBtn);
			this.Cenniki.Controls.Add(this.CennikiGrid);
			this.Cenniki.Location = new System.Drawing.Point(4, 22);
			this.Cenniki.Name = "Cenniki";
			this.Cenniki.Padding = new System.Windows.Forms.Padding(3);
			this.Cenniki.Size = new System.Drawing.Size(1051, 487);
			this.Cenniki.TabIndex = 3;
			this.Cenniki.Text = "Cenniki";
			this.Cenniki.UseVisualStyleBackColor = true;
			// 
			// UsunCennikBtn
			// 
			this.UsunCennikBtn.Location = new System.Drawing.Point(3, 64);
			this.UsunCennikBtn.Name = "UsunCennikBtn";
			this.UsunCennikBtn.Size = new System.Drawing.Size(75, 23);
			this.UsunCennikBtn.TabIndex = 7;
			this.UsunCennikBtn.Text = "Usuń";
			this.UsunCennikBtn.UseVisualStyleBackColor = true;
			this.UsunCennikBtn.Click += new System.EventHandler(this.UsunCennikBtn_Click);
			// 
			// EdytujCennikBtn
			// 
			this.EdytujCennikBtn.Location = new System.Drawing.Point(3, 35);
			this.EdytujCennikBtn.Name = "EdytujCennikBtn";
			this.EdytujCennikBtn.Size = new System.Drawing.Size(75, 23);
			this.EdytujCennikBtn.TabIndex = 6;
			this.EdytujCennikBtn.Text = "Edytuj";
			this.EdytujCennikBtn.UseVisualStyleBackColor = true;
			this.EdytujCennikBtn.Click += new System.EventHandler(this.EdytujCennikBtn_Click);
			// 
			// DodajCennikBtn
			// 
			this.DodajCennikBtn.Location = new System.Drawing.Point(3, 6);
			this.DodajCennikBtn.Name = "DodajCennikBtn";
			this.DodajCennikBtn.Size = new System.Drawing.Size(75, 23);
			this.DodajCennikBtn.TabIndex = 5;
			this.DodajCennikBtn.Text = "Dodaj";
			this.DodajCennikBtn.UseVisualStyleBackColor = true;
			this.DodajCennikBtn.Click += new System.EventHandler(this.DodajCennikBtn_Click);
			// 
			// CennikiGrid
			// 
			this.CennikiGrid.AllowUserToAddRows = false;
			this.CennikiGrid.AllowUserToDeleteRows = false;
			this.CennikiGrid.AllowUserToResizeColumns = false;
			this.CennikiGrid.AllowUserToResizeRows = false;
			this.CennikiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.CennikiGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CennikIDc,
            this.CennikNazwa,
            this.Data_Od,
            this.Data_Do});
			this.CennikiGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.CennikiGrid.Location = new System.Drawing.Point(3, 93);
			this.CennikiGrid.Name = "CennikiGrid";
			this.CennikiGrid.ReadOnly = true;
			this.CennikiGrid.Size = new System.Drawing.Size(1045, 391);
			this.CennikiGrid.TabIndex = 2;
			// 
			// CennikIDc
			// 
			this.CennikIDc.DataPropertyName = "Id";
			this.CennikIDc.HeaderText = "CennikID";
			this.CennikIDc.Name = "CennikIDc";
			this.CennikIDc.ReadOnly = true;
			// 
			// CennikNazwa
			// 
			this.CennikNazwa.DataPropertyName = "Nazwa";
			this.CennikNazwa.HeaderText = "Nazwa";
			this.CennikNazwa.Name = "CennikNazwa";
			this.CennikNazwa.ReadOnly = true;
			// 
			// Data_Od
			// 
			this.Data_Od.DataPropertyName = "Data_Od";
			this.Data_Od.HeaderText = "Data od";
			this.Data_Od.Name = "Data_Od";
			this.Data_Od.ReadOnly = true;
			// 
			// Data_Do
			// 
			this.Data_Do.DataPropertyName = "Data_Do";
			this.Data_Do.HeaderText = "Data Do";
			this.Data_Do.Name = "Data_Do";
			this.Data_Do.ReadOnly = true;
			// 
			// Ceny
			// 
			this.Ceny.Controls.Add(this.UsunCeneBtn);
			this.Ceny.Controls.Add(this.EdytujCeneBtn);
			this.Ceny.Controls.Add(this.DodajCeneBtn);
			this.Ceny.Controls.Add(this.CenyGrid);
			this.Ceny.Location = new System.Drawing.Point(4, 22);
			this.Ceny.Name = "Ceny";
			this.Ceny.Padding = new System.Windows.Forms.Padding(3);
			this.Ceny.Size = new System.Drawing.Size(1051, 487);
			this.Ceny.TabIndex = 2;
			this.Ceny.Text = "Ceny";
			this.Ceny.UseVisualStyleBackColor = true;
			// 
			// UsunCeneBtn
			// 
			this.UsunCeneBtn.Location = new System.Drawing.Point(3, 64);
			this.UsunCeneBtn.Name = "UsunCeneBtn";
			this.UsunCeneBtn.Size = new System.Drawing.Size(75, 23);
			this.UsunCeneBtn.TabIndex = 4;
			this.UsunCeneBtn.Text = "Usuń";
			this.UsunCeneBtn.UseVisualStyleBackColor = true;
			this.UsunCeneBtn.Click += new System.EventHandler(this.UsunCeneBtn_Click);
			// 
			// EdytujCeneBtn
			// 
			this.EdytujCeneBtn.Location = new System.Drawing.Point(3, 35);
			this.EdytujCeneBtn.Name = "EdytujCeneBtn";
			this.EdytujCeneBtn.Size = new System.Drawing.Size(75, 23);
			this.EdytujCeneBtn.TabIndex = 3;
			this.EdytujCeneBtn.Text = "Edytuj";
			this.EdytujCeneBtn.UseVisualStyleBackColor = true;
			this.EdytujCeneBtn.Click += new System.EventHandler(this.EdytujCeneBtn_Click);
			// 
			// DodajCeneBtn
			// 
			this.DodajCeneBtn.Location = new System.Drawing.Point(3, 6);
			this.DodajCeneBtn.Name = "DodajCeneBtn";
			this.DodajCeneBtn.Size = new System.Drawing.Size(75, 23);
			this.DodajCeneBtn.TabIndex = 2;
			this.DodajCeneBtn.Text = "Dodaj";
			this.DodajCeneBtn.UseVisualStyleBackColor = true;
			this.DodajCeneBtn.Click += new System.EventHandler(this.DodajCeneBtn_Click);
			// 
			// CenyGrid
			// 
			this.CenyGrid.AllowUserToAddRows = false;
			this.CenyGrid.AllowUserToDeleteRows = false;
			this.CenyGrid.AllowUserToResizeColumns = false;
			this.CenyGrid.AllowUserToResizeRows = false;
			this.CenyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.CenyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CenaID,
            this.CennikID,
            this.TowarId,
            this.Cena,
            this.Rabat});
			this.CenyGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.CenyGrid.Location = new System.Drawing.Point(3, 93);
			this.CenyGrid.Name = "CenyGrid";
			this.CenyGrid.ReadOnly = true;
			this.CenyGrid.RowHeadersWidth = 50;
			this.CenyGrid.Size = new System.Drawing.Size(1045, 391);
			this.CenyGrid.TabIndex = 1;
			// 
			// CenaID
			// 
			this.CenaID.DataPropertyName = "Id";
			this.CenaID.HeaderText = "CenaID";
			this.CenaID.Name = "CenaID";
			this.CenaID.ReadOnly = true;
			// 
			// CennikID
			// 
			this.CennikID.DataPropertyName = "CennikId";
			this.CennikID.HeaderText = "CennikID";
			this.CennikID.Name = "CennikID";
			this.CennikID.ReadOnly = true;
			// 
			// TowarId
			// 
			this.TowarId.DataPropertyName = "TowarId";
			this.TowarId.HeaderText = "TowarId";
			this.TowarId.Name = "TowarId";
			this.TowarId.ReadOnly = true;
			// 
			// Cena
			// 
			this.Cena.DataPropertyName = "Cena";
			this.Cena.HeaderText = "Cena";
			this.Cena.Name = "Cena";
			this.Cena.ReadOnly = true;
			// 
			// Rabat
			// 
			this.Rabat.DataPropertyName = "Rabat";
			this.Rabat.HeaderText = "Rabat";
			this.Rabat.Name = "Rabat";
			this.Rabat.ReadOnly = true;
			// 
			// Towary
			// 
			this.Towary.Controls.Add(this.UsunTowarBtn);
			this.Towary.Controls.Add(this.EdytujTowarBtn);
			this.Towary.Controls.Add(this.DodajTowarBtn);
			this.Towary.Controls.Add(this.TowaryGrid);
			this.Towary.Location = new System.Drawing.Point(4, 22);
			this.Towary.Name = "Towary";
			this.Towary.Padding = new System.Windows.Forms.Padding(3);
			this.Towary.Size = new System.Drawing.Size(1051, 487);
			this.Towary.TabIndex = 1;
			this.Towary.Text = "Towary";
			this.Towary.UseVisualStyleBackColor = true;
			// 
			// UsunTowarBtn
			// 
			this.UsunTowarBtn.Location = new System.Drawing.Point(3, 64);
			this.UsunTowarBtn.Name = "UsunTowarBtn";
			this.UsunTowarBtn.Size = new System.Drawing.Size(75, 23);
			this.UsunTowarBtn.TabIndex = 3;
			this.UsunTowarBtn.Text = "Usuń";
			this.UsunTowarBtn.UseVisualStyleBackColor = true;
			this.UsunTowarBtn.Click += new System.EventHandler(this.UsunTowarBtn_Click);
			// 
			// EdytujTowarBtn
			// 
			this.EdytujTowarBtn.Location = new System.Drawing.Point(3, 35);
			this.EdytujTowarBtn.Name = "EdytujTowarBtn";
			this.EdytujTowarBtn.Size = new System.Drawing.Size(75, 23);
			this.EdytujTowarBtn.TabIndex = 2;
			this.EdytujTowarBtn.Text = "Edytuj";
			this.EdytujTowarBtn.UseVisualStyleBackColor = true;
			this.EdytujTowarBtn.Click += new System.EventHandler(this.EdytujTowarBtn_Click);
			// 
			// DodajTowarBtn
			// 
			this.DodajTowarBtn.Location = new System.Drawing.Point(3, 6);
			this.DodajTowarBtn.Name = "DodajTowarBtn";
			this.DodajTowarBtn.Size = new System.Drawing.Size(75, 23);
			this.DodajTowarBtn.TabIndex = 1;
			this.DodajTowarBtn.Text = "Dodaj";
			this.DodajTowarBtn.UseVisualStyleBackColor = true;
			this.DodajTowarBtn.Click += new System.EventHandler(this.DodajTowarBtn_Click);
			// 
			// TowaryGrid
			// 
			this.TowaryGrid.AllowUserToAddRows = false;
			this.TowaryGrid.AllowUserToDeleteRows = false;
			this.TowaryGrid.AllowUserToResizeColumns = false;
			this.TowaryGrid.AllowUserToResizeRows = false;
			this.TowaryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TowaryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kod,
            this.Nazwa,
            this.Masa,
            this.JM,
            this.Data_Utworzenia,
            this.Data_Modyfikacji});
			this.TowaryGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.TowaryGrid.Location = new System.Drawing.Point(3, 93);
			this.TowaryGrid.Name = "TowaryGrid";
			this.TowaryGrid.ReadOnly = true;
			this.TowaryGrid.RowHeadersWidth = 50;
			this.TowaryGrid.Size = new System.Drawing.Size(1045, 391);
			this.TowaryGrid.TabIndex = 0;
			// 
			// TabControl
			// 
			this.TabControl.Controls.Add(this.Towary);
			this.TabControl.Controls.Add(this.Ceny);
			this.TabControl.Controls.Add(this.Cenniki);
			this.TabControl.Controls.Add(this.Podsumowanie);
			this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabControl.Location = new System.Drawing.Point(0, 0);
			this.TabControl.Name = "TabControl";
			this.TabControl.SelectedIndex = 0;
			this.TabControl.Size = new System.Drawing.Size(1059, 513);
			this.TabControl.TabIndex = 0;
			this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
			// 
			// Podsumowanie
			// 
			this.Podsumowanie.Controls.Add(this.Wydruk);
			this.Podsumowanie.Controls.Add(this.PodsumowanieGrid);
			this.Podsumowanie.Location = new System.Drawing.Point(4, 22);
			this.Podsumowanie.Name = "Podsumowanie";
			this.Podsumowanie.Padding = new System.Windows.Forms.Padding(3);
			this.Podsumowanie.Size = new System.Drawing.Size(1051, 487);
			this.Podsumowanie.TabIndex = 4;
			this.Podsumowanie.Text = "Podsumowanie";
			this.Podsumowanie.UseVisualStyleBackColor = true;
			// 
			// Wydruk
			// 
			this.Wydruk.Location = new System.Drawing.Point(8, 6);
			this.Wydruk.Name = "Wydruk";
			this.Wydruk.Size = new System.Drawing.Size(1040, 47);
			this.Wydruk.TabIndex = 1;
			this.Wydruk.Text = "ZAPISZ PLIK PDF";
			this.Wydruk.UseVisualStyleBackColor = true;
			this.Wydruk.Click += new System.EventHandler(this.Wydruk_Click);
			// 
			// PodsumowanieGrid
			// 
			this.PodsumowanieGrid.AllowUserToAddRows = false;
			this.PodsumowanieGrid.AllowUserToDeleteRows = false;
			this.PodsumowanieGrid.AllowUserToResizeColumns = false;
			this.PodsumowanieGrid.AllowUserToResizeRows = false;
			this.PodsumowanieGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.PodsumowanieGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TowarNazwa,
            this.KodTowaru,
            this.RabatTowaru,
            this.MasaTowaru,
            this.JMasy,
            this.CenaTowaruX,
            this.Promocja,
            this.PromocjaOd,
            this.PromocjaDo,
            this.CenaZRabatem});
			this.PodsumowanieGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.PodsumowanieGrid.Location = new System.Drawing.Point(3, 65);
			this.PodsumowanieGrid.Name = "PodsumowanieGrid";
			this.PodsumowanieGrid.ReadOnly = true;
			this.PodsumowanieGrid.Size = new System.Drawing.Size(1045, 419);
			this.PodsumowanieGrid.TabIndex = 0;
			// 
			// TowarNazwa
			// 
			this.TowarNazwa.DataPropertyName = "Nazwa";
			this.TowarNazwa.HeaderText = "Nazwa Towaru";
			this.TowarNazwa.Name = "TowarNazwa";
			this.TowarNazwa.ReadOnly = true;
			// 
			// KodTowaru
			// 
			this.KodTowaru.DataPropertyName = "Kod";
			this.KodTowaru.HeaderText = "Kod";
			this.KodTowaru.Name = "KodTowaru";
			this.KodTowaru.ReadOnly = true;
			// 
			// RabatTowaru
			// 
			this.RabatTowaru.DataPropertyName = "Rabat";
			this.RabatTowaru.HeaderText = "Rabat";
			this.RabatTowaru.Name = "RabatTowaru";
			this.RabatTowaru.ReadOnly = true;
			// 
			// MasaTowaru
			// 
			this.MasaTowaru.DataPropertyName = "Masa";
			this.MasaTowaru.HeaderText = "Masa";
			this.MasaTowaru.Name = "MasaTowaru";
			this.MasaTowaru.ReadOnly = true;
			// 
			// JMasy
			// 
			this.JMasy.DataPropertyName = "JM";
			this.JMasy.HeaderText = "JM";
			this.JMasy.Name = "JMasy";
			this.JMasy.ReadOnly = true;
			// 
			// CenaTowaruX
			// 
			this.CenaTowaruX.DataPropertyName = "Cena";
			this.CenaTowaruX.HeaderText = "Cena Towaru";
			this.CenaTowaruX.Name = "CenaTowaruX";
			this.CenaTowaruX.ReadOnly = true;
			// 
			// Promocja
			// 
			this.Promocja.DataPropertyName = "Nazwa1";
			this.Promocja.HeaderText = "Promocja";
			this.Promocja.Name = "Promocja";
			this.Promocja.ReadOnly = true;
			// 
			// PromocjaOd
			// 
			this.PromocjaOd.DataPropertyName = "Data_od";
			this.PromocjaOd.HeaderText = "Promocja od";
			this.PromocjaOd.Name = "PromocjaOd";
			this.PromocjaOd.ReadOnly = true;
			// 
			// PromocjaDo
			// 
			this.PromocjaDo.DataPropertyName = "Data_do";
			this.PromocjaDo.HeaderText = "Promocja Do";
			this.PromocjaDo.Name = "PromocjaDo";
			this.PromocjaDo.ReadOnly = true;
			// 
			// CenaZRabatem
			// 
			this.CenaZRabatem.HeaderText = "Cena z Rabatem";
			this.CenaZRabatem.Name = "CenaZRabatem";
			this.CenaZRabatem.ReadOnly = true;
			// 
			// Kod
			// 
			this.Kod.DataPropertyName = "Kod";
			this.Kod.HeaderText = "Kod";
			this.Kod.Name = "Kod";
			this.Kod.ReadOnly = true;
			// 
			// Nazwa
			// 
			this.Nazwa.DataPropertyName = "Nazwa";
			this.Nazwa.HeaderText = "Nazwa";
			this.Nazwa.Name = "Nazwa";
			this.Nazwa.ReadOnly = true;
			// 
			// Masa
			// 
			this.Masa.DataPropertyName = "Masa";
			this.Masa.HeaderText = "Masa";
			this.Masa.Name = "Masa";
			this.Masa.ReadOnly = true;
			// 
			// JM
			// 
			this.JM.DataPropertyName = "JM";
			this.JM.HeaderText = "JM";
			this.JM.Name = "JM";
			this.JM.ReadOnly = true;
			// 
			// Data_Utworzenia
			// 
			this.Data_Utworzenia.DataPropertyName = "Data_Utworzenia";
			this.Data_Utworzenia.HeaderText = "Data Utworzenia";
			this.Data_Utworzenia.Name = "Data_Utworzenia";
			this.Data_Utworzenia.ReadOnly = true;
			// 
			// Data_Modyfikacji
			// 
			this.Data_Modyfikacji.DataPropertyName = "Data_Modyfikacji";
			this.Data_Modyfikacji.HeaderText = "Data Modyfikacji";
			this.Data_Modyfikacji.Name = "Data_Modyfikacji";
			this.Data_Modyfikacji.ReadOnly = true;
			// 
			// Formularz
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1059, 513);
			this.Controls.Add(this.TabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(973, 552);
			this.Name = "Formularz";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FORMULARZ TOWAROWY";
			this.Load += new System.EventHandler(this.Formularz_Load);
			this.Cenniki.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.CennikiGrid)).EndInit();
			this.Ceny.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.CenyGrid)).EndInit();
			this.Towary.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.TowaryGrid)).EndInit();
			this.TabControl.ResumeLayout(false);
			this.Podsumowanie.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PodsumowanieGrid)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion
		private System.Windows.Forms.TabPage Cenniki;
		private System.Windows.Forms.Button UsunCennikBtn;
		private System.Windows.Forms.Button EdytujCennikBtn;
		private System.Windows.Forms.Button DodajCennikBtn;
		private System.Windows.Forms.DataGridView CennikiGrid;
		private System.Windows.Forms.TabPage Ceny;
		private System.Windows.Forms.Button UsunCeneBtn;
		private System.Windows.Forms.Button EdytujCeneBtn;
		private System.Windows.Forms.Button DodajCeneBtn;
		private System.Windows.Forms.DataGridView CenyGrid;
		private System.Windows.Forms.TabPage Towary;
		private System.Windows.Forms.Button UsunTowarBtn;
		private System.Windows.Forms.Button EdytujTowarBtn;
		private System.Windows.Forms.Button DodajTowarBtn;
		private System.Windows.Forms.DataGridView TowaryGrid;
		private System.Windows.Forms.TabControl TabControl;
		private System.Windows.Forms.DataGridViewTextBoxColumn CenaID;
		private System.Windows.Forms.DataGridViewTextBoxColumn CennikID;
		private System.Windows.Forms.DataGridViewTextBoxColumn TowarId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
		private System.Windows.Forms.DataGridViewTextBoxColumn Rabat;
		private System.Windows.Forms.DataGridViewTextBoxColumn CennikIDc;
		private System.Windows.Forms.DataGridViewTextBoxColumn CennikNazwa;
		private System.Windows.Forms.DataGridViewTextBoxColumn Data_Od;
		private System.Windows.Forms.DataGridViewTextBoxColumn Data_Do;
		private System.Windows.Forms.TabPage Podsumowanie;
		private System.Windows.Forms.DataGridView PodsumowanieGrid;
		private System.Windows.Forms.Button Wydruk;
		private System.Windows.Forms.DataGridViewTextBoxColumn TowarNazwa;
		private System.Windows.Forms.DataGridViewTextBoxColumn KodTowaru;
		private System.Windows.Forms.DataGridViewTextBoxColumn RabatTowaru;
		private System.Windows.Forms.DataGridViewTextBoxColumn MasaTowaru;
		private System.Windows.Forms.DataGridViewTextBoxColumn JMasy;
		private System.Windows.Forms.DataGridViewTextBoxColumn CenaTowaruX;
		private System.Windows.Forms.DataGridViewTextBoxColumn Promocja;
		private System.Windows.Forms.DataGridViewTextBoxColumn PromocjaOd;
		private System.Windows.Forms.DataGridViewTextBoxColumn PromocjaDo;
		private System.Windows.Forms.DataGridViewTextBoxColumn CenaZRabatem;
		private System.Windows.Forms.DataGridViewTextBoxColumn Kod;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
		private System.Windows.Forms.DataGridViewTextBoxColumn Masa;
		private System.Windows.Forms.DataGridViewTextBoxColumn JM;
		private System.Windows.Forms.DataGridViewTextBoxColumn Data_Utworzenia;
		private System.Windows.Forms.DataGridViewTextBoxColumn Data_Modyfikacji;
	}
}

