
using EMS.Models;

namespace EMS.Clients;

public class EmployeesClient(HttpClient httpClient)
{

  

  public async Task<EmployeeSummary[]> GetEmployeesAsync()
     => await httpClient.GetFromJsonAsync<EmployeeSummary[]>("employees")?? [];

  //Add new Employee
  public async Task AddEmployeeAsync(Employee employee) 
    { 
      
      await httpClient.PostAsJsonAsync("employees", employee);
    }

  // Get Employee by Id
  public async Task<Employee> GetEmployeeAsync(int id) => 
    await httpClient.GetFromJsonAsync<Employee>($"employees/{id}") ?? throw new Exception("Aucun Employé Trouvé!!");

  public async Task UpdateEmployeeAsync(Employee employee) => 
    await httpClient.PutAsJsonAsync($"employees/{employee.Id}", employee);

  public async Task DeleteEmployeeAsync(int id) => await httpClient.DeleteAsync($"employees/{id}");
}

