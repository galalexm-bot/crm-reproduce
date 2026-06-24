using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Extensions;
using EleWise.ELMA.Tasks.Models;
using NHibernate.Criterion;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

public abstract class ReplacementTaskObjectsPropertyFilterBase<T> : IReplacementTaskRemapObjectsFilterExtension where T : IEntity
{
	private Guid? propertyUid;

	protected abstract Expression<Func<T, object>> UserProperty { get; }

	private Guid PropertyUid
	{
		get
		{
			if (!propertyUid.HasValue)
			{
				propertyUid = InterfaceActivator.PropertyUid(UserProperty, inherit: true);
			}
			return propertyUid.Value;
		}
	}

	public ICriterion CreatePropertyCriteria(ClassMetadata rootMetadata, PropertyMetadata property, IReplacementTask replacementTask)
	{
		if (property == null || property.Uid != PropertyUid)
		{
			return null;
		}
		IEntity replacementObject = replacementTask.GetReplacementObject();
		if (replacementObject == null)
		{
			return null;
		}
		return CreatePropertyCriteria(replacementObject);
	}

	protected virtual ICriterion CreatePropertyCriteria(IEntity replacementObject)
	{
		return null;
	}

	protected virtual IEnumerable<Expression<Func<T, object>>> GetProjections()
	{
		yield break;
	}

	public bool IsPropertyReadOnly(IEntity replacementObject, PropertyMetadata property, IEntity entity)
	{
		if (property == null || property.Uid != PropertyUid || !(entity is T))
		{
			return false;
		}
		return IsReadOnly(replacementObject, (T)entity);
	}

	public IEnumerable<Pair<ClassMetadata, PropertyMetadata>> GetProjections(ClassMetadata rootMetadata, IReplacementTask replacementTask)
	{
		Type type = InterfaceActivator.TypeOf<T>();
		if (!type.IsInheritOrSame(MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(rootMetadata.Uid)))
		{
			return Enumerable.Empty<Pair<ClassMetadata, PropertyMetadata>>();
		}
		return from p in GetProjections().Select(delegate(Expression<Func<T, object>> p)
			{
				PropertyMetadata propertyMetadata = InterfaceActivator.LoadPropertyMetadata(p);
				return (propertyMetadata == null) ? null : new Pair<ClassMetadata, PropertyMetadata>(MetadataLoader.LoadMetadata(type) as ClassMetadata, propertyMetadata);
			})
			where p != null
			select p;
	}

	protected virtual bool IsReadOnly(IEntity replacementObject, T entity)
	{
		return false;
	}

	public bool ReplaceProperty(IEntity entity, PropertyMetadata property, IUser newUser)
	{
		if (property == null || property.Uid != PropertyUid || !(entity is T))
		{
			return false;
		}
		return ReplaceProperty((T)entity, newUser);
	}

	protected virtual bool ReplaceProperty(T entity, IUser newUser)
	{
		return false;
	}

	public virtual bool CanUseForReplacementTaskType(IReplacementTask replacementTask)
	{
		return replacementTask.IsReplacementTask();
	}
}
