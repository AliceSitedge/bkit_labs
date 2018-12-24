using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Employee
    {
        public int id;
        public string surname;
        public int departmentId;

        public Employee(int _id, string _surname, int _departmentId)
        {
            id = _id;
            surname = _surname;
            departmentId = _departmentId;
        }
    }
}
