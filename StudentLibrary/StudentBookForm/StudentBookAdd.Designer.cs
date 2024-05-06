namespace StudentLibrary.StudentBookForm
{
	partial class StudentBookAdd
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
			btnNo = new Button();
			btnYes = new Button();
			label4 = new Label();
			bookCb = new ComboBox();
			label1 = new Label();
			studentCb = new ComboBox();
			deadLineDateTimePicker = new DateTimePicker();
			label2 = new Label();
			SuspendLayout();
			// 
			// btnNo
			// 
			btnNo.Location = new Point(239, 189);
			btnNo.Name = "btnNo";
			btnNo.Size = new Size(75, 23);
			btnNo.TabIndex = 19;
			btnNo.Text = "Отмена";
			btnNo.UseVisualStyleBackColor = true;
			btnNo.Click += btnNo_Click;
			// 
			// btnYes
			// 
			btnYes.Location = new Point(14, 189);
			btnYes.Name = "btnYes";
			btnYes.Size = new Size(75, 23);
			btnYes.TabIndex = 18;
			btnYes.Text = "Выдать";
			btnYes.UseVisualStyleBackColor = true;
			btnYes.Click += btnYes_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F);
			label4.Location = new Point(14, 76);
			label4.Name = "label4";
			label4.Size = new Size(54, 21);
			label4.TabIndex = 17;
			label4.Text = "Книга:";
			// 
			// bookCb
			// 
			bookCb.Font = new Font("Segoe UI", 12F);
			bookCb.FormattingEnabled = true;
			bookCb.Location = new Point(132, 73);
			bookCb.Name = "bookCb";
			bookCb.Size = new Size(182, 29);
			bookCb.TabIndex = 16;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(14, 32);
			label1.Name = "label1";
			label1.Size = new Size(71, 21);
			label1.TabIndex = 21;
			label1.Text = "Студент:";
			// 
			// studentCb
			// 
			studentCb.Font = new Font("Segoe UI", 12F);
			studentCb.FormattingEnabled = true;
			studentCb.Location = new Point(132, 29);
			studentCb.Name = "studentCb";
			studentCb.Size = new Size(182, 29);
			studentCb.TabIndex = 20;
			// 
			// deadLineDateTimePicker
			// 
			deadLineDateTimePicker.Font = new Font("Segoe UI", 12F);
			deadLineDateTimePicker.Location = new Point(132, 119);
			deadLineDateTimePicker.Name = "deadLineDateTimePicker";
			deadLineDateTimePicker.Size = new Size(182, 29);
			deadLineDateTimePicker.TabIndex = 22;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(14, 125);
			label2.Name = "label2";
			label2.Size = new Size(75, 21);
			label2.TabIndex = 23;
			label2.Text = "Дедлайн:";
			// 
			// StudentBookAdd
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(337, 230);
			Controls.Add(label2);
			Controls.Add(deadLineDateTimePicker);
			Controls.Add(label1);
			Controls.Add(studentCb);
			Controls.Add(btnNo);
			Controls.Add(btnYes);
			Controls.Add(label4);
			Controls.Add(bookCb);
			Name = "StudentBookAdd";
			Text = "StudentBookAdd";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnNo;
		private Button btnYes;
		private Label label4;
		private ComboBox bookCb;
		private Label label1;
		private DateTimePicker deadLineDateTimePicker;
		private Label label2;
		private ComboBox studentCb;
	}
}