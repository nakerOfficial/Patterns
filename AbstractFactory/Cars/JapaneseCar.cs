using AbstractFactory.Interfaces;

namespace AbstractFactory.Cars
{
    internal class JapaneseCar : ICar
    {
        public void ReleaseCar(IEngine engine)
        {
            Console.WriteLine("Created Japanese car with:");
            engine.ReleaseEngine();
        }
    }
}
