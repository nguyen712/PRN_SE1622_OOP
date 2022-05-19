using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_SE151446_OOP.NguyenOOP
{
    public class Person
    {
        protected string Name { get; set; }
        protected Address Address { get; set; }//HAS-(not cách kế thừa)
        protected DateTime dob { get; set; }
        public Person()
        {

        }

        public Person(string name, Address address, DateTime dob)
        {
            Name = name;
            Address = address;
            this.dob = dob;
        }
        public virtual string Display()
        {
            return $"[Name = {Name}], Address = {Address}, dob = {dob}";
        }
    }
}
