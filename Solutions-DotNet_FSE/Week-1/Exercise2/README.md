# Factory Pattern

## Overview

This assignment demonstrates the **Factory Design Pattern** in C# using a simple console application. The Factory pattern provides a way to **create objects without specifying the exact class** of object that will be created.

This is particularly useful in scenarios such as:
- Creating objects based on input or configuration at runtime.
- Encapsulating object creation logic in one place.
- Promoting loose coupling and scalability in code by relying on common interfaces.
---
### Animal Interface

```csharp
interface Animal
{
    void MakeSound();
}
```

### Concrete Classes

```csharp
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
```

### Factory Class

```csharp
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
```

### Main Class
```csharp
class Program
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
```
---
## How to Run
### Prerequisites
- .NET SDK installed
- VS Code or any C# IDE
- Any terminal or command prompt

### Compilation
```bash
dotnet build
```
### Execution
```bash
dotnet run
```
---
## Output
```bash
Requesting Dog:
Dog Object created.
Woof!
Requesting Cat:
Cat Object created.
Meow!
Requesting Horse:
Invalid animal type.
```