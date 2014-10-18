using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department_Using_Layer_Arch_App.DLL.DAO;
using Department_Using_Layer_Arch_App.DLL.GATEWAY;

namespace Department_Using_Layer_Arch_App.BLL
{
    class StudentBLL
    {
       private StudentGateway aStudentGateway;

        public StudentBLL()
        {
            aStudentGateway = new StudentGateway();
        }

        public string Save(Student aStudent)
        {
            
            if (aStudent.Name == string.Empty || aStudent.Email == string.Empty || aStudent.Address == string.Empty)
            {
                return "please fill up all field";
            }
            else
            {
                if (!HasThisEmailValid(aStudent.Email))
                {
                    return aStudentGateway.Save(aStudent);
                }
                else
                {
                    return "email address already in system";
                }
            }

        }
        private bool HasThisEmailValid(string email)
        {
            return aStudentGateway.HasThisEmailValid(email);
        }

        public List<Student> GetAllStudent()
        {
            return aStudentGateway.GetAllStudent();
        }
    }
}
