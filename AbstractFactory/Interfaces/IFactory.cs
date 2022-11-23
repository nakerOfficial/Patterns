namespace AbstractFactory.Interfaces
{
    internal interface IFactory
    {
        IEngine CreateEngine();
        ICar CreateCar();
    }
}
