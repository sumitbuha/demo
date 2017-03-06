using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
     abstract class hello
    {
        public abstract int mymeth();
    }
    class first
    {
        public string this[int i]
        {

        }
        int length;
        int height;
        int width;
        public first(int a,int b)
        {
          length = a;
          height = b;

        }
        public override int mymeth()
        {
            return (length * height);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            first f = new first(10,20);
            int result =f.mymeth();
            Console.WriteLine("Area is:{0}",result);
            Console.ReadLine();
        }
    }
}
