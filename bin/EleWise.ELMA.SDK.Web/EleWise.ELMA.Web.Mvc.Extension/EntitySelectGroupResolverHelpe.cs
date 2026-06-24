using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.Web.Mvc.Extensions;

public static class EntitySelectGroupResolverHelper
{
	private static IFeatureFlagService featureFlagService;

	private const string SortGroupsWithEntitiesEnabledKey = "SortGroupsWithEntities.Enabled";

	private static IFeatureFlagService FeatureFlagService => featureFlagService ?? (featureFlagService = Locator.GetServiceNotNull<IFeatureFlagService>());

	public static IEnumerable<TItem> EntitySelectGroup<TEntity, TItem>(this IEnumerable<TEntity> items, Func<IEnumerable<TEntity>, IEnumerable<TItem>> orderedConvertFunc, Func<EntitySelectGroup, TItem> createHeaderFunc) where TEntity : IEntity where TItem : class
	{
		return items.EntitySelectGroup(InterfaceActivator.UID<TEntity>(), orderedConvertFunc, createHeaderFunc);
	}

	public static IEnumerable<TItem> EntitySelectGroup<TEntity, TItem>(this IEnumerable<TEntity> items, Guid typeUid, Func<IEnumerable<TEntity>, IEnumerable<TItem>> orderedConvertFunc, Func<EntitySelectGroup, TItem> createHeaderFunc) where TEntity : IEntity where TItem : class
	{
		return items.EntitySelectGroup(typeUid, (IEnumerable<TEntity> list, EntitySelectGroup g) => orderedConvertFunc(list), createHeaderFunc);
	}

	public static IEnumerable<TItem> EntitySelectGroup<TEntity, TItem>(this IEnumerable<TEntity> items, Guid typeUid, Func<IEnumerable<TEntity>, EntitySelectGroup, IEnumerable<TItem>> orderedConvertFunc, Func<EntitySelectGroup, TItem> createHeaderFunc) where TEntity : IEntity where TItem : class
	{
		IEntity[] itemsList = items.Cast<IEntity>().ToArray();
		if (itemsList.Length == 0)
		{
			return Enumerable.Empty<TItem>();
		}
		return GetEntitySelectGroupResult((from g in (from g in (from p in ComponentManager.Current.GetExtensionPoints<IEntitySelectGroupResolver>()
					where p.CheckType(typeUid)
					select p).SelectMany((IEntitySelectGroupResolver gp) => gp.GetGroups(typeUid, itemsList)).Select((EntitySelectGroup g, int i) => new SelectEntityGroupsInnerModel
				{
					Group = g,
					Entities = g.Entities
				})
				where g.Entities.Any()
				select g).TakeWhile(delegate(SelectEntityGroupsInnerModel g)
			{
				if (itemsList.Length == 0)
				{
					return false;
				}
				itemsList = itemsList.Except(g.Entities).ToArray();
				return true;
			})
			orderby !g.Group.ShowOnTop, g.Group.Order
			select g).Select(delegate(SelectEntityGroupsInnerModel g, int i)
		{
			g.ShowHeader = i > 0 || g.Group.ShowHeader;
			return g;
		}), orderedConvertFunc, createHeaderFunc);
	}

	public static bool SortGroupsWithEntitiesEnabled()
	{
		return FeatureFlagService.Enabled("SortGroupsWithEntities.Enabled", defaultEnabled: true);
	}

	private static IEnumerable<TItem> GetEntitySelectGroupResult<TEntity, TItem>(IEnumerable<SelectEntityGroupsInnerModel> groups, Func<IEnumerable<TEntity>, EntitySelectGroup, IEnumerable<TItem>> orderedConvertFunc, Func<EntitySelectGroup, TItem> createHeaderFunc) where TEntity : IEntity where TItem : class
	{
		if (SortGroupsWithEntitiesEnabled() && typeof(TItem) == typeof(SelectEntitiesAndGroupsModel))
		{
			List<TItem> list = new List<TItem>();
			{
				foreach (SelectEntityGroupsInnerModel group in groups)
				{
					bool showHeader = group.ShowHeader && createHeaderFunc != null;
					int num = list.FindIndex(delegate(TItem g)
					{
						SelectEntitiesAndGroupsModel selectEntitiesAndGroupsModel = g as SelectEntitiesAndGroupsModel;
						return (selectEntitiesAndGroupsModel?.IsGroup ?? false) && showHeader && !selectEntitiesAndGroupsModel.Value.IsNullOrWhiteSpace() && selectEntitiesAndGroupsModel.Value.Equals(group.Group.Id);
					});
					if (num >= 0)
					{
						list.RemoveAt(num);
						if (showHeader)
						{
							list.Insert(num, createHeaderFunc(group.Group));
						}
						List<TItem> list2 = orderedConvertFunc(group.Entities.Cast<TEntity>(), group.Group).ToList();
						int num2 = list2.Count();
						int num3 = num + 1;
						for (int i = 0; i < num2; i++)
						{
							list.Insert(num3 + i, list2[i]);
						}
					}
					else
					{
						if (showHeader)
						{
							list.Add(createHeaderFunc(group.Group));
						}
						list.AddRange(orderedConvertFunc(group.Entities.Cast<TEntity>(), group.Group));
					}
				}
				return list;
			}
		}
		return groups.SelectMany(delegate(SelectEntityGroupsInnerModel g)
		{
			bool flag = g.ShowHeader && createHeaderFunc != null;
			return Enumerable.Repeat(flag ? createHeaderFunc(g.Group) : null, flag ? 1 : 0).Concat(orderedConvertFunc(g.Entities.Cast<TEntity>(), g.Group));
		}).ToArray();
	}
}
