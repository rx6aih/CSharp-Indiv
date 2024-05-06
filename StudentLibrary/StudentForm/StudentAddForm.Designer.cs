namespace StudentLibrary.StudentForm
{
	partial class StudentAddForm
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			tbName = new TextBox();
			tbSName = new TextBox();
			tbAge = new TextBox();
			backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			comboBox1 = new ComboBox();
			label4 = new Label();
			btnYes = new Button();
			btnNo = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(28, 40);
			label1.Name = "label1";
			label1.Size = new Size(44, 21);
			label1.TabIndex = 0;
			label1.Text = "Имя:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(28, 75);
			label2.Name = "label2";
			label2.Size = new Size(78, 21);
			label2.TabIndex = 1;
			label2.Text = "Фамилия:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F);
			label3.Location = new Point(28, 117);
			label3.Name = "label3";
			label3.Size = new Size(69, 21);
			label3.TabIndex = 2;
			label3.Text = "Возраст:";
			// 
			// tbName
			// 
			tbName.Font = new Font("Segoe UI", 12F);
			tbName.Location = new Point(146, 40);
			tbName.Name = "tbName";
			tbName.Size = new Size(129, 29);
			tbName.TabIndex = 3;
			// 
			// tbSName
			// 
			tbSName.Font = new Font("Segoe UI", 12F);
			tbSName.Location = new Point(146, 75);
			tbSName.Name = "tbSName";
			tbSName.Size = new Size(129, 29);
			tbSName.TabIndex = 4;
			// 
			// tbAge
			// 
			tbAge.Font = new Font("Segoe UI", 12F);
			tbAge.Location = new Point(146, 110);
			tbAge.Name = "tbAge";
			tbAge.Size = new Size(129, 29);
			tbAge.TabIndex = 5;
			// 
			// comboBox1
			// 
			comboBox1.Font = new Font("Segoe UI", 12F);
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(146, 153);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(129, 29);
			comboBox1.TabIndex = 6;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F);
			label4.Location = new Point(28, 156);
			label4.Name = "label4";
			label4.Size = new Size(103, 21);
			label4.TabIndex = 7;
			label4.Text = "Университет:";
			// 
			// btnYes
			// 
			btnYes.Location = new Point(28, 206);
			btnYes.Name = "btnYes";
			btnYes.Size = new Size(75, 23);
			btnYes.TabIndex = 8;
			btnYes.Text = "Добавить";
			btnYes.UseVisualStyleBackColor = true;
			btnYes.Click += btnYes_Click;
			// 
			// btnNo
			// 
			btnNo.Location = new Point(200, 206);
			btnNo.Name = "btnNo";
			btnNo.Size = new Size(75, 23);
			btnNo.TabIndex = 9;
			btnNo.Text = "Отмена";
			btnNo.UseVisualStyleBackColor = true;
			btnNo.Click += btnNo_Click;
			// 
			// StudentAddForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(304, 254);
			Controls.Add(btnNo);
			Controls.Add(btnYes);
			Controls.Add(label4);
			Controls.Add(comboBox1);
			Controls.Add(tbAge);
			Controls.Add(tbSName);
			Controls.Add(tbName);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "StudentAddForm";
			Text = "StudentAddForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox tbName;
		private TextBox tbSName;
		private TextBox tbAge;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private ComboBox comboBox1;
		private Label label4;
		private Button btnYes;
		private Button btnNo;
	}
}