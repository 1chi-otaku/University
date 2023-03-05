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
          Parent[] parents_1 = new Parent[2] { new Parent("Tom",Gender.Male,"3419911","Ukraine"), new Parent("Tasha", Gender.Female, "3311419911", "Ukraine") };
          Parent[] parents_2 = new Parent[2] { new Parent("Nicolas", Gender.Male, "754169911", "Hungary"), new Parent("Fiona", Gender.Female, "671419911", "Poland") };
          Student student = new Student("Tom",Gender.Male,"#100011223","Ukraine","KNP-213",parents_1);
          Student student2 = new Student("Elise", Gender.Female, "#23042223", "GB", "KNP-213", 0);
          Student student3 = new Student("George", Gender.Male, "#100011223", "Poland", "KNP-211", parents_2);
          StudentGroup KNP213 = new StudentGroup(student,"KNP-213");
          KNP213.AddStudent(student3);
          StudentGroup KNP211 = new StudentGroup(student2, "KNP-211");
          List <StudentGroup> studentGroups = new List<StudentGroup>();
          studentGroups.Add(KNP213);
          studentGroups.Add(KNP211);
          List<IDepartment> departments = new List<IDepartment>();
          departments.Add(new Department(new DepHead("Dr.Makami", Gender.Male, "43194291491", "USA", "Department Head")));
          departments.Add(new Department(new DepHead("Dr.Rinna", Gender.Female, "91351491491", "USA", "Department Head")));
          Faculty faculty = new Faculty(departments,studentGroups);

          University university = new University(faculty);

          university.Print();







        }
    }
}
