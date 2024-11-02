namespace EMS.Api;

public record class EmployeeDetailsDto
(
    int Id,
    string Name,
    string Email,
    DateOnly HireDate,
    DateOnly AddedDate,
    DateOnly ModifiedDate,
    int DepartmentId,
    decimal Salary,
    string Status
);
