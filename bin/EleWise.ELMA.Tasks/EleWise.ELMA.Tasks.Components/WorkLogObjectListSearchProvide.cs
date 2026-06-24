using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.ExtensionPoints;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Tasks.Components;

public class WorkLogObjectListSearchProvider : WorkLogSearchProviderBase
{
	private readonly FetchOptions fetchOptions;

	public WorkLogObjectListSearchProvider(FetchOptions fetchOptions)
	{
		this.fetchOptions = fetchOptions;
	}

	public override string WorkLogItemSearchPreAppendPartQuery(string query, string idAlias, Guid objectTypeUid)
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		int length = query.IndexOf(" from", StringComparison.CurrentCultureIgnoreCase);
		string text = query.Substring(0, length);
		length = text.IndexOf(" as ", StringComparison.CurrentCultureIgnoreCase);
		text = text.Substring(length + 4);
		return string.Format("SELECT {0} AS {1}, {2} AS {3} FROM ({4}) {5}", serviceNotNull.Dialect.QuoteIfNeeded(text), serviceNotNull.Dialect.Quote("ObjectId"), serviceNotNull.Dialect.QuoteString(objectTypeUid.ToString().Trim("{}".ToCharArray())), serviceNotNull.Dialect.Quote("ObjectUid"), query, serviceNotNull.Dialect.QuoteIfNeeded("tParty_LoadObject"));
	}

	public override string AfterCreateQuery(string query)
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		return string.Format("SELECT {0}, {1} FROM ({2}) {3}", serviceNotNull.Dialect.Quote("ObjectId"), serviceNotNull.Dialect.Quote("ObjectUid"), serviceNotNull.SetupFetchOptions(string.Format(" {0}, {1} FROM ({2}) {3} WHERE 1=1", serviceNotNull.Dialect.Quote("ObjectId"), serviceNotNull.Dialect.Quote("ObjectUid"), query, serviceNotNull.Dialect.QuoteIfNeeded("tPaging_LoadObject")), fetchOptions), serviceNotNull.Dialect.QuoteIfNeeded("tResult_LoadObject"));
	}

	public override ICriteria TransformPartCriteria(ISession session, ICriteria criteria, Guid baseObjectTypeUid, List<Guid> objectTypeUids, IWorkLogObjectSearchFilter filter)
	{
		criteria.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Id() });
		WorkLogSearchProviderBase.SetupFastSearchFilter(session, criteria, filter.SearchString, baseObjectTypeUid);
		return criteria;
	}
}
