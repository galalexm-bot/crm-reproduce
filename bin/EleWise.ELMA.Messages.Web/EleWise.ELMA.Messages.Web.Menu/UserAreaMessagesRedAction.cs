using EleWise.ELMA.BPM.Web.Content.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content.Menu;

namespace EleWise.ELMA.Messages.Web.Menu;

[Component(Order = 100)]
public class UserAreaMessagesRedAction : IUserAreaAction
{
	public string Id => "UserAreaAction_MessagesRed";

	public string CssClass => "";

	public bool NeedUpdateCount()
	{
		return true;
	}

	public MenuItemCount GetCount()
	{
		return MessagesMenuItemCountEvaluator.GetCountRed();
	}
}
