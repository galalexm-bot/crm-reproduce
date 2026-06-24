using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Extensions;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Attributes;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.CRM.Web.Portlets;
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
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers;

[AllPermissions(new string[] { "{46401803-1B46-4E60-8DA0-227FF8CF60F3}", "{96144EE1-1A52-45C4-9AE7-4FF1AD6A03E8}" })]
[RouteArea("EleWise.ELMA.CRM.Web")]
public class SaleController : FilterTreeBaseController<ISale, long>
{
	public IUnionComplexCacheService ComplexCacheService { get; set; }

	protected override string GridIdPrefix => "Sales";

	protected override bool EnableEqlQuery => true;

	[ContentItem(Name = "SR.M('Сделки')", Image24 = "#sale.svg")]
	[FilterMenuItem(Id = "crm-salies", Type = typeof(ISale), FilterEditAction = "EditFilters")]
	public ActionResult Index(long? FilterId = null)
	{
		ActionResult val = BaseIndex(FilterId);
		if (val != null)
		{
			return val;
		}
		FilterModel filter = CreateFilter(FilterId);
		GridDataFilter<ISale> gridDataFilter = CreateGridData(null, filter);
		return (ActionResult)(object)((Controller)this).View((object)gridDataFilter);
	}

	public ActionResult Search(long? FilterId = null)
	{
		if (((Controller)this).get_Request().QueryString.Count == 0)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
		}
		FilterModel filter = CreateFilter(FilterId);
		GridDataFilter<ISale> gridDataFilter = CreateGridData(null, filter);
		return (ActionResult)(object)((Controller)this).View("Index", (object)gridDataFilter);
	}

	[EntityForm("Create", "EleWise.ELMA.CRM.Web")]
	[Permission("{F7D14102-3444-458C-A0B7-7C067D07BDF8}")]
	public ActionResult CreatePopup([ParameterContainer] ISale sale, Guid? formUid = null, ViewType? viewType = null, bool formReadOnly = false, string parentFormId = "", string formId = "")
	{
		SaleModel saleModel = new SaleModel(sale, (!viewType.HasValue) ? ViewType.Create : viewType.Value)
		{
			FormUid = formUid,
			FormReadOnly = formReadOnly,
			FormId = formId
		};
		saleModel.DynamicFormSettings.ParentFormId = parentFormId;
		DynamicFormSettings dynamicFormSettings = saleModel.DynamicFormSettings;
		dynamicFormSettings.ViewItemId = dynamicFormSettings.ViewItemId + ";" + saleModel.View.Uid;
		return (ActionResult)(object)((Controller)this).PartialView("Sale/SaleEditForm", (object)saleModel);
	}

	[SaleCreate]
	[Permission("{F7D14102-3444-458C-A0B7-7C067D07BDF8}")]
	[ContentItem(Name = "SR.M('Создать сделку')", Image24 = "#sale.svg")]
	public ActionResult Create(long? contractorId)
	{
		SaleModel saleModel = new SaleModel();
		saleModel.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
		if (saleModel.LockEditPermission)
		{
			base.Notifier.Error(SR.T("Производится перерасчет разрешений. Изменение заблокировано. Пожалуйста попробуйте позже."));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Sale");
		}
		if (contractorId.HasValue && contractorId > 0)
		{
			IContractor contractor = ContractorManager.Instance.LoadOrNull(contractorId.Value);
			saleModel.Entity.Contractor = contractor;
			saleModel.ContractorReadOnly = true;
		}
		return (ActionResult)(object)((Controller)this).View((object)saleModel);
	}

	[HttpPost]
	[Permission("{F7D14102-3444-458C-A0B7-7C067D07BDF8}")]
	public ActionResult Create(SaleModel model)
	{
		model.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
		if (model.LockEditPermission)
		{
			base.Notifier.Error(SR.T("Производится перерасчет разрешений. Изменение заблокировано. Пожалуйста попробуйте позже."));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Sale");
		}
		model.Entity.Save();
		string text = ((Controller)this).get_Url().Entity(model.Entity);
		base.Notifier.Information(MvcHtmlString.Create(SR.T("Сделка <a href='{1}'>\"{0}\"</a> сохранена успешно", model.Entity.Name.HtmlEncode(), text)));
		if (IsCustomViewRequest())
		{
			return HandleCustomViewJsonCallback(model.Entity);
		}
		if (IsCreatorRequest())
		{
			return CreatorJson(model.Entity);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Details", "Sale", (object)new
		{
			id = model.Entity.Id
		});
	}

	[DetailsAction]
	[EntityLink]
	public ActionResult Details(long id, int? tabIndex = null)
	{
		try
		{
			if (tabIndex.HasValue && DirectoryMapVirtualPathProvider.AnyConfigFile("~/Modules/EleWise.ELMA.CRM.Web/Views/Sale/TabView.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Sale/TasksTab.cshtml"))
			{
				((ControllerBase)this).get_ViewData().set_Item("SelectedTab", (object)tabIndex.Value);
			}
			ISale sale = base.Manager.Load(id);
			ThrowExceptionIfDeleted(sale);
			SaleModel saleModel = new SaleModel(sale, ViewType.Display);
			if (sale.IsDeleted)
			{
				base.Notifier.Error(SR.T("Сделка с идентификатором {0} была удалена", id));
				return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Sale");
			}
			saleModel.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
			SetAsReadForFeed(sale);
			return (ActionResult)(object)((Controller)this).View((object)saleModel);
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Sale");
		}
	}

	[AsyncViewItemAction]
	public ActionResult AsyncViewItem(Guid viewItemUid, long id, ViewType viewType, Guid? formUid)
	{
		SaleModel saleModel = new SaleModel(base.Manager.LoadOrCreate(id), viewType);
		saleModel.FormUid = formUid;
		return AsyncViewItemView(saleModel.View, viewType, viewItemUid, saleModel, (SaleModel m) => m.Entity);
	}

	[Permission]
	public ActionResult Edit([InstancePermission(typeof(ISale), "{AF2CEF4B-F639-49B4-BD88-363F20BD5A74}")] long id)
	{
		try
		{
			ISale sale = base.Manager.Load(id);
			SaleModel saleModel = new SaleModel(sale, ViewType.Edit);
			ThrowExceptionIfDeleted(sale);
			saleModel.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
			if (saleModel.LockEditPermission)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { id });
			}
			return (ActionResult)(object)((Controller)this).View((object)saleModel);
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Sale");
		}
	}

	[HttpPost]
	[Permission]
	public ActionResult Edit([InstancePermission("{AF2CEF4B-F639-49B4-BD88-363F20BD5A74}")] SaleModel model)
	{
		model.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
		if (model.LockEditPermission)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { model.Entity.Id });
		}
		model.Entity.Save();
		string text = ((Controller)this).get_Url().Entity(model.Entity);
		base.Notifier.Information(MvcHtmlString.Create(SR.T("Сделка <a href='{1}'>\"{0}\"</a> сохранена успешно", model.Entity.Name.HtmlEncode(), text)));
		return (ActionResult)(object)((Controller)this).RedirectToAction("Details", "Sale", (object)new
		{
			id = model.Entity.Id
		});
	}

	[HttpGet]
	[Permission("{dde5667e-bc3f-458c-abb6-2d693f6ffec2}")]
	public ActionResult Delete(long id)
	{
		try
		{
			ISale sale = base.Manager.Load(id);
			base.Manager.Delete(sale);
			base.Notifier.Information(SR.T("Сделка \"{0}\" удалена", sale.Name));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Sale", (object)new
			{
				area = "EleWise.ELMA.CRM.Web"
			});
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Sale", (object)new
			{
				area = "EleWise.ELMA.CRM.Web"
			});
		}
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult ChangeStatus(SaleChangeStatusModel model)
	{
		ISale sale = SaleManager.Instance.Load(model.EntityId);
		if (model.Status == sale.SaleStatus && model.ShortStatus == sale.ShortStatus)
		{
			base.Notifier.Information(SR.T("Сделка уже имеет данный статус"));
			return (ActionResult)(object)((Controller)this).Redirect(model.RedirectUrl);
		}
		ComponentManager.Current.GetExtensionPoints<IActionWebHandler>().ToList().ForEach(delegate(IActionWebHandler p)
		{
			p.Process(this, "ChangeStatus", ((ControllerBase)this).get_ValueProvider(), model);
		});
		if (!model.Break)
		{
			sale.ShortStatus = model.ShortStatus;
			SaleManager.Instance.ChangeStatus(sale, model.Status, model.Comment);
		}
		return (ActionResult)(object)((Controller)this).Redirect(model.RedirectUrl);
	}

	[HttpPost]
	public ActionResult ChangeStage(SaleChangeStageModel model)
	{
		ISale sale = SaleManager.Instance.Load(model.EntityId);
		if (model.Stage == sale.SaleStage)
		{
			base.Notifier.Information("Сделка уже находится на данной стадии");
			return (ActionResult)(object)((Controller)this).Redirect(model.RedirectUrl);
		}
		ComponentManager.Current.GetExtensionPoints<IActionWebHandler>().ToList().ForEach(delegate(IActionWebHandler p)
		{
			p.Process(this, "ChangeStage", ((ControllerBase)this).get_ValueProvider(), model);
		});
		if (!model.Break)
		{
			sale.ShortStatus = model.ShortStatus;
			SaleManager.Instance.ChangeStage(sale, model.Stage, model.Comment);
		}
		return (ActionResult)(object)((Controller)this).Redirect(model.RedirectUrl);
	}

	[CustomGridAction]
	[Permission("{96144EE1-1A52-45C4-9AE7-4FF1AD6A03E8}")]
	public ActionResult SalesOfContractor(GridCommand command, long contractorId)
	{
		IContractor contractor = ContractorManager.Instance.Load(contractorId);
		ISaleFilter saleFilter = InterfaceActivator.Create<ISaleFilter>();
		saleFilter.Contractors.Add(contractor);
		GridData<ISale, ISaleFilter> gridData = base.Manager.CreateGridData(command, saleFilter);
		return (ActionResult)(object)((Controller)this).PartialView("SalesOfContractorGrid", (object)gridData);
	}

	public ActionResult Products(long saleId)
	{
		ISale sale = SaleManager.Instance.Load(saleId);
		ISaleProductFilter saleProductFilter = InterfaceActivator.Create<ISaleProductFilter>();
		saleProductFilter.Sale = sale;
		SaleProductsModel saleProductsModel = new SaleProductsModel(ViewType.Display)
		{
			GridData = EntityManager<ISaleProduct>.Instance.CreateGridData(null, saleProductFilter),
			Sale = sale,
			ReadOnly = sale.SaleClosed()
		};
		if (!saleProductsModel.ReadOnly)
		{
			ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
			saleProductsModel.ReadOnly = !serviceNotNull.HasPermission(CRMPermissionProvider.CRMSaleCreateElementPermission, saleProductsModel.Sale) && !serviceNotNull.HasPermission(CRMPermissionProvider.CRMSaleFullAccessPermission, saleProductsModel.Sale);
		}
		return (ActionResult)(object)((Controller)this).PartialView("SaleProducts/Products", (object)saleProductsModel);
	}

	[CustomGridAction]
	public ActionResult ProductsGrid(GridCommand command, long saleId)
	{
		ISale sale = SaleManager.Instance.Load(saleId);
		ISaleProductFilter saleProductFilter = InterfaceActivator.Create<ISaleProductFilter>();
		saleProductFilter.Sale = sale;
		GridData<ISaleProduct, ISaleProductFilter> gridData = EntityManager<ISaleProduct>.Instance.CreateGridData(command, saleProductFilter);
		((ControllerBase)this).get_ViewData().set_Item("ReadOnly", (object)sale.SaleClosed());
		return (ActionResult)(object)((Controller)this).PartialView("SaleProducts/Grid", (object)gridData);
	}

	public ActionResult DeleteProduct(long productLinkId)
	{
		ISaleProduct saleProduct = EntityManager<ISaleProduct>.Instance.Load(productLinkId);
		long id = saleProduct.Sale.Id;
		saleProduct.Delete();
		return ProductsGrid(null, id);
	}

	public ActionResult CreateProduct(long saleId)
	{
		ISale sale = SaleManager.Instance.Load(saleId);
		SaleProductsModel saleProductsModel = new SaleProductsModel(ViewType.Create);
		saleProductsModel.Entity.Sale = sale;
		return (ActionResult)(object)((Controller)this).PartialView("SaleProducts/EditProduct", (object)saleProductsModel);
	}

	[HttpPost]
	public ActionResult AddProduct(SaleProductsModel model)
	{
		model.Entity.Save();
		return SuccessJson();
	}

	public ActionResult EditProduct(ISaleProduct productLink)
	{
		SaleProductsModel saleProductsModel = new SaleProductsModel(ViewType.Edit);
		saleProductsModel.Entity = productLink;
		return (ActionResult)(object)((Controller)this).PartialView("SaleProducts/EditProduct", (object)saleProductsModel);
	}

	[HttpPost]
	public ActionResult SaveEditedProduct(SaleProductsModel productLink)
	{
		productLink.Entity.Save();
		return SuccessJson();
	}

	[HttpPost]
	public ActionResult SummaryTable([Bind(Prefix = "DataFilter")] FilterModel filter = null)
	{
		IEnumerable<SalesVolumesInfo> enumerable = from x in SaleManager.Instance.SalesVolumeByCurrency(filter?.Filter)
			select new SalesVolumesInfo
			{
				Currency = x.Key,
				Volume = x.Value
			};
		return (ActionResult)(object)((Controller)this).PartialView((object)enumerable);
	}

	[HttpGet]
	public ActionResult SalePortlet(SalePortletPersonalization settings)
	{
		SalePortletModel salePortletModel = new SalePortletModel
		{
			FilterId = ((settings.Filter != null) ? new long?(settings.Filter.Id) : null),
			ShowOnlyMy = settings.ShowOnlyMy
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)salePortletModel);
	}

	[CustomGridAction]
	public ActionResult PortletGrid(GridCommand command, long? filterId, bool showOnlyMy)
	{
		FilterModel filterModel = CreateFilter(filterId);
		((ISaleFilter)filterModel.Filter).ShowOnlyMy = showOnlyMy;
		GridDataFilter<ISale> gridDataFilter = CreateGridData(command, filterModel);
		return (ActionResult)(object)((Controller)this).PartialView((object)gridDataFilter);
	}

	private ActionResult SelectPermission(ISale instance)
	{
		ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
		bool inheritAvailable = serviceNotNull.HasPermission(CRMPermissionProvider.CRMSaleIssuanceElementPermission, instance) || serviceNotNull.HasPermission(CRMPermissionProvider.CRMSaleFullAccessPermission, instance) || serviceNotNull.HasPermission(CRMPermissionProvider.CRMFullAccessPermission);
		Dictionary<Guid, Guid> participantWorkOne = new Dictionary<Guid, Guid>();
		Dictionary<Guid, Guid> informsOne = new Dictionary<Guid, Guid>();
		CRMPermissionModel cRMPermissionModel = new CRMPermissionModel();
		cRMPermissionModel.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
		Action<EntityPermissionRoleTypeSelectorModel> obj = delegate(EntityPermissionRoleTypeSelectorModel m)
		{
			m.Routes = new RouteValueDictionary(new
			{
				action = "PermissionSettings",
				controller = "Sale",
				area = "EleWise.ELMA.CRM.Web"
			});
		};
		cRMPermissionModel.Id = instance.Id;
		cRMPermissionModel.AdditionalPermissionsModel = base.PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(instance, InterfaceActivator.TypeOf<ISale>(), ((Controller)this).get_Url(), delegate(IInstanceSettingsPermissionHolder h)
		{
			if (!(h is ISalePersonPermission) || ((ISalePersonPermission)h).Sale != instance || ((ISalePersonPermission)h).InheritedFromNumber.HasValue)
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
				if (!informsOne.ContainsKey(h.PermissionId))
				{
					informsOne.Add(h.PermissionId, h.PermissionId);
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
		obj(cRMPermissionModel.AdditionalPermissionsModel);
		cRMPermissionModel.InheritAvailable = true;
		participantWorkOne = new Dictionary<Guid, Guid>();
		informsOne = new Dictionary<Guid, Guid>();
		cRMPermissionModel.InheritPermissions = instance.InheritPermissions;
		cRMPermissionModel.InheritPermissionsModel = base.PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(instance, InterfaceActivator.TypeOf<ISale>(), ((Controller)this).get_Url(), delegate(IInstanceSettingsPermissionHolder h)
		{
			if (!(h is ISalePersonPermission) || ((ISalePersonPermission)h).Sale != instance || !((ISalePersonPermission)h).InheritedFromNumber.HasValue)
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
				if (!informsOne.ContainsKey(h.PermissionId))
				{
					informsOne.Add(h.PermissionId, h.PermissionId);
					return true;
				}
				return false;
			}
			return true;
		});
		cRMPermissionModel.InheritPermissionsModel.BindModelName = "InheritPermissions";
		cRMPermissionModel.InheritPermissionsModel.Instance = instance;
		cRMPermissionModel.InheritPermissionsModel.Edit = false;
		cRMPermissionModel.InheritAvailable = inheritAvailable;
		return (ActionResult)(object)((Controller)this).PartialView("Sale/SalePermissionSetting", (object)cRMPermissionModel);
	}

	[HttpPost]
	public ActionResult EnableInheritPermission(ISale instance, bool enable)
	{
		if (ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { instance.Id });
		}
		SaleManager.Instance.EnableInheritPermissions(instance, enable);
		return SelectPermission(instance);
	}

	public ActionResult GetPermissionSettings(ISale instance)
	{
		return PermissionSettings(instance);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult PermissionSettings(long id, EditableListModel access)
	{
		ISale instance = SaleManager.Instance.Load(id);
		if (ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { instance.Id });
		}
		if (access != null)
		{
			base.PermissionsModelService.BindPermissionsFromModel(instance, access, delegate(ICollection<IInstanceSettingsPermissionHolder> holders, IEnumerable<IInstanceSettingsPermissionHolder> newHolders)
			{
				List<IInstanceSettingsPermissionHolder> list = new List<IInstanceSettingsPermissionHolder>();
				if (instance.InheritPermissions)
				{
					list.AddRange(holders.Where((IInstanceSettingsPermissionHolder h) => ((ISalePersonPermission)h).InheritedFromNumber.HasValue));
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
		}
		string text = ((Controller)this).get_Url().ReturnUrl();
		return (ActionResult)(object)((Controller)this).Redirect(text);
	}

	public ActionResult PermissionSettings(ISale instance)
	{
		return SelectPermission(instance);
	}
}
