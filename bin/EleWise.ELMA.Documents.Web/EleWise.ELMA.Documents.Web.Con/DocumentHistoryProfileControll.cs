using System.Web.Mvc;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.Documents.Web.Controllers;

[Permission("2818B96D-D686-418C-8CCB-6D37815F1497")]
public class DocumentHistoryProfileController : DmsController<IDocumentHistoryProfile, long>
{
	[HttpGet]
	public ActionResult Settings()
	{
		IDocumentHistoryProfile documentHistoryProfile = DocumentHistoryProfileManager.Instance.LoadDefaultSettings();
		if (documentHistoryProfile == null)
		{
			DocumentHistoryProfileManager.Instance.CreateNew(null, DocumentConstants.DefaultDocumentHistoryProfileUid);
		}
		else
		{
			DocumentHistoryProfileManager.Instance.RefreshProfile(documentHistoryProfile);
		}
		DocumentHistoryProfileView documentHistoryProfileView = new DocumentHistoryProfileView
		{
			Entity = documentHistoryProfile
		};
		((Controller)(object)this).SetCurrentMenuItem("document_module_settings");
		return (ActionResult)(object)((Controller)this).View((object)documentHistoryProfileView);
	}

	[HttpPost]
	public ActionResult Settings(DocumentHistoryProfileView model)
	{
		DocumentHistoryProfileManager.Instance.Save(model.Entity);
		base.Notifier.Information(SR.T("Настройки отображения истории успешно сохранены"));
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
	}
}
