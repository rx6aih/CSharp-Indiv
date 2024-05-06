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

namespace StudentLibrary.StudentForm
{
	public partial class StudentForm : Form
	{
		public StudentForm()
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
					StudentRepository sr = new StudentRepository(db);

					List<Student> students = sr.GetAll().ToList();
					dataGridView1.DataSource = students;
					dataGridView1.Refresh();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					throw;
				}
		}
		private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			StudentAddForm sa = new StudentAddForm();
			sa.ShowDialog();
			Update();
		}

		private void StudentForm_Load(object sender, EventArgs e)
		{
			dataGridView1.Columns[0].HeaderText = "Номер";
			dataGridView1.Columns[1].HeaderText = "Имя";
			dataGridView1.Columns[2].HeaderText = "Фамилия";
			dataGridView1.Columns[3].HeaderText = "Возраст";
			dataGridView1.Columns[4].HeaderText = "Номер университета";
			dataGridView1.Columns["University"].Visible = false;
		}

		private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
			DialogResult dr = MessageBox.Show("Удаление", "Вы уверены?", MessageBoxButtons.YesNo);
			if (dr == DialogResult.Yes)
			{
				using (Context db = new Context())
				{
					StudentRepository sr = new StudentRepository(db);
					sr.Delete(id);
					db.SaveChanges();
					Update();
				}
			}
		}

		private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
			StudentUpdateForm su = new StudentUpdateForm(id);
			su.ShowDialog();
			Update();
		}
	}
}
