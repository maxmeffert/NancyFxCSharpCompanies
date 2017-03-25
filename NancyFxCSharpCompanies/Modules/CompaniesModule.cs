using System;
using System.Threading.Tasks;
using Nancy;

namespace NancyFxCSharpCompanies
{
	public class CompaniesModule : NancyModule
	{
		public CompaniesModule () : base("companies")
		{ 
			Get["/", true] = (_,ctx) => GetCompanies();
		}

		public async Task<object> GetCompanies()
		{
			Company result = new Company () {
				Id = 0,
				Name = "Company"
			};

			return result;
		}
	}
}

