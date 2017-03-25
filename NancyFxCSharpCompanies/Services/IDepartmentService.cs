using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NancyFxCSharpCompanies
{
	public interface IDepartmentService
	{
		Task<ICollection<Department>> GetDepartments();
		Task<Department> GetDepartment (int id);
	}
}

