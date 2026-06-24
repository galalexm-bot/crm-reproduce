using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IWorkLogEntityInfoLinkDescription
{
	bool CheckType(IEntity entity);

	MvcHtmlString Description(HtmlHelper htmlHelper, IEntity entity);
}
