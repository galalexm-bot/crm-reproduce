using System;
using System.Data;
using EleWise.ELMA.Runtime.NH;
using NHibernate;
using Orchard;
using Orchard.Data;

namespace EleWise.ELMA.Web.Orchard.Data;

public class SessionFlushTM : ITransactionManager, IDependency, IDisposable
{
	private readonly ISessionProvider _sessionProvider;

	public SessionFlushTM(ISessionProvider sessionProvider)
	{
		_sessionProvider = sessionProvider;
	}

	void ITransactionManager.Demand()
	{
	}

	void ITransactionManager.Cancel()
	{
	}

	void IDisposable.Dispose()
	{
	}

	public void RequireNew()
	{
	}

	public void RequireNew(IsolationLevel level)
	{
	}

	public ISession GetSession()
	{
		return _sessionProvider.GetSession("");
	}
}
