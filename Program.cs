using System;

namespace Inheritance
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // Test the DoSound method
            Dog dog = new Dog("Buddy", 30.0, 5, "Husky");
            dog.DoSound();

            // Test the Wolfman Talk method
            Wolfman wolfman = new Wolfman("Wolverine", 80.0, 35, true);
            wolfman.Talk();
        }
    }
}

// 13. we add The new attribute in the Bird class since it's common to all birds.
// 14. The new attribute should be added to the Animal class since it applies to all animals.



