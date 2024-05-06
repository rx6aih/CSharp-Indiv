namespace StudentLibrary.StudentBookForm
{
	partial class StudentBookTwoDateReport
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
			dateTimePicker1 = new DateTimePicker();
			label1 = new Label();
			dateTimePicker2 = new DateTimePicker();
			btnNo = new Button();
			btnYes = new Button();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(12, 18);
			label2.Name = "label2";
			label2.Size = new Size(66, 21);
			label2.TabIndex = 31;
			label2.Text = "Начало:";
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Font = new Font("Segoe UI", 12F);
			dateTimePicker1.Location = new Point(12, 42);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(182, 29);
			dateTimePicker1.TabIndex = 30;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(222, 18);
			label1.Name = "label1";
			label1.Size = new Size(58, 21);
			label1.TabIndex = 32;
			label1.Text = "Конец:";
			// 
			// dateTimePicker2
			// 
			dateTimePicker2.Font = new Font("Segoe UI", 12F);
			dateTimePicker2.Location = new Point(222, 42);
			dateTimePicker2.Name = "dateTimePicker2";
			dateTimePicker2.Size = new Size(182, 29);
			dateTimePicker2.TabIndex = 33;
			// 
			// btnNo
			// 
			btnNo.Font = new Font("Segoe UI", 12F);
			btnNo.Location = new Point(275, 103);
			btnNo.Name = "btnNo";
			btnNo.Size = new Size(129, 36);
			btnNo.TabIndex = 35;
			btnNo.Text = "Отмена";
			btnNo.UseVisualStyleBackColor = true;
			btnNo.Click += btnNo_Click;
			// 
			// btnYes
			// 
			btnYes.Font = new Font("Segoe UI", 12F);
			btnYes.Location = new Point(12, 103);
			btnYes.Name = "btnYes";
			btnYes.Size = new Size(129, 36);
			btnYes.TabIndex = 34;
			btnYes.Text = "Сформировать";
			btnYes.UseVisualStyleBackColor = true;
			btnYes.Click += btnYes_Click;
			// 
			// StudentBookTwoDateReport
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(418, 155);
			Controls.Add(btnNo);
			Controls.Add(btnYes);
			Controls.Add(dateTimePicker2);
			Controls.Add(label1);
			Controls.Add(label2);
			Controls.Add(dateTimePicker1);
			Name = "StudentBookTwoDateReport";
			Text = "StudentBookTwoDateReport";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label2;
		private DateTimePicker dateTimePicker1;
		private Label label1;
		private DateTimePicker dateTimePicker2;
		private Button btnNo;
		private Button btnYes;
	}
}