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
	public partial class BookAddForm : Form
	{
		public BookAddForm()
		{
			InitializeComponent();
		}

		private void btnYes_Click(object sender, EventArgs e)
		{
			try
			{
				using (Context db = new Context())
				{
					BookRepository ur = new BookRepository(db);
					ur.Create(new Book { Name = tbName.Text, Price = Convert.ToInt32(tbPrice.Text) });
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
