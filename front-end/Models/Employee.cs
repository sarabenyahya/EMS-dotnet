using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EMS.Models;

public class Employee
{
    public  int? Id { get; set; }

    [Required(ErrorMessage = "⚠️ Le nom est requis")]
    public required  string  Name { get; set; }

    [Required(ErrorMessage = "⚠️ L'email est requis")][EmailAddress(ErrorMessage = "⚠️ Email invalide ")]
    public required string Email { get; set; }

    public DateOnly HireDate { get; set; }

    public DateOnly AddedDate { get; set; }

    public DateOnly ModifiedDate { get; set; }
    
    public required int DepartmentId { get; set; }

    public decimal Salary { get; set; }

    public required  string Status { get; set; } 

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name},Email {Email}, HireDate: {HireDate}, AddedDate: {AddedDate}, ModifiedDate: {ModifiedDate}, DepartmentId: {DepartmentId}, Salary: {Salary}, Status: {Status}";
    }
}

