using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
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
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers;

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

	private static readonly Dictionary<Guid, Guid?> LeadConverterTypeToFormMap = new Dictionary<Guid, Guid?>
	{
		[contractorIndividualUid] = LeadConverterConsts.ContractorIndividualEditFormUid,
		[contractorLegalUid] = LeadConverterConsts.ContractorLegalEditFormUid,
		[saleUid] = LeadConverterConsts.SaleCreateFormUid,
		[relationshipCallUid] = LeadConverterConsts.RelationshipCallCreateFormUid,
		[relationshipMailUid] = LeadConverterConsts.RelationshipMailCreateFormUid,
		[relationshipMeetingUid] = LeadConverterConsts.RelationshipMeetingCreateFormUid
	};

	private static Guid SaleUid = Guid.Empty;

	private List<string> LocalizedItemNames = new List<string> { SR.T("Создать возможность") };

	public IUnionComplexCacheService ComplexCacheService { get; set; }

	protected override string GridIdPrefix => "LeadGrid";

	protected override bool EnableEqlQuery => true;

	public LeadController(LeadManager leadManager, IMetadataRuntimeService metadataRuntimeService, IEnumerable<IContractorBaseModel2> contractorModelProviders, IEnumerable<IRelationshipBaseModel2> relationshipModelProviders)
	{
		this.leadManager = leadManager;
		this.metadataRuntimeService = metadataRuntimeService;
		this.contractorModelProviders = contractorModelProviders;
		this.relationshipModelProviders = relationshipModelProviders;
	}

	protected ILeadFilter CreateFilter()
	{
		InstanceOf<ILeadFilter> instanceOf = new InstanceOf<ILeadFilter>();
		instanceOf.New.PermissionId = CRMPermissionProvider.CRMAccessPermission.Id;
		return instanceOf.New;
	}

	[ContentItem(Name = "SR.M('Возможности')", Image24 = "#contact.svg")]
	[FilterMenuItem(Id = "crm-leads", Type = typeof(ILead), FilterEditAction = "EditFilters")]
	public ActionResult Index(long? FilterId = null)
	{
		ActionResult val = BaseIndex(FilterId);
		if (val != null)
		{
			return val;
		}
		FilterModel filter = CreateFilter(FilterId);
		GridDataFilter<ILead> gridDataFilter = CreateGridData(null, filter);
		return (ActionResult)(object)((Controller)this).View((object)gridDataFilter);
	}

	public ActionResult Search(long? FilterId = null)
	{
		if (((Controller)this).get_Request().QueryString.Count == 0)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
		}
		FilterModel filter = CreateFilter(FilterId);
		GridDataFilter<ILead> gridDataFilter = CreateGridData(null, filter);
		return (ActionResult)(object)((Controller)this).View("Index", (object)gridDataFilter);
	}

	public static void InitNewModel(LeadModel model)
	{
		InitNewModel(model, leadWasNull: true);
	}

	private static void InitNewModel(LeadModel model, bool leadWasNull)
	{
		if (leadWasNull)
		{
			model.Entity.Email.Add(InterfaceActivator.Create<IEmail>());
			model.Entity.Phone.Add(InterfaceActivator.Create<IPhone>());
			model.LeadTypes = LeadTypeManager.Instance.FindAll();
			model.NewContact.Email.Add(InterfaceActivator.Create<IEmail>());
			model.NewContact.Phone.Add(InterfaceActivator.Create<IPhone>());
		}
	}

	[EntityForm("Create", "EleWise.ELMA.CRM.Web")]
	[Permission("{C8B3D353-B34D-4463-ABED-9FEF8B6D4B47}")]
	public ActionResult CreatePopup([ParameterContainer] ILead lead, Guid? formUid = null, ViewType? viewType = null, bool formReadOnly = false, string parentFormId = "", string formId = "")
	{
		LeadModel leadModel = new LeadModel(lead, (!viewType.HasValue) ? ViewType.Create : viewType.Value)
		{
			FormId = formId,
			FormUid = formUid,
			FormReadOnly = formReadOnly
		};
		leadModel.DynamicFormSettings.ParentFormId = parentFormId;
		DynamicFormSettings dynamicFormSettings = leadModel.DynamicFormSettings;
		dynamicFormSettings.ViewItemId = dynamicFormSettings.ViewItemId + ";" + leadModel.View.Uid;
		InitNewModel(leadModel, lead == null);
		return (ActionResult)(object)((Controller)this).PartialView("Lead/LeadEditFields", (object)leadModel);
	}

	[LeadCreate]
	[Permission("{C8B3D353-B34D-4463-ABED-9FEF8B6D4B47}")]
	[ContentItem(Name = "SR.M('Создать возможность')", Image24 = "#add.svg")]
	public ActionResult Create()
	{
		LeadModel leadModel = new LeadModel();
		leadModel.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
		if (leadModel.LockEditPermission)
		{
			base.Notifier.Error(SR.T("Производится перерасчет разрешений. Изменение заблокировано. Пожалуйста попробуйте позже."));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Lead");
		}
		if (defaultCountry != null)
		{
			IAddress address = EntityManager<IAddress>.Instance.Create();
			address.Country = defaultCountry;
			leadModel.Entity.Address = address;
		}
		InitNewModel(leadModel);
		return (ActionResult)(object)((Controller)this).View((object)leadModel);
	}

	[HttpPost]
	[Permission("{C8B3D353-B34D-4463-ABED-9FEF8B6D4B47}")]
	public ActionResult Create(LeadModel model)
	{
		model.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
		if (model.LockEditPermission)
		{
			base.Notifier.Error(SR.T("Производится перерасчет разрешений. Изменение заблокировано. Пожалуйста попробуйте позже."));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Lead");
		}
		SaveWithCategoryRulesResult saveWithCategoryRulesResult = model.SaveWithCategoryRules();
		string text = null;
		if (saveWithCategoryRulesResult.AddedCategories.Count > 0)
		{
			text = (IsCreatorRequest() ? "" : SR.T("Потенциальный клиент <a href='{1}'>{0}</a> сохранен успешно", model.Entity.Name.HtmlEncode(), ((Controller)this).get_Url().Entity(model.Entity)));
			if (saveWithCategoryRulesResult.AddedCategories.Count > 0)
			{
				if (!IsCreatorRequest())
				{
					text += "<br/>";
					text += SR.T("Автоматически добавлены категории: {0}", saveWithCategoryRulesResult.AddedCategories.Select((ICategory c) => c.Name).ToSeparatedString(", ")).HtmlEncode();
				}
				else
				{
					text = SR.T("Потенциальному клиенту {0} автоматически добавлены категории: {1}", model.Entity.Name, saveWithCategoryRulesResult.AddedCategories.Select((ICategory c) => c.Name).ToSeparatedString(", ")).HtmlEncode();
				}
			}
			base.Notifier.Information(MvcHtmlString.Create(text));
		}
		if (IsCustomViewRequest())
		{
			return HandleCustomViewJsonCallback(model.Entity);
		}
		if (IsCreatorRequest())
		{
			return CreatorJsonWithInformation(model.Entity, text);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { model.Entity.Id });
	}

	[DetailsAction]
	[EntityLink]
	public ActionResult Details(long id, int? tabIndex = 0)
	{
		try
		{
			if (tabIndex.HasValue && DirectoryMapVirtualPathProvider.AnyConfigFile("~/Modules/EleWise.ELMA.CRM.Web/Views/Lead/TabView.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Lead/TasksTab.cshtml"))
			{
				((ControllerBase)this).get_ViewData().set_Item("SelectedTab", (object)tabIndex.Value);
			}
			ILead lead = base.Manager.Load(id);
			ThrowExceptionIfDeleted(lead);
			LeadModel leadModel = new LeadModel(lead, ViewType.Display);
			leadModel.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
			return (ActionResult)(object)((Controller)this).View((object)leadModel);
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Lead");
		}
	}

	[Permission]
	public ActionResult Edit([InstancePermission(typeof(ILead), "{AE298CD3-A16A-4B55-ACFC-545E4A0EBD48}")] long id)
	{
		try
		{
			ILead lead = base.Manager.Load(id);
			ThrowExceptionIfDeleted(lead);
			if (!((IEnumerable<IEmail>)lead.Email).Any())
			{
				lead.Email.Add(InterfaceActivator.Create<IEmail>());
			}
			if (!((IEnumerable<IPhone>)lead.Phone).Any())
			{
				lead.Phone.Add(InterfaceActivator.Create<IPhone>());
			}
			LeadModel leadModel = new LeadModel(lead, ViewType.Edit);
			leadModel.LeadTypes = LeadTypeManager.Instance.FindAll();
			leadModel.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
			if (leadModel.LockEditPermission)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { id });
			}
			return (ActionResult)(object)((Controller)this).View((object)leadModel);
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Contractor");
		}
	}

	[AsyncViewItemAction]
	public ActionResult AsyncViewItem(Guid viewItemUid, long id, ViewType viewType, Guid? formUid)
	{
		LeadModel leadModel = new LeadModel(base.Manager.LoadOrCreate(id), viewType);
		leadModel.FormUid = formUid;
		return AsyncViewItemView(leadModel.View, viewType, viewItemUid, leadModel, (LeadModel m) => m.Entity);
	}

	[HttpPost]
	[TransactionAction]
	[Permission]
	public ActionResult Edit([InstancePermission("{AE298CD3-A16A-4B55-ACFC-545E4A0EBD48}")] LeadModel model)
	{
		try
		{
			model.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
			if (model.LockEditPermission)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { model.Entity.Id });
			}
			LeadManager.Instance.CheckDublicateLead(model.Entity);
			SaveWithCategoryRulesResult saveWithCategoryRulesResult = model.SaveWithCategoryRules((model.UnassignOldCategories == true) ? RuleDeletedCategoryAction.Delete : ((model.UnassignOldCategories == false) ? RuleDeletedCategoryAction.Keep : RuleDeletedCategoryAction.Revert));
			if (!model.UnassignOldCategories.HasValue && saveWithCategoryRulesResult.DeletedCategories.Count > 0)
			{
				base.UnitOfWorkManager.RollbackCurrent("");
				model.CategoriesToDelete = saveWithCategoryRulesResult.DeletedCategories;
				return (ActionResult)(object)((Controller)this).View((object)model);
			}
			if (saveWithCategoryRulesResult.AddedCategories.Count > 0 || saveWithCategoryRulesResult.DeletedCategories.Count > 0)
			{
				string text = SR.T("Потенциальный клиент <a href=\"{1}\">{0}</a> сохранено успешно", model.Entity.Name.HtmlEncode(), ((Controller)this).get_Url().Entity(model.Entity));
				if (saveWithCategoryRulesResult.AddedCategories.Count > 0)
				{
					text = text + "<br/> " + SR.T("Автоматически добавлены категории: {0}", saveWithCategoryRulesResult.AddedCategories.Select((ICategory c) => c.Name).ToSeparatedString(", ")).HtmlEncode();
				}
				if (saveWithCategoryRulesResult.DeletedCategories.Count > 0)
				{
					text = text + "<br/> " + SR.T("Удалены категории: {0}", saveWithCategoryRulesResult.DeletedCategories.Select((ICategory c) => c.Name).ToSeparatedString(", ")).HtmlEncode();
				}
				base.Notifier.Information(MvcHtmlString.Create(text));
			}
			return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { model.Entity.Id });
		}
		catch (Exception ex)
		{
			base.Logger.Error(ex.Message, ex);
			base.UnitOfWorkManager.RollbackCurrent("");
			FormNotifierExtensions.Error(base.Notifier, ex);
			return (ActionResult)(object)((Controller)this).View((object)model);
		}
	}

	[HttpGet]
	[Permission("{dde5667e-bc3f-458c-abb6-2d693f6ffec2}")]
	public ActionResult Delete(long id)
	{
		try
		{
			if (ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { id });
			}
			ILead lead = LeadManager.Instance.Load(id);
			LeadManager.Instance.Delete(lead);
			base.Notifier.Information(SR.T("Потенциальный клиент \"{0}\" успешно удален", lead.Name));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Lead", (object)new
			{
				area = "EleWise.ELMA.CRM.Web"
			});
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Lead", (object)new
			{
				area = "EleWise.ELMA.CRM.Web"
			});
		}
	}

	[HttpGet]
	[Permission("{dde5667e-bc3f-458c-abb6-2d693f6ffec2}")]
	public ActionResult DeleteGroup(long[] leadsId, string popupId)
	{
		if (ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
		{
			base.Notifier.Error(SR.T("Производится перерасчет разрешений. Изменение заблокировано. Пожалуйста попробуйте позже."));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Lead", (object)new
			{
				area = "EleWise.ELMA.CRM.Web"
			});
		}
		List<ILead> leads = leadsId.Select((long id) => base.Manager.Load(id)).ToList();
		if (leadsId.Length != 0)
		{
			return (ActionResult)(object)((Controller)this).PartialView("DeleteGroup", (object)new GroupLeadInfo
			{
				Leads = leads,
				PopupId = popupId
			});
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}

	[HttpPost]
	[Permission("{dde5667e-bc3f-458c-abb6-2d693f6ffec2}")]
	public ActionResult DeleteGroup(GroupLeadInfo leadsInfo)
	{
		if (ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
		{
			base.Notifier.Error(SR.T("Производится перерасчет разрешений. Изменение заблокировано. Пожалуйста попробуйте позже."));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Lead", (object)new
			{
				area = "EleWise.ELMA.CRM.Web"
			});
		}
		leadsInfo.Leads.ForEach(delegate(ILead m)
		{
			base.Manager.Load(m.Id).Delete();
		});
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}

	[HttpGet]
	public ActionResult Fail(long id)
	{
		bool showConvert = base.Manager.Load(id).Contractor == null;
		return (ActionResult)(object)((Controller)this).PartialView("State/Fail", (object)new LeadFailModel
		{
			Id = id,
			ShowConvert = showConvert
		});
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult Fail(LeadFailModel model)
	{
		ILead lead = base.Manager.Load(model.Id);
		LeadManager.Instance.Fail(lead, model.Convert, model.Comment);
		string text = ((Controller)this).get_Url().Entity(lead);
		base.Notifier.Information(MvcHtmlString.Create(SR.T("Потенциальный клиент <a href='{1}'>{0}</a>, статус \"Неквалифицированный\" сохранен", lead.Name.HtmlEncode(), text)));
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}

	[HttpGet]
	public ActionResult Begin(long id)
	{
		ILead lead = base.Manager.Load(id);
		if (lead.Status == LeadStatus.InHand)
		{
			base.Notifier.Information(SR.T("Потенциальный клиент \"{0}\" уже имеет статус \"В работе\"", lead.Name));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { id });
		}
		LeadManager.Instance.BeginWork(lead);
		base.Notifier.Information(SR.T("Потенциальный клиент \"{0}\", статус \"В работе\" сохранен", lead.Name));
		return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { id });
	}

	[HttpGet]
	public ActionResult ConversationNotStart(long id)
	{
		ILead lead = base.Manager.Load(id);
		if (lead.Status == LeadStatus.ConversationNotStart)
		{
			base.Notifier.Information(SR.T("Потенциальный клиент \"{0}\" уже имеет статус \"Разговор не состоялся\"", lead.Name));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { id });
		}
		LeadManager.Instance.ConversationNotStart(lead);
		base.Notifier.Information(SR.T("Потенциальный клиент \"{0}\", статус \"Разговор не состоялся\" сохранен", lead.Name));
		return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { id });
	}

	public ActionResult Activate(long[] leadsId)
	{
		UpdateLeadsModel updateLeadsModel = leadManager.ActivateManyLeads(leadsId);
		if (updateLeadsModel.Error != null)
		{
			FormNotifierExtensions.Error(base.Notifier, updateLeadsModel.Error);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Lead");
		}
		CreateLeadsActivatedMessage(updateLeadsModel.LeadsWithoutEditPermission.Any() ? string.Join(", ", updateLeadsModel.LeadsWithoutEditPermission) : string.Empty, updateLeadsModel.LeadsIncorrectStatus.Any() ? string.Join(", ", updateLeadsModel.LeadsIncorrectStatus) : string.Empty, updateLeadsModel.AnySuccess);
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
	}

	public ActionResult AssignTo(long userId, long[] leadsId)
	{
		UpdateLeadsModel updateLeadsModel = leadManager.UpdateSqlLeadResponsible(leadsId, userId);
		EleWise.ELMA.Security.Models.IUser user = AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>.Instance.Load(userId);
		if (updateLeadsModel.Error != null)
		{
			FormNotifierExtensions.Error(base.Notifier, updateLeadsModel.Error);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Lead");
		}
		CreateLeadsAssignedMessage(user, updateLeadsModel.LeadsWithoutEditPermission.Any() ? string.Join(", ", updateLeadsModel.LeadsWithoutEditPermission) : string.Empty, updateLeadsModel.AnySuccess);
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}

	public ActionResult SelectAndAssign(long[] leadsId)
	{
		return (ActionResult)(object)((Controller)this).PartialView("SelectResponsible", (object)new LeadSelectResponsibleModel
		{
			LeadsId = leadsId,
			User = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>()
		});
	}

	[HttpPost]
	public ActionResult SelectAndAssign(LeadSelectResponsibleModel model)
	{
		if (model.User == null)
		{
			base.Notifier.Error(SR.T("Не выбран ответственный для присвоения."));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Lead");
		}
		return AssignTo(model.User.Id, model.LeadsId);
	}

	[HttpGet]
	public ActionResult ChangeType(long[] leadsId)
	{
		return (ActionResult)(object)((Controller)this).PartialView("SelectTypes", (object)new LeadChangeTypeModel
		{
			LeadsId = leadsId
		});
	}

	[HttpPost]
	public ActionResult ChangeType(LeadChangeTypeModel model)
	{
		if (model.Types == null)
		{
			base.Notifier.Error(SR.T("Не выбран тип для присвоения."));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Lead");
		}
		string leadsWithoutEditAccess;
		bool anySuccessOperation = model.Save(out leadsWithoutEditAccess);
		if (model.LeadsId.Length == 1)
		{
			CreateLeadChangeTypeMessage(model, anySuccessOperation);
		}
		else
		{
			CreateMultipleLeadsChangeTypeMessage(leadsWithoutEditAccess, anySuccessOperation);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}

	[HttpGet]
	public ActionResult Dublicate(long leadId)
	{
		if (ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { leadId });
		}
		return (ActionResult)(object)((Controller)this).PartialView("Dublicate", (object)new DublicateLeadModel(LeadManager.Instance.Load(leadId)));
	}

	[HttpGet]
	public ActionResult LeadAttachDublicate(long leadId, long thisLeadId)
	{
		if (ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { thisLeadId });
		}
		LeadManager.Instance.Dublicate(LeadManager.Instance.Load(thisLeadId), LeadManager.Instance.Load(leadId));
		return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new
		{
			id = thisLeadId
		});
	}

	[HttpGet]
	public ActionResult ContractorAttachDublicate(long contractorId, long thisLeadId)
	{
		if (ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { thisLeadId });
		}
		LeadManager.Instance.Dublicate(LeadManager.Instance.Load(thisLeadId), ContractorManager.Instance.Load(contractorId));
		return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new
		{
			id = thisLeadId
		});
	}

	[HttpGet]
	public ActionResult NotDublicate(long leadId)
	{
		if (ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new
			{
				id = leadId
			});
		}
		LeadManager.Instance.NotDublicate(LeadManager.Instance.Load(leadId));
		return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new
		{
			id = leadId
		});
	}

	[HttpPost]
	public ActionResult Dublicate(DublicateLeadModel model)
	{
		if (ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
		{
			base.Notifier.Error(SR.T("Производится перерасчет разрешений. Изменение заблокировано. Пожалуйста попробуйте позже."));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { model.ThisLead.Id });
		}
		model.Dublicate();
		return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new
		{
			id = model.ThisLead.Id
		});
	}

	[HttpPost]
	public ActionResult CheckCompleteCalcDublicate(long leadId)
	{
		try
		{
			ILead lead = base.Manager.Load(leadId);
			if (LeadDublicateStateManager.Instance.GetLeadDublicateState(lead).Status != 0)
			{
				return (ActionResult)(object)((Controller)this).Json((object)new
				{
					success = true
				}, "text/html");
			}
		}
		catch
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false
			}, "text/html");
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = false
		}, "text/html");
	}

	private void CreateMultipleLeadsChangeTypeMessage(string leadsWithoutEditAccess, bool anySuccessOperation)
	{
		if (anySuccessOperation)
		{
			base.Notifier.Information(SR.T("Типы потенциальных клиентов изменены"));
		}
		if (leadsWithoutEditAccess != string.Empty)
		{
			EleWise.ELMA.Security.Models.IUser currentUser = Locator.GetService<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			string text = SR.T("Не удалось сменить тип потенциальных клиентов {0} на пользователя {1}, т.к. у него отсутствуют права на редактирование данных потенциальных клиентов", leadsWithoutEditAccess, currentUser.FullName);
			base.Notifier.Error(text);
		}
	}

	private void CreateLeadChangeTypeMessage(LeadChangeTypeModel model, bool anySuccessOperation)
	{
		ILead lead = base.Manager.Load(model.LeadsId[0]);
		string text = ((Controller)this).get_Url().Entity(lead);
		if (anySuccessOperation)
		{
			base.Notifier.Information(MvcHtmlString.Create(SR.T("Тип потенциального клиента <a href='{1}'>{0}</a> изменен", lead.Name.HtmlEncode(), text)));
		}
		else
		{
			EleWise.ELMA.Security.Models.IUser currentUser = Locator.GetService<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			base.Notifier.Error(MvcHtmlString.Create(SR.T("Тип потенциального клиента <a href='{1}'>{0}</a> не изменен,  т.к. у пользователя {2} отсутствует право на редактирование данного потенциального клиента", lead.Name.HtmlEncode(), text, currentUser.FullName.HtmlEncode())));
		}
	}

	private void CreateLeadsActivatedMessage(string leadsWithoutEditAccess, string leadsIncorrectStatus, bool anySuccessAssigment)
	{
		if (anySuccessAssigment)
		{
			base.Notifier.Information(SR.T("Потенциальные клиенты активированы"));
		}
		if (leadsWithoutEditAccess != string.Empty)
		{
			EleWise.ELMA.Security.Models.IUser currentUser = Locator.GetService<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			string text = SR.T("Не удалось активировать потенциальных клиентов {0} на пользователя {1}, т.к. у него отсутствуют права на редактирование данных потенциальных клиентов", leadsWithoutEditAccess, currentUser.FullName);
			base.Notifier.Error(MvcHtmlString.Create(text));
		}
		if (leadsIncorrectStatus != string.Empty)
		{
			string text2 = SR.T("Не удалось активировать потенциальных клиентов: {0}. Операция активации доступна только для возможностей, имеющих статус \"Неквалифицированный\" или \"Дубль\"", leadsIncorrectStatus);
			base.Notifier.Error(MvcHtmlString.Create(text2));
		}
	}

	private void CreateLeadsAssignedMessage(EleWise.ELMA.Security.Models.IUser user, string leadsWithoutEditAccess, bool anySuccessAssigment)
	{
		if (ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
		{
			base.Notifier.Error(SR.T("Производится перерасчет разрешений. Изменение заблокировано. Пожалуйста попробуйте позже."));
		}
		if (anySuccessAssigment)
		{
			base.Notifier.Information(SR.T("Потенциальные клиенты назначены на пользователя {0}", user.FullName));
		}
		if (leadsWithoutEditAccess != string.Empty)
		{
			string text = SR.T("Не удалось назначить потенциальных клиентов {0} на пользователя {1}, т.к. у него отсутствуют права на редактирование данных потенциальных клиентов", leadsWithoutEditAccess, user.FullName);
			base.Notifier.Error(text);
		}
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
		((dynamic)((ControllerBase)this).get_ViewBag()).ShowSummary = showSummary ?? (((LeadManager)base.Manager).ForceShowSummary(filter.Entity as IFilter) || (DataAccessManager.BLOBManager.GetBLOB<bool?>(ShowSummaryGuid, "ShowSummary") ?? false));
		ILeadFilter leadFilter = filter.Filter as ILeadFilter;
		if (leadFilter != null && !leadFilter.SummaryLeadStatus.HasValue && ((dynamic)((ControllerBase)this).get_ViewBag()).ShowSummary)
		{
			leadFilter.SummaryLeadStatus = summaryLeadStatus;
		}
		ActionResult obj = Grid(command, filter, FilterId, SearchTasksType);
		PartialViewResult val = (PartialViewResult)(object)((obj is PartialViewResult) ? obj : null);
		if (val != null)
		{
			((ViewResultBase)val).set_ViewName("Grid");
		}
		return obj;
	}

	[HttpGet]
	public ActionResult Convert(long id)
	{
		if (ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
		{
			base.Notifier.Error(SR.T("Производится перерасчет разрешений. Изменение заблокировано. Пожалуйста попробуйте позже."));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { id });
		}
		LeadConvertModel leadConvertModel = new LeadConvertModel
		{
			Entity = LeadManager.Instance.Load(id)
		};
		return (ActionResult)(object)((Controller)this).View((object)leadConvertModel);
	}

	[HttpGet]
	public ActionResult ConvertV2(long id)
	{
		PageApplicationData pageApplicationData = new PageApplicationData(new Guid("f7c27aa5-6dc0-4ae2-97ea-d0563a81831d"), new Dictionary<string, object> { { "LeadId", id } });
		pageApplicationData.ApplicationId = new Guid("{364C95C7-492A-4F0C-8287-9887035B6046}");
		return (ActionResult)(object)((Controller)this).PartialView("Shared/UI/PageApplication", (object)pageApplicationData);
	}

	[HttpPost]
	public ActionResult PrepareContractorData(LeadConvertModel model)
	{
		Type typeByUid = metadataRuntimeService.GetTypeByUid(model.ContractorUid);
		PropertyMap map = LeadManager.Instance.ConvertToContractorMap(typeByUid);
		IContractor contractor = (IContractor)InterfaceActivator.Create(typeByUid);
		PropertyMapHelper.Map(model.Entity, contractor, map);
		IContractorBaseModel2 contractorBaseModel = contractorModelProviders.FirstOrDefault((IContractorBaseModel2 p) => p.ContratorTypeUid == model.ContractorUid);
		if (contractorBaseModel == null)
		{
			throw new Exception(SR.T("Не найдена модель для контрагента {0}", model.ContractorUid));
		}
		Guid? valueOrDefault = LeadConverterTypeToFormMap.GetValueOrDefault(model.ContractorUid, null);
		model.Contractor = (valueOrDefault.HasValue ? contractorBaseModel.CreateFromContractor(contractor, valueOrDefault.Value) : contractorBaseModel.CreateFromContrator(contractor, ViewType.Edit));
		return (ActionResult)(object)((Controller)this).PartialView("Convert/StepContractor", (object)model);
	}

	protected void FillContacts(LeadConvertModel model)
	{
		model.Contractor.PrepareSave();
		PropertyMap map = LeadManager.Instance.ConvertToContactMap();
		model.Contacts = new List<IContact>();
		foreach (ILeadContact item in (IEnumerable<ILeadContact>)model.Entity.Contacts)
		{
			IContact contact = InterfaceActivator.Create<IContact>();
			PropertyMapHelper.Map(item, contact, map);
			contact.Contractor = model.Contractor.Contractor;
			model.Contacts.Add(contact);
		}
		((ICollection<IContact>)model.Contractor.Contractor.Contacts).Clear();
		model.Contractor.Contractor.Contacts.AddAll((ICollection<IContact>)model.Contacts);
	}

	[HttpPost]
	public ActionResult PrepareContactsData(LeadConvertModel model)
	{
		FillContacts(model);
		return (ActionResult)(object)((Controller)this).PartialView("Convert/StepContacts", (object)model);
	}

	[HttpPost]
	public ActionResult PrepareSaleRelData(LeadConvertModel model)
	{
		FillContacts(model);
		string text;
		if (model.ConvertUid == saleUid)
		{
			model.Sale = new SaleModel
			{
				ContractorReadOnly = true,
				FormUid = LeadConverterTypeToFormMap.GetValueOrDefault(model.ConvertUid, null)
			};
			model.Sale.Entity.Contractor = model.Contractor.Contractor;
			model.Sale.Entity.MarketingGroup = model.Entity.MarketingGroup;
			model.Sale.Entity.MarketingActivity = model.Entity.MarketingActivity;
			model.Sale.Entity.MarketingEffect = model.Entity.MarketingEffect;
			text = "Convert/StepSale";
		}
		else
		{
			IRelationship relationship = (IRelationship)InterfaceActivator.Create(metadataRuntimeService.GetTypeByUid(model.ConvertUid));
			IRelationshipUser relationshipUser = InterfaceActivator.Create<IRelationshipUser>();
			relationshipUser.User = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			relationshipUser.Status = RelationshipUserStatus.Participant;
			relationship.RelationshipUsers.Add(relationshipUser);
			IRelationshipBaseModel2 relationshipBaseModel = relationshipModelProviders.FirstOrDefault((IRelationshipBaseModel2 p) => p.RelationshipTypeUid == model.ConvertUid);
			if (relationshipBaseModel == null)
			{
				throw new Exception(SR.T("Не найдена модель для взаимоотношения {0}", model.ContractorUid));
			}
			Guid? valueOrDefault = LeadConverterTypeToFormMap.GetValueOrDefault(model.ConvertUid, null);
			model.Relationship = (valueOrDefault.HasValue ? relationshipBaseModel.CreateFromRelationship(relationship, valueOrDefault.Value) : relationshipBaseModel.CreateFromRelationship(relationship));
			model.Relationship.LinkReadOnly = true;
			model.Relationship.Relationship.Contractor = model.Contractor.Contractor;
			text = "Convert/StepRelationship";
		}
		return (ActionResult)(object)((Controller)this).PartialView(text, (object)model);
	}

	[NonAction]
	private bool CanUseRuntimeV2ForLeadConversion()
	{
		List<ClassMetadata> childClasses = MetadataLoader.GetChildClasses(contractorUid);
		List<ClassMetadata> childClasses2 = MetadataLoader.GetChildClasses(relationshipUid);
		ClassMetadata metadata = (ClassMetadata)MetadataLoader.LoadMetadataOrNull(saleUid);
		if (childClasses.All((ClassMetadata md) => IsDefaultFormHasRuntimeV2(md, ViewType.Edit)) && childClasses2.All((ClassMetadata md) => IsDefaultFormHasRuntimeV2(md, ViewType.Create)))
		{
			return IsDefaultFormHasRuntimeV2(metadata, ViewType.Create);
		}
		return false;
	}

	[NonAction]
	private bool IsDefaultFormHasRuntimeV2(ClassMetadata metadata, ViewType viewType)
	{
		FormViewItem form = metadata.DefaultForms.GetForm(viewType);
		if (form == null)
		{
			return false;
		}
		return form.RuntimeVersion == RuntimeVersion.Version2;
	}

	[NonAction]
	private void ConvertTasks(ILead lead, IContractor contractor)
	{
		ICRMTaskBaseFilter iCRMTaskBaseFilter = InterfaceActivator.Create<ICRMTaskBaseFilter>();
		iCRMTaskBaseFilter.Lead = lead;
		foreach (ICRMTaskBase item in from ICRMTaskBase crmTask in TaskManager.Instance.Find(iCRMTaskBaseFilter, FetchOptions.All)
			where crmTask != null
			select crmTask)
		{
			item.Contractor = contractor;
		}
	}

	[NonAction]
	private void ConvertCrmAttachments(ILead lead, IContractor contractor)
	{
		CrmAttachmentManager.Instance.Find((ICRMAttachment c) => c.Lead == lead).ForEach(delegate(ICRMAttachment a)
		{
			a.Contractor = contractor;
		});
	}

	[NonAction]
	private void ConvertRelationships(ILead lead, IContractor contractor)
	{
		RelationshipManager.Instance.Find((IRelationship r) => r.Lead == lead).ForEach(delegate(IRelationship r)
		{
			r.Contractor = contractor;
		});
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult Convert(LeadConvertModel model)
	{
		if (SaleUid == Guid.Empty)
		{
			SaleUid = InterfaceActivator.UID<ISale>();
		}
		FillContacts(model);
		if (model.ConvertUid == SaleUid)
		{
			model.Sale.Entity.Contractor = model.Contractor.Contractor;
		}
		else if (model.ConvertUid != Guid.Empty)
		{
			model.Relationship.Relationship.Contractor = model.Contractor.Contractor;
			if (model.Relationship.Relationship is IRelationshipMeeting relationshipMeeting)
			{
				if (relationshipMeeting.TimeNotSet)
				{
					RelationshipMeetingManager.Instance.ClarifyTime(relationshipMeeting);
				}
				else if (model.Relationship is RelationshipMeetingModel relationshipMeetingModel && relationshipMeetingModel.WholeDay)
				{
					relationshipMeeting.StartDate = relationshipMeeting.StartDate.Date.NormalizeStartDate(time: false);
					relationshipMeeting.EndDate = relationshipMeeting.StartDate.NormalizeEndDate(time: false);
				}
			}
			else
			{
				model.Relationship.Relationship.EndDate = model.Relationship.Relationship.StartDate.AddMinutes(RelationshipManager.GetDefaultDurationByEntityTypeUid(model.Relationship.Relationship.TypeUid));
			}
		}
		ConvertTasks(model.Entity, model.Contractor.Contractor);
		ConvertCrmAttachments(model.Entity, model.Contractor.Contractor);
		ConvertRelationships(model.Entity, model.Contractor.Contractor);
		LeadManager.Instance.ConvertComplete(model.Entity, model.Contractor.Contractor, model.Contacts, (model.ConvertUid == SaleUid) ? model.Sale.Entity : null, (model.ConvertUid == Guid.Empty || model.ConvertUid == SaleUid) ? null : model.Relationship.Relationship, model.Comment);
		if (!(model.ConvertUid == InterfaceActivator.UID<ISale>()))
		{
			return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().Entity(model.Contractor.Contractor));
		}
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().Entity(model.Sale.Entity));
	}

	[HttpGet]
	public ActionResult LeadPortlet(LeadPortletPersonalization settings)
	{
		LeadPortletModel leadPortletModel = new LeadPortletModel
		{
			FilterId = ((settings.Filter != null) ? new long?(settings.Filter.Id) : null),
			ShowOnlyMy = settings.ShowOnlyMy
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)leadPortletModel);
	}

	[CustomGridAction]
	public ActionResult PortletGrid(GridCommand command, long? filterId, bool showOnlyMy)
	{
		FilterModel filterModel = CreateFilter(filterId);
		((ILeadFilter)filterModel.Filter).ShowOnlyMy = showOnlyMy;
		GridDataFilter<ILead> gridDataFilter = CreateGridData(command, filterModel);
		return (ActionResult)(object)((Controller)this).PartialView((object)gridDataFilter);
	}

	private IEnumerable<T> AddRange<T>(List<T> list, IEnumerable<T> data)
	{
		list.AddRange(data);
		return data;
	}

	[CustomGridAction]
	public virtual ActionResult DublicateContractorsGrid(GridCommand command, long leadId, long maxPercent)
	{
		ILead lead = LeadManager.Instance.Load(leadId);
		List<IDublicateContractor> dublicateContractors = new List<IDublicateContractor>();
		((ControllerBase)this).get_ViewData().set_Item("DublicateContractors", (object)dublicateContractors);
		((ControllerBase)this).get_ViewData().set_Item("MaxPercent", (object)maxPercent);
		GridData<IContractor> gridData = new GridData<IContractor>
		{
			Command = command
		};
		gridData.SetCount((GridData<IContractor> d, FetchOptions f) => LeadManager.Instance.DublicateContractorsCount(lead));
		gridData.SetDataSource((GridData<IContractor> d, FetchOptions f) => (d.Count <= 0) ? Enumerable.Empty<IContractor>() : (from dc in AddRange(dublicateContractors, LeadManager.Instance.DublicateContractors(f, lead))
			select dc.Dublicate));
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	[CustomGridAction]
	public virtual ActionResult DublicateLeadsGrid(GridCommand command, long leadId, long maxPercent)
	{
		ILead lead = LeadManager.Instance.Load(leadId);
		List<IDublicateLead> dublicateLeads = new List<IDublicateLead>();
		((ControllerBase)this).get_ViewData().set_Item("DublicateLeads", (object)dublicateLeads);
		((ControllerBase)this).get_ViewData().set_Item("MaxPercent", (object)maxPercent);
		GridData<ILead> gridData = new GridData<ILead>
		{
			Command = command
		};
		gridData.SetCount((GridData<ILead> d, FetchOptions f) => LeadManager.Instance.DublicateLeadsCount(lead));
		gridData.SetDataSource((GridData<ILead> d, FetchOptions f) => (d.Count <= 0) ? Enumerable.Empty<ILead>() : (from dl in AddRange(dublicateLeads, LeadManager.Instance.DublicateLeads(f, lead))
			select dl.Dublicate));
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	private ActionResult SelectPermission(ILead instance)
	{
		ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
		bool inheritAvailable = serviceNotNull.HasPermission(CRMPermissionProvider.CRMLeadIssuanceElementPermission, instance) || serviceNotNull.HasPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, instance) || serviceNotNull.HasPermission(CRMPermissionProvider.CRMFullAccessPermission);
		CRMPermissionModel cRMPermissionModel = new CRMPermissionModel();
		cRMPermissionModel.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
		Action<EntityPermissionRoleTypeSelectorModel> obj = delegate(EntityPermissionRoleTypeSelectorModel m)
		{
			m.Routes = new RouteValueDictionary(new
			{
				action = "PermissionSettings",
				controller = "Lead",
				area = "EleWise.ELMA.CRM.Web"
			});
		};
		cRMPermissionModel.Id = instance.Id;
		Dictionary<Guid, Guid> participantWorkOne = new Dictionary<Guid, Guid>();
		Dictionary<Guid, Guid> InformsOne = new Dictionary<Guid, Guid>();
		cRMPermissionModel.AdditionalPermissionsModel = base.PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(instance, InterfaceActivator.TypeOf<ILead>(), ((Controller)this).get_Url(), delegate(IInstanceSettingsPermissionHolder h)
		{
			if (!(h is ILeadPersonPermission) || ((ILeadPersonPermission)h).Lead != instance || ((ILeadPersonPermission)h).InheritedFromNumber.HasValue)
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
		cRMPermissionModel.AdditionalPermissionsModel.BindModelName = "additionalPermissions";
		if (cRMPermissionModel.LockEditPermission)
		{
			cRMPermissionModel.AdditionalPermissionsModel.Edit = false;
		}
		cRMPermissionModel.AdditionalPermissionsModel.NoForm = false;
		obj(cRMPermissionModel.AdditionalPermissionsModel);
		cRMPermissionModel.InheritAvailable = inheritAvailable;
		cRMPermissionModel.InheritPermissions = instance.InheritPermissions;
		participantWorkOne = new Dictionary<Guid, Guid>();
		InformsOne = new Dictionary<Guid, Guid>();
		cRMPermissionModel.InheritPermissionsModel = base.PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(instance, InterfaceActivator.TypeOf<ILead>(), ((Controller)this).get_Url(), delegate(IInstanceSettingsPermissionHolder h)
		{
			if (!(h is ILeadPersonPermission) || ((ILeadPersonPermission)h).Lead != instance || !((ILeadPersonPermission)h).InheritedFromNumber.HasValue)
			{
				return false;
			}
			if (h.TypeRoleId == CommonRoleTypes.ParticipantWork.Id)
			{
				if (participantWorkOne.ContainsKey(h.PermissionId))
				{
					return false;
				}
				participantWorkOne.Add(h.PermissionId, h.PermissionId);
			}
			if (h.TypeRoleId == CommonRoleTypes.Informs.Id)
			{
				if (InformsOne.ContainsKey(h.PermissionId))
				{
					return false;
				}
				InformsOne.Add(h.PermissionId, h.PermissionId);
			}
			return true;
		});
		cRMPermissionModel.InheritPermissionsModel.BindModelName = "InheritPermissions";
		cRMPermissionModel.InheritPermissionsModel.Instance = instance;
		cRMPermissionModel.InheritPermissionsModel.Edit = false;
		return (ActionResult)(object)((Controller)this).PartialView("Lead/LeadPermissionSetting", (object)cRMPermissionModel);
	}

	[HttpPost]
	public ActionResult EnableInheritPermission(ILead instance, bool enable)
	{
		LeadManager.Instance.EnableInheritPermissions(instance, enable);
		return SelectPermission(instance);
	}

	public ActionResult GetPermissionSettings(ILead instance)
	{
		return PermissionSettings(instance);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult PermissionSettings(long id, EditableListModel additionalPermissions)
	{
		ILead instance = LeadManager.Instance.Load(id);
		if (ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { instance.Id });
		}
		EleWise.ELMA.Security.Models.IUser systemUser = UserManager.Instance.Load(SecurityConstants.SystemUserUid);
		if (additionalPermissions != null)
		{
			base.PermissionsModelService.BindPermissionsFromModel(instance, additionalPermissions, delegate(ICollection<IInstanceSettingsPermissionHolder> holders, IEnumerable<IInstanceSettingsPermissionHolder> newHolders)
			{
				List<IInstanceSettingsPermissionHolder> list = newHolders.Where((IInstanceSettingsPermissionHolder e) => e.TypeRoleId != CommonRoleTypes.ParticipantWork.Id && e.TypeRoleId != CommonRoleTypes.Informs.Id).ToList();
				foreach (IInstanceSettingsPermissionHolder item3 in newHolders.Where((IInstanceSettingsPermissionHolder e) => e.TypeRoleId == CommonRoleTypes.ParticipantWork.Id))
				{
					if (item3 != null && instance.ParticipantWork != null)
					{
						list.Add(new InstanceSettingsPermissionHolder
						{
							Assigned = systemUser,
							PermissionId = item3.PermissionId,
							Target = item3.Target,
							TypeRoleId = item3.TypeRoleId
						});
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
				if (instance.InheritPermissions)
				{
					list2.AddRange(holders.Where((IInstanceSettingsPermissionHolder h) => ((ILeadPersonPermission)h).InheritedFromNumber.HasValue));
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
				if (instance.InheritPermissions)
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

	public ActionResult PermissionSettings(ILead instance)
	{
		return SelectPermission(instance);
	}
}
