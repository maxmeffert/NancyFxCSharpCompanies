using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NancyFxCSharpCompanies.Models;

namespace NancyFxCSharpCompanies.Services
{
	public interface ICompanyService
	{
		Task<ICollection<Company>> GetCompanies();
		Task<Company> GetCompany (int id);
	}
}

