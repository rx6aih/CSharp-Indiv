using StudentLibrary.DAL.EF;
using StudentLibrary.DAL.Repositories;
using StudentLibrary.DAL.Entities;
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
	public partial class UniversityAddForm : Form
	{

		public UniversityAddForm()
		{
			InitializeComponent();
		}

		private void yesButton_Click(object sender, EventArgs e)
		{
			try
			{
				using (Context db = new Context())
				{
					UniversityRepository ur = new UniversityRepository(db);
					ur.Create(new University { Name = nameTextBox.Text });
					db.SaveChanges();
					Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void UniversityAddForm_Load(object sender, EventArgs e)
		{
		}

		private void noButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
