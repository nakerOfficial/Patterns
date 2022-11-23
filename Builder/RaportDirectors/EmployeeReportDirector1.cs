using Builder.Builders;

namespace Builder.RaportDirectors
{
    internal class EmployeeReportDirector1
    {
        private readonly IEmployeeReportBuilder _builder;

        public EmployeeReportDirector1(IEmployeeReportBuilder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            _builder
                .BuildHeader()
                .BuildBody()
                .BuildFooter()
                .BuildSign("Director 1");
        }
    }
}
