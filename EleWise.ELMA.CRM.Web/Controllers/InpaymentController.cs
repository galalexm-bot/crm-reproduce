// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.InpaymentController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

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
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Forms;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using System;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
    [AllPermissions(new string[] { "{46401803-1B46-4E60-8DA0-227FF8CF60F3}", "{EE6119AA-D9B9-4FDA-8EA3-7C3B92B4956E}" })]
    [RouteArea("EleWise.ELMA.CRM.Web")]
    public class InpaymentController : FilterTreeBaseController<IInpayment, long>
    {
        public static IProductionCalendarService Calendar => Locator.GetServiceNotNull<IProductionCalendarService>();

        public IProductionSchedule ProductionSchedule => InpaymentController.Calendar.GetGlobalProductionSchedule(Locator.GetServiceNotNull<ITimeZoneService>().CurrentUserTimeZone.Settings);

        public IUnionComplexCacheService ComplexCacheService { get; set; }

        [ContentItem(Name = "SR.M('План поступлений')", Image24 = "#budget.svg")]
        [FilterMenuItem(Id = "crm-inpayments", Type = typeof(IInpayment), FilterEditAction = "EditFilters")]
        public ActionResult Index(long? FilterId = null) => this.BaseIndex(FilterId, nameof(FilterId), nameof(Index), new Guid?()) ?? View((object)this.CreateGridData((GridCommand)null, this.CreateFilter(FilterId, new Guid?(), (IEntityFilter)null, (EleWise.ELMA.Web.Mvc.Models.Grids.GridState)null, "Filter")));

        public ActionResult Search(long? FilterId = null)
        {
            if (base.Request.QueryString.Count == 0)
            {
                return RedirectToAction("Index");
            }
            FilterModel filter = CreateFilter(FilterId);
            GridDataFilter<InpaymentModel> model = CreateGridData(null, filter);
            return View("Index", model);
        }

        [DetailsAction]
        [EntityLink]
        public ActionResult Details(long id, int? tabIndex = 0)
        {
            try
            {
                if (tabIndex.HasValue)
                    ((ControllerBase)this).ViewData["SelectedTab"] = (object)tabIndex.Value;
                return View(base.Manager.Load(id));
            }
            catch (Exception ex)
            {
                Notifier.Error(ex);
                return RedirectToAction("Index", "Inpayment");
            }
        }

        public ActionResult Edit(long id) => View((object)InpaymentManager.Instance.Load(id));

        [HttpPost]
        public ActionResult Edit(IInpayment model)
        {
            if (model.Sale.SaleClosed())
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(EleWise.ELMA.SR.T("Нельзя изменить поступление по закрытой сделке"));
                return Redirect(((Controller)this).Url.ReturnUrl());
            }
            try
            {
                model.Save();
            }
            catch (Exception ex)
            {
                ((BaseController)this).Logger.Log(EleWise.ELMA.Logging.LogLevel.Error, ex, "Error while saving Inpayment");
                // ISSUE: explicit non-virtual call
                Notifier.Error(EleWise.ELMA.SR.T("Произошла ошибка во время сохранения"));
            }
            return RedirectToAction("Details", (object)new
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
                Notifier.Information(EleWise.ELMA.SR.T("Поступление \"{0}\" удалено", (object)inpayment.Name));
                return RedirectToAction("Index", "Inpayment", (object)new
                {
                    area = "EleWise.ELMA.CRM.Web"
                });
            }
            catch (Exception ex)
            {
                Notifier.Error(ex);
                return RedirectToAction("Index", "Inpayment", (object)new
                {
                    area = "EleWise.ELMA.CRM.Web"
                });
            }
        }

        [HttpGet]
        public ActionResult AddCommentPopup(long id, Guid typeUid, string popupId)
        {
            CommentWithAttachments commentWithAttachments1 = new CommentWithAttachments();
            commentWithAttachments1.ShowAttachment = false;
            commentWithAttachments1.PopupId = popupId;
            commentWithAttachments1.ObjectId = id;
            commentWithAttachments1.ObjectTypeUid = typeUid;
            commentWithAttachments1.AddCommentActionUid = InpaymentActions.AddCommentGuid;
            ((FormViewModel)commentWithAttachments1).RedirectUrl = ((Controller)this).Url.Action("Details", "Inpayment", (object)new
            {
                area = "EleWise.ELMA.CRM.Web",
                id = id
            });
            CommentWithAttachments commentWithAttachments2 = commentWithAttachments1;
            ((ControllerBase)this).ViewData.TemplateInfo = new TemplateInfo()
            {
                HtmlFieldPrefix = commentWithAttachments2.HtmlPrefix
            };
            return RedirectToAction("PopupCommentContent", "Comment", (object)new
            {
                area = "EleWise.ELMA.BPM.Web.Common",
                PopupId = commentWithAttachments2.PopupId,
                ObjectId = commentWithAttachments2.ObjectId,
                ShowAttachment = commentWithAttachments2.ShowAttachment,
                RedirectUrl = ((FormViewModel)commentWithAttachments2).RedirectUrl,
                ObjectTypeUid = commentWithAttachments2.ObjectTypeUid,
                PostAction = ((FormViewModel)commentWithAttachments2).PostAction,
                PostController = ((FormViewModel)commentWithAttachments2).PostController,
                PostArea = ((FormViewModel)commentWithAttachments2).PostArea,
                ActionName = commentWithAttachments2.ActionName,
                AddCommentActionUid = commentWithAttachments2.AddCommentActionUid,
                HtmlPrefix = commentWithAttachments2.HtmlPrefix
            });
        }

        [HttpGet]
        public ActionResult AskQuestionPopup(long id, Guid typeUid, string popupId)
        {
            QuestionModel questionModel1 = new QuestionModel();
            questionModel1.PopupId = popupId;
            questionModel1.ObjectId = id;
            questionModel1.ObjectTypeUid = typeUid;
            questionModel1.AddQuestionActionUid = InpaymentActions.AddQuestionGuid;
            ((FormViewModel)questionModel1).RedirectUrl = ((Controller)this).Url.Action("Details", "Inpayment", (object)new
            {
                area = "EleWise.ELMA.CRM.Web",
                id = id
            });
            QuestionModel questionModel2 = questionModel1;
            return RedirectToAction("QuestionCreateForm", "Question", (object)new
            {
                area = "EleWise.ELMA.BPM.Web.Tasks",
                PopupId = questionModel2.PopupId,
                PostAction = ((FormViewModel)questionModel2).PostAction,
                PostController = ((FormViewModel)questionModel2).PostController,
                PostArea = ((FormViewModel)questionModel2).PostArea,
                ObjectId = questionModel2.ObjectId,
                ObjectTypeUid = questionModel2.ObjectTypeUid,
                RedirectUrl = ((FormViewModel)questionModel2).RedirectUrl,
                AddQuestionActionUid = questionModel2.AddQuestionActionUid
            });
        }

        internal DateTime GetWeekStart()
        {
            DateTime runtimeDateTime = DateTime.Today.AddDays((double)-((Convert.ToInt64((object)DateTime.Now.DayOfWeek) + 6L) % 7L));
            while (!this.ProductionSchedule.IsWorkDay(runtimeDateTime))
                runtimeDateTime = runtimeDateTime.AddDays(1.0);
            return runtimeDateTime;
        }

        public DateTime FirstDayOfMonth(DateTime dateTime) => new DateTime(dateTime.Year, dateTime.Month, 1);

        [CustomGridAction]
        public ActionResult OldInpaymentsGridAction(
          GridCommand command,
          [Bind(Prefix = "DataFilter")] FilterModel filter,
          [Bind(Prefix = "StatusSet0")] InpaymentStatusFilterModel statusFilter,
          long? FilterId = null,
          bool portletView = false,
          bool showOnlyMy = false,
          Guid? instanceId = null)
        {
            DateTime endDate = this.FirstDayOfMonth(this.GetWeekStart()).AddSeconds(-1.0);
            InpaymentSubPanelModel model = this.CommonGridAction(command, filter, portletView ? (InpaymentStatusFilterModel)null : statusFilter, FilterId, DateTime.MinValue, endDate, 0, portletView, showOnlyMy, instanceId);
            model.StartDate = DateTime.MinValue;
            model.EndDate = endDate;
            model.CheckBoxInPlan = false;
            model.HideTotalInPlanWithoutDate = true;
            return PartialView("SubPanelGrid", (object)model);
        }

        [CustomGridAction]
        public ActionResult ThisMonthBeforeWeekGridAction(
          GridCommand command,
          [Bind(Prefix = "DataFilter")] FilterModel filter,
          [Bind(Prefix = "StatusSet1")] InpaymentStatusFilterModel statusFilter,
          long? FilterId = null,
          bool portletView = false,
          bool showOnlyMy = false,
          Guid? instanceId = null)
        {
            DateTime startDate = this.FirstDayOfMonth(this.GetWeekStart());
            DateTime endDate = this.GetWeekStart().AddSeconds(-1.0);
            InpaymentSubPanelModel model = this.CommonGridAction(command, filter, portletView ? (InpaymentStatusFilterModel)null : statusFilter, FilterId, startDate, endDate, 1, portletView, showOnlyMy, instanceId);
            model.CheckBoxInPlan = false;
            model.StartDate = startDate;
            model.EndDate = endDate;
            model.HideTotalInPlanWithoutDate = true;
            return PartialView("SubPanelGrid", (object)model);
        }

        [CustomGridAction]
        public ActionResult CurrentWeekGridAction(
          GridCommand command,
          [Bind(Prefix = "DataFilter")] FilterModel filter,
          [Bind(Prefix = "StatusSet2")] InpaymentStatusFilterModel statusFilter,
          long? FilterId = null,
          bool portletView = false,
          bool showOnlyMy = false,
          Guid? instanceId = null)
        {
            DateTime weekStart = this.GetWeekStart();
            DateTime runtimeDateTime = weekStart;
            while (this.ProductionSchedule.IsWorkDay(runtimeDateTime))
                runtimeDateTime = runtimeDateTime.AddDays(1.0);
            DateTime endDate = runtimeDateTime.Date.AddSeconds(-1.0);
            InpaymentSubPanelModel model = this.CommonGridAction(command, filter, portletView ? (InpaymentStatusFilterModel)null : statusFilter, FilterId, weekStart, endDate, 2, portletView, showOnlyMy, instanceId);
            model.StartDate = weekStart;
            model.EndDate = endDate;
            model.HideTotalInPlanWithoutDate = true;
            return PartialView("SubPanelGrid", (object)model);
        }

        [CustomGridAction]
        public ActionResult ThisMonthAfterWeekGridAction(
          GridCommand command,
          [Bind(Prefix = "DataFilter")] FilterModel filter,
          [Bind(Prefix = "StatusSet3")] InpaymentStatusFilterModel statusFilter,
          long? FilterId = null,
          bool portletView = false,
          bool showOnlyMy = false,
          Guid? instanceId = null)
        {
            DateTime dateTime = this.GetWeekStart();
            while (this.ProductionSchedule.IsWorkDay(dateTime))
                dateTime = dateTime.AddDays(1.0);
            DateTime endDate = this.FirstDayOfMonth(dateTime.AddMonths(1)).AddSeconds(-1.0);
            InpaymentSubPanelModel model = this.CommonGridAction(command, filter, portletView ? (InpaymentStatusFilterModel)null : statusFilter, FilterId, dateTime, endDate, 3, portletView, showOnlyMy, instanceId);
            model.CheckBoxOverdue = false;
            model.StartDate = dateTime;
            model.EndDate = endDate;
            model.HideTotalInPlanWithoutDate = true;
            return PartialView("SubPanelGrid", (object)model);
        }

        [CustomGridAction]
        public ActionResult FarFutureGridAction(
          GridCommand command,
          [Bind(Prefix = "DataFilter")] FilterModel filter,
          [Bind(Prefix = "StatusSet4")] InpaymentStatusFilterModel statusFilter,
          long? FilterId = null,
          bool portletView = false,
          bool showOnlyMy = false,
          Guid? instanceId = null)
        {
            DateTime runtimeDateTime = this.GetWeekStart();
            while (this.ProductionSchedule.IsWorkDay(runtimeDateTime))
                runtimeDateTime = runtimeDateTime.AddDays(1.0);
            DateTime startDate = this.FirstDayOfMonth(runtimeDateTime.AddMonths(1));
            InpaymentSubPanelModel model = this.CommonGridAction(command, filter, portletView ? (InpaymentStatusFilterModel)null : statusFilter, FilterId, startDate, DateTime.MaxValue, 4, portletView, showOnlyMy, instanceId);
            model.CheckBoxOverdue = false;
            model.StartDate = startDate;
            model.EndDate = DateTime.MaxValue;
            return PartialView("SubPanelGrid", (object)model);
        }

        protected GridDataFilter<InpaymentModel> CreateGridData(GridCommand command, FilterModel filter)
        {
            GridDataFilter<InpaymentModel> gridData = new GridDataFilter<InpaymentModel>();
            ((GridData<InpaymentModel>)gridData).Command = command;
            gridData.DataFilter = filter;
            ((GridData<InpaymentModel>)gridData).SetDataSource((Func<GridData<InpaymentModel>, FetchOptions, IEnumerable>)((d, f) => (IEnumerable)InpaymentManager.Instance.GetInpayments((IInpaymentFilter)filter.Filter, f)));
            ((GridData<InpaymentModel>)gridData).SetCount((Func<GridData<InpaymentModel>, FetchOptions, long>)((d, f) => (long)InpaymentManager.Instance.GetInpaymentsCount((IInpaymentFilter)filter.Filter)));
            return gridData;
        }

        internal InpaymentSubPanelModel CommonGridAction(
          GridCommand command,
          FilterModel filter,
          InpaymentStatusFilterModel statusFilter,
          long? FilterId,
          DateTime startDate,
          DateTime endDate,
          int gridNo,
          bool portletView = false,
          bool showOnlyMy = false,
          Guid? instanceId = null)
        {
            if (filter == null)
                filter = this.CreateFilter(new long?(FilterId ?? 0L), new Guid?(), (IEntityFilter)null, (EleWise.ELMA.Web.Mvc.Models.Grids.GridState)null, "Filter");
            if (statusFilter == null)
                statusFilter = InpaymentPersonalizationAdministration.LoadState(string.Format("{0}{1}_StatusSet{2}", portletView ? (object)string.Format("Portlet_{0}_", (object)instanceId) : (object)string.Empty, (object)InpaymentController.GetGridIds[gridNo], (object)gridNo)) ?? new InpaymentStatusFilterModel();
            else
                InpaymentPersonalizationAdministration.SaveState(string.Format("{0}{1}_StatusSet{2}", portletView ? (object)string.Format("Portlet_{0}_", (object)instanceId) : (object)string.Empty, (object)InpaymentController.GetGridIds[gridNo], (object)gridNo), statusFilter);
            IInpaymentFilter filter1 = (IInpaymentFilter)filter.Filter;
            filter1.GridDateRange = new DateTimeRange(new DateTime?(startDate), new DateTime?(endDate));
            if (!statusFilter.IsOverdue)
                filter1.IsOverdue = new bool?(false);
            if (!statusFilter.InPlan)
                filter1.InPlan = new bool?(false);
            if (!statusFilter.Received)
                filter1.Received = new bool?(false);
            if (!statusFilter.Cancelled)
                filter1.Cancelled = new bool?(false);
            filter1.ShowOnlyMy = showOnlyMy;
            InpaymentSubPanelModel inpaymentSubPanelModel = new InpaymentSubPanelModel(filter1)
            {
                GridData = this.CreateGridData(command, filter)
            };
            inpaymentSubPanelModel.GridData.GridId = portletView ? string.Format("{0}_{1}", (object)InpaymentController.GetGridIds[gridNo], (object)instanceId) : InpaymentController.GetGridIds[gridNo];
            inpaymentSubPanelModel.GridAction = InpaymentController.GetGridIds[gridNo] + "Action";
            inpaymentSubPanelModel.StatusSetPrefix = "StatusSet" + (object)gridNo;
            inpaymentSubPanelModel.PortletView = portletView;
            inpaymentSubPanelModel.InstanceId = instanceId ?? Guid.Empty;
            inpaymentSubPanelModel.StatusFilterModel = statusFilter;
            return inpaymentSubPanelModel;
        }

        public static string[] GetGridIds => new string[5]
        {
      "OldInpaymentsGrid",
      "ThisMonthBeforeWeekGrid",
      "CurrentWeekGrid",
      "ThisMonthAfterWeekGrid",
      "FarFutureGrid"
        };

        protected virtual bool EnableEqlQuery => true;

        [HttpGet]
        public ActionResult InpaymentPortlet(InpaymentPortletPersonalization settings) => PartialView((object)new InpaymentPortletModel()
        {
            InstanceId = settings.InstanceId,
            FilterId = (settings.Filter != null ? new long?(settings.Filter.Id) : new long?()),
            ShowOnlyMy = settings.ShowOnlyMy,
            SplitByPeriods = settings.SplitByPeriods
        });

        [CustomGridAction]
        public ActionResult PortletGrid(
          GridCommand command,
          long? filterId,
          bool showOnlyMy,
          Guid instanceId)
        {
            FilterModel filter1 = this.CreateFilter(filterId, new Guid?(), (IEntityFilter)null, (EleWise.ELMA.Web.Mvc.Models.Grids.GridState)null, "Filter");
            IInpaymentFilter filter2 = (IInpaymentFilter)filter1.Filter;
            filter2.ShowOnlyMy = showOnlyMy;
            return PartialView((object)new InpaymentSubPanelModel(filter2)
            {
                GridData = this.CreateGridData(command, filter1),
                PortletView = true,
                InstanceId = instanceId
            });
        }

        public ActionResult PortletSplitGrids(long? filterId, bool showOnlyMy, Guid instanceId) => PartialView((object)new InpaymentPortletModel()
        {
            InstanceId = instanceId,
            FilterId = filterId,
            ShowOnlyMy = showOnlyMy,
            SplitByPeriods = true
        });

        [CustomGridAction]
        public ActionResult Inpayments(GridCommand command, long saleId, bool readOnly = false)
        {
            ISale sale = SaleManager.Instance.Load(saleId);
            IInpaymentFilter filter = InterfaceActivator.Create<IInpaymentFilter>();
            filter.Sale = sale;
            return PartialView("SaleInpayments/Inpayments", (object)new SaleInpaymentsModel()
            {
                Sale = sale,
                GridData = (GridData<IInpayment>)EntityManager<IInpayment>.Instance.CreateGridData<IInpayment, IInpaymentFilter>(command, filter)
            });
        }

        [HttpGet]
        public ActionResult AddInpayment(long? saleId)
        {
            SaleInpaymentEditModel model = new SaleInpaymentEditModel()
            {
                Inpayment = InterfaceActivator.Create<IInpayment>()
            };
            model.Inpayment.Sale = saleId.HasValue ? SaleManager.Instance.Load(saleId.Value) : (ISale)null;
            // ISSUE: explicit non-virtual call
            model.Inpayment.Responsible = base.AuthenticationService.GetCurrentUser<IUser>();
            return PartialView("EditInpayment", (object)model);
        }

        [HttpGet]
        public ActionResult EditInpayment(long id) => PartialView(nameof(EditInpayment), (object)new SaleInpaymentEditModel()
        {
            Inpayment = EntityManager<IInpayment>.Instance.Load((object)id)
        });

        [HttpPost]
        public ActionResult EditInpayment(SaleInpaymentEditModel model)
        {
            if (model.CloseInpaymentsPlan && model.Inpayment.Sale != null)
            {
                model.Inpayment.Sale.InpaymentsPlanCompleted = true;
                model.Inpayment.Sale.SalesVolume = new double?(EntityManager<IInpayment>.Instance.Find((IEntityFilter)new InstanceOf<IInpaymentFilter>()
                {
                    New = {
            Sale = model.Inpayment.Sale
          }
                }.New, FetchOptions.All).Sum<IInpayment>((Func<IInpayment, double>)(x => (double)x.Sum)) + (double)model.Inpayment.Sum);
                model.Inpayment.Sale.Save();
            }
            if (model.Inpayment.Sale.SaleStatus != SaleStatus.NegativeClosed && model.Inpayment.Sale.SaleStatus != SaleStatus.PositiveClosed)
            {
                if (model.Inpayment.IsNew())
                {
                    // ISSUE: explicit non-virtual call
                    Notifier.Information(EleWise.ELMA.SR.T("Поступление успешно создано"));
                }
                model.Inpayment.Save();
                this.UpdateSalesVolume(model.Inpayment.Sale);
                return ((BaseController)this).SuccessJson();
            }
            if (model.Inpayment.IsNew())
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(EleWise.ELMA.SR.T("Нельзя добавить поступление по закрытой сделке"));
            }
            return ((BaseController)this).ErrorJson(EleWise.ELMA.SR.T("Нельзя добавить или изменить поступление по закрытой сделке"));
        }

        private void UpdateSalesVolume(ISale sale)
        {
            if (!sale.InpaymentsPlanCompleted)
                return;
            double num = EntityManager<IInpayment>.Instance.Find((Expression<Func<IInpayment, bool>>)(i => i.Sale == sale)).Where<IInpayment>((Func<IInpayment, bool>)(x => x.Status != InpaymentStatus.Cancelled)).Sum<IInpayment>((Func<IInpayment, double>)(x => (double)x.Sum));
            sale.SalesVolume = new double?(num);
            sale.Save();
        }

        public ActionResult UpdateInpaymentsGrid(ISale sale)
        {
            IInpaymentFilter filter = InterfaceActivator.Create<IInpaymentFilter>();
            filter.Sale = sale;
            return PartialView("SaleInpayments/Grid", (object)new SaleInpaymentsModel()
            {
                Sale = sale,
                GridData = (GridData<IInpayment>)EntityManager<IInpayment>.Instance.CreateGridData<IInpayment, IInpaymentFilter>((GridCommand)null, filter)
            });
        }

        [Permission("E56A21C6-2981-4BCF-AB5E-9F012811197D")]
        public ActionResult DeleteInpayment(long id, bool readOnly = false)
        {
            IInpayment inpayment = EntityManager<IInpayment>.Instance.Load((object)id);
            ISale sale = inpayment.Sale;
            inpayment.Delete();
            this.UpdateSalesVolume(sale);
            return this.UpdateInpaymentsGrid(sale);
        }

        [HttpPost]
        public ActionResult CloseInpaymentsPlan(long id, Money inpaymentsTotal)
        {
            ISale sale = SaleManager.Instance.Load(id);
            sale.InpaymentsPlanCompleted = true;
            sale.SalesVolume = new double?(EntityManager<IInpayment>.Instance.Find((Expression<Func<IInpayment, bool>>)(x => x.Sale != default(object) && x.Sale.Id == id)).Sum<IInpayment>((Func<IInpayment, double>)(x => (double)x.Sum)) + (double)inpaymentsTotal);
            sale.Save();
            return (ActionResult)new EmptyResult();
        }

        [HttpPost]
        public ActionResult SetInpaymentInvoice(long id)
        {
            IInpayment inpayment = EntityManager<IInpayment>.Instance.Load((object)id);
            if (inpayment.Sale.SaleStatus != SaleStatus.NegativeClosed && inpayment.Sale.SaleStatus != SaleStatus.PositiveClosed)
            {
                inpayment.Invoice = true;
                inpayment.Save();
            }
            IInpaymentFilter filter = InterfaceActivator.Create<IInpaymentFilter>();
            filter.Sale = inpayment.Sale;
            return PartialView("SaleInpayments/Grid", (object)new SaleInpaymentsModel()
            {
                Sale = inpayment.Sale,
                GridData = (GridData<IInpayment>)EntityManager<IInpayment>.Instance.CreateGridData<IInpayment, IInpaymentFilter>((GridCommand)null, filter)
            });
        }

        [HttpPost]
        public ActionResult SetInpaymentDate(long id, DateTime? date)
        {
            IInpayment inpayment = EntityManager<IInpayment>.Instance.Load((object)id);
            if (inpayment.Sale.SaleStatus != SaleStatus.NegativeClosed && inpayment.Sale.SaleStatus != SaleStatus.PositiveClosed)
            {
                if (date.HasValue)
                    InpaymentManager.Instance.SetInpaymentDate(inpayment, date.Value);
                else
                    InpaymentManager.Instance.SetInpaymentDate(inpayment);
            }
            IInpaymentFilter filter = InterfaceActivator.Create<IInpaymentFilter>();
            filter.Sale = inpayment.Sale;
            return PartialView("SaleInpayments/Grid", (object)new SaleInpaymentsModel()
            {
                Sale = inpayment.Sale,
                GridData = (GridData<IInpayment>)EntityManager<IInpayment>.Instance.CreateGridData<IInpayment, IInpaymentFilter>((GridCommand)null, filter)
            });
        }

        [HttpGet]
        public ActionResult SetInpaymentStatus(long id, string prefix)
        {
            IInpayment inpayment = EntityManager<IInpayment>.Instance.Load((object)id);
            InpaymentChangeStatusModel model = new InpaymentChangeStatusModel()
            {
                InpaymentId = id,
                Value = inpayment.Status,
                ActualDate = inpayment.ActualDate
            };
            ((ControllerBase)this).ViewData.TemplateInfo.HtmlFieldPrefix = prefix;
            return PartialView("SetInpaymentStatusPopup", (object)model);
        }

        [HttpPost]
        public ActionResult SetInpaymentStatus(InpaymentChangeStatusModel statusModel)
        {
            IInpayment inpayment = EntityManager<IInpayment>.Instance.Load((object)statusModel.InpaymentId);
            if (inpayment.Sale.SaleStatus != SaleStatus.NegativeClosed && inpayment.Sale.SaleStatus != SaleStatus.PositiveClosed)
                InpaymentManager.Instance.SetInpaymentStatus(inpayment, statusModel.Value, statusModel.ActualDate, statusModel.Comment);
            IInpaymentFilter filter = InterfaceActivator.Create<IInpaymentFilter>();
            filter.Sale = inpayment.Sale;
            return PartialView("SaleInpayments/Grid", (object)new SaleInpaymentsModel()
            {
                Sale = inpayment.Sale,
                GridData = (GridData<IInpayment>)EntityManager<IInpayment>.Instance.CreateGridData<IInpayment, IInpaymentFilter>((GridCommand)null, filter)
            });
        }

        [HttpPost]
        public JsonResult CheckPlanCompleted(long id)
        {
            ISale sale = SaleManager.Instance.Load(id);
            return Json(new
            {
                success = true,
                planCompleted = sale.InpaymentsPlanCompleted
            });
        }
    }
}
