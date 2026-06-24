using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Import.Web.Components;

[Component]
internal class CrmImportLessSourceProvider : ILayoutLessSourceProvider, IAbstractLessSourceProvider
{
	public string Area => "EleWise.ELMA.CRM.Import.Web";

	public string ContentPath => "~/Modules/EleWise.ELMA.CRM.Import.Web/Content/";

	public string FileName => "index.less";
}
