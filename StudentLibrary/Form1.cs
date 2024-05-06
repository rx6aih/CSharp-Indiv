using StudentLibrary.DAL.EF;
using StudentLibrary.StudentForm;
using StudentLibrary.UniversityForm;
using System.Runtime.InteropServices;

namespace StudentLibrary
{
	public partial class Form1 : Form
	{
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn
	   (
		   int nLeftRect,     // x-coordinate of upper-left corner
		   int nTopRect,      // y-coordinate of upper-left corner
		   int nRightRect,    // x-coordinate of lower-right corner
		   int nBottomRect,   // y-coordinate of lower-right corner
		   int nWidthEllipse, // width of ellipse
		   int nHeightEllipse // height of ellipse
	   );
		private Context db = new Context();
		public Form1()
		{
			InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.None;
			Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void universityButton_Click(object sender, EventArgs e)
		{
			UniversityForm.UniversityForm uf = new UniversityForm.UniversityForm();
			uf.ShowDialog();
		}

		private void studentButton_Click(object sender, EventArgs e)
		{
			StudentForm.StudentForm sf = new StudentForm.StudentForm();
			sf.ShowDialog();
		}

		private void bookButton_Click(object sender, EventArgs e)
		{
			BookForm.BookForm bf = new BookForm.BookForm();
			bf.ShowDialog();
		}

		private void studentBookButton_Click(object sender, EventArgs e)
		{
			StudentBookForm.StudentBookForm sbf = new StudentBookForm.StudentBookForm();
			sbf.ShowDialog();
		}
	}
}
