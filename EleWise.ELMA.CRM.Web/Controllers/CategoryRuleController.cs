// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.CategoryRuleController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
    public class CategoryRuleController : FilterTreeBaseController<ICategoryRule, long>
    {
        public ActionResult Index()
        {
            ((Controller)this).SetCurrentMenuItem("crm-admin-menu");
            return View((object)new CategoryRulesIndexModel()
            {
                RulesForLeads = this.CreateCategoryRulesListModel((GridCommand)null, EleWise.ELMA.SR.T("Правила для возможностей"), CategoryRuleType.RuleForLeads),
                RulesForContractors = this.CreateCategoryRulesListModel((GridCommand)null, EleWise.ELMA.SR.T("Правила для контрагентов"), CategoryRuleType.RuleForContractor)
            });
        }

        public ActionResult Add(long typeId)
        {
            ((Controller)this).SetCurrentMenuItem("crm-admin-menu");
            ICategoryRule categoryRule = InterfaceActivator.Create<ICategoryRule>();
            categoryRule.Type = (CategoryRuleType)typeId;
            FilterModel filterModel = this.CreateFilterModel(categoryRule);
            return View("EditForm", (object)new CategoryRuleEditModel()
            {
                CategoryRule = categoryRule,
                DataFilter = filterModel
            });
        }

        [HttpPost]
        public ActionResult Save(CategoryRuleEditModel model)
        {
            IEntityManager entityManager = ModelHelper.GetEntityManager(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(MetadataLoader.GetEntityMetadataByFilter(model.DataFilter.Filter.GetType()).Uid));
            if (entityManager == null)
                throw new ArgumentNullException("manager");
            model.CategoryRule.Filter = UniversalFilterSaver.Pack(model.DataFilter.Filter);
            if (base.EnableEqlQuery)
            {
                IEntityFilter filter = model.DataFilter.Filter;
                try
                {
                    entityManager.CheckFilter(filter);
                    model.CategoryRule.Save();
                    return RedirectToAction("Index");
                }
                catch (NullReferenceException ex)
                {
                    // ISSUE: explicit non-virtual call
                    Notifier.Error(EleWise.ELMA.SR.T("Неправильно составлен запрос"));
                }
                catch (ADOException ex)
                {
                    // ISSUE: explicit non-virtual call
                    Notifier.Error(EleWise.ELMA.SR.T("Неправильно составлен запрос"));
                }
                catch (Exception ex)
                {
                    // ISSUE: explicit non-virtual call
                    Notifier.Error(ex);
                }
                FilterModel filterModel = this.CreateFilterModel(model.CategoryRule);
                return View("EditForm", (object)new CategoryRuleEditModel()
                {
                    CategoryRule = model.CategoryRule,
                    DataFilter = filterModel
                });
            }
            model.CategoryRule.Save();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(ICategoryRule categoryRule)
        {
            ((Controller)this).SetCurrentMenuItem("crm-admin-menu");
            if (categoryRule == null)
                return RedirectToAction("Index");
            FilterModel filterModel = this.CreateFilterModel(categoryRule);
            return View("EditForm", (object)new CategoryRuleEditModel()
            {
                CategoryRule = categoryRule,
                DataFilter = filterModel
            });
        }

        public ActionResult Delete(ICategoryRule categoryRule)
        {
            if (categoryRule == null)
                return RedirectToAction("Index");
            CategoryRuleType type = categoryRule.Type;
            categoryRule.Delete();
            return PartialView("CategoryRulesListGrid", (object)this.CreateCategoryRulesListModel((GridCommand)null, string.Empty, type));
        }

        [CustomGridAction]
        public ActionResult RefreshGrid(GridCommand command, CategoryRuleType categoryRuleType) => PartialView("CategoryRulesListGrid", (object)this.CreateCategoryRulesListModel(command, string.Empty, categoryRuleType));

        private FilterModel CreateFilterModel(ICategoryRule categoryRule)
        {
            EleWise.ELMA.Common.Models.Filters.IFilter filter = InterfaceActivator.Create<EleWise.ELMA.Common.Models.Filters.IFilter>();
            switch (categoryRule.Type)
            {
                case CategoryRuleType.RuleForLeads:
                    return this.CreateFilterModel<ILead>(filter, categoryRule);
                case CategoryRuleType.RuleForContractor:
                    return this.CreateContractorFilterModel(filter, categoryRule);
                default:
                    throw new ArgumentException(EleWise.ELMA.SR.T("Неизвестный тип правила добавления категории: {0}", (object)Enum.GetName(typeof(CategoryRuleType), (object)categoryRule.Type)));
            }
        }

        private FilterModel CreateContractorFilterModel(EleWise.ELMA.Common.Models.Filters.IFilter filter, ICategoryRule categoryRule)
        {
            if (categoryRule.Filter == null || !(categoryRule.Filter is SerializableFilter))
                return this.CreateFilterModel<IContractor>(filter, categoryRule);
            Guid? typeUid = new Guid?(InterfaceActivator.UID(AttributeHelper<FilterForAttribute>.GetAttribute(ReflectionType.GetType((categoryRule.Filter as SerializableFilter).FilterType), false).EntityType));
            return this.CreateFilterModel<IContractor>(filter, categoryRule, typeUid);
        }

        private FilterModel CreateFilterModel<T>(
          EleWise.ELMA.Common.Models.Filters.IFilter filter,
          ICategoryRule categoryRule,
          Guid? typeUid = null)
        {
            Guid uid = InterfaceActivator.UID<T>();
            FilterModel filterModel = new FilterModel((IFilterBase)filter, uid, typeUid, new Guid?(uid), "Filter", (IEntityFilter)null, new Guid?(), base.EnableEqlQuery, (EleWise.ELMA.Web.Mvc.Models.Grids.GridState)null, (string)null, (string)null, (Type)null);
            Guid categoriesUid = ((ClassMetadata)MetadataLoader.LoadMetadata(MetadataLoader.GetFilterType(uid))).Properties.Where<PropertyMetadata>((Func<PropertyMetadata, bool>)(prop => prop.Name == "Categories")).Select<PropertyMetadata, Guid>((Func<PropertyMetadata, Guid>)(prop => prop.Uid)).FirstOrDefault<Guid>();
            ((List<SearchFieldsData>)((EntityModel<IFilterBase>)filterModel).Entity.SearchFields).RemoveAll((Predicate<SearchFieldsData>)(sf => sf.PropertyUid == categoriesUid));
            if (categoryRule.Filter != null)
            {
                IEntityFilter entityFilter = UniversalFilterSaver.UnPack(categoryRule.Filter);
                filterModel.Filter = entityFilter;
            }
            return filterModel;
        }

        private CategoryRulesListModel CreateCategoryRulesListModel(
          GridCommand command,
          string header,
          CategoryRuleType categoryRuleType)
        {
            CategoryRulesListModel categoryRulesListModel = new CategoryRulesListModel();
            categoryRulesListModel.Header = header;
            ICategoryRuleFilter filter = InterfaceActivator.Create<ICategoryRuleFilter>();
            filter.Type = new CategoryRuleType?(categoryRuleType);
            // ISSUE: explicit non-virtual call
            categoryRulesListModel.Rules = (GridData<ICategoryRule>)base.Manager.CreateGridData<ICategoryRule, ICategoryRuleFilter>(command, filter);
            categoryRulesListModel.GridId = Enum.GetName(typeof(CategoryRuleType), (object)categoryRuleType) + "Grid";
            categoryRulesListModel.TypeId = (long)categoryRuleType;
            return categoryRulesListModel;
        }

        protected virtual bool EnableEqlQuery => true;
    }
}
