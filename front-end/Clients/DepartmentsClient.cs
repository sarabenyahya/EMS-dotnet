using EMS.models;
namespace EMS.Clients;

public class DepartmentsClient(HttpClient httpClient)
{
  public async Task<Department[]> GetDepartmentsAsync()
    => await httpClient.GetFromJsonAsync<Department[]>("departments")?? [];
}

