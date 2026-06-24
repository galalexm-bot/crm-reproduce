using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Attributes;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Binders;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Models.Selectors;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.CRM.Web.Controllers;

[Permission("{46401803-1B46-4E60-8DA0-227FF8CF60F3}")]
[RouteArea("EleWise.ELMA.CRM.Web")]
public class ContractorController : FilterTreeBaseController<IContractor, long>
{
	public IUnionComplexCacheService ComplexCacheService { get; set; }

	protected override string GridIdPrefix => "ContractorsGrid";

	protected override bool EnableEqlQuery => true;

	[ContentItem(Name = "SR.M('Контрагенты')", Image24 = "#contractors.svg")]
	[FilterMenuItem(Id = "crm-contractors", Type = typeof(IContractor), FilterEditAction = "EditFilters")]
	public ActionResult Index(long? FilterId = null)
	{
		ActionResult val = BaseIndex(FilterId);
		if (val != null)
		{
			return val;
		}
		FilterModel filter = CreateFilter(FilterId);
		GridDataFilter<IContractor> gridDataFilter = CreateGridData(null, filter);
		return (ActionResult)(object)((Controller)this).View((object)gridDataFilter);
	}

	public ActionResult Search(long? FilterId = null)
	{
		if (((Controller)this).get_Request().QueryString.Count == 0)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
		}
		FilterModel filter = CreateFilter(FilterId);
		GridDataFilter<IContractor> gridDataFilter = CreateGridData(null, filter);
		return (ActionResult)(object)((Controller)this).View("Index", (object)gridDataFilter);
	}

	[DetailsAction]
	[EntityLink]
	public ActionResult Details(long id)
	{
		IContractor contractor = ContractorManager.Instance.Load(id);
		ThrowExceptionIfDeleted(contractor);
		string text = ((Controller)this).get_Url().Entity(contractor);
		if (((Controller)this).get_Request().RawUrl == text)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("ViewItem", "Catalogs", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Common",
				uid = contractor.TypeUid,
				id = id
			});
		}
		return (ActionResult)(object)((Controller)this).Redirect(text);
	}

	[HttpGet]
	[Permission("{dde5667e-bc3f-458c-abb6-2d693f6ffec2}")]
	public ActionResult Delete(long[] contractorsId, string popupId)
	{
		List<IContractor> contractors = contractorsId.Select((long id) => ContractorManager.Instance.Load(id)).ToList();
		if (contractorsId.Length != 0)
		{
			return (ActionResult)(object)((Controller)this).PartialView("DeleteGroup", (object)new GroupContractorInfo
			{
				Contractors = contractors,
				PopupId = popupId
			});
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Contractor");
	}

	[HttpPost]
	[Permission("{dde5667e-bc3f-458c-abb6-2d693f6ffec2}")]
	[TransactionAction]
	public ActionResult Delete(GroupContractorInfo contactsInfo)
	{
		if (ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
		{
			base.Notifier.Information(SR.T("Производится перерасчет разрешений. Изменение заблокировано. Пожалуйста попробуйте позже."));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Contractor");
		}
		int count = contactsInfo.Contractors.Count;
		contactsInfo.Contractors.ForEach(delegate(IContractor m)
		{
			ContractorManager.Instance.Load(m.Id).Delete();
		});
		base.Notifier.Information(SR.T("Удалено {0} контрагентов", count));
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Contractor");
	}

	public JsonResult Select(string text, int max = 100, string filterProviderUid = null, string filterProviderData = null)
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		IContractorFilter contractorFilter = InterfaceActivator.Create<IContractorFilter>();
		contractorFilter.SearchString = text;
		if (!string.IsNullOrEmpty(filterProviderUid))
		{
			Guid uid = new Guid(filterProviderUid);
			ComponentManager.Current.GetExtensionPoints<IEntityFilterProvider>().First((IEntityFilterProvider p) => p.ProviderUid == uid).ApplyFilter(contractorFilter, filterProviderData);
		}
		AutoCompleteContractorItem[] items = AutoCompleteContractorItem.GetItems(base.Manager.Find(contractorFilter, new FetchOptions(0, max, LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor u) => u.Name)))));
		JsonResult val = new JsonResult();
		val.set_Data((object)items);
		val.set_JsonRequestBehavior((JsonRequestBehavior)0);
		return val;
	}

	public static dynamic CreateEntitySelectRouteValues(ViewAttributes viewAttributes)
	{
		return CreateEntitySelectRouteValues((viewAttributes.EntityFilterProvider != Guid.Empty) ? viewAttributes.EntityFilterProvider.ToString() : null, viewAttributes.EntityFilterData);
	}

	public static dynamic CreateEntitySelectRouteValues(string filterProviderUid, string filterProviderData)
	{
		dynamic val = new ExpandoObject();
		val.area = "EleWise.ELMA.CRM.Web";
		if (!string.IsNullOrEmpty(filterProviderUid))
		{
			val.filterProviderUid = filterProviderUid;
			val.filterProviderData = filterProviderData;
		}
		return val;
	}

	public ActionResult PopupEntity(string inputId, [JsonBinder] ICollection<SelectListItem> selected, bool multiselect, string filterProviderUid = null, string filterProviderData = null)
	{
		if (string.IsNullOrEmpty(inputId))
		{
			throw new ArgumentNullException("inputId");
		}
		IContractorFilter filter = InterfaceActivator.Create<IContractorFilter>();
		if (!string.IsNullOrEmpty(filterProviderUid))
		{
			Guid uid = new Guid(filterProviderUid);
			ComponentManager.Current.GetExtensionPoints<IEntityFilterProvider>().First((IEntityFilterProvider p) => p.ProviderUid == uid).ApplyFilter(filter, filterProviderData);
		}
		ICollection<IContractor> source = base.Manager.Find(filter, FetchOptions.All);
		EntityPopupSelectorModel model = new EntityPopupSelectorModel
		{
			InputId = inputId,
			SelectedItems = ((selected != null) ? selected.ToList() : new List<SelectListItem>()),
			MultiSelect = multiselect,
			AvalibleItems = (from i in ((IEnumerable<IContractor>)source).Select((Func<IContractor, SelectListItem>)delegate(IContractor i)
				{
					//IL_0000: Unknown result type (might be due to invalid IL or missing references)
					//IL_0005: Unknown result type (might be due to invalid IL or missing references)
					//IL_0016: Unknown result type (might be due to invalid IL or missing references)
					//IL_0023: Expected O, but got Unknown
					SelectListItem val = new SelectListItem();
					val.set_Value(i.GetId().ToString());
					val.set_Text(i.ToString());
					return val;
				})
				where !string.IsNullOrEmpty(i.get_Text())
				select i).ToList()
		};
		if (model.SelectedItems.Any())
		{
			if (multiselect)
			{
				model.AvalibleItems = model.AvalibleItems.Where((SelectListItem a) => !model.SelectedItems.Any((SelectListItem s) => s.get_Value() == a.get_Value())).ToList();
			}
			else
			{
				model.AvalibleItems.First((SelectListItem a) => a.get_Value() == model.SelectedItems.First().get_Value()).set_Selected(true);
			}
		}
		model.AvalibleItems = model.AvalibleItems.OrderBy((SelectListItem i) => i.get_Text()).ToList();
		return (ActionResult)(object)((Controller)this).PartialView("EditorTemplates/Entities/PopupEntity", (object)model);
	}

	private ActionResult SelectPermission(IContractor instance)
	{
		ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
		bool inheritAvailable = serviceNotNull.HasPermission(CRMPermissionProvider.CRMContractorIssuanceElementPermission, instance) || serviceNotNull.HasPermission(CRMPermissionProvider.CRMContractorFullAccessPermission, instance) || serviceNotNull.HasPermission(CRMPermissionProvider.CRMFullAccessPermission);
		CRMPermissionModel cRMPermissionModel = new CRMPermissionModel();
		cRMPermissionModel.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
		Action<EntityPermissionRoleTypeSelectorModel> obj = delegate(EntityPermissionRoleTypeSelectorModel m)
		{
			m.Routes = new RouteValueDictionary(new
			{
				action = "PermissionSettings",
				controller = "Contractor",
				area = "EleWise.ELMA.CRM.Web"
			});
		};
		cRMPermissionModel.Id = instance.Id;
		Dictionary<Guid, Guid> participantWorkOne = new Dictionary<Guid, Guid>();
		Dictionary<Guid, Guid> InformsOne = new Dictionary<Guid, Guid>();
		cRMPermissionModel.AdditionalPermissionsModel = base.PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(instance, InterfaceActivator.TypeOf<IContractor>(), ((Controller)this).get_Url(), delegate(IInstanceSettingsPermissionHolder h)
		{
			if (h is IContractorPersonPermission contractorPersonPermission2 && contractorPersonPermission2.User == null && contractorPersonPermission2.Group == null && contractorPersonPermission2.OrganizationItemPosition == null && contractorPersonPermission2.OrganizationItemEmployee == null)
			{
				return false;
			}
			if (!(h is IContractorPersonPermission) || ((IContractorPersonPermission)h).Contractor != instance || ((IContractorPersonPermission)h).InheritedFromNumber.HasValue)
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
		cRMPermissionModel.AdditionalPermissionsModel.Instance = instance;
		if (cRMPermissionModel.LockEditPermission)
		{
			cRMPermissionModel.AdditionalPermissionsModel.Edit = false;
		}
		obj(cRMPermissionModel.AdditionalPermissionsModel);
		participantWorkOne = new Dictionary<Guid, Guid>();
		InformsOne = new Dictionary<Guid, Guid>();
		cRMPermissionModel.InheritAvailable = inheritAvailable;
		cRMPermissionModel.InheritPermissions = instance.InheritPermissions;
		cRMPermissionModel.InheritPermissionsModel = base.PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(instance, InterfaceActivator.TypeOf<IContractor>(), ((Controller)this).get_Url(), delegate(IInstanceSettingsPermissionHolder h)
		{
			if (h is IContractorPersonPermission contractorPersonPermission && contractorPersonPermission.User == null && contractorPersonPermission.Group == null && contractorPersonPermission.OrganizationItemPosition == null && contractorPersonPermission.OrganizationItemEmployee == null)
			{
				return false;
			}
			if (!(h is IContractorPersonPermission) || ((IContractorPersonPermission)h).Contractor != instance || !((IContractorPersonPermission)h).InheritedFromNumber.HasValue)
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
		return (ActionResult)(object)((Controller)this).PartialView("Contractor/ContractorPermissionSetting", (object)cRMPermissionModel);
	}

	[HttpPost]
	public ActionResult EnableInheritPermission(IContractor instance, bool enable)
	{
		if (ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { instance.Id });
		}
		ContractorManager.Instance.EnableInheritPermissions(instance, enable);
		return SelectPermission(instance);
	}

	public ActionResult GetPermissionSettings(IContractor instance)
	{
		return PermissionSettings(instance);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult PermissionSettings(long id, EditableListModel access)
	{
		IContractor instance = ContractorManager.Instance.Load(id);
		if (ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { instance.Id });
		}
		EleWise.ELMA.Security.Models.IUser systemUser = UserManager.Instance.Load(SecurityConstants.SystemUserUid);
		IContractor instanceContractor = instance;
		if (access != null && instanceContractor != null)
		{
			base.PermissionsModelService.BindPermissionsFromModel(instanceContractor, access, delegate(ICollection<IInstanceSettingsPermissionHolder> holders, IEnumerable<IInstanceSettingsPermissionHolder> newHolders)
			{
				List<IInstanceSettingsPermissionHolder> list = newHolders.Where((IInstanceSettingsPermissionHolder e) => e.TypeRoleId != CommonRoleTypes.ParticipantWork.Id && e.TypeRoleId != CommonRoleTypes.Informs.Id).ToList();
				foreach (IInstanceSettingsPermissionHolder item3 in newHolders.Where((IInstanceSettingsPermissionHolder e) => e.TypeRoleId == CommonRoleTypes.ParticipantWork.Id))
				{
					if (instance.ParticipantWork != null)
					{
						list.Add(new InstanceSettingsPermissionHolder
						{
							Assigned = systemUser,
							PermissionId = item3.PermissionId,
							Target = item3.Target,
							TypeRoleId = item3.TypeRoleId
						});
						if (((ICollection<EleWise.ELMA.Security.Models.IUser>)instance.ParticipantWork).Count > 0)
						{
							foreach (EleWise.ELMA.Security.Models.IUser item4 in (IEnumerable<EleWise.ELMA.Security.Models.IUser>)instance.ParticipantWork)
							{
								InstanceSettingsPermissionHolder item = new InstanceSettingsPermissionHolder
								{
									Assigned = item4,
									PermissionId = item3.PermissionId,
									Target = item3.Target,
									TypeRoleId = item3.TypeRoleId
								};
								list.Add(item);
							}
						}
					}
				}
				foreach (IInstanceSettingsPermissionHolder item5 in newHolders.Where((IInstanceSettingsPermissionHolder e) => e.TypeRoleId == CommonRoleTypes.Informs.Id))
				{
					if (item5 != null && instance.Informs != null)
					{
						list.Add(new InstanceSettingsPermissionHolder
						{
							Assigned = systemUser,
							PermissionId = item5.PermissionId,
							Target = item5.Target,
							TypeRoleId = item5.TypeRoleId
						});
						foreach (EleWise.ELMA.Security.Models.IUser item6 in (IEnumerable<EleWise.ELMA.Security.Models.IUser>)instance.Informs)
						{
							InstanceSettingsPermissionHolder item2 = new InstanceSettingsPermissionHolder
							{
								Assigned = item6,
								PermissionId = item5.PermissionId,
								Target = item5.Target,
								TypeRoleId = item5.TypeRoleId
							};
							list.Add(item2);
						}
					}
				}
				List<IInstanceSettingsPermissionHolder> list2 = new List<IInstanceSettingsPermissionHolder>();
				if (instanceContractor.InheritPermissions)
				{
					list2.AddRange(holders.Where((IInstanceSettingsPermissionHolder h) => ((IContractorPersonPermission)h).InheritedFromNumber.HasValue));
					foreach (IInstanceSettingsPermissionHolder item7 in list2)
					{
						holders.Remove(item7);
					}
				}
				holders.SyncFrom(list, (IInstanceSettingsPermissionHolder v1, IInstanceSettingsPermissionHolder v2) => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals(v1.Assigned, v2.Assigned), null, delegate(IInstanceSettingsPermissionHolder v)
				{
					if (v is IEntity)
					{
						((IEntity)v).Delete();
					}
				});
				if (instanceContractor.InheritPermissions)
				{
					foreach (IInstanceSettingsPermissionHolder item8 in list2)
					{
						holders.Add(item8);
					}
				}
			});
		}
		string text = ((Controller)this).get_Url().ReturnUrl();
		return (ActionResult)(object)((Controller)this).Redirect(text);
	}

	public ActionResult PermissionSettings(IContractor instance)
	{
		return SelectPermission(instance);
	}
}
