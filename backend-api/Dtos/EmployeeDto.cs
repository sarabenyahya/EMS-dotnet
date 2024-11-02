using System.ComponentModel.DataAnnotations;
using EMS.Api.Entities;

namespace EMS.Api.Dtos;

public record class EmployeeDto(
    int Id,
    string Name,
    string Email,
    DateOnly HireDate,
    DateOnly AddedDate,
    DateOnly ModifiedDate,
    string Department,
    decimal Salary,
    string Status
);

