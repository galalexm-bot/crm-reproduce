using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using NHibernate;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers;

public class CategoryRuleController : FilterTreeBaseController<ICategoryRule, long>
{
	protected override bool EnableEqlQuery => true;

	public ActionResult Index()
	{
		((Controller)(object)this).SetCurrentMenuItem("crm-admin-menu");
		CategoryRulesIndexModel categoryRulesIndexModel = new CategoryRulesIndexModel();
		categoryRulesIndexModel.RulesForLeads = CreateCategoryRulesListModel(null, SR.T("Правила для возможностей"), CategoryRuleType.RuleForLeads);
		categoryRulesIndexModel.RulesForContractors = CreateCategoryRulesListModel(null, SR.T("Правила для контрагентов"), CategoryRuleType.RuleForContractor);
		return (ActionResult)(object)((Controller)this).View((object)categoryRulesIndexModel);
	}

	public ActionResult Add(long typeId)
	{
		((Controller)(object)this).SetCurrentMenuItem("crm-admin-menu");
		ICategoryRule categoryRule = InterfaceActivator.Create<ICategoryRule>();
		categoryRule.Type = (CategoryRuleType)typeId;
		FilterModel dataFilter = CreateFilterModel(categoryRule);
		CategoryRuleEditModel categoryRuleEditModel = new CategoryRuleEditModel
		{
			CategoryRule = categoryRule,
			DataFilter = dataFilter
		};
		return (ActionResult)(object)((Controller)this).View("EditForm", (object)categoryRuleEditModel);
	}

	[HttpPost]
	public ActionResult Save(CategoryRuleEditModel model)
	{
		IEntityManager entityManager = ModelHelper.GetEntityManager(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(MetadataLoader.GetEntityMetadataByFilter(model.DataFilter.Filter.GetType()).Uid));
		if (entityManager == null)
		{
			throw new ArgumentNullException("manager");
		}
		model.CategoryRule.Filter = UniversalFilterSaver.Pack(model.DataFilter.Filter);
		if (EnableEqlQuery)
		{
			IEntityFilter filter = model.DataFilter.Filter;
			try
			{
				entityManager.CheckFilter(filter);
				model.CategoryRule.Save();
				return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
			}
			catch (NullReferenceException)
			{
				base.Notifier.Error(SR.T("Неправильно составлен запрос"));
			}
			catch (ADOException)
			{
				base.Notifier.Error(SR.T("Неправильно составлен запрос"));
			}
			catch (Exception exception)
			{
				FormNotifierExtensions.Error(base.Notifier, exception);
			}
			FilterModel dataFilter = CreateFilterModel(model.CategoryRule);
			CategoryRuleEditModel categoryRuleEditModel = new CategoryRuleEditModel
			{
				CategoryRule = model.CategoryRule,
				DataFilter = dataFilter
			};
			return (ActionResult)(object)((Controller)this).View("EditForm", (object)categoryRuleEditModel);
		}
		model.CategoryRule.Save();
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}

	public ActionResult Edit(ICategoryRule categoryRule)
	{
		((Controller)(object)this).SetCurrentMenuItem("crm-admin-menu");
		if (categoryRule == null)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
		}
		FilterModel dataFilter = CreateFilterModel(categoryRule);
		CategoryRuleEditModel categoryRuleEditModel = new CategoryRuleEditModel
		{
			CategoryRule = categoryRule,
			DataFilter = dataFilter
		};
		return (ActionResult)(object)((Controller)this).View("EditForm", (object)categoryRuleEditModel);
	}

	public ActionResult Delete(ICategoryRule categoryRule)
	{
		if (categoryRule == null)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
		}
		CategoryRuleType type = categoryRule.Type;
		categoryRule.Delete();
		CategoryRulesListModel categoryRulesListModel = CreateCategoryRulesListModel(null, string.Empty, type);
		return (ActionResult)(object)((Controller)this).PartialView("CategoryRulesListGrid", (object)categoryRulesListModel);
	}

	[CustomGridAction]
	public ActionResult RefreshGrid(GridCommand command, CategoryRuleType categoryRuleType)
	{
		CategoryRulesListModel categoryRulesListModel = CreateCategoryRulesListModel(command, string.Empty, categoryRuleType);
		return (ActionResult)(object)((Controller)this).PartialView("CategoryRulesListGrid", (object)categoryRulesListModel);
	}

	private FilterModel CreateFilterModel(ICategoryRule categoryRule)
	{
		IFilter filter = InterfaceActivator.Create<IFilter>();
		return categoryRule.Type switch
		{
			CategoryRuleType.RuleForContractor => CreateContractorFilterModel(filter, categoryRule), 
			CategoryRuleType.RuleForLeads => CreateFilterModel<ILead>(filter, categoryRule), 
			_ => throw new ArgumentException(SR.T("Неизвестный тип правила добавления категории: {0}", Enum.GetName(typeof(CategoryRuleType), categoryRule.Type))), 
		};
	}

	private FilterModel CreateContractorFilterModel(IFilter filter, ICategoryRule categoryRule)
	{
		if (categoryRule.Filter == null || !(categoryRule.Filter is SerializableFilter))
		{
			return CreateFilterModel<IContractor>(filter, categoryRule);
		}
		Type entityType = AttributeHelper<FilterForAttribute>.GetAttribute(ReflectionType.GetType((categoryRule.Filter as SerializableFilter).FilterType), inherited: false).EntityType;
		Guid? typeUid = InterfaceActivator.UID(entityType);
		return CreateFilterModel<IContractor>(filter, categoryRule, typeUid);
	}

	private FilterModel CreateFilterModel<T>(IFilter filter, ICategoryRule categoryRule, Guid? typeUid = null)
	{
		Guid guid = InterfaceActivator.UID<T>();
		FilterModel filterModel = new FilterModel(filter, guid, typeUid, guid, "Filter", null, null, EnableEqlQuery);
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(MetadataLoader.GetFilterType(guid));
		Guid categoriesUid = (from prop in classMetadata.Properties
			where prop.Name == "Categories"
			select prop.Uid).FirstOrDefault();
		((List<SearchFieldsData>)filterModel.Entity.SearchFields).RemoveAll((SearchFieldsData sf) => sf.PropertyUid == categoriesUid);
		if (categoryRule.Filter != null)
		{
			IEntityFilter entityFilter2 = (filterModel.Filter = UniversalFilterSaver.UnPack(categoryRule.Filter));
		}
		return filterModel;
	}

	private CategoryRulesListModel CreateCategoryRulesListModel(GridCommand command, string header, CategoryRuleType categoryRuleType)
	{
		CategoryRulesListModel obj = new CategoryRulesListModel
		{
			Header = header
		};
		ICategoryRuleFilter categoryRuleFilter = InterfaceActivator.Create<ICategoryRuleFilter>();
		categoryRuleFilter.Type = categoryRuleType;
		obj.Rules = base.Manager.CreateGridData(command, categoryRuleFilter);
		obj.GridId = Enum.GetName(typeof(CategoryRuleType), categoryRuleType) + "Grid";
		obj.TypeId = (long)categoryRuleType;
		return obj;
	}
}
