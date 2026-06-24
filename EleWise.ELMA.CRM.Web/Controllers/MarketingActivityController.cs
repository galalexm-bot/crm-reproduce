// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.MarketingActivityController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

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
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Models.Boxes;
using EleWise.ELMA.Web.Mvc.Models.Forms;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Telerik.Web.Mvc;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.CRM.Web.Controllers
{
    [AllPermissions(new string[] { "{46401803-1B46-4E60-8DA0-227FF8CF60F3}", "{5A9420EC-B6AD-4610-982B-4795E850A72E}" })]
    [RouteArea("EleWise.ELMA.CRM.Web")]
    public class MarketingActivityController : FilterTreeBaseController<IMarketingBase, long>
    {
        protected IMarketingBaseFilter CreateFilter()
        {
            InstanceOf<IMarketingBaseFilter> instanceOf = new InstanceOf<IMarketingBaseFilter>();
            instanceOf.New.PermissionId = new Guid?(CRMPermissionProvider.CRMAccessPermission.Id);
            return instanceOf.New;
        }

        [ContentItem(Name = "SR.M('Маркетинг')", Image24 = "#target.svg")]
        [FilterMenuItem(Id = "crm-marketing-aktivities", Type = typeof(IMarketingBase), FilterEditAction = "EditFilters")]
        public ActionResult Index(long? FilterId = null) => this.BaseIndex(FilterId, nameof(FilterId), nameof(Index), new Guid?()) ?? View((object)this.CreateGridData((GridCommand)null, this.CreateFilter(FilterId, new Guid?(), (IEntityFilter)null, (EleWise.ELMA.Web.Mvc.Models.Grids.GridState)null, "Filter")));

        public ActionResult Search(long? FilterId = null)
        {
            if (base.Request.QueryString.Count == 0)
            {
                return RedirectToAction("Index");
            }
            FilterModel filter = CreateFilter(FilterId);
            GridDataFilter<IMarketingBase> model = CreateGridData(null, filter);
            return View("Index", model);
        }

        [Permission("{12F5ECDA-DDFF-422F-83DE-BFF4E94ACD1E}")]
        public ActionResult Create(Guid typeUid, long? parentId)
        {
            MarketingActivityModel model = (MarketingActivityModel)null;
            bool flag = parentId.HasValue && !base.SecurityService.HasPermission(CRMPermissionProvider.MarketingFullAccessPermission);
            if (typeUid == InterfaceActivator.UID<IMarketingActivity>())
            {
                IMarketingActivity marketingActivity = InterfaceActivator.Create<IMarketingActivity>();
                marketingActivity.Responsible = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
                marketingActivity.MarketingGroup = parentId.HasValue ? MarketingGroupManager.Instance.Load(parentId.Value) : (IMarketingGroup)null;
                model = new MarketingActivityModel((IMarketingBase)marketingActivity)
                {
                    LockParentItem = flag,
                    LockResponsible = flag
                };
            }
            else if (typeUid == InterfaceActivator.UID<IMarketingGroup>())
            {
                IMarketingGroup marketingActivity = InterfaceActivator.Create<IMarketingGroup>();
                marketingActivity.Responsible = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
                model = new MarketingActivityModel((IMarketingBase)marketingActivity);
            }
            else if (typeUid == InterfaceActivator.UID<IMarketingEffect>())
            {
                IMarketingEffect marketingActivity = InterfaceActivator.Create<IMarketingEffect>();
                marketingActivity.MarketingActivity = parentId.HasValue ? MarketingActivityManager.Instance.Load(parentId.Value) : (IMarketingActivity)null;
                marketingActivity.Responsible = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
                model = new MarketingActivityModel((IMarketingBase)marketingActivity)
                {
                    LockParentItem = flag,
                    LockResponsible = flag
                };
            }
            model.Entity.BudgetType = MarketingBudgetType.SumOfChild;
            return View((object)model);
        }

        [HttpPost]
        [Permission("{12F5ECDA-DDFF-422F-83DE-BFF4E94ACD1E}")]
        public ActionResult Create(MarketingActivityModel model)
        {
            try
            {
                model.Save();
                return RedirectToAction("Details", "MarketingActivity", (object)new
                {
                    id = model.Entity.Id
                });
            }
            catch (Exception ex)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(ex);
                return View((object)model);
            }
        }

        public ActionResult GetMarketingTags(long id)
        {
            try
            {
                return PartialView("MarketingTagParent", (object)MarketingBaseManager.Instance.Load(id));
            }
            catch (Exception ex)
            {
                return Json((object)new
                {
                    success = false,
                    error = ex.Message
                }, "text/html");
            }
        }

        [DetailsAction]
        [EntityLink]
        public ActionResult Details(long id, string selectedTab)
        {
            try
            {
                // ISSUE: explicit non-virtual call
                IMarketingBase marketingActivity = base.Manager.Load(id).CastAsRealType<IMarketingBase>();
                ((ControllerBase)this).ViewData["SelectedTab"] = (object)selectedTab;
                ThrowExceptionIfDeleted((ISoftDeletable)marketingActivity);
                return View((object)new MarketingActivityModel(marketingActivity));
            }
            catch (Exception ex)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(ex);
                return RedirectToAction("Index", "MarketingActivity");
            }
        }

        [Permission("{7D45412B-8491-49B7-B033-93FFE3F394E5}")]
        public ActionResult Edit(long id)
        {
            try
            {
                IMarketingBase marketingActivity = base.Manager.Load(id).CastAsRealType<IMarketingBase>();
                ThrowExceptionIfDeleted((ISoftDeletable)marketingActivity);
                return View((object)new MarketingActivityModel(marketingActivity));
            }
            catch (Exception ex)
            {
                Notifier.Error(ex);
                return RedirectToAction("Index", "MarketingActivity");
            }
        }

        [Permission("{7D45412B-8491-49B7-B033-93FFE3F394E5}")]
        [HttpPost]
        public ActionResult Edit(MarketingActivityModel model)
        {
            try
            {
                model.Save();
                return RedirectToAction("Details", "MarketingActivity", (object)new
                {
                    id = model.Entity.Id
                });
            }
            catch (Exception ex)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(ex);
                return View((object)model);
            }
        }

        [HttpGet]
        [Permission("{81B30D9D-42F8-483F-A8D7-EC7E2E0F7CAD}")]
        public ActionResult Delete(long id)
        {
            try
            {
                // ISSUE: explicit non-virtual call
                IMarketingBase marketingBase = base.Manager.Load(id);
                marketingBase.Delete();
                // ISSUE: explicit non-virtual call
                Notifier.Information(EleWise.ELMA.SR.T("Маркетинговое мероприятие \"{0}\" успешно удалено", (object)marketingBase.Name));
                return RedirectToAction("Index", "MarketingActivity", (object)new
                {
                    area = "EleWise.ELMA.CRM.Web"
                });
            }
            catch (Exception ex)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(ex);
                return RedirectToAction("Index", "MarketingActivity", (object)new
                {
                    area = "EleWise.ELMA.CRM.Web"
                });
            }
        }

        [CustomGridAction]
        public ActionResult MarketingActivityContractors(
          GridCommand command,
          IMarketingBase marketingBase,
          string tabId)
        {
            GridData<IContractor> model = MarketingActivityRelatedEntitiesFinder.Find<IContractor>(command, marketingBase.CastAsRealType<IMarketingBase>());
            ((ControllerBase)this).ViewData["TabId"] = (object)tabId;
            return PartialView("RelatedMarketingActivityEntities/RelatedContractorsGrid", (object)model);
        }

        [CustomGridAction]
        public ActionResult MarketingActivityLeads(
          GridCommand command,
          IMarketingBase marketingBase,
          string tabId)
        {
            GridData<ILead> model = MarketingActivityRelatedEntitiesFinder.Find<ILead>(command, marketingBase.CastAsRealType<IMarketingBase>());
            ((ControllerBase)this).ViewData["TabId"] = (object)tabId;
            return PartialView("RelatedMarketingActivityEntities/RelatedLeadsGrid", (object)model);
        }

        [CustomGridAction]
        public ActionResult MarketingActivitySales(
          GridCommand command,
          IMarketingBase marketingBase,
          string tabId)
        {
            GridData<ISale> model = MarketingActivityRelatedEntitiesFinder.Find<ISale>(command, marketingBase.CastAsRealType<IMarketingBase>());
            ((ControllerBase)this).ViewData["TabId"] = (object)tabId;
            return PartialView("RelatedMarketingActivityEntities/RelatedSalesGrid", (object)model);
        }

        [CustomGridAction]
        public ActionResult MarketingActivityStatistic(
          GridCommand command,
          IMarketingBase marketingBase,
          string tabId)
        {
            MarketingStatisticModel model = new MarketingStatisticModel(marketingBase, MarketingPeriodEnum.Month, DateTime.Today);
            ((ControllerBase)this).ViewData["TabId"] = (object)tabId;
            return PartialView("MarketingStatistic/MarketingStatisticObject", (object)model);
        }

        [CustomGridAction]
        public ActionResult GroupActivitiesGrid(GridCommand command, IMarketingGroup marketingGroup)
        {
            IMarketingActivityFilter filter = InterfaceActivator.Create<IMarketingActivityFilter>();
            filter.MarketingGroup = marketingGroup;
            return PartialView((object)AbstractNHEntityManager<IMarketingActivity, long>.Instance.CreateGridData<IMarketingActivity, IMarketingActivityFilter>(command, filter));
        }

        [CustomGridAction]
        public ActionResult GroupEffectGrid(GridCommand command, IMarketingGroup marketingGroup)
        {
            IMarketingEffectFilter filter = InterfaceActivator.Create<IMarketingEffectFilter>();
            ICollection<IMarketingEffect> source;
            if (marketingGroup.MarketingActivities.Count > 0)
            {
                filter.Query = string.Format("MarketingActivity IN ({0})", (object)string.Join<long>(",", marketingGroup.MarketingActivities.Select<IMarketingActivity, long>((Func<IMarketingActivity, long>)(ma => ma.Id))));
                source = AbstractNHEntityManager<IMarketingEffect, long>.Instance.Find((IEntityFilter)filter, FetchOptions.All);
            }
            else
                source = (ICollection<IMarketingEffect>)new List<IMarketingEffect>();
            return PartialView((object)source.CreateGridData<IMarketingEffect>("MarketingActivity"));
        }

        [CustomGridAction]
        public ActionResult ActivityEffectsGrid(
          GridCommand command,
          long marketingActivityId,
          bool? pagable)
        {
            IMarketingEffectFilter filter = InterfaceActivator.Create<IMarketingEffectFilter>();
            filter.MarketingActivity = MarketingActivityManager.Instance.Load(marketingActivityId);
            GridData<IMarketingEffect, IMarketingEffectFilter> gridData = AbstractNHEntityManager<IMarketingEffect, long>.Instance.CreateGridData<IMarketingEffect, IMarketingEffectFilter>(command, filter);
            gridData.IsPageable = pagable ?? true;
            return PartialView((object)gridData);
        }

        public ActionResult AssignActivityToManyEntities(
          long[] entitiesId,
          Guid entityTypeUid,
          string redirectControllerName,
          string redirectActionName,
          string entitiesName,
          string entitiesNameForErrorMessage)
        {
            return PartialView("SelectMarketingActivity", (object)new SelectMarketingActivityModel()
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
                return RedirectToAction(model.RedirectActionName, model.RedirectControllerName);
            Type typeByUid = Locator.GetService<IMetadataRuntimeService>().GetTypeByUid(model.EntityTypeUid);
            if (typeByUid == (Type)null)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(EleWise.ELMA.SR.T("Неизвестный Guid типа: {0}", (object)model.EntityTypeUid));
                return RedirectToAction(model.RedirectActionName, model.RedirectControllerName);
            }
            bool anySuccessOperation = false;
            string errorItems = string.Empty;
            IEntityManager entityManager = ModelHelper.GetEntityManager(typeByUid);
            foreach (long id in model.EntitiesId)
            {
                if (entityManager.LoadOrNull((object)id) is IEntity<long> entity && entity is IMarketingActivityTarget)
                {
                    string Name;
                    if (!this.CheckEditPermission(entity, out Name))
                    {
                        errorItems = errorItems + Name + ", ";
                    }
                    else
                    {
                        anySuccessOperation = true;
                        (entity as IMarketingActivityTarget).MarketingGroup = model.MarketingGroup;
                        (entity as IMarketingActivityTarget).MarketingActivity = model.MarketingActivity;
                        (entity as IMarketingActivityTarget).MarketingEffect = model.MarketingEffect;
                        entity.Save();
                    }
                }
            }
            this.CreateResultMessage(model, anySuccessOperation, errorItems);
            return RedirectToAction(model.RedirectActionName, model.RedirectControllerName);
        }

        [Permission("{E0F57F69-5FBA-428A-93B4-8C80F35879B5}")]
        public ActionResult BudgetEdit(long id)
        {
            try
            {
                IMarketingBase model = base.Manager.Load(id).CastAsRealType<IMarketingBase>();
                ThrowExceptionIfDeleted((ISoftDeletable)model);
                return View((object)model);
            }
            catch (Exception ex)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(ex);
                return RedirectToAction("Index", "MarketingActivity");
            }
        }

        [Permission("{E0F57F69-5FBA-428A-93B4-8C80F35879B5}")]
        [HttpPost]
        public ActionResult BudgetEdit(long id, MarketingBudgetType budgetType, Money budget)
        {
            try
            {
                // ISSUE: explicit non-virtual call
                IMarketingBase marketingBase = base.Manager.Load(id);
                marketingBase.BudgetType = budgetType;
                marketingBase.Budget = budgetType != MarketingBudgetType.Manual ? new Money() : budget;
                marketingBase.Save();
                // ISSUE: explicit non-virtual call
                Notifier.Information(EleWise.ELMA.SR.T("Настройки бюджета изменены"));
            }
            catch (Exception ex)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(EleWise.ELMA.SR.T("Произошла ошибка во время изменения настроек бюджета."));
                ((BaseController)this).Logger.Error((object)EleWise.ELMA.SR.T("Произошла ошибка во время изменения настроек бюджета."), ex);
            }
            return RedirectToAction("Details", "MarketingActivity", (object)new
            {
                id = id
            });
        }

        [Permission("{E0F57F69-5FBA-428A-93B4-8C80F35879B5}")]
        public ActionResult AddPayment(long marketingId)
        {
            IMarketingPayment model = InterfaceActivator.Create<IMarketingPayment>();
            // ISSUE: explicit non-virtual call
            model.MarketingObjectBase = base.Manager.Load(marketingId).CastAsRealType<IMarketingBase>();
            return PartialView("MarketingPayment/AddPaymentPopup", (object)model);
        }

        [Permission("{E0F57F69-5FBA-428A-93B4-8C80F35879B5}")]
        public ActionResult EditPayment(long id)
        {
            try
            {
                return View("MarketingPayment/EditPayment", (object)MarketingPaymentManager.Instance.Load(id));
            }
            catch (Exception ex)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(ex);
                return RedirectToAction("Index", "MarketingActivity");
            }
        }

        [Permission("{E0F57F69-5FBA-428A-93B4-8C80F35879B5}")]
        public ActionResult SavePayment(IMarketingPayment payment)
        {
            payment.Save();
            return RedirectToAction("Details", "MarketingActivity", (object)new
            {
                id = payment.MarketingObjectBase.Id
            });
        }

        [Permission("{E0F57F69-5FBA-428A-93B4-8C80F35879B5}")]
        [HttpPost]
        public ActionResult DeletePayment(long id)
        {
            try
            {
                MarketingPaymentManager.Instance.Load(id).Delete();
                // ISSUE: explicit non-virtual call
                Notifier.Information(EleWise.ELMA.SR.T("Платеж удален"));
            }
            catch (Exception ex)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(EleWise.ELMA.SR.T("Произошла ошибка во время удаления платежа."));
                ((BaseController)this).Logger.Error((object)EleWise.ELMA.SR.T("Произошла ошибка во время удаления платежа."), ex);
            }
            return (ActionResult)new EmptyResult();
        }

        [CustomGridAction]
        public ActionResult GridPayment(GridCommand command, IMarketingBase marketingBase)
        {
            List<MarketingPaymentModel> list = new List<MarketingPaymentModel>();
            GridData<MarketingPaymentModel> gridData = new GridData<MarketingPaymentModel>();
            if (marketingBase is IMarketingGroup marketingGroup)
            {
                list.AddRange(from m in marketingGroup.MarketingActivities
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
                list.AddRange(from m in marketingActivity.MarketingEffects
                              select new MarketingPaymentModel
                              {
                                  Entity = m,
                                  Budget = MarketingBaseManager.Instance.CalcMarketingBudget(m),
                                  CreationDate = m.CreationDate
                              } into m
                              where (double)m.Budget > 0.0
                              select m);
            }
            list.AddRange(from m in marketingBase.Payments
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
                command = new GridCommand
                {
                    PageSize = 10
                };
            }
            gridData.Command = command;
            gridData.SetCount((GridData<MarketingPaymentModel> d, FetchOptions f) => list.Count());
            gridData.DataSource = command.ApplyPaging(list);
            gridData.IsPageable = list.Count > 10;
            gridData.IsAjax = list.Count > 10;
            base.ViewData["CanControlBudget"] = CRMPermissionProvider.CheckAny(new Permission[2]
            {
                CRMPermissionProvider.CRMFullAccessPermission,
                CRMPermissionProvider.MarketingFullAccessPermission
            }) || base.SecurityService.HasPermission(CRMPermissionProvider.CRMMarketingBudgetControlPermission, marketingBase);
            return PartialView("MarketingPayment/GridPayment", gridData);
        }

        private void CreateResultMessage(
          SelectMarketingActivityModel model,
          bool anySuccessOperation,
          string errorItems)
        {
            IMarketingBase marketingBase = (IMarketingBase)model.MarketingGroup ?? (IMarketingBase)model.MarketingActivity ?? (IMarketingBase)model.MarketingEffect;
            if (marketingBase != null)
            {
                string str = model.MarketingGroup != null ? EleWise.ELMA.SR.T("маркетинговая группа") : (model.MarketingActivity != null ? EleWise.ELMA.SR.T("маркетинговое мероприятие") : EleWise.ELMA.SR.T("маркетинговое воздействие"));
                if (anySuccessOperation)
                {
                    // ISSUE: explicit non-virtual call
                    Notifier.Information(MvcHtmlString.Create(EleWise.ELMA.SR.T("Присвоение активности {0} \"{1}\" выбранным {2} успешно произведено", (object)str, (object)marketingBase.Name, (object)model.EntitiesName)));
                }
                if (!(errorItems != string.Empty))
                    return;
                // ISSUE: explicit non-virtual call
                EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
                // ISSUE: explicit non-virtual call
                Notifier.Error(MvcHtmlString.Create(EleWise.ELMA.SR.T("Присвоение активности \"{0}\" {1} {2} {3} не удалось т.к. у пользователя {4} отсутствуют права на редактирование данных {5}", (object)str, (object)marketingBase.Name, (object)model.EntitiesName, (object)errorItems, (object)currentUser.FullName, (object)model.EntitiesNameForErrorMessage)));
            }
            else
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(EleWise.ELMA.SR.T("Не выбрана маркетинговая активность для присвоения"));
            }
        }

        private bool CheckEditPermission(IEntity<long> entity, out string Name)
        {
            Name = string.Empty;
            switch (entity)
            {
                case IContractor _:
                    Name = (entity as IContractor).Name;
                    // ISSUE: explicit non-virtual call
                    return base.SecurityService.HasPermission(CRMPermissionProvider.EditContractorPermission, (object)entity);
                case IContact _:
                    Name = (entity as IContact).Name;
                    // ISSUE: explicit non-virtual call
                    return base.SecurityService.HasPermission(CRMPermissionProvider.EditContactPermission, (object)entity);
                case ILead _:
                    Name = (entity as ILead).Name;
                    // ISSUE: explicit non-virtual call
                    return base.SecurityService.HasPermission(CRMPermissionProvider.EditLeadPermission, (object)entity);
                case ISale _:
                    Name = (entity as ISale).Name;
                    // ISSUE: explicit non-virtual call
                    return base.SecurityService.HasPermission(CRMPermissionProvider.EditSalePermission, (object)entity);
                default:
                    return false;
            }
        }

        public ActionResult LeadDynamic()
        {
            HttpContextAccessor.CurrentContext.Items.Add((object)"showFiltersTree", (object)true);
            return View("LeadDynamic/LeadDynamic", (object)new LeadDynamicModel());
        }

        public ActionResult LeadDynamicGrid(
          DateTime? date,
          MarketingPeriodEnum mode = MarketingPeriodEnum.Month,
          bool showArchive = false,
          bool showStatistic = true)
        {
            return PartialView("LeadDynamic/LeadDynamicGrid", (object)new LeadDynamicModel(mode, date.HasValue ? date.Value : DateTime.Today, showArchive, showStatistic));
        }

        [CustomGridAction]
        public ActionResult LeadDynamicActivity(
          GridCommand command,
          DateTime? date,
          long marketingGroupId,
          MarketingPeriodEnum mode = MarketingPeriodEnum.Month,
          bool showArchive = false,
          bool showStatistic = true)
        {
            return PartialView("LeadDynamic/LeadDynamicActivity", (object)new LeadDynamicModel(mode, date.HasValue ? date.Value : DateTime.Today, showArchive, showStatistic, marketingGroupId));
        }

        public JsonResult LeadDynamicSaveState(long id, bool expanding)
        {
            LeadDynamicState.SaveIdsState(id, expanding);
            return Json(new
            {
                success = true
            }, "text/html");
        }

        public ActionResult MarketingStatistic()
        {
            HttpContextAccessor.CurrentContext.Items.Add((object)"showFiltersTree", (object)true);
            return View("MarketingStatistic/MarketingStatistic", (object)new MarketingStatisticModel());
        }

        public ActionResult MarketingStatisticGrid(
          DateTime? date,
          MarketingPeriodEnum mode = MarketingPeriodEnum.Month,
          long marketingBaseId = 0)
        {
            return PartialView("MarketingStatistic/MarketingStatisticGrid", (object)new MarketingStatisticModel(marketingBaseId != 0L ? MarketingBaseManager.Instance.Load(marketingBaseId) : (IMarketingBase)null, mode, date.HasValue ? date.Value : DateTime.Today));
        }

        private ActionResult SelectPermission(IMarketingBase instance)
        {
            Type type = InterfaceActivator.TypeOf<IMarketingBase>();
            CRMPermissionModel model = new CRMPermissionModel()
            {
                Id = instance.Id
            };
            model.AdditionalPermissionsModel = this.PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel((object)instance, type, ((Controller)this).Url, (Func<IInstanceSettingsPermissionHolder, bool>)(holder => ((IMarketingPersonPermission)holder).PermissionSource == null), true, (string)null);
            model.AdditionalPermissionsModel.Instance = (object)instance;
            model.AdditionalPermissionsModel.Routes = new RouteValueDictionary((object)new
            {
                action = "PermissionSettings",
                controller = "MarketingActivity",
                area = "EleWise.ELMA.CRM.Web"
            });
            if (model.LockEditPermission)
                model.AdditionalPermissionsModel.Edit = false;
            if (!(instance is IMarketingGroup))
            {
                model.InheritPermissions = instance.InheritPermissions;
                // ISSUE: explicit non-virtual call
                // ISSUE: explicit non-virtual call
                // ISSUE: explicit non-virtual call
                model.InheritAvailable = base.SecurityService.HasPermission(CRMPermissionProvider.CRMMarketingIssuanceElementPermission, (object)instance) || base.SecurityService.HasPermission(CRMPermissionProvider.CRMMarketingFullAccessPermission, (object)instance) || base.SecurityService.HasPermission(CRMPermissionProvider.CRMFullAccessPermission);
                model.InheritPermissionsModel = this.PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel((object)instance, type, ((Controller)this).Url, (Func<IInstanceSettingsPermissionHolder, bool>)(holder => ((IMarketingPersonPermission)holder).PermissionSource != null), true, (string)null);
                model.InheritPermissionsModel.BindModelName = "InheritPermissions";
                model.InheritPermissionsModel.Instance = (object)instance;
                model.InheritPermissionsModel.Edit = false;
            }
            return PartialView("MarketingActivityPermissionSettings", (object)model);
        }

        [HttpPost]
        public ActionResult EnableInheritPermission(IMarketingBase instance, bool enable)
        {
            MarketingBaseManager.Instance.EnableInheritPermissions(instance, enable);
            return this.SelectPermission(instance);
        }

        [HttpPost]
        [TransactionAction]
        public ActionResult PermissionSettings(long id, EditableListModel access)
        {
            IMarketingBase marketingObj = MarketingBaseManager.Instance.Load(id);
            if (access != null && marketingObj != null)
                this.PermissionsModelService.BindPermissionsFromModel((object)marketingObj, access, (Action<ICollection<IInstanceSettingsPermissionHolder>, IEnumerable<IInstanceSettingsPermissionHolder>>)((holders, newHolders) =>
              {
                  List<IInstanceSettingsPermissionHolder> permissionHolderList = new List<IInstanceSettingsPermissionHolder>();
                  if (marketingObj.InheritPermissions)
                  {
                      permissionHolderList.AddRange(holders.Where<IInstanceSettingsPermissionHolder>((Func<IInstanceSettingsPermissionHolder, bool>)(h => ((IMarketingPersonPermission)h).PermissionSource != null)));
                      foreach (IInstanceSettingsPermissionHolder permissionHolder in permissionHolderList)
                          holders.Remove(permissionHolder);
                  }
                  holders.SyncFrom<IInstanceSettingsPermissionHolder>(newHolders, (Func<IInstanceSettingsPermissionHolder, IInstanceSettingsPermissionHolder, bool>)((v1, v2) => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals((object)v1.Assigned, (object)v2.Assigned)), onRemove: ((Action<IInstanceSettingsPermissionHolder>)(v =>
        {
            if (!(v is IEntity entity2))
                return;
            entity2.Delete();
        })));
                  if (!marketingObj.InheritPermissions)
                      return;
                  foreach (IInstanceSettingsPermissionHolder permissionHolder in permissionHolderList)
                      holders.Add(permissionHolder);
              }));
            return Redirect(((Controller)this).Url.ReturnUrl());
        }

        public ActionResult PermissionSettings(IMarketingBase instance) => this.SelectPermission(instance);

        public ActionResult RemoveContractor(long id)
        {
            string str = (string)null;
            try
            {
                IContractor contractor = ContractorManager.Instance.Load(id);
                contractor.MarketingGroup = (IMarketingGroup)null;
                contractor.MarketingActivity = (IMarketingActivity)null;
                contractor.MarketingEffect = (IMarketingEffect)null;
                contractor.Save();
            }
            catch (Exception ex)
            {
                str = ex.Message;
            }
            return Json((object)new
            {
                success = string.IsNullOrEmpty(str),
                error = str
            });
        }

        public ActionResult RemoveLead(long id)
        {
            string str = (string)null;
            try
            {
                ILead lead = LeadManager.Instance.Load(id);
                lead.MarketingGroup = (IMarketingGroup)null;
                lead.MarketingActivity = (IMarketingActivity)null;
                lead.MarketingEffect = (IMarketingEffect)null;
                lead.Save();
            }
            catch (Exception ex)
            {
                str = ex.Message;
            }
            return Json((object)new
            {
                success = string.IsNullOrEmpty(str),
                error = str
            });
        }

        public ActionResult RemoveSale(long id)
        {
            string str = (string)null;
            try
            {
                ISale sale = SaleManager.Instance.Load(id);
                sale.MarketingGroup = (IMarketingGroup)null;
                sale.MarketingActivity = (IMarketingActivity)null;
                sale.MarketingEffect = (IMarketingEffect)null;
                sale.Save();
            }
            catch (Exception ex)
            {
                str = ex.Message;
            }
            return Json((object)new
            {
                success = string.IsNullOrEmpty(str),
                error = str
            });
        }

        [HttpGet]
        public ActionResult LinkContractor(long id)
        {
            LinkEntityToMarketingModel model = new LinkEntityToMarketingModel();
            model.Action = nameof(LinkContractor);
            model.MarketingBase = AbstractNHEntityManager<IMarketingBase, long>.Instance.Load(id);
            model.EntityExpression = (Expression<Func<LinkEntityToMarketingModel, IEntity>>)(m => m.Contractor);
            model.Callback = "refreshContractorsGird(data)";
            return PartialView("LinkEntity", (object)model);
        }

        [HttpPost]
        public ActionResult LinkContractor(LinkEntityToMarketingModel model)
        {
            string str = (string)null;
            try
            {
                ContractorManager.Instance.LinkToMarketing(model.Contractor, model.MarketingBase);
            }
            catch (Exception ex)
            {
                str = ex.Message;
                ((BaseController)this).Logger.Error((object)ex.Message, ex);
            }
            return Json((object)new
            {
                success = string.IsNullOrEmpty(str),
                error = str
            }, "text/html");
        }

        [HttpGet]
        public ActionResult LinkLead(long id)
        {
            LinkEntityToMarketingModel model = new LinkEntityToMarketingModel();
            model.Action = nameof(LinkLead);
            model.MarketingBase = AbstractNHEntityManager<IMarketingBase, long>.Instance.Load(id);
            model.EntityExpression = (Expression<Func<LinkEntityToMarketingModel, IEntity>>)(m => m.Lead);
            model.Callback = "refreshLeadsGird(data)";
            return PartialView("LinkEntity", (object)model);
        }

        [HttpPost]
        public ActionResult LinkLead(LinkEntityToMarketingModel model)
        {
            string str = (string)null;
            try
            {
                LeadManager.Instance.LinkToMarketing(model.Lead, model.MarketingBase);
            }
            catch (Exception ex)
            {
                str = ex.Message;
                ((BaseController)this).Logger.Error((object)ex.Message, ex);
            }
            return Json((object)new
            {
                success = string.IsNullOrEmpty(str),
                error = str
            }, "text/html");
        }

        [HttpGet]
        public ActionResult LinkSale(long id)
        {
            LinkEntityToMarketingModel model = new LinkEntityToMarketingModel();
            model.Action = nameof(LinkSale);
            model.MarketingBase = AbstractNHEntityManager<IMarketingBase, long>.Instance.Load(id);
            model.EntityExpression = (Expression<Func<LinkEntityToMarketingModel, IEntity>>)(m => m.Sale);
            model.Callback = "refreshSalesGird(data)";
            return PartialView("LinkEntity", (object)model);
        }

        [HttpPost]
        public ActionResult LinkSale(LinkEntityToMarketingModel model)
        {
            string str = (string)null;
            try
            {
                SaleManager.Instance.LinkToMarketing(model.Sale, model.MarketingBase);
            }
            catch (Exception ex)
            {
                str = ex.Message;
                ((BaseController)this).Logger.Error((object)ex.Message, ex);
            }
            return Json((object)new
            {
                success = string.IsNullOrEmpty(str),
                error = str
            }, "text/html");
        }

        [TransactionAction]
        public ActionResult Archive(CommentWithAttachments model)
        {
            try
            {
                IMarketingBase marketingBase = MarketingBaseManager.Instance.Load(model.ObjectId).CastAsRealType<IMarketingBase>();
                EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(marketingBase.GetType());
                MarketingBaseManager.Instance.Archive(marketingBase, model.ActionModel);
                // ISSUE: explicit non-virtual call
                Notifier.Information(MvcHtmlString.Create(EleWise.ELMA.SR.T("{0} <a href='{2}'>{1}</a> перемещено(а) в архив", (object)entityMetadata.DisplayName.HtmlEncode(), (object)marketingBase.Name.HtmlEncode(), (object)((Controller)this).Url.Entity((IEntity)marketingBase))));
                return Redirect(((FormViewModel)model).RedirectUrl);
            }
            catch (Exception ex)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(ex);
                return RedirectToAction("Details", (object)new
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
                IMarketingBase marketingBase = MarketingBaseManager.Instance.Load(model.ObjectId).CastAsRealType<IMarketingBase>();
                EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(marketingBase.GetType());
                MarketingBaseManager.Instance.Activate(marketingBase, model.ActionModel);
                // ISSUE: explicit non-virtual call
                Notifier.Information(MvcHtmlString.Create(EleWise.ELMA.SR.T("{0} <a href='{2}'>{1}</a> возвращено(а) из архива", (object)entityMetadata.DisplayName.HtmlEncode(), (object)marketingBase.Name.HtmlEncode(), (object)((Controller)this).Url.Entity((IEntity)marketingBase))));
                return Redirect(((FormViewModel)model).RedirectUrl);
            }
            catch (Exception ex)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(ex);
                return RedirectToAction("Details", (object)new
                {
                    id = model.ObjectId
                });
            }
        }

        public ActionResult ComboboxSelect(string text, string id)
        {
            Guid activityTypeUid = InterfaceActivator.UID<IMarketingActivity>();
            Guid groupTypeUid = InterfaceActivator.UID<IMarketingGroup>();
            IMarketingBaseFilter filter = new InstanceOf<IMarketingBaseFilter>()
            {
                New = {
          Status = new MarketingObjectStatus?(MarketingObjectStatus.Active)
        }
            }.New;
            if (!string.IsNullOrEmpty(text))
                filter.Name = text;
            if (!string.IsNullOrEmpty(id))
            {
                long result;
                if (long.TryParse(id.TrimStart('g', 'a', 'e', '?'), out result))
                    filter.Id = (object)result;
            }
            List<AutocompleteItem> list = MarketingBaseManager.Instance.Find((IEntityFilter)filter, new FetchOptions(0, 100)).Select<IMarketingBase, AutocompleteItem>((Func<IMarketingBase, AutocompleteItem>)(i => new AutocompleteItem()
            {
                Value = string.Format("{0}{1}", i.TypeUid == groupTypeUid ? (object)"g" : (i.TypeUid == activityTypeUid ? (object)"a" : (object)"e"), (object)i.Id),
                Text = i.Name,
                DropDownText = string.Format("{0} {1}", (object)HtmlExtensions.Image(((Controller)this).Url.ObjectIcon(ObjectIconFormat.x16, (object)i), (object)new
                {
                    style = "vertical-align: text-bottom;"
                }), (object)HttpUtility.HtmlEncode(i.Name)),
                EntityUrl = ((Controller)this).Url.Entity((IEntity)i)
            })).ToList<AutocompleteItem>();
            return (ActionResult)new JsonResult()
            {
                Data = (object)list
            };
        }

        public ActionResult TreeSelect(string value)
        {
            Guid gUid = InterfaceActivator.UID<IMarketingGroup>();
            Guid aUid = InterfaceActivator.UID<IMarketingActivity>();
            if (value == null)
                return Json((object)MarketingBaseManager.Instance.TreeRoot().Select<MarketingTreeItem, TreeViewItem>((Func<MarketingTreeItem, TreeViewItem>)(item =>
              {
                  return new TreeViewItem()
                  {
                      LoadOnDemand = item.ChildrenCount > 0,
                      Value = string.Format("{0}{1}", item.TypeUid == gUid ? (object)"g" : (item.TypeUid == aUid ? (object)"a" : (object)"?"), (object)item.Id),
                      Text = item.Name,
                      ImageUrl = item.TypeUid == gUid ? ((Controller)this).Url.Image("#targets.svg") : (item.TypeUid == aUid ? ((Controller)this).Url.Image("#target.svg") : ((Controller)this).Url.Image("#unk.svg"))
                  };
              })).ToList<TreeViewItem>());
            long result;
            if (long.TryParse(value.Substring(1), out result))
            {
                IMarketingBase group = MarketingBaseManager.Instance.Load(result).CastAsRealType<IMarketingBase>();
                switch (group)
                {
                    case IMarketingGroup _:
                        return Json((object)MarketingBaseManager.Instance.TreeGroup((IMarketingGroup)group).Select<MarketingTreeItem, TreeViewItem>((Func<MarketingTreeItem, TreeViewItem>)(activity =>
                     {
                         return new TreeViewItem()
                         {
                             LoadOnDemand = activity.ChildrenCount > 0,
                             Value = string.Format("a{0}", (object)activity.Id),
                             Text = activity.Name,
                             ImageUrl = ((Controller)this).Url.Image("#target.svg")
                         };
                     })));
                    case IMarketingActivity _:
                        InstanceOf<IMarketingEffectFilter> instanceOf = new InstanceOf<IMarketingEffectFilter>();
                        instanceOf.New.MarketingActivity = (IMarketingActivity)group;
                        instanceOf.New.Status = new MarketingObjectStatus?(MarketingObjectStatus.Active);
                        return Json((object)MarketingEffectManager.Instance.Find((IEntityFilter)instanceOf.New, FetchOptions.All).Select<IMarketingEffect, TreeViewItem>((Func<IMarketingEffect, TreeViewItem>)(effect =>
                     {
                         return new TreeViewItem()
                         {
                             LoadOnDemand = false,
                             Value = string.Format("e{0}", (object)effect.Id),
                             Text = effect.Name,
                             ImageUrl = ((Controller)this).Url.Image("#arrow.svg")
                         };
                     })));
                }
            }
            return Json((object)new TreeViewItem[0]);
        }

        public ActionResult Explorer(string popupId)
        {
            ((ControllerBase)this).ViewData["PopupId"] = (object)popupId;
            return PartialView();
        }

        public List<string> LocalizedItemsNames => new List<string>()
    {
      EleWise.ELMA.SR.T("Маркетинг")
    };

        protected virtual string GridIdPrefix => "MarketingBaseGrid";

        protected virtual bool EnableEqlQuery => true;
    }
}
