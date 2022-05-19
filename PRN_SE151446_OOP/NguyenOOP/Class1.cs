using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_SE151446_OOP.NguyenOOP
{
    public class Student
    {
        /*Fields*/
        private int id;
        private string name;
        private DateTime dateOnly;
        private string _address;
        /*Property*/
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        //Init properties
        public double ? Mark { get; set; }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime DateOnly { get => dateOnly; set => dateOnly = value; }

        public Student()
        {

        }

        public Student(int id, string name, DateTime dateOnly, string address, double mark)
        {
            this.id = id;
            this.name = name;
            this.dateOnly = dateOnly;
            Address = address;
            Mark = mark;
        }
        
        /*to increase Mark with percent rate */

        public void IncreaseMarkByPercent(int? percent) 
        {
            if (percent > 0 && percent is not null)
            {
                int? percentAfter = percent / 100;
                this.Mark *= percentAfter;
            }
        }

        public override string? ToString() => $"Id = {id} name = {name} dateOnly = {dateOnly} address = {Address} mark = {Mark}" ;
 
    }
}
