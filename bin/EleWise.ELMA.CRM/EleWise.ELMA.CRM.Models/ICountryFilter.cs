using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(ICountry))]
public interface ICountryFilter : IEntityFilter
{
	string Name { get; set; }

	string Code { get; set; }

	string ShortName { get; set; }

	long? CountryCode { get; set; }
}
