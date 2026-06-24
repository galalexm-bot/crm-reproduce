using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component(Order = 300)]
internal class LayoutScriptSourceProvider : ILayoutScriptSourceProvider
{
	public string[] ScriptSources => new string[7]
	{
		string.Format("~/Modules/{0}/Scripts/AutoResizeTextbox.js", "EleWise.ELMA.BPM.Web.Common"),
		string.Format("~/Modules/{0}/Scripts/GroupControlsContainer.js", "EleWise.ELMA.BPM.Web.Common"),
		string.Format("~/Modules/{0}/Scripts/BigText.js", "EleWise.ELMA.BPM.Web.Common"),
		string.Format("~/Modules/{0}/Scripts/scrolltop.js", "EleWise.ELMA.BPM.Web.Common"),
		string.Format("~/Modules/{0}/Scripts/SelectableGrid.js", "EleWise.ELMA.BPM.Web.Common"),
		string.Format("~/Modules/{0}/Scripts/elma.CommentWithAttachments.js", "EleWise.ELMA.BPM.Web.Common"),
		string.Format("~/Modules/{0}/Scripts/elma.CollapsableContainer.js", "EleWise.ELMA.BPM.Web.Common")
	};
}
