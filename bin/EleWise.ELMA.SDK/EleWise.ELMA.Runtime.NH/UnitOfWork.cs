using System;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;

namespace EleWise.ELMA.Runtime.NH;

public abstract class UnitOfWork : IUnitOfWorkAsync, IUnitOfWork, IDisposable
{
	internal static UnitOfWork fnLVqZW1XVkMraixA0YS;

	public abstract Task<bool> IsDirtyAsync { get; }

	public abstract bool IsDirty { get; }

	public abstract ISession Session { get; }

	public abstract Guid Uid { get; }

	public abstract Task CommitAsync(CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task RollbackAsync(CancellationToken cancellationToken = default(CancellationToken));

	public static IUnitOfWork New(string dbName, bool transactional)
	{
		return Locator.GetServiceNotNull<IUnitOfWorkManager>().Create(dbName, transactional);
	}

	public static IUnitOfWork New(string dbName)
	{
		return (IUnitOfWork)q1qHDrW1nyOv9v3b4snv(dbName, true);
	}

	public abstract void Commit();

	public abstract void Rollback();

	public abstract void Dispose();

	protected UnitOfWork()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vZ4xlTW1OrVIbQXc7GNX();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool VyZ5wFW1To8pfr4O9e5g()
	{
		return fnLVqZW1XVkMraixA0YS == null;
	}

	internal static UnitOfWork N8QqRBW1kwei1L031a3O()
	{
		return fnLVqZW1XVkMraixA0YS;
	}

	internal static object q1qHDrW1nyOv9v3b4snv(object P_0, bool transactional)
	{
		return New((string)P_0, transactional);
	}

	internal static void vZ4xlTW1OrVIbQXc7GNX()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
