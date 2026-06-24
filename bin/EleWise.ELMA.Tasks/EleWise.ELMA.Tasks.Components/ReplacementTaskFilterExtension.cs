using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Models;
using NHibernate.Criterion;

namespace EleWise.ELMA.Tasks.Components;

[Component]
public class ReplacementTaskFilterExtension : IReplacementTaskRemapObjectsFilterExtension
{
	private Guid taskBaseUid;

	private Guid taskBaseImplUid;

	public ICriterion CreatePropertyCriteria(ClassMetadata rootMetadata, PropertyMetadata property, IReplacementTask replacementTask)
	{
		if (taskBaseUid == Guid.Empty)
		{
			taskBaseUid = InterfaceActivator.UID<ITaskBase>(loadImplementation: false);
		}
		if (taskBaseImplUid == Guid.Empty)
		{
			taskBaseImplUid = InterfaceActivator.UID<ITaskBase>();
		}
		if (rootMetadata.Uid != taskBaseUid && rootMetadata.Uid != taskBaseImplUid)
		{
			return null;
		}
		return (ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq("Id", (object)replacementTask.Id));
	}

	public bool IsPropertyReadOnly(IEntity replacementObject, PropertyMetadata property, IEntity entity)
	{
		return false;
	}

	public IEnumerable<Pair<ClassMetadata, PropertyMetadata>> GetProjections(ClassMetadata rootMetadata, IReplacementTask replacementTask)
	{
		yield break;
	}

	public bool ReplaceProperty(IEntity entity, PropertyMetadata property, IUser newUser)
	{
		return false;
	}

	public bool CanUseForReplacementTaskType(IReplacementTask replacementTask)
	{
		return true;
	}
}
