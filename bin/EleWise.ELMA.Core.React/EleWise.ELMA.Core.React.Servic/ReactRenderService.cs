using Bridge.Html5;
using Bridge.React;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.React.Helpers;
using EleWise.ELMA.Core.UI.Model;
using EleWise.ELMA.Core.UI.Services;

namespace EleWise.ELMA.Core.React.Services;

[Service]
internal sealed class ReactRenderService : IRenderService
{
	public void Render(IRenderContent element, Element container)
	{
		React.Render(element.ToReactElement(), container);
	}
}
