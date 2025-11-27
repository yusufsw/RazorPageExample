using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageExample.Models;
using RazorPageExample.Repository;

namespace RazorPageExample.Pages.Employees;

public class CreateModel: PageModel
{
    private readonly IEmployeeRepository _employeeRepository;
    public CreateModel(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    [BindProperty]
    public Employee Employee { get; set; } = null!;

    public void OnGet(int id)
    {
        
    }

    public IActionResult OnPost(Employee employee)
    {
        _employeeRepository.Create(employee);
        return RedirectToPage("/Employees/Index");
    }
    // public IActionResult OnPost()
    // {
    //     Employee = _employeeRepository.Update(Employee);
    //     return RedirectToPage("/Employees/Index");
    // }
}