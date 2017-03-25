using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NancyFxCSharpCompanies
{
	public interface ICompanyService
	{
		Task<ICollection<Company>> GetCompanies();
		Task<Company> GetCompany (int id);
	}
}

