using AbstractFactory.Cars;
using AbstractFactory.Engines;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    internal class JapaneseFactory : IFactory
    {
        public ICar CreateCar() => new JapaneseCar();
        public IEngine CreateEngine() => new JapaneseEngine();
    }
}
