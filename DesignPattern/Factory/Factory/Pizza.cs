namespace DesignPattern.Factory.Factory;

public abstract class Pizza
{
    protected string Name;
    protected string Dough;
    protected string Sauce;
    protected List<string> Toppings = new List<string>();
    
    public void Prepare()
    {
        Console.WriteLine("Preparing " + Name);
        Console.WriteLine("Tossing dough...");
        Console.WriteLine("Adding sauce...");
        Console.WriteLine("Adding toppings...");
        foreach (var topping in Toppings)
        {
            Console.WriteLine(" " + topping);
        }
        
    }

    public void Bake()
    {
        Console.WriteLine("Baking pizza");
    }

    public void Box()
    {
        Console.WriteLine("Boxing pizza");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting pizza");
    }
    
    public string GetName()
    {
        return Name;
    }
}