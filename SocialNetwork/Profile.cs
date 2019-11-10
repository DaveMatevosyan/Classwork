using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    class Profile
    {
        public List<User> Friends { get; set; }
        private List<Intersets> ListOfInterests { get; set; }

        public Profile()
        {
            this.Friends = new List<User>();
            this.ListOfInterests = new List<Intersets>();
        }
        public void AddInterest(Intersets interest)
        {
            this.ListOfInterests.Add(interest);
        }

        public void PrintInterests()
        {
            if (this.ListOfInterests != null)
            {
                foreach (var interest in this.ListOfInterests)
                {
                    Console.Write($"{interest} ");
                }
            }
        }

        public int NumberOfFriends()
        {
            return this.Friends.Count;
        }
    }
}
