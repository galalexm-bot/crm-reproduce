using System;
using System.Web.Mvc;
using EleWise.ELMA.API;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models.API;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.BPM.Web.Security.Controllers;

[RouteArea("EleWise.ELMA.BPM.Web.Security")]
[Permission("A69D083E-F2E9-4E86-AF71-71A1E4BE91B0")]
public class PublicApplicationController : BPMController<EleWise.ELMA.Security.Models.API.IPublicApplication, long>
{
	private const string UpdateTokenHtmlFieldPrefix = "UpdateToken";

	private const string CreateTokenHtmlFieldPrefix = "CreateToken";

	public IPublicApplicationService PublicApplicationService { get; set; }

	public PublicApplicationTokenManager TokenManager { get; set; }

	[ContentItem(Name = "SR.M('Внешние приложения')", Image24 = "#apps.svg")]
	[Permission("A69D083E-F2E9-4E86-AF71-71A1E4BE91B0")]
	public ActionResult Index()
	{
		return (ActionResult)(object)((Controller)this).View((object)base.Manager.FindAll());
	}

	[Permission("A69D083E-F2E9-4E86-AF71-71A1E4BE91B0")]
	public ActionResult Create()
	{
		return (ActionResult)(object)((Controller)this).View((object)base.Manager.Create());
	}

	[Permission("A69D083E-F2E9-4E86-AF71-71A1E4BE91B0")]
	public ActionResult CreateTokenPopup(Guid id)
	{
		CreatePublicApplicationTokenModel createPublicApplicationTokenModel = new CreatePublicApplicationTokenModel
		{
			ApplicationUid = id,
			ExpireDateTime = DateTime.Today.AddMonths(6)
		};
		((ControllerBase)this).get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix("CreateToken");
		return (ActionResult)(object)((Controller)this).PartialView((object)createPublicApplicationTokenModel);
	}

	[Permission("A69D083E-F2E9-4E86-AF71-71A1E4BE91B0")]
	[HttpPost]
	public ActionResult Create(EleWise.ELMA.Security.Models.API.IPublicApplication model)
	{
		if (((Controller)this).get_ModelState().get_IsValid() && model.IsNew() && PublicApplicationService.CreateApplication(model))
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
		}
		return (ActionResult)(object)((Controller)this).View((object)model);
	}

	[Permission("A69D083E-F2E9-4E86-AF71-71A1E4BE91B0")]
	[HttpPost]
	public ActionResult CreateToken([Bind(Prefix = "CreateToken")] CreatePublicApplicationTokenModel model)
	{
		if (((Controller)this).get_ModelState().get_IsValid())
		{
			EleWise.ELMA.API.Models.IPublicApplicationToken publicApplicationToken = PublicApplicationService.CreateToken(model.ApplicationUid, model.ExpireDateTime);
			if (publicApplicationToken != null)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("View", (object)new
				{
					id = publicApplicationToken.Application.Uid
				});
			}
		}
		base.Notifier.Error(SR.T("Ошибка при попытке создать токен приложения"));
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", (object)new
		{
			id = model.ApplicationUid
		});
	}

	[Permission("A69D083E-F2E9-4E86-AF71-71A1E4BE91B0")]
	[HttpPost]
	public ActionResult RemoveToken(Guid id, string token)
	{
		if (PublicApplicationService.RemoveToken(token))
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("View", (object)new { id });
		}
		base.Notifier.Error(SR.T("Ошибка при попытке создать токен приложения"));
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", (object)new { id });
	}

	[Permission("A69D083E-F2E9-4E86-AF71-71A1E4BE91B0")]
	[HttpPost]
	public ActionResult Delete(Guid id)
	{
		if (PublicApplicationService.RemoveApplication(id))
		{
			base.Notifier.Information(SR.T("Внешнее приложение успешно удалено"));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
		}
		base.Notifier.Error(SR.T("Ошибка при удалении внешнего приложения"));
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}

	[Permission("A69D083E-F2E9-4E86-AF71-71A1E4BE91B0")]
	public ActionResult UpdateTokenPopup(string token)
	{
		EleWise.ELMA.Security.Models.API.IPublicApplicationToken publicApplicationToken = TokenManager.FindByToken(token);
		if (publicApplicationToken == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		UpdatePublicApplicationTokenModel updatePublicApplicationTokenModel = new UpdatePublicApplicationTokenModel
		{
			ApplicationUid = publicApplicationToken.Application.Uid,
			ExpireDateTime = publicApplicationToken.Expire,
			Token = token
		};
		((ControllerBase)this).get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix("UpdateToken");
		return (ActionResult)(object)((Controller)this).PartialView((object)updatePublicApplicationTokenModel);
	}

	[Permission("A69D083E-F2E9-4E86-AF71-71A1E4BE91B0")]
	[HttpPost]
	public ActionResult UpdateToken([Bind(Prefix = "UpdateToken")] UpdatePublicApplicationTokenModel model)
	{
		if (PublicApplicationService.UpdateToken(model.Token, model.ExpireDateTime))
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("View", (object)new
			{
				id = model.ApplicationUid
			});
		}
		base.Notifier.Error(SR.T("Ошибка при попытке создать токен приложения"));
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", (object)new
		{
			id = model.ApplicationUid
		});
	}

	[Permission("A69D083E-F2E9-4E86-AF71-71A1E4BE91B0")]
	[HttpPost]
	public ActionResult Activate(Guid id)
	{
		EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication = base.Manager.LoadOrNull(id);
		if (publicApplication == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		if (PublicApplicationService.Activate(publicApplication.Uid))
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("View", (object)new
			{
				id = publicApplication.Uid
			});
		}
		base.Notifier.Error(SR.T("Ошибка при активации публичного приложения"));
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}

	[Permission("A69D083E-F2E9-4E86-AF71-71A1E4BE91B0")]
	[HttpPost]
	public ActionResult DeActivate(Guid id)
	{
		EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication = base.Manager.LoadOrNull(id);
		if (publicApplication == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		if (PublicApplicationService.DeActivate(publicApplication.Uid))
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("View", (object)new
			{
				id = publicApplication.Uid
			});
		}
		base.Notifier.Error(SR.T("Ошибка при деактивации публичного приложения"));
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}

	[Permission("A69D083E-F2E9-4E86-AF71-71A1E4BE91B0")]
	public ActionResult View(Guid id)
	{
		EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication = base.Manager.LoadOrNull(id);
		if (publicApplication == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		return (ActionResult)(object)((Controller)this).View((object)publicApplication);
	}
}
