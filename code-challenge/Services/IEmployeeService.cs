using challenge.Models;
using System;

namespace challenge.Services
{
    public interface IEmployeeService
    {
        Employee GetById(String id);
        ReportingStructure GetReportStructure(String id);
        Compensation GetEmployeeCompensation(String id);
        Compensation AddEmployeeCompensation(CompensationPost employee);
        Employee Create(Employee employee);
        Employee Replace(Employee originalEmployee, Employee newEmployee);
    }
}