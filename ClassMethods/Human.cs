using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassMethods
{
    internal class Human // <- klase
    {
        public string FirstName { get; set; }   // <- propertis (string tipo)
        public string LastName { get; set; }    // <- propertis
        public int Age { get; set; }            // <- propertis
        public string Email { get; set; }      // <- propertis
        public List<Pet> Pets { get; set; } = new List<Pet>();    // <- propertis (automatiskai inicializuojamas)

        public Human(string firstName, string lastName, int age)    // <- konstruktorius
        {
            // priskiriame parametrus properciams:
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string GetFullName()             // <- klases metodas
        {
            return $"{FirstName} {LastName}";
        }

        public void UpdateEmail(string newEmail)
        {
            if (IsValidEmail(newEmail))
            {
                Email = newEmail;
            }
            else
            {
                Console.WriteLine("Ivestas nevalidus email'as");
            }
        }

        private bool IsValidEmail(string email)
        {
            var regexPattern = "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$";
            return Regex.IsMatch(email, regexPattern);
        }

        public void PrintPets()
        {
            foreach (var pet in Pets)
            {
                Console.WriteLine($"{pet.AnimalType}, {pet.Name}, {pet.Age}");
            }
        }

        public void PrintPets(string animalType)
        {
            foreach (var pet in Pets)
            {
                if (pet.AnimalType == animalType)
                {
                    Console.WriteLine($"{pet.AnimalType}, {pet.Name}, {pet.Age}");
                }
            }
        }
    }
}
