// Представим, что 2 директора сдают отчеты одних сотрудников.

using Builder.Builders;
using Builder.Models;
using Builder.RaportDirectors;

List<Employee> employees = new()
{
    new Employee { Name = "Ivan", Salary = 3400 },
    new Employee { Name = "Boris", Salary = 4600 },
    new Employee { Name = "Jora", Salary = 6500 }
};

var builder = new EmployeeReportBuilder(employees);




#region variant 1
Console.WriteLine("=================== variant 1 ==================");

var director1 = new EmployeeReportDirector1(builder);
director1.Build();
var report = builder.GetReport();

Console.WriteLine(report);
#endregion


Thread.Sleep(2000);


#region variant 2
Console.WriteLine("=================== variant 2 ==================");

var director2 = new EmployeeRaportDirector2(builder);
director2.Build();
report = builder.GetReport();

Console.WriteLine(report);
#endregion