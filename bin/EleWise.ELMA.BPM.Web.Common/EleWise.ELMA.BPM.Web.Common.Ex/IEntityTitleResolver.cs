using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IEntityTitleResolver
{
	bool CheckType(IEntity entity);

	MvcHtmlString GetTitle(IEntity entity, UrlHelper helper);
}
