namespace AplikacjaWindows.Forms
{
	partial class AddEditTowarForm
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
			this.AddButtonYes = new System.Windows.Forms.Button();
			this.CancelAddButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.NameAddBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.KodAddBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.MasaAddBox = new System.Windows.Forms.TextBox();
			this.JmBox = new System.Windows.Forms.ComboBox();
			this.CreateDate = new System.Windows.Forms.TextBox();
			this.EditDate = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// AddButtonYes
			// 
			this.AddButtonYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
			this.AddButtonYes.Location = new System.Drawing.Point(12, 249);
			this.AddButtonYes.Name = "AddButtonYes";
			this.AddButtonYes.Size = new System.Drawing.Size(75, 23);
			this.AddButtonYes.TabIndex = 0;
			this.AddButtonYes.Text = "Dodaj";
			this.AddButtonYes.UseVisualStyleBackColor = true;
			this.AddButtonYes.Click += new System.EventHandler(this.AddButtonYes_Click);
			// 
			// CancelAddButton
			// 
			this.CancelAddButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelAddButton.Location = new System.Drawing.Point(93, 249);
			this.CancelAddButton.Name = "CancelAddButton";
			this.CancelAddButton.Size = new System.Drawing.Size(75, 23);
			this.CancelAddButton.TabIndex = 1;
			this.CancelAddButton.Text = "Anuluj";
			this.CancelAddButton.UseVisualStyleBackColor = true;
			this.CancelAddButton.Click += new System.EventHandler(this.CancelAddButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nazwa";
			// 
			// NameAddBox
			// 
			this.NameAddBox.Location = new System.Drawing.Point(12, 29);
			this.NameAddBox.Name = "NameAddBox";
			this.NameAddBox.Size = new System.Drawing.Size(100, 20);
			this.NameAddBox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Kod";
			// 
			// KodAddBox
			// 
			this.KodAddBox.Location = new System.Drawing.Point(12, 68);
			this.KodAddBox.Name = "KodAddBox";
			this.KodAddBox.Size = new System.Drawing.Size(100, 20);
			this.KodAddBox.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Masa";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(21, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "JM";
			// 
			// MasaAddBox
			// 
			this.MasaAddBox.Location = new System.Drawing.Point(12, 107);
			this.MasaAddBox.Name = "MasaAddBox";
			this.MasaAddBox.Size = new System.Drawing.Size(100, 20);
			this.MasaAddBox.TabIndex = 9;
			// 
			// JmBox
			// 
			this.JmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.JmBox.FormattingEnabled = true;
			this.JmBox.Location = new System.Drawing.Point(12, 146);
			this.JmBox.Name = "JmBox";
			this.JmBox.Size = new System.Drawing.Size(121, 21);
			this.JmBox.TabIndex = 11;
			// 
			// CreateDate
			// 
			this.CreateDate.Location = new System.Drawing.Point(12, 223);
			this.CreateDate.Name = "CreateDate";
			this.CreateDate.Size = new System.Drawing.Size(23, 20);
			this.CreateDate.TabIndex = 12;
			this.CreateDate.Visible = false;
			// 
			// EditDate
			// 
			this.EditDate.Location = new System.Drawing.Point(41, 223);
			this.EditDate.Name = "EditDate";
			this.EditDate.Size = new System.Drawing.Size(21, 20);
			this.EditDate.TabIndex = 13;
			this.EditDate.Visible = false;
			// 
			// AddEditTowarForm
			// 
			this.AcceptButton = this.AddButtonYes;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CancelAddButton;
			this.ClientSize = new System.Drawing.Size(213, 308);
			this.ControlBox = false;
			this.Controls.Add(this.EditDate);
			this.Controls.Add(this.CreateDate);
			this.Controls.Add(this.JmBox);
			this.Controls.Add(this.MasaAddBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.KodAddBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.NameAddBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CancelAddButton);
			this.Controls.Add(this.AddButtonYes);
			this.MaximumSize = new System.Drawing.Size(229, 347);
			this.MinimumSize = new System.Drawing.Size(229, 347);
			this.Name = "AddEditTowarForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FORMULARZ TOWAROWY";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditTowarForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button AddButtonYes;
		private System.Windows.Forms.Button CancelAddButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox NameAddBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox KodAddBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox MasaAddBox;
		private System.Windows.Forms.ComboBox JmBox;
		private System.Windows.Forms.TextBox CreateDate;
		private System.Windows.Forms.TextBox EditDate;
	}
}