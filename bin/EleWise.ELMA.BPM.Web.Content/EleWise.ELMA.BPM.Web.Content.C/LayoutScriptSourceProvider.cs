using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Content.Components;

[Component(Order = 300)]
internal class LayoutScriptSourceProvider : ILayoutScriptSourceProvider
{
	public string[] ScriptSources => new string[4] { "~/Modules/EleWise.ELMA.BPM.Web.Content/Scripts/tiny_mce_gzip_cached.js", "~/Modules/EleWise.ELMA.BPM.Web.Content/Scripts/Elma.LeftMenu.js", "~/Modules/EleWise.ELMA.BPM.Web.Content/Scripts/Elma.StartMenu.js", "~/Modules/EleWise.ELMA.BPM.Web.Content/Scripts/MenuPing.js" };
}
