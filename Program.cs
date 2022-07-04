using System;
using System.Collections.Generic;

namespace Console_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Employee employee;
            Drug drug;
            employee = new Employee();
            employee.Name = "admin";
            employee.UsernameE = "Superadmin";
            employee.PasswordE = "admin123";
            Console.Clear();

            List<Employee> users = new List<Employee>();
            users.Add(new Employee { UsernameE = "Superadmin", PasswordE = "admin123" });
            
            bool CorrectLogin = Login(users);
            while (!CorrectLogin)
                {
                Console.WriteLine("The wromg Username or Password. Please try again");
                Login(users);
                }

                   
        }
        static bool Login(List<Employee> users)
        {
            Console.WriteLine("Please insert your Username: ");
            string Username = Console.ReadLine();
            Console.WriteLine("Indicate your Password: ");
            string Password = Console.ReadLine();

            Employee employee = users.Find(u => u.UsernameE == Username && u.PasswordE == Password);
            if (employee != null)
            {
               
                return false;
            }
            else return true;

        }
    }
}
