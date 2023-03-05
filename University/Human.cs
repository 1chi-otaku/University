using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
