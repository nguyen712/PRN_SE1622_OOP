using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_SE151446_OOP.NguyenOOP
{
    public class employee: Person
    {
        public int ID { get; set; }
        public double salary { get; set; }
        public string level { get; set; }
        
        public employee()
        {

        }

        public employee(string name, Address address, DateTime dob, int iD, double salary, string level):base(name, address, dob)
        {
            ID = iD;
            this.salary = salary;
            this.level = level;
        }
        public override string Display()
        {
            return $"Id = {ID}, Salary = {salary}, level = {level} " + base.Display();
        }
    }
}
