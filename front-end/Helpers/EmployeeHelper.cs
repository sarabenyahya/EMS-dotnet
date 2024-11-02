namespace EMS.Helpers;

public static class EmployeeHelper
{
    public static string  GetStatusFromApi(string apiStatus)
    {
        return apiStatus switch
        {
            "Intern" => "Stagiaire",
            "Permanent" => "Titulaire",
            "Retired" => "Retraité(e)",
            "Fired" => "Viré(e)",
            _ => "Stagiaire"
        };
    }

    public static string  GetClass(string department){
        return department switch
        {
            "Ventes" => "bg-primary",
            "Marketing" => "bg-success",
            "Resources Humaines" => "bg-danger",
            "Finance" => "bg-warning",
            _ => "bg-dark"
        };
    }
}


public class Notification 
{   
    public required string Message { get; set; }
    public required string Icon { get; set; }
}
