namespace EMS.Api.Entities;

public class Employee
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public DateOnly HireDate { get; set; }
    public DateOnly AddedDate { get; set; }
    public DateOnly ModifiedDate { get; set; }
    public int DepartmentId { get; set; }
    public Department? Department { get; set; }
    public decimal Salary { get; set; }
    public required string Status { get; set; }
}
 

