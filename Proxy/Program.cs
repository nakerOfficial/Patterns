// Представим, что есть приложение, которое показывает
// заказы и их текущий статус, но статусы отдаются долго


using Proxy;


#region without Proxi (Pattern Design)
//IChief chief = new Chief();
#endregion


#region with Proxi (Pattern Design)
IChief chief = new ChiefProxy(new Chief());
#endregion


while (true)
{
    Thread.Sleep(2000);


    Console.Clear();
    Console.WriteLine("Welcome to Cooker");
    Console.WriteLine("========== Orders ==========");


    chief.GetOrders().ToList().ForEach(order =>
    {
        Console.Write($"{order.Name}\t\t");

        string status = chief.GetStatuses().First(s => s.Key == order.StatusId).Value;
        Console.Write($"{status}\n");
    });
}