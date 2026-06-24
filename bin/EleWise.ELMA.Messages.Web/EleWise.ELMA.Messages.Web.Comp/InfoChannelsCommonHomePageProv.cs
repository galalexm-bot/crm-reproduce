using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Messages.Web.Components;

[Component(Order = 30)]
public class InfoChannelsCommonHomePageProvider : ICommonHomePageProvider, IModuleSettingsPageProvider
{
	public string ModuleUid => "EleWise.ELMA.Messages";

	public string Image => "#messages.svg";

	public string Text => SR.T("Сообщения");

	public string Description => SR.T("Раздел позволяет настроить информационные каналы для обмена сообщениями и новостями в организации");

	public string Url(UrlHelper urlHelper)
	{
		return urlHelper.Action("MessagesSettingsPage", "BaseMessage", (object)new
		{
			area = "EleWise.ELMA.Messages.Web"
		});
	}
}
