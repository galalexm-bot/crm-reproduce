using System;
using NHibernate;

namespace EleWise.ELMA.Runtime.NH;

public interface IUnitOfWork : IDisposable
{
	bool IsDirty { get; }

	ISession Session { get; }

	Guid Uid { get; }

	void Commit();

	void Rollback();
}
