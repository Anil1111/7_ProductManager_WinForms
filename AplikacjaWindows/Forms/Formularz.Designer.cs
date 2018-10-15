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
			this.components = new System.ComponentModel.Container();
			this.Cenniki = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.CennikiGrid = new System.Windows.Forms.DataGridView();
			this.Ceny = new System.Windows.Forms.TabPage();
			this.UsunCeneBtn = new System.Windows.Forms.Button();
			this.EdytujCeneBtn = new System.Windows.Forms.Button();
			this.DodajCeneBtn = new System.Windows.Forms.Button();
			this.CenyGrid = new System.Windows.Forms.DataGridView();
			this.Towary = new System.Windows.Forms.TabPage();
			this.UsunTowarBtn = new System.Windows.Forms.Button();
			this.EdytujTowarBtn = new System.Windows.Forms.Button();
			this.DodajTowarBtn = new System.Windows.Forms.Button();
			this.TowaryGrid = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.masaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.jMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataUtworzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataModyfikacjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ceniesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.towaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.TabControl = new System.Windows.Forms.TabControl();
			this.Cenniki.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CennikiGrid)).BeginInit();
			this.Ceny.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CenyGrid)).BeginInit();
			this.Towary.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TowaryGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.towaryBindingSource)).BeginInit();
			this.TabControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// Cenniki
			// 
			this.Cenniki.Controls.Add(this.button1);
			this.Cenniki.Controls.Add(this.button2);
			this.Cenniki.Controls.Add(this.button3);
			this.Cenniki.Controls.Add(this.CennikiGrid);
			this.Cenniki.Location = new System.Drawing.Point(4, 22);
			this.Cenniki.Name = "Cenniki";
			this.Cenniki.Padding = new System.Windows.Forms.Padding(3);
			this.Cenniki.Size = new System.Drawing.Size(925, 487);
			this.Cenniki.TabIndex = 3;
			this.Cenniki.Text = "Cenniki";
			this.Cenniki.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 66);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Usuń";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(6, 36);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "Edytuj";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(6, 6);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 5;
			this.button3.Text = "Dodaj";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// CennikiGrid
			// 
			this.CennikiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.CennikiGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.CennikiGrid.Location = new System.Drawing.Point(3, 334);
			this.CennikiGrid.Name = "CennikiGrid";
			this.CennikiGrid.Size = new System.Drawing.Size(919, 150);
			this.CennikiGrid.TabIndex = 2;
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
			this.Ceny.Size = new System.Drawing.Size(925, 487);
			this.Ceny.TabIndex = 2;
			this.Ceny.Text = "Ceny";
			this.Ceny.UseVisualStyleBackColor = true;
			// 
			// UsunCeneBtn
			// 
			this.UsunCeneBtn.Location = new System.Drawing.Point(6, 66);
			this.UsunCeneBtn.Name = "UsunCeneBtn";
			this.UsunCeneBtn.Size = new System.Drawing.Size(75, 23);
			this.UsunCeneBtn.TabIndex = 4;
			this.UsunCeneBtn.Text = "Usuń";
			this.UsunCeneBtn.UseVisualStyleBackColor = true;
			// 
			// EdytujCeneBtn
			// 
			this.EdytujCeneBtn.Location = new System.Drawing.Point(6, 36);
			this.EdytujCeneBtn.Name = "EdytujCeneBtn";
			this.EdytujCeneBtn.Size = new System.Drawing.Size(75, 23);
			this.EdytujCeneBtn.TabIndex = 3;
			this.EdytujCeneBtn.Text = "Edytuj";
			this.EdytujCeneBtn.UseVisualStyleBackColor = true;
			// 
			// DodajCeneBtn
			// 
			this.DodajCeneBtn.Location = new System.Drawing.Point(6, 6);
			this.DodajCeneBtn.Name = "DodajCeneBtn";
			this.DodajCeneBtn.Size = new System.Drawing.Size(75, 23);
			this.DodajCeneBtn.TabIndex = 2;
			this.DodajCeneBtn.Text = "Dodaj";
			this.DodajCeneBtn.UseVisualStyleBackColor = true;
			// 
			// CenyGrid
			// 
			this.CenyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.CenyGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.CenyGrid.Location = new System.Drawing.Point(3, 334);
			this.CenyGrid.Name = "CenyGrid";
			this.CenyGrid.Size = new System.Drawing.Size(919, 150);
			this.CenyGrid.TabIndex = 1;
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
			this.Towary.Size = new System.Drawing.Size(925, 487);
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
			this.TowaryGrid.AutoGenerateColumns = false;
			this.TowaryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TowaryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.kodDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.masaDataGridViewTextBoxColumn,
            this.jMDataGridViewTextBoxColumn,
            this.dataUtworzeniaDataGridViewTextBoxColumn,
            this.dataModyfikacjiDataGridViewTextBoxColumn,
            this.ceniesDataGridViewTextBoxColumn});
			this.TowaryGrid.DataSource = this.towaryBindingSource;
			this.TowaryGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.TowaryGrid.Location = new System.Drawing.Point(3, 334);
			this.TowaryGrid.Name = "TowaryGrid";
			this.TowaryGrid.ReadOnly = true;
			this.TowaryGrid.Size = new System.Drawing.Size(919, 150);
			this.TowaryGrid.TabIndex = 0;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			// 
			// kodDataGridViewTextBoxColumn
			// 
			this.kodDataGridViewTextBoxColumn.DataPropertyName = "Kod";
			this.kodDataGridViewTextBoxColumn.HeaderText = "Kod";
			this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
			// 
			// nazwaDataGridViewTextBoxColumn
			// 
			this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
			this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
			this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
			// 
			// masaDataGridViewTextBoxColumn
			// 
			this.masaDataGridViewTextBoxColumn.DataPropertyName = "Masa";
			this.masaDataGridViewTextBoxColumn.HeaderText = "Masa";
			this.masaDataGridViewTextBoxColumn.Name = "masaDataGridViewTextBoxColumn";
			// 
			// jMDataGridViewTextBoxColumn
			// 
			this.jMDataGridViewTextBoxColumn.DataPropertyName = "JM";
			this.jMDataGridViewTextBoxColumn.HeaderText = "JM";
			this.jMDataGridViewTextBoxColumn.Name = "jMDataGridViewTextBoxColumn";
			// 
			// dataUtworzeniaDataGridViewTextBoxColumn
			// 
			this.dataUtworzeniaDataGridViewTextBoxColumn.DataPropertyName = "Data_Utworzenia";
			this.dataUtworzeniaDataGridViewTextBoxColumn.HeaderText = "Data Utworzenia";
			this.dataUtworzeniaDataGridViewTextBoxColumn.Name = "dataUtworzeniaDataGridViewTextBoxColumn";
			// 
			// dataModyfikacjiDataGridViewTextBoxColumn
			// 
			this.dataModyfikacjiDataGridViewTextBoxColumn.DataPropertyName = "Data_Modyfikacji";
			this.dataModyfikacjiDataGridViewTextBoxColumn.HeaderText = "Data Modyfikacji";
			this.dataModyfikacjiDataGridViewTextBoxColumn.Name = "dataModyfikacjiDataGridViewTextBoxColumn";
			// 
			// ceniesDataGridViewTextBoxColumn
			// 
			this.ceniesDataGridViewTextBoxColumn.DataPropertyName = "Cenies";
			this.ceniesDataGridViewTextBoxColumn.HeaderText = "Cena";
			this.ceniesDataGridViewTextBoxColumn.Name = "ceniesDataGridViewTextBoxColumn";
			// 
			// towaryBindingSource
			// 
			this.towaryBindingSource.DataSource = typeof(AplikacjaWindows.Towary);
			// 
			// TabControl
			// 
			this.TabControl.Controls.Add(this.Towary);
			this.TabControl.Controls.Add(this.Ceny);
			this.TabControl.Controls.Add(this.Cenniki);
			this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabControl.Location = new System.Drawing.Point(0, 0);
			this.TabControl.Name = "TabControl";
			this.TabControl.SelectedIndex = 0;
			this.TabControl.Size = new System.Drawing.Size(933, 513);
			this.TabControl.TabIndex = 0;
			// 
			// Formularz
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(933, 513);
			this.Controls.Add(this.TabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
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
			((System.ComponentModel.ISupportInitialize)(this.towaryBindingSource)).EndInit();
			this.TabControl.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion
		private System.Windows.Forms.BindingSource towaryBindingSource;
		private System.Windows.Forms.TabPage Cenniki;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
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
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn masaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn jMDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataUtworzeniaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataModyfikacjiDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ceniesDataGridViewTextBoxColumn;
		private System.Windows.Forms.TabControl TabControl;
	}
}

