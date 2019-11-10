using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    class User
    {
        public string Name { get; set; }

        private DateTime dateOfBirth;
        public DateTime DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }
            set
            {
                if (value.Year < 2010)
                {                 
                    this.dateOfBirth = value;
                }
                else
                {
                    this.dateOfBirth = DateTime.Now;
                }
            }
        }

        private string gender;
        public string Gender
        {
            get { return this.gender; }
            set
            {
                if (value == "Male" || value == "Female")
                {
                    this.gender = value;
                }
                else
                {
                    this.gender = "Unknown";
                }
            }
        }

        public Profile UserProfile { get; set; }

        public User()
        {
        }
        public User(string name, DateTime dateOfBirth, string gender = "Unknown")
        {
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
        }

        public void RegisterUser()
        {

        }

        public void CreateProfile()
        {
            this.UserProfile = new Profile();
        }

        public void PrintUserDetails()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine(this.DateOfBirth);
            Console.WriteLine(this.Gender);
            if (this.UserProfile != null && this.UserProfile.Interests != null)
            {                
                foreach (Interests interest in this.UserProfile.Interests)
                {
                    Console.Write($"{interest} ");
                }
            }
            Console.WriteLine();
        }




    }
}
