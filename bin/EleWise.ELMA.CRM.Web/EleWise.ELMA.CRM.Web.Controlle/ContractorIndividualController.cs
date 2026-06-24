using System;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.ExtensionPoints;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Attributes;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.CRM.Web.Controllers;

[Permission("{46401803-1B46-4E60-8DA0-227FF8CF60F3}")]
[RouteArea("EleWise.ELMA.CRM.Web")]
public class ContractorIndividualController : BPMController<IContractorIndividual, long>
{
	private ICountry defaultCountry = Locator.GetService<CrmSettingsModule>().Settings.DefaultCountry;

	public IUnionComplexCacheService ComplexCacheService { get; set; }

	[NotNull]
	public IEntityActionHandler EntityActionHandler { get; set; }

	[ContractorCreate]
	[Permission("FED901DB-3E4A-4BF0-B3DD-5BD1CC0D7255", typeof(IContractorIndividual))]
	[ContentItem(Name = "SR.M('Создание физического лица')", Image24 = "#add.svg")]
	public ActionResult Create()
	{
		ContractorIndividualModel contractorIndividualModel = new ContractorIndividualModel();
		contractorIndividualModel.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
		if (contractorIndividualModel.LockEditPermission)
		{
			base.Notifier.Error(SR.T("Производится перерасчет разрешений. Изменение заблокировано. Пожалуйста попробуйте позже."));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Contractor", (object)new
			{
				area = "EleWise.ELMA.CRM.Web"
			});
		}
		InitNewModel(contractorIndividualModel);
		return (ActionResult)(object)((Controller)this).View((object)contractorIndividualModel);
	}

	[EntityForm("Create", "EleWise.ELMA.CRM.Web")]
	[Permission("FED901DB-3E4A-4BF0-B3DD-5BD1CC0D7255", typeof(IContractorIndividual))]
	public ActionResult CreatePopup([ParameterContainer] IContractorIndividual contractor, Guid? formUid = null, ViewType? viewType = null, bool formReadOnly = false, string parentFormId = "", string formId = "")
	{
		ContractorIndividualModel contractorIndividualModel = new ContractorIndividualModel(contractor, (!viewType.HasValue) ? ViewType.Create : viewType.Value)
		{
			FormUid = formUid,
			FormReadOnly = formReadOnly,
			FormId = formId
		};
		contractorIndividualModel.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
		InitNewModel(contractorIndividualModel, contractor == null);
		contractorIndividualModel.DynamicFormSettings.ParentFormId = parentFormId;
		DynamicFormSettings dynamicFormSettings = contractorIndividualModel.DynamicFormSettings;
		dynamicFormSettings.ViewItemId = dynamicFormSettings.ViewItemId + ";" + contractorIndividualModel.View.Uid;
		return (ActionResult)(object)((Controller)this).PartialView("ContractorIndividual/ContractorIndividualEditForm", (object)contractorIndividualModel);
	}

	[HttpPost]
	[Permission("FED901DB-3E4A-4BF0-B3DD-5BD1CC0D7255", typeof(IContractorIndividual))]
	[TransactionAction]
	public ActionResult Create(ContractorIndividualModel model)
	{
		model.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
		if (model.LockEditPermission)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { model.Entity.Id });
		}
		if (!model.Entity.IsNew())
		{
			EntityActionHandler.ActionExecuted(new EntityActionEventArgs(null, model.Entity, "c7b89bfd-dc8f-440d-82a9-da1ee469afd9"));
		}
		SaveWithCategoryRulesResult saveWithCategoryRulesResult = model.SaveWithCategoryRules();
		string text = null;
		if (saveWithCategoryRulesResult.AddedCategories.Count > 0)
		{
			text = (IsCreatorRequest() ? "" : SR.T("Физическое лицо <a href=\"{1}\">{0}</a> сохранено успешно", model.Entity.Name.HtmlEncode(), ((Controller)this).get_Url().Entity(model.Entity)));
			if (saveWithCategoryRulesResult.AddedCategories.Count > 0)
			{
				if (!IsCreatorRequest())
				{
					text += "<br/>";
					text += SR.T("Автоматически добавлены категории: {0}", saveWithCategoryRulesResult.AddedCategories.Select((ICategory c) => c.Name).ToSeparatedString(", ")).HtmlEncode();
				}
				else
				{
					text = SR.T("Физическому лицу {0} автоматически добавлены категории: {1}", model.Entity.Name.HtmlEncode(), saveWithCategoryRulesResult.AddedCategories.Select((ICategory c) => c.Name).ToSeparatedString(", ").HtmlEncode());
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
	public ActionResult Details(long id, int? tabIndex = null)
	{
		try
		{
			if (tabIndex.HasValue && DirectoryMapVirtualPathProvider.AnyConfigFile("~/Modules/EleWise.ELMA.CRM.Web/Views/ContractorIndividual/TabView.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Shared/Contractor/TasksTab.cshtml"))
			{
				((ControllerBase)this).get_ViewData().set_Item("SelectedTab", (object)tabIndex.Value);
			}
			IContractorIndividual contractorIndividual = base.Manager.Load(id);
			ThrowExceptionIfDeleted(contractorIndividual);
			ContractorIndividualModel contractorIndividualModel = new ContractorIndividualModel(contractorIndividual, ViewType.Display);
			contractorIndividualModel.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
			return (ActionResult)(object)((Controller)this).View((object)contractorIndividualModel);
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
		ContractorIndividualModel contractorIndividualModel = new ContractorIndividualModel(base.Manager.LoadOrCreate(id), viewType);
		contractorIndividualModel.FormUid = formUid;
		contractorIndividualModel.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
		return AsyncViewItemView(contractorIndividualModel.View, viewType, viewItemUid, contractorIndividualModel, (ContractorIndividualModel m) => m.Entity);
	}

	public ActionResult Edit(long id)
	{
		try
		{
			IContractorIndividual contractorIndividual = base.Manager.Load(id);
			ThrowExceptionIfDeleted(contractorIndividual);
			if (!base.SecurityService.HasPermission(CRMPermissionProvider.EditContractorPermission, contractorIndividual))
			{
				throw new SecurityException(SR.T("Недостаточно прав для редактирования контрагента \"{0}\" с идентификатором {1}", contractorIndividual.Name, contractorIndividual.Id));
			}
			ContractorIndividualModel contractorIndividualModel = new ContractorIndividualModel(contractorIndividual, ViewType.Edit);
			contractorIndividualModel.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
			if (contractorIndividualModel.LockEditPermission)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { id });
			}
			return (ActionResult)(object)((Controller)this).View((object)contractorIndividualModel);
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Contractor");
		}
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult Edit(ContractorIndividualModel model)
	{
		try
		{
			model.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
			if (model.LockEditPermission)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { model.Entity.Id });
			}
			SaveWithCategoryRulesResult saveWithCategoryRulesResult = model.SaveWithCategoryRules((model.UnassignOldCategories == true) ? RuleDeletedCategoryAction.Delete : ((model.UnassignOldCategories == false) ? RuleDeletedCategoryAction.Keep : RuleDeletedCategoryAction.Revert));
			if (!model.UnassignOldCategories.HasValue && saveWithCategoryRulesResult.DeletedCategories.Count > 0)
			{
				base.UnitOfWorkManager.RollbackCurrent("");
				model.CategoriesToDelete = saveWithCategoryRulesResult.DeletedCategories;
				return (ActionResult)(object)((Controller)this).View((object)model);
			}
			EntityActionHandler.ActionExecuted(new EntityActionEventArgs(null, model.Entity, "c7b89bfd-dc8f-440d-82a9-da1ee469afd9"));
			if (saveWithCategoryRulesResult.AddedCategories.Count > 0 || saveWithCategoryRulesResult.DeletedCategories.Count > 0)
			{
				string text = SR.T("Физическое лицо <a href=\"{1}\">{0}</a> сохранено успешно", model.Entity.Name.HtmlEncode(), ((Controller)this).get_Url().Entity(model.Entity));
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
			IContractorIndividual contractorIndividual = base.Manager.Load(id);
			base.Manager.Delete(contractorIndividual);
			base.Notifier.Information(SR.T("Физическое лицо \"{0}\" успешно удалено", contractorIndividual.Name));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Contractor", (object)new
			{
				area = "EleWise.ELMA.CRM.Web"
			});
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Contractor", (object)new
			{
				area = "EleWise.ELMA.CRM.Web"
			});
		}
	}

	[HttpGet]
	[Permission("{9219C9AB-7E68-47B1-8939-FF6FC4439DA0}")]
	public ActionResult AddWatch(Guid typeUid, string entityId)
	{
		object entityId2 = ModelHelper.TryConvertEntityId(typeUid, entityId);
		IUser currentUser = GetCurrentUser();
		if (!WatchManager.Instance.IsWatchExsist(typeUid, entityId2, currentUser))
		{
			WatchManager.Instance.CreateWatchByUser(typeUid, entityId2, currentUser);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new
		{
			Id = entityId
		});
	}

	[HttpGet]
	[Permission("{9219C9AB-7E68-47B1-8939-FF6FC4439DA0}")]
	public ActionResult RemoveWatch(Guid typeUid, string entityId)
	{
		object entityId2 = ModelHelper.TryConvertEntityId(typeUid, entityId);
		IUser currentUser = GetCurrentUser();
		WatchManager.Instance.GetWatchByUser(typeUid, currentUser.Id, entityId2).ForEach(delegate(IWatch w)
		{
			w.Delete();
		});
		return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new
		{
			Id = entityId
		});
	}

	protected void InitNewModel(ContractorIndividualModel model)
	{
		InitNewModel(model, contractorWasNull: true);
	}

	private void InitNewModel(ContractorIndividualModel model, bool contractorWasNull)
	{
		if (defaultCountry != null && model.Contractor != null)
		{
			IAddressProvider addressProvider = ComponentManager.Current.GetExtensionPoints<IAddressProvider>().FirstOrDefault((IAddressProvider p) => p.CountryCode == defaultCountry.CountryCode);
			IAddress address = ((addressProvider != null) ? addressProvider.CreateAddress() : EntityManager<IAddress>.Instance.Create());
			address.Country = defaultCountry;
			model.Contractor.LegalAddress = address;
			IAddress address2 = ((addressProvider != null) ? addressProvider.CreateAddress() : EntityManager<IAddress>.Instance.Create());
			address2.Country = defaultCountry;
			model.Contractor.PostalAddress = address2;
		}
		if (contractorWasNull)
		{
			model.Entity.Email.Add(InterfaceActivator.Create<IEmail>());
			model.Entity.Phone.Add(InterfaceActivator.Create<IPhone>());
			model.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
		}
	}
}
