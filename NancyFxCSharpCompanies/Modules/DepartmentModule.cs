﻿using System;
using System.Threading.Tasks;
using Nancy;
using NancyFxCSharpCompanies.Services;

namespace NancyFxCSharpCompanies.Modules
{
	public class DepartmentModule : NancyModule
	{
		private IDepartmentService _departmentService;

		public DepartmentModule (IDepartmentService departmentService) : base("departments")
		{ 
			_departmentService = departmentService;

			Get["/", true] = (_,ctx) => GetDepartments ();
			Get["/{id}", true] = (_,ctx) => GetDepartment (_.id);
		}

		public async Task<object> GetDepartments()
		{
			return await _departmentService.GetDepartments ();
		}

		public async Task<object> GetDepartment(int id)
		{
			return await _departmentService.GetDepartment (id);
		}
	}
}

