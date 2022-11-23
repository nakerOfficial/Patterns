using Builder.RaportDirectors;

namespace Builder.Builders
{
    internal interface IEmployeeReportBuilder
    {
        IEmployeeReportBuilder BuildHeader();
        IEmployeeReportBuilder BuildBody();
        IEmployeeReportBuilder BuildContent();
        IEmployeeReportBuilder BuildFooter();
        IEmployeeReportBuilder BuildSign(string sign);
        EmployeeReport GetReport();
    }
}
