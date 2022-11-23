using AbstractFactory.Interfaces;

namespace AbstractFactory.Cars
{
    internal class RussianCar : ICar
    {
        public void ReleaseCar(IEngine engine)
        {
            Console.WriteLine("Created Russian car witn:");
            engine.ReleaseEngine();
        }
    }
}
