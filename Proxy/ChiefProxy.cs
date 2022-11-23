namespace Proxy
{
    internal class ChiefProxy : IChief
    {
        private readonly Chief _chief;

        private IDictionary<int, string>? _statuses;

        public ChiefProxy(Chief chief)
        {
           _chief = chief;
        }

        public IEnumerable<Order> GetOrders()
        {
            return _chief.GetOrders();
        }

        public Dictionary<int, string> GetStatuses()
        {
            if (_statuses == null)
            {
                _statuses = _chief.GetStatuses();
            }

            return (Dictionary<int, string>)_statuses;
        }
    }
}
