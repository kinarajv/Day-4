﻿namespace AnimalProgram;
public interface IAnimal
{
    void Eat();
}

public interface IDog : IAnimal
{
    void Bark();
    void Jump();
}
public abstract class Dog : IDog
{
    public void Bark()
    {
        Console.WriteLine("Bark");
    }
    public virtual void Eat()
    {
        Console.WriteLine("Dog Eat");
    }
    public abstract void Jump();
}

public class Poodle : Dog {
    public override void Jump() {
        Console.WriteLine("Poodle Jump");
    }
    public new static void Eat() {
        Console.WriteLine("Poodle Eat");
    }
}

static class Program {
    static void Main() {
        Poodle poodle = new();
        Poodle.Eat();
        poodle.Bark();
        poodle.Jump();
    }
}