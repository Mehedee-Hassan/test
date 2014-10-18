using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Department_Using_Layer_Arch_App
{
    public partial class University_UI : Form
    {
        public University_UI()
        {
            InitializeComponent();
        }

        private void departmentUiButton_Click(object sender, EventArgs e)
        {
            DepartmentUI departmentUI = new DepartmentUI();
            departmentUI.Show();

        }

        private void studentUiButton_Click(object sender, EventArgs e)
        {

            StudentUI studentUI = new StudentUI();
            studentUI.Show();
        }
    }
}
