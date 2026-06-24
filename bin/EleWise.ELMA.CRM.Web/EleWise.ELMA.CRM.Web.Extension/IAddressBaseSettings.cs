using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Web.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IAddressBaseSettings
{
	IEnumerable<NamedValue<string>> Settings(UrlHelper url);
}
