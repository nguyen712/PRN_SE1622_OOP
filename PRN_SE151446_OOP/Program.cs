namespace Pro_SE1622;

using PRN_SE151446_OOP.NguyenOOP;
using static System.Console;
public class Program
{
    public static void Main()
    {
        //WriteLine("Hello");
        //ReadLine();
        //Student x = new Student(1, "nguyen", DateTime.Parse("7/12/2001"), "111", 10);
        //Student a = new Student();
        ///a.Name = "Nguyen";
        //a.Id = 1;
        //a.Mark = 10;
        //a.DateOnly = new DateTime().AddDays(7).AddMonths(12).AddYears(2001);
        //a.Address = "FPT";
        //WriteLine(a);
        //a.IncreaseMarkByPercent(100);
        employee e = new employee("Nguyen", new Address(111, "P6", "CMT8", "HCM"), DateTime.Parse("7/12/2001"), 1, 1000000, "Fesher");
        WriteLine(e.Display());
    }
}