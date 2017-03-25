using System;
using System.Collections.Generic;

namespace NancyFxCSharpCompanies
{
	public class Company
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public ICollection<Department> Departments { get; } = new List<Department>();
	}
}

