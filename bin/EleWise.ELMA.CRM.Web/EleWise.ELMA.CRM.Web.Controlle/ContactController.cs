using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Cache;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Attributes;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Html.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers;

[Permission("{46401803-1B46-4E60-8DA0-227FF8CF60F3}")]
[RouteArea("EleWise.ELMA.CRM.Web")]
public class ContactController : FilterTreeBaseController<IContact, long>
{
	public new const string DataFilterPrefix = "DataFilter";

	private ICountry defaultCountry = Locator.GetService<CrmSettingsModule>().Settings.DefaultCountry;

	public IUnionComplexCacheService ComplexCacheService { get; set; }

	protected override string GridIdPrefix => "Contacts";

	protected override bool EnableEqlQuery => true;

	[ContentItem(Name = "SR.M('Контакты')", Image24 = "#contact.svg")]
	[FilterMenuItem(Id = "crm-contacts", Type = typeof(IContact), FilterEditAction = "EditFilters")]
	public ActionResult Index(long? FilterId = null)
	{
		ActionResult val = BaseIndex(FilterId);
		if (val != null)
		{
			return val;
		}
		FilterModel filter = CreateFilter(FilterId);
		GridDataFilter<IContact> gridDataFilter = CreateGridData(null, filter);
		return (ActionResult)(object)((Controller)this).View((object)gridDataFilter);
	}

	public ActionResult Search(long? FilterId = null)
	{
		if (((Controller)this).get_Request().QueryString.Count == 0)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
		}
		FilterModel filter = CreateFilter(FilterId);
		GridDataFilter<IContact> gridDataFilter = CreateGridData(null, filter);
		return (ActionResult)(object)((Controller)this).View("Index", (object)gridDataFilter);
	}

	[CustomGridAction]
	public ActionResult GridTable(GridCommand command, CustomGridCommand customCommand, ContactGrid grid)
	{
		IContactFilter contactFilter = InterfaceActivator.Create<IContactFilter>();
		if (grid.ContractorId > 0)
		{
			IContractor contractor2 = (contactFilter.Contractor = ContractorManager.Instance.Load(grid.ContractorId));
		}
		grid.Data = base.Manager.CreateGridData(command, contactFilter);
		return (ActionResult)(object)((Controller)this).PartialView((object)grid);
	}

	public static void InitNewModel(ContactModel model)
	{
		InitNewModel(model, contactWasNull: true);
	}

	private static void InitNewModel(ContactModel model, bool contactWasNull)
	{
		if (contactWasNull)
		{
			model.Entity.Email.Add(InterfaceActivator.Create<IEmail>());
			model.Entity.Phone.Add(InterfaceActivator.Create<IPhone>());
		}
	}

	[EntityForm("Create", "EleWise.ELMA.CRM.Web")]
	[Permission("{6ED5408C-9BB5-4EA5-950A-D6047957D8DE}")]
	public ActionResult CreatePopup([ParameterContainer] IContact contact, Guid? formUid = null, ViewType? viewType = null, bool formReadOnly = false, string parentFormId = "", string formId = "")
	{
		ContactModel contactModel = new ContactModel(contact, (!viewType.HasValue) ? ViewType.Create : viewType.Value)
		{
			FormUid = formUid,
			FormId = formId,
			FormReadOnly = formReadOnly
		};
		contactModel.DynamicFormSettings.ParentFormId = parentFormId;
		DynamicFormSettings dynamicFormSettings = contactModel.DynamicFormSettings;
		dynamicFormSettings.ViewItemId = dynamicFormSettings.ViewItemId + ";" + contactModel.View.Uid;
		InitNewModel(contactModel, contact == null);
		return (ActionResult)(object)((Controller)this).PartialView("Contact/ContactEditForm", (object)contactModel);
	}

	[ContactCreate]
	[ContentItem(Name = "SR.M('Создать контакт')", Image24 = "#add.svg")]
	[Permission("{6ED5408C-9BB5-4EA5-950A-D6047957D8DE}")]
	public ActionResult Create(long ContractorId = 0L)
	{
		ContactModel contactModel = new ContactModel();
		InitNewModel(contactModel);
		contactModel.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
		if (contactModel.LockEditPermission)
		{
			base.Notifier.Error(SR.T("Производится перерасчет разрешений. Изменение заблокировано. Пожалуйста попробуйте позже."));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Contact", (object)new
			{
				area = "EleWise.ELMA.CRM.Web"
			});
		}
		if (defaultCountry != null)
		{
			IAddress address = EntityManager<IAddress>.Instance.Create();
			address.Country = defaultCountry;
			contactModel.Entity.RegistrationAddress = address;
			IAddress address2 = EntityManager<IAddress>.Instance.Create();
			address2.Country = defaultCountry;
			contactModel.Entity.ResidenceAddress = address2;
		}
		if (ContractorId > 0)
		{
			contactModel.Entity.Contractor = ContractorManager.Instance.Load(ContractorId);
		}
		return (ActionResult)(object)((Controller)this).View((object)contactModel);
	}

	[HttpPost]
	[Permission("{6ED5408C-9BB5-4EA5-950A-D6047957D8DE}")]
	public ActionResult Create(ContactModel model)
	{
		try
		{
			model.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
			if (model.LockEditPermission)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { model.Entity.Id });
			}
			model.Save();
			string text = ((Controller)this).get_Url().Entity(model.Entity);
			base.Notifier.Information(MvcHtmlString.Create(SR.T("Контакт <a href=\"{1}\">{0}</a> сохранен успешно", model.Entity.Name.HtmlEncode(), text)));
			if (IsCustomViewRequest())
			{
				return HandleCustomViewJsonCallback(model.Entity);
			}
			return (ActionResult)((!IsCreatorRequest()) ? ((object)((Controller)this).RedirectToAction("Details", (object)new
			{
				id = model.Entity.Id
			})) : ((object)CreatorJson(model.Entity)));
		}
		catch (Exception ex)
		{
			FormNotifierExtensions.Error(base.Notifier, ex);
			return (ActionResult)((!IsCreatorRequest()) ? ((object)((Controller)this).View((object)model)) : ((object)CreatorJson(null, ex.Message)));
		}
	}

	[DetailsAction]
	[EntityLink]
	public ActionResult Details(long id, int? tabIndex = 0)
	{
		try
		{
			if (tabIndex.HasValue && DirectoryMapVirtualPathProvider.AnyConfigFile("~/Modules/EleWise.ELMA.CRM.Web/Views/Contact/TasksTab.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Contact/TasksTab.cshtml"))
			{
				((ControllerBase)this).get_ViewData().set_Item("SelectedTab", (object)tabIndex.Value);
			}
			IContact contact = base.Manager.Load(id);
			ThrowExceptionIfDeleted(contact);
			ContactModel contactModel = new ContactModel(contact, ViewType.Display);
			contactModel.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
			return (ActionResult)(object)((Controller)this).View((object)contactModel);
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Contact");
		}
	}

	public ActionResult Edit(long id)
	{
		try
		{
			IContact contact = base.Manager.Load(id);
			ThrowExceptionIfDeleted(contact);
			ContactModel contactModel = new ContactModel(contact, ViewType.Edit);
			if (!base.SecurityService.HasPermission(CRMPermissionProvider.EditContactPermission, contact))
			{
				throw new SecurityException(SR.T("Недостаточно прав для редактирования контакта \"{0}\" с идентификатором {1}", contact.Name, contact.Id));
			}
			contactModel.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
			if (contactModel.LockEditPermission)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { id });
			}
			return (ActionResult)(object)((Controller)this).View((object)contactModel);
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Contact");
		}
	}

	[HttpPost]
	public ActionResult Edit(ContactModel model)
	{
		try
		{
			model.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
			if (model.LockEditPermission)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { model.Entity.Id });
			}
			model.Save();
			string text = ((Controller)this).get_Url().Entity(model.Entity);
			base.Notifier.Information(MvcHtmlString.Create(SR.T("Контакт <a href=\"{3}\">{0} {1} {2}</a> сохранен успешно", model.Entity.Firstname.HtmlEncode(), model.Entity.Surname.HtmlEncode(), model.Entity.Middlename.HtmlEncode(), text)));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new
			{
				id = model.Entity.Id
			});
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).View((object)model);
		}
	}

	[AsyncViewItemAction]
	public ActionResult AsyncViewItem(Guid viewItemUid, long id, ViewType viewType, Guid? formUid)
	{
		ContactModel contactModel = new ContactModel(base.Manager.LoadOrCreate(id), viewType);
		contactModel.FormUid = formUid;
		return AsyncViewItemView(contactModel.View, viewType, viewItemUid, contactModel, (ContactModel m) => m.Entity);
	}

	[HttpGet]
	[Permission("{dde5667e-bc3f-458c-abb6-2d693f6ffec2}")]
	public ActionResult Delete(long id)
	{
		try
		{
			IContact contact = base.Manager.Load(id);
			base.Manager.Delete(contact);
			base.Notifier.Information(SR.T("Контакт \"{0} {1} {2}\" удален", contact.Firstname, contact.Surname, contact.Middlename));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Contact", (object)new
			{
				area = "EleWise.ELMA.CRM.Web"
			});
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Contact", (object)new
			{
				area = "EleWise.ELMA.CRM.Web"
			});
		}
	}

	[HttpGet]
	[Permission("{dde5667e-bc3f-458c-abb6-2d693f6ffec2}")]
	public ActionResult DeleteGroup(long[] contactsId, string popupId)
	{
		List<IContact> contacts = contactsId.Select((long id) => ContactManager.Instance.Load(id)).ToList();
		if (contactsId.Length != 0)
		{
			return (ActionResult)(object)((Controller)this).PartialView((object)new GroupContactInfo
			{
				Contacts = contacts,
				PopupId = popupId
			});
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Contact");
	}

	[HttpPost]
	[Permission("{dde5667e-bc3f-458c-abb6-2d693f6ffec2}")]
	public ActionResult DeleteGroup(GroupContactInfo contactsInfo)
	{
		contactsInfo.Contacts.ForEach(delegate(IContact m)
		{
			ContactManager.Instance.Load(m.Id).Delete();
		});
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Contact", (object)new
		{
			area = "EleWise.ELMA.CRM.Web"
		});
	}

	public ActionResult DetailsForm(long id)
	{
		IContact contact = ContactManager.Instance.Load(id);
		return (ActionResult)(object)((Controller)this).PartialView((object)contact);
	}

	private ActionResult SelectPermission(IContact instance)
	{
		ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
		bool inheritAvailable = serviceNotNull.HasPermission(CRMPermissionProvider.CRMContactIssuanceElementPermission, instance) || serviceNotNull.HasPermission(CRMPermissionProvider.CRMContactFullAccessPermission, instance) || serviceNotNull.HasPermission(CRMPermissionProvider.CRMFullAccessPermission);
		CRMPermissionModel cRMPermissionModel = new CRMPermissionModel();
		cRMPermissionModel.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
		Action<EntityPermissionRoleTypeSelectorModel> obj = delegate(EntityPermissionRoleTypeSelectorModel m)
		{
			m.Routes = new RouteValueDictionary(new
			{
				action = "PermissionSettings",
				controller = "Contact",
				area = "EleWise.ELMA.CRM.Web"
			});
		};
		cRMPermissionModel.Id = instance.Id;
		Dictionary<Guid, Guid> participantWorkOne = new Dictionary<Guid, Guid>();
		Dictionary<Guid, Guid> InformsOne = new Dictionary<Guid, Guid>();
		cRMPermissionModel.AdditionalPermissionsModel = base.PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(instance, InterfaceActivator.TypeOf<IContact>(), ((Controller)this).get_Url(), delegate(IInstanceSettingsPermissionHolder h)
		{
			if (!(h is IContactPersonPermission) || ((IContactPersonPermission)h).Contact != instance || ((IContactPersonPermission)h).InheritedFromNumber.HasValue)
			{
				return false;
			}
			if (h.TypeRoleId == CommonRoleTypes.ParticipantWork.Id)
			{
				if (!participantWorkOne.ContainsKey(h.PermissionId))
				{
					participantWorkOne.Add(h.PermissionId, h.PermissionId);
					return true;
				}
				return false;
			}
			if (h.TypeRoleId == CommonRoleTypes.Informs.Id)
			{
				if (!InformsOne.ContainsKey(h.PermissionId))
				{
					InformsOne.Add(h.PermissionId, h.PermissionId);
					return true;
				}
				return false;
			}
			return true;
		});
		if (cRMPermissionModel.LockEditPermission)
		{
			cRMPermissionModel.AdditionalPermissionsModel.Edit = false;
		}
		cRMPermissionModel.AdditionalPermissionsModel.Instance = instance;
		cRMPermissionModel.AdditionalPermissionsModel.BindModelName = "additionalPermissions";
		cRMPermissionModel.AdditionalPermissionsModel.NoForm = false;
		obj(cRMPermissionModel.AdditionalPermissionsModel);
		cRMPermissionModel.InheritAvailable = true;
		cRMPermissionModel.InheritAvailable = inheritAvailable;
		participantWorkOne = new Dictionary<Guid, Guid>();
		InformsOne = new Dictionary<Guid, Guid>();
		cRMPermissionModel.InheritPermissions = instance.InheritPermissions;
		cRMPermissionModel.InheritPermissionsModel = base.PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(instance, InterfaceActivator.TypeOf<IContact>(), ((Controller)this).get_Url(), delegate(IInstanceSettingsPermissionHolder h)
		{
			if (!(h is IContactPersonPermission) || ((IContactPersonPermission)h).Contact != instance || !((IContactPersonPermission)h).InheritedFromNumber.HasValue)
			{
				return false;
			}
			if (h.TypeRoleId == CommonRoleTypes.ParticipantWork.Id)
			{
				if (!participantWorkOne.ContainsKey(h.PermissionId))
				{
					participantWorkOne.Add(h.PermissionId, h.PermissionId);
					return true;
				}
				return false;
			}
			if (h.TypeRoleId == CommonRoleTypes.Informs.Id)
			{
				if (!InformsOne.ContainsKey(h.PermissionId))
				{
					InformsOne.Add(h.PermissionId, h.PermissionId);
					return true;
				}
				return false;
			}
			return true;
		});
		cRMPermissionModel.InheritPermissionsModel.BindModelName = "InheritPermissions";
		cRMPermissionModel.InheritPermissionsModel.Instance = instance;
		cRMPermissionModel.InheritPermissionsModel.Edit = false;
		return (ActionResult)(object)((Controller)this).PartialView("Contact/ContactPermissionSetting", (object)cRMPermissionModel);
	}

	[HttpPost]
	public ActionResult EnableInheritPermission(IContact instance, bool enable)
	{
		if (ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { instance.Id });
		}
		ContactManager.Instance.EnableInheritPermissions(instance, enable);
		return SelectPermission(instance);
	}

	public ActionResult GetPermissionSettings(IContact instance)
	{
		return PermissionSettings(instance);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult PermissionSettings(long id, EditableListModel additionalPermissions)
	{
		IContact ContactInstance = ContactManager.Instance.Load(id);
		if (additionalPermissions != null && ContactInstance != null)
		{
			base.PermissionsModelService.BindPermissionsFromModel(ContactInstance, additionalPermissions, delegate(ICollection<IInstanceSettingsPermissionHolder> holders, IEnumerable<IInstanceSettingsPermissionHolder> newHolders)
			{
				List<IInstanceSettingsPermissionHolder> list = new List<IInstanceSettingsPermissionHolder>();
				if (ContactInstance.InheritPermissions)
				{
					list.AddRange(holders.Where((IInstanceSettingsPermissionHolder h) => ((IContactPersonPermission)h).InheritedFromNumber.HasValue));
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
				if (ContactInstance.InheritPermissions)
				{
					foreach (IInstanceSettingsPermissionHolder item2 in list)
					{
						holders.Add(item2);
					}
				}
			});
		}
		string text = ((Controller)this).get_Url().ReturnUrl();
		return (ActionResult)(object)((Controller)this).Redirect(text);
	}

	public ActionResult PermissionSettings(IContact instance)
	{
		return SelectPermission(instance);
	}
}
