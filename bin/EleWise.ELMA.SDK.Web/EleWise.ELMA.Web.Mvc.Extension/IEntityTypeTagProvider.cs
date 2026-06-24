using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IEntityTypeTagProvider
{
	bool CheckType(IEntity entity);

	string GetIconUrl(HtmlHelper helper, IEntity entity);

	MvcHtmlString GetTag(HtmlHelper helper, IEntity entity);
}
