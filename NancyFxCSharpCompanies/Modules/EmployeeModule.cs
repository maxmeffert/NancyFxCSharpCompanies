﻿using System;
using System.Threading.Tasks;
using Nancy;
using NancyFxCSharpCompanies.Services;

namespace NancyFxCSharpCompanies.Modules
{
	public class EmployeeModule : NancyModule
	{
		private IEmployeeService _employeeService;

		public EmployeeModule (IEmployeeService employeeService) : base("employees")
		{
			_employeeService = employeeService;

			Get["/", true] = (_,ctx) => GetEmployees ();
			Get["/{id}", true] = (_,ctx) => GetEmployee (_.id);
		}

		public async Task<object> GetEmployees()
		{
			return await _employeeService.GetEmployees ();
		}

		public async Task<object> GetEmployee(int id)
		{
			return await _employeeService.GetEmployee (id);
		}
	}
}

