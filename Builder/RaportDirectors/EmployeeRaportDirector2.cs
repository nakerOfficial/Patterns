using Builder.Builders;

namespace Builder.RaportDirectors
{
    internal class EmployeeRaportDirector2
    {
        private readonly IEmployeeReportBuilder _builder;

        public EmployeeRaportDirector2(IEmployeeReportBuilder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            _builder
                .BuildHeader()
                .BuildContent()
                .BuildFooter()
                .BuildSign("Director 2");
        }
    }
}
