using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(Order = 700)]
internal class LayoutScriptSourceProvider : ILayoutScriptSourceProvider
{
	public string[] ScriptSources => new string[1] { string.Format("~/Modules/{0}/Scripts/elma.TaskQuickActions.js", "EleWise.ELMA.BPM.Web.Tasks") };
}
