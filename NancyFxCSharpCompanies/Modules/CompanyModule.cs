using System;
using System.Threading.Tasks;
using Nancy;

namespace NancyFxCSharpCompanies
{
	public class CompanyModule : NancyModule
	{
		private ICompanyService _companiesService;

		public CompanyModule (ICompanyService companiesService) : base("companies")
		{ 
			_companiesService = companiesService;

			Get["/", true] = (_,ctx) => GetCompanies();
			Get["/{id}", true] = (_,ctx) => GetCompany(_.id);
		}

		public async Task<object> GetCompanies()
		{
			return await _companiesService.GetCompanies ();
		}

		public async Task<object> GetCompany(int id)
		{
			return await _companiesService.GetCompany (id);
		}
	}
}

