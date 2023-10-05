namespace ClassMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new Human("Frank", "Stevenson", 35);
            var friend = new Human("Andrius", "Andraitis", 23);
            var lecturer = new Human("Vilmantas", "Naviera", 25);

            Console.WriteLine(employee.GetFullName());
            Console.WriteLine(friend.GetFullName());
            Console.WriteLine(lecturer.GetFullName());

            employee.UpdateEmail("newFrankgmail.com");
            friend.UpdateEmail("newFriend@gmail.com");
            lecturer.UpdateEmail("newVilmantas@gmail.com");

            Console.WriteLine(employee.Email);
            Console.WriteLine(friend.Email);
            Console.WriteLine(lecturer.Email);


            var person = new Human("Albertas", "Majauskas", 35);
            person.Pets.Add(new Pet("Suo", "Reksas", 5, "woof"));
            person.Pets.Add(new Pet("Suo", "Lese", 7, "woof"));
            person.Pets.Add(new Pet("Papuga", "Zibe", 15, "chirp"));
            person.Pets.Add(new Pet("Kate", "Rainis", 3, "meow"));

            person.PrintPets();
            Console.WriteLine("Zemiau isspaudinsime gyvunus pagal tipo filtra");
            person.PrintPets("Suo");
            Console.WriteLine("Zemiau isspaudinsime gyvunus pagal amziaus filtra");
            person.PrintPets(6);
            Console.WriteLine("Zemiau isspaudinsime gyvunus pagal tipo ir amziaus filtra");
            person.PrintPets("Suo", 6);

            //foreach(var pet in person.Pets)
            //{
            //    pet.MakeSound();
            //}
        }
    }
}