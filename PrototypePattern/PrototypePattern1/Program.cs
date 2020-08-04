using System;

namespace PrototypePattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------1-й вариант использования
            var workAddress = new Address { City = "Perm", Street = "Pushkina", Suite = 100 };
            var anton = new Contact
            {
                Name = "Anton",
                WorkAddress = workAddress.DeepCopy()
            };

            anton.WorkAddress.Suite = 1000;

            var lena = new Contact
            {
                Name = "Lena",
                WorkAddress = workAddress.DeepCopy()
            };
            lena.WorkAddress.Suite = 500;

            Console.WriteLine(anton);
            Console.WriteLine(lena);
            //------------------------2-й вариант использования
            var employee = new Contact
            { 
                WorkAddress = new Address
                { 
                    City = "Perm", 
                    Street = "Pushkina"
                }
            };

            var vasya = employee.DeepCopy();
            vasya.Name = "Vasya";
            vasya.WorkAddress.Suite = 125;
            Console.WriteLine(vasya);
            //------------------------3-й вариант использования

            var petya = EmployeeFactory.NewMainOfficeEmployee("Petya", 300);
            var yulia = EmployeeFactory.NewSecondOfficeEmployee("Yulia", 50000);
            Console.WriteLine(petya);
            Console.WriteLine(yulia);
            
            
            Console.ReadLine();
        }
    }
}
