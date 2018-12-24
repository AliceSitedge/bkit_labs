using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class DepartmentEmployeeRelation
    {
        public int employeeId;
        public int departmentId;

        public DepartmentEmployeeRelation(int _empId, int _depId)
        {
            employeeId = _empId;
            departmentId = _depId;
        }
    }
}
