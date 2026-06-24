using System.Web.Mvc;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.Documents.Web.Controllers;

[Permission("2818B96D-D686-418C-8CCB-6D37815F1497")]
public class DocumentActionsProfileController : DmsController
{
	[HttpGet]
	public ActionResult Settings()
	{
		DocumentActionSettingsHolder documentActionSettingsHolder = DocumentActionsProfileManager.Instance.LoadDefaultSettings();
		if (documentActionSettingsHolder == null)
		{
			documentActionSettingsHolder = DocumentActionsProfileManager.Instance.CreateNew();
			DocumentActionsProfileManager.Instance.SaveDefaultSettings(documentActionSettingsHolder);
		}
		else
		{
			DocumentActionsProfileManager.Instance.RefreshProfile(documentActionSettingsHolder);
		}
		DocumentActionsProfileView documentActionsProfileView = new DocumentActionsProfileView
		{
			Entity = DocumentActionSettingsHolderView.Create(documentActionSettingsHolder)
		};
		((Controller)(object)this).SetCurrentMenuItem("document_module_settings");
		return (ActionResult)(object)((Controller)this).View((object)documentActionsProfileView);
	}

	[HttpPost]
	public ActionResult Settings(DocumentActionsProfileView model)
	{
		DocumentActionsProfileManager.Instance.SaveDefaultSettings(model.Entity.GetHolder());
		DocumentActionsProfileManager.Instance.ClearCache();
		base.Notifier.Information(SR.T("Настройки отображения действий успешно сохранены"));
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
	}
}
