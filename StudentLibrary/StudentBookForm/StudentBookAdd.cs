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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace StudentLibrary.StudentBookForm
{
	public partial class StudentBookAdd : Form
	{
		public StudentBookAdd()
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
					StudentRepository sr = new StudentRepository(db);
					List<Student> students = sr.GetAll().ToList();

					studentCb.DataSource = students;
					studentCb.DisplayMember = "SecondName";
					studentCb.ValueMember = "Id";


					BookRepository br = new BookRepository(db);
					List<Book> books = br.GetAll().ToList();

					bookCb.DataSource = books;
					bookCb.DisplayMember = "Name";
					bookCb.ValueMember = "Id";
					
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
					StudentBookRepository sbr = new StudentBookRepository(db);
					sbr.Create(new StudentBook
					{
						StudentId = Convert.ToInt32(studentCb.SelectedValue),
						BookId = Convert.ToInt32(bookCb.SelectedValue),
						ExpireDate = deadLineDateTimePicker.Value,
						Status = "Good"
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
