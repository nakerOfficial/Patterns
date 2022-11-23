using AbstractFactory.Factories;
using AbstractFactory.Interfaces;

Console.WriteLine("------------------- Car Factory List -------------------");

Console.WriteLine("------------------- 1 -------------------");

IFactory japaneseFactory = new JapaneseFactory();
IEngine japaneseEngine = japaneseFactory.CreateEngine();
ICar japaneseCar = japaneseFactory.CreateCar();

japaneseCar.ReleaseCar(japaneseEngine);

Console.WriteLine("------------------- 2 -------------------");
IFactory russianFactory = new RussianFactory();
IEngine russianEngine = russianFactory.CreateEngine();
ICar russianCar = russianFactory.CreateCar();

russianCar.ReleaseCar(russianEngine);