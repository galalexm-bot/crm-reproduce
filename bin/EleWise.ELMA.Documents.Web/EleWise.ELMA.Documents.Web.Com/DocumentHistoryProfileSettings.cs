using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Web.Extensions;

namespace EleWise.ELMA.Documents.Web.Components.Settings;

[Component(Order = 40)]
public class DocumentHistoryProfileSettings : ModuleSettingsDmsPageProvider
{
	public override string ModuleUid => "EleWise.ELMA.Documents.Web";

	public override string Image => "#history.svg";

	public override string Text => SR.T("Настройка отображения истории по документам");

	public override string Description => SR.T("Настроить те блоки и действия, которые пользователь будет видеть при загрузке истории в документах.");

	public override string Url(UrlHelper urlHelper)
	{
		return urlHelper.Action("Settings", "DocumentHistoryProfile", (object)new
		{
			area = "EleWise.ELMA.Documents.Web"
		});
	}
}
