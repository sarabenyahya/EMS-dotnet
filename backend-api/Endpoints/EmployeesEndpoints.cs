using System.ComponentModel.DataAnnotations;
using EMS.Api.Data;
using EMS.Api.Dtos;
using EMS.Api.Entities;
using EMS.Api.Mapping;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace EMS.Api.Endpoints;

public static class EmployeesEndpoints
{
    const string GetEmployeeEndpoint = "GetEmployee";
   

    /*  private static readonly List<EmployeeDto> employees = [
     new EmployeeDto(1, "John Doe", "jdoe@em.com", new DateOnly(2022, 1, 1), new DateOnly(2022, 1, 1), new DateOnly(2022, 1, 1), "Engineering", 1000, "Active"),
     new EmployeeDto(2, "Jane Doe", "jdoe@em.com", new DateOnly(1985, 1, 1), new DateOnly(2022, 1, 1), new DateOnly(2022, 1, 1), "HR", 2000, "Active"),
     new EmployeeDto(3, "John Smith", "jsmith@em.com", new DateOnly(1980, 1, 1), new DateOnly(2022, 1, 1), new DateOnly(2022, 1, 1), "Sales", 1500, "Active"),
     new EmployeeDto(4, "Jane Johnson", "jjohnson@em.com", new DateOnly(1990, 1, 1), new DateOnly(2022, 1, 1), new DateOnly(2022, 1, 1), "Marketing", 1200, "Active"),
     new EmployeeDto(5, "Mike Brown", "mbrown@em.com", new DateOnly(1995, 1, 1), new DateOnly(2022, 1, 1), new DateOnly(2022, 1, 1), "Engineering", 1000, "Active"),
     new EmployeeDto(6, "Sarah Lee", "slee@em.com", new DateOnly(1992, 1, 1), new DateOnly(2022, 1, 1), new DateOnly(2022, 1, 1), "Finance", 1500, "Active")
     ]; */


    public static RouteGroupBuilder MapEmployeesEndpoints(this WebApplication app)
    {
        

        RouteGroupBuilder group = app.MapGroup("api/employees")
        .WithParameterValidation();

        // ============= Get Employees list ===============================
        group.MapGet("/", async (AppDbContext dbContext) =>
            await dbContext.Employees 
                .Include(e => e.Department)
                .Select(e => e.ToEmployeeDto())
                .AsNoTracking()
                .ToListAsync()

        ).WithName("GetEmployees");


        // ===================== Get employee by id==========================
        group.MapGet("/{id}", async (int id, AppDbContext dbContext) =>
        {
            Employee? employee = await dbContext.Employees.FindAsync(id);
            if (employee is null) return Results.NotFound(new { message = $"Aucun employée trouvé pour l'id: `{id}`" });

            return Results.Ok(employee.ToEmployeeDetailsDto());


        })
         .WithName(GetEmployeeEndpoint);

        

        // Add employee -----------------------------------------------
        group.MapPost("",async (CreateEmployeeDto newEmployee, AppDbContext dbContext) =>
        {

            var employee = newEmployee.ToEntity();
            dbContext.Employees.Add(employee);
            await dbContext.SaveChangesAsync();

            return Results.CreatedAtRoute(GetEmployeeEndpoint, new { id = employee.Id }, employee.ToEmployeeDetailsDto());
        });


        // Update employee----------------------------------------------
        group.MapPut("/{id}",async (int id, UpdateEmployeeDto updatedEmployee, AppDbContext dbContext) =>
        {
            Employee? employee = await dbContext.Employees.FindAsync(id);
            if (employee is null) return Results.NotFound(new { message = $"Aucun employée pour l'id: `{id}`" });


            dbContext.Entry(employee).CurrentValues.SetValues(updatedEmployee.ToEntity(id));
            await dbContext.SaveChangesAsync();
            return Results.NoContent();
        }
        );


        // Delete employee ----------------------------------------------
        group.MapDelete("/{id}",async (int id, AppDbContext dbContext) =>

        {
           
            await dbContext.Employees.Where(e => e.Id == id).ExecuteDeleteAsync();

            return Results.NoContent();
        });

        return group;
    }




}
