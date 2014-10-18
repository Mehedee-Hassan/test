using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Department_Using_Layer_Arch_App.BLL;
using Department_Using_Layer_Arch_App.DLL.DAO;

namespace Department_Using_Layer_Arch_App
{
    public partial class StudentUI : Form
    {
        private StudentBLL aStudentBll = new StudentBLL();
        private List<Student> students;

        public StudentUI()
        {
            InitializeComponent();
            ShowDataInGrid();
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.Name = nameTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.Address = addressTextBox.Text;
          
            string msg = aStudentBll.Save(aStudent);
            MessageBox.Show(msg);
            ShowDataInGrid();
        }

        private void ShowDataInGrid()
        {
            
            students = aStudentBll.GetAllStudent();
            studentGridView.DataSource = students;
        }
    }
}
