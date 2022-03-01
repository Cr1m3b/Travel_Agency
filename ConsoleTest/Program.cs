using MyDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var booking = db.Bookings.ToList();
            foreach (var book in booking)
            {
                Console.WriteLine(book.PurchaseDate);
            }
        }
    }
}
