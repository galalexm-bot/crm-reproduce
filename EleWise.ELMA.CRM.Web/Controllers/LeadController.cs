// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.LeadController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Attributes;
using EleWise.ELMA.CRM.Web.Extensions;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.CRM.Web.Models.Lead;
using EleWise.ELMA.CRM.Web.Portlets;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Web.Mvc;
using System.Web.Routing;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
    [Permission("{46401803-1B46-4E60-8DA0-227FF8CF60F3}")]
    [RouteArea("EleWise.ELMA.CRM.Web")]
    public class LeadController : FilterTreeBaseController<ILead, long>
    {
        private ICountry defaultCountry = Locator.GetService<CrmSettingsModule>().Settings.DefaultCountry;
        private readonly LeadManager leadManager;
        private readonly IMetadataRuntimeService metadataRuntimeService;
        private readonly IEnumerable<IContractorBaseModel2> contractorModelProviders;
        private readonly IEnumerable<IRelationshipBaseModel2> relationshipModelProviders;
        private const string CONVERTMODELKEY = "ConvertModel";
        private static readonly Guid ShowSummaryGuid = new Guid("B6356A70-1857-409C-89AC-E4A037928B9F");
        private static Guid contractorUid = InterfaceActivator.UID<IContractor>();
        private static Guid contractorIndividualUid = InterfaceActivator.UID<IContractorIndividual>();
        private static Guid contractorLegalUid = InterfaceActivator.UID<IContractorLegal>();
        private static Guid saleUid = InterfaceActivator.UID<ISale>();
        private static Guid relationshipUid = InterfaceActivator.UID<IRelationship>();
        private static Guid relationshipCallUid = InterfaceActivator.UID<IRelationshipCall>();
        private static Guid relationshipMailUid = InterfaceActivator.UID<IRelationshipMail>();
        private static Guid relationshipMeetingUid = InterfaceActivator.UID<IRelationshipMeeting>();
        private static readonly Dictionary<Guid, Guid?> LeadConverterTypeToFormMap = new Dictionary<Guid, Guid?>()
        {
            [LeadController.contractorIndividualUid] = new Guid?(LeadConverterConsts.ContractorIndividualEditFormUid),
            [LeadController.contractorLegalUid] = new Guid?(LeadConverterConsts.ContractorLegalEditFormUid),
            [LeadController.saleUid] = new Guid?(LeadConverterConsts.SaleCreateFormUid),
            [LeadController.relationshipCallUid] = new Guid?(LeadConverterConsts.RelationshipCallCreateFormUid),
            [LeadController.relationshipMailUid] = new Guid?(LeadConverterConsts.RelationshipMailCreateFormUid),
            [LeadController.relationshipMeetingUid] = new Guid?(LeadConverterConsts.RelationshipMeetingCreateFormUid)
        };
        private static Guid SaleUid = Guid.Empty;
        private List<string> LocalizedItemNames = new List<string>()
    {
      EleWise.ELMA.SR.T("Создать возможность")
    };

        public IUnionComplexCacheService ComplexCacheService { get; set; }

        public LeadController(
          LeadManager leadManager,
          IMetadataRuntimeService metadataRuntimeService,
          IEnumerable<IContractorBaseModel2> contractorModelProviders,
          IEnumerable<IRelationshipBaseModel2> relationshipModelProviders)
        {
            this.leadManager = leadManager;
            this.metadataRuntimeService = metadataRuntimeService;
            this.contractorModelProviders = contractorModelProviders;
            this.relationshipModelProviders = relationshipModelProviders;
        }

        protected ILeadFilter CreateFilter()
        {
            InstanceOf<ILeadFilter> instanceOf = new InstanceOf<ILeadFilter>();
            instanceOf.New.PermissionId = new Guid?(CRMPermissionProvider.CRMAccessPermission.Id);
            return instanceOf.New;
        }

        [ContentItem(Name = "SR.M('Возможности')", Image24 = "#contact.svg")]
        [FilterMenuItem(Id = "crm-leads", Type = typeof(ILead), FilterEditAction = "EditFilters")]
        public ActionResult Index(long? FilterId = null) => this.BaseIndex(FilterId, nameof(FilterId), nameof(Index), new Guid?()) ?? View((object)this.CreateGridData((GridCommand)null, this.CreateFilter(FilterId, new Guid?(), (IEntityFilter)null, (EleWise.ELMA.Web.Mvc.Models.Grids.GridState)null, "Filter")));

        public ActionResult Search(long? FilterId = null)
        {
            if (base.Request.QueryString.Count == 0)
            {
                return RedirectToAction("Index");
            }
            FilterModel filter = CreateFilter(FilterId);
            GridDataFilter<ILead> model = CreateGridData(null, filter);
            return View("Index", model);
        }

        public static void InitNewModel(LeadModel model) => LeadController.InitNewModel(model, true);

        private static void InitNewModel(LeadModel model, bool leadWasNull)
        {
            if (!leadWasNull)
                return;
            model.Entity.Email.Add(InterfaceActivator.Create<IEmail>());
            model.Entity.Phone.Add(InterfaceActivator.Create<IPhone>());
            model.LeadTypes = (IEnumerable<ILeadType>)LeadTypeManager.Instance.FindAll();
            model.NewContact.Email.Add(InterfaceActivator.Create<IEmail>());
            model.NewContact.Phone.Add(InterfaceActivator.Create<IPhone>());
        }

        [EntityForm("Create", "EleWise.ELMA.CRM.Web")]
        [Permission("{C8B3D353-B34D-4463-ABED-9FEF8B6D4B47}")]
        public ActionResult CreatePopup(
          [ParameterContainer] ILead lead,
          Guid? formUid = null,
          EleWise.ELMA.Model.Views.ViewType? viewType = null,
          bool formReadOnly = false,
          string parentFormId = "",
          string formId = "")
        {
            LeadModel leadModel = new LeadModel(lead, viewType.HasValue ? viewType.Value : EleWise.ELMA.Model.Views.ViewType.Create);
            leadModel.FormId = formId;
            leadModel.FormUid = formUid;
            leadModel.FormReadOnly = formReadOnly;
            LeadModel model = leadModel;
            model.DynamicFormSettings.ParentFormId = parentFormId;
            DynamicFormSettings dynamicFormSettings = model.DynamicFormSettings;
            dynamicFormSettings.ViewItemId = dynamicFormSettings.ViewItemId + ";" + (object)model.View.Uid;
            LeadController.InitNewModel(model, lead == null);
            return PartialView("Lead/LeadEditFields", (object)model);
        }

        [LeadCreate]
        [Permission("{C8B3D353-B34D-4463-ABED-9FEF8B6D4B47}")]
        [ContentItem(Name = "SR.M('Создать возможность')", Image24 = "#add.svg")]
        public ActionResult Create()
        {
            LeadModel model = new LeadModel();
            model.LockEditPermission = this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking;
            if (model.LockEditPermission)
            {

                (((BaseController)this).Notifier).Error(EleWise.ELMA.SR.T("Производится перерасчет разрешений. Изменение заблокировано. Пожалуйста попробуйте позже."));
                return RedirectToAction("Index", "Lead");
            }
            if (this.defaultCountry != null)
            {
                IAddress address = EntityManager<IAddress>.Instance.Create();
                address.Country = this.defaultCountry;
                model.Entity.Address = address;
            }
            LeadController.InitNewModel(model);
            return View((object)model);
        }

        [HttpPost]
        [Permission("{C8B3D353-B34D-4463-ABED-9FEF8B6D4B47}")]
        public ActionResult Create(LeadModel model)
        {
            model.LockEditPermission = this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking;
            if (model.LockEditPermission)
            {

                (((BaseController)this).Notifier).Error(EleWise.ELMA.SR.T("Производится перерасчет разрешений. Изменение заблокировано. Пожалуйста попробуйте позже."));
                return RedirectToAction("Index", "Lead");
            }
            SaveWithCategoryRulesResult categoryRulesResult = model.SaveWithCategoryRules();
            string information = (string)null;
            if (categoryRulesResult.AddedCategories.Count > 0)
            {
                string str;
                if (!((BaseController)this).IsCreatorRequest())
                    str = EleWise.ELMA.SR.T("Потенциальный клиент <a href='{1}'>{0}</a> сохранен успешно", (object)model.Entity.Name.HtmlEncode(), (object)((Controller)this).Url.Entity((IEntity)model.Entity));
                else
                    str = "";
                information = str;
                if (categoryRulesResult.AddedCategories.Count > 0)
                {
                    if (!((BaseController)this).IsCreatorRequest())
                        information = information + "<br/>" + EleWise.ELMA.SR.T("Автоматически добавлены категории: {0}", (object)categoryRulesResult.AddedCategories.Select<ICategory, string>((Func<ICategory, string>)(c => c.Name)).ToSeparatedString<string>(", ")).HtmlEncode();
                    else
                        information = EleWise.ELMA.SR.T("Потенциальному клиенту {0} автоматически добавлены категории: {1}", (object)model.Entity.Name, (object)categoryRulesResult.AddedCategories.Select<ICategory, string>((Func<ICategory, string>)(c => c.Name)).ToSeparatedString<string>(", ")).HtmlEncode();
                }

              (((BaseController)this).Notifier).Information(MvcHtmlString.Create(information));
            }
            if (IsCustomViewRequest())
                return HandleCustomViewJsonCallback((IEntity)model.Entity);
            return ((BaseController)this).IsCreatorRequest() ? ((BaseController)this).CreatorJsonWithInformation((IEntity)model.Entity, information) : RedirectToAction("Details", (object)new
            {
                Id = model.Entity.Id
            });
        }

        [DetailsAction]
        [EntityLink]
        public ActionResult Details(long id, int? tabIndex = 0)
        {
            try
            {
                if (tabIndex.HasValue)
                {
                    if (DirectoryMapVirtualPathProvider.AnyConfigFile("~/Modules/EleWise.ELMA.CRM.Web/Views/Lead/TabView.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Lead/TasksTab.cshtml"))
                        ((ControllerBase)this).ViewData["SelectedTab"] = (object)tabIndex.Value;
                }

                ILead lead = base.Manager.Load(id);
                ThrowExceptionIfDeleted((ISoftDeletable)lead);
                return View((object)new LeadModel(lead, EleWise.ELMA.Model.Views.ViewType.Display)
                {
                    LockEditPermission = this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking
                });
            }
            catch (Exception ex)
            {

                (((BaseController)this).Notifier).Error(ex);
                return RedirectToAction("Index", "Lead");
            }
        }

        [Permission]
        public ActionResult Edit([InstancePermission(typeof(ILead), "{AE298CD3-A16A-4B55-ACFC-545E4A0EBD48}")] long id)
        {
            try
            {
                ILead lead = base.Manager.Load(id);
                ThrowExceptionIfDeleted((ISoftDeletable)lead);
                if (!lead.Email.Any<IEmail>())
                    lead.Email.Add(InterfaceActivator.Create<IEmail>());
                if (!lead.Phone.Any<IPhone>())
                    lead.Phone.Add(InterfaceActivator.Create<IPhone>());
                LeadModel model = new LeadModel(lead, EleWise.ELMA.Model.Views.ViewType.Edit);
                model.LeadTypes = (IEnumerable<ILeadType>)LeadTypeManager.Instance.FindAll();
                model.LockEditPermission = this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking;
                if (model.LockEditPermission)
                {
                    return RedirectToAction("Details", new { id });
                }
                return View(model);
            }
            catch (Exception ex)
            {

                (((BaseController)this).Notifier).Error(ex);
                return RedirectToAction("Index", "Contractor");
            }
        }

        [AsyncViewItemAction]
        public ActionResult AsyncViewItem(Guid viewItemUid, long id, EleWise.ELMA.Model.Views.ViewType viewType, Guid? formUid)
        {

            LeadModel originalModel = new LeadModel(base.Manager.LoadOrCreate(id), viewType);
            originalModel.FormUid = formUid;
            return AsyncViewItemView<LeadModel>(originalModel.View, viewType, viewItemUid, originalModel, (Expression<Func<LeadModel, object>>)(m => m.Entity));
        }

        [HttpPost]
        [TransactionAction]
        [Permission]
        public ActionResult Edit([InstancePermission("{AE298CD3-A16A-4B55-ACFC-545E4A0EBD48}")] LeadModel model)
        {
            try
            {
                model.LockEditPermission = this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking;
                if (model.LockEditPermission)
                    return RedirectToAction("Details", (object)new
                    {
                        Id = model.Entity.Id
                    });
                LeadManager.Instance.CheckDublicateLead(model.Entity);
                LeadModel leadModel = model;
                bool? unassignOldCategories1 = model.UnassignOldCategories;
                bool flag1 = true;
                bool? unassignOldCategories2;
                int num;
                if (!(unassignOldCategories1.GetValueOrDefault() == flag1 & unassignOldCategories1.HasValue))
                {
                    unassignOldCategories2 = model.UnassignOldCategories;
                    bool flag2 = false;
                    num = unassignOldCategories2.GetValueOrDefault() == flag2 & unassignOldCategories2.HasValue ? 2 : 0;
                }
                else
                    num = 1;
                SaveWithCategoryRulesResult categoryRulesResult = leadModel.SaveWithCategoryRules((RuleDeletedCategoryAction)num);
                unassignOldCategories2 = model.UnassignOldCategories;
                if (!unassignOldCategories2.HasValue && categoryRulesResult.DeletedCategories.Count > 0)
                {
                    ((BaseController)this).UnitOfWorkManager.RollbackCurrent("");
                    model.CategoriesToDelete = (IEnumerable<ICategory>)categoryRulesResult.DeletedCategories;
                    return View((object)model);
                }
                if (categoryRulesResult.AddedCategories.Count > 0 || categoryRulesResult.DeletedCategories.Count > 0)
                {
                    string str = EleWise.ELMA.SR.T("Потенциальный клиент <a href=\"{1}\">{0}</a> сохранено успешно", (object)model.Entity.Name.HtmlEncode(), (object)((Controller)this).Url.Entity((IEntity)model.Entity));
                    if (categoryRulesResult.AddedCategories.Count > 0)
                        str = str + "<br/> " + EleWise.ELMA.SR.T("Автоматически добавлены категории: {0}", (object)categoryRulesResult.AddedCategories.Select<ICategory, string>((Func<ICategory, string>)(c => c.Name)).ToSeparatedString<string>(", ")).HtmlEncode();
                    if (categoryRulesResult.DeletedCategories.Count > 0)
                        str = str + "<br/> " + EleWise.ELMA.SR.T("Удалены категории: {0}", (object)categoryRulesResult.DeletedCategories.Select<ICategory, string>((Func<ICategory, string>)(c => c.Name)).ToSeparatedString<string>(", ")).HtmlEncode();

                    (((BaseController)this).Notifier).Information(MvcHtmlString.Create(str));
                }
                return RedirectToAction("Details", (object)new
                {
                    Id = model.Entity.Id
                });
            }
            catch (Exception ex)
            {
                ((BaseController)this).Logger.Error((object)ex.Message, ex);
                ((BaseController)this).UnitOfWorkManager.RollbackCurrent("");

                (((BaseController)this).Notifier).Error(ex);
                return View((object)model);
            }
        }

        [HttpGet]
        [Permission("{dde5667e-bc3f-458c-abb6-2d693f6ffec2}")]
        public ActionResult Delete(long id)
        {
            try
            {
                if (this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking)
                    return RedirectToAction("Details", (object)new
                    {
                        id = id
                    });
                ILead lead = LeadManager.Instance.Load(id);
                LeadManager.Instance.Delete(lead);

                (((BaseController)this).Notifier).Information(EleWise.ELMA.SR.T("Потенциальный клиент \"{0}\" успешно удален", (object)lead.Name));
                return RedirectToAction("Index", "Lead", (object)new
                {
                    area = "EleWise.ELMA.CRM.Web"
                });
            }
            catch (Exception ex)
            {

                (((BaseController)this).Notifier).Error(ex);
                return RedirectToAction("Index", "Lead", (object)new
                {
                    area = "EleWise.ELMA.CRM.Web"
                });
            }
        }

        [HttpGet]
        [Permission("{dde5667e-bc3f-458c-abb6-2d693f6ffec2}")]
        public ActionResult DeleteGroup(long[] leadsId, string popupId)
        {
            if (this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking)
            {
                (((BaseController)this).Notifier).Error(EleWise.ELMA.SR.T("Производится перерасчет разрешений. Изменение заблокировано. Пожалуйста попробуйте позже."));
                return RedirectToAction("Index", "Lead", (object)new
                {
                    area = "EleWise.ELMA.CRM.Web"
                });
            }

            List<ILead> list = ((IEnumerable<long>)leadsId).Select<long, ILead>((Func<long, ILead>)(id => base.Manager.Load(id))).ToList<ILead>();
            if (leadsId.Length == 0)
                return RedirectToAction("Index");
            return PartialView(nameof(DeleteGroup), (object)new GroupLeadInfo()
            {
                Leads = (IList<ILead>)list,
                PopupId = popupId
            });
        }

        [HttpPost]
        [Permission("{dde5667e-bc3f-458c-abb6-2d693f6ffec2}")]
        public ActionResult DeleteGroup(GroupLeadInfo leadsInfo)
        {
            if (this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking)
            {

                (((BaseController)this).Notifier).Error(EleWise.ELMA.SR.T("Производится перерасчет разрешений. Изменение заблокировано. Пожалуйста попробуйте позже."));
                return RedirectToAction("Index", "Lead", (object)new
                {
                    area = "EleWise.ELMA.CRM.Web"
                });
            }

            leadsInfo.Leads.ForEach<ILead>((Action<ILead>)(m => base.Manager.Load(m.Id).Delete()));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Fail(long id)
        {
            bool flag = base.Manager.Load(id).Contractor == null;
            return PartialView("State/Fail", (object)new LeadFailModel()
            {
                Id = id,
                ShowConvert = flag
            });
        }

        [HttpPost]
        [TransactionAction]
        public ActionResult Fail(LeadFailModel model)
        {

            ILead lead = base.Manager.Load(model.Id);
            LeadManager.Instance.Fail(lead, model.Convert, model.Comment);
            string str = ((Controller)this).Url.Entity((IEntity)lead);

            (((BaseController)this).Notifier).Information(MvcHtmlString.Create(EleWise.ELMA.SR.T("Потенциальный клиент <a href='{1}'>{0}</a>, статус \"Неквалифицированный\" сохранен", (object)lead.Name.HtmlEncode(), (object)str)));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Begin(long id)
        {

            ILead lead = base.Manager.Load(id);
            if (lead.Status == LeadStatus.InHand)
            {

                (((BaseController)this).Notifier).Information(EleWise.ELMA.SR.T("Потенциальный клиент \"{0}\" уже имеет статус \"В работе\"", (object)lead.Name));
                return RedirectToAction("Details", (object)new
                {
                    id = id
                });
            }
            LeadManager.Instance.BeginWork(lead);

            (((BaseController)this).Notifier).Information(EleWise.ELMA.SR.T("Потенциальный клиент \"{0}\", статус \"В работе\" сохранен", (object)lead.Name));
            return RedirectToAction("Details", (object)new
            {
                id = id
            });
        }

        [HttpGet]
        public ActionResult ConversationNotStart(long id)
        {

            ILead lead = base.Manager.Load(id);
            if (lead.Status == LeadStatus.ConversationNotStart)
            {

                (((BaseController)this).Notifier).Information(EleWise.ELMA.SR.T("Потенциальный клиент \"{0}\" уже имеет статус \"Разговор не состоялся\"", (object)lead.Name));
                return RedirectToAction("Details", (object)new
                {
                    id = id
                });
            }
            LeadManager.Instance.ConversationNotStart(lead);

            (((BaseController)this).Notifier).Information(EleWise.ELMA.SR.T("Потенциальный клиент \"{0}\", статус \"Разговор не состоялся\" сохранен", (object)lead.Name));
            return RedirectToAction("Details", (object)new
            {
                id = id
            });
        }

        public ActionResult Activate(long[] leadsId)
        {
            UpdateLeadsModel updateLeadsModel = this.leadManager.ActivateManyLeads(leadsId);
            if (updateLeadsModel.Error != null)
            {

                (((BaseController)this).Notifier).Error(updateLeadsModel.Error);
                return RedirectToAction("Index", "Lead");
            }
            this.CreateLeadsActivatedMessage(updateLeadsModel.LeadsWithoutEditPermission.Any<string>() ? string.Join(", ", (IEnumerable<string>)updateLeadsModel.LeadsWithoutEditPermission) : string.Empty, updateLeadsModel.LeadsIncorrectStatus.Any<string>() ? string.Join(", ", (IEnumerable<string>)updateLeadsModel.LeadsIncorrectStatus) : string.Empty, updateLeadsModel.AnySuccess);
            return Redirect(((Controller)this).Url.ReturnUrl());
        }

        public ActionResult AssignTo(long userId, long[] leadsId)
        {
            UpdateLeadsModel updateLeadsModel = this.leadManager.UpdateSqlLeadResponsible(leadsId, userId);
            EleWise.ELMA.Security.Models.IUser user = AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>.Instance.Load(userId);
            if (updateLeadsModel.Error != null)
            {

                (((BaseController)this).Notifier).Error(updateLeadsModel.Error);
                return RedirectToAction("Index", "Lead");
            }
            this.CreateLeadsAssignedMessage(user, updateLeadsModel.LeadsWithoutEditPermission.Any<string>() ? string.Join(", ", (IEnumerable<string>)updateLeadsModel.LeadsWithoutEditPermission) : string.Empty, updateLeadsModel.AnySuccess);
            return RedirectToAction("Index");
        }

        public ActionResult SelectAndAssign(long[] leadsId) => PartialView("SelectResponsible", (object)new LeadSelectResponsibleModel()
        {
            LeadsId = leadsId,
            User = (((BaseController)this).AuthenticationService).GetCurrentUser<EleWise.ELMA.Security.Models.IUser>()
        });

        [HttpPost]
        public ActionResult SelectAndAssign(LeadSelectResponsibleModel model)
        {
            if (model.User != null)
                return this.AssignTo(model.User.Id, model.LeadsId);

            (((BaseController)this).Notifier).Error(EleWise.ELMA.SR.T("Не выбран ответственный для присвоения."));
            return RedirectToAction("Index", "Lead");
        }

        [HttpGet]
        public ActionResult ChangeType(long[] leadsId) => PartialView("SelectTypes", (object)new LeadChangeTypeModel()
        {
            LeadsId = leadsId
        });

        [HttpPost]
        public ActionResult ChangeType(LeadChangeTypeModel model)
        {
            if (model.Types == null)
            {

                (((BaseController)this).Notifier).Error(EleWise.ELMA.SR.T("Не выбран тип для присвоения."));
                return RedirectToAction("Index", "Lead");
            }
            string leadsWithoutEditAccess;
            bool anySuccessOperation = model.Save(out leadsWithoutEditAccess);
            if (model.LeadsId.Length == 1)
                this.CreateLeadChangeTypeMessage(model, anySuccessOperation);
            else
                this.CreateMultipleLeadsChangeTypeMessage(leadsWithoutEditAccess, anySuccessOperation);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Dublicate(long leadId)
        {
            if (ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
            {
                return RedirectToAction("Details", new { leadId });
            }
            return PartialView("Dublicate", new DublicateLeadModel(LeadManager.Instance.Load(leadId)));
        }

        [HttpGet]
        public ActionResult LeadAttachDublicate(long leadId, long thisLeadId)
        {
            if (this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking)
                return RedirectToAction("Details", (object)new
                {
                    thisLeadId = thisLeadId
                });
            LeadManager.Instance.Dublicate(LeadManager.Instance.Load(thisLeadId), LeadManager.Instance.Load(leadId));
            return RedirectToAction("Details", (object)new
            {
                id = thisLeadId
            });
        }

        [HttpGet]
        public ActionResult ContractorAttachDublicate(long contractorId, long thisLeadId)
        {
            if (this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking)
                return RedirectToAction("Details", (object)new
                {
                    thisLeadId = thisLeadId
                });
            LeadManager.Instance.Dublicate(LeadManager.Instance.Load(thisLeadId), ContractorManager.Instance.Load(contractorId));
            return RedirectToAction("Details", (object)new
            {
                id = thisLeadId
            });
        }

        [HttpGet]
        public ActionResult NotDublicate(long leadId)
        {
            if (this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking)
                return RedirectToAction("Details", (object)new
                {
                    id = leadId
                });
            LeadManager.Instance.NotDublicate(LeadManager.Instance.Load(leadId));
            return RedirectToAction("Details", (object)new
            {
                id = leadId
            });
        }

        [HttpPost]
        public ActionResult Dublicate(DublicateLeadModel model)
        {
            if (this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking)
            {

                (((BaseController)this).Notifier).Error(EleWise.ELMA.SR.T("Производится перерасчет разрешений. Изменение заблокировано. Пожалуйста попробуйте позже."));
                return RedirectToAction("Details", (object)new
                {
                    Id = model.ThisLead.Id
                });
            }
            model.Dublicate();
            return RedirectToAction("Details", (object)new
            {
                id = model.ThisLead.Id
            });
        }

        [HttpPost]
        public ActionResult CheckCompleteCalcDublicate(long leadId)
        {
            try
            {
                if (LeadDublicateStateManager.Instance.GetLeadDublicateState(base.Manager.Load(leadId)).Status != LeadDublicateStatus.New)
                    return Json((object)new
                    {
                        success = true
                    }, "text/html");
            }
            catch
            {
                return Json((object)new
                {
                    success = false
                }, "text/html");
            }
            return Json((object)new
            {
                success = false
            }, "text/html");
        }

        private void CreateMultipleLeadsChangeTypeMessage(
          string leadsWithoutEditAccess,
          bool anySuccessOperation)
        {
            if (anySuccessOperation)
            {

                (((BaseController)this).Notifier).Information(EleWise.ELMA.SR.T("Типы потенциальных клиентов изменены"));
            }
            if (!(leadsWithoutEditAccess != string.Empty))
                return;
            EleWise.ELMA.Security.Models.IUser currentUser = Locator.GetService<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();

            (((BaseController)this).Notifier).Error(EleWise.ELMA.SR.T("Не удалось сменить тип потенциальных клиентов {0} на пользователя {1}, т.к. у него отсутствуют права на редактирование данных потенциальных клиентов", (object)leadsWithoutEditAccess, (object)currentUser.FullName));
        }

        private void CreateLeadChangeTypeMessage(LeadChangeTypeModel model, bool anySuccessOperation)
        {
            ILead lead = base.Manager.Load(model.LeadsId[0]);
            string str = ((Controller)this).Url.Entity((IEntity)lead);
            if (anySuccessOperation)
            {

                (((BaseController)this).Notifier).Information(MvcHtmlString.Create(EleWise.ELMA.SR.T("Тип потенциального клиента <a href='{1}'>{0}</a> изменен", (object)lead.Name.HtmlEncode(), (object)str)));
            }
            else
            {
                EleWise.ELMA.Security.Models.IUser currentUser = Locator.GetService<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();

                (((BaseController)this).Notifier).Error(MvcHtmlString.Create(EleWise.ELMA.SR.T("Тип потенциального клиента <a href='{1}'>{0}</a> не изменен,  т.к. у пользователя {2} отсутствует право на редактирование данного потенциального клиента", (object)lead.Name.HtmlEncode(), (object)str, (object)currentUser.FullName.HtmlEncode())));
            }
        }

        private void CreateLeadsActivatedMessage(
          string leadsWithoutEditAccess,
          string leadsIncorrectStatus,
          bool anySuccessAssigment)
        {
            if (anySuccessAssigment)
            {

                (((BaseController)this).Notifier).Information(EleWise.ELMA.SR.T("Потенциальные клиенты активированы"));
            }
            if (leadsWithoutEditAccess != string.Empty)
            {
                EleWise.ELMA.Security.Models.IUser currentUser = Locator.GetService<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();

                (((BaseController)this).Notifier).Error(MvcHtmlString.Create(EleWise.ELMA.SR.T("Не удалось активировать потенциальных клиентов {0} на пользователя {1}, т.к. у него отсутствуют права на редактирование данных потенциальных клиентов", (object)leadsWithoutEditAccess, (object)currentUser.FullName)));
            }
            if (!(leadsIncorrectStatus != string.Empty))
                return;

            (((BaseController)this).Notifier).Error(MvcHtmlString.Create(EleWise.ELMA.SR.T("Не удалось активировать потенциальных клиентов: {0}. Операция активации доступна только для возможностей, имеющих статус \"Неквалифицированный\" или \"Дубль\"", (object)leadsIncorrectStatus)));
        }

        private void CreateLeadsAssignedMessage(
          EleWise.ELMA.Security.Models.IUser user,
          string leadsWithoutEditAccess,
          bool anySuccessAssigment)
        {
            if (this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking)
            {

                (((BaseController)this).Notifier).Error(EleWise.ELMA.SR.T("Производится перерасчет разрешений. Изменение заблокировано. Пожалуйста попробуйте позже."));
            }
            if (anySuccessAssigment)
            {

                (((BaseController)this).Notifier).Information(EleWise.ELMA.SR.T("Потенциальные клиенты назначены на пользователя {0}", (object)user.FullName));
            }
            if (!(leadsWithoutEditAccess != string.Empty))
                return;

            (((BaseController)this).Notifier).Error(EleWise.ELMA.SR.T("Не удалось назначить потенциальных клиентов {0} на пользователя {1}, т.к. у него отсутствуют права на редактирование данных потенциальных клиентов", (object)leadsWithoutEditAccess, (object)user.FullName));
        }

        [CustomGridAction]
        public virtual ActionResult GridWithSummary(GridCommand command, [Bind(Prefix = "DataFilter")] FilterModel filter, long? FilterId = null, string SearchTasksType = null, [Bind(Prefix = "DataFilter.ShowSummary")] bool? showSummary = null, [Bind(Prefix = "DataFilter.SummaryFilter")] SummaryLeadStatus? summaryLeadStatus = null)
        {
            if (filter == null)
            {
                filter = CreateFilter(FilterId);
            }
            if (showSummary.HasValue && !((LeadManager)base.Manager).ForceShowSummary(filter.Entity as IFilter))
            {
                DataAccessManager.BLOBManager.SetBLOB(ShowSummaryGuid, "ShowSummary", showSummary.Value);
            }
            base.ViewBag.ShowSummary = showSummary ?? (((LeadManager)base.Manager).ForceShowSummary(filter.Entity as IFilter) || (DataAccessManager.BLOBManager.GetBLOB<bool?>(ShowSummaryGuid, "ShowSummary") ?? false));
            ILeadFilter leadFilter = filter.Filter as ILeadFilter;
            if (leadFilter != null && !leadFilter.SummaryLeadStatus.HasValue && base.ViewBag.ShowSummary)
            {
                leadFilter.SummaryLeadStatus = summaryLeadStatus;
            }
            ActionResult actionResult = Grid(command, filter, FilterId, SearchTasksType);
            if (actionResult is PartialViewResult partialViewResult)
            {
                partialViewResult.ViewName = "Grid";
            }
            return actionResult;
        }

        [HttpGet]
        public ActionResult Convert(long id)
        {
            if (this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking)
            {

                (((BaseController)this).Notifier).Error(EleWise.ELMA.SR.T("Производится перерасчет разрешений. Изменение заблокировано. Пожалуйста попробуйте позже."));
                return RedirectToAction("Details", (object)new
                {
                    id = id
                });
            }
            LeadConvertModel model = new LeadConvertModel();
            model.Entity = LeadManager.Instance.Load(id);
            return View((object)model);
        }

        [HttpGet]
        public ActionResult ConvertV2(long id) => PartialView("Shared/UI/PageApplication", (object)new PageApplicationData(new Guid("f7c27aa5-6dc0-4ae2-97ea-d0563a81831d"), new Dictionary<string, object>()
    {
      {
        "LeadId",
        (object) id
      }
    })
        {
            ApplicationId = new Guid("{364C95C7-492A-4F0C-8287-9887035B6046}")
        });

        [HttpPost]
        public ActionResult PrepareContractorData(LeadConvertModel model)
        {
            Type typeByUid = this.metadataRuntimeService.GetTypeByUid(model.ContractorUid);
            PropertyMap contractorMap = LeadManager.Instance.ConvertToContractorMap(typeByUid);
            IContractor contractor = (IContractor)InterfaceActivator.Create(typeByUid);
            PropertyMapHelper.Map((object)model.Entity, (object)contractor, contractorMap);
            IContractorBaseModel2 contractorBaseModel2 = this.contractorModelProviders.FirstOrDefault<IContractorBaseModel2>((Func<IContractorBaseModel2, bool>)(p => p.ContratorTypeUid == model.ContractorUid));
            if (contractorBaseModel2 == null)
                throw new Exception(EleWise.ELMA.SR.T("Не найдена модель для контрагента {0}", (object)model.ContractorUid));
            Guid? valueOrDefault = LeadController.LeadConverterTypeToFormMap.GetValueOrDefault<Guid, Guid?>(model.ContractorUid, new Guid?());
            model.Contractor = valueOrDefault.HasValue ? contractorBaseModel2.CreateFromContractor(contractor, valueOrDefault.Value) : contractorBaseModel2.CreateFromContrator(contractor, EleWise.ELMA.Model.Views.ViewType.Edit);
            return PartialView("Convert/StepContractor", (object)model);
        }

        protected void FillContacts(LeadConvertModel model)
        {
            model.Contractor.PrepareSave();
            PropertyMap contactMap = LeadManager.Instance.ConvertToContactMap();
            model.Contacts = new List<IContact>();
            foreach (ILeadContact contact1 in (IEnumerable<ILeadContact>)model.Entity.Contacts)
            {
                IContact contact2 = InterfaceActivator.Create<IContact>();
                IContact objRight = contact2;
                PropertyMap map = contactMap;
                PropertyMapHelper.Map((object)contact1, (object)objRight, map);
                contact2.Contractor = model.Contractor.Contractor;
                model.Contacts.Add(contact2);
            }
            model.Contractor.Contractor.Contacts.Clear();
            model.Contractor.Contractor.Contacts.AddAll((ICollection<IContact>)model.Contacts);
        }

        [HttpPost]
        public ActionResult PrepareContactsData(LeadConvertModel model)
        {
            this.FillContacts(model);
            return PartialView("Convert/StepContacts", (object)model);
        }

        [HttpPost]
        public ActionResult PrepareSaleRelData(LeadConvertModel model)
        {
            this.FillContacts(model);
            string viewName;
            if (model.ConvertUid == LeadController.saleUid)
            {
                LeadConvertModel leadConvertModel = model;
                SaleModel saleModel = new SaleModel();
                saleModel.ContractorReadOnly = true;
                saleModel.FormUid = LeadController.LeadConverterTypeToFormMap.GetValueOrDefault<Guid, Guid?>(model.ConvertUid, new Guid?());
                leadConvertModel.Sale = saleModel;
                model.Sale.Entity.Contractor = model.Contractor.Contractor;
                model.Sale.Entity.MarketingGroup = model.Entity.MarketingGroup;
                model.Sale.Entity.MarketingActivity = model.Entity.MarketingActivity;
                model.Sale.Entity.MarketingEffect = model.Entity.MarketingEffect;
                viewName = "Convert/StepSale";
            }
            else
            {
                IRelationship relationship = (IRelationship)InterfaceActivator.Create(this.metadataRuntimeService.GetTypeByUid(model.ConvertUid));
                IRelationshipUser relationshipUser = InterfaceActivator.Create<IRelationshipUser>();

                relationshipUser.User = (((BaseController)this).AuthenticationService).GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
                relationshipUser.Status = RelationshipUserStatus.Participant;
                relationship.RelationshipUsers.Add(relationshipUser);
                IRelationshipBaseModel2 relationshipBaseModel2 = this.relationshipModelProviders.FirstOrDefault<IRelationshipBaseModel2>((Func<IRelationshipBaseModel2, bool>)(p => p.RelationshipTypeUid == model.ConvertUid));
                if (relationshipBaseModel2 == null)
                    throw new Exception(EleWise.ELMA.SR.T("Не найдена модель для взаимоотношения {0}", (object)model.ContractorUid));
                Guid? valueOrDefault = LeadController.LeadConverterTypeToFormMap.GetValueOrDefault<Guid, Guid?>(model.ConvertUid, new Guid?());
                model.Relationship = valueOrDefault.HasValue ? relationshipBaseModel2.CreateFromRelationship(relationship, valueOrDefault.Value) : relationshipBaseModel2.CreateFromRelationship(relationship);
                model.Relationship.LinkReadOnly = true;
                model.Relationship.Relationship.Contractor = model.Contractor.Contractor;
                viewName = "Convert/StepRelationship";
            }
            return PartialView(viewName, (object)model);
        }

        [NonAction]
        private bool CanUseRuntimeV2ForLeadConversion()
        {
            List<ClassMetadata> childClasses1 = MetadataLoader.GetChildClasses(LeadController.contractorUid);
            List<ClassMetadata> childClasses2 = MetadataLoader.GetChildClasses(LeadController.relationshipUid);
            ClassMetadata metadata = (ClassMetadata)MetadataLoader.LoadMetadataOrNull(LeadController.saleUid);
            Func<ClassMetadata, bool> predicate = (Func<ClassMetadata, bool>)(md => this.IsDefaultFormHasRuntimeV2(md, EleWise.ELMA.Model.Views.ViewType.Edit));
            return childClasses1.All<ClassMetadata>(predicate) && childClasses2.All<ClassMetadata>((Func<ClassMetadata, bool>)(md => this.IsDefaultFormHasRuntimeV2(md, EleWise.ELMA.Model.Views.ViewType.Create))) && this.IsDefaultFormHasRuntimeV2(metadata, EleWise.ELMA.Model.Views.ViewType.Create);
        }

        [NonAction]
        private bool IsDefaultFormHasRuntimeV2(ClassMetadata metadata, EleWise.ELMA.Model.Views.ViewType viewType)
        {
            FormViewItem form = metadata.DefaultForms.GetForm(viewType);
            return form != null && form.RuntimeVersion == RuntimeVersion.Version2;
        }

        [NonAction]
        private void ConvertTasks(ILead lead, IContractor contractor)
        {
            ICRMTaskBaseFilter filter = InterfaceActivator.Create<ICRMTaskBaseFilter>();
            filter.Lead = lead;
            foreach (ICRMTaskBase crmTaskBase in TaskManager.Instance.Find((IEntityFilter)filter, FetchOptions.All).Cast<ICRMTaskBase>().Where<ICRMTaskBase>((Func<ICRMTaskBase, bool>)(crmTask => crmTask != null)))
                crmTaskBase.Contractor = contractor;
        }

        [NonAction]
        private void ConvertCrmAttachments(ILead lead, IContractor contractor) => CrmAttachmentManager.Instance.Find((Expression<Func<ICRMAttachment, bool>>)(c => c.Lead == lead)).ForEach<ICRMAttachment>((Action<ICRMAttachment>)(a => a.Contractor = contractor));

        [NonAction]
        private void ConvertRelationships(ILead lead, IContractor contractor) => RelationshipManager.Instance.Find((Expression<Func<IRelationship, bool>>)(r => r.Lead == lead)).ForEach<IRelationship>((Action<IRelationship>)(r => r.Contractor = contractor));

        [HttpPost]
        [TransactionAction]
        public ActionResult Convert(LeadConvertModel model)
        {
            if (LeadController.SaleUid == Guid.Empty)
                LeadController.SaleUid = InterfaceActivator.UID<ISale>();
            this.FillContacts(model);
            if (model.ConvertUid == LeadController.SaleUid)
                model.Sale.Entity.Contractor = model.Contractor.Contractor;
            else if (model.ConvertUid != Guid.Empty)
            {
                model.Relationship.Relationship.Contractor = model.Contractor.Contractor;
                if (model.Relationship.Relationship is IRelationshipMeeting relationship2)
                {
                    if (relationship2.TimeNotSet)
                        RelationshipMeetingManager.Instance.ClarifyTime(relationship2);
                    else if (model.Relationship is RelationshipMeetingModel relationship1 && relationship1.WholeDay)
                    {
                        relationship2.StartDate = relationship2.StartDate.Date.NormalizeStartDate(false);
                        relationship2.EndDate = relationship2.StartDate.NormalizeEndDate(false);
                    }
                }
                else
                    model.Relationship.Relationship.EndDate = model.Relationship.Relationship.StartDate.AddMinutes((double)RelationshipManager.GetDefaultDurationByEntityTypeUid(model.Relationship.Relationship.TypeUid));
            }
            this.ConvertTasks(model.Entity, model.Contractor.Contractor);
            this.ConvertCrmAttachments(model.Entity, model.Contractor.Contractor);
            this.ConvertRelationships(model.Entity, model.Contractor.Contractor);
            LeadManager.Instance.ConvertComplete(model.Entity, model.Contractor.Contractor, (IEnumerable<IContact>)model.Contacts, model.ConvertUid == LeadController.SaleUid ? model.Sale.Entity : (ISale)null, model.ConvertUid == Guid.Empty || model.ConvertUid == LeadController.SaleUid ? (IRelationship)null : model.Relationship.Relationship, model.Comment);
            return !(model.ConvertUid == InterfaceActivator.UID<ISale>()) ? Redirect(((Controller)this).Url.Entity((IEntity)model.Contractor.Contractor)) : Redirect(((Controller)this).Url.Entity((IEntity)model.Sale.Entity));
        }

        protected virtual string GridIdPrefix => "LeadGrid";

        protected virtual bool EnableEqlQuery => true;

        [HttpGet]
        public ActionResult LeadPortlet(LeadPortletPersonalization settings) => PartialView((object)new LeadPortletModel()
        {
            FilterId = (settings.Filter != null ? new long?(settings.Filter.Id) : new long?()),
            ShowOnlyMy = settings.ShowOnlyMy
        });

        [CustomGridAction]
        public ActionResult PortletGrid(GridCommand command, long? filterId, bool showOnlyMy)
        {
            FilterModel filter = this.CreateFilter(filterId, new Guid?(), (IEntityFilter)null, (EleWise.ELMA.Web.Mvc.Models.Grids.GridState)null, "Filter");
            ((ILeadFilter)filter.Filter).ShowOnlyMy = showOnlyMy;
            return PartialView((object)this.CreateGridData(command, filter));
        }

        private IEnumerable<T> AddRange<T>(List<T> list, IEnumerable<T> data)
        {
            list.AddRange(data);
            return data;
        }

        [CustomGridAction]
        public virtual ActionResult DublicateContractorsGrid(
          GridCommand command,
          long leadId,
          long maxPercent)
        {
            ILead lead = LeadManager.Instance.Load(leadId);
            List<IDublicateContractor> dublicateContractors = new List<IDublicateContractor>();
            ((ControllerBase)this).ViewData["DublicateContractors"] = (object)dublicateContractors;
            ((ControllerBase)this).ViewData["MaxPercent"] = (object)maxPercent;
            GridData<IContractor> model = new GridData<IContractor>()
            {
                Command = command
            };
            model.SetCount((Func<GridData<IContractor>, FetchOptions, long>)((d, f) => LeadManager.Instance.DublicateContractorsCount(lead)));
            model.SetDataSource((Func<GridData<IContractor>, FetchOptions, IEnumerable>)((d, f) => d.Count <= 0 ? (IEnumerable)Enumerable.Empty<IContractor>() : (IEnumerable)this.AddRange<IDublicateContractor>(dublicateContractors, (IEnumerable<IDublicateContractor>)LeadManager.Instance.DublicateContractors(f, lead)).Select<IDublicateContractor, IContractor>((Func<IDublicateContractor, IContractor>)(dc => dc.Dublicate))));
            return PartialView((object)model);
        }

        [CustomGridAction]
        public virtual ActionResult DublicateLeadsGrid(
          GridCommand command,
          long leadId,
          long maxPercent)
        {
            ILead lead = LeadManager.Instance.Load(leadId);
            List<IDublicateLead> dublicateLeads = new List<IDublicateLead>();
            ((ControllerBase)this).ViewData["DublicateLeads"] = (object)dublicateLeads;
            ((ControllerBase)this).ViewData["MaxPercent"] = (object)maxPercent;
            GridData<ILead> model = new GridData<ILead>()
            {
                Command = command
            };
            model.SetCount((Func<GridData<ILead>, FetchOptions, long>)((d, f) => LeadManager.Instance.DublicateLeadsCount(lead)));
            model.SetDataSource((Func<GridData<ILead>, FetchOptions, IEnumerable>)((d, f) => d.Count <= 0 ? (IEnumerable)Enumerable.Empty<ILead>() : (IEnumerable)this.AddRange<IDublicateLead>(dublicateLeads, (IEnumerable<IDublicateLead>)LeadManager.Instance.DublicateLeads(f, lead)).Select<IDublicateLead, ILead>((Func<IDublicateLead, ILead>)(dl => dl.Dublicate))));
            return PartialView((object)model);
        }

        private ActionResult SelectPermission(ILead instance)
        {
            ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
            bool flag = serviceNotNull.HasPermission(CRMPermissionProvider.CRMLeadIssuanceElementPermission, (object)instance) || serviceNotNull.HasPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, (object)instance) || serviceNotNull.HasPermission(CRMPermissionProvider.CRMFullAccessPermission);
            CRMPermissionModel model = new CRMPermissionModel();
            model.LockEditPermission = this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking;
            model.Id = instance.Id;
            Dictionary<Guid, Guid> participantWorkOne = new Dictionary<Guid, Guid>();
            Dictionary<Guid, Guid> InformsOne = new Dictionary<Guid, Guid>();
            model.AdditionalPermissionsModel = this.PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel((object)instance, InterfaceActivator.TypeOf<ILead>(), ((Controller)this).Url, (Func<IInstanceSettingsPermissionHolder, bool>)(h =>
         {
             if ((!(h is ILeadPersonPermission) || ((ILeadPersonPermission)h).Lead != instance ? 0 : (!((ILeadPersonPermission)h).InheritedFromNumber.HasValue ? 1 : 0)) == 0)
                 return false;
             if (h.TypeRoleId == CommonRoleTypes.ParticipantWork.Id)
             {
                 if (participantWorkOne.ContainsKey(h.PermissionId))
                     return false;
                 participantWorkOne.Add(h.PermissionId, h.PermissionId);
                 return true;
             }
             if (!(h.TypeRoleId == CommonRoleTypes.Informs.Id))
                 return true;
             if (InformsOne.ContainsKey(h.PermissionId))
                 return false;
             InformsOne.Add(h.PermissionId, h.PermissionId);
             return true;
         }), true, (string)null);
            model.AdditionalPermissionsModel.Instance = (object)instance;
            model.AdditionalPermissionsModel.BindModelName = "additionalPermissions";
            if (model.LockEditPermission)
                model.AdditionalPermissionsModel.Edit = false;
            model.AdditionalPermissionsModel.NoForm = false;
            ((Action<EntityPermissionRoleTypeSelectorModel>)(m => m.Routes = new RouteValueDictionary((object)new
            {
                action = "PermissionSettings",
                controller = "Lead",
                area = "EleWise.ELMA.CRM.Web"
            })))(model.AdditionalPermissionsModel);
            model.InheritAvailable = flag;
            model.InheritPermissions = instance.InheritPermissions;
            participantWorkOne = new Dictionary<Guid, Guid>();
            InformsOne = new Dictionary<Guid, Guid>();
            model.InheritPermissionsModel = this.PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel((object)instance, InterfaceActivator.TypeOf<ILead>(), ((Controller)this).Url, (Func<IInstanceSettingsPermissionHolder, bool>)(h =>
         {
             if ((!(h is ILeadPersonPermission) || ((ILeadPersonPermission)h).Lead != instance ? 0 : (((ILeadPersonPermission)h).InheritedFromNumber.HasValue ? 1 : 0)) == 0)
                 return false;
             if (h.TypeRoleId == CommonRoleTypes.ParticipantWork.Id)
             {
                 if (participantWorkOne.ContainsKey(h.PermissionId))
                     return false;
                 participantWorkOne.Add(h.PermissionId, h.PermissionId);
             }
             if (h.TypeRoleId == CommonRoleTypes.Informs.Id)
             {
                 if (InformsOne.ContainsKey(h.PermissionId))
                     return false;
                 InformsOne.Add(h.PermissionId, h.PermissionId);
             }
             return true;
         }), true, (string)null);
            model.InheritPermissionsModel.BindModelName = "InheritPermissions";
            model.InheritPermissionsModel.Instance = (object)instance;
            model.InheritPermissionsModel.Edit = false;
            return PartialView("Lead/LeadPermissionSetting", (object)model);
        }

        [HttpPost]
        public ActionResult EnableInheritPermission(ILead instance, bool enable)
        {
            LeadManager.Instance.EnableInheritPermissions(instance, enable);
            return this.SelectPermission(instance);
        }

        public ActionResult GetPermissionSettings(ILead instance) => this.PermissionSettings(instance);

        [HttpPost]
        [TransactionAction]
        public ActionResult PermissionSettings(long id, EditableListModel additionalPermissions)
        {
            ILead instance = LeadManager.Instance.Load(id);
            if (this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking)
                return RedirectToAction("Details", (object)new
                {
                    Id = instance.Id
                });
            EleWise.ELMA.Security.Models.IUser systemUser = UserManager.Instance.Load(SecurityConstants.SystemUserUid);
            if (additionalPermissions != null)
                this.PermissionsModelService.BindPermissionsFromModel((object)instance, additionalPermissions, (Action<ICollection<IInstanceSettingsPermissionHolder>, IEnumerable<IInstanceSettingsPermissionHolder>>)((holders, newHolders) =>
              {
                  List<IInstanceSettingsPermissionHolder> list = newHolders.Where<IInstanceSettingsPermissionHolder>((Func<IInstanceSettingsPermissionHolder, bool>)(e => e.TypeRoleId != CommonRoleTypes.ParticipantWork.Id && e.TypeRoleId != CommonRoleTypes.Informs.Id)).ToList<IInstanceSettingsPermissionHolder>();
                  foreach (IInstanceSettingsPermissionHolder permissionHolder1 in newHolders.Where<IInstanceSettingsPermissionHolder>((Func<IInstanceSettingsPermissionHolder, bool>)(e => e.TypeRoleId == CommonRoleTypes.ParticipantWork.Id)))
                  {
                      if (permissionHolder1 != null && instance.ParticipantWork != null)
                      {
                          list.Add((IInstanceSettingsPermissionHolder)new InstanceSettingsPermissionHolder()
                          {
                              Assigned = (IEntity)systemUser,
                              PermissionId = permissionHolder1.PermissionId,
                              Target = permissionHolder1.Target,
                              TypeRoleId = permissionHolder1.TypeRoleId
                          });
                          foreach (EleWise.ELMA.Security.Models.IUser user in (IEnumerable<EleWise.ELMA.Security.Models.IUser>)instance.ParticipantWork)
                          {
                              InstanceSettingsPermissionHolder permissionHolder2 = new InstanceSettingsPermissionHolder()
                              {
                                  Assigned = (IEntity)user,
                                  PermissionId = permissionHolder1.PermissionId,
                                  Target = permissionHolder1.Target,
                                  TypeRoleId = permissionHolder1.TypeRoleId
                              };
                              list.Add((IInstanceSettingsPermissionHolder)permissionHolder2);
                          }
                      }
                  }
                  foreach (IInstanceSettingsPermissionHolder permissionHolder3 in newHolders.Where<IInstanceSettingsPermissionHolder>((Func<IInstanceSettingsPermissionHolder, bool>)(e => e.TypeRoleId == CommonRoleTypes.Informs.Id)))
                  {
                      if (permissionHolder3 != null && instance.Informs != null)
                      {
                          list.Add((IInstanceSettingsPermissionHolder)new InstanceSettingsPermissionHolder()
                          {
                              Assigned = (IEntity)systemUser,
                              PermissionId = permissionHolder3.PermissionId,
                              Target = permissionHolder3.Target,
                              TypeRoleId = permissionHolder3.TypeRoleId
                          });
                          foreach (EleWise.ELMA.Security.Models.IUser inform in (IEnumerable<EleWise.ELMA.Security.Models.IUser>)instance.Informs)
                          {
                              InstanceSettingsPermissionHolder permissionHolder4 = new InstanceSettingsPermissionHolder()
                              {
                                  Assigned = (IEntity)inform,
                                  PermissionId = permissionHolder3.PermissionId,
                                  Target = permissionHolder3.Target,
                                  TypeRoleId = permissionHolder3.TypeRoleId
                              };
                              list.Add((IInstanceSettingsPermissionHolder)permissionHolder4);
                          }
                      }
                  }
                  List<IInstanceSettingsPermissionHolder> permissionHolderList = new List<IInstanceSettingsPermissionHolder>();
                  if (instance.InheritPermissions)
                  {
                      permissionHolderList.AddRange(holders.Where<IInstanceSettingsPermissionHolder>((Func<IInstanceSettingsPermissionHolder, bool>)(h => ((ILeadPersonPermission)h).InheritedFromNumber.HasValue)));
                      foreach (IInstanceSettingsPermissionHolder permissionHolder in permissionHolderList)
                          holders.Remove(permissionHolder);
                  }
                  holders.SyncFrom<IInstanceSettingsPermissionHolder>((IEnumerable<IInstanceSettingsPermissionHolder>)list, (Func<IInstanceSettingsPermissionHolder, IInstanceSettingsPermissionHolder, bool>)((v1, v2) => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals((object)v1.Assigned, (object)v2.Assigned)), onRemove: ((Action<IInstanceSettingsPermissionHolder>)(v =>
       {
           if (!(v is IEntity))
               return;
           ((IEntity)v).Delete();
       })));
                  if (!instance.InheritPermissions)
                      return;
                  foreach (IInstanceSettingsPermissionHolder permissionHolder in permissionHolderList)
                      holders.Add(permissionHolder);
              }));
            return Redirect(((Controller)this).Url.ReturnUrl());
        }

        public ActionResult PermissionSettings(ILead instance) => this.SelectPermission(instance);
    }
}
