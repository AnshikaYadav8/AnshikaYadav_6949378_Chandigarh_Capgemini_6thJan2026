using System;
using System.Collections.Generic;
using System.Linq;

interface IProperty
{
    int Id { get; set; }
    string Address { get; set; }
    string Type { get; set; }
    decimal Price { get; set; }
}

interface IRealEstate
{
    void AddProperty(IProperty property);
    void RemoveProperty(int id);
    List<IProperty> GetPropertiesByType(string type);
    IProperty GetMostExpensiveProperty();
}

class Property : IProperty
{
    public int Id { get; set; }
    public string Address { get; set; }
    public string Type { get; set; }
    public decimal Price { get; set; }
}

class RealEstate : IRealEstate
{
    private List<IProperty> properties = new List<IProperty>();

    public void AddProperty(IProperty property)
    {
        properties.Add(property);
    }

    public void RemoveProperty(int id)
    {
        var p = properties.FirstOrDefault(x => x.Id == id);
        if (p != null)
            properties.Remove(p);
    }

    public List<IProperty> GetPropertiesByType(string type)
    {
        return properties.Where(p => p.Type == type).ToList();
    }

    public IProperty GetMostExpensiveProperty()
    {
        return properties.OrderByDescending(p => p.Price).FirstOrDefault();
    }
}

class Program
{
    static void Main()
    {
        IRealEstate realEstate = new RealEstate();

        realEstate.AddProperty(new Property { Id = 1, Address = "12 Main St", Type = "House", Price = 300000 });
        realEstate.AddProperty(new Property { Id = 2, Address = "45 Lake Rd", Type = "Apartment", Price = 200000 });
        realEstate.AddProperty(new Property { Id = 3, Address = "78 Hill Ave", Type = "House", Price = 450000 });

        Console.WriteLine("House Listings:");
        foreach (var p in realEstate.GetPropertiesByType("House"))
        {
            Console.WriteLine($"{p.Address} Price: {p.Price}");
        }

        var expensive = realEstate.GetMostExpensiveProperty();
        Console.WriteLine("Most Expensive Property: " + expensive.Address);
    }
}