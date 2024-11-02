namespace EMS.models;

public enum Status
{
    Active,
    Retired,
    Fired,
    Intern

    
}

public static class StatusExtensions
    {
        public static string GetStatus(this Status status)
        {
            switch (status)
            {
                case Status.Active:
                    return "Actif(ve)";
                case Status.Retired:
                    return "Retraité(e)";
                case Status.Fired:
                    return "Viré(e)";
                case Status.Intern:
                    return "Stagiaire";
                default:
                    throw new ArgumentOutOfRangeException(nameof(status), status, null);
            }
        }
    }
