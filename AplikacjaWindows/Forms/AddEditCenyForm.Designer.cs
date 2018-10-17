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
			this.CenaAddBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.CennikAddBox = new System.Windows.Forms.ComboBox();
			this.TowarAddBox = new System.Windows.Forms.ComboBox();
			this.CancelAddButton = new System.Windows.Forms.Button();
			this.AddButtonYes = new System.Windows.Forms.Button();
			this.RabatAddBox = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.RabatAddBox)).BeginInit();
			this.SuspendLayout();
			// 
			// CenaAddBox
			// 
			this.CenaAddBox.Location = new System.Drawing.Point(15, 103);
			this.CenaAddBox.Name = "CenaAddBox";
			this.CenaAddBox.Size = new System.Drawing.Size(100, 20);
			this.CenaAddBox.TabIndex = 18;
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
			// CennikAddBox
			// 
			this.CennikAddBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CennikAddBox.FormattingEnabled = true;
			this.CennikAddBox.Location = new System.Drawing.Point(15, 26);
			this.CennikAddBox.Name = "CennikAddBox";
			this.CennikAddBox.Size = new System.Drawing.Size(121, 21);
			this.CennikAddBox.TabIndex = 20;
			// 
			// TowarAddBox
			// 
			this.TowarAddBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TowarAddBox.FormattingEnabled = true;
			this.TowarAddBox.Location = new System.Drawing.Point(15, 64);
			this.TowarAddBox.Name = "TowarAddBox";
			this.TowarAddBox.Size = new System.Drawing.Size(121, 21);
			this.TowarAddBox.TabIndex = 21;
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
			this.CancelAddButton.Click += new System.EventHandler(this.CancelAddButton_Click);
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
			// RabatAddBox
			// 
			this.RabatAddBox.Location = new System.Drawing.Point(15, 142);
			this.RabatAddBox.Name = "RabatAddBox";
			this.RabatAddBox.Size = new System.Drawing.Size(120, 20);
			this.RabatAddBox.TabIndex = 25;
			// 
			// AddEditCenyForm
			// 
			this.AcceptButton = this.AddButtonYes;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CancelAddButton;
			this.ClientSize = new System.Drawing.Size(185, 225);
			this.ControlBox = false;
			this.Controls.Add(this.RabatAddBox);
			this.Controls.Add(this.CancelAddButton);
			this.Controls.Add(this.AddButtonYes);
			this.Controls.Add(this.TowarAddBox);
			this.Controls.Add(this.CennikAddBox);
			this.Controls.Add(this.CenaAddBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximumSize = new System.Drawing.Size(201, 264);
			this.MinimumSize = new System.Drawing.Size(201, 264);
			this.Name = "AddEditCenyForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddEditCenyForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditCenyForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.RabatAddBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox CenaAddBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox CennikAddBox;
		private System.Windows.Forms.ComboBox TowarAddBox;
		private System.Windows.Forms.Button CancelAddButton;
		private System.Windows.Forms.Button AddButtonYes;
		private System.Windows.Forms.NumericUpDown RabatAddBox;
	}
}