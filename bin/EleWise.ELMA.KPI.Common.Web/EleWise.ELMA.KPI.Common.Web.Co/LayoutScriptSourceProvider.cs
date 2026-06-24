using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.KPI.Common.Web.Components;

[Component(Order = 500)]
internal class LayoutScriptSourceProvider : ILayoutScriptSourceProvider
{
	public string[] ScriptSources => new string[2] { "~/Modules/EleWise.ELMA.KPI.Common.Web/Scripts/ProjectionScale.js", "~/Modules/EleWise.ELMA.KPI.Common.Web/Scripts/ColorPicker.js" };
}
