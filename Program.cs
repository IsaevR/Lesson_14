using PhoneBookApp.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person {Name = "Alexander", Phone = "986118792", Department = "Engineer" };
            PhoneBookDb db = new PhoneBookDb();
            db.People.Add(person);
            db.SaveChanges();
            Console.WriteLine("Id | Name       | Phone         |  Department  ");
            Console.WriteLine("-----------------------------------------------");
            foreach(var p in db.People)
            {
                Console.Write(" {0} | \b",p.Id);
                Console.Write(" {0}",p.Name);
                Console.Write("\t|{0}",p.Phone);
                Console.Write("\t|{0}", p.Department);
                Console.WriteLine();
            }
        }

    }
}
