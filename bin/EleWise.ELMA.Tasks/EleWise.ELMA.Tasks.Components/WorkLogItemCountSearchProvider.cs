using System;
using System.Collections.Generic;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.ExtensionPoints;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Tasks.Components;

public class WorkLogItemCountSearchProvider : WorkLogItemSearchProvider
{
	public override ICriteria TransformPartCriteria(ISession session, ICriteria criteria, Guid baseObjectTypeUid, List<Guid> objectTypeUids, IWorkLogObjectSearchFilter filter)
	{
		ICriteria obj = base.TransformPartCriteria(session, criteria, baseObjectTypeUid, objectTypeUids, filter);
		obj.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false), (ICriterion)(object)Restrictions.IsNull("IsDeleted")));
		return obj;
	}

	public override string WorkLogItemSearchPreAppendPartQuery(string query, string idAlias, Guid objectTypeUid)
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		return string.Format("SELECT * FROM ({0}) {1}", query, serviceNotNull.Dialect.QuoteIfNeeded("tCount_LoadObject"));
	}

	public override string AfterCreateQuery(string query)
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		return string.Format("SELECT COUNT(*) AS {0} FROM ({1}) {2}", serviceNotNull.Dialect.Quote("RowsCount"), query, serviceNotNull.Dialect.QuoteIfNeeded("tCount_LoadObject"));
	}
}
