using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student("Ajay", 55, 60, 90);
            student s2 = new student("Vijay", 65, 80, 75);
            student s3 = new student("Kiran", 85, 65, 70);

            s1.Calculate();
            s2.Calculate();
            s3.Calculate();

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(student.TotalCount());
        }
    }
}
