using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.ObjectPool
{
    class Employee
    {
        private static int EmployeeCount = 0;

        private int employeeId = 0;

        public Employee()
        {
            this.employeeId = ++EmployeeCount;
        }

        public int Id { get { return this.employeeId; } }

        public string ToString()
        {
            return String.Format("Employee with Id {0} ist working....", Id);
        }
    }
}
