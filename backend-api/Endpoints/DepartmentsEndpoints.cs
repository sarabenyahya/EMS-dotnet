
using EMS.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace EMS.Api.Endpoints;

public static class DepartmentsEndpoints
{
    


    public static RouteGroupBuilder MapDepartmentEndpoints(this WebApplication app)
    {

        RouteGroupBuilder group = app.MapGroup("api/departments")
        .WithParameterValidation();

        // ============= Get Employees list ===============================
        group.MapGet("/", async (AppDbContext dbContext) =>
            await dbContext.Department
                
                .Select(d => d.ToDepartmentDto())
                .AsNoTracking()
                .ToListAsync()

        );

        return group;

    }


}

