using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Content.Extensions;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content;
using EleWise.ELMA.Content.Helpers;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

public class WorkplacePagesController : BPMController
{
	public HomePageSettingManager HomePageManager { get; set; }

	public PortalObjectManager PortalObjectManager { get; set; }

	public IEntityManager<ComponentMetadataItemHeader, long> ComponentMetadataItemHeaderManager { get; set; }

	[AnyPermission(new string[] { "F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6", "B8C77CE4-28FF-4446-B293-59B43C89511B" })]
	public ActionResult Organizer()
	{
		IUserWorkPlace currentUser = base.AuthenticationService.GetCurrentUser<IUserWorkPlace>();
		IWorkplacePages currentWorkplacePages = WorkPlaceExtensions.GetCurrentWorkplacePages();
		List<IHomePageSetting> list = HomePageManager.GetHomePageSettings(WorkPlaceExtensions.GetCurrentWorkPlace(loadDefaultWorkPlace: true), currentUser, disableSecurity: false).ToList();
		OrganizerModel organizerModel = new OrganizerModel
		{
			WorkplacePages = (from p in (IEnumerable<IHomePageSetting>)currentWorkplacePages.Pages
				select p.Page into p
				where p != null
				select p).ToList(),
			SelectedPageSettings = list,
			DisabledItems = (list.Any() ? new JsonSerializer().Serialize((from p in list
				where p.Page != null
				select p.Page.Id).ToList()) : "[]"),
			AdminPermission = base.SecurityService.HasPermission(PermissionProvider.ContentAdminPermission)
		};
		((ControllerBase)this).get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix("Pages");
		return (ActionResult)(object)((Controller)this).PartialView((object)organizerModel);
	}

	[HttpPost]
	[AnyPermission(new string[] { "F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6", "B8C77CE4-28FF-4446-B293-59B43C89511B" })]
	public ActionResult Organizer(List<IHomePageSetting> pages)
	{
		string text = null;
		try
		{
			IUserWorkPlace user = (IUserWorkPlace)base.AuthenticationService.GetCurrentUser<IUser>();
			List<IPortalObject> list = (from p in (IEnumerable<IHomePageSetting>)WorkPlaceExtensions.GetCurrentWorkplacePages().Pages
				select p.Page into p
				where p != null && base.SecurityService.HasPermission(user, PageSecurity.ViewPagePermission, p)
				select p).ToList();
			if (!base.SecurityService.HasPermission(user, PermissionProvider.ContentAdminPermission) && pages.Select((IHomePageSetting p) => p.Page).Intersect(list).Count() < list.Count)
			{
				throw new SecurityException(SR.T("Нет прав на удаление главных страниц интерфейса"));
			}
			HomePageManager.SaveOrganizerSettings(user, pages);
		}
		catch (Exception ex)
		{
			text = ex.Message;
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = string.IsNullOrEmpty(text),
			error = text
		}, "text/html");
	}

	[TransactionAction]
	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult Create(long id)
	{
		base.ActiveMenuItem = "portal-workplace";
		IWorkplacePages workplacePages = InterfaceActivator.Create<IWorkplacePages>();
		workplacePages.Save();
		IWorkPlace workPlace = WorkPlaceManager.Instance.Load(id);
		workPlace.WorkplacePages = workplacePages;
		workPlace.Save();
		return (ActionResult)(object)((Controller)this).RedirectToAction("Edit", (object)new
		{
			id = workplacePages.Id,
			ReturnUrl = ((Controller)this).get_Url().Action("Display", "WorkPlace", (object)new { id })
		});
	}

	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult Edit(long id, string ReturnUrl, bool enableEdit = false)
	{
		base.ActiveMenuItem = "portal-workplace";
		IWorkplacePages workplacePages = AbstractNHEntityManager<IWorkplacePages, long>.Instance.Load(id);
		WorkPlaceManager instance = WorkPlaceManager.Instance;
		InstanceOf<IWorkPlaceFilter> instanceOf = new InstanceOf<IWorkPlaceFilter>();
		instanceOf.New.WorkplacePages = workplacePages;
		List<IWorkPlace> list = instance.Find(instanceOf.New, null).ToList();
		bool readOnly = list.Count > 1 && !enableEdit;
		WorkplacePagesModel workplacePagesModel = new WorkplacePagesModel
		{
			OrganizerModel = new OrganizerModel
			{
				SelectedPageSettings = ((IEnumerable<IHomePageSetting>)workplacePages.Pages).ToList(),
				AdminPermission = true,
				DisabledItems = (((IEnumerable<IHomePageSetting>)workplacePages.Pages).Any() ? new JsonSerializer().Serialize((from p in (IEnumerable<IHomePageSetting>)workplacePages.Pages
					where p.Page != null
					select p.Page.Id).ToList()) : "[]"),
				ReadOnly = readOnly
			},
			Entity = workplacePages,
			ReturnUrl = ReturnUrl,
			Workplaces = list,
			ReadOnly = readOnly
		};
		return (ActionResult)(object)((Controller)this).View((object)workplacePagesModel);
	}

	[HttpPost]
	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult Edit(WorkplacePagesModel model)
	{
		try
		{
			if (((Controller)this).get_ModelState().get_IsValid())
			{
				foreach (IHomePageSetting item in ((IEnumerable<IHomePageSetting>)model.Entity.Pages).ToList())
				{
					if (item == null)
					{
						continue;
					}
					bool flag = false;
					if (item.Page != null)
					{
						IHomePageSetting setting2 = item;
						IHomePageSetting homePageSetting = model.Pages.FirstOrDefault((IHomePageSetting x) => x.Page.Id == setting2.Page.Id);
						if (homePageSetting != null)
						{
							item.Order = homePageSetting.Order;
							item.Visible = homePageSetting.Visible;
							item.Save();
							flag = true;
						}
					}
					if (!flag)
					{
						((ICollection<IHomePageSetting>)model.Entity.Pages).Remove(item);
						item.Delete();
					}
				}
				foreach (IHomePageSetting page in model.Pages)
				{
					IHomePageSetting setting = page;
					if (((IEnumerable<IHomePageSetting>)model.Entity.Pages).FirstOrDefault((IHomePageSetting x) => x.Page != null && x.Page.Id == setting.Page.Id) == null)
					{
						page.WorkplacePages = model.Entity;
						page.Save();
						model.Entity.Pages.Add(page);
					}
				}
				model.Entity.Save();
			}
			else
			{
				base.Notifier.Error(SR.T("Заполните обязательные поля"));
			}
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
		}
		string text = ((Controller)this).get_Url().ReturnUrl() ?? ((Controller)this).get_Url().Action("Index", "WorkPlace");
		return (ActionResult)(object)((Controller)this).Redirect(text);
	}

	[TransactionAction]
	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult CreateNew(IWorkplacePages wpPages, string ReturnUrl, long workPlaceId)
	{
		IWorkPlace workPlace = WorkPlaceManager.Instance.LoadOrNull(workPlaceId);
		if (WorkPlaceManager.MobileWorkPlaceUid == workPlace.Uid)
		{
			throw new ObjectNotFoundException(InterfaceActivator.TypeOf<IWorkPlace>().FullName, workPlace.Id);
		}
		if (workPlace == null || workPlace.Uid == WorkPlaceManager.DefaultWorkPlaceUid)
		{
			if (wpPages != null)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Edit", (object)new { wpPages.Id, ReturnUrl });
			}
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Portal");
		}
		IWorkplacePages workplacePages = ((wpPages != null) ? CloneHelperBuilder.Create(wpPages).Restrictions(delegate(RestrictionsBuilder<IWorkplacePages> r)
		{
			r.Rule().ForPropertyName((IWorkplacePages p) => p.CreationDate).Ignore();
			r.Rule().ForPropertyName((IWorkplacePages p) => p.CreationAuthor).Ignore();
			r.Rule().ForPropertyName((IWorkplacePages p) => p.ChangeDate).Ignore();
			r.Rule().ForPropertyName((IWorkplacePages p) => p.ChangeAuthor).Ignore();
		}).Clone() : InterfaceActivator.Create<IWorkplacePages>());
		workplacePages.Save();
		workPlace.WorkplacePages = workplacePages;
		workPlace.Save();
		return (ActionResult)(object)((Controller)this).RedirectToAction("Edit", (object)new { workplacePages.Id, ReturnUrl });
	}

	public ActionResult PageSettings(string pageIdStr, string pageParameters)
	{
		long num = long.Parse(pageIdStr);
		IPortalObject portalObject = PortalObjectManager.Load(num);
		ComponentMetadataItem published = ComponentMetadataItemHeaderManager.Load(portalObject.Uid).Published;
		PageComponentMetadata pageComponentMetadata = (PageComponentMetadata)published.Metadata;
		Assembly assembly = ComponentManager.FindLoadedAssembly(ScriptExecutionHandlerHelper.CreateFullAssemblyName(published.AssemblyName, published.AssemblyVersion), isFullName: true);
		if (assembly == null && published.ScriptModule != null)
		{
			ScriptModule scriptModule = published.ScriptModule;
			assembly = ComponentManager.LoadAssembly(scriptModule.AssemblyRaw, scriptModule.DebugRaw);
		}
		if (assembly == null)
		{
			throw new Exception(SR.T("Не удалось загрузить сборку {0}", published.AssemblyName));
		}
		string text = pageComponentMetadata.FullTypeName + "+" + pageComponentMetadata.Content.Context.Name;
		Type type = assembly.GetType(text);
		if (type == null)
		{
			throw new Exception(SR.T("Не удалось загрузить тип {0}", text));
		}
		object obj = InterfaceActivator.Create(type);
		if (!string.IsNullOrWhiteSpace(pageParameters))
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			string[] array = pageParameters.Split(new char[1] { '&' }, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < array.Length; i++)
			{
				string[] array2 = array[i].Split('=');
				if (array2.Length == 2)
				{
					dictionary.Add(array2[0], array2[1]);
				}
			}
			new EntityJsonSerializer().ConvertFromSerializable(obj, dictionary);
		}
		PageInputsModel pageInputsModel = new PageInputsModel
		{
			PageId = num,
			Context = obj,
			PropertyNames = (from property in PortalObjectHelper.GetPageInputs(pageComponentMetadata.Content.Context)
				select property.Name).ToList()
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)pageInputsModel);
	}
}
