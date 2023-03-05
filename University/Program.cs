using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
          Student student = new Student("Tom",Gender.Male,"#100011223","Ukraine","KNP-213",2);

          student.PrintInfo();

          

        }
    }
}
