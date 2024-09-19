using System;

namespace Inheritance
{

    class Program
    {
        static void Main(string[] args)
        {
            // 3. Create a list of Animals
            List<Animal> animals = new List<Animal>
            {
                new Dog("Buddy", 30.0, 5, "Labrador"),
                new Horse("Spirit", 500, 7, 60),
                new Wolfman("Lupin", 80.0, 35, true)
            };

            // 5. Print all animals in the list with a foreach loop
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Stats()); // 11. Print Stats for each animal
                animal.DoSound(); // 6. Call DoSound for each animal

                // 7. Check if the animal is of type IPerson and cast to IPerson to call Talk()
                if (animal is IPerson person)
                {
                    person.Talk();
                }
            }

            // 8. Create a list for Dogs
            List<Dog> dogs = new List<Dog>
            {
                new Dog("Max", 25, 4, "Bulldog"),
                new Dog("Rex", 35, 6, "German Shepherd")
            };

            // 11. Print Stats for each Dog in the dogs list
            foreach (Dog dog in dogs)
            {
                Console.WriteLine(dog.Stats());
            }

            // 18. Print Dog-specific method using a foreach loop on Animals
            foreach (Animal animal in animals)
            {
                if (animal is Dog dog)
                {
                    Console.WriteLine(dog.DogMethod());
                }
            }
        }
    }
}

// 13. we add The new attribute in the Bird class since it's common to all birds.
// 14. The new attribute should be added to the Animal class since it applies to all animals.



