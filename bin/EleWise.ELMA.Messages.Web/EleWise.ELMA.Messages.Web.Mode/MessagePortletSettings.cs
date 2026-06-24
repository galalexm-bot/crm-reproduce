namespace EleWise.ELMA.Messages.Web.Models;

public class MessagePortletSettings
{
	public bool ShowOnlyNew { get; set; }

	public static MessagePortletSettings Default => new MessagePortletSettings();
}
