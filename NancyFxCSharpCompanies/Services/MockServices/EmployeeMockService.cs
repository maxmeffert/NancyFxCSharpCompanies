using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using NancyFxCSharpCompanies.Models;

namespace NancyFxCSharpCompanies.Services.MockServices
{
	public class EmployeeMockService : IEmployeeService
	{
		private ICollection<Employee> employees = new List<Employee>();

		public EmployeeMockService()
		{
			for (int i = 0; i < 10; i++)
			{
				employees.Add (new Employee (){ 
					Id = i,
					FirstName = "John" + i,
					SecondName = "Doe" + i
				});
			}
		}

		public async Task<ICollection<Employee>> GetEmployees()
		{
			return employees;
		}

		public async Task<Employee> GetEmployee(int id)
		{
			return employees.Where (c => c.Id == id).FirstOrDefault ();
		}
	}
}

