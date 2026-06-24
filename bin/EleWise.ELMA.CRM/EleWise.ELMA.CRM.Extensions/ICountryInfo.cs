using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ICountryInfo
{
	void Adding(IAddress address);

	void ChangeTypeUid(IAddress address);

	bool NeedAdd(string Name);
}
