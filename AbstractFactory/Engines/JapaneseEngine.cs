using AbstractFactory.Interfaces;

namespace AbstractFactory.Engines
{
    internal class JapaneseEngine : IEngine
    {
        public void ReleaseEngine() => Console.WriteLine("Japanese engine");
    }
}
