using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NancyFxCSharpCompanies
{
	public interface IEmployeeService
	{
		Task<ICollection<Employee>> GetEmployees();
		Task<Employee> GetEmployee (int id);
	}
}

