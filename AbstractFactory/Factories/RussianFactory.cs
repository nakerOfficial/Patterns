using AbstractFactory.Cars;
using AbstractFactory.Engines;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    internal class RussianFactory : IFactory
    {
        public ICar CreateCar() => new RussianCar();
        public IEngine CreateEngine() => new RussianEngine();
    }
}
