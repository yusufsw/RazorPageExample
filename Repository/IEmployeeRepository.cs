using RazorPageExample.Models;

namespace RazorPageExample.Repository;

public interface IEmployeeRepository
{
    IEnumerable<Employee> GetAll(); 
    Employee GetById(int id);

    Employee Update(Employee entity);

    void Create(Employee entity);

}