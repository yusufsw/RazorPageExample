using RazorPageExample.Models;

namespace RazorPageExample.Reposiotry;

public class MockEmployeeRepository : IEmployeeRepository
{
    private List<Employee> _employeeList;
    public MockEmployeeRepository()
    {
        _employeeList = new List<Employee>()
        {
          new Employee {Id=1, Name="Yusuf", Email="info@yusuf.com", Photo = "1.jpg", Deparment="Software" },  
          new Employee {Id=2, Name="Efe", Email="info@Efe.com", Photo = "2.jpg", Deparment="Health" },  
          new Employee {Id=3, Name="Eyup", Email="info@Eyup.com", Photo = "3.jpg", Deparment="Basketball" },  
          new Employee {Id=4, Name="Halil", Email="info@Halil.com", Photo = "4.jpg", Deparment="Education" },  
          new Employee {Id=5, Name="Bahriye", Email="info@Bahriye.com", Photo = "5.jpg", Deparment="Chemistry" }
        };
    }

    public IEnumerable<Employee> GetAll()
    {
        return _employeeList;
    }
}