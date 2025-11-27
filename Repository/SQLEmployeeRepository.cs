using RazorPageExample.Models;

namespace RazorPageExample.Repository;

public class SQLEmployeeRepository : IEmployeeRepository
{
    private readonly DataContext _context;
    public SQLEmployeeRepository(DataContext context)
    {
        _context = context;
    }

    public Employee Create(Employee entity)
    {
        _context.Employees.Add(entity);
        _context.SaveChanges();
        return entity;
    }

    public IEnumerable<Employee> GetAll()
    {
        return _context.Employees.ToList();
    }

    public Employee GetById(int id)
    {
        return _context.Employees.FirstOrDefault(i => i.Id == id);
    }

    public Employee Update(Employee entity)
    {
        var entityToUpdate = _context.Employees.FirstOrDefault(i => i.Id == entity.Id);

        if(entityToUpdate != null)
        {
            entityToUpdate.Name = entity.Name;
            entityToUpdate.Email = entity.Email;
            entityToUpdate.Photo = entity.Photo;
            entityToUpdate.Department = entity.Department;
            _context.SaveChanges();
        }
        return entityToUpdate;
    }
}