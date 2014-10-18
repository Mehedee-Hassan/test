using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department_Using_Layer_Arch_App.DLL.DAO;

namespace Department_Using_Layer_Arch_App.DLL.GATEWAY
{
    internal class StudentGateway
    {
         private SqlConnection connection;
         private string TABLE_NAME1;
         public StudentGateway()
         {

             string conn = @"server=SHAPLA4\SQLEXPRESS; 
                                database=Jahangirnagar University;
                                integrated security=true";

             TABLE_NAME1 = "table_Student";
             
             connection = new SqlConnection();
             connection.ConnectionString = conn;
         }

         public string Save(Student aStudent)
        {
            connection.Open();
            string query = string.Format("INSERT INTO {3} VALUES('{0}','{1}','{2}')", aStudent.Name,
                aStudent.Email, aStudent.Address, TABLE_NAME1);
            SqlCommand command = new SqlCommand(query, connection);

            int affectedRows = command.ExecuteNonQuery();
            connection.Close();
            if (affectedRows > 0)
                return "insert success";
            return "something wrong";
        }

        public bool HasThisEmailValid(string email)
        { 
            connection.Open();
            string query = string.Format("SELECT * FROM {1} WHERE Email='{0}'", email, TABLE_NAME1);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            bool Hasrow = aReader.HasRows;
            connection.Close();
            return Hasrow;
        }

        public List<Student> GetAllStudent()
        {
            connection.Open();
            string query = string.Format("SELECT * FROM {0}", TABLE_NAME1);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            List<Student> students = new List<Student>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Student aStudent = new Student();
                    aStudent.StudentId = (int) aReader[0];
                    aStudent.Name = aReader[1].ToString();
                    aStudent.Email = aReader[2].ToString();
                    aStudent.Address = aReader[3].ToString();
                    students.Add(aStudent);
                }
            }
            connection.Close();
            return students;
        }
    }
}
