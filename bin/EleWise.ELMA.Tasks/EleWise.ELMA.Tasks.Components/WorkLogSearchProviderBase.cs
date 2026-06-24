using System;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Tasks.ExtensionPoints;
using NHibernate;

namespace EleWise.ELMA.Tasks.Components;

public class WorkLogSearchProviderBase
{
	public virtual bool DisibleSearchString => false;

	public virtual void UpdateFilter(IEntityFilter filterEntity)
	{
	}

	public virtual ICriteria TransformPartCriteria(ISession session, ICriteria criteria, Guid baseObjectTypeUid, List<Guid> objectTypeUids, IWorkLogObjectSearchFilter filter)
	{
		return criteria;
	}

	public virtual string WorkLogItemSearchPreAppendPartQuery(string query, string idAlias, Guid objectTypeUid)
	{
		return query;
	}

	public virtual string AfterCreateQuery(string query)
	{
		return query;
	}

	public virtual bool CanPropertyFilter(PropertyInfo propertyInfo)
	{
		return false;
	}

	protected static void SetupFastSearchFilter(ISession session, ICriteria criteria, string searchString, Guid objectTypeUid)
	{
	}
}
