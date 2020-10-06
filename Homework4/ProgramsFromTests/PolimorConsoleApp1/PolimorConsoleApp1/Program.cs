using System;

namespace PolimorConsoleApp1
{
    public class Class1
    {
        public virtual void Method1()
        {
            Console.WriteLine("Class1 Method1");
        }
        public virtual void Method2()
        {
            Console.WriteLine("Class1 Method2");
        }
        public virtual void Method3()
        {
            Console.WriteLine("Class1 Method3");
        }
    }
    public class Class2 : Class1
    {
        public new void Method1()
        {
            Console.WriteLine("Class2 Method1");
        }
        public override void Method2()
        {
            Console.WriteLine("Class2 Method2");
        }
        public void Method3()
        {
            Console.WriteLine("Class2 Method3");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class1 x = new Class1();
            Class2 y = new Class2();
            Class1 z = new Class2();
            y = x;
            x.Method1(); x.Method2(); x.Method3();
            Console.WriteLine("");
            y.Method1(); y.Method2(); y.Method2();
            Console.WriteLine("");
            z.Method1(); z.Method2(); z.Method2();
            Console.ReadKey();

        }
    }
}
