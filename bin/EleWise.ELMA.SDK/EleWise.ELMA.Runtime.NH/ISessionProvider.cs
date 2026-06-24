using NHibernate;

namespace EleWise.ELMA.Runtime.NH;

public interface ISessionProvider
{
	ISession GetSession(string dbName);

	void EndUnitOfWork(string dbName);

	void CloseSession(string dbName);

	void SetCurrentSession(ISession session, string dbName);
}
