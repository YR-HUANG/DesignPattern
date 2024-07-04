namespace DesignPattern.Factory.SimpleFactory;

public class SimplePizzaFactory
{
    public Pizza CreatePizza(string type)
    {
        Pizza pizza = null;
        if (type == "cheese")
        {
            pizza = new CheesePizza();
        }
        else if (type == "pepperoni")
        {
            pizza = new PepperoniPizza();
        }
        else if (type == "clam")
        {
            pizza = new ClamPizza();
        }
        else if (type == "veggie")
        {
            pizza = new VeggiePizza();
        }

        return pizza;
    } 
}

public class ClamPizza : Pizza
{
}

public class VeggiePizza : Pizza
{
}

internal class PepperoniPizza : Pizza
{
}

internal class CheesePizza : Pizza
{
}

public class Pizza
{
    public void Prepare()
    {
        Console.WriteLine("Preparing pizza");
    }

    public void Bake()
    {
        Console.WriteLine("Baking pizza");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting pizza");
    }

    public void Box()
    {
        Console.WriteLine("Boxing pizza");
    }
}