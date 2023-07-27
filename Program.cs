using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading
{
    public class OurClass
    {
        public void Display()
        {
            Console.WriteLine("Display of Our Class");
        }
        public void Display(string name)
        {
            Console.WriteLine("Welcome to Display "+name);
        }
        public void Display(string fname,string lname)
        {
            Console.WriteLine("Welcome to Display Mr.\\Ms. "+fname+" "+lname);
        }
        public double Add(double num1,double num2)
        {
            Console.WriteLine("Int Method Call");
            return num1 + num2;
        }
        public int Add(int num1,int num2)
        {
            Console.WriteLine("Int Method Call");
            return num1 + num2;
        }
        public string Add(string fname,string lname)
        {
            Console.WriteLine("String Method Call");
            return fname + " " + lname;
        }
        public void Increment(int num)
        {
            num += 3;
            Console.WriteLine("Number After Increment "+num);
        }
        //public void Increment(ref int num)
        //{
        //    num += 5;
        //    Console.WriteLine("Number After Increment "+num);
        //}
        public void Increment(out int num)
        {
            num = 5;
            Console.WriteLine("Number After Increment "+num);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            OurClass obj = new OurClass();
            //obj.Display("sam");
            //obj.Display();
            //Console.WriteLine(obj.Add("raj","Kumar"));
            int num = 45;
            obj.Increment(num);
            obj.Increment(out num);
        }
    }
}
