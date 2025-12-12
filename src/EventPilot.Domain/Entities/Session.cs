namespace EventPilot.Domain.Entities;

public class Session
{
    public long Id { get; set; }
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Location { get; set; } = null!;
    public int? Capacity { get; set; }
    public string Speaker { get; set; } = null!;
    
    public long EventId { get; set; }
    public Event Event { get; set; } = null!;
    
    public ICollection<SessionRegistration> SessionRegistrations { get; set; } = new List<SessionRegistration>();
    public ICollection<Certificate> Certificates { get; set; } = new List<Certificate>();
    public ICollection<CheckIn> CheckIns { get; set; } = new List<CheckIn>();
}