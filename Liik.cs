using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Grupp_ja_liikmed
{
    public class Liik
    {

        private string _name;
        private string _lastname;
        private int _age;



        public Liik(string name, string lastname, int age)
        {
            _name = name;
            _lastname = lastname;
            _age = age;
        }

        public string Name { get => _name; }
        public string Lastname { get => _lastname; }
        public int Age { get => _age; }

        public Liik GetAll()
        {
            Console.WriteLine("Kiruta nimi: ");
            string name = Console.ReadLine();
            Console.WriteLine("Kiruta perenimi: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Kirjuta vanus: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Liik lik = new Liik(name, lastname, age);
            return lik;
        }
        public void ShowLiik()
        {
            Console.WriteLine("Nimi: {0} {1}\n Vanus: {2}", Name, Lastname, Age);
        }

    }
}
