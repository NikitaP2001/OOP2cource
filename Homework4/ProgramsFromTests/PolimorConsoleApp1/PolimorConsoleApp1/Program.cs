using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
struct Student
{
    public int age;  
}
class Student1
{
    public int age;
}
namespace PolimorConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student() { age = 17 };
            Student st2 = st1;
            st2.age = 20;
            Console.WriteLine("Struct: st1.age = {0}, st2.age = {1}", st1.age, st2.age);
            Student1 st3 = new Student1() { age = 17 };
            Student1 st4 = st3;
            st4.age = 20;
            Console.WriteLine("Struct: st3.age = {0}, st4.age = {1}", st3.age, st4.age);
            Console.ReadKey(true);
        }
    }
}
