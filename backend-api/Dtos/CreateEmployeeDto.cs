using System.ComponentModel.DataAnnotations;

namespace EMS.Api.Dtos;

public record class CreateEmployeeDto(
    [Required(ErrorMessage = "Le nom est requis")][StringLength(50)]
    string Name,
    [Required(ErrorMessage = "L'email est requis")][EmailAddress]
    string Email,
    [Range(typeof(DateOnly), "1900-01-01", "2100-01-01", ErrorMessage = "Date is out of range")]
    DateOnly HireDate,
    // DateOnly AddedDate,
    // DateOnly ModifiedDate,
    [Required(ErrorMessage = "Le Département est requis")]
    int DepartmentId,
    decimal Salary,
    string Status
);
