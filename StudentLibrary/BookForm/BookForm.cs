using StudentLibrary.DAL.EF;
using StudentLibrary.DAL.Entities;
using StudentLibrary.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentLibrary.BookForm
{
	public partial class BookForm : Form
	{
		public BookForm()
		{
			StartPosition = FormStartPosition.CenterParent;
			InitializeComponent();
			Update();
		}

		private void Update()
		{
			using (var db = new Context())
			{
				try
				{
					BookRepository br = new BookRepository(db);

					List<Book> books = br.GetAll().ToList();
					dataGridView1.DataSource = books;
					dataGridView1.Refresh();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			BookAddForm ba = new BookAddForm();
			ba.ShowDialog();
			Update();
		}

		private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
			DialogResult dr = MessageBox.Show("Удаление", "Вы уверены?", MessageBoxButtons.YesNo);
			if (dr == DialogResult.Yes)
			{
				using (Context db = new Context())
				{
					BookRepository br = new BookRepository(db);
					br.Delete(id);
					db.SaveChanges();
					Update();
				}
			}
		}

		private void BookForm_Load(object sender, EventArgs e)
		{
			dataGridView1.Columns[0].HeaderText = "Номер";
			dataGridView1.Columns[1].HeaderText = "Название книги";
			dataGridView1.Columns[2].HeaderText = "Цена";
		}
	}
}
