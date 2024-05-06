namespace StudentLibrary.StudentForm
{
	partial class StudentForm
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
			menuStrip1 = new MenuStrip();
			добавитьToolStripMenuItem = new ToolStripMenuItem();
			удалитьToolStripMenuItem = new ToolStripMenuItem();
			изменитьToolStripMenuItem = new ToolStripMenuItem();
			dataGridView1 = new DataGridView();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem, удалитьToolStripMenuItem, изменитьToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(573, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// добавитьToolStripMenuItem
			// 
			добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
			добавитьToolStripMenuItem.Size = new Size(71, 20);
			добавитьToolStripMenuItem.Text = "Добавить";
			добавитьToolStripMenuItem.Click += добавитьToolStripMenuItem_Click;
			// 
			// удалитьToolStripMenuItem
			// 
			удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
			удалитьToolStripMenuItem.Size = new Size(63, 20);
			удалитьToolStripMenuItem.Text = "Удалить";
			удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
			// 
			// изменитьToolStripMenuItem
			// 
			изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
			изменитьToolStripMenuItem.Size = new Size(73, 20);
			изменитьToolStripMenuItem.Text = "Изменить";
			изменитьToolStripMenuItem.Click += изменитьToolStripMenuItem_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(12, 27);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(549, 150);
			dataGridView1.TabIndex = 1;
			// 
			// StudentForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(573, 193);
			Controls.Add(dataGridView1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "StudentForm";
			Text = "StudentForm";
			Load += StudentForm_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem добавитьToolStripMenuItem;
		private ToolStripMenuItem удалитьToolStripMenuItem;
		private ToolStripMenuItem изменитьToolStripMenuItem;
		private DataGridView dataGridView1;
	}
}