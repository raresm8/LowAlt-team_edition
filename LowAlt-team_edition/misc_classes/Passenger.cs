namespace LowAlt_team_edition.misc_classes;

public class Passenger
{
    /// <summary>
    /// cnp of the passenger
    /// </summary>
    public string Cnp { get; init; }

    /// <summary>
    /// list of reservations in the past
    /// </summary>
    public List<Reservation> PriorReservations { get; init; }

    /// <summary>
    /// username of the passenger
    /// </summary>
    public string Username { get; init; }

    /// <summary>
    /// indicates if the passenger is admin
    /// </summary>
    public bool IsAdmin { get; init; }

    /// <summary>
    /// indicates if the pasaenger is logged in
    /// </summary>
    public bool IsLoggedIn => !string.IsNullOrWhiteSpace(Username);
    

    public Passenger()
    {
        Cnp = "";
        PriorReservations = new List<Reservation>
        {
            new Reservation(this, "RO101", 1),
            new Reservation(this, "RO102", 5),
            new Reservation(this, "EN007", 1)
        };
    }
    
    public Passenger(string cnp, string username, List<Reservation> priorReservations, bool isAdmin)
    {
        Cnp = cnp;
        Username = username;
        PriorReservations = priorReservations;
        IsAdmin = isAdmin;
    }
    
    public override string ToString() => $"Cnp: {Cnp}, Username: {Username}";
}