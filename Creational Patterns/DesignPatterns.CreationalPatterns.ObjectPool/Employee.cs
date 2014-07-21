using System;

namespace DesignPatterns.CreationalPatterns.ObjectPool
{
    internal class Employee
    {
        private static int _employeeCount;

        private readonly int _employeeId;

        public Employee()
        {
            _employeeId = ++_employeeCount;
        }

        private int Id
        {
            get { return _employeeId; }
        }

        public override string ToString()
        {
            return String.Format("Employee with Id {0} ist working....", Id);
        }
    }
}