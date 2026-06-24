using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.CRM.Web.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IAddressProviderWeb
{
	long CountryCode { get; }

	Type AddressType { get; }

	string EditorPartialViewName { get; }
}
