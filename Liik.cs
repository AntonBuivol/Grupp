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
        Random r = new Random();

        private string _name;
        private int _age;

        public Liik(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string Name { get => _name; }
        public int Age { get => _age; }


        public Liik GetAll()
        {
            Console.WriteLine("Kiruta nimi: ");
            string name = Console.ReadLine();
            Console.WriteLine("Kirjuta vanus: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Liik lik = new Liik(name, age);
            return lik;
        }
        public void ShowLiik()
        {
            Console.WriteLine("Nimi: {0}\n Vanus: {1}", Name, Age);
        }

    public void Youngest()
        {

        }

    }
}
