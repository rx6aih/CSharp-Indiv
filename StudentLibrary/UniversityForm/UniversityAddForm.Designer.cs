namespace StudentLibrary.UniversityForm
{
	partial class UniversityAddForm
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
			nameTextBox = new TextBox();
			yesButton = new Button();
			noButton = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(12, 42);
			label1.Name = "label1";
			label1.Size = new Size(81, 21);
			label1.TabIndex = 0;
			label1.Text = "Название:";
			// 
			// nameTextBox
			// 
			nameTextBox.Font = new Font("Segoe UI", 12F);
			nameTextBox.Location = new Point(99, 39);
			nameTextBox.Name = "nameTextBox";
			nameTextBox.Size = new Size(123, 29);
			nameTextBox.TabIndex = 1;
			// 
			// yesButton
			// 
			yesButton.Location = new Point(12, 93);
			yesButton.Name = "yesButton";
			yesButton.Size = new Size(71, 23);
			yesButton.TabIndex = 2;
			yesButton.Text = "Добавить";
			yesButton.UseVisualStyleBackColor = true;
			yesButton.Click += yesButton_Click;
			// 
			// noButton
			// 
			noButton.Location = new Point(151, 93);
			noButton.Name = "noButton";
			noButton.Size = new Size(71, 23);
			noButton.TabIndex = 3;
			noButton.Text = "Отмена";
			noButton.UseVisualStyleBackColor = true;
			noButton.Click += noButton_Click;
			// 
			// UniversityAddForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(236, 136);
			Controls.Add(noButton);
			Controls.Add(yesButton);
			Controls.Add(nameTextBox);
			Controls.Add(label1);
			Name = "UniversityAddForm";
			Text = "UniversityAddForm";
			Load += UniversityAddForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox nameTextBox;
		private Button yesButton;
		private Button noButton;
	}
}