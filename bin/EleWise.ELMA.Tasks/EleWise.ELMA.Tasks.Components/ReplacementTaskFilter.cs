using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Extensions;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;

namespace EleWise.ELMA.Tasks.Components;

[Component(Order = 10)]
public class ReplacementTaskFilter : EntityManagerBehavior
{
	public static IEnumerable<KeyValuePair<PropertyMetadata, ClassMetadata>> GetProperties(EntityMetadata entityMetadata)
	{
		Guid userTypeUid = InterfaceActivator.UID<IUser>(loadImplementation: false);
		return from p in MetadataLoader.GetChildProperties(entityMetadata)
			where p.Key.SubTypeUid == userTypeUid
			where p.Key.Settings is EntityUserSettings
			where ((EntityUserSettings)p.Key.Settings).Replaceable
			select p;
	}

	public static IEnumerable<KeyValuePair<PropertyMetadata, ClassMetadata>> GetProperties(Type entityType)
	{
		if (!(InterfaceActivator.LoadMetadata(entityType) is EntityMetadata entityMetadata))
		{
			return Enumerable.Empty<KeyValuePair<PropertyMetadata, ClassMetadata>>();
		}
		return GetProperties(entityMetadata);
	}

	public static IEnumerable<KeyValuePair<PropertyMetadata, ClassMetadata>> GetProperties<T>() where T : class, IEntity
	{
		return GetProperties(InterfaceActivator.TypeOf<T>());
	}

	internal static void FilterActivate(long replacementTaskId, bool useProjections)
	{
		ContextVars.Set("Replacement_ReplacementTask_Id", replacementTaskId);
		ContextVars.Set("Replacement_ReplacementTask_UseProjections", useProjections);
	}

	internal static void FilterDeactivate()
	{
		ContextVars.Remove("Replacement_ReplacementTask_Id");
		ContextVars.Remove("Replacement_ReplacementTask_UseProjections");
	}

	public override void OnCreateCriteria(ICriteria criteria, IEntityFilter filter)
	{
		ContextVars.TryGetValue<long>("Replacement_ReplacementTask_Id", out var value);
		if (value == 0L)
		{
			return;
		}
		Type rootEntityTypeIfAvailable = criteria.GetRootEntityTypeIfAvailable();
		if (!(rootEntityTypeIfAvailable == InterfaceActivator.TypeOf<IReplacementTask>()))
		{
			IReplacementTask replacementTask = ReplacementTaskManager.Instance.LoadOrNull(value);
			if (replacementTask != null && InterfaceActivator.LoadMetadata(rootEntityTypeIfAvailable) is EntityMetadata rootMetadata && replacementTask.GetReplacementObject() != null)
			{
				ContextVars.TryGetValue<bool>("Replacement_ReplacementTask_UseProjections", out var value2);
				SetupCriteria(criteria, filter, replacementTask, rootMetadata, rootEntityTypeIfAvailable, value2);
			}
		}
	}

	protected virtual void SetupCriteria(ICriteria criteria, IEntityFilter filter, IReplacementTask replacementTask, EntityMetadata rootMetadata, Type criteriaRootType, bool useProjections)
	{
		IEnumerable<KeyValuePair<PropertyMetadata, ClassMetadata>> properties = GetProperties(rootMetadata);
		Disjunction orClause = Restrictions.Disjunction();
		List<IReplacementTaskRemapObjectsFilterExtension> extensions = (from e in ComponentManager.Current.GetExtensionPoints<IReplacementTaskRemapObjectsFilterExtension>()
			where e.CanUseForReplacementTaskType(replacementTask)
			select e).ToList();
		if (useProjections)
		{
			SetupProjections(criteria, rootMetadata, replacementTask, extensions);
		}
		criteria.Add((ICriterion)(object)orClause);
		properties.Each(delegate(KeyValuePair<PropertyMetadata, ClassMetadata> prop)
		{
			Conjunction val = Restrictions.Conjunction();
			bool flag = false;
			foreach (ICriterion item in from ext in extensions
				select ext.CreatePropertyCriteria(prop.Value, prop.Key, replacementTask) into crit
				where crit != null
				select crit)
			{
				flag = true;
				((Junction)val).Add(item);
			}
			SimpleExpression val2 = Restrictions.Eq((IProjection)(object)new CustomPropertyProjection(prop.Key.Name, prop.Value.TypeName, ((EntityMetadata)prop.Value).TableName, prop.Key), (object)replacementTask.GetReplacementUser());
			((Junction)orClause).Add((ICriterion)(flag ? ((object)Restrictions.And((ICriterion)(object)val, (ICriterion)(object)val2)) : ((object)val2)));
		});
	}

	private static void SetupProjections(ICriteria criteria, EntityMetadata rootMetadata, IReplacementTask replacementTask, IEnumerable<IReplacementTaskRemapObjectsFilterExtension> extensions)
	{
		bool flag = false;
		foreach (IReplacementTaskRemapObjectsFilterExtension extension in extensions)
		{
			foreach (Pair<ClassMetadata, PropertyMetadata> item in from p in extension.GetProjections(rootMetadata, replacementTask)
				where p != null
				select p)
			{
				string name = item.Second.Name;
				string fullTypeName = item.First.FullTypeName;
				CustomPropertyProjection projection = new CustomPropertyProjection(name, fullTypeName, ((EntityMetadata)item.First).TableName, item.Second);
				flag = true;
				string alias = string.Format("{0}___{1}", name, fullTypeName.Replace(".", "__"));
				criteria.AddProjection((IProjection)(object)projection, alias);
			}
		}
		if (flag)
		{
			Type rootEntityTypeIfAvailable;
			try
			{
				rootEntityTypeIfAvailable = criteria.GetRootEntityTypeIfAvailable();
			}
			catch
			{
				return;
			}
			criteria.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(rootEntityTypeIfAvailable));
		}
	}
}
