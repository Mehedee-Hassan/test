using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_Using_Layer_Arch_App.DLL.DAO
{
    class Department
    {

        public string Name { get; set; }
        public string Code { get; set; }


        public Department(string name, string code)
        {
            Name = name;
            Code = code;
        }

    }
}
