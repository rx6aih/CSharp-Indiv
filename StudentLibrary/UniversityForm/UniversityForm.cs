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

namespace StudentLibrary.UniversityForm
{
	public partial class UniversityForm : Form
	{
		public UniversityForm()
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
					UniversityRepository ur = new UniversityRepository(db);

					List<University> universities = ur.GetAll().ToList();
					dataGridView1.DataSource = universities;
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
			UniversityAddForm ua = new UniversityAddForm();
			ua.ShowDialog();
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
					UniversityRepository ur = new UniversityRepository(db);
					ur.Delete(id);
					db.SaveChanges();
					Update();
				}
			}
		}

		private void UniversityForm_Load(object sender, EventArgs e)
		{
			dataGridView1.Columns[0].HeaderText = "Номер университета";
			dataGridView1.Columns[1].HeaderText = "Название университета";
		}
	}
}
