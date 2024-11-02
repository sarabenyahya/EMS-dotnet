using EMS.Api.Dtos;
using EMS.Api.Entities;
using EMS.Api.Data;

namespace EMS.Api.Mapping;

public static class EmployeeMapping
{
    public static Employee ToEntity(this CreateEmployeeDto createEmployeeDto) => new()
    {
        Name = createEmployeeDto.Name,
        Email = createEmployeeDto.Email,
        HireDate = createEmployeeDto.HireDate,
        AddedDate = DateOnly.FromDateTime(DateTime.UtcNow),
        ModifiedDate = DateOnly.FromDateTime(DateTime.UtcNow),
        DepartmentId = createEmployeeDto.DepartmentId,
        Salary = createEmployeeDto.Salary,
        Status = createEmployeeDto.Status
    };

    public static Employee ToEntity(this UpdateEmployeeDto updateEmployeeDto, int id) => new()
    {
        Id = id,
        Name = updateEmployeeDto.Name,
        Email = updateEmployeeDto.Email,
        HireDate = updateEmployeeDto.HireDate,
        AddedDate = updateEmployeeDto.AddedDate,
        ModifiedDate = DateOnly.FromDateTime(DateTime.UtcNow),
        DepartmentId = updateEmployeeDto.DepartmentId,
        Salary = updateEmployeeDto.Salary,
        Status = updateEmployeeDto.Status
    };

    public static EmployeeDto ToEmployeeDto(this Employee employee) =>
        new(
            employee.Id,
            employee.Name,
            employee.Email,
            employee.HireDate,
            employee.AddedDate,
            employee.ModifiedDate,
            employee.Department!.Name,
            employee.Salary,
            employee.Status
        );

    public static EmployeeDetailsDto ToEmployeeDetailsDto(this Employee employee) =>
        new(
            employee.Id,
            employee.Name,
            employee.Email,
            employee.HireDate,
            employee.AddedDate,
            employee.ModifiedDate,
            employee.DepartmentId,
            employee.Salary,
            employee.Status
        );
}
