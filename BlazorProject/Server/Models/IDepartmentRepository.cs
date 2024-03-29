﻿using BlazorProject.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorProject.Server.Models
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int departmentId);
    }
}
