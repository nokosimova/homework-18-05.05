using System;
using System.Collections;
using System.Text;


namespace homework18
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> CountryList = new MyList<string>();
            MyDictionary<int, string> ClientList = new MyDictionary<int, string>();
            Console.WriteLine("-----------list-----------");
            CountryList.Add("Tajikistan");
            CountryList.Add("Russia");
            CountryList.Add("Uzbeistan");
            CountryList.Add("Kazakhstan");
            CountryList.Add("Kyrgyztan");

            Console.Write("list[0] = ");
            Console.WriteLine(CountryList[0]);
            Console.Write("list[3] = ");
            Console.WriteLine(CountryList[3]);

            Console.Write("------------------------");
            Console.WriteLine("Show all list:  ");
            foreach (var i in CountryList)
                Console.WriteLine($"{i} ");

            Console.WriteLine("\n---------dictionary---------");
            ClientList.Add(10, "Umarov D.O.");
            ClientList.Add(2, "Komilov V.V");
            ClientList.Add(3, "Rashidova R.K.");
            ClientList.Add(4, "Turaev K.L.");
            ClientList.Add(5, "Valiev");
            //  ClientList[1] = "abc";
            Console.WriteLine($"Client[Valiev] = {ClientList[2]}");
            Console.WriteLine($"Client[Rashidova R.K.] = {ClientList[3]}");

            Console.WriteLine("------------------------");
            Console.WriteLine("Show all Client list:  ");
            foreach (Pair<int, string> i in ClientList.GetItems())
                Console.WriteLine($"{i.key} - {i.value} ");
            Console.ReadKey();
        }
    }
}
