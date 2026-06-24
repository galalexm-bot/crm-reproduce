using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Documents.Web.Components;

[Component(Order = 400)]
internal class LayoutScriptSourceProvider : ILayoutScriptSourceProvider
{
	public string[] ScriptSources => new string[4]
	{
		string.Format("~/Modules/{0}/Scripts/elma.DocumentAttachment.js", "EleWise.ELMA.Documents.Web"),
		string.Format("~/Modules/{0}/Scripts/elma.DocumentButtonAgent.js", "EleWise.ELMA.Documents.Web"),
		string.Format("~/Modules/{0}/Scripts/elma.DocumentMenu.js", "EleWise.ELMA.Documents.Web"),
		string.Format("~/Modules/{0}/Scripts/elma.DocumentPreviewSelector.js", "EleWise.ELMA.Documents.Web")
	};
}
