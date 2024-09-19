using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // 1. Abstract class Animal
    public abstract class Animal
    {
        // 2. Properties common to all animals
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        // 4. Constructor for Animal class
        protected Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        // 3. Abstract method DoSound
        public abstract void DoSound();
    }

    // 5. Subclass Horse
    public class Horse : Animal
    {
        public double Speed { get; set; }

        public Horse(string name, double weight, int age, double speed) : base(name, weight, age)
        {
            Speed = speed;
        }

        // 7. Implementing DoSound for Horse
        public override void DoSound()
        {
            Console.WriteLine("The horse neighs.");
        }
    }

    // 5. Subclass Dog
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, double weight, int age, string breed) : base(name, weight, age)
        {
            Breed = breed;
        }

        // 7. Implementing DoSound for Dog
        public override void DoSound()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    // 5. Subclass Hedgehog
    public class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }

        public Hedgehog(string name, double weight, int age, int nrOfSpikes) : base(name, weight, age)
        {
            NrOfSpikes = nrOfSpikes;
        }

        // 7. Implementing DoSound for Hedgehog
        public override void DoSound()
        {
            Console.WriteLine("The hedgehog makes a soft sound.");
        }
    }

    // 5. Subclass Worm
    public class Worm : Animal
    {
        public bool IsPoisonous { get; set; }

        public Worm(string name, double weight, int age, bool isPoisonous) : base(name, weight, age)
        {
            IsPoisonous = isPoisonous;
        }

        // 7. Implementing DoSound for Worm
        public override void DoSound()
        {
            Console.WriteLine("The worm is silent.");
        }
    }

    // 5. Subclass Bird
    public class Bird : Animal
    {
        public double WingSpan { get; set; }

        public Bird(string name, double weight, int age, double wingSpan) : base(name, weight, age)
        {
            WingSpan = wingSpan;
        }

        // 7. Implementing DoSound for Bird
        public override void DoSound()
        {
            Console.WriteLine("The bird chirps.");
        }
    }

    // 5. Subclass Wolf
    public class Wolf : Animal
    {
        public bool IsAlpha { get; set; }

        public Wolf(string name, double weight, int age, bool isAlpha) : base(name, weight, age)
        {
            IsAlpha = isAlpha;
        }

        // 7. Implementing DoSound for Wolf
        public override void DoSound()
        {
            Console.WriteLine("The wolf howls.");
        }
    }

    // 8. Subclass Pelican inheriting from Bird
    public class Pelican : Bird
    {
        public double BeakSize { get; set; }

        public Pelican(string name, double weight, int age, double wingSpan, double beakSize)
            : base(name, weight, age, wingSpan)
        {
            BeakSize = beakSize;
        }
    }

    // 8. Subclass Flamingo inheriting from Bird
    public class Flamingo : Bird
    {
        public string Color { get; set; }

        public Flamingo(string name, double weight, int age, double wingSpan, string color)
            : base(name, weight, age, wingSpan)
        {
            Color = color;
        }
    }

    // 8. Subclass Swan inheriting from Bird
    public class Swan : Bird
    {
        public bool IsAggressive { get; set; }

        public Swan(string name, double weight, int age, double wingSpan, bool isAggressive)
            : base(name, weight, age, wingSpan)
        {
            IsAggressive = isAggressive;
        }
    }

    // 10. IPerson interface with Talk method
    public interface IPerson
    {
        void Talk();
    }

    // 11. Wolfman class inheriting from Wolf and implementing IPerson
    public class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age, bool isAlpha)
            : base(name, weight, age, isAlpha) { }

         // 12. Implementing Talk method
        public void Talk()
        {
            Console.WriteLine("The Wolfman speaks in a deep voice.");
        }
    }

}
