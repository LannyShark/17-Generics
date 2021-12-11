using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Account<int> account1 = new Account<int> { Number = 1, Balance = 16510, Name = "Permilovskiy I. A." };
            Account<string> account2 = new Account<string> { Number = "02", Balance = 10000, Name = "Demidowitch A. S." };
            Console.WriteLine($"{account1.Name}, {account1.Number}, {account1.Balance}");
            Console.WriteLine($"{account2.Name}, {account2.Number}, {account2.Balance}");
            Console.ReadKey();
        }
    }
    class Account<T>
    {
        public T Number { get; set; }
        public decimal Balance { get; set; }
        public string Name { get; set; }
    }
}
