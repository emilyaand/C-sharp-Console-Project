using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Project
{
    public class Pharmacy
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string MinSalary { get; set; }
        public string Budget { get; set; }
        public string Location { get; set; }
        public string Username { get; internal set; }
       // public Employee[] employee;
      //  public Drug[] drug;
    }
    public class Employee: Pharmacy
    {
        public int IdE { get; set; }
        public string NameE { get; set; }
        public string RoleType {
            get { return RoleType; }
            set { RoleType = value; }
                } //(Admin, Staff)
        public string Surname { get; set; }
        public int BirthDate { get; set; }
        public int Salary { get; set; }
        public string UsernameE {
            get { return UsernameE; }
            set { UsernameE = value; }
               }//(uniqiue) 
        public string PasswordE
        {
            get { return PasswordE; }
            set { PasswordE = value; }

        }//(uzunlugu 5den az olmayan, icinde en azi 1 reqem bir boyuk herf ve bir xarakter olmalidir)
        public bool IsPasswordValid()
        {
            if (PasswordE.Length < 5) return false;

            bool IsDigitIncluded = false;
            foreach    (char item in PasswordE)
            {
                if(int.TryParse(item+"", out int result))
                {
                    IsDigitIncluded = true;
                    break;
                }
            }
            if (IsDigitIncluded == false) return false;
            return true;
        }

    }
    public class Drug: Pharmacy    {
        public int IdP { get; set; }
        public string NameP { get; set; }
        public string DrugType {
            get { return DrugType; }
            set { DrugType = value; }
                } //(syrob, powder, tablet)
        public int Count { get; set; } 
        public int PurchasePrice { get; set; } 
        public int SalePrice { get; set; } 


    }
        
}
