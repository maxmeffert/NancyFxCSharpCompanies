using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using NancyFxCSharpCompanies.Models;

namespace NancyFxCSharpCompanies.Services.MockServices
{
	public class DepartmentMockService : IDepartmentService
	{
		private ICollection<Department> departments = new List<Department>();

		public DepartmentMockService()
		{
			for (int i = 0; i < 10; i++)
			{
				departments.Add (new Department (){ 
					Id = i,
					Name = "Department" + i
				});
			}
		}

		public async Task<ICollection<Department>> GetDepartments()
		{
			return departments;
		}

		public async Task<Department> GetDepartment(int id)
		{
			return departments.Where (c => c.Id == id).FirstOrDefault ();
		}
	}
}

