namespace DesignPattern.Factory.SimpleFactory;

public class PizzaStore
{
    private SimplePizzaFactory _factory;

    public PizzaStore(SimplePizzaFactory factory)
    {
        _factory = factory;
    } 
    
    public Pizza OrderPizza(string type)
    {
        var pizza = new Pizza();
        pizza = _factory.CreatePizza(type);
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        
        return pizza;
    }
}