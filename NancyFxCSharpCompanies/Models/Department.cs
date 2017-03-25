using System;
using System.Collections.Generic;

namespace NancyFxCSharpCompanies
{
	public class Department
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public Employee Manager { get; set; }
		public ICollection<Employee> Employees { get; } = new List<Employee>();
	}
}

