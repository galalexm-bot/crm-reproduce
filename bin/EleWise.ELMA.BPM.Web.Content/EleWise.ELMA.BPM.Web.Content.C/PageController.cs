using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Content.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Content.Extensions;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.BPM.Web.Content.Portlets;
using EleWise.ELMA.BPM.Web.Content.Security;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.BPM.Web.Security.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Html.Grids;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Models.Portal;
using EleWise.ELMA.Web.Mvc.Portlets;
using EleWise.ELMA.Web.Mvc.Portlets.Layouts;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

public class PageController : BPMController<IPageBase, long>
{
	private const string PagesGridId = "portletPagesGrid47";

	private const string pageIdKey = "EleWise.ELMA.BPM.Web.Content.Controllers.PageController.Home.lastPageId";

	public IEnumerable<IPortletLayout> PortletLayouts { get; set; }

	public OneColumnLayout OneColumnLayout { get; set; }

	public PortletManager PortletManagerFactory { get; set; }

	public IEntityManager<IMenuItem> MenuItemManager { get; set; }

	public HomePageSettingManager HomePageManager { get; set; }

	public PortalObjectManager PortalObjectManager { get; set; }

	public PortletPageManager PortletPageManager { get; set; }

	public RoleMapPageManager RoleMapPageManager { get; set; }

	public IEntityManager<IRoleMapPageItem> RoleMapPageItemManager { get; set; }

	public PermissionsModelService PermissionsModelService { get; set; }

	public ISessionProvider SessionProvider { get; set; }

	public IMetadataRuntimeService MetadataRuntimeService { get; set; }

	public static string LevelUpFolderName => string.Format("...\\({0})", SR.T("на уровень выше"));

	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	[ContentItem(Id = "EleWise.ELMA.BPM.Web.Content.Controllers.PageController.Index", Name = "SR.M('Страницы')", Image24 = "#user.svg")]
	public ActionResult Index()
	{
		return Folder(null);
	}

	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult Folder(long? id)
	{
		((Controller)(object)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Content.Controllers.PageController.Index");
		IPageFolder folder = GetFolder(id);
		((ControllerBase)this).get_ViewData().set_Item("GridId", (object)"portletPagesGrid47");
		return (ActionResult)(object)((Controller)this).View("Folder", (object)folder);
	}

	private static IPageFolder GetFolder(long? id)
	{
		IPageFolder result = null;
		if (id.HasValue && id > 0)
		{
			result = AbstractNHEntityManager<IPageFolder, long>.Instance.Load(id.Value);
		}
		return result;
	}

	[CustomGridAction]
	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult Grid(GridCommand command, long? id, bool? enableChecked, bool? portlet)
	{
		((ControllerBase)this).get_ViewData().set_Item("Portlet", (object)portlet);
		GridData<IPortalObject, IPortalObjectFilter> folderData = GenerateGrid(command, id, enableChecked, ((Controller)this).get_RouteData(), ((ControllerBase)this).get_ViewData());
		return ExportExcel(folderData, typeof(IPortalObject), () => (ActionResult)(object)((Controller)this).PartialView((object)folderData));
	}

	private static GridData<IPortalObject, IPortalObjectFilter> GenerateGrid(GridCommand command, long? id, bool? enableChecked, RouteData routeData, ViewDataDictionary viewData)
	{
		IPageFolder folder = GetFolder(id);
		GridState gridState = GridPersonalizationAdministration.LoadState(GridHelper.GetGridId(routeData));
		if (gridState == null)
		{
			gridState = GridState.CreateNew(GridHelper.GetGridId(routeData), InterfaceActivator.TypeOf<IPortalObject>());
			GridPersonalizationAdministration.SaveState(gridState.GridId, gridState);
		}
		viewData.set_Item("EnableChecked", (object)(!enableChecked.HasValue || enableChecked.Value));
		viewData.set_Item("GridId", (object)gridState.GridId);
		return GetFolderGrid(folder, command);
	}

	private static GridData<IPortalObject, IPortalObjectFilter> GetFolderGrid(IPageFolder folder, GridCommand command = null, IPortalObjectFilter portalFilter = null)
	{
		IPortalObjectFilter portalObjectFilter = portalFilter;
		if (portalObjectFilter == null)
		{
			InstanceOf<IPortalObjectFilter> instanceOf = new InstanceOf<IPortalObjectFilter>();
			instanceOf.New.Folder = folder;
			portalObjectFilter = instanceOf.New;
		}
		IPortalObjectFilter portalObjectFilter2 = portalObjectFilter;
		if (portalObjectFilter2.Folder == null)
		{
			portalObjectFilter2.IsRoot = true;
		}
		portalObjectFilter2.PermissionId = PageSecurity.ViewPagePermission.Id;
		GridData<IPortalObject, IPortalObjectFilter> gridData = new GridData<IPortalObject, IPortalObjectFilter>
		{
			Command = command,
			DataFilter = portalObjectFilter2
		};
		gridData.SetCount(delegate(GridData<IPortalObject, IPortalObjectFilter> d, FetchOptions f)
		{
			long num = PortalObjectManager.Instance.Count(d.DataFilter);
			int num2 = f.MaxResults - 1;
			return num + (int)((folder != null) ? ((num <= num2 || num % num2 == 0L) ? (num / num2) : ((int)(num / num2) + 1)) : 0);
		});
		gridData.SetDataSource(delegate(GridData<IPortalObject, IPortalObjectFilter> d, FetchOptions f)
		{
			if (folder != null)
			{
				f.FirstResult -= ((command != null) ? (command.get_Page() - 1) : 0);
				f.MaxResults--;
			}
			List<IPortalObject> list = PortalObjectManager.Instance.Find(gridData.DataFilter, f).ToList();
			if (folder != null)
			{
				InstanceOf<IPageFolder> instanceOf2 = new InstanceOf<IPageFolder>();
				instanceOf2.New.Id = ((folder.Folder != null) ? folder.Folder.Id : 0);
				instanceOf2.New.Name = LevelUpFolderName;
				instanceOf2.New.CreationAuthor = null;
				instanceOf2.New.CreationDate = null;
				list.Insert(0, instanceOf2.New);
			}
			return list;
		});
		return gridData;
	}

	[HttpGet]
	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult EditFolder(long? id, long? parentId, string popupId)
	{
		IPageFolder pageFolder = (id.HasValue ? AbstractNHEntityManager<IPageFolder, long>.Instance.Load(id) : InterfaceActivator.Create<IPageFolder>());
		if (!id.HasValue && parentId.HasValue)
		{
			pageFolder.Folder = AbstractNHEntityManager<IPageFolder, long>.Instance.Load(parentId);
		}
		return (ActionResult)(object)((Controller)this).PartialView((object)new PageFolderModel
		{
			Entity = pageFolder,
			PopupId = popupId
		});
	}

	[HttpPost]
	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult EditFolder(PageFolderModel model)
	{
		string text = null;
		try
		{
			if (((Controller)this).get_ModelState().get_IsValid())
			{
				model.Entity.Save();
			}
			else
			{
				text = SR.T("Не заполнены обязательные поля");
			}
		}
		catch (Exception ex)
		{
			text = ex.Message;
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = string.IsNullOrEmpty(text),
			id = model.Entity.Id,
			popupId = model.PopupId,
			error = text
		}, "text/html");
	}

	[HttpGet]
	public ActionResult PermissionSettings(long id, bool? forPopup = false)
	{
		IPortalObject instance = PortalObjectManager.Instance.Load(id);
		return PermissionSettings(instance, forPopup);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult PermissionSettings(long id, EditableListModel access)
	{
		IPortalObject instance = PortalObjectManager.Instance.Load(id);
		if (!base.SecurityService.HasPermission(EleWise.ELMA.Content.PermissionProvider.ContentAdminPermission) && !base.SecurityService.HasPermission(PageSecurity.FullAccessPagePermission, instance))
		{
			throw new SecurityException();
		}
		PermissionsModelService.BindPermissionsFromModel(instance, access, delegate(ICollection<IInstanceSettingsPermissionHolder> holders, IEnumerable<IInstanceSettingsPermissionHolder> newHolders)
		{
			List<IInstanceSettingsPermissionHolder> list = new List<IInstanceSettingsPermissionHolder>();
			if (instance.InheritPermissions)
			{
				list.AddRange(holders.Where((IInstanceSettingsPermissionHolder h) => ((IPortalObjectPermission)h).InheritedFromFolder != null));
				foreach (IInstanceSettingsPermissionHolder item in list)
				{
					holders.Remove(item);
				}
			}
			holders.SyncFrom(newHolders, (IInstanceSettingsPermissionHolder v1, IInstanceSettingsPermissionHolder v2) => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals(v1.Assigned, v2.Assigned), null, delegate(IInstanceSettingsPermissionHolder v)
			{
				if (v is IEntity)
				{
					((IEntity)v).Delete();
				}
			});
			if (instance.InheritPermissions)
			{
				foreach (IInstanceSettingsPermissionHolder item2 in list)
				{
					holders.Add(item2);
				}
			}
		});
		PortalObjectManager.Instance.Save(instance);
		string text = ((Controller)this).get_Url().ReturnUrl();
		return (ActionResult)(object)((Controller)this).Redirect(text);
	}

	private ActionResult PermissionSettings(IPortalObject instance, bool? forPopup = false)
	{
		bool flag = instance.CastAsRealType() is IPageProfile;
		PortalObjectPermissionModel portalObjectPermissionModel = new PortalObjectPermissionModel
		{
			InheritPermissions = instance.InheritPermissions,
			Id = instance.Id,
			ForPopup = (forPopup.HasValue && forPopup.Value)
		};
		Action<EntityPermissionRoleTypeSelectorModel> action = delegate(EntityPermissionRoleTypeSelectorModel m)
		{
			m.Routes = new RouteValueDictionary(new
			{
				action = "PermissionSettings",
				controller = "Page",
				area = "EleWise.ELMA.BPM.Web.Content"
			});
		};
		portalObjectPermissionModel.InheritAvailable = instance.Folder != null;
		if (instance.InheritPermissions)
		{
			if (flag)
			{
				portalObjectPermissionModel.InheritedPermissionsModel = PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(instance, InterfaceActivator.TypeOf<IPageProfile>(), ((Controller)this).get_Url(), (IInstanceSettingsPermissionHolder h) => ((IPortalObjectPermission)h).InheritedFromFolder != null, (Permission p) => p != PageSecurity.EditPagePermission);
			}
			else
			{
				portalObjectPermissionModel.InheritedPermissionsModel = PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(instance, InterfaceActivator.TypeOf<IPortalObject>(), ((Controller)this).get_Url(), (IInstanceSettingsPermissionHolder h) => ((IPortalObjectPermission)h).InheritedFromFolder != null);
			}
			action(portalObjectPermissionModel.InheritedPermissionsModel);
			portalObjectPermissionModel.InheritedPermissionsModel.Edit = false;
			portalObjectPermissionModel.InheritedPermissionsModel.ShowSaveButton = !portalObjectPermissionModel.ForPopup;
		}
		if (flag)
		{
			portalObjectPermissionModel.AdditionalPermissionsModel = PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(instance, InterfaceActivator.TypeOf<IPageProfile>(), ((Controller)this).get_Url(), (IInstanceSettingsPermissionHolder h) => ((IPortalObjectPermission)h).InheritedFromFolder == null, (Permission p) => p != PageSecurity.EditPagePermission);
		}
		else
		{
			portalObjectPermissionModel.AdditionalPermissionsModel = PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(instance, InterfaceActivator.TypeOf<IPortalObject>(), ((Controller)this).get_Url(), (IInstanceSettingsPermissionHolder h) => ((IPortalObjectPermission)h).InheritedFromFolder == null);
		}
		action(portalObjectPermissionModel.AdditionalPermissionsModel);
		portalObjectPermissionModel.Edit = portalObjectPermissionModel.AdditionalPermissionsModel.Edit;
		portalObjectPermissionModel.AdditionalPermissionsModel.ShowSaveButton = !portalObjectPermissionModel.ForPopup;
		portalObjectPermissionModel.ChangeInherite = base.SecurityService.HasPermission(EleWise.ELMA.Content.PermissionProvider.ContentAdminPermission) || instance is IPageBase || base.SecurityService.HasPermission(PageSecurity.FullAccessPagePermission, instance);
		return (ActionResult)(object)((Controller)this).PartialView("PortalObject/PermissionSettings", (object)portalObjectPermissionModel);
	}

	[HttpPost]
	public ActionResult EnableInheritPermission(long id, bool enable, bool? forPopup)
	{
		IPortalObject portalObject = PortalObjectManager.Instance.Load(id);
		if (!base.SecurityService.HasPermission(EleWise.ELMA.Content.PermissionProvider.ContentAdminPermission) && !base.SecurityService.HasPermission(PageSecurity.FullAccessPagePermission, portalObject))
		{
			throw new SecurityException();
		}
		PortalObjectManager.Instance.EnableInheritPermissions(portalObject, enable);
		return PermissionSettings(portalObject, forPopup);
	}

	[OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
	[ContentItem(Name = "SR.M('Главная')", Image24 = "#home.svg")]
	public ActionResult Home(long? pageId)
	{
		IUserWorkPlace currentUser = base.AuthenticationService.GetCurrentUser<IUserWorkPlace>();
		if (currentUser == null)
		{
			throw new InvalidOperationException();
		}
		if (!pageId.HasValue)
		{
			long? pageId2 = ((Controller)this).get_Session()["EleWise.ELMA.BPM.Web.Content.Controllers.PageController.Home.lastPageId"] as long?;
			if (pageId2.HasValue)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Home", (object)new
				{
					pageId = pageId2
				});
			}
		}
		HomePagesModel homePagesModel = new HomePagesModel();
		List<HomePageTab> tabs = HomePageManager.GetTabs(WorkPlaceExtensions.GetCurrentWorkPlace(loadDefaultWorkPlace: true), currentUser);
		homePagesModel.VisibleTabs = tabs.OrderBy((HomePageTab t) => t.Order).ToList();
		homePagesModel.AllowedSetupTabs = base.SecurityService.HasPermission(EleWise.ELMA.Content.PermissionProvider.ContentAdminPermission) || base.SecurityService.HasPermission(EleWise.ELMA.Content.PermissionProvider.AllowSetupHomePage);
		HomePageTab homePageTab = homePagesModel.VisibleTabs.FirstOrDefault();
		if (homePageTab != null)
		{
			homePageTab.Default = true;
		}
		if (pageId.HasValue)
		{
			if (!tabs.Any((HomePageTab t) => t.Id == pageId))
			{
				((Controller)this).get_Session()["EleWise.ELMA.BPM.Web.Content.Controllers.PageController.Home.lastPageId"] = null;
				return (ActionResult)(object)((Controller)this).RedirectToAction("Home", (object)new
				{
					pageId = (long?)null
				});
			}
		}
		else if (homePageTab != null)
		{
			pageId = homePageTab.Id;
		}
		if (pageId.HasValue)
		{
			try
			{
				IPortalObject page = PortalObjectManager.LoadOrNull(pageId.Value).CastAsRealType();
				homePagesModel.CurrentPageModel = (from p in ComponentManager.Current.GetExtensionPoints<IPageContentModelExtension>()
					where p.CheckPage(page)
					select p.CreateModel(page)).FirstOrDefault();
				if (homePagesModel.CurrentPageModel == null)
				{
					throw new Exception(SR.T("Неподдерживаемый тип страницы: {0}", page.GetType().ToString()));
				}
				HttpSessionStateBase session = ((Controller)this).get_Session();
				long? num2 = (homePagesModel.ActivePageId = pageId);
				session["EleWise.ELMA.BPM.Web.Content.Controllers.PageController.Home.lastPageId"] = num2;
			}
			catch (SecurityException ex)
			{
				SecurityException ex3 = (SecurityException)(homePagesModel.Exception = ex);
			}
			catch (Exception ex4)
			{
				Exception ex6 = (homePagesModel.Exception = ex4);
			}
		}
		return (ActionResult)(object)((Controller)this).View((object)homePagesModel);
	}

	[HttpGet]
	[AnyPermission(new string[] { "F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6", "B8C77CE4-28FF-4446-B293-59B43C89511B" })]
	public ActionResult AddHomePage()
	{
		IPortletPage portletPage = InterfaceActivator.Create<IPortletPage>();
		PortletPageAttributesModel portletPageAttributesModel = CreatePortletPageAttributesModel(portletPage);
		return (ActionResult)(object)((Controller)this).PartialView((object)portletPageAttributesModel);
	}

	[HttpPost]
	[AnyPermission(new string[] { "F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6", "B8C77CE4-28FF-4446-B293-59B43C89511B" })]
	public ActionResult AddHomePage([Bind(Prefix = "Page")] IPortletPage page, string returnUrl, bool Shared = false)
	{
		HomePageManager.AddPage(WorkPlaceExtensions.GetCurrentWorkPlace(loadDefaultWorkPlace: true), base.AuthenticationService.GetCurrentUser<IUserWorkPlace>(), page);
		return (ActionResult)(object)((Controller)this).RedirectToAction("ConfigurePortletPage", (object)new
		{
			id = page.Id,
			scope = PersonalizationScope.User,
			ReturnUrl = (returnUrl ?? ((Controller)this).get_Url().Action("Home", (object)new
			{
				scope = PersonalizationScope.User,
				pageId = page.Id
			}))
		});
	}

	[HttpGet]
	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult HomeTabs(bool shared = false)
	{
		IPageFolder pageFolder = PageFolderManager.Instance.LoadOrCreateHomePagesFolder();
		return (ActionResult)(object)((Controller)this).RedirectToAction("Folder", (object)new
		{
			id = pageFolder.Id
		});
	}

	public ActionResult View(long id, PersonalizationScope scope = PersonalizationScope.Shared, string activeMenuItemCode = null)
	{
		IPageBase pageBase = base.Manager.Load(id);
		Type typeByUid = MetadataRuntimeService.GetTypeByUid(pageBase.TypeUid);
		if (typeByUid.IsInheritOrSame(typeof(IPortletPage)))
		{
			return ViewPortletPage(id, scope, activeMenuItemCode);
		}
		if (typeByUid.IsInheritOrSame(typeof(IRoleMapPage)))
		{
			return RedirectFromRoleMapPage(pageBase.Cast<IRoleMapPage, IPageBase>(), scope, activeMenuItemCode);
		}
		return (ActionResult)(object)((Controller)this).Redirect("~");
	}

	public ActionResult Edit(long id, string ReturnUrl, string activeMenuItemCode)
	{
		IPageBase pageBase = base.Manager.Load(id);
		Type typeByUid = MetadataRuntimeService.GetTypeByUid(pageBase.TypeUid);
		if (typeByUid.IsInheritOrSame(typeof(IPortletPage)))
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("EditPortletPageAttributes", "Page", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Content",
				id = id,
				ReturnUrl = ReturnUrl,
				activeMenuItemCode = activeMenuItemCode
			});
		}
		if (typeByUid.IsInheritOrSame(typeof(IRoleMapPage)))
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("EditRoleMapPage", "Page", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Content",
				id = id,
				ReturnUrl = ReturnUrl,
				activeMenuItemCode = activeMenuItemCode
			});
		}
		return (ActionResult)(object)((Controller)this).Redirect("~");
	}

	public ActionResult Configure(long id, PersonalizationScope scope, string ReturnUrl)
	{
		IPageBase pageBase = base.Manager.Load(id);
		Type typeByUid = MetadataRuntimeService.GetTypeByUid(pageBase.TypeUid);
		if (typeByUid.IsInheritOrSame(typeof(IPortletPage)))
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("ConfigurePortletPage", "Page", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Content",
				id = id,
				scope = scope,
				ReturnUrl = ReturnUrl
			});
		}
		if (typeByUid.IsInheritOrSame(typeof(IRoleMapPage)))
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("ConfigureRoleMapPage", "Page", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Content",
				id = id,
				scope = scope,
				ReturnUrl = ReturnUrl
			});
		}
		return (ActionResult)(object)((Controller)this).Redirect("~");
	}

	private ActionResult RedirectFromRoleMapPage(IRoleMapPage roleMapPage, PersonalizationScope scope, string activeMenuItemCode)
	{
		IPortletPage mappedPage = RoleMapPageManager.GetMappedPage(roleMapPage);
		return ViewPortletPage(mappedPage.Id, scope, activeMenuItemCode);
	}

	[HttpGet]
	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	[ContentItem(Name = "SR.M('Создать ролевую страницу')", Image24 = "#add.svg")]
	public ActionResult CreateRoleMapPage(long? parentId)
	{
		IRoleMapPage roleMapPage = InterfaceActivator.Create<IRoleMapPage>();
		roleMapPage.Folder = (parentId.HasValue ? AbstractNHEntityManager<IPageFolder, long>.Instance.Load(parentId) : null);
		RoleMapPageAttributesModel roleMapPageAttributesModel = CreateRoleMapPageAttributesModel(roleMapPage);
		return (ActionResult)(object)((Controller)this).View((object)roleMapPageAttributesModel);
	}

	[HttpPost]
	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult CreateRoleMapPage([Bind(Prefix = "Page")] IRoleMapPage page, bool goEdit = false)
	{
		if (!((Controller)this).get_ModelState().get_IsValid())
		{
			return (ActionResult)(object)((Controller)this).View((object)CreateRoleMapPageAttributesModel(page));
		}
		RoleMapPageManager.Save(page);
		if (goEdit)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("ConfigureRoleMapPage", (object)new
			{
				id = page.Id
			});
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", (object)new
		{
			id = page.Id
		});
	}

	[HttpGet]
	public ActionResult EditRoleMapPage(long id, string activeMenuItemCode)
	{
		IRoleMapPage roleMapPage = RoleMapPageManager.Load(id);
		CheckEditAttributesPermission(roleMapPage);
		if (!string.IsNullOrEmpty(activeMenuItemCode))
		{
			((Controller)(object)this).SetCurrentMenuItem(activeMenuItemCode);
		}
		RoleMapPageAttributesModel roleMapPageAttributesModel = CreateRoleMapPageAttributesModel(roleMapPage);
		return (ActionResult)(object)((Controller)this).View((object)roleMapPageAttributesModel);
	}

	[HttpGet]
	public ActionResult ConfigureRoleMapPage(long id)
	{
		IRoleMapPage roleMapPage = RoleMapPageManager.Load(id);
		CheckEditAttributesPermission(roleMapPage);
		RoleMapPageConfigureModel roleMapPageConfigureModel = new RoleMapPageConfigureModel
		{
			Entity = roleMapPage,
			MapItems = GetMapItems(roleMapPage)
		};
		return (ActionResult)(object)((Controller)this).View((object)roleMapPageConfigureModel);
	}

	private Dictionary<IRoleMapPageItem, IEnumerable<AssignedRoleTypeModel>> GetMapItems(IRoleMapPage page)
	{
		return (from i in (IEnumerable<IRoleMapPageItem>)page.MapItems
			orderby i.Order, i.Id
			select i).ToDictionary((IRoleMapPageItem i) => i, (IRoleMapPageItem i) => PermissionsModelService.CreateAssignedRoleTypeModel(((IEnumerable)i.Users).Cast<IEntity>().Union((IEnumerable<IEntity>)i.OrganizationItems).Union((IEnumerable<IEntity>)i.UserGroups)));
	}

	[HttpPost]
	public ActionResult EditRoleMapPage([Bind(Prefix = "Page")] IRoleMapPage page, string ReturnUrl)
	{
		CheckEditAttributesPermission(page);
		if (!((Controller)this).get_ModelState().get_IsValid())
		{
			return (ActionResult)(object)((Controller)this).View((object)CreateRoleMapPageAttributesModel(page));
		}
		RoleMapPageManager.Save(page);
		if (!string.IsNullOrWhiteSpace(ReturnUrl))
		{
			return (ActionResult)(object)((Controller)this).Redirect(ReturnUrl);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", (object)new
		{
			id = page.Id
		});
	}

	[HttpGet]
	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	[ContentItem(Name = "SR.M('Создать текстовую страницу')", Image24 = "#add.svg")]
	public ActionResult CreateTextPage(long? parentId)
	{
		IPortletPage portletPage = InterfaceActivator.Create<IPortletPage>();
		portletPage.Folder = (parentId.HasValue ? AbstractNHEntityManager<IPageFolder, long>.Instance.Load(parentId.Value) : null);
		return (ActionResult)(object)((Controller)this).View("CreateTextPage", (object)CreatePortletPageAttributesModel(portletPage));
	}

	[HttpPost]
	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult CreateTextPage([Bind(Prefix = "Page")] IPortletPage page, bool goEdit = false)
	{
		page.PortletsLayoutId = OneColumnLayout.Id;
		if (!ReValidateModel(page, "Page"))
		{
			return (ActionResult)(object)((Controller)this).View("CreateTextPage", (object)CreatePortletPageAttributesModel(page));
		}
		base.UnitOfWorkManager.Execute((Action)delegate
		{
			PortletPageManager.Save(page);
			string portalPageDataPath = PortletsRestrictionProvider.PortalPageDataPath(page);
			PortletManager portletManager = PortletManagerFactory.Create(PersonalizationScope.Shared, portalPageDataPath);
			portletManager.GetAllPortlets(portalPageDataPath).ForEach(delegate(PortletViewModel p)
			{
				portletManager.RemovePersonalization(p.Personalization.PortletUid, p.Personalization.InstanceId, portalPageDataPath);
			});
			PortletPersonalization portletPersonalization = portletManager.AddPortlet(portletManager.GetPortlet(HTMLPortlet.id), portalPageDataPath);
			portletPersonalization.Zone = OneColumnLayout.Zones.First().Id;
			portletPersonalization.Closed = false;
			portletPersonalization.Collapsed = false;
			portletPersonalization.Collapsed = false;
			portletPersonalization.EnableAsyncLoading = false;
			portletManager.SavePersonalization(portletPersonalization, portalPageDataPath);
		});
		if (goEdit)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("ConfigurePortletPage", (object)new
			{
				id = page.Id,
				ReturnUrl = ((Controller)this).get_Url().Action("View", (object)new
				{
					id = page.Id
				})
			});
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", (object)new
		{
			id = page.Id
		});
	}

	[HttpGet]
	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	[ContentItem(Name = "SR.M('Создать портлетную страницу')", Image24 = "#add.svg")]
	public ActionResult CreatePortletPage(long? parentId)
	{
		IPortletPage portletPage = InterfaceActivator.Create<IPortletPage>();
		portletPage.Folder = (parentId.HasValue ? AbstractNHEntityManager<IPageFolder, long>.Instance.Load(parentId.Value) : null);
		PortletPageAttributesModel portletPageAttributesModel = CreatePortletPageAttributesModel(portletPage);
		return (ActionResult)(object)((Controller)this).View((object)portletPageAttributesModel);
	}

	[HttpPost]
	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult CreatePortletPage([Bind(Prefix = "Page")] IPortletPage page, bool goEdit = false)
	{
		if (!((Controller)this).get_ModelState().get_IsValid())
		{
			return (ActionResult)(object)((Controller)this).View((object)CreatePortletPageAttributesModel(page));
		}
		PortletPageManager.Save(page);
		if (goEdit)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("ConfigurePortletPage", "Page", (object)new
			{
				id = page.Id,
				ReturnUrl = ((page.Folder != null) ? ((Controller)this).get_Url().Action("Folder", (object)new
				{
					id = page.Folder.Id
				}) : ((Controller)this).get_Url().Action("Index", (object)new
				{
					id = (long?)null
				}))
			});
		}
		if (page.Folder == null)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", (object)new
			{
				id = (long?)null
			});
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Folder", (object)new
		{
			id = page.Folder.Id
		});
	}

	[HttpPost]
	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult Delete(long id)
	{
		string text = null;
		try
		{
			PageBaseManager.Instance.TryDeletePage(id);
		}
		catch (Exception ex)
		{
			text = ex.Message;
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = string.IsNullOrEmpty(text),
			error = text
		});
	}

	private void TryDeleteFolder(long id)
	{
		List<Guid> pageTypeUids = (from m in MetadataLoader.GetChildClasses((ClassMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.UID<IPageBase>()))
			select m.Uid).ToList();
		TryDeleteFolder(id, pageTypeUids);
	}

	private void TryDeleteFolder(long id, List<Guid> pageTypeUids)
	{
		IPageFolder folder = PageFolderManager.Instance.Load(id);
		if (folder.Uid == PageFolderManager.HomePagesFolderUid || folder.Uid == PageFolderManager.UserPagesFolderUid)
		{
			throw new Exception(SR.T("Нелья удалить системную папку"));
		}
		foreach (IPortalObject item in PortalObjectManager.Instance.Find((IPortalObject o) => o.Folder == folder))
		{
			if (item.TypeUid == InterfaceActivator.UID<IPageFolder>())
			{
				TryDeleteFolder(item.Id, pageTypeUids);
			}
			else if (pageTypeUids.Contains(item.TypeUid))
			{
				PageBaseManager.Instance.TryDeletePage(item.Id);
			}
		}
		folder.Delete();
	}

	[HttpPost]
	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult DeleteFolder(long id)
	{
		string text = null;
		try
		{
			TryDeleteFolder(id);
		}
		catch (Exception ex)
		{
			text = ex.Message;
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = string.IsNullOrEmpty(text),
			error = text
		});
	}

	private void CheckEditAttributesPermission(IPageBase page)
	{
		if (!base.SecurityService.HasPermission(EleWise.ELMA.Content.PermissionProvider.ContentAdminPermission) && !base.SecurityService.HasPermission(PageSecurity.EditPagePermission, page))
		{
			throw new SecurityException(SR.T("Недостаточно прав. Необходима одна из следующих привилегий: {0}.", string.Join(", ", EleWise.ELMA.Content.PermissionProvider.ContentAdminPermission.Name, PageSecurity.EditPagePermission.Name)));
		}
	}

	private void CheckConfigurePermission(IPageBase page, PersonalizationScope scope)
	{
		if (base.SecurityService.HasPermission(EleWise.ELMA.Content.PermissionProvider.ContentAdminPermission))
		{
			return;
		}
		switch (scope)
		{
		case PersonalizationScope.Shared:
			if (base.SecurityService.HasPermission(PageSecurity.EditPagePermission, page))
			{
				break;
			}
			goto default;
		default:
			throw new SecurityException(SR.T("Недостаточно прав. Необходима одна из следующих привилегий: {0}.", string.Join(", ", EleWise.ELMA.Content.PermissionProvider.ContentAdminPermission.Name, PageSecurity.EditPagePermission.Name)));
		case PersonalizationScope.User:
			break;
		}
	}

	[HttpGet]
	public ActionResult EditPortletPageAttributes(long id, string activeMenuItemCode)
	{
		IPortletPage portletPage = PortletPageManager.Load(id);
		CheckEditAttributesPermission(portletPage);
		if (!string.IsNullOrEmpty(activeMenuItemCode))
		{
			((Controller)(object)this).SetCurrentMenuItem(activeMenuItemCode);
		}
		PortletPageAttributesModel portletPageAttributesModel = CreatePortletPageAttributesModel(portletPage);
		return (ActionResult)(object)((Controller)this).View((object)portletPageAttributesModel);
	}

	[HttpPost]
	public ActionResult EditPortletPageAttributes([Bind(Prefix = "Page")] IPortletPage page, string ReturnUrl)
	{
		CheckEditAttributesPermission(page);
		if (!((Controller)this).get_ModelState().get_IsValid())
		{
			return (ActionResult)(object)((Controller)this).View((object)CreatePortletPageAttributesModel(page));
		}
		base.Manager.Save(page);
		if (!string.IsNullOrWhiteSpace(ReturnUrl))
		{
			return (ActionResult)(object)((Controller)this).Redirect(ReturnUrl);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", (object)new
		{
			id = page.Id
		});
	}

	private PortletPageAttributesModel CreatePortletPageAttributesModel(IPortletPage portletPage)
	{
		return new PortletPageAttributesModel
		{
			Page = portletPage,
			Layouts = PortletLayouts,
			Themes = Themes()
		};
	}

	private RoleMapPageAttributesModel CreateRoleMapPageAttributesModel(IRoleMapPage roleMapPage)
	{
		return new RoleMapPageAttributesModel
		{
			Page = roleMapPage,
			Shared = false
		};
	}

	private string[] Themes()
	{
		return new string[1] { "ELMA" };
	}

	[HttpGet]
	public ActionResult ConfigurePortletPage(long id, PersonalizationScope scope = PersonalizationScope.Shared, string activeMenuItemCode = null)
	{
		((Controller)(object)this).SetCurrentMenuItem((!string.IsNullOrEmpty(activeMenuItemCode)) ? activeMenuItemCode : "portal-pages");
		IPortletPage portletPage = PortletPageManager.Load(id);
		CheckConfigurePermission(portletPage, scope);
		PortalPageContentModel portalPageContentModel = CreatePageContentModel(portletPage, scope, edit: true);
		return (ActionResult)(object)((Controller)this).View((object)portalPageContentModel);
	}

	[HttpPost]
	public ActionResult ConfigurePortletPage(long id, [Bind(Prefix = "PortalModel")] PortalModel portalModel, string ReturnUrl)
	{
		if (portalModel == null)
		{
			throw new InvalidOperationException();
		}
		IPortletPage portletPage = PortletPageManager.Load(id);
		CheckConfigurePermission(portletPage, portalModel.Scope);
		if (PortletsRestrictionProvider.PortalPageDataPath(portletPage) != portalModel.PersonalPath)
		{
			throw new InvalidOperationException();
		}
		PortletManagerFactory.Create(portalModel.Scope, portalModel.PersonalPath).SavePersonalization(portalModel);
		if (!string.IsNullOrWhiteSpace(ReturnUrl))
		{
			return (ActionResult)(object)((Controller)this).Redirect(ReturnUrl);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", (object)new { id });
	}

	internal static PortalPageContentModel CreatePageContentModel(IPortletPage portletPage, PersonalizationScope scope, bool edit)
	{
		PortletManager serviceNotNull = Locator.GetServiceNotNull<PortletManager>();
		ISecurityService serviceNotNull2 = Locator.GetServiceNotNull<ISecurityService>();
		string text = PortletsRestrictionProvider.PortalPageDataPath(portletPage);
		PortalModel portalModel = new PortalModel();
		portalModel.AllowedAddPortlet = serviceNotNull.AllowedAddPortlet(text);
		portalModel.AllowedEdit = serviceNotNull.AllowedPersonalization(text);
		portalModel.AllowedChangeSharedSettings = serviceNotNull.AllowedChangeSharedSettings(text);
		portalModel.HasPersonalization = serviceNotNull.HasSavedPersonalization(text);
		portalModel.Edit = edit;
		IPortletLayout portletLayout = ComponentManager.Current.GetExtensionPoints<IPortletLayout>().FirstOrDefault((IPortletLayout l) => l.Id == portletPage.PortletsLayoutId);
		if (portletLayout == null)
		{
			throw new InvalidOperationException(SR.T("Нe удалось загрузить шаблон id={0}", portletPage.PortletsLayoutId));
		}
		portalModel.PortletLayout = portletLayout;
		portalModel.PersonalPath = text;
		portalModel.Scope = scope;
		PortletManager portletManager = serviceNotNull.Create(scope, text);
		List<Tuple<string, PortletViewModel>> list = (List<Tuple<string, PortletViewModel>>)(portalModel.ZonePortletViews = (from p in portletManager.GetCurrentPortlets(portletLayout, text)
			orderby p.Personalization.Zone
			select new Tuple<string, PortletViewModel>(p.Personalization.Zone, p)).ToList());
		bool canChangeShared = (scope == PersonalizationScope.Shared || portletManager.AllowedChangeSharedSettings(text)) && (serviceNotNull2.HasPermission(EleWise.ELMA.Content.PermissionProvider.ContentAdminPermission) || serviceNotNull2.HasPermission(PageSecurity.EditPagePermission, portletPage));
		return new PortalPageContentModel
		{
			Page = portletPage,
			PortalModel = portalModel,
			CanChangeShared = canChangeShared
		};
	}

	public ActionResult ViewPortletPage(long id, PersonalizationScope scope = PersonalizationScope.Shared, string activeMenuItemCode = null)
	{
		if (!string.IsNullOrEmpty(activeMenuItemCode))
		{
			((Controller)(object)this).SetCurrentMenuItem(activeMenuItemCode);
		}
		IPortletPage portletPage = PortletPageManager.Load(id);
		if (!base.SecurityService.HasPermission(EleWise.ELMA.Content.PermissionProvider.ContentAdminPermission) && !base.SecurityService.HasPermission(PageSecurity.ViewPagePermission, portletPage))
		{
			throw new SecurityException();
		}
		PortalPageContentModel portalPageContentModel = CreatePageContentModel(portletPage, scope, edit: false);
		return (ActionResult)(object)((Controller)this).View("ViewPortletPage", (object)portalPageContentModel);
	}

	public ActionResult PortletPageContent(long id, PersonalizationScope scope = PersonalizationScope.Shared)
	{
		PortalPageContentModel portalPageContentModel = CreatePageContentModel(PortletPageManager.Load(id), scope, edit: false);
		return (ActionResult)(object)((Controller)this).PartialView((object)portalPageContentModel);
	}

	[HttpGet]
	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult MoveFolder(long id, string popupId)
	{
		IPageFolder pageFolder = PageFolderManager.Instance.Load(id);
		MoveToFolderModel moveToFolderModel = new MoveToFolderModel
		{
			Entity = pageFolder,
			PopupId = popupId,
			PostAction = "MoveFolder",
			PostController = "Page",
			PostCallback = "pageFolderEditComplete(data)"
		};
		if (pageFolder.Uid == PageFolderManager.HomePagesFolderUid || pageFolder.Uid == PageFolderManager.UserPagesFolderUid)
		{
			moveToFolderModel.Error = true;
			moveToFolderModel.ErrorMessage = MvcHtmlString.Create(SR.T("Нельзя переместить системную папку \"{0}\"", pageFolder.Name));
		}
		return (ActionResult)(object)((Controller)this).PartialView("MoveToFolder", (object)moveToFolderModel);
	}

	[HttpPost]
	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult MoveFolder(MoveToFolderModel model)
	{
		string text = null;
		try
		{
			if (model.Entity == model.Entity.Folder)
			{
				throw new Exception(SR.T("Нельзя перенести папку саму в себя"));
			}
			if (model.Entity != null && PageFolderManager.Instance.IsParentFolder(model.Entity as IPageFolder, model.Entity.Folder))
			{
				throw new Exception(SR.T("Нельзя перенести в папку, являющуюся дочерней"));
			}
			model.Entity.Save();
		}
		catch (Exception ex)
		{
			text = ex.Message;
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = string.IsNullOrEmpty(text),
			id = model.Entity.Id,
			error = text,
			popupId = model.PopupId
		}, "text/html");
	}

	[HttpGet]
	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult Move(long id, string popupId)
	{
		IPageBase entity = PageBaseManager.Instance.Load(id);
		MoveToFolderModel moveToFolderModel = new MoveToFolderModel
		{
			Entity = entity,
			PopupId = popupId,
			PostAction = "Move",
			PostController = "Page",
			PostCallback = "pageMoveComplete(data)"
		};
		return (ActionResult)(object)((Controller)this).PartialView("MoveToFolder", (object)moveToFolderModel);
	}

	[HttpPost]
	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult Move(MoveToFolderModel model)
	{
		string text = null;
		try
		{
			model.Entity.Save();
		}
		catch (Exception ex)
		{
			text = ex.Message;
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = string.IsNullOrEmpty(text),
			id = model.Entity.Id,
			folderId = ((model.Entity.Folder != null) ? new long?(model.Entity.Folder.Id) : null),
			error = text,
			popupId = model.PopupId
		}, "text/html");
	}
}
