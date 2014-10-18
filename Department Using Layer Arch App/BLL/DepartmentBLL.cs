using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department_Using_Layer_Arch_App.DLL.DAO;
using Department_Using_Layer_Arch_App.DLL.GATEWAY;

namespace Department_Using_Layer_Arch_App.BLL
{
    class DepartmentBLL
    {

        private DepartmentGateWay aDepartmentGateWay;
        public DepartmentBLL()
        {
            aDepartmentGateWay = new DepartmentGateWay();
        }


        public bool IsValidData(string name, string code)
        {
            bool checkUName = aDepartmentGateWay.IsValidName(name);
            bool checkUCode = aDepartmentGateWay.IsValidCode(code);

            if (checkUCode && checkUName)
            {
                return true;
            }
            return false;
        }

        public string Save(Department aDepartment)
        {

            string msg1 = "";

            if (Epty(aDepartment))
            {
                msg1 += "Field Cannot Be Empty";
            }
            else
            {
                if (!aDepartmentGateWay.IsValidName(aDepartment.Name))
                {
                    msg1 += "\nName repeted";
                }

                if (!aDepartmentGateWay.IsValidCode(aDepartment.Code))
                {
                    msg1 += "\nCode repeted";
                }

                if (aDepartmentGateWay.IsValidCode(aDepartment.Code) && aDepartmentGateWay.IsValidName(aDepartment.Name))
                {
                    aDepartmentGateWay.Save(aDepartment);

                    msg1 += "\ninserted";
                }
            }

            return msg1;
        }

        private bool Epty(Department aDepartment)
        {

            if (aDepartment.Name == string.Empty || aDepartment.Code == string.Empty)
            {
                return true;
            }

            return false;
        }

        public List<Department> GetAllStudent()
        {


            return aDepartmentGateWay.GetAllDepartments();
        }
    }
}
