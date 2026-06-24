using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Web.Extensions;

namespace EleWise.ELMA.Documents.Web.Components.Settings;

[Component(Order = 50)]
public class DocumentActionsProfileSettings : ModuleSettingsDmsPageProvider
{
	public override string ModuleUid => "EleWise.ELMA.Documents.Web";

	public override string Image => "#history.svg";

	public override string Text => SR.T("Настройка отображения действий по документам");

	public override string Description => SR.T("Настроить те блоки и действия, которые пользователь будет видеть на карточке документа.");

	public override string Url(UrlHelper urlHelper)
	{
		return urlHelper.Action("Settings", "DocumentActionsProfile", (object)new
		{
			area = "EleWise.ELMA.Documents.Web"
		});
	}
}
