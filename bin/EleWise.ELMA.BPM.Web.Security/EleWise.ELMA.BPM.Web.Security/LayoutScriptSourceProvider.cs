using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Security.Components;

[Component(Order = 100)]
internal class LayoutScriptSourceProvider : ILayoutScriptSourceProvider
{
	public string[] ScriptSources => new string[4] { "~/Modules/EleWise.ELMA.BPM.Web.Security/Scripts/Elma.UserInfo.js", "~/Modules/EleWise.ELMA.BPM.Web.Security/Scripts/Elma.UserPanelPing.js", "~/Modules/EleWise.ELMA.BPM.Web.Security/Scripts/Elma.UserSelect.js", "~/Modules/EleWise.ELMA.BPM.Web.Security/Scripts/Elma.UserPopup.js" };
}
