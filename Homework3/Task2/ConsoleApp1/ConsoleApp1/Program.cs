using System;
using System.Collections.Generic;
using System.Data;

namespace ConsoleApp1
{
    abstract class Student
    {
        public Student(string n) { name = n; state = ""; }  
        public void Read() {
            state += "Read";                                
        }
        public void Write()
        {
            state += "Write";
        }
        public void Relax()
        {
            state += "Relax";
        }
        public abstract void Study();
        public string name;
        public string state;
    }
    class GoodStudent : Student
    {
        public GoodStudent(string n)
        : base(n) { state = "Good";  }
        public override void Study() {
            Read();
            Write();
            Read();
            Write();
            Relax();
        }
    }
    class BadStudent : Student  
    {
        public BadStudent(string n)
        : base(n) { state = "Bad"; }
        public override void Study() {
            Relax();
            Relax();
            Relax();
            Relax();
        }
    }
    class Group
    {
        string Name;
        List<Student> students = new List<Student>();
        public Group (string GroupName) { Name = GroupName; }
        public void AddStudent(Student st)
        {
            students.Add(st);
        }
        public string GetInfo()
        {
            string temp = "";
            temp += "Group: " + Name + " Students: ";
            foreach (Student st in students)
            {
                temp += st.name + " ";
            }
            return temp;
        }
        public string GetFullInfo()
        {
            string temp = "";
            temp += "Group: " + Name + " Students: ";
            foreach (Student st in students)
            {
                temp += st.state + " " + st.name + " ";
            }
            return temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Group gr = new Group("gr"); // Create group
            BadStudent a = new BadStudent("stud1");  // Create students
            GoodStudent b = new GoodStudent("stud2");
            gr.AddStudent(a); // Adding students to a group
            gr.AddStudent(b);
            Console.WriteLine(gr.GetInfo() + "\n" + gr.GetFullInfo());
        }
    }
}
