﻿using DesignPattern.Factory.Factory.Models;

namespace DesignPattern.Factory.Factory;

public class NYPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        Pizza pizza = null;
        if (type == "cheese")
        {
            pizza = new NyStyleCheesePizza();
        }
        else if (type == "pepperoni")
        {
            pizza = new NYStylePepperoniPizza();
        }
        else if (type == "clam")
        {
            pizza = new NYStyleClamPizza();
        }
        else if (type == "veggie")
        {
            pizza = new NYStyleVeggiePizza();
        }

        return pizza;
    }
}