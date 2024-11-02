namespace EMS.Api.Dtos;

public record class UpdateEmployeeDto(
 
    string Name,
    string Email,
    DateOnly HireDate,
    DateOnly AddedDate,
    DateOnly ModifiedDate,
    int DepartmentId,
    decimal Salary,
    string Status
);