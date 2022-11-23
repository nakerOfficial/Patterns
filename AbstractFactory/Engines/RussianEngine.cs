using AbstractFactory.Interfaces;

namespace AbstractFactory.Engines
{
    internal class RussianEngine : IEngine
    {
        public void ReleaseEngine() => Console.WriteLine("Russian engine");
    }
}
