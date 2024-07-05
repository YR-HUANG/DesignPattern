using DesignPattern.Factory.Factory;

namespace DesignPattern.Factory.FactoryAndBuider;

public class ComputerProvider
{
    public ComputerBuilder GetComputer(string type)
    {
        ComputerBuilder computerBuilder = null;
        if (type == "Acer")
        {
            computerBuilder = new Acer();
        }
        else if (type == "Asus")
        {
            computerBuilder = new Asus();
        }
        else if (type == "Msi")
        {
            computerBuilder = new Msi();
        }

        return computerBuilder;
    }
}