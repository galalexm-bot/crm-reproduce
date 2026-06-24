using System;
using System.Collections.Generic;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.ExtensionPoints;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Tasks.Components;

public class WorkLogCountSearchProvider : WorkLogSearchProviderBase
{
	public override string WorkLogItemSearchPreAppendPartQuery(string query, string idAlias, Guid objectTypeUid)
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		int length = query.IndexOf(" from", StringComparison.CurrentCultureIgnoreCase);
		string text = query.Substring(0, length);
		length = text.IndexOf(" as ", StringComparison.CurrentCultureIgnoreCase);
		text = text.Substring(length + 4);
		return string.Format("SELECT {2} AS {3}, {4} AS {5} FROM ({0}) {1}", query, serviceNotNull.Dialect.QuoteIfNeeded("tCount_LoadObject"), serviceNotNull.Dialect.QuoteIfNeeded(text), serviceNotNull.Dialect.Quote("Id"), serviceNotNull.Dialect.QuoteString(objectTypeUid.ToString().Trim("{}".ToCharArray())), serviceNotNull.Dialect.Quote("ObjectUid"));
	}

	public override string AfterCreateQuery(string query)
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		return string.Format("SELECT COUNT(*) AS {0} FROM ({1}) {2}", serviceNotNull.Dialect.Quote("RowsCount"), query, serviceNotNull.Dialect.QuoteIfNeeded("tCount_LoadObject"));
	}

	public override ICriteria TransformPartCriteria(ISession session, ICriteria criteria, Guid baseObjectTypeUid, List<Guid> objectTypeUids, IWorkLogObjectSearchFilter filter)
	{
		criteria.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property("Id") });
		WorkLogSearchProviderBase.SetupFastSearchFilter(session, criteria, filter.SearchString, baseObjectTypeUid);
		return criteria;
	}
}
