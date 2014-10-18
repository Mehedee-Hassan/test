using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using Department_Using_Layer_Arch_App.DLL.DAO;

namespace Department_Using_Layer_Arch_App.DLL.GATEWAY
{
    class DepartmentGateWay
    {
        private SqlConnection connection;
        private string TABLE_NAME1;



        public DepartmentGateWay()
        {
            string conn = @"server=SHAPLA4\SQLEXPRESS; 
                                database=Jahangirnagar University;
                                integrated security=true";

            TABLE_NAME1 = "table_Department";

            connection = new SqlConnection();
            connection.ConnectionString = conn;

        }




        public string Save(Department aDepartment)
        {
            connection.Open();
            string query = string.Format("INSERT INTO {2} VALUES('{0}','{1}')", aDepartment.Name,
                aDepartment.Code, TABLE_NAME1

                );


            SqlCommand command = new SqlCommand(query, connection);


            int affectedRow = command.ExecuteNonQuery();
            connection.Close();

            //change

            if (affectedRow > 0)
            {
                return "";
            }
            return "no";
        }


        public bool IsValidName(string name)
        {

            connection.Open();
            string query = string.Format("SELECT * FROM {1} WHERE Name='{0}'", name, TABLE_NAME1);

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();

            bool hasName = aReader.HasRows;


            connection.Close();

            return !hasName;
        }
        public bool IsValidCode(string code)
        {
            connection.Open();
            string query = string.Format("SELECT * FROM {1} WHERE Code='{0}'", code, TABLE_NAME1);

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            bool hasCode = reader.HasRows;


            connection.Close();

            return !hasCode;
        }




        public List<Department> GetAllDepartments()
        {
            connection.Open();

            string query = string.Format("SELECT * FROM {0}", TABLE_NAME1);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            List<Department> departments = new List<Department>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Department aDepartment = new Department(aReader[1].ToString(), aReader[2].ToString());
                    departments.Add(aDepartment);
                }
            }
            connection.Close();

            return departments;

        }
    }
}
