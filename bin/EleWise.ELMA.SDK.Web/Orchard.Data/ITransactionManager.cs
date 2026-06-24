using System.Data;
using NHibernate;

namespace Orchard.Data;

public interface ITransactionManager : IDependency
{
	void Demand();

	void RequireNew();

	void RequireNew(IsolationLevel level);

	void Cancel();

	ISession GetSession();
}
