using System;
using System.Collections.Generic;

namespace Delegate
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<string> strlist = new List<string>(); //{ "Sadiq", "Esqin", "Cavid", "Orxan", "Ramil"};
            strlist.Add("Sadiq");
            strlist.Add("Esqin");
            strlist.Add("Cavid");
            strlist.Add("Orxan");
            strlist.Add("Ramil");
            
            ChekWord(CheckName, strlist);
        }


        public static bool CheckName(string name)
        {
            return name != "Cavid";
        }


        public static string ChekWord(Predicate<string> predicate, List<string> names)
        {
            var name = "Cavid";
            foreach (var item in names)
            {
                if (predicate(item))
                {
                    Console.WriteLine(item);
                }
            }
            return name;
            
        }
    }

       
 
}
