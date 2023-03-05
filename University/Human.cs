using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace University
{
    public enum Gender
    {
        Male,
        Female,
        NoData
    }
    abstract class Human
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string PassportId { get; set; }
        public string Residence { get; set; }

        public Human() { 
            Name = string.Empty;
            Gender = Gender.NoData;
            PassportId = string.Empty;
            Residence = string.Empty;
        }
       public Human(string name, Gender gender, string passportId, string residence)
       {
            Name = name;
            Gender = gender;
            PassportId = passportId;
            Residence = residence;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine("Name - " + Name);
            Console.WriteLine("Gender - " + Gender);
            Console.WriteLine("Passport Id - " + PassportId);
            Console.WriteLine("Residence - " + Residence);
        }
    }

    class Parent : Human
    {
        public Parent() : base() { }
        public Parent(string name,Gender gender,string passportId,string residence):base(name,gender,passportId,residence) { }
        public void BeParent() => Console.WriteLine(Name + " is being a parent!");
        public override void PrintInfo()
        {
            base.PrintInfo();
        }
    }
    class Student : Human
    {
        public string Group { get; set; }
        public Parent[] parents { get; set; }

        public Student():base()
        {
            Group = string.Empty;
            parents = new Parent[0];
        }
        public Student(string name, Gender gender, string passportId, string residence, string group, Parent[] parents) : base(name, gender, passportId, residence)
        {
            Group = group;
            this.parents = parents;
        }
        public Student(string name, Gender gender, string passportId, string residence, string group, int parents_count) : base(name, gender, passportId, residence)
        {
            Group = group;
            parents = new Parent[parents_count];
            for (int i = 0; i < parents.Length; i++)
            {
                parents[i] = new Parent();
            }
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("-----------------------\nParents: ");
            for (int i = 0; i < parents.Length; i++)
            {
                parents[i].PrintInfo();
                Console.WriteLine();
            }
            Console.Write("-----------------------");
            Console.WriteLine();
        }

        public void Study() => Console.WriteLine(Name + " from group " + Group + " is studying!");

    }
    class StudentGroup
    {
        public string GroupName { get; set; }
        public List<Student> Students;

        public StudentGroup()
        {
            Students = new List<Student>();
        }
        public StudentGroup(List<Student> students,string groupName)
        {
            Students = students;
            GroupName = groupName;
        }
        public StudentGroup(Student student, string groupName)
        {
            Students = new List<Student>
            {
                student
            };
            GroupName = groupName;
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }

        public void PrintStudents()
        {
            Console.WriteLine("Group - " + GroupName);
            for (int i = 0; i < Students.Count; i++)
            {
                Console.WriteLine(i+1 + "|");
                Students[i].PrintInfo();
            }
        }
        

    }

    class Teacher:Human
    {
        public string Position { get; set; }
        public Teacher() : base()
        {
            Position = string.Empty;
        }
        public Teacher(string name, Gender gender, string passportId, string residence, string position):base(name,gender,passportId,residence)
        {
            Position = position;
        }
        public virtual void Teach()
        {
            Console.WriteLine(Name + " is teaching!");
        }
    }
    class DepHead : Teacher
    {
        public DepHead():base()
        {
        }
        public DepHead(string name, Gender gender, string passportId, string residence, string position) : base(name, gender, passportId, residence,position)
        {
        }
        public override void Teach()
        {
            base.Teach();
            Console.WriteLine(Name + " is a Department Head!");
        }

    }
}
