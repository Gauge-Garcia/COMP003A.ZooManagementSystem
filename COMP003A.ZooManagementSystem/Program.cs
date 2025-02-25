// Author: Gauge Garcia
// Course: COMP-003A
// Faculty: Johnathan Cruz
// Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#

namespace COMP003A.ZooManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            int choice = 0;

            while (choice !=5)
            {
                Console.WriteLine("\n Welcome to the Zoo Management System!\n Please choose what you would like to execute:");
                Console.WriteLine(" 1. Add a Lion.");
                Console.WriteLine(" 2. Add a Parrot.");
                Console.WriteLine(" 3. Display ALL Animals.");
                Console.WriteLine(" 4. Describe an Animal.");
                Console.WriteLine(" 5. Exit.");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                    {
                            AddAnimal(animals, "Lion");
                            break;
                    }

                    case 2:
                    {
                            AddAnimal(animals, "Parrot");
                            break;
                    }

                    case 3:
                    {
                            DisplayAnimals(animals);
                            break;
                    }

                    case 4:
                    {
                            DescribeAnimal();
                            break;
                    }
                    case 5:
                    {
                            choice = 5;
                            Console.WriteLine("GoodBye!!!");
                            break;
                    }

                    default:
                    {
                            Console.WriteLine("Invalid input, Please Try Again.");
                            break;
                    }
                }
            }
        }


        static void AddAnimal(List<Animal> animals, string animalType)
        {
            try
            {
                Console.Write($"Enter the name of the {animalType.ToLower()}: ");
                string name = Console.ReadLine();

                Console.Write($"Enter the species of the {animalType.ToLower()}: ");
                string species = Console.ReadLine();

                if (animalType == "Lion")
                {
                    animals.Add(new Lion(name, species));
                }
                else if (animalType == "Parrot")
                {
                    animals.Add(new Parrot(name, species));
                }

                Console.WriteLine($"{animalType} added successfully!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void DisplayAnimals(List<Animal> animals)
        {
            Console.WriteLine("\nDisplaying all animals:");
            foreach (Animal animal in animals)
            {
                animal.MakeSound();
                Console.WriteLine($"({animal.Name}, {animal.Species})");
            }
        }

        static void DescribeAnimal()
        {
            Console.WriteLine("\nDescribe Animal (choose an option):");
            Console.WriteLine("1. DescribeAnimal (name only)");
            Console.WriteLine("2. DescribeAnimal (name and species)");
            Console.WriteLine("3. DescribeAnimal (name, species, and age)");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the animal name: ");
                    string name = Console.ReadLine();
                    ZooUtility.DescribeAnimal(name);
                    break;
                case "2":
                    Console.Write("Enter the animal name: ");
                    string namec2 = Console.ReadLine();
                    Console.Write("Enter the animal species: ");
                    string speciesc2 = Console.ReadLine();
                    ZooUtility.DescribeAnimal(namec2, speciesc2);
                    break;
                case "3":
                    Console.Write("Enter the animal name: ");
                    string namec3 = Console.ReadLine();
                    Console.Write("Enter the animal species: ");
                    string speciesc3 = Console.ReadLine();
                    Console.Write("Enter the animal age: ");
                    int age = int.Parse(Console.ReadLine());
                    ZooUtility.DescribeAnimal(namec3, speciesc3, age);
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}
 

