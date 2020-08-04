using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern1
{
    public class EmployeeFactory
    {
        private static Contact main = new Contact
        {
            WorkAddress = new Address()
            {
                City = "Perm",
                Street = "Pushkina"
            }
        };

        private static Contact second = new Contact
        {
            WorkAddress = new Address()
            {
                City = "Perm",
                Street = "Osipenko"
            }
        };

        private static Contact NewEmployee(string name, int suite, Contact prototype)
        {
            var employee = prototype.DeepCopy();
            employee.Name = name;
            employee.WorkAddress.Suite = suite;
            return employee;
        }

        public static Contact NewMainOfficeEmployee(string name, int suite)
        {
            return NewEmployee(name, suite, main);
        }

        public static Contact NewSecondOfficeEmployee(string name, int suite)
        {
            return NewEmployee(name, suite, second);
        }
    }
}

