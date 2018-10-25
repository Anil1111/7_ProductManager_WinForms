namespace AplikacjaWindows.Forms
{
	partial class AddEditCennikiForm
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
			this.CancelAddButton = new System.Windows.Forms.Button();
			this.AddButtonYes = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.NameAddBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
			this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// CancelAddButton
			// 
			this.CancelAddButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelAddButton.Location = new System.Drawing.Point(92, 153);
			this.CancelAddButton.Name = "CancelAddButton";
			this.CancelAddButton.Size = new System.Drawing.Size(75, 23);
			this.CancelAddButton.TabIndex = 3;
			this.CancelAddButton.Text = "Anuluj";
			this.CancelAddButton.UseVisualStyleBackColor = true;
			// 
			// AddButtonYes
			// 
			this.AddButtonYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
			this.AddButtonYes.Location = new System.Drawing.Point(11, 153);
			this.AddButtonYes.Name = "AddButtonYes";
			this.AddButtonYes.Size = new System.Drawing.Size(75, 23);
			this.AddButtonYes.TabIndex = 2;
			this.AddButtonYes.Text = "Dodaj";
			this.AddButtonYes.UseVisualStyleBackColor = true;
			this.AddButtonYes.Click += new System.EventHandler(this.AddButtonYes_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Data Do";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Data Od";
			// 
			// NameAddBox
			// 
			this.NameAddBox.Location = new System.Drawing.Point(15, 25);
			this.NameAddBox.Name = "NameAddBox";
			this.NameAddBox.Size = new System.Drawing.Size(100, 20);
			this.NameAddBox.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Nazwa";
			// 
			// StartDatePicker
			// 
			this.StartDatePicker.Location = new System.Drawing.Point(15, 65);
			this.StartDatePicker.Name = "StartDatePicker";
			this.StartDatePicker.Size = new System.Drawing.Size(200, 20);
			this.StartDatePicker.TabIndex = 15;
			// 
			// EndDatePicker
			// 
			this.EndDatePicker.Location = new System.Drawing.Point(15, 104);
			this.EndDatePicker.Name = "EndDatePicker";
			this.EndDatePicker.Size = new System.Drawing.Size(200, 20);
			this.EndDatePicker.TabIndex = 16;
			// 
			// AddEditCennikiForm
			// 
			this.AcceptButton = this.AddButtonYes;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CancelAddButton;
			this.ClientSize = new System.Drawing.Size(244, 208);
			this.ControlBox = false;
			this.Controls.Add(this.EndDatePicker);
			this.Controls.Add(this.StartDatePicker);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.NameAddBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CancelAddButton);
			this.Controls.Add(this.AddButtonYes);
			this.MaximumSize = new System.Drawing.Size(260, 247);
			this.MinimumSize = new System.Drawing.Size(260, 247);
			this.Name = "AddEditCennikiForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cennik";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CancelAddButton;
		private System.Windows.Forms.Button AddButtonYes;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox NameAddBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker StartDatePicker;
		private System.Windows.Forms.DateTimePicker EndDatePicker;
	}
}