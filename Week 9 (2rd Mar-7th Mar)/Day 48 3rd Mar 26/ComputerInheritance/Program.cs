using System;

abstract class Computer
{
    protected string brand;
    protected int ram;

    public Computer(string brand, int ram)
    {
        this.brand = brand;
        this.ram = ram;
    }

    public abstract string GetDetails();
}

class Laptop : Computer
{
    private double weight;

    public Laptop(string brand, int ram, double weight)
        : base(brand, ram)
    {
        this.weight = weight;
    }

    public override string GetDetails()
    {
        return $"Laptop Brand:{brand}, RAM:{ram}GB, Weight:{weight}kg";
    }
}

class Desktop : Computer
{
    private string caseType;

    public Desktop(string brand, int ram, string caseType)
        : base(brand, ram)
    {
        this.caseType = caseType;
    }

    public override string GetDetails()
    {
        return $"Desktop Brand:{brand}, RAM:{ram}GB, Case:{caseType}";
    }
}

class Program
{
    static void Main()
    {
        Computer c1 = new Laptop("Dell", 16, 2.1);
        Computer c2 = new Desktop("HP", 32, "Tower");

        Console.WriteLine(c1.GetDetails());
        Console.WriteLine(c2.GetDetails());
    }
}