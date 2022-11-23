using Builder.Models;
using Builder.RaportDirectors;

namespace Builder.Builders
{
    internal class EmployeeReportBuilder : IEmployeeReportBuilder
    {
        private EmployeeReport _employeeReport;
        private readonly IEnumerable<Employee> _employees;

        public EmployeeReportBuilder(IEnumerable<Employee> employees)
        {
            _employees = employees;
            _employeeReport = new();
        }

        public IEmployeeReportBuilder BuildHeader()
        {
            _employeeReport.Header = $"EMPLOYEES REPORT ON DATE: {DateTime.Now}\n";
            _employeeReport.Header += "\n ----------------------------------------\n";

            return this;
        }

        public IEmployeeReportBuilder BuildBody()
        {
            _employeeReport.Body = string.Join(
                Environment.NewLine,
                _employees.Select(e => $"Name: {e.Name}\t\t Salary: {e.Salary}")
            );

            return this;
        }

        public IEmployeeReportBuilder BuildContent()
        {
            _employeeReport.Body = "It's IMPORTANT CONTENT!";

            return this;
        }

        public IEmployeeReportBuilder BuildFooter()
        {
            _employeeReport.Footer = "\n ----------------------------------------\n";
            _employeeReport.Footer += $"\nTOTAL EMPLOYEES: {_employees.Count()}"
                + $"\tTOTAL SALARY: {_employees.Sum(e => e.Salary)}$";

            return this;
        }

        public IEmployeeReportBuilder BuildSign(string sign)
        {
            _employeeReport.Sign = $"\n\nSIGN: {sign}";

            return this;
        }

        public EmployeeReport GetReport()
        {
            EmployeeReport employeeReport = _employeeReport;

            _employeeReport = new();

            return employeeReport;
        }
    }
}
