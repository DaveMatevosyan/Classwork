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
            User defaultUser = new User();
            //PrintUserDetails(defaultUser);

            User annaUser = new User();
            annaUser.Name = "Anna";
            annaUser.DateOfBirth = new DateTime(2014, 10, 11);
            annaUser.Gender = "Female";
            annaUser.CreateProfile();
            annaUser.UserProfile.Interests = new List<Interests> { Interests.Music, Interests.Sport };
            annaUser.PrintUserDetails();

            User johnUser = new User()
            {
                Name = "John",
                DateOfBirth = new DateTime(2000, 11, 12),
                Gender = "Male"
            };

            User jackUser = new User("Jack", new DateTime(2000, 09, 05), "Male");
            User user = new User("Jack", new DateTime(2000, 09, 05));
            user.CreateProfile();
            user.UserProfile.Interests = new List<Interests>() { Interests.Game, Interests.Sport };

            //PrintUserDetails(annaUser);
            //PrintUserDetails(johnUser);

            Console.ReadLine();
        }

        static void PrintUserDetails(User user)
        {
            Console.WriteLine(user.Name);
            Console.WriteLine(user.DateOfBirth);
            Console.WriteLine(user.Gender);
            Console.WriteLine();
        }
    }
}
