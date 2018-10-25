namespace AplikacjaWindows.Forms
{
	partial class AddEditCenyForm
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
			this.PriceAddBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.PriceListAddBox = new System.Windows.Forms.ComboBox();
			this.ProductAddBox = new System.Windows.Forms.ComboBox();
			this.CancelAddButton = new System.Windows.Forms.Button();
			this.AddButtonYes = new System.Windows.Forms.Button();
			this.DiscountAddBox = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.DiscountAddBox)).BeginInit();
			this.SuspendLayout();
			// 
			// PriceAddBox
			// 
			this.PriceAddBox.Location = new System.Drawing.Point(15, 103);
			this.PriceAddBox.Name = "PriceAddBox";
			this.PriceAddBox.Size = new System.Drawing.Size(100, 20);
			this.PriceAddBox.TabIndex = 18;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Rabat";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Cena";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "Towar";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Cennik";
			// 
			// PriceListAddBox
			// 
			this.PriceListAddBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.PriceListAddBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.PriceListAddBox.FormattingEnabled = true;
			this.PriceListAddBox.Location = new System.Drawing.Point(15, 26);
			this.PriceListAddBox.Name = "PriceListAddBox";
			this.PriceListAddBox.Size = new System.Drawing.Size(121, 21);
			this.PriceListAddBox.TabIndex = 20;
			// 
			// ProductAddBox
			// 
			this.ProductAddBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.ProductAddBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.ProductAddBox.FormattingEnabled = true;
			this.ProductAddBox.Location = new System.Drawing.Point(15, 64);
			this.ProductAddBox.Name = "ProductAddBox";
			this.ProductAddBox.Size = new System.Drawing.Size(121, 21);
			this.ProductAddBox.TabIndex = 21;
			// 
			// CancelAddButton
			// 
			this.CancelAddButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelAddButton.Location = new System.Drawing.Point(93, 183);
			this.CancelAddButton.Name = "CancelAddButton";
			this.CancelAddButton.Size = new System.Drawing.Size(75, 23);
			this.CancelAddButton.TabIndex = 23;
			this.CancelAddButton.Text = "Anuluj";
			this.CancelAddButton.UseVisualStyleBackColor = true;
			// 
			// AddButtonYes
			// 
			this.AddButtonYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
			this.AddButtonYes.Location = new System.Drawing.Point(12, 183);
			this.AddButtonYes.Name = "AddButtonYes";
			this.AddButtonYes.Size = new System.Drawing.Size(75, 23);
			this.AddButtonYes.TabIndex = 22;
			this.AddButtonYes.Text = "Dodaj";
			this.AddButtonYes.UseVisualStyleBackColor = true;
			this.AddButtonYes.Click += new System.EventHandler(this.AddButtonYes_Click);
			// 
			// DiscountAddBox
			// 
			this.DiscountAddBox.Location = new System.Drawing.Point(15, 142);
			this.DiscountAddBox.Name = "DiscountAddBox";
			this.DiscountAddBox.Size = new System.Drawing.Size(120, 20);
			this.DiscountAddBox.TabIndex = 25;
			// 
			// AddEditCenyForm
			// 
			this.AcceptButton = this.AddButtonYes;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CancelAddButton;
			this.ClientSize = new System.Drawing.Size(185, 225);
			this.ControlBox = false;
			this.Controls.Add(this.DiscountAddBox);
			this.Controls.Add(this.CancelAddButton);
			this.Controls.Add(this.AddButtonYes);
			this.Controls.Add(this.ProductAddBox);
			this.Controls.Add(this.PriceListAddBox);
			this.Controls.Add(this.PriceAddBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximumSize = new System.Drawing.Size(201, 264);
			this.MinimumSize = new System.Drawing.Size(201, 264);
			this.Name = "AddEditCenyForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cena";
			((System.ComponentModel.ISupportInitialize)(this.DiscountAddBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox PriceAddBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox PriceListAddBox;
		private System.Windows.Forms.ComboBox ProductAddBox;
		private System.Windows.Forms.Button CancelAddButton;
		private System.Windows.Forms.Button AddButtonYes;
		private System.Windows.Forms.NumericUpDown DiscountAddBox;
	}
}