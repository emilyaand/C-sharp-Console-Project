using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Project
{
    internal class Pharmacy
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string MinSalary { get; set; }
        public string Budget { get; set; }
        public string Location { get; set; }
    }
    class Employee: Pharmacy
    {
        public int IdE { get; set; }
        public string NameE { get; set; }
        public string RoleType { get; set; } //(Admin, Staff)
        public string Surname { get; set; }
        public int BirthDate { get; set; }
        public int Salary { get; set; }
        public string Username { get; set; }//(uniqiue) 
        public string Password { get; set; }//(uzunlugu 5den az olmayan, icinde en azi 1 reqem bir boyuk herf ve bir xarakter olmalidir)
    }
    class Drug: Pharmacy    {
        public int IdP { get; set; }
        public string NameP { get; set; }
        public string DrugType { get; set; } //(syrob, powder, tablet)
        public int Count { get; set; } 
        public int PurchasePrice { get; set; } 
        public int SalePrice { get; set; } 


    }
        
}
