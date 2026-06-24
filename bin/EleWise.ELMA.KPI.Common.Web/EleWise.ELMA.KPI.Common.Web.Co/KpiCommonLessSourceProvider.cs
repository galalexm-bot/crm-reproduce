using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.KPI.Common.Web.Components;

[Component(Order = 1000)]
internal class KpiCommonLessSourceProvider : ILayoutLessSourceProvider, IAbstractLessSourceProvider
{
	public string Area => "EleWise.ELMA.KPI.Common.Web";

	public string ContentPath => "~/Modules/EleWise.ELMA.KPI.Common.Web/Content/";

	public string FileName => "index.less";
}
