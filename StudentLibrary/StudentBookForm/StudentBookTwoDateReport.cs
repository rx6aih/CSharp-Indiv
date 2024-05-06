using Microsoft.Office.Interop.Excel;
using StudentLibrary.DAL.EF;
using StudentLibrary.DAL.Entities;
using StudentLibrary.DAL.Repositories;
using StudentLibrary.StudentBookForm.Comparers;
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
	public partial class StudentBookTwoDateReport : Form
	{
		public StudentBookTwoDateReport()
		{
			InitializeComponent();
		}

		private void btnYes_Click(object sender, EventArgs e)
		{
			try
			{
				using(var db = new Context())
				{
					StudentBookRepository sbr = new StudentBookRepository(db);
					List<StudentBook> studentsBooks = sbr
						.GetAll()
						.Where(x => x.ExpireDate.Date > dateTimePicker1.Value.Date && x.ExpireDate.Date < dateTimePicker2.Value.Date)
						.ToList();

					StudentRepository sr = new StudentRepository(db);
					//List<Student> result = new List<Student>();
					//foreach (var aStudent in students)
					//{
					//	Student bStudent = sr.Get(aStudent.StudentId);
					//	result.Add(bStudent);
					//}

					OpenFileDialog ofd = new OpenFileDialog();
					ofd.ShowDialog();
					string filename = ofd.FileName;

					Microsoft.Office.Interop.Excel.Application excelObj = new Microsoft
						.Office
						.Interop
						.Excel
						.Application();
					excelObj.Visible = true;

					Workbook wb = excelObj.Workbooks
						.Open(filename, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);

					Worksheet worksheet = wb.Worksheets[1];
					worksheet.Cells[1, 1].Value = "Номер";
					worksheet.Cells[1, 2].Value = "Дэдлайн";
					worksheet.Cells[1, 3].Value = "Номер студента";
					worksheet.Cells[1, 4].Value = "Номер книги";

					try
					{
						int i = 2;

						int all = sbr.GetAll().Count();
						int expired = sbr.GetAll().Where(x => x.Status == "Expired").Count();
						int lost = sbr.GetAll().Where(x => x.Status == "Lost").Count();

						for (; i <= studentsBooks.Count + 1; i++)
						{
							var some2 = studentsBooks[i - 2];
							worksheet.Cells[i, 1].Value = studentsBooks[i - 2].Id.ToString();
							worksheet.Cells[i, 2].Value = studentsBooks[i - 2].ExpireDate.ToLongDateString();
							worksheet.Cells[i, 3].Value = studentsBooks[i - 2].StudentId.ToString();
							worksheet.Cells[i, 4].Value = studentsBooks[i - 2].BookId.ToString();
						}

						worksheet.Cells[i + 1, 4] = "Всего :" + all.ToString();
						worksheet.Cells[i + 2, 4] = "Просрочено" + expired.ToString();
						worksheet.Cells[i + 3, 4] = "Потеряно:" + lost.ToString();

						wb.Save();
						Close();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				throw;
			}
		}

		private void btnNo_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
