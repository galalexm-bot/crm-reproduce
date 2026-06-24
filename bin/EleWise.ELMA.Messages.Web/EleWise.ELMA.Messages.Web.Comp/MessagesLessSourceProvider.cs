using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Messages.Web.Components;

[Component(Order = 250)]
internal class MessagesLessSourceProvider : ILayoutLessSourceProvider, IAbstractLessSourceProvider
{
	public string Area => "EleWise.ELMA.Messages.Web";

	public string ContentPath => "~/Modules/EleWise.ELMA.Messages.Web/Content/";

	public string FileName => "index.less";
}
