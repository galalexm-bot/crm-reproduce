using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Extensions.MSSQL;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using NHibernate;

namespace EleWise.ELMA.Messages.Db.MsSql.Components.Feed;

[Component]
internal class FeedMsSqlIndexes : IFeedIndexesExtension
{
	public bool IsSupport(Guid uidProvider)
	{
		return new Guid(MSSQLTransformationProvider.UidString) == uidProvider;
	}

	public void Enable()
	{
		ISessionProvider serviceNotNull = Locator.GetServiceNotNull<ISessionProvider>();
		ISession session = serviceNotNull.GetSession("");
		session.ExecuteWithTimeout(0, delegate
		{
			((IQuery)session.CreateSQLQuery("ALTER INDEX All ON Feed REBUILD")).ExecuteUpdate();
		});
	}

	public void Disable()
	{
		ISessionProvider serviceNotNull = Locator.GetServiceNotNull<ISessionProvider>();
		ISession session = serviceNotNull.GetSession("");
		session.ExecuteWithTimeout(0, delegate
		{
			((IQuery)session.CreateSQLQuery("ALTER INDEX ALL ON Feed DISABLE")).ExecuteUpdate();
		});
		session.ExecuteWithTimeout(0, delegate
		{
			((IQuery)session.CreateSQLQuery("ALTER INDEX IX_Feed_Id ON Feed REBUILD")).ExecuteUpdate();
		});
	}
}
