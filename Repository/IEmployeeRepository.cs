using RazorPageExample.Models;

namespace RazorPageExample.Repository;

public interface IEmployeeRepository
{
    IEnumerable<Employee> GetAll(); 
}