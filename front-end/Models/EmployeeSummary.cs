namespace EMS;

public class EmployeeSummary
{
  public int Id { get; set; }
  public required string Name { get; set; }
  public required string Email { get; set; }
  public required string Department { get; set; }
  public DateOnly HireDate { get; set; }
  public DateOnly AddedDate { get; set; }
  public DateOnly ModifiedDate { get; set; }
  public decimal Salary { get; set; }
  public required string Status { get; set; }
  
}
