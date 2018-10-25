namespace AplikacjaWindows.Forms {
    partial class MainForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.Cenniki = new System.Windows.Forms.TabPage();
			this.DeletePriceListBtn = new System.Windows.Forms.Button();
			this.EditPriceListBtn = new System.Windows.Forms.Button();
			this.AddPriceListBtn = new System.Windows.Forms.Button();
			this.CennikiGrid = new System.Windows.Forms.DataGridView();
			this.CennikIDc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CennikNazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Data_Od = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Data_Do = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ceny = new System.Windows.Forms.TabPage();
			this.DeletePriceBtn = new System.Windows.Forms.Button();
			this.EditPriceBtn = new System.Windows.Forms.Button();
			this.AddPriceBtn = new System.Windows.Forms.Button();
			this.CenyGrid = new System.Windows.Forms.DataGridView();
			this.Towary = new System.Windows.Forms.TabPage();
			this.DeleteProductBtn = new System.Windows.Forms.Button();
			this.EditProductBtn = new System.Windows.Forms.Button();
			this.AddProduktBtn = new System.Windows.Forms.Button();
			this.ProductsGrid = new System.Windows.Forms.DataGridView();
			this.Kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Masa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.JM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Data_Utworzenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Data_Modyfikacji = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TabControl = new System.Windows.Forms.TabControl();
			this.Podsumowanie = new System.Windows.Forms.TabPage();
			this.PrintButton = new System.Windows.Forms.Button();
			this.ExportPDF = new System.Windows.Forms.Button();
			this.PodsumowanieGrid = new System.Windows.Forms.DataGridView();
			this.TowarNazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KodTowaru = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MasaTowaru = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.JMasy = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Promocja = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PromocjaOd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PromocjaDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CenaZRabatem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
			this.printSummaryGrid = new System.Drawing.Printing.PrintDocument();
			this.CenaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Towar = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Rabat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cennik = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cenniki.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CennikiGrid)).BeginInit();
			this.Ceny.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CenyGrid)).BeginInit();
			this.Towary.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).BeginInit();
			this.TabControl.SuspendLayout();
			this.Podsumowanie.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PodsumowanieGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// Cenniki
			// 
			this.Cenniki.Controls.Add(this.DeletePriceListBtn);
			this.Cenniki.Controls.Add(this.EditPriceListBtn);
			this.Cenniki.Controls.Add(this.AddPriceListBtn);
			this.Cenniki.Controls.Add(this.CennikiGrid);
			this.Cenniki.Location = new System.Drawing.Point(4, 22);
			this.Cenniki.Name = "Cenniki";
			this.Cenniki.Padding = new System.Windows.Forms.Padding(3);
			this.Cenniki.Size = new System.Drawing.Size(1051, 487);
			this.Cenniki.TabIndex = 3;
			this.Cenniki.Text = "Cenniki";
			this.Cenniki.UseVisualStyleBackColor = true;
			// 
			// DeletePriceListBtn
			// 
			this.DeletePriceListBtn.Location = new System.Drawing.Point(3, 64);
			this.DeletePriceListBtn.Name = "DeletePriceListBtn";
			this.DeletePriceListBtn.Size = new System.Drawing.Size(75, 23);
			this.DeletePriceListBtn.TabIndex = 7;
			this.DeletePriceListBtn.Text = "Usuń";
			this.DeletePriceListBtn.UseVisualStyleBackColor = true;
			this.DeletePriceListBtn.Click += new System.EventHandler(this.DeletePriceListBtn_Click);
			// 
			// EditPriceListBtn
			// 
			this.EditPriceListBtn.Location = new System.Drawing.Point(3, 35);
			this.EditPriceListBtn.Name = "EditPriceListBtn";
			this.EditPriceListBtn.Size = new System.Drawing.Size(75, 23);
			this.EditPriceListBtn.TabIndex = 6;
			this.EditPriceListBtn.Text = "Edytuj";
			this.EditPriceListBtn.UseVisualStyleBackColor = true;
			this.EditPriceListBtn.Click += new System.EventHandler(this.EditPriceListBtn_Click);
			// 
			// AddPriceListBtn
			// 
			this.AddPriceListBtn.Location = new System.Drawing.Point(3, 6);
			this.AddPriceListBtn.Name = "AddPriceListBtn";
			this.AddPriceListBtn.Size = new System.Drawing.Size(75, 23);
			this.AddPriceListBtn.TabIndex = 5;
			this.AddPriceListBtn.Text = "Dodaj";
			this.AddPriceListBtn.UseVisualStyleBackColor = true;
			this.AddPriceListBtn.Click += new System.EventHandler(this.AddPriceListBtn_Click);
			// 
			// CennikiGrid
			// 
			this.CennikiGrid.AllowUserToAddRows = false;
			this.CennikiGrid.AllowUserToDeleteRows = false;
			this.CennikiGrid.AllowUserToResizeColumns = false;
			this.CennikiGrid.AllowUserToResizeRows = false;
			this.CennikiGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.CennikiGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.CennikiGrid.ColumnHeadersHeight = 30;
			this.CennikiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.CennikiGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CennikIDc,
            this.CennikNazwa,
            this.Data_Od,
            this.Data_Do});
			this.CennikiGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.CennikiGrid.Location = new System.Drawing.Point(3, 93);
			this.CennikiGrid.Name = "CennikiGrid";
			this.CennikiGrid.ReadOnly = true;
			this.CennikiGrid.RowHeadersWidth = 50;
			this.CennikiGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.CennikiGrid.Size = new System.Drawing.Size(1045, 391);
			this.CennikiGrid.TabIndex = 2;
			// 
			// CennikIDc
			// 
			this.CennikIDc.DataPropertyName = "Id";
			this.CennikIDc.HeaderText = "CennikID";
			this.CennikIDc.Name = "CennikIDc";
			this.CennikIDc.ReadOnly = true;
			this.CennikIDc.Visible = false;
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
			this.Ceny.Controls.Add(this.DeletePriceBtn);
			this.Ceny.Controls.Add(this.EditPriceBtn);
			this.Ceny.Controls.Add(this.AddPriceBtn);
			this.Ceny.Controls.Add(this.CenyGrid);
			this.Ceny.Location = new System.Drawing.Point(4, 22);
			this.Ceny.Name = "Ceny";
			this.Ceny.Padding = new System.Windows.Forms.Padding(3);
			this.Ceny.Size = new System.Drawing.Size(1051, 487);
			this.Ceny.TabIndex = 2;
			this.Ceny.Text = "Ceny";
			this.Ceny.UseVisualStyleBackColor = true;
			// 
			// DeletePriceBtn
			// 
			this.DeletePriceBtn.Location = new System.Drawing.Point(3, 64);
			this.DeletePriceBtn.Name = "DeletePriceBtn";
			this.DeletePriceBtn.Size = new System.Drawing.Size(75, 23);
			this.DeletePriceBtn.TabIndex = 4;
			this.DeletePriceBtn.Text = "Usuń";
			this.DeletePriceBtn.UseVisualStyleBackColor = true;
			this.DeletePriceBtn.Click += new System.EventHandler(this.DeletePriceBtn_Click);
			// 
			// EditPriceBtn
			// 
			this.EditPriceBtn.Location = new System.Drawing.Point(3, 35);
			this.EditPriceBtn.Name = "EditPriceBtn";
			this.EditPriceBtn.Size = new System.Drawing.Size(75, 23);
			this.EditPriceBtn.TabIndex = 3;
			this.EditPriceBtn.Text = "Edytuj";
			this.EditPriceBtn.UseVisualStyleBackColor = true;
			this.EditPriceBtn.Click += new System.EventHandler(this.EditPriceBtn_Click);
			// 
			// AddPriceBtn
			// 
			this.AddPriceBtn.Location = new System.Drawing.Point(3, 6);
			this.AddPriceBtn.Name = "AddPriceBtn";
			this.AddPriceBtn.Size = new System.Drawing.Size(75, 23);
			this.AddPriceBtn.TabIndex = 2;
			this.AddPriceBtn.Text = "Dodaj";
			this.AddPriceBtn.UseVisualStyleBackColor = true;
			this.AddPriceBtn.Click += new System.EventHandler(this.AddPriceBtn_Click);
			// 
			// CenyGrid
			// 
			this.CenyGrid.AllowUserToAddRows = false;
			this.CenyGrid.AllowUserToDeleteRows = false;
			this.CenyGrid.AllowUserToResizeColumns = false;
			this.CenyGrid.AllowUserToResizeRows = false;
			this.CenyGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.CenyGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.CenyGrid.ColumnHeadersHeight = 30;
			this.CenyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.CenyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CenaID,
            this.Towar,
            this.Cena,
            this.Rabat,
            this.Cennik});
			this.CenyGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.CenyGrid.Location = new System.Drawing.Point(3, 93);
			this.CenyGrid.Name = "CenyGrid";
			this.CenyGrid.ReadOnly = true;
			this.CenyGrid.RowHeadersWidth = 50;
			this.CenyGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.CenyGrid.Size = new System.Drawing.Size(1045, 391);
			this.CenyGrid.TabIndex = 1;
			// 
			// Towary
			// 
			this.Towary.Controls.Add(this.DeleteProductBtn);
			this.Towary.Controls.Add(this.EditProductBtn);
			this.Towary.Controls.Add(this.AddProduktBtn);
			this.Towary.Controls.Add(this.ProductsGrid);
			this.Towary.Location = new System.Drawing.Point(4, 22);
			this.Towary.Name = "Towary";
			this.Towary.Padding = new System.Windows.Forms.Padding(3);
			this.Towary.Size = new System.Drawing.Size(1051, 487);
			this.Towary.TabIndex = 1;
			this.Towary.Text = "Towary";
			this.Towary.UseVisualStyleBackColor = true;
			// 
			// DeleteProductBtn
			// 
			this.DeleteProductBtn.Location = new System.Drawing.Point(3, 64);
			this.DeleteProductBtn.Name = "DeleteProductBtn";
			this.DeleteProductBtn.Size = new System.Drawing.Size(75, 23);
			this.DeleteProductBtn.TabIndex = 3;
			this.DeleteProductBtn.Text = "Usuń";
			this.DeleteProductBtn.UseVisualStyleBackColor = true;
			this.DeleteProductBtn.Click += new System.EventHandler(this.DeleteProductBtn_Click);
			// 
			// EditProductBtn
			// 
			this.EditProductBtn.Location = new System.Drawing.Point(3, 35);
			this.EditProductBtn.Name = "EditProductBtn";
			this.EditProductBtn.Size = new System.Drawing.Size(75, 23);
			this.EditProductBtn.TabIndex = 2;
			this.EditProductBtn.Text = "Edytuj";
			this.EditProductBtn.UseVisualStyleBackColor = true;
			this.EditProductBtn.Click += new System.EventHandler(this.EditProductBtn_Click);
			// 
			// AddProduktBtn
			// 
			this.AddProduktBtn.Location = new System.Drawing.Point(3, 6);
			this.AddProduktBtn.Name = "AddProduktBtn";
			this.AddProduktBtn.Size = new System.Drawing.Size(75, 23);
			this.AddProduktBtn.TabIndex = 1;
			this.AddProduktBtn.Text = "Dodaj";
			this.AddProduktBtn.UseVisualStyleBackColor = true;
			this.AddProduktBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
			// 
			// ProductsGrid
			// 
			this.ProductsGrid.AllowUserToAddRows = false;
			this.ProductsGrid.AllowUserToDeleteRows = false;
			this.ProductsGrid.AllowUserToOrderColumns = true;
			this.ProductsGrid.AllowUserToResizeColumns = false;
			this.ProductsGrid.AllowUserToResizeRows = false;
			this.ProductsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.ProductsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.ProductsGrid.ColumnHeadersHeight = 30;
			this.ProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.ProductsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kod,
            this.Nazwa,
            this.Masa,
            this.JM,
            this.Data_Utworzenia,
            this.Data_Modyfikacji});
			this.ProductsGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ProductsGrid.Location = new System.Drawing.Point(3, 93);
			this.ProductsGrid.Name = "ProductsGrid";
			this.ProductsGrid.ReadOnly = true;
			this.ProductsGrid.RowHeadersWidth = 50;
			this.ProductsGrid.Size = new System.Drawing.Size(1045, 391);
			this.ProductsGrid.TabIndex = 0;
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
			this.Podsumowanie.Controls.Add(this.PrintButton);
			this.Podsumowanie.Controls.Add(this.ExportPDF);
			this.Podsumowanie.Controls.Add(this.PodsumowanieGrid);
			this.Podsumowanie.Location = new System.Drawing.Point(4, 22);
			this.Podsumowanie.Name = "Podsumowanie";
			this.Podsumowanie.Padding = new System.Windows.Forms.Padding(3);
			this.Podsumowanie.Size = new System.Drawing.Size(1051, 487);
			this.Podsumowanie.TabIndex = 4;
			this.Podsumowanie.Text = "Podsumowanie";
			this.Podsumowanie.UseVisualStyleBackColor = true;
			// 
			// PrintButton
			// 
			this.PrintButton.Location = new System.Drawing.Point(9, 6);
			this.PrintButton.Name = "PrintButton";
			this.PrintButton.Size = new System.Drawing.Size(150, 47);
			this.PrintButton.TabIndex = 2;
			this.PrintButton.Text = "Wydrukuj";
			this.PrintButton.UseVisualStyleBackColor = true;
			this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
			// 
			// ExportPDF
			// 
			this.ExportPDF.Location = new System.Drawing.Point(794, 6);
			this.ExportPDF.Name = "ExportPDF";
			this.ExportPDF.Size = new System.Drawing.Size(254, 47);
			this.ExportPDF.TabIndex = 1;
			this.ExportPDF.Text = "ZAPISZ PLIK PDF";
			this.ExportPDF.UseVisualStyleBackColor = true;
			this.ExportPDF.Click += new System.EventHandler(this.ExportPDF_Click);
			// 
			// PodsumowanieGrid
			// 
			this.PodsumowanieGrid.AllowUserToAddRows = false;
			this.PodsumowanieGrid.AllowUserToDeleteRows = false;
			this.PodsumowanieGrid.AllowUserToResizeColumns = false;
			this.PodsumowanieGrid.AllowUserToResizeRows = false;
			this.PodsumowanieGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.PodsumowanieGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.PodsumowanieGrid.ColumnHeadersHeight = 40;
			this.PodsumowanieGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.PodsumowanieGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TowarNazwa,
            this.KodTowaru,
            this.MasaTowaru,
            this.JMasy,
            this.ProductPrice,
            this.Discount,
            this.Promocja,
            this.PromocjaOd,
            this.PromocjaDo,
            this.CenaZRabatem});
			this.PodsumowanieGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.PodsumowanieGrid.Location = new System.Drawing.Point(3, 59);
			this.PodsumowanieGrid.Name = "PodsumowanieGrid";
			this.PodsumowanieGrid.ReadOnly = true;
			this.PodsumowanieGrid.RowHeadersWidth = 50;
			this.PodsumowanieGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.PodsumowanieGrid.Size = new System.Drawing.Size(1045, 425);
			this.PodsumowanieGrid.TabIndex = 0;
			// 
			// TowarNazwa
			// 
			this.TowarNazwa.DataPropertyName = "ProductName";
			this.TowarNazwa.HeaderText = "Nazwa Towaru";
			this.TowarNazwa.Name = "TowarNazwa";
			this.TowarNazwa.ReadOnly = true;
			// 
			// KodTowaru
			// 
			this.KodTowaru.DataPropertyName = "ProductCode";
			this.KodTowaru.HeaderText = "Kod";
			this.KodTowaru.Name = "KodTowaru";
			this.KodTowaru.ReadOnly = true;
			// 
			// MasaTowaru
			// 
			this.MasaTowaru.DataPropertyName = "ProductWeight";
			this.MasaTowaru.HeaderText = "Masa";
			this.MasaTowaru.Name = "MasaTowaru";
			this.MasaTowaru.ReadOnly = true;
			// 
			// JMasy
			// 
			this.JMasy.DataPropertyName = "UnitWeight";
			this.JMasy.HeaderText = "JM";
			this.JMasy.Name = "JMasy";
			this.JMasy.ReadOnly = true;
			// 
			// ProductPrice
			// 
			this.ProductPrice.DataPropertyName = "ProductPrice";
			this.ProductPrice.HeaderText = "Cena Towaru";
			this.ProductPrice.Name = "ProductPrice";
			this.ProductPrice.ReadOnly = true;
			// 
			// Discount
			// 
			this.Discount.DataPropertyName = "Discount";
			this.Discount.HeaderText = "Rabat";
			this.Discount.Name = "Discount";
			this.Discount.ReadOnly = true;
			// 
			// Promocja
			// 
			this.Promocja.DataPropertyName = "Promotion";
			this.Promocja.HeaderText = "Promocja";
			this.Promocja.Name = "Promocja";
			this.Promocja.ReadOnly = true;
			// 
			// PromocjaOd
			// 
			this.PromocjaOd.DataPropertyName = "PromoStart";
			this.PromocjaOd.HeaderText = "Promocja od";
			this.PromocjaOd.Name = "PromocjaOd";
			this.PromocjaOd.ReadOnly = true;
			// 
			// PromocjaDo
			// 
			this.PromocjaDo.DataPropertyName = "PromoEnd";
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
			// printPreview
			// 
			this.printPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreview.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreview.Document = this.printSummaryGrid;
			this.printPreview.Enabled = true;
			this.printPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreview.Icon")));
			this.printPreview.Name = "printPreviewDialog1";
			this.printPreview.Visible = false;
			// 
			// printSummaryGrid
			// 
			this.printSummaryGrid.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printSummaryGrid_PrintPage);
			// 
			// CenaID
			// 
			this.CenaID.DataPropertyName = "PriceID";
			this.CenaID.HeaderText = "Cena ID";
			this.CenaID.Name = "CenaID";
			this.CenaID.ReadOnly = true;
			this.CenaID.Visible = false;
			// 
			// Towar
			// 
			this.Towar.DataPropertyName = "ProductName";
			this.Towar.HeaderText = "Towar";
			this.Towar.Name = "Towar";
			this.Towar.ReadOnly = true;
			// 
			// Cena
			// 
			this.Cena.DataPropertyName = "Price";
			this.Cena.HeaderText = "Cena";
			this.Cena.Name = "Cena";
			this.Cena.ReadOnly = true;
			// 
			// Rabat
			// 
			this.Rabat.DataPropertyName = "Discount";
			this.Rabat.HeaderText = "Rabat";
			this.Rabat.Name = "Rabat";
			this.Rabat.ReadOnly = true;
			// 
			// Cennik
			// 
			this.Cennik.DataPropertyName = "PriceListName";
			this.Cennik.HeaderText = "Cennik";
			this.Cennik.Name = "Cennik";
			this.Cennik.ReadOnly = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1059, 513);
			this.Controls.Add(this.TabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(973, 552);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FORMULARZ TOWAROWY";
			this.Load += new System.EventHandler(this.Formularz_Load);
			this.Cenniki.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.CennikiGrid)).EndInit();
			this.Ceny.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.CenyGrid)).EndInit();
			this.Towary.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).EndInit();
			this.TabControl.ResumeLayout(false);
			this.Podsumowanie.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PodsumowanieGrid)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion
		private System.Windows.Forms.TabPage Cenniki;
		private System.Windows.Forms.Button DeletePriceListBtn;
		private System.Windows.Forms.Button EditPriceListBtn;
		private System.Windows.Forms.Button AddPriceListBtn;
		private System.Windows.Forms.DataGridView CennikiGrid;
		private System.Windows.Forms.TabPage Ceny;
		private System.Windows.Forms.Button DeletePriceBtn;
		private System.Windows.Forms.Button EditPriceBtn;
		private System.Windows.Forms.Button AddPriceBtn;
		private System.Windows.Forms.TabPage Towary;
		private System.Windows.Forms.Button DeleteProductBtn;
		private System.Windows.Forms.Button EditProductBtn;
		private System.Windows.Forms.Button AddProduktBtn;
		private System.Windows.Forms.DataGridView ProductsGrid;
		private System.Windows.Forms.TabControl TabControl;
		private System.Windows.Forms.TabPage Podsumowanie;
		private System.Windows.Forms.DataGridView PodsumowanieGrid;
		private System.Windows.Forms.Button ExportPDF;
		private System.Windows.Forms.DataGridViewTextBoxColumn Kod;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
		private System.Windows.Forms.DataGridViewTextBoxColumn Masa;
		private System.Windows.Forms.DataGridViewTextBoxColumn JM;
		private System.Windows.Forms.DataGridViewTextBoxColumn Data_Utworzenia;
		private System.Windows.Forms.DataGridViewTextBoxColumn Data_Modyfikacji;
		private System.Windows.Forms.DataGridViewTextBoxColumn TowarNazwa;
		private System.Windows.Forms.DataGridViewTextBoxColumn KodTowaru;
		private System.Windows.Forms.DataGridViewTextBoxColumn MasaTowaru;
		private System.Windows.Forms.DataGridViewTextBoxColumn JMasy;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
		private System.Windows.Forms.DataGridViewTextBoxColumn Promocja;
		private System.Windows.Forms.DataGridViewTextBoxColumn PromocjaOd;
		private System.Windows.Forms.DataGridViewTextBoxColumn PromocjaDo;
		private System.Windows.Forms.DataGridViewTextBoxColumn CenaZRabatem;
		private System.Windows.Forms.Button PrintButton;
		private System.Windows.Forms.PrintPreviewDialog printPreview;
		private System.Drawing.Printing.PrintDocument printSummaryGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn CennikIDc;
		private System.Windows.Forms.DataGridViewTextBoxColumn CennikNazwa;
		private System.Windows.Forms.DataGridViewTextBoxColumn Data_Od;
		private System.Windows.Forms.DataGridViewTextBoxColumn Data_Do;
		private System.Windows.Forms.DataGridView CenyGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn CenaID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Towar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
		private System.Windows.Forms.DataGridViewTextBoxColumn Rabat;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cennik;
	}
}

