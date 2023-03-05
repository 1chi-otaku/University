using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    abstract class IDepartment
    {
        public IDepartment()
        {
            DepHead = new DepHead();
        }
        abstract public  DepHead DepHead { get; set; }
        abstract public void DepInfo();
    }
    class Department : IDepartment
    {
        public Department() : base() { }
        public Department(DepHead depHead)
        {
            DepHead = depHead;
        }

        public override DepHead DepHead { get; set; }

        public override void DepInfo()
        {
            Console.WriteLine("This is a department. " + DepHead.Name + " is a Department Head!");
        }
    }
    class SpecDep : IDepartment
    {
        public SpecDep() : base() { }
        public SpecDep(DepHead depHead)
        {
            DepHead = depHead;
        }
        public override DepHead DepHead { get; set; }

        public override void DepInfo()
        {
            Console.WriteLine("This is a special department. " + DepHead.Name + " is a Department Head!");
        }
    }
    class University
    {
        public List<Faculty> faculties { get; set; }

        public University()
        {
           faculties= new List<Faculty>();
        }
        public University(Faculty faculty)
        {
            faculties = new List<Faculty> { faculty };
        }
        public University(List<Faculty> faculties)
        {
            this.faculties = faculties;
        }
        public void AddFaculty(Faculty faculty)
        {
            faculties.Add(faculty);
        }
        public void DeleteFaculty(Faculty faculty)
        {
            faculties.Remove(faculty);
        }
       
    }

    class Faculty
    {
        public List<IDepartment> departments { get; set; }
        public List<StudentGroup> studentGroups { get; set; }

        public Faculty() { 
           departments.Add(new Department());
           studentGroups.Add(new StudentGroup());
        }
        public Faculty(List<IDepartment> departments, List<StudentGroup> studentGroups)
        {
            this.departments = departments;
            this.studentGroups = studentGroups;
        }
        public void AddDepartment(IDepartment department)
        {
            departments.Add(department);
        }
        public void DeleteDepartment(IDepartment department)
        {
            departments.Remove(department);
        }
    }
}
