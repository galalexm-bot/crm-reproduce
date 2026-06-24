using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Messages.Web.Components;

[Component(Order = 400)]
internal class LayoutScriptSourceProvider : ILayoutScriptSourceProvider
{
	public string[] ScriptSources => new string[4] { "~/Modules/EleWise.ELMA.Messages.Web/Scripts/UpdateMessagesCount.js", "~/Modules/EleWise.ELMA.Messages.Web/Scripts/ChannelMessage.js", "~/Modules/EleWise.ELMA.Messages.Web/Scripts/FeedScripts.js", "~/Modules/EleWise.ELMA.Messages.Web/Scripts/FeedHubScripts.js" };
}
