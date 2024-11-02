using EMS.Api.Dtos;
using EMS.Api.Entities;

namespace EMS.Api;

public static class DepartmentMapping
{

    public static DepartmentDto ToDepartmentDto(this Department department)
        => new(department.Id, department.Name);
}
