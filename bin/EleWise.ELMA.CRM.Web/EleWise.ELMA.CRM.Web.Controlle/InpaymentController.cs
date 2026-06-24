using System;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Extensions;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Attributes;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.CRM.Web.Portlets;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers;

[AllPermissions(new string[] { "{46401803-1B46-4E60-8DA0-227FF8CF60F3}", "{EE6119AA-D9B9-4FDA-8EA3-7C3B92B4956E}" })]
[RouteArea("EleWise.ELMA.CRM.Web")]
public class InpaymentController : FilterTreeBaseController<IInpayment, long>
{
	public static IProductionCalendarService Calendar => Locator.GetServiceNotNull<IProductionCalendarService>();

	public IProductionSchedule ProductionSchedule => Calendar.GetGlobalProductionSchedule(Locator.GetServiceNotNull<ITimeZoneService>().CurrentUserTimeZone.Settings);

	public IUnionComplexCacheService ComplexCacheService { get; set; }

	public static string[] GetGridIds => new string[5] { "OldInpaymentsGrid", "ThisMonthBeforeWeekGrid", "CurrentWeekGrid", "ThisMonthAfterWeekGrid", "FarFutureGrid" };

	protected override bool EnableEqlQuery => true;

	[ContentItem(Name = "SR.M('План поступлений')", Image24 = "#budget.svg")]
	[FilterMenuItem(Id = "crm-inpayments", Type = typeof(IInpayment), FilterEditAction = "EditFilters")]
	public ActionResult Index(long? FilterId = null)
	{
		ActionResult val = BaseIndex(FilterId);
		if (val != null)
		{
			return val;
		}
		FilterModel filter = CreateFilter(FilterId);
		GridDataFilter<InpaymentModel> gridDataFilter = CreateGridData(null, filter);
		return (ActionResult)(object)((Controller)this).View((object)gridDataFilter);
	}

	public ActionResult Search(long? FilterId = null)
	{
		if (((Controller)this).get_Request().QueryString.Count == 0)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
		}
		FilterModel filter = CreateFilter(FilterId);
		GridDataFilter<InpaymentModel> gridDataFilter = CreateGridData(null, filter);
		return (ActionResult)(object)((Controller)this).View("Index", (object)gridDataFilter);
	}

	[DetailsAction]
	[EntityLink]
	public ActionResult Details(long id, int? tabIndex = 0)
	{
		try
		{
			if (tabIndex.HasValue)
			{
				((ControllerBase)this).get_ViewData().set_Item("SelectedTab", (object)tabIndex.Value);
			}
			IInpayment inpayment = base.Manager.Load(id);
			return (ActionResult)(object)((Controller)this).View((object)inpayment);
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Inpayment");
		}
	}

	public ActionResult Edit(long id)
	{
		IInpayment inpayment = InpaymentManager.Instance.Load(id);
		return (ActionResult)(object)((Controller)this).View((object)inpayment);
	}

	[HttpPost]
	public ActionResult Edit(IInpayment model)
	{
		if (model.Sale.SaleClosed())
		{
			base.Notifier.Error(SR.T("Нельзя изменить поступление по закрытой сделке"));
			return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
		}
		try
		{
			model.Save();
		}
		catch (Exception exception)
		{
			base.Logger.Log(LogLevel.Error, exception, "Error while saving Inpayment");
			base.Notifier.Error(SR.T("Произошла ошибка во время сохранения"));
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new
		{
			id = model.Id
		});
	}

	[HttpGet]
	[Permission("E56A21C6-2981-4BCF-AB5E-9F012811197D")]
	public ActionResult Delete(long id)
	{
		try
		{
			IInpayment inpayment = base.Manager.Load(id);
			base.Manager.Delete(inpayment);
			base.Notifier.Information(SR.T("Поступление \"{0}\" удалено", inpayment.Name));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Inpayment", (object)new
			{
				area = "EleWise.ELMA.CRM.Web"
			});
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Inpayment", (object)new
			{
				area = "EleWise.ELMA.CRM.Web"
			});
		}
	}

	[HttpGet]
	public ActionResult AddCommentPopup(long id, Guid typeUid, string popupId)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		CommentWithAttachments commentWithAttachments = new CommentWithAttachments
		{
			ShowAttachment = false,
			PopupId = popupId,
			ObjectId = id,
			ObjectTypeUid = typeUid,
			AddCommentActionUid = InpaymentActions.AddCommentGuid,
			RedirectUrl = ((Controller)this).get_Url().Action("Details", "Inpayment", (object)new
			{
				area = "EleWise.ELMA.CRM.Web",
				id = id
			})
		};
		ViewDataDictionary viewData = ((ControllerBase)this).get_ViewData();
		TemplateInfo val = new TemplateInfo();
		val.set_HtmlFieldPrefix(commentWithAttachments.HtmlPrefix);
		viewData.set_TemplateInfo(val);
		return (ActionResult)(object)((Controller)this).RedirectToAction("PopupCommentContent", "Comment", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common",
			PopupId = commentWithAttachments.PopupId,
			ObjectId = commentWithAttachments.ObjectId,
			ShowAttachment = commentWithAttachments.ShowAttachment,
			RedirectUrl = commentWithAttachments.RedirectUrl,
			ObjectTypeUid = commentWithAttachments.ObjectTypeUid,
			PostAction = commentWithAttachments.PostAction,
			PostController = commentWithAttachments.PostController,
			PostArea = commentWithAttachments.PostArea,
			ActionName = commentWithAttachments.ActionName,
			AddCommentActionUid = commentWithAttachments.AddCommentActionUid,
			HtmlPrefix = commentWithAttachments.HtmlPrefix
		});
	}

	[HttpGet]
	public ActionResult AskQuestionPopup(long id, Guid typeUid, string popupId)
	{
		QuestionModel questionModel = new QuestionModel
		{
			PopupId = popupId,
			ObjectId = id,
			ObjectTypeUid = typeUid,
			AddQuestionActionUid = InpaymentActions.AddQuestionGuid,
			RedirectUrl = ((Controller)this).get_Url().Action("Details", "Inpayment", (object)new
			{
				area = "EleWise.ELMA.CRM.Web",
				id = id
			})
		};
		return (ActionResult)(object)((Controller)this).RedirectToAction("QuestionCreateForm", "Question", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks",
			PopupId = questionModel.PopupId,
			PostAction = questionModel.PostAction,
			PostController = questionModel.PostController,
			PostArea = questionModel.PostArea,
			ObjectId = questionModel.ObjectId,
			ObjectTypeUid = questionModel.ObjectTypeUid,
			RedirectUrl = questionModel.RedirectUrl,
			AddQuestionActionUid = questionModel.AddQuestionActionUid
		});
	}

	internal DateTime GetWeekStart()
	{
		DateTime dateTime = DateTime.Today.AddDays(-((Convert.ToInt64(DateTime.Now.DayOfWeek) + 6) % 7));
		while (!ProductionSchedule.IsWorkDay(dateTime))
		{
			dateTime = dateTime.AddDays(1.0);
		}
		return dateTime;
	}

	public DateTime FirstDayOfMonth(DateTime dateTime)
	{
		return new DateTime(dateTime.Year, dateTime.Month, 1);
	}

	[CustomGridAction]
	public ActionResult OldInpaymentsGridAction(GridCommand command, [Bind(Prefix = "DataFilter")] FilterModel filter, [Bind(Prefix = "StatusSet0")] InpaymentStatusFilterModel statusFilter, long? FilterId = null, bool portletView = false, bool showOnlyMy = false, Guid? instanceId = null)
	{
		DateTime endDate = FirstDayOfMonth(GetWeekStart()).AddSeconds(-1.0);
		InpaymentSubPanelModel inpaymentSubPanelModel = CommonGridAction(command, filter, portletView ? null : statusFilter, FilterId, DateTime.MinValue, endDate, 0, portletView, showOnlyMy, instanceId);
		inpaymentSubPanelModel.StartDate = DateTime.MinValue;
		inpaymentSubPanelModel.EndDate = endDate;
		inpaymentSubPanelModel.CheckBoxInPlan = false;
		inpaymentSubPanelModel.HideTotalInPlanWithoutDate = true;
		return (ActionResult)(object)((Controller)this).PartialView("SubPanelGrid", (object)inpaymentSubPanelModel);
	}

	[CustomGridAction]
	public ActionResult ThisMonthBeforeWeekGridAction(GridCommand command, [Bind(Prefix = "DataFilter")] FilterModel filter, [Bind(Prefix = "StatusSet1")] InpaymentStatusFilterModel statusFilter, long? FilterId = null, bool portletView = false, bool showOnlyMy = false, Guid? instanceId = null)
	{
		DateTime startDate = FirstDayOfMonth(GetWeekStart());
		DateTime endDate = GetWeekStart().AddSeconds(-1.0);
		InpaymentSubPanelModel inpaymentSubPanelModel = CommonGridAction(command, filter, portletView ? null : statusFilter, FilterId, startDate, endDate, 1, portletView, showOnlyMy, instanceId);
		inpaymentSubPanelModel.CheckBoxInPlan = false;
		inpaymentSubPanelModel.StartDate = startDate;
		inpaymentSubPanelModel.EndDate = endDate;
		inpaymentSubPanelModel.HideTotalInPlanWithoutDate = true;
		return (ActionResult)(object)((Controller)this).PartialView("SubPanelGrid", (object)inpaymentSubPanelModel);
	}

	[CustomGridAction]
	public ActionResult CurrentWeekGridAction(GridCommand command, [Bind(Prefix = "DataFilter")] FilterModel filter, [Bind(Prefix = "StatusSet2")] InpaymentStatusFilterModel statusFilter, long? FilterId = null, bool portletView = false, bool showOnlyMy = false, Guid? instanceId = null)
	{
		DateTime weekStart = GetWeekStart();
		DateTime runtimeDateTime = weekStart;
		while (ProductionSchedule.IsWorkDay(runtimeDateTime))
		{
			runtimeDateTime = runtimeDateTime.AddDays(1.0);
		}
		runtimeDateTime = runtimeDateTime.Date.AddSeconds(-1.0);
		InpaymentSubPanelModel inpaymentSubPanelModel = CommonGridAction(command, filter, portletView ? null : statusFilter, FilterId, weekStart, runtimeDateTime, 2, portletView, showOnlyMy, instanceId);
		inpaymentSubPanelModel.StartDate = weekStart;
		inpaymentSubPanelModel.EndDate = runtimeDateTime;
		inpaymentSubPanelModel.HideTotalInPlanWithoutDate = true;
		return (ActionResult)(object)((Controller)this).PartialView("SubPanelGrid", (object)inpaymentSubPanelModel);
	}

	[CustomGridAction]
	public ActionResult ThisMonthAfterWeekGridAction(GridCommand command, [Bind(Prefix = "DataFilter")] FilterModel filter, [Bind(Prefix = "StatusSet3")] InpaymentStatusFilterModel statusFilter, long? FilterId = null, bool portletView = false, bool showOnlyMy = false, Guid? instanceId = null)
	{
		DateTime dateTime = GetWeekStart();
		while (ProductionSchedule.IsWorkDay(dateTime))
		{
			dateTime = dateTime.AddDays(1.0);
		}
		DateTime endDate = FirstDayOfMonth(dateTime.AddMonths(1)).AddSeconds(-1.0);
		InpaymentSubPanelModel inpaymentSubPanelModel = CommonGridAction(command, filter, portletView ? null : statusFilter, FilterId, dateTime, endDate, 3, portletView, showOnlyMy, instanceId);
		inpaymentSubPanelModel.CheckBoxOverdue = false;
		inpaymentSubPanelModel.StartDate = dateTime;
		inpaymentSubPanelModel.EndDate = endDate;
		inpaymentSubPanelModel.HideTotalInPlanWithoutDate = true;
		return (ActionResult)(object)((Controller)this).PartialView("SubPanelGrid", (object)inpaymentSubPanelModel);
	}

	[CustomGridAction]
	public ActionResult FarFutureGridAction(GridCommand command, [Bind(Prefix = "DataFilter")] FilterModel filter, [Bind(Prefix = "StatusSet4")] InpaymentStatusFilterModel statusFilter, long? FilterId = null, bool portletView = false, bool showOnlyMy = false, Guid? instanceId = null)
	{
		DateTime runtimeDateTime = GetWeekStart();
		while (ProductionSchedule.IsWorkDay(runtimeDateTime))
		{
			runtimeDateTime = runtimeDateTime.AddDays(1.0);
		}
		runtimeDateTime = FirstDayOfMonth(runtimeDateTime.AddMonths(1));
		InpaymentSubPanelModel inpaymentSubPanelModel = CommonGridAction(command, filter, portletView ? null : statusFilter, FilterId, runtimeDateTime, DateTime.MaxValue, 4, portletView, showOnlyMy, instanceId);
		inpaymentSubPanelModel.CheckBoxOverdue = false;
		inpaymentSubPanelModel.StartDate = runtimeDateTime;
		inpaymentSubPanelModel.EndDate = DateTime.MaxValue;
		return (ActionResult)(object)((Controller)this).PartialView("SubPanelGrid", (object)inpaymentSubPanelModel);
	}

	protected new GridDataFilter<InpaymentModel> CreateGridData(GridCommand command, FilterModel filter)
	{
		GridDataFilter<InpaymentModel> gridDataFilter = new GridDataFilter<InpaymentModel>();
		gridDataFilter.Command = command;
		gridDataFilter.DataFilter = filter;
		gridDataFilter.SetDataSource((GridData<InpaymentModel> d, FetchOptions f) => InpaymentManager.Instance.GetInpayments((IInpaymentFilter)filter.Filter, f));
		gridDataFilter.SetCount((GridData<InpaymentModel> d, FetchOptions f) => InpaymentManager.Instance.GetInpaymentsCount((IInpaymentFilter)filter.Filter));
		return gridDataFilter;
	}

	internal InpaymentSubPanelModel CommonGridAction(GridCommand command, FilterModel filter, InpaymentStatusFilterModel statusFilter, long? FilterId, DateTime startDate, DateTime endDate, int gridNo, bool portletView = false, bool showOnlyMy = false, Guid? instanceId = null)
	{
		if (filter == null)
		{
			filter = CreateFilter(FilterId ?? 0);
		}
		if (statusFilter == null)
		{
			statusFilter = InpaymentPersonalizationAdministration.LoadState($"{(portletView ? $"Portlet_{instanceId}_" : string.Empty)}{GetGridIds[gridNo]}_StatusSet{gridNo}") ?? new InpaymentStatusFilterModel();
		}
		else
		{
			InpaymentPersonalizationAdministration.SaveState($"{(portletView ? $"Portlet_{instanceId}_" : string.Empty)}{GetGridIds[gridNo]}_StatusSet{gridNo}", statusFilter);
		}
		IInpaymentFilter inpaymentFilter = (IInpaymentFilter)filter.Filter;
		inpaymentFilter.GridDateRange = new DateTimeRange(startDate, endDate);
		if (!statusFilter.IsOverdue)
		{
			inpaymentFilter.IsOverdue = false;
		}
		if (!statusFilter.InPlan)
		{
			inpaymentFilter.InPlan = false;
		}
		if (!statusFilter.Received)
		{
			inpaymentFilter.Received = false;
		}
		if (!statusFilter.Cancelled)
		{
			inpaymentFilter.Cancelled = false;
		}
		inpaymentFilter.ShowOnlyMy = showOnlyMy;
		InpaymentSubPanelModel inpaymentSubPanelModel = new InpaymentSubPanelModel(inpaymentFilter);
		inpaymentSubPanelModel.GridData = CreateGridData(command, filter);
		inpaymentSubPanelModel.GridData.GridId = (portletView ? $"{GetGridIds[gridNo]}_{instanceId}" : GetGridIds[gridNo]);
		inpaymentSubPanelModel.GridAction = GetGridIds[gridNo] + "Action";
		inpaymentSubPanelModel.StatusSetPrefix = "StatusSet" + gridNo;
		inpaymentSubPanelModel.PortletView = portletView;
		inpaymentSubPanelModel.InstanceId = instanceId ?? Guid.Empty;
		inpaymentSubPanelModel.StatusFilterModel = statusFilter;
		return inpaymentSubPanelModel;
	}

	[HttpGet]
	public ActionResult InpaymentPortlet(InpaymentPortletPersonalization settings)
	{
		InpaymentPortletModel inpaymentPortletModel = new InpaymentPortletModel
		{
			InstanceId = settings.InstanceId,
			FilterId = ((settings.Filter != null) ? new long?(settings.Filter.Id) : null),
			ShowOnlyMy = settings.ShowOnlyMy,
			SplitByPeriods = settings.SplitByPeriods
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)inpaymentPortletModel);
	}

	[CustomGridAction]
	public ActionResult PortletGrid(GridCommand command, long? filterId, bool showOnlyMy, Guid instanceId)
	{
		FilterModel filterModel = CreateFilter(filterId);
		IInpaymentFilter obj = (IInpaymentFilter)filterModel.Filter;
		obj.ShowOnlyMy = showOnlyMy;
		InpaymentSubPanelModel inpaymentSubPanelModel = new InpaymentSubPanelModel(obj);
		inpaymentSubPanelModel.GridData = CreateGridData(command, filterModel);
		inpaymentSubPanelModel.PortletView = true;
		inpaymentSubPanelModel.InstanceId = instanceId;
		return (ActionResult)(object)((Controller)this).PartialView((object)inpaymentSubPanelModel);
	}

	public ActionResult PortletSplitGrids(long? filterId, bool showOnlyMy, Guid instanceId)
	{
		InpaymentPortletModel inpaymentPortletModel = new InpaymentPortletModel
		{
			InstanceId = instanceId,
			FilterId = filterId,
			ShowOnlyMy = showOnlyMy,
			SplitByPeriods = true
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)inpaymentPortletModel);
	}

	[CustomGridAction]
	public ActionResult Inpayments(GridCommand command, long saleId, bool readOnly = false)
	{
		ISale sale = SaleManager.Instance.Load(saleId);
		IInpaymentFilter inpaymentFilter = InterfaceActivator.Create<IInpaymentFilter>();
		inpaymentFilter.Sale = sale;
		SaleInpaymentsModel saleInpaymentsModel = new SaleInpaymentsModel();
		saleInpaymentsModel.Sale = sale;
		saleInpaymentsModel.GridData = EntityManager<IInpayment>.Instance.CreateGridData(command, inpaymentFilter);
		return (ActionResult)(object)((Controller)this).PartialView("SaleInpayments/Inpayments", (object)saleInpaymentsModel);
	}

	[HttpGet]
	public ActionResult AddInpayment(long? saleId)
	{
		SaleInpaymentEditModel saleInpaymentEditModel = new SaleInpaymentEditModel
		{
			Inpayment = InterfaceActivator.Create<IInpayment>()
		};
		saleInpaymentEditModel.Inpayment.Sale = (saleId.HasValue ? SaleManager.Instance.Load(saleId.Value) : null);
		saleInpaymentEditModel.Inpayment.Responsible = base.AuthenticationService.GetCurrentUser<IUser>();
		return (ActionResult)(object)((Controller)this).PartialView("EditInpayment", (object)saleInpaymentEditModel);
	}

	[HttpGet]
	public ActionResult EditInpayment(long id)
	{
		SaleInpaymentEditModel saleInpaymentEditModel = new SaleInpaymentEditModel
		{
			Inpayment = EntityManager<IInpayment>.Instance.Load(id)
		};
		return (ActionResult)(object)((Controller)this).PartialView("EditInpayment", (object)saleInpaymentEditModel);
	}

	[HttpPost]
	public ActionResult EditInpayment(SaleInpaymentEditModel model)
	{
		if (model.CloseInpaymentsPlan && model.Inpayment.Sale != null)
		{
			model.Inpayment.Sale.InpaymentsPlanCompleted = true;
			ISale sale = model.Inpayment.Sale;
			IEntityManager<IInpayment> instance = EntityManager<IInpayment>.Instance;
			InstanceOf<IInpaymentFilter> instanceOf = new InstanceOf<IInpaymentFilter>();
			instanceOf.New.Sale = model.Inpayment.Sale;
			sale.SalesVolume = instance.Find(instanceOf.New, FetchOptions.All).Sum((IInpayment x) => x.Sum) + (double)model.Inpayment.Sum;
			model.Inpayment.Sale.Save();
		}
		if (model.Inpayment.Sale.SaleStatus != SaleStatus.NegativeClosed && model.Inpayment.Sale.SaleStatus != SaleStatus.PositiveClosed)
		{
			if (model.Inpayment.IsNew())
			{
				base.Notifier.Information(SR.T("Поступление успешно создано"));
			}
			model.Inpayment.Save();
			UpdateSalesVolume(model.Inpayment.Sale);
			return SuccessJson();
		}
		if (model.Inpayment.IsNew())
		{
			base.Notifier.Error(SR.T("Нельзя добавить поступление по закрытой сделке"));
		}
		return ErrorJson(SR.T("Нельзя добавить или изменить поступление по закрытой сделке"));
	}

	private void UpdateSalesVolume(ISale sale)
	{
		if (sale.InpaymentsPlanCompleted)
		{
			double value = (from x in EntityManager<IInpayment>.Instance.Find((IInpayment i) => i.Sale == sale)
				where x.Status != InpaymentStatus.Cancelled
				select x).Sum((IInpayment x) => x.Sum);
			sale.SalesVolume = value;
			sale.Save();
		}
	}

	public ActionResult UpdateInpaymentsGrid(ISale sale)
	{
		IInpaymentFilter inpaymentFilter = InterfaceActivator.Create<IInpaymentFilter>();
		inpaymentFilter.Sale = sale;
		SaleInpaymentsModel saleInpaymentsModel = new SaleInpaymentsModel();
		saleInpaymentsModel.Sale = sale;
		saleInpaymentsModel.GridData = EntityManager<IInpayment>.Instance.CreateGridData(null, inpaymentFilter);
		return (ActionResult)(object)((Controller)this).PartialView("SaleInpayments/Grid", (object)saleInpaymentsModel);
	}

	[Permission("E56A21C6-2981-4BCF-AB5E-9F012811197D")]
	public ActionResult DeleteInpayment(long id, bool readOnly = false)
	{
		IInpayment inpayment = EntityManager<IInpayment>.Instance.Load(id);
		ISale sale = inpayment.Sale;
		inpayment.Delete();
		UpdateSalesVolume(sale);
		return UpdateInpaymentsGrid(sale);
	}

	[HttpPost]
	public ActionResult CloseInpaymentsPlan(long id, Money inpaymentsTotal)
	{
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		ISale sale = SaleManager.Instance.Load(id);
		sale.InpaymentsPlanCompleted = true;
		sale.SalesVolume = EntityManager<IInpayment>.Instance.Find((IInpayment x) => x.Sale != null && x.Sale.Id == id).Sum((IInpayment x) => x.Sum) + (double)inpaymentsTotal;
		sale.Save();
		return (ActionResult)new EmptyResult();
	}

	[HttpPost]
	public ActionResult SetInpaymentInvoice(long id)
	{
		IInpayment inpayment = EntityManager<IInpayment>.Instance.Load(id);
		if (inpayment.Sale.SaleStatus != SaleStatus.NegativeClosed && inpayment.Sale.SaleStatus != SaleStatus.PositiveClosed)
		{
			inpayment.Invoice = true;
			inpayment.Save();
		}
		IInpaymentFilter inpaymentFilter = InterfaceActivator.Create<IInpaymentFilter>();
		inpaymentFilter.Sale = inpayment.Sale;
		SaleInpaymentsModel saleInpaymentsModel = new SaleInpaymentsModel();
		saleInpaymentsModel.Sale = inpayment.Sale;
		saleInpaymentsModel.GridData = EntityManager<IInpayment>.Instance.CreateGridData(null, inpaymentFilter);
		return (ActionResult)(object)((Controller)this).PartialView("SaleInpayments/Grid", (object)saleInpaymentsModel);
	}

	[HttpPost]
	public ActionResult SetInpaymentDate(long id, DateTime? date)
	{
		IInpayment inpayment = EntityManager<IInpayment>.Instance.Load(id);
		if (inpayment.Sale.SaleStatus != SaleStatus.NegativeClosed && inpayment.Sale.SaleStatus != SaleStatus.PositiveClosed)
		{
			if (date.HasValue)
			{
				InpaymentManager.Instance.SetInpaymentDate(inpayment, date.Value);
			}
			else
			{
				InpaymentManager.Instance.SetInpaymentDate(inpayment);
			}
		}
		IInpaymentFilter inpaymentFilter = InterfaceActivator.Create<IInpaymentFilter>();
		inpaymentFilter.Sale = inpayment.Sale;
		SaleInpaymentsModel saleInpaymentsModel = new SaleInpaymentsModel();
		saleInpaymentsModel.Sale = inpayment.Sale;
		saleInpaymentsModel.GridData = EntityManager<IInpayment>.Instance.CreateGridData(null, inpaymentFilter);
		return (ActionResult)(object)((Controller)this).PartialView("SaleInpayments/Grid", (object)saleInpaymentsModel);
	}

	[HttpGet]
	public ActionResult SetInpaymentStatus(long id, string prefix)
	{
		IInpayment inpayment = EntityManager<IInpayment>.Instance.Load(id);
		InpaymentChangeStatusModel inpaymentChangeStatusModel = new InpaymentChangeStatusModel
		{
			InpaymentId = id,
			Value = inpayment.Status,
			ActualDate = inpayment.ActualDate
		};
		((ControllerBase)this).get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(prefix);
		return (ActionResult)(object)((Controller)this).PartialView("SetInpaymentStatusPopup", (object)inpaymentChangeStatusModel);
	}

	[HttpPost]
	public ActionResult SetInpaymentStatus(InpaymentChangeStatusModel statusModel)
	{
		IInpayment inpayment = EntityManager<IInpayment>.Instance.Load(statusModel.InpaymentId);
		if (inpayment.Sale.SaleStatus != SaleStatus.NegativeClosed && inpayment.Sale.SaleStatus != SaleStatus.PositiveClosed)
		{
			InpaymentManager.Instance.SetInpaymentStatus(inpayment, statusModel.Value, statusModel.ActualDate, statusModel.Comment);
		}
		IInpaymentFilter inpaymentFilter = InterfaceActivator.Create<IInpaymentFilter>();
		inpaymentFilter.Sale = inpayment.Sale;
		SaleInpaymentsModel saleInpaymentsModel = new SaleInpaymentsModel();
		saleInpaymentsModel.Sale = inpayment.Sale;
		saleInpaymentsModel.GridData = EntityManager<IInpayment>.Instance.CreateGridData(null, inpaymentFilter);
		return (ActionResult)(object)((Controller)this).PartialView("SaleInpayments/Grid", (object)saleInpaymentsModel);
	}

	[HttpPost]
	public JsonResult CheckPlanCompleted(long id)
	{
		ISale sale = SaleManager.Instance.Load(id);
		return ((Controller)this).Json((object)new
		{
			success = true,
			planCompleted = sale.InpaymentsPlanCompleted
		});
	}
}
