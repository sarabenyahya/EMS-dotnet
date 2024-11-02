namespace EMS.Services;

using EMS.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class EmployeeService
{
    private readonly FirebaseClient _firebaseClient;
    

    public EmployeeService()
    {
        // Remplacez ceci par l'URL de votre base de données Firebase
        _firebaseClient = new FirebaseClient("https://data-visualization-b5581-default-rtdb.firebaseio.com/");
    }
/**
    public async Task<List<Employee>> GetEmployeesAsync()
    {
        var employees = await _firebaseClient
            .Child("ems")   
            .OnceAsync<Employee>();

        return [.. employees.Select(item => new Employee
        {
            Id = item.Key,
            Name = item.Object.Name,
            Email = item.Object.Email,
            HireDate = item.Object.HireDate,
            AddedDate = item.Object.AddedDate,
            ModifiedDate = item.Object.ModifiedDate,
            Department = item.Object.Department,
            Salary = item.Object.Salary,
            Status = item.Object.Status
        }).OrderBy(e => e.AddedDate)];
    }


  
    public async Task<Employee> GetEmployeeAsync(string Id)
    {
        var employee = await _firebaseClient
            .Child("ems")
            .Child(Id)
            .OnceSingleAsync<Employee>(); // Retrieve a single FirebaseObject instead of a collection
        employee.Id = Id;
        return employee  ?? throw new Exception("Employee not found") ;
    }

    public async Task AddEmployeeAsync(Employee employee)
    {
        await _firebaseClient
            .Child("ems")
            .PostAsync(employee);
    }

    public async Task UpdateEmployeeAsync(Employee employee)
    {
        await _firebaseClient
            .Child("ems")
            .Child(employee.Id)
            .PutAsync(employee);
            
    }


    public async Task DeleteEmployeeAsync(string Id)
    {
        await _firebaseClient
            .Child("ems")
            .Child(Id)
            .DeleteAsync();
    }


    public async Task SubscribeToEmployeeChanges(Action<Dictionary<string, Employee>> callback)
    {
        var observable = _firebaseClient.Child("ems").AsObservable<Dictionary<string, Employee>>();
        
        observable.Subscribe(d =>
        {
            callback(d.Object);
        });
    }
    */
}

