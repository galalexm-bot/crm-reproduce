using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Attributes;
using EleWise.ELMA.CRM.Web.Code;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Models.Boxes;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.CRM.Web.Controllers;

[AllPermissions(new string[] { "{46401803-1B46-4E60-8DA0-227FF8CF60F3}", "{5A9420EC-B6AD-4610-982B-4795E850A72E}" })]
[RouteArea("EleWise.ELMA.CRM.Web")]
public class MarketingActivityController : FilterTreeBaseController<IMarketingBase, long>
{
	public List<string> LocalizedItemsNames => new List<string> { SR.T("Маркетинг") };

	protected override string GridIdPrefix => "MarketingBaseGrid";

	protected override bool EnableEqlQuery => true;

	protected IMarketingBaseFilter CreateFilter()
	{
		InstanceOf<IMarketingBaseFilter> instanceOf = new InstanceOf<IMarketingBaseFilter>();
		instanceOf.New.PermissionId = CRMPermissionProvider.CRMAccessPermission.Id;
		return instanceOf.New;
	}

	[ContentItem(Name = "SR.M('Маркетинг')", Image24 = "#target.svg")]
	[FilterMenuItem(Id = "crm-marketing-aktivities", Type = typeof(IMarketingBase), FilterEditAction = "EditFilters")]
	public ActionResult Index(long? FilterId = null)
	{
		ActionResult val = BaseIndex(FilterId);
		if (val != null)
		{
			return val;
		}
		FilterModel filter = CreateFilter(FilterId);
		GridDataFilter<IMarketingBase> gridDataFilter = CreateGridData(null, filter);
		return (ActionResult)(object)((Controller)this).View((object)gridDataFilter);
	}

	public ActionResult Search(long? FilterId = null)
	{
		if (((Controller)this).get_Request().QueryString.Count == 0)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
		}
		FilterModel filter = CreateFilter(FilterId);
		GridDataFilter<IMarketingBase> gridDataFilter = CreateGridData(null, filter);
		return (ActionResult)(object)((Controller)this).View("Index", (object)gridDataFilter);
	}

	[Permission("{12F5ECDA-DDFF-422F-83DE-BFF4E94ACD1E}")]
	public ActionResult Create(Guid typeUid, long? parentId)
	{
		MarketingActivityModel marketingActivityModel = null;
		bool flag = parentId.HasValue && !base.SecurityService.HasPermission(CRMPermissionProvider.MarketingFullAccessPermission);
		if (typeUid == InterfaceActivator.UID<IMarketingActivity>())
		{
			IMarketingActivity marketingActivity = InterfaceActivator.Create<IMarketingActivity>();
			marketingActivity.Responsible = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			marketingActivity.MarketingGroup = (parentId.HasValue ? MarketingGroupManager.Instance.Load(parentId.Value) : null);
			marketingActivityModel = new MarketingActivityModel(marketingActivity)
			{
				LockParentItem = flag,
				LockResponsible = flag
			};
		}
		else if (typeUid == InterfaceActivator.UID<IMarketingGroup>())
		{
			IMarketingGroup marketingGroup = InterfaceActivator.Create<IMarketingGroup>();
			marketingGroup.Responsible = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			marketingActivityModel = new MarketingActivityModel(marketingGroup);
		}
		else if (typeUid == InterfaceActivator.UID<IMarketingEffect>())
		{
			IMarketingEffect marketingEffect = InterfaceActivator.Create<IMarketingEffect>();
			marketingEffect.MarketingActivity = (parentId.HasValue ? MarketingActivityManager.Instance.Load(parentId.Value) : null);
			marketingEffect.Responsible = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			marketingActivityModel = new MarketingActivityModel(marketingEffect)
			{
				LockParentItem = flag,
				LockResponsible = flag
			};
		}
		marketingActivityModel.Entity.BudgetType = MarketingBudgetType.SumOfChild;
		return (ActionResult)(object)((Controller)this).View((object)marketingActivityModel);
	}

	[HttpPost]
	[Permission("{12F5ECDA-DDFF-422F-83DE-BFF4E94ACD1E}")]
	public ActionResult Create(MarketingActivityModel model)
	{
		try
		{
			model.Save();
			return (ActionResult)(object)((Controller)this).RedirectToAction("Details", "MarketingActivity", (object)new
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

	public ActionResult GetMarketingTags(long id)
	{
		try
		{
			IMarketingBase marketingBase = MarketingBaseManager.Instance.Load(id);
			return (ActionResult)(object)((Controller)this).PartialView("MarketingTagParent", (object)marketingBase);
		}
		catch (Exception ex)
		{
			string message = ex.Message;
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				error = message
			}, "text/html");
		}
	}

	[DetailsAction]
	[EntityLink]
	public ActionResult Details(long id, string selectedTab)
	{
		try
		{
			IMarketingBase marketingBase = base.Manager.Load(id).CastAsRealType();
			((ControllerBase)this).get_ViewData().set_Item("SelectedTab", (object)selectedTab);
			ThrowExceptionIfDeleted(marketingBase);
			return (ActionResult)(object)((Controller)this).View((object)new MarketingActivityModel(marketingBase));
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "MarketingActivity");
		}
	}

	[Permission("{7D45412B-8491-49B7-B033-93FFE3F394E5}")]
	public ActionResult Edit(long id)
	{
		try
		{
			IMarketingBase marketingBase = base.Manager.Load(id).CastAsRealType();
			ThrowExceptionIfDeleted(marketingBase);
			MarketingActivityModel marketingActivityModel = new MarketingActivityModel(marketingBase);
			return (ActionResult)(object)((Controller)this).View((object)marketingActivityModel);
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "MarketingActivity");
		}
	}

	[Permission("{7D45412B-8491-49B7-B033-93FFE3F394E5}")]
	[HttpPost]
	public ActionResult Edit(MarketingActivityModel model)
	{
		try
		{
			model.Save();
			return (ActionResult)(object)((Controller)this).RedirectToAction("Details", "MarketingActivity", (object)new
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

	[HttpGet]
	[Permission("{81B30D9D-42F8-483F-A8D7-EC7E2E0F7CAD}")]
	public ActionResult Delete(long id)
	{
		try
		{
			IMarketingBase marketingBase = base.Manager.Load(id);
			marketingBase.Delete();
			base.Notifier.Information(SR.T("Маркетинговое мероприятие \"{0}\" успешно удалено", marketingBase.Name));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "MarketingActivity", (object)new
			{
				area = "EleWise.ELMA.CRM.Web"
			});
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "MarketingActivity", (object)new
			{
				area = "EleWise.ELMA.CRM.Web"
			});
		}
	}

	[CustomGridAction]
	public ActionResult MarketingActivityContractors(GridCommand command, IMarketingBase marketingBase, string tabId)
	{
		GridData<IContractor> gridData = MarketingActivityRelatedEntitiesFinder.Find<IContractor>(command, marketingBase.CastAsRealType());
		((ControllerBase)this).get_ViewData().set_Item("TabId", (object)tabId);
		return (ActionResult)(object)((Controller)this).PartialView("RelatedMarketingActivityEntities/RelatedContractorsGrid", (object)gridData);
	}

	[CustomGridAction]
	public ActionResult MarketingActivityLeads(GridCommand command, IMarketingBase marketingBase, string tabId)
	{
		GridData<ILead> gridData = MarketingActivityRelatedEntitiesFinder.Find<ILead>(command, marketingBase.CastAsRealType());
		((ControllerBase)this).get_ViewData().set_Item("TabId", (object)tabId);
		return (ActionResult)(object)((Controller)this).PartialView("RelatedMarketingActivityEntities/RelatedLeadsGrid", (object)gridData);
	}

	[CustomGridAction]
	public ActionResult MarketingActivitySales(GridCommand command, IMarketingBase marketingBase, string tabId)
	{
		GridData<ISale> gridData = MarketingActivityRelatedEntitiesFinder.Find<ISale>(command, marketingBase.CastAsRealType());
		((ControllerBase)this).get_ViewData().set_Item("TabId", (object)tabId);
		return (ActionResult)(object)((Controller)this).PartialView("RelatedMarketingActivityEntities/RelatedSalesGrid", (object)gridData);
	}

	[CustomGridAction]
	public ActionResult MarketingActivityStatistic(GridCommand command, IMarketingBase marketingBase, string tabId)
	{
		MarketingStatisticModel marketingStatisticModel = new MarketingStatisticModel(marketingBase, MarketingPeriodEnum.Month, DateTime.Today);
		((ControllerBase)this).get_ViewData().set_Item("TabId", (object)tabId);
		return (ActionResult)(object)((Controller)this).PartialView("MarketingStatistic/MarketingStatisticObject", (object)marketingStatisticModel);
	}

	[CustomGridAction]
	public ActionResult GroupActivitiesGrid(GridCommand command, IMarketingGroup marketingGroup)
	{
		IMarketingActivityFilter marketingActivityFilter = InterfaceActivator.Create<IMarketingActivityFilter>();
		marketingActivityFilter.MarketingGroup = marketingGroup;
		GridData<IMarketingActivity, IMarketingActivityFilter> gridData = AbstractNHEntityManager<IMarketingActivity, long>.Instance.CreateGridData(command, marketingActivityFilter);
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	[CustomGridAction]
	public ActionResult GroupEffectGrid(GridCommand command, IMarketingGroup marketingGroup)
	{
		IMarketingEffectFilter marketingEffectFilter = InterfaceActivator.Create<IMarketingEffectFilter>();
		ICollection<IMarketingEffect> source;
		if (((ICollection<IMarketingActivity>)marketingGroup.MarketingActivities).Count > 0)
		{
			marketingEffectFilter.Query = string.Format("MarketingActivity IN ({0})", string.Join(",", ((IEnumerable<IMarketingActivity>)marketingGroup.MarketingActivities).Select((IMarketingActivity ma) => ma.Id)));
			source = AbstractNHEntityManager<IMarketingEffect, long>.Instance.Find(marketingEffectFilter, FetchOptions.All);
		}
		else
		{
			source = new List<IMarketingEffect>();
		}
		return (ActionResult)(object)((Controller)this).PartialView((object)source.CreateGridData("MarketingActivity"));
	}

	[CustomGridAction]
	public ActionResult ActivityEffectsGrid(GridCommand command, long marketingActivityId, bool? pagable)
	{
		IMarketingEffectFilter marketingEffectFilter = InterfaceActivator.Create<IMarketingEffectFilter>();
		marketingEffectFilter.MarketingActivity = MarketingActivityManager.Instance.Load(marketingActivityId);
		GridData<IMarketingEffect, IMarketingEffectFilter> gridData = AbstractNHEntityManager<IMarketingEffect, long>.Instance.CreateGridData(command, marketingEffectFilter);
		gridData.IsPageable = pagable ?? true;
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	public ActionResult AssignActivityToManyEntities(long[] entitiesId, Guid entityTypeUid, string redirectControllerName, string redirectActionName, string entitiesName, string entitiesNameForErrorMessage)
	{
		return (ActionResult)(object)((Controller)this).PartialView("SelectMarketingActivity", (object)new SelectMarketingActivityModel
		{
			EntitiesId = entitiesId,
			EntityTypeUid = entityTypeUid,
			RedirectControllerName = redirectControllerName,
			RedirectActionName = redirectActionName,
			EntitiesName = entitiesName,
			EntitiesNameForErrorMessage = entitiesNameForErrorMessage
		});
	}

	[HttpPost]
	public ActionResult AssignActivityToManyEntities(SelectMarketingActivityModel model)
	{
		if (model.EntitiesId.Length == 0)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction(model.RedirectActionName, model.RedirectControllerName);
		}
		Type typeByUid = Locator.GetService<IMetadataRuntimeService>().GetTypeByUid(model.EntityTypeUid);
		if (typeByUid == null)
		{
			base.Notifier.Error(SR.T("Неизвестный Guid типа: {0}", model.EntityTypeUid));
			return (ActionResult)(object)((Controller)this).RedirectToAction(model.RedirectActionName, model.RedirectControllerName);
		}
		bool anySuccessOperation = false;
		string text = string.Empty;
		IEntityManager entityManager = ModelHelper.GetEntityManager(typeByUid);
		long[] entitiesId = model.EntitiesId;
		foreach (long num in entitiesId)
		{
			if (entityManager.LoadOrNull(num) is IEntity<long> entity && entity is IMarketingActivityTarget)
			{
				if (!CheckEditPermission(entity, out var Name))
				{
					text = text + Name + ", ";
					continue;
				}
				anySuccessOperation = true;
				(entity as IMarketingActivityTarget).MarketingGroup = model.MarketingGroup;
				(entity as IMarketingActivityTarget).MarketingActivity = model.MarketingActivity;
				(entity as IMarketingActivityTarget).MarketingEffect = model.MarketingEffect;
				entity.Save();
			}
		}
		CreateResultMessage(model, anySuccessOperation, text);
		return (ActionResult)(object)((Controller)this).RedirectToAction(model.RedirectActionName, model.RedirectControllerName);
	}

	[Permission("{E0F57F69-5FBA-428A-93B4-8C80F35879B5}")]
	public ActionResult BudgetEdit(long id)
	{
		try
		{
			IMarketingBase marketingBase = base.Manager.Load(id).CastAsRealType();
			ThrowExceptionIfDeleted(marketingBase);
			return (ActionResult)(object)((Controller)this).View((object)marketingBase);
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "MarketingActivity");
		}
	}

	[Permission("{E0F57F69-5FBA-428A-93B4-8C80F35879B5}")]
	[HttpPost]
	public ActionResult BudgetEdit(long id, MarketingBudgetType budgetType, Money budget)
	{
		try
		{
			IMarketingBase marketingBase = base.Manager.Load(id);
			marketingBase.BudgetType = budgetType;
			if (budgetType == MarketingBudgetType.Manual)
			{
				marketingBase.Budget = budget;
			}
			else
			{
				marketingBase.Budget = default(Money);
			}
			marketingBase.Save();
			base.Notifier.Information(SR.T("Настройки бюджета изменены"));
		}
		catch (Exception exception)
		{
			base.Notifier.Error(SR.T("Произошла ошибка во время изменения настроек бюджета."));
			base.Logger.Error(SR.T("Произошла ошибка во время изменения настроек бюджета."), exception);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Details", "MarketingActivity", (object)new { id });
	}

	[Permission("{E0F57F69-5FBA-428A-93B4-8C80F35879B5}")]
	public ActionResult AddPayment(long marketingId)
	{
		IMarketingPayment marketingPayment = InterfaceActivator.Create<IMarketingPayment>();
		marketingPayment.MarketingObjectBase = base.Manager.Load(marketingId).CastAsRealType();
		return (ActionResult)(object)((Controller)this).PartialView("MarketingPayment/AddPaymentPopup", (object)marketingPayment);
	}

	[Permission("{E0F57F69-5FBA-428A-93B4-8C80F35879B5}")]
	public ActionResult EditPayment(long id)
	{
		try
		{
			IMarketingPayment marketingPayment = MarketingPaymentManager.Instance.Load(id);
			return (ActionResult)(object)((Controller)this).View("MarketingPayment/EditPayment", (object)marketingPayment);
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "MarketingActivity");
		}
	}

	[Permission("{E0F57F69-5FBA-428A-93B4-8C80F35879B5}")]
	public ActionResult SavePayment(IMarketingPayment payment)
	{
		payment.Save();
		return (ActionResult)(object)((Controller)this).RedirectToAction("Details", "MarketingActivity", (object)new
		{
			id = payment.MarketingObjectBase.Id
		});
	}

	[Permission("{E0F57F69-5FBA-428A-93B4-8C80F35879B5}")]
	[HttpPost]
	public ActionResult DeletePayment(long id)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		try
		{
			MarketingPaymentManager.Instance.Load(id).Delete();
			base.Notifier.Information(SR.T("Платеж удален"));
		}
		catch (Exception exception)
		{
			base.Notifier.Error(SR.T("Произошла ошибка во время удаления платежа."));
			base.Logger.Error(SR.T("Произошла ошибка во время удаления платежа."), exception);
		}
		return (ActionResult)new EmptyResult();
	}

	[CustomGridAction]
	public ActionResult GridPayment(GridCommand command, IMarketingBase marketingBase)
	{
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		List<MarketingPaymentModel> list = new List<MarketingPaymentModel>();
		GridData<MarketingPaymentModel> gridData = new GridData<MarketingPaymentModel>();
		if (marketingBase is IMarketingGroup marketingGroup)
		{
			list.AddRange(from m in (IEnumerable<IMarketingActivity>)marketingGroup.MarketingActivities
				select new MarketingPaymentModel
				{
					Entity = m,
					Budget = MarketingBaseManager.Instance.CalcMarketingBudget(m),
					CreationDate = m.CreationDate
				} into m
				where (double)m.Budget > 0.0
				select m);
		}
		if (marketingBase is IMarketingActivity marketingActivity)
		{
			list.AddRange(from m in (IEnumerable<IMarketingEffect>)marketingActivity.MarketingEffects
				select new MarketingPaymentModel
				{
					Entity = m,
					Budget = MarketingBaseManager.Instance.CalcMarketingBudget(m),
					CreationDate = m.CreationDate
				} into m
				where (double)m.Budget > 0.0
				select m);
		}
		list.AddRange(from m in (IEnumerable<IMarketingPayment>)marketingBase.Payments
			select new MarketingPaymentModel
			{
				Entity = m,
				Budget = m.Sum,
				CreationDate = m.CreationDate
			} into m
			where (double)m.Budget > 0.0
			select m);
		if (command == null)
		{
			GridCommand val = new GridCommand();
			val.set_PageSize(10);
			command = val;
		}
		gridData.Command = command;
		gridData.SetCount((GridData<MarketingPaymentModel> d, FetchOptions f) => list.Count());
		gridData.DataSource = command.ApplyPaging(list);
		gridData.IsPageable = list.Count > 10;
		gridData.IsAjax = list.Count > 10;
		((ControllerBase)this).get_ViewData().set_Item("CanControlBudget", (object)(CRMPermissionProvider.CheckAny(new Permission[2]
		{
			CRMPermissionProvider.CRMFullAccessPermission,
			CRMPermissionProvider.MarketingFullAccessPermission
		}) || base.SecurityService.HasPermission(CRMPermissionProvider.CRMMarketingBudgetControlPermission, marketingBase)));
		return (ActionResult)(object)((Controller)this).PartialView("MarketingPayment/GridPayment", (object)gridData);
	}

	private void CreateResultMessage(SelectMarketingActivityModel model, bool anySuccessOperation, string errorItems)
	{
		IMarketingBase marketingGroup = model.MarketingGroup;
		object obj = marketingGroup;
		if (obj == null)
		{
			marketingGroup = model.MarketingActivity;
			obj = marketingGroup ?? model.MarketingEffect;
		}
		IMarketingBase marketingBase = (IMarketingBase)obj;
		if (marketingBase != null)
		{
			string text = ((model.MarketingGroup != null) ? SR.T("маркетинговая группа") : ((model.MarketingActivity != null) ? SR.T("маркетинговое мероприятие") : SR.T("маркетинговое воздействие")));
			if (anySuccessOperation)
			{
				string text2 = SR.T("Присвоение активности {0} \"{1}\" выбранным {2} успешно произведено", text, marketingBase.Name, model.EntitiesName);
				base.Notifier.Information(MvcHtmlString.Create(text2));
			}
			if (errorItems != string.Empty)
			{
				EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
				string text3 = SR.T("Присвоение активности \"{0}\" {1} {2} {3} не удалось т.к. у пользователя {4} отсутствуют права на редактирование данных {5}", text, marketingBase.Name, model.EntitiesName, errorItems, currentUser.FullName, model.EntitiesNameForErrorMessage);
				base.Notifier.Error(MvcHtmlString.Create(text3));
			}
		}
		else
		{
			base.Notifier.Error(SR.T("Не выбрана маркетинговая активность для присвоения"));
		}
	}

	private bool CheckEditPermission(IEntity<long> entity, out string Name)
	{
		Name = string.Empty;
		if (entity is IContractor)
		{
			Name = (entity as IContractor).Name;
			return base.SecurityService.HasPermission(CRMPermissionProvider.EditContractorPermission, entity);
		}
		if (entity is IContact)
		{
			Name = (entity as IContact).Name;
			return base.SecurityService.HasPermission(CRMPermissionProvider.EditContactPermission, entity);
		}
		if (entity is ILead)
		{
			Name = (entity as ILead).Name;
			return base.SecurityService.HasPermission(CRMPermissionProvider.EditLeadPermission, entity);
		}
		if (entity is ISale)
		{
			Name = (entity as ISale).Name;
			return base.SecurityService.HasPermission(CRMPermissionProvider.EditSalePermission, entity);
		}
		return false;
	}

	public ActionResult LeadDynamic()
	{
		HttpContextAccessor.CurrentContext.Items.Add("showFiltersTree", true);
		LeadDynamicModel leadDynamicModel = new LeadDynamicModel();
		return (ActionResult)(object)((Controller)this).View("LeadDynamic/LeadDynamic", (object)leadDynamicModel);
	}

	public ActionResult LeadDynamicGrid(DateTime? date, MarketingPeriodEnum mode = MarketingPeriodEnum.Month, bool showArchive = false, bool showStatistic = true)
	{
		LeadDynamicModel leadDynamicModel = new LeadDynamicModel(mode, date.HasValue ? date.Value : DateTime.Today, showArchive, showStatistic);
		return (ActionResult)(object)((Controller)this).PartialView("LeadDynamic/LeadDynamicGrid", (object)leadDynamicModel);
	}

	[CustomGridAction]
	public ActionResult LeadDynamicActivity(GridCommand command, DateTime? date, long marketingGroupId, MarketingPeriodEnum mode = MarketingPeriodEnum.Month, bool showArchive = false, bool showStatistic = true)
	{
		LeadDynamicModel leadDynamicModel = new LeadDynamicModel(mode, date.HasValue ? date.Value : DateTime.Today, showArchive, showStatistic, marketingGroupId);
		return (ActionResult)(object)((Controller)this).PartialView("LeadDynamic/LeadDynamicActivity", (object)leadDynamicModel);
	}

	public JsonResult LeadDynamicSaveState(long id, bool expanding)
	{
		LeadDynamicState.SaveIdsState(id, expanding);
		return ((Controller)this).Json((object)new
		{
			success = true
		}, "text/html");
	}

	public ActionResult MarketingStatistic()
	{
		HttpContextAccessor.CurrentContext.Items.Add("showFiltersTree", true);
		MarketingStatisticModel marketingStatisticModel = new MarketingStatisticModel();
		return (ActionResult)(object)((Controller)this).View("MarketingStatistic/MarketingStatistic", (object)marketingStatisticModel);
	}

	public ActionResult MarketingStatisticGrid(DateTime? date, MarketingPeriodEnum mode = MarketingPeriodEnum.Month, long marketingBaseId = 0L)
	{
		MarketingStatisticModel marketingStatisticModel = new MarketingStatisticModel((marketingBaseId != 0L) ? MarketingBaseManager.Instance.Load(marketingBaseId) : null, mode, date.HasValue ? date.Value : DateTime.Today);
		return (ActionResult)(object)((Controller)this).PartialView("MarketingStatistic/MarketingStatisticGrid", (object)marketingStatisticModel);
	}

	private ActionResult SelectPermission(IMarketingBase instance)
	{
		Type type = InterfaceActivator.TypeOf<IMarketingBase>();
		CRMPermissionModel cRMPermissionModel = new CRMPermissionModel
		{
			Id = instance.Id
		};
		cRMPermissionModel.AdditionalPermissionsModel = base.PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(instance, type, ((Controller)this).get_Url(), (IInstanceSettingsPermissionHolder holder) => ((IMarketingPersonPermission)holder).PermissionSource == null);
		cRMPermissionModel.AdditionalPermissionsModel.Instance = instance;
		cRMPermissionModel.AdditionalPermissionsModel.Routes = new RouteValueDictionary(new
		{
			action = "PermissionSettings",
			controller = "MarketingActivity",
			area = "EleWise.ELMA.CRM.Web"
		});
		if (cRMPermissionModel.LockEditPermission)
		{
			cRMPermissionModel.AdditionalPermissionsModel.Edit = false;
		}
		if (!(instance is IMarketingGroup))
		{
			cRMPermissionModel.InheritPermissions = instance.InheritPermissions;
			cRMPermissionModel.InheritAvailable = base.SecurityService.HasPermission(CRMPermissionProvider.CRMMarketingIssuanceElementPermission, instance) || base.SecurityService.HasPermission(CRMPermissionProvider.CRMMarketingFullAccessPermission, instance) || base.SecurityService.HasPermission(CRMPermissionProvider.CRMFullAccessPermission);
			cRMPermissionModel.InheritPermissionsModel = base.PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(instance, type, ((Controller)this).get_Url(), (IInstanceSettingsPermissionHolder holder) => ((IMarketingPersonPermission)holder).PermissionSource != null);
			cRMPermissionModel.InheritPermissionsModel.BindModelName = "InheritPermissions";
			cRMPermissionModel.InheritPermissionsModel.Instance = instance;
			cRMPermissionModel.InheritPermissionsModel.Edit = false;
		}
		return (ActionResult)(object)((Controller)this).PartialView("MarketingActivityPermissionSettings", (object)cRMPermissionModel);
	}

	[HttpPost]
	public ActionResult EnableInheritPermission(IMarketingBase instance, bool enable)
	{
		MarketingBaseManager.Instance.EnableInheritPermissions(instance, enable);
		return SelectPermission(instance);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult PermissionSettings(long id, EditableListModel access)
	{
		IMarketingBase marketingObj = MarketingBaseManager.Instance.Load(id);
		if (access != null && marketingObj != null)
		{
			base.PermissionsModelService.BindPermissionsFromModel(marketingObj, access, delegate(ICollection<IInstanceSettingsPermissionHolder> holders, IEnumerable<IInstanceSettingsPermissionHolder> newHolders)
			{
				List<IInstanceSettingsPermissionHolder> list = new List<IInstanceSettingsPermissionHolder>();
				if (marketingObj.InheritPermissions)
				{
					list.AddRange(holders.Where((IInstanceSettingsPermissionHolder h) => ((IMarketingPersonPermission)h).PermissionSource != null));
					foreach (IInstanceSettingsPermissionHolder item in list)
					{
						holders.Remove(item);
					}
				}
				holders.SyncFrom(newHolders, (IInstanceSettingsPermissionHolder v1, IInstanceSettingsPermissionHolder v2) => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals(v1.Assigned, v2.Assigned), null, delegate(IInstanceSettingsPermissionHolder v)
				{
					if (v is IEntity entity)
					{
						entity.Delete();
					}
				});
				if (marketingObj.InheritPermissions)
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

	public ActionResult PermissionSettings(IMarketingBase instance)
	{
		return SelectPermission(instance);
	}

	public ActionResult RemoveContractor(long id)
	{
		string text = null;
		try
		{
			IContractor contractor = ContractorManager.Instance.Load(id);
			contractor.MarketingGroup = null;
			contractor.MarketingActivity = null;
			contractor.MarketingEffect = null;
			contractor.Save();
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

	public ActionResult RemoveLead(long id)
	{
		string text = null;
		try
		{
			ILead lead = LeadManager.Instance.Load(id);
			lead.MarketingGroup = null;
			lead.MarketingActivity = null;
			lead.MarketingEffect = null;
			lead.Save();
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

	public ActionResult RemoveSale(long id)
	{
		string text = null;
		try
		{
			ISale sale = SaleManager.Instance.Load(id);
			sale.MarketingGroup = null;
			sale.MarketingActivity = null;
			sale.MarketingEffect = null;
			sale.Save();
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

	[HttpGet]
	public ActionResult LinkContractor(long id)
	{
		LinkEntityToMarketingModel linkEntityToMarketingModel = new LinkEntityToMarketingModel();
		linkEntityToMarketingModel.Action = "LinkContractor";
		linkEntityToMarketingModel.MarketingBase = AbstractNHEntityManager<IMarketingBase, long>.Instance.Load(id);
		linkEntityToMarketingModel.EntityExpression = (LinkEntityToMarketingModel m) => m.Contractor;
		linkEntityToMarketingModel.Callback = "refreshContractorsGird(data)";
		LinkEntityToMarketingModel linkEntityToMarketingModel2 = linkEntityToMarketingModel;
		return (ActionResult)(object)((Controller)this).PartialView("LinkEntity", (object)linkEntityToMarketingModel2);
	}

	[HttpPost]
	public ActionResult LinkContractor(LinkEntityToMarketingModel model)
	{
		string text = null;
		try
		{
			ContractorManager.Instance.LinkToMarketing(model.Contractor, model.MarketingBase);
		}
		catch (Exception ex)
		{
			text = ex.Message;
			base.Logger.Error(ex.Message, ex);
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = string.IsNullOrEmpty(text),
			error = text
		}, "text/html");
	}

	[HttpGet]
	public ActionResult LinkLead(long id)
	{
		LinkEntityToMarketingModel linkEntityToMarketingModel = new LinkEntityToMarketingModel();
		linkEntityToMarketingModel.Action = "LinkLead";
		linkEntityToMarketingModel.MarketingBase = AbstractNHEntityManager<IMarketingBase, long>.Instance.Load(id);
		linkEntityToMarketingModel.EntityExpression = (LinkEntityToMarketingModel m) => m.Lead;
		linkEntityToMarketingModel.Callback = "refreshLeadsGird(data)";
		LinkEntityToMarketingModel linkEntityToMarketingModel2 = linkEntityToMarketingModel;
		return (ActionResult)(object)((Controller)this).PartialView("LinkEntity", (object)linkEntityToMarketingModel2);
	}

	[HttpPost]
	public ActionResult LinkLead(LinkEntityToMarketingModel model)
	{
		string text = null;
		try
		{
			LeadManager.Instance.LinkToMarketing(model.Lead, model.MarketingBase);
		}
		catch (Exception ex)
		{
			text = ex.Message;
			base.Logger.Error(ex.Message, ex);
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = string.IsNullOrEmpty(text),
			error = text
		}, "text/html");
	}

	[HttpGet]
	public ActionResult LinkSale(long id)
	{
		LinkEntityToMarketingModel linkEntityToMarketingModel = new LinkEntityToMarketingModel();
		linkEntityToMarketingModel.Action = "LinkSale";
		linkEntityToMarketingModel.MarketingBase = AbstractNHEntityManager<IMarketingBase, long>.Instance.Load(id);
		linkEntityToMarketingModel.EntityExpression = (LinkEntityToMarketingModel m) => m.Sale;
		linkEntityToMarketingModel.Callback = "refreshSalesGird(data)";
		LinkEntityToMarketingModel linkEntityToMarketingModel2 = linkEntityToMarketingModel;
		return (ActionResult)(object)((Controller)this).PartialView("LinkEntity", (object)linkEntityToMarketingModel2);
	}

	[HttpPost]
	public ActionResult LinkSale(LinkEntityToMarketingModel model)
	{
		string text = null;
		try
		{
			SaleManager.Instance.LinkToMarketing(model.Sale, model.MarketingBase);
		}
		catch (Exception ex)
		{
			text = ex.Message;
			base.Logger.Error(ex.Message, ex);
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = string.IsNullOrEmpty(text),
			error = text
		}, "text/html");
	}

	[TransactionAction]
	public ActionResult Archive(CommentWithAttachments model)
	{
		try
		{
			IMarketingBase marketingBase = MarketingBaseManager.Instance.Load(model.ObjectId).CastAsRealType();
			EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(marketingBase.GetType());
			MarketingBaseManager.Instance.Archive(marketingBase, model.ActionModel);
			base.Notifier.Information(MvcHtmlString.Create(SR.T("{0} <a href='{2}'>{1}</a> перемещено(а) в архив", entityMetadata.DisplayName.HtmlEncode(), marketingBase.Name.HtmlEncode(), ((Controller)this).get_Url().Entity(marketingBase))));
			return (ActionResult)(object)((Controller)this).Redirect(model.RedirectUrl);
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new
			{
				id = model.ObjectId
			});
		}
	}

	[TransactionAction]
	public ActionResult Activate(CommentWithAttachments model)
	{
		try
		{
			IMarketingBase marketingBase = MarketingBaseManager.Instance.Load(model.ObjectId).CastAsRealType();
			EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(marketingBase.GetType());
			MarketingBaseManager.Instance.Activate(marketingBase, model.ActionModel);
			base.Notifier.Information(MvcHtmlString.Create(SR.T("{0} <a href='{2}'>{1}</a> возвращено(а) из архива", entityMetadata.DisplayName.HtmlEncode(), marketingBase.Name.HtmlEncode(), ((Controller)this).get_Url().Entity(marketingBase))));
			return (ActionResult)(object)((Controller)this).Redirect(model.RedirectUrl);
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new
			{
				id = model.ObjectId
			});
		}
	}

	public ActionResult ComboboxSelect(string text, string id)
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		Guid activityTypeUid = InterfaceActivator.UID<IMarketingActivity>();
		Guid groupTypeUid = InterfaceActivator.UID<IMarketingGroup>();
		InstanceOf<IMarketingBaseFilter> instanceOf = new InstanceOf<IMarketingBaseFilter>();
		instanceOf.New.Status = MarketingObjectStatus.Active;
		IMarketingBaseFilter @new = instanceOf.New;
		if (!string.IsNullOrEmpty(text))
		{
			@new.Name = text;
		}
		if (!string.IsNullOrEmpty(id) && long.TryParse(id.TrimStart('g', 'a', 'e', '?'), out var result))
		{
			@new.Id = result;
		}
		List<AutocompleteItem> data = (from i in MarketingBaseManager.Instance.Find(@new, new FetchOptions(0, 100))
			select new AutocompleteItem
			{
				Value = string.Format("{0}{1}", (i.TypeUid == groupTypeUid) ? "g" : ((i.TypeUid == activityTypeUid) ? "a" : "e"), i.Id),
				Text = i.Name,
				DropDownText = string.Format("{0} {1}", HtmlExtensions.Image(((Controller)this).get_Url().ObjectIcon(ObjectIconFormat.x16, i), new
				{
					style = "vertical-align: text-bottom;"
				}), HttpUtility.HtmlEncode(i.Name)),
				EntityUrl = ((Controller)this).get_Url().Entity(i)
			}).ToList();
		JsonResult val = new JsonResult();
		val.set_Data((object)data);
		return (ActionResult)val;
	}

	public ActionResult TreeSelect(string value)
	{
		Guid gUid = InterfaceActivator.UID<IMarketingGroup>();
		Guid aUid = InterfaceActivator.UID<IMarketingActivity>();
		if (value == null)
		{
			List<TreeViewItem> list = MarketingBaseManager.Instance.TreeRoot().Select((Func<MarketingTreeItem, TreeViewItem>)delegate(MarketingTreeItem item)
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				//IL_0014: Unknown result type (might be due to invalid IL or missing references)
				//IL_0068: Unknown result type (might be due to invalid IL or missing references)
				//IL_0074: Expected O, but got Unknown
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e3: Expected O, but got Unknown
				//IL_00e4: Expected O, but got Unknown
				TreeViewItem val3 = new TreeViewItem();
				val3.set_LoadOnDemand(item.ChildrenCount > 0);
				val3.set_Value(string.Format("{0}{1}", (item.TypeUid == gUid) ? "g" : ((item.TypeUid == aUid) ? "a" : "?"), item.Id));
				((NavigationItem<TreeViewItem>)val3).set_Text(item.Name);
				((NavigationItem<TreeViewItem>)val3).set_ImageUrl((item.TypeUid == gUid) ? ((Controller)this).get_Url().Image("#targets.svg") : ((item.TypeUid == aUid) ? ((Controller)this).get_Url().Image("#target.svg") : ((Controller)this).get_Url().Image("#unk.svg")));
				return val3;
			}).ToList();
			return (ActionResult)(object)((Controller)this).Json((object)list);
		}
		if (long.TryParse(value.Substring(1), out var result))
		{
			IMarketingBase marketingBase = MarketingBaseManager.Instance.Load(result).CastAsRealType();
			if (marketingBase is IMarketingGroup)
			{
				IEnumerable<TreeViewItem> enumerable = MarketingBaseManager.Instance.TreeGroup((IMarketingGroup)marketingBase).Select((Func<MarketingTreeItem, TreeViewItem>)delegate(MarketingTreeItem activity)
				{
					//IL_0000: Unknown result type (might be due to invalid IL or missing references)
					//IL_0005: Unknown result type (might be due to invalid IL or missing references)
					//IL_0014: Unknown result type (might be due to invalid IL or missing references)
					//IL_002f: Unknown result type (might be due to invalid IL or missing references)
					//IL_003b: Expected O, but got Unknown
					//IL_003b: Unknown result type (might be due to invalid IL or missing references)
					//IL_0056: Expected O, but got Unknown
					//IL_0057: Expected O, but got Unknown
					TreeViewItem val2 = new TreeViewItem();
					val2.set_LoadOnDemand(activity.ChildrenCount > 0);
					val2.set_Value($"a{activity.Id}");
					((NavigationItem<TreeViewItem>)val2).set_Text(activity.Name);
					((NavigationItem<TreeViewItem>)val2).set_ImageUrl(((Controller)this).get_Url().Image("#target.svg"));
					return val2;
				});
				return (ActionResult)(object)((Controller)this).Json((object)enumerable);
			}
			if (marketingBase is IMarketingActivity)
			{
				InstanceOf<IMarketingEffectFilter> instanceOf = new InstanceOf<IMarketingEffectFilter>();
				instanceOf.New.MarketingActivity = (IMarketingActivity)marketingBase;
				instanceOf.New.Status = MarketingObjectStatus.Active;
				IMarketingEffectFilter @new = instanceOf.New;
				return (ActionResult)(object)((Controller)this).Json((object)((IEnumerable<IMarketingEffect>)MarketingEffectManager.Instance.Find(@new, FetchOptions.All)).Select((Func<IMarketingEffect, TreeViewItem>)delegate(IMarketingEffect effect)
				{
					//IL_0000: Unknown result type (might be due to invalid IL or missing references)
					//IL_0005: Unknown result type (might be due to invalid IL or missing references)
					//IL_000c: Unknown result type (might be due to invalid IL or missing references)
					//IL_0027: Unknown result type (might be due to invalid IL or missing references)
					//IL_0033: Expected O, but got Unknown
					//IL_0033: Unknown result type (might be due to invalid IL or missing references)
					//IL_004e: Expected O, but got Unknown
					//IL_004f: Expected O, but got Unknown
					TreeViewItem val = new TreeViewItem();
					val.set_LoadOnDemand(false);
					val.set_Value($"e{effect.Id}");
					((NavigationItem<TreeViewItem>)val).set_Text(effect.Name);
					((NavigationItem<TreeViewItem>)val).set_ImageUrl(((Controller)this).get_Url().Image("#arrow.svg"));
					return val;
				}));
			}
		}
		return (ActionResult)(object)((Controller)this).Json((object)new TreeViewItem[0]);
	}

	public ActionResult Explorer(string popupId)
	{
		((ControllerBase)this).get_ViewData().set_Item("PopupId", (object)popupId);
		return (ActionResult)(object)((Controller)this).PartialView();
	}
}
