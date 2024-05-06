namespace StudentLibrary.StudentBookForm
{
	partial class StudentBookOneDateReport
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
			label2 = new Label();
			dateTimePicker = new DateTimePicker();
			label1 = new Label();
			universityCb = new ComboBox();
			btnYes = new Button();
			btnNo = new Button();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(12, 81);
			label2.Name = "label2";
			label2.Size = new Size(47, 21);
			label2.TabIndex = 29;
			label2.Text = "Дата:";
			// 
			// dateTimePicker
			// 
			dateTimePicker.Font = new Font("Segoe UI", 12F);
			dateTimePicker.Location = new Point(130, 75);
			dateTimePicker.Name = "dateTimePicker";
			dateTimePicker.Size = new Size(182, 29);
			dateTimePicker.TabIndex = 28;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(12, 32);
			label1.Name = "label1";
			label1.Size = new Size(103, 21);
			label1.TabIndex = 27;
			label1.Text = "Университет:";
			// 
			// universityCb
			// 
			universityCb.Font = new Font("Segoe UI", 12F);
			universityCb.FormattingEnabled = true;
			universityCb.Location = new Point(130, 29);
			universityCb.Name = "universityCb";
			universityCb.Size = new Size(182, 29);
			universityCb.TabIndex = 26;
			// 
			// btnYes
			// 
			btnYes.Font = new Font("Segoe UI", 12F);
			btnYes.Location = new Point(12, 134);
			btnYes.Name = "btnYes";
			btnYes.Size = new Size(129, 36);
			btnYes.TabIndex = 30;
			btnYes.Text = "Сформировать";
			btnYes.UseVisualStyleBackColor = true;
			btnYes.Click += btnYes_Click;
			// 
			// btnNo
			// 
			btnNo.Font = new Font("Segoe UI", 12F);
			btnNo.Location = new Point(180, 134);
			btnNo.Name = "btnNo";
			btnNo.Size = new Size(129, 36);
			btnNo.TabIndex = 31;
			btnNo.Text = "Отмена";
			btnNo.UseVisualStyleBackColor = true;
			btnNo.Click += btnNo_Click;
			// 
			// StudentBookOneDateReport
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(321, 192);
			Controls.Add(btnNo);
			Controls.Add(btnYes);
			Controls.Add(label2);
			Controls.Add(dateTimePicker);
			Controls.Add(label1);
			Controls.Add(universityCb);
			Name = "StudentBookOneDateReport";
			Text = "StudentBookOneDateReport";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label2;
		private DateTimePicker dateTimePicker;
		private Label label1;
		private ComboBox universityCb;
		private Button btnYes;
		private Button btnNo;
	}
}