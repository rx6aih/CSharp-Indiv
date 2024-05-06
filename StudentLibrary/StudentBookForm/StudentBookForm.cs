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

namespace StudentLibrary.StudentBookForm
{
	public partial class StudentBookForm : Form
	{
		public StudentBookForm()
		{
			StartPosition = FormStartPosition.CenterParent;
			InitializeComponent();
			Update();
		}
		private void Update()
		{
			using (var db = new Context())
				try
				{
					StudentBookRepository sbr = new StudentBookRepository(db);

					List<StudentBook> sb = sbr.GetAll().ToList();
					dataGridView1.DataSource = sb;
					dataGridView1.Refresh();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					throw;
				}
		}

		private void выдатьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			StudentBookAdd sba = new StudentBookAdd();
			sba.ShowDialog();
			Update();
		}

		private void StudentBookForm_Load(object sender, EventArgs e)
		{
			dataGridView1.Columns[0].HeaderText = "Номер";
			dataGridView1.Columns[1].HeaderText = "Дедлайн";
			dataGridView1.Columns[2].HeaderText = "Номер студента";
			dataGridView1.Columns[3].HeaderText = "Номер книги";
			dataGridView1.Columns[6].HeaderText = "Статус";
			dataGridView1.Columns["Student"].Visible = false;
			dataGridView1.Columns["Book"].Visible = false;

			try
			{
				using (var db = new Context())
				{
					StudentBookRepository sbr = new StudentBookRepository(db);

					List<StudentBook> sbList = sbr.GetAll().Where(x => x.ExpireDate < DateTime.Today).ToList();
					if (sbList.Count > 0)
						foreach (StudentBook sb in sbList)
						{
							sb.Status = "Expired";
						}
					db.SaveChanges();
					Update();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				throw;
			}
		}

		private void lostBtn_Click(object sender, EventArgs e)
		{
			int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
			DialogResult dr = MessageBox.Show("Книга потеряна", "Вы уверены что книга потеряна?", MessageBoxButtons.YesNo);
			if (dr == DialogResult.Yes)
			{
				using (Context db = new Context())
				{
					StudentBookRepository sbr = new StudentBookRepository(db);
					StudentBook lostBook = sbr.Get(id);
					lostBook.Status = "Lost";
					db.SaveChanges();
					Update();
				}
			}
		}

		private void заToolStripMenuItem_Click(object sender, EventArgs e)
		{
			StudentBookOneDateReport oneDateReport = new StudentBookOneDateReport();
			oneDateReport.ShowDialog();
		}

		private void заПромежутокToolStripMenuItem_Click(object sender, EventArgs e)
		{
			StudentBookTwoDateReport twoDateReport = new StudentBookTwoDateReport();
			twoDateReport.ShowDialog();
		}
	}
}
