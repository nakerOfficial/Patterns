namespace Proxy
{
    internal class Chief : IChief
    {
        public Dictionary<int, string> GetStatuses()
        {
            Dictionary<int, string> statuses = new ();

            statuses.Add(1, "Ready");
            statuses.Add(2, "Not ready");
            statuses.Add(3, "Preparing");

            Thread.Sleep(2000);

            return statuses;
        }

        public IEnumerable<Order> GetOrders()
        {
            List<Order> orders = new();

            orders.Add(new Order() { Name = "Burger", StatusId = RandomizeStatus() });
            orders.Add(new Order() { Name = "Pasta", StatusId = RandomizeStatus() });
            orders.Add(new Order() { Name = "Omlet", StatusId = RandomizeStatus() });

            return orders;
        }

        private static int RandomizeStatus() => new Random().Next(1, 4); 
    }
}
