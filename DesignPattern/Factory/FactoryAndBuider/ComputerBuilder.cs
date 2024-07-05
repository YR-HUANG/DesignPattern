using DesignPattern.Factory.Factory;

namespace DesignPattern.Factory.FactoryAndBuider;

public class ComputerBuilder
{
    private Computer _computer = new Computer();

    public ComputerBuilder AddCpu(string cpu)
    {
        _computer.CPU = cpu;
        return this;
    }
    public ComputerBuilder AddRam(string ram)
    {
        _computer.RAM = ram;
        return this;
    }
    public ComputerBuilder AddHardDisk(string hardDisk)
    {
        _computer.HardDisk = hardDisk;
        return this;
    }
    public Computer Build()
    {
        return _computer;
    }
}