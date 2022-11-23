using System.Text;

namespace Builder.RaportDirectors
{
    internal class EmployeeReport
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public string Footer { get; set; }
        public string Sign { get; set; }

        public override string ToString() =>
            new StringBuilder()
            .Append(Header)
            .Append(Body)
            .Append(Footer)
            .Append(Sign)
            .ToString();
    }
}
