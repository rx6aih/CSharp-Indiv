namespace StudentLibrary.StudentForm
{
	partial class StudentUpdateForm
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
			label4 = new Label();
			comboBox1 = new ComboBox();
			tbAge = new TextBox();
			tbSName = new TextBox();
			tbName = new TextBox();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			btnNo = new Button();
			btnYes = new Button();
			SuspendLayout();
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F);
			label4.Location = new Point(28, 143);
			label4.Name = "label4";
			label4.Size = new Size(103, 21);
			label4.TabIndex = 15;
			label4.Text = "Университет:";
			// 
			// comboBox1
			// 
			comboBox1.Font = new Font("Segoe UI", 12F);
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(146, 140);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(129, 29);
			comboBox1.TabIndex = 14;
			// 
			// tbAge
			// 
			tbAge.Font = new Font("Segoe UI", 12F);
			tbAge.Location = new Point(146, 97);
			tbAge.Name = "tbAge";
			tbAge.Size = new Size(129, 29);
			tbAge.TabIndex = 13;
			// 
			// tbSName
			// 
			tbSName.Font = new Font("Segoe UI", 12F);
			tbSName.Location = new Point(146, 62);
			tbSName.Name = "tbSName";
			tbSName.Size = new Size(129, 29);
			tbSName.TabIndex = 12;
			// 
			// tbName
			// 
			tbName.Font = new Font("Segoe UI", 12F);
			tbName.Location = new Point(146, 27);
			tbName.Name = "tbName";
			tbName.Size = new Size(129, 29);
			tbName.TabIndex = 11;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F);
			label3.Location = new Point(28, 104);
			label3.Name = "label3";
			label3.Size = new Size(69, 21);
			label3.TabIndex = 10;
			label3.Text = "Возраст:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(28, 62);
			label2.Name = "label2";
			label2.Size = new Size(78, 21);
			label2.TabIndex = 9;
			label2.Text = "Фамилия:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(28, 27);
			label1.Name = "label1";
			label1.Size = new Size(44, 21);
			label1.TabIndex = 8;
			label1.Text = "Имя:";
			// 
			// btnNo
			// 
			btnNo.Location = new Point(200, 191);
			btnNo.Name = "btnNo";
			btnNo.Size = new Size(75, 23);
			btnNo.TabIndex = 17;
			btnNo.Text = "Отмена";
			btnNo.UseVisualStyleBackColor = true;
			btnNo.Click += btnNo_Click;
			// 
			// btnYes
			// 
			btnYes.Location = new Point(28, 191);
			btnYes.Name = "btnYes";
			btnYes.Size = new Size(75, 23);
			btnYes.TabIndex = 16;
			btnYes.Text = "Изменить";
			btnYes.UseVisualStyleBackColor = true;
			btnYes.Click += btnYes_Click;
			// 
			// StudentUpdateForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(325, 236);
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
			Name = "StudentUpdateForm";
			Text = "StudentUpdateForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label4;
		private ComboBox comboBox1;
		private TextBox tbAge;
		private TextBox tbSName;
		private TextBox tbName;
		private Label label3;
		private Label label2;
		private Label label1;
		private Button btnNo;
		private Button btnYes;
	}
}