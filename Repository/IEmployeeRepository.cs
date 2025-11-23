using RazorPageExample.Models;

namespace RazorPageExample.Reposiotry;

public interface IEmployeeRepository
{
    IEnumerable<Employee> GetAll(); 
}