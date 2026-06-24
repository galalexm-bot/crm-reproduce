using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Components;

[Component(Order = 800)]
internal class CrmLessSourceProvider : ILayoutLessSourceProvider, IAbstractLessSourceProvider
{
	public string Area => "EleWise.ELMA.CRM.Web";

	public string ContentPath => "~/Modules/EleWise.ELMA.CRM.Web/Content/";

	public string FileName => "index.less";
}
