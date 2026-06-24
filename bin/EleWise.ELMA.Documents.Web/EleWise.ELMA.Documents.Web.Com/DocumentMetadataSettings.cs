using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Web.Extensions;

namespace EleWise.ELMA.Documents.Web.Components.Settings;

[Component(Order = 10)]
public class DocumentMetadataSettings : ModuleSettingsDmsPageProvider
{
	public override string ModuleUid => "EleWise.ELMA.Documents.Web";

	public override string Image => "#document_type.svg";

	public override string Text => SR.T("Типы документов");

	public override string Description => SR.T("Настройка типов документа. Определение папок по умолчанию. Раздача прав на создание документов определенных типов.");

	public override string Url(UrlHelper urlHelper)
	{
		return urlHelper.Action("List", "DocumentMetadata", (object)new
		{
			area = "EleWise.ELMA.Documents.Web"
		});
	}
}
