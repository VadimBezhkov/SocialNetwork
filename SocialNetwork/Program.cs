using Entity;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            User us1 = new User
            {
                LastName = "Vadim",
                FirstName = "Bezhkov",
                Email = "vadimbezhkov3112@gmail.com",
                Login = "Vadim",
                Password = "123",
                SecondName = "Alexandrovich",
                TimeRegistration = DateTime.Now
            };
            using (StringContex db = new StringContex())
            {
                db.Users.Add(us1);
                db.SaveChanges();
            }
            Console.WriteLine("Готово");
                Console.ReadKey();
         
        }
    }
}
