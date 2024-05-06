namespace StudentLibrary.BookForm
{
	partial class BookAddForm
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
			tbName = new TextBox();
			tbPrice = new TextBox();
			btnYes = new Button();
			btnNo = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(29, 29);
			label1.Name = "label1";
			label1.Size = new Size(81, 21);
			label1.TabIndex = 0;
			label1.Text = "Название:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(29, 75);
			label2.Name = "label2";
			label2.Size = new Size(50, 21);
			label2.TabIndex = 1;
			label2.Text = "Цена:";
			// 
			// tbName
			// 
			tbName.Font = new Font("Segoe UI", 12F);
			tbName.Location = new Point(116, 29);
			tbName.Name = "tbName";
			tbName.Size = new Size(100, 29);
			tbName.TabIndex = 2;
			// 
			// tbPrice
			// 
			tbPrice.Font = new Font("Segoe UI", 12F);
			tbPrice.Location = new Point(116, 75);
			tbPrice.Name = "tbPrice";
			tbPrice.Size = new Size(100, 29);
			tbPrice.TabIndex = 3;
			// 
			// btnYes
			// 
			btnYes.Location = new Point(29, 127);
			btnYes.Name = "btnYes";
			btnYes.Size = new Size(75, 23);
			btnYes.TabIndex = 4;
			btnYes.Text = "Добавить";
			btnYes.UseVisualStyleBackColor = true;
			btnYes.Click += btnYes_Click;
			// 
			// btnNo
			// 
			btnNo.Location = new Point(141, 127);
			btnNo.Name = "btnNo";
			btnNo.Size = new Size(75, 23);
			btnNo.TabIndex = 5;
			btnNo.Text = "Отмена";
			btnNo.UseVisualStyleBackColor = true;
			btnNo.Click += btnNo_Click;
			// 
			// BookAddForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(249, 176);
			Controls.Add(btnNo);
			Controls.Add(btnYes);
			Controls.Add(tbPrice);
			Controls.Add(tbName);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "BookAddForm";
			Text = "BookAddForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox tbName;
		private TextBox tbPrice;
		private Button btnYes;
		private Button btnNo;
	}
}