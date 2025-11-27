using RazorPageExample.Models;

namespace RazorPageExample.Repository;

public class MockEmployeeRepository : IEmployeeRepository
{
    private List<Employee> _employeeList;
    public MockEmployeeRepository()
    {
        _employeeList = new List<Employee>()
        {
          new Employee {Id=1, Name="Yusuf", Email="info@yusuf.com", Photo = "1.jpeg", Department="Software" },  
          new Employee {Id=2, Name="Efe", Email="info@Efe.com", Photo = "2.jpeg", Department="Health" },  
          new Employee {Id=3, Name="Eyup", Email="info@Eyup.com", Photo = "3.jpeg", Department="Basketball" },  
          new Employee {Id=4, Name="Halil", Email="info@Halil.com", Photo = "4.jpeg", Department="Education" },  
          new Employee {Id=5, Name="Bahriye", Email="info@Bahriye.com", Photo = "5.jpeg", Department="Chemistry" },
          new Employee {Id=6, Name="Bahriye", Email="info@Bahriye.com", Photo = "5.jpeg", Department="Chemistry" }
        };
    }

    public Employee Create(Employee entity)//it will complete
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Employee> GetAll()
    {
        return _employeeList;
    }

    public Employee GetById(int id)
    {
        return _employeeList.FirstOrDefault(i=>i.Id == id);
    }

    public Employee Update(Employee entity)
    {
        Employee employee = _employeeList.FirstOrDefault(i => i.Id == entity.Id);

        if(employee != null)
        {
            employee.Name = entity.Name;
            employee.Email = entity.Email;
            employee.Photo = entity.Photo;
            employee.Department = entity.Department;
        }
        return employee;
    }
}