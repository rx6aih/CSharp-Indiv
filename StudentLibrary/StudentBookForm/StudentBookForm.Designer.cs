namespace StudentLibrary.StudentBookForm
{
	partial class StudentBookForm
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
			dataGridView1 = new DataGridView();
			menuStrip1 = new MenuStrip();
			выдатьToolStripMenuItem = new ToolStripMenuItem();
			отчётToolStripMenuItem = new ToolStripMenuItem();
			заToolStripMenuItem = new ToolStripMenuItem();
			заПромежутокToolStripMenuItem = new ToolStripMenuItem();
			lostBtn = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(12, 27);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(559, 150);
			dataGridView1.TabIndex = 0;
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { выдатьToolStripMenuItem, отчётToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(586, 24);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// выдатьToolStripMenuItem
			// 
			выдатьToolStripMenuItem.Name = "выдатьToolStripMenuItem";
			выдатьToolStripMenuItem.Size = new Size(58, 20);
			выдатьToolStripMenuItem.Text = "Выдать";
			выдатьToolStripMenuItem.Click += выдатьToolStripMenuItem_Click;
			// 
			// отчётToolStripMenuItem
			// 
			отчётToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { заToolStripMenuItem, заПромежутокToolStripMenuItem });
			отчётToolStripMenuItem.Name = "отчётToolStripMenuItem";
			отчётToolStripMenuItem.Size = new Size(51, 20);
			отчётToolStripMenuItem.Text = "Отчёт";
			// 
			// заToolStripMenuItem
			// 
			заToolStripMenuItem.Name = "заToolStripMenuItem";
			заToolStripMenuItem.Size = new Size(181, 22);
			заToolStripMenuItem.Text = "За выбранную дату";
			заToolStripMenuItem.Click += заToolStripMenuItem_Click;
			// 
			// заПромежутокToolStripMenuItem
			// 
			заПромежутокToolStripMenuItem.Name = "заПромежутокToolStripMenuItem";
			заПромежутокToolStripMenuItem.Size = new Size(181, 22);
			заПромежутокToolStripMenuItem.Text = "За промежуток";
			заПромежутокToolStripMenuItem.Click += заПромежутокToolStripMenuItem_Click;
			// 
			// lostBtn
			// 
			lostBtn.Font = new Font("Segoe UI", 12F);
			lostBtn.Location = new Point(468, 183);
			lostBtn.Name = "lostBtn";
			lostBtn.Size = new Size(103, 29);
			lostBtn.TabIndex = 2;
			lostBtn.Text = "Потеряна";
			lostBtn.UseVisualStyleBackColor = true;
			lostBtn.Click += lostBtn_Click;
			// 
			// StudentBookForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(586, 217);
			Controls.Add(lostBtn);
			Controls.Add(dataGridView1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "StudentBookForm";
			Text = "StudentBookForm";
			Load += StudentBookForm_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem выдатьToolStripMenuItem;
		private ToolStripMenuItem отчётToolStripMenuItem;
		private ToolStripMenuItem заToolStripMenuItem;
		private ToolStripMenuItem заПромежутокToolStripMenuItem;
		private Button lostBtn;
	}
}