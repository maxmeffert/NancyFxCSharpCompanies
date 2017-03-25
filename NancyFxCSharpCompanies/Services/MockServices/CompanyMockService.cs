using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NancyFxCSharpCompanies
{
	public class CompanyMockService : ICompanyService
	{

		private ICollection<Company> companies = new List<Company>();

		public CompanyMockService()
		{
			for (int i = 0; i < 10; i++)
			{
				companies.Add (new Company (){ 
					Id = i,
					Name = "Company" + i
				});
			}
		}

		public async Task<ICollection<Company>> GetCompanies()
		{
			return companies;
		}

		public async Task<Company> GetCompany(int id)
		{
			return companies.Where (c => c.Id == id).FirstOrDefault ();
		}
	}
}

