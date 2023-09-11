using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Grupp_ja_liikmed
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Group group = new Group(3);
            ////Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine(group.AddMember("John"));  // True
            //Console.WriteLine(group.AddMember("John"));  // False
            //Console.WriteLine(group.AddMember("Mary"));  // True
            //Console.WriteLine(group.AddMember("Jane"));  // True
            //Console.WriteLine(group.AddMember("Joseph"));  // False
            //Console.WriteLine(string.Join(", ", group.Members));  // John, Mary, Jane
            //Console.WriteLine(group.GetMembersCount());  // 3

            //Group bookClub = new Group(4);
            //Console.WriteLine(bookClub.AddMember("Albert"));   // True
            //Console.WriteLine(bookClub.AddMember("Samantha"));  // True
            //Console.WriteLine(bookClub.AddMember("Robert"));   // True
            //Console.WriteLine(bookClub.AddMember("Roberta"));  // True
            //Console.WriteLine(string.Join(", ", bookClub.Members));  // Albert, Samantha, Robert, Roberta

            //Console.WriteLine(bookClub.HasMember("Albert"));  // True
            //Console.WriteLine(bookClub.HasMember("John"));  // False
            //Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("Kui palju inimesed gruppis: ");
            int count = Convert.ToInt32(Console.ReadLine());

            Group grname = new Group(count);
            Liik lik = new Liik("","",0);
            while (true)
                {
                Console.WriteLine("Mida te tahete:\n1) Create Liik\n2) Kõige vanem\n3) Kõige noorem\n4) Show info\n5) Exit");
                ConsoleKeyInfo vali= Console.ReadKey();
                Console.WriteLine();
                switch(vali.KeyChar)
                {

                    case'1':
                        for (int i = 0; i < count; i++)
                        {
                            lik = lik.GetAll();
                            lik.ShowLiik();
                            grname.AddMember(lik);
                            Console.WriteLine();
                        }
                        break;
                        
                    case '2':
                        grname.Oldest();
                        break;
                
                    case '3':
                        grname.Youngest();
                        break;
                
                    case '4':
                        Console.WriteLine();
                        Console.WriteLine("Inimesed:");
                        grname.ShowGroup();
                        Console.WriteLine();
                        Console.WriteLine("Inimeste arv: " + grname.GetMembersCount());
                        Console.ReadLine();
                        break;
                
                    case '5':
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
