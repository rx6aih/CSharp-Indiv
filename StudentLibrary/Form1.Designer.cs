namespace StudentLibrary
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			button1 = new Button();
			universityButton = new Button();
			studentButton = new Button();
			bookButton = new Button();
			studentBookButton = new Button();
			SuspendLayout();
			// 
			// button1
			// 
			button1.BackColor = Color.White;
			button1.FlatAppearance.BorderSize = 0;
			button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			button1.Location = new Point(750, 12);
			button1.Name = "button1";
			button1.Size = new Size(38, 28);
			button1.TabIndex = 0;
			button1.Text = "X";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// universityButton
			// 
			universityButton.BackColor = Color.Beige;
			universityButton.Font = new Font("Segoe UI", 12F);
			universityButton.Location = new Point(26, 98);
			universityButton.Name = "universityButton";
			universityButton.Size = new Size(124, 40);
			universityButton.TabIndex = 1;
			universityButton.Text = "Университеты";
			universityButton.UseVisualStyleBackColor = false;
			universityButton.Click += universityButton_Click;
			// 
			// studentButton
			// 
			studentButton.BackColor = Color.Beige;
			studentButton.Font = new Font("Segoe UI", 12F);
			studentButton.Location = new Point(183, 98);
			studentButton.Name = "studentButton";
			studentButton.Size = new Size(124, 40);
			studentButton.TabIndex = 2;
			studentButton.Text = "Студенты";
			studentButton.UseVisualStyleBackColor = false;
			studentButton.Click += studentButton_Click;
			// 
			// bookButton
			// 
			bookButton.BackColor = Color.Beige;
			bookButton.Font = new Font("Segoe UI", 12F);
			bookButton.Location = new Point(335, 98);
			bookButton.Name = "bookButton";
			bookButton.Size = new Size(124, 40);
			bookButton.TabIndex = 3;
			bookButton.Text = "Книги";
			bookButton.UseVisualStyleBackColor = false;
			bookButton.Click += bookButton_Click;
			// 
			// studentBookButton
			// 
			studentBookButton.BackColor = Color.Beige;
			studentBookButton.Font = new Font("Segoe UI", 12F);
			studentBookButton.Location = new Point(650, 98);
			studentBookButton.Name = "studentBookButton";
			studentBookButton.Size = new Size(138, 40);
			studentBookButton.TabIndex = 4;
			studentBookButton.Text = "Выданные книги";
			studentBookButton.UseVisualStyleBackColor = false;
			studentBookButton.Click += studentBookButton_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Wheat;
			ClientSize = new Size(802, 270);
			Controls.Add(studentBookButton);
			Controls.Add(bookButton);
			Controls.Add(studentButton);
			Controls.Add(universityButton);
			Controls.Add(button1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private Button button1;
		private Button universityButton;
		private Button studentButton;
		private Button bookButton;
		private Button studentBookButton;
		private Button button2;
	}
}
