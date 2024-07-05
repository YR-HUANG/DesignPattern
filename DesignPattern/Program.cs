// See https://aka.ms/new-console-template for more information

using DesignPattern.Factory.Factory;
using DesignPattern.Factory.Factory.Models;
using DesignPattern.Factory.FactoryAndBuider;
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


//Builder feat. Factory
var computer = new ComputerProvider().GetComputer("Acer");
computer.AddRam("16GB");
computer.AddCpu("i7");
computer.AddHardDisk("1TB");
computer.Build();