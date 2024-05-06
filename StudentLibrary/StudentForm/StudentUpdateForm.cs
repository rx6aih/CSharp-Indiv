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
	public partial class StudentUpdateForm : Form
	{
		private int id;
		public StudentUpdateForm(int id)
		{
			this.id = id;
			InitializeComponent();
			using (var db = new Context())
			{
				UniversityRepository ur = new UniversityRepository(db);
				List<University> universities = ur.GetAll().ToList();
				comboBox1.DataSource = universities;
				comboBox1.DisplayMember = "Name";
				comboBox1.ValueMember = "Id";

				StudentRepository sr = new StudentRepository(db);
				tbName.Text = sr.Get(id).FirstName;
				tbSName.Text = sr.Get(id).SecondName;
				tbAge.Text = sr.Get(id).Age.ToString();
				comboBox1.SelectedValue = sr.Get(id).UniversityId;
			}
		}

		private void btnYes_Click(object sender, EventArgs e)
		{
			try
			{
				using (var db = new Context())
				{
					StudentRepository ur = new StudentRepository(db);

					Student student = ur.Get(id);
					student.FirstName = tbName.Text;
					student.SecondName = tbSName.Text;
					student.Age = Convert.ToInt32(tbAge.Text);
					student.UniversityId = Convert.ToInt32(comboBox1.SelectedValue);

					db.SaveChanges();
					Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnNo_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
