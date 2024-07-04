// See https://aka.ms/new-console-template for more information

using DesignPattern.Factory.Factory;
using DesignPattern.Factory.Factory.Models;
using DesignPattern.Factory.SimpleFactory;



//Simple Factory
// var pizzaStore = new PizzaStore(new SimplePizzaFactory());
// var pizza = pizzaStore.OrderPizza("cheese");
//

var nyPizzaStore = new NYPizzaStore();
var orderPizza = nyPizzaStore.OrderPizza("cheese");
Console.WriteLine("NY Pizza: " + orderPizza.GetName());

var chiacoStylePizzaStore = new ChiacoStylePizzaStore();
var pizza = chiacoStylePizzaStore.OrderPizza("cheese");
Console.WriteLine("chiaco Pizza: " + pizza.GetName());