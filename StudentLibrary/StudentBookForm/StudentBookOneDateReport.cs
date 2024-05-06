using Microsoft.Office.Interop.Excel;
using StudentLibrary.DAL.EF;
using StudentLibrary.DAL.Entities;
using StudentLibrary.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using StudentLibrary.StudentBookForm.Comparers;

namespace StudentLibrary.StudentBookForm
{
	public partial class StudentBookOneDateReport : Form
	{
		public StudentBookOneDateReport()
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
					universityCb.DataSource = universities;
					universityCb.DisplayMember = "Name";
					universityCb.ValueMember = "Id";
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void btnYes_Click(object sender, EventArgs e)
		{
			try
			{
				using (var db = new Context())
				{
					StudentBookRepository sbr = new StudentBookRepository(db);
					var some = dateTimePicker.Value;
					List<StudentBook> badStudents = sbr
						.GetAll()
						.Where(x => x.Status != "Good" && x.ExpireDate.Day == dateTimePicker.Value.Day)
						.GroupBy(x=>x.StudentId)
						.Select(x=>x.FirstOrDefault())
						.Distinct(new StudentBookComparer())
						.ToList();

					StudentRepository sr = new StudentRepository(db); 
					List<Student> result = new List<Student>();
					foreach (var aStudent in badStudents)
					{
						Student bStudent = sr.Get(aStudent.StudentId);
						if (bStudent.UniversityId == Convert.ToInt32(universityCb.SelectedValue))
							result.Add(bStudent);
					}

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
					worksheet.Cells[1, 2].Value = "Имя";
					worksheet.Cells[1, 3].Value = "Фамилия";
					worksheet.Cells[1, 4].Value = "Возраст";

					try
					{
						for (int i = 2; i <= result.Count+1; i++)
						{
							var some2 = result[i - 2];
							worksheet.Cells[i, 1].Value = result[i - 2].Id.ToString();
							worksheet.Cells[i, 2].Value = result[i - 2].FirstName.ToString();
							worksheet.Cells[i, 3].Value = result[i - 2].SecondName.ToString();
							worksheet.Cells[i, 4].Value = result[i - 2].Age.ToString();

						}
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
			}
		}

		private void btnNo_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
