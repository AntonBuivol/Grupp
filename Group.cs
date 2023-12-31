﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Grupp_ja_liikmed
{
    public class Group
    {
        public List<Liik> Members { get; } = new List<Liik>();
        private readonly int _maxAmount;

        public Group(int maxAmount)
        {
            _maxAmount = maxAmount;
        }

        public void CreateGroup()
        {
            Console.WriteLine("Kui palju inimesed: ");
            int count = Convert.ToInt32(Console.ReadLine());
        }

        public bool AddMember(Liik member)
        {
            Console.ForegroundColor = ConsoleColor.White;

            if (Members.Any(m => m.Name == member.Name && m.Lastname == member.Lastname && m.Age == member.Age))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("See inimene on juba olemas");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }

            if (member.Age<1 || member.Age>100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Selline vanus on võimatu.");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
            if (Members.Count >= _maxAmount)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Inimesed rohkem kuid oli vaja gruppis");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }

            Members.Add(member);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Inimene on lisatud");
            Console.ForegroundColor = ConsoleColor.White;
            return true;
        }

        public void ShowGroup()
        {
            foreach (Liik item in Members)
            {
                Console.Write(item.Name + " " + item.Lastname + ": " + item.Age + " aastad" + "; ");
            }
            
        }

        public int GetMembersCount()
        {
            return Members.Count;
        }

        public bool HasMember(Liik member)
        {
            return Members.Contains(member);
        }

        public void Oldest()
        {
            Liik m = new Liik("","",0);
            foreach (Liik item in Members)
            {
                if(item.Age > m.Age)
                {
                    m = item;
                }
            }
            Console.WriteLine("Vanem: " + m.Name + " " + m.Lastname + ": " + m.Age + " aastad");
            Console.WriteLine();
        }

        public void Youngest()
        {
            Liik m = new Liik("", "", 1000);
            foreach (Liik item in Members)
            {
                if (item.Age < m.Age)
                    m = item;
            }
            Console.WriteLine("Noorem: " + m.Name + " " + m.Lastname + ": " + m.Age + " aastad");
            Console.WriteLine();
        }

    }
}
