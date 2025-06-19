interface Animal
{
    void MakeSound();
}

class Dog : Animal
{
    public void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

class Cat : Animal
{
    public void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

class AnimalFactory
{
    public static Animal CreateAnimal(string animalType)
    {
        if (animalType.Equals("dog", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Dog Object created.");
            return new Dog();
        }
        else if (animalType.Equals("cat", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Cat Object created.");
            return new Cat();
        }
        else
        {
            Console.WriteLine("Invalid animal type.");
            return null;
        }
    }
}

class exercise2
{
    static void Main(string[] args)
    {
        // Requesting Dog
        Console.WriteLine("Requesting Dog:");
        Animal a1 = AnimalFactory.CreateAnimal("dog");
        a1?.MakeSound();

        // Requesting Cat
        Console.WriteLine("Requesting Cat:");
        Animal a2 = AnimalFactory.CreateAnimal("cat");
        a2?.MakeSound();

        // Requesting Horse (invalid)
        Console.WriteLine("Requesting Horse:");
        Animal a3 = AnimalFactory.CreateAnimal("horse");
        a3?.MakeSound(); // null check using ? operator
    }
}