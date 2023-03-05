using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    static class UniversityStatisticsHandler
    {

        static public void Print(University university)
        {
            int departments_count = 0;
            int student_groups = 0;
            Console.WriteLine("University has:");
            Console.WriteLine(university.faculties.Count + " faculties");
            for (int i = 0; i < university.faculties.Count; i++)
            {
                departments_count += university.faculties[i].departments.Count;
                student_groups += university.faculties[i].studentGroups.Count;
            }
            Console.WriteLine(departments_count + " departments");
            Console.WriteLine(student_groups + " students groups");
        }
        static public void StudentList(University university)
        {
            for (int i = 0; i < university.faculties.Count; i++)
            {
                Console.WriteLine("Faculty #" + (i + 1));
                for (int j = 0; j < university.faculties[i].studentGroups.Count; j++)
                {
                    Console.WriteLine("Student Group #" + (j + 1));
                    for (int k = 0; k < university.faculties[i].studentGroups[j].Students.Count; k++)
                    {
                        university.faculties[i].studentGroups[j].Students[k].PrintInfo();
                    }
                }
            }
        }
        static public void TeacherList(University university)
        {
            for (int i = 0; i < university.faculties.Count; i++)
            {
                Console.WriteLine("Faculty #" + (i + 1));
                for (int j = 0; j < university.faculties[i].studentGroups.Count; j++)
                {
                    university.faculties[i].departments[j].DepInfo();
                }
            }
        }

    }

}
