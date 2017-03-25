using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NancyFxCSharpCompanies.Models;

namespace NancyFxCSharpCompanies.Services
{
	public interface IEmployeeService
	{
		Task<ICollection<Employee>> GetEmployees();
		Task<Employee> GetEmployee (int id);
	}
}

