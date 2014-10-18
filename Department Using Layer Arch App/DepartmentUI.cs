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
using Department_Using_Layer_Arch_App.DLL.GATEWAY;

namespace Department_Using_Layer_Arch_App
{
    public partial class DepartmentUI : Form
    {

        //private DepartmentGateWay aDepartmentGateWay;
        private DepartmentBLL aDepartmentBll = new DepartmentBLL();
        private List<Department> departments;

        public DepartmentUI()
        {

            InitializeComponent();

            ShowDataInGrid();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Department aDepartment = new Department(nameTextBox.Text, codeTextBox.Text);

            string msg = aDepartmentBll.Save(aDepartment);
            MessageBox.Show(msg);

            ShowDataInGrid();

        }


        private void ShowDataInGrid()
        {
            departments = aDepartmentBll.GetAllStudent();
            departmentDataGridView.DataSource = departments;
        }
    }
}
