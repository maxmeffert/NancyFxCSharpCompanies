using System;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.Responses.Negotiation;

namespace NancyFxCSharpCompanies
{
	public class Bootstrapper : DefaultNancyBootstrapper
	{
		public Bootstrapper ()
		{
		}

		protected override NancyInternalConfiguration InternalConfiguration
		{
			get
			{
				return NancyInternalConfiguration.WithOverrides(x => { 
					x.ResponseProcessors.Clear();
					x.ResponseProcessors.Add(typeof(JsonProcessor));
				});
			}
		}
	}
}

