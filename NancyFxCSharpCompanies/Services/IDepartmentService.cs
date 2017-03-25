using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NancyFxCSharpCompanies.Models;

namespace NancyFxCSharpCompanies.Services
{
	public interface IDepartmentService
	{
		Task<ICollection<Department>> GetDepartments();
		Task<Department> GetDepartment (int id);
	}
}

