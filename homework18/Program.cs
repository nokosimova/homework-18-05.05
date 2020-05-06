using System;
using System.Collections;
using System.Text;


namespace homework18
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> newlist = new MyList<int>();
            newlist.Add(3);
            newlist.Add(5);
            newlist.Add(10);
            Console.WriteLine(newlist[0]);
            Console.ReadKey();
        }
    }
}
