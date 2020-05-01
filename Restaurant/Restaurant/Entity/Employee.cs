using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entity
{
    public class Employee
    {
        public int id { get; set; }
        public String Name { get; set; }
        public String Identity { get; set; }
        public String Dob { get; set; }
        public int Gender { get; set; }
        public String Phone { get; set; }
        public String Address { get; set; }
        public String Role { get; set; }
        public int Salary { get; set; }
        public String Start_date { get; set; }

        public String Description { get; set; }
        public Employee(string name, string identity, string dob, int gender, string phone, string address, string role, int salary , String Description)
        {
            Name = name;
            Identity = identity;
            Dob = dob;
            Gender = gender;
            Phone = phone;
            Address = address;
            Role = role;
            Salary = salary;
            this.Description = Description;
        }

        public Employee()
        {

        }
    }
}
