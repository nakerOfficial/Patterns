namespace Proxy
{
    internal interface IChief
    {
        public Dictionary<int, string> GetStatuses();
        public IEnumerable<Order> GetOrders();
    }
}
