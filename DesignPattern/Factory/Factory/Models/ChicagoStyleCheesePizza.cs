namespace DesignPattern.Factory.Factory.Models;

public class ChicagoStyleCheesePizza : Pizza
{
    public ChicagoStyleCheesePizza()
    {
        Name = "Chicago Style Deep Dish Cheese Pizza";
        Dough = "Extra Thick Crust Dough";
        Sauce = "Plum Tomato Sauce";
        Toppings.Add("Shredded Mozzarella Cheese");
    }
    
    public void Cut()
    {
        Console.WriteLine("Cutting the pizza into square slices");
    }
}

public class ChiacoStylePizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        Pizza pizza = null;
        if (type == "cheese")
        {
            pizza = new ChicagoStyleCheesePizza();
        }
        else if (type == "pepperoni")
        {
            pizza = new ChiacoStylePepperoniPizza();
        }
        else if (type == "clam")
        {
            pizza = new ChiacoClamPizza();
        }
        else if (type == "veggie")
        {
            pizza = new ChiacoStyleVeggiePizza();
        }

        return pizza;
    }
}