using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.CRM.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ICountryInfoExt : ICountryInfo
{
	Type GetAddressType();
}
