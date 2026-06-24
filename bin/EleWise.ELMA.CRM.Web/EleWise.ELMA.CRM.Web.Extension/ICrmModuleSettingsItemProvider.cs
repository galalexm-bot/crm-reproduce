using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Web.Models;

namespace EleWise.ELMA.CRM.Web.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ICrmModuleSettingsItemProvider
{
	IEnumerable<CrmModuleSettingsItem> GetItems(UrlHelper urlHelper);

	IEnumerable<CrmModuleSettingsItem> GetObjects(UrlHelper urlHelper);
}
