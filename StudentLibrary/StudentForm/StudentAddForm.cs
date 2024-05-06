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
	public partial class StudentAddForm : Form
	{
		public StudentAddForm()
		{
			InitializeComponent();
			Update();
		}
		public void Update()
		{
			using (var db = new Context())
			{
				try
				{
					UniversityRepository ur = new UniversityRepository(db);
					List<University> universities = ur.GetAll().ToList();
					comboBox1.DataSource = universities;
					comboBox1.DisplayMember = "Name";
					comboBox1.ValueMember = "Id";
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void btnYes_Click(object sender, EventArgs e)
		{
			using (var db = new Context())
			{
				try
				{
					StudentRepository sr = new StudentRepository(db);
					sr.Create(new Student
					{
						FirstName = tbName.Text,
						SecondName = tbSName.Text,
						Age = Convert.ToInt32(tbAge.Text),
						UniversityId = Convert.ToInt32(comboBox1.SelectedValue)
					});
					db.SaveChanges();
					Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void btnNo_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
