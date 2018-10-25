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
			this.CodeAddBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.WeightAddBox = new System.Windows.Forms.TextBox();
			this.UnitWeightBox = new System.Windows.Forms.ComboBox();
			this.CreateDateBox = new System.Windows.Forms.TextBox();
			this.EditDateBox = new System.Windows.Forms.TextBox();
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
			this.NameAddBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameAddBox_Validating);
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
			// CodeAddBox
			// 
			this.CodeAddBox.Location = new System.Drawing.Point(12, 68);
			this.CodeAddBox.Name = "CodeAddBox";
			this.CodeAddBox.Size = new System.Drawing.Size(100, 20);
			this.CodeAddBox.TabIndex = 5;
			this.CodeAddBox.Validating += new System.ComponentModel.CancelEventHandler(this.CodeAddBox_Validating);
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
			// WeightAddBox
			// 
			this.WeightAddBox.Location = new System.Drawing.Point(12, 107);
			this.WeightAddBox.Name = "WeightAddBox";
			this.WeightAddBox.Size = new System.Drawing.Size(100, 20);
			this.WeightAddBox.TabIndex = 9;
			this.WeightAddBox.Validating += new System.ComponentModel.CancelEventHandler(this.WeightAddBox_Validating);
			// 
			// UnitWeightBox
			// 
			this.UnitWeightBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.UnitWeightBox.FormattingEnabled = true;
			this.UnitWeightBox.Location = new System.Drawing.Point(12, 146);
			this.UnitWeightBox.Name = "UnitWeightBox";
			this.UnitWeightBox.Size = new System.Drawing.Size(121, 21);
			this.UnitWeightBox.TabIndex = 11;
			// 
			// CreateDateBox
			// 
			this.CreateDateBox.Location = new System.Drawing.Point(12, 223);
			this.CreateDateBox.Name = "CreateDateBox";
			this.CreateDateBox.Size = new System.Drawing.Size(23, 20);
			this.CreateDateBox.TabIndex = 12;
			this.CreateDateBox.Visible = false;
			// 
			// EditDateBox
			// 
			this.EditDateBox.Location = new System.Drawing.Point(41, 223);
			this.EditDateBox.Name = "EditDateBox";
			this.EditDateBox.Size = new System.Drawing.Size(21, 20);
			this.EditDateBox.TabIndex = 13;
			this.EditDateBox.Visible = false;
			// 
			// AddEditTowarForm
			// 
			this.AcceptButton = this.AddButtonYes;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CancelAddButton;
			this.ClientSize = new System.Drawing.Size(213, 308);
			this.ControlBox = false;
			this.Controls.Add(this.EditDateBox);
			this.Controls.Add(this.CreateDateBox);
			this.Controls.Add(this.UnitWeightBox);
			this.Controls.Add(this.WeightAddBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.CodeAddBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.NameAddBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CancelAddButton);
			this.Controls.Add(this.AddButtonYes);
			this.MaximumSize = new System.Drawing.Size(229, 347);
			this.MinimumSize = new System.Drawing.Size(229, 347);
			this.Name = "AddEditTowarForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Towar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button AddButtonYes;
		private System.Windows.Forms.Button CancelAddButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox NameAddBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox CodeAddBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox WeightAddBox;
		private System.Windows.Forms.ComboBox UnitWeightBox;
		private System.Windows.Forms.TextBox CreateDateBox;
		private System.Windows.Forms.TextBox EditDateBox;
	}
}