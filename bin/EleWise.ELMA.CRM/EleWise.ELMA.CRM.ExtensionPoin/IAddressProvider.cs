using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IAddressProvider
{
	long CountryCode { get; }

	string AddressFormatTemplate { get; }

	void SaveNewFields(IAddress address);

	IAddress CreateAddress();
}
