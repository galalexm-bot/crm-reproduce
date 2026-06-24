using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.CRM.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class CategoryAssignMethodManager : EntityManager<ICategoryAssignMethod, long>
{
	public new static CategoryAssignMethodManager Instance => Locator.GetServiceNotNull<CategoryAssignMethodManager>();

	public bool IsAutoAssigned(ICategory category, IEntity<long> entity)
	{
		ICollection<ICategoryAssignMethod> categoryAssignMethod = GetCategoryAssignMethod(category, entity);
		if (categoryAssignMethod != null && categoryAssignMethod.Count() != 0)
		{
			return categoryAssignMethod.First().AutoAssign;
		}
		return false;
	}

	public void SetAutoAssign(ICategory category, IEntity<long> entity, bool autoAssign)
	{
		ICollection<ICategoryAssignMethod> categoryAssignMethod = GetCategoryAssignMethod(category, entity);
		if (categoryAssignMethod != null && categoryAssignMethod.Count() > 0)
		{
			ICategoryAssignMethod categoryAssignMethod2 = categoryAssignMethod.First();
			categoryAssignMethod2.AutoAssign = autoAssign;
			categoryAssignMethod2.Save();
		}
		else
		{
			CreateNewCategoryAssignMethod(category, entity, autoAssign);
		}
	}

	public ICollection<ICategoryAssignMethod> GetAutoAssignedCategories(IEntity<long> entity)
	{
		ICategoryAssignMethodFilter categoryAssignMethodFilter = InterfaceActivator.Create<ICategoryAssignMethodFilter>();
		categoryAssignMethodFilter.EntityId = entity.Id;
		categoryAssignMethodFilter.TypeUid = InterfaceActivator.UID(entity.GetType());
		categoryAssignMethodFilter.AutoAssign = true;
		return Find(categoryAssignMethodFilter, FetchOptions.All);
	}

	public void Delete(IEntity<long> entity, ICategory category)
	{
		List<ICategoryAssignMethod> list = GetCategoryAssignMethod(category, entity).ToList();
		if (list != null)
		{
			for (int i = 0; i < list.Count; i++)
			{
				list[i].Delete();
			}
		}
	}

	private void CreateNewCategoryAssignMethod(ICategory category, IEntity<long> entity, bool autoAssign)
	{
		ICategoryAssignMethod categoryAssignMethod = InterfaceActivator.Create<ICategoryAssignMethod>();
		categoryAssignMethod.EntityId = entity.Id;
		categoryAssignMethod.Category = category;
		categoryAssignMethod.AutoAssign = autoAssign;
		categoryAssignMethod.TypeUid = InterfaceActivator.UID(entity.GetType());
		categoryAssignMethod.Save();
	}

	private ICollection<ICategoryAssignMethod> GetCategoryAssignMethod(ICategory category, IEntity<long> entity)
	{
		ICategoryAssignMethodFilter categoryAssignMethodFilter = InterfaceActivator.Create<ICategoryAssignMethodFilter>();
		categoryAssignMethodFilter.EntityId = entity.Id;
		categoryAssignMethodFilter.Category = category;
		categoryAssignMethodFilter.TypeUid = InterfaceActivator.UID(entity.GetType());
		return Find(categoryAssignMethodFilter, FetchOptions.All);
	}

	public virtual SaveWithCategoryRulesResult SaveWithCategoryRules(IEntity<long> entity, ISet<ICategory> categories, CategoryRuleType categoryRuleType, RuleDeletedCategoryAction ruleDeletedCategoryAction)
	{
		entity.Save();
		base.Session.Flush();
		ICollection<ICategoryRule> source = EntityManager<ICategoryRule>.Instance.Find((ICategoryRule r) => (int)r.Type == (int)categoryRuleType);
		List<ICategoryAssignMethod> list = GetAutoAssignedCategories(entity).ToList();
		List<ICategoryAssignMethod> list2 = list.Where((ICategoryAssignMethod m) => m.Category == null || !((ICollection<ICategory>)categories).Contains(m.Category)).ToList();
		list.RemoveAll(list2.Contains);
		list2.ForEach(delegate(ICategoryAssignMethod m)
		{
			m.Delete();
		});
		List<ICategory> rulesCategories = source.Where((ICategoryRule rule) => CheckRule(rule, entity)).SelectMany((ICategoryRule rule) => (IEnumerable<ICategory>)rule.Categories).ToList();
		List<ICategory> list3 = rulesCategories.Where((ICategory c) => !((ICollection<ICategory>)categories).Contains(c)).Distinct().ToList();
		List<ICategoryAssignMethod> list4 = ((ruleDeletedCategoryAction == RuleDeletedCategoryAction.Keep) ? new List<ICategoryAssignMethod>() : list.Where((ICategoryAssignMethod m) => m.AutoAssign && !rulesCategories.Contains(m.Category)).ToList());
		if (ruleDeletedCategoryAction != 0 || list4.Count == 0)
		{
			list3.ForEach(delegate(ICategory c)
			{
				categories.Add(c);
				SetAutoAssign(c, entity, autoAssign: true);
			});
			list4.ForEach(delegate(ICategoryAssignMethod m)
			{
				((ICollection<ICategory>)categories).Remove(m.Category);
				m.Delete();
			});
			base.SecurityService.RunWithElevatedPrivilegies(delegate
			{
				entity.Save();
			});
		}
		return new SaveWithCategoryRulesResult
		{
			AddedCategories = list3,
			DeletedCategories = list4.Select((ICategoryAssignMethod m) => m.Category).ToList()
		};
	}

	private static bool CheckRule(ICategoryRule rule, IEntity<long> entity)
	{
		if (rule == null || rule.Filter == null || entity == null)
		{
			return false;
		}
		IEntityFilter entityFilter = UniversalFilterSaver.UnPack(rule.Filter);
		if (entityFilter == null)
		{
			return false;
		}
		Type type = AttributeHelper<FilterForAttribute>.GetAttribute(entityFilter.GetType(), inherited: false)?.EntityType;
		Type type2 = entity.GetType();
		entityFilter.Id = entity.Id;
		entityFilter.DisableSecurity = true;
		entity.Save();
		IEntityManager entityManagerOrNull = ModelHelper.GetEntityManagerOrNull(type2);
		if (entityManagerOrNull != null && type != null && (type2 == type || type2.IsSubclassOf(type)))
		{
			return entityManagerOrNull.Count(entityFilter) == 1;
		}
		return false;
	}
}
