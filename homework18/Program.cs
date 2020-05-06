using System;
using System.Collections;
using System.Text;


namespace homework18
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> CountryList = new MyList<int>();
            MyDictionary<string, int> BalanceList = new MyDictionary<string, int>();
            Console.Writeline("-----------list-----------");
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
            foreach (MyList<string> i in CountryList)
                Console.Write($"{i} ");

            Console.WriteLine("---------dictionary---------");
            BalanceList.Add("Umarov D.O.", 1000);
            BalanceList.Add("Komilov V.V", 520000);
            BalanceList.Add("Rashidova R.K.", 1500);
            BalanceList.Add("Turaev K.L.", 500);
            BalanceList.Add("Valiev S.L.", 25000);

            Console.WriteLine($"balance[Valiev S.L.] = {BalanceList["Valiev S.L."]}");
            Console.WriteLine($"balance[Rashidova R.K.] = {BalanceList["Rashidova R.K."]}");

            Console.Write("------------------------");
            Console.WriteLine("Show all balance list:  ");
            foreach (MyDictionary<string,int> i in BalanceList)
                Console.Write($"{i} ");
            Console.ReadKey();
        }
    }
}
