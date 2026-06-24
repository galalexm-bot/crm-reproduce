using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(IAddress))]
public interface IAddressFilter : IEntityFilter
{
	ICountry Country { get; set; }

	string Region { get; set; }

	string District { get; set; }

	string City { get; set; }

	string Locality { get; set; }

	string Street { get; set; }

	string Building { get; set; }

	string Appartment { get; set; }
}
