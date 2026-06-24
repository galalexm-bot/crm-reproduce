using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Settings.Managers;

[Component]
internal class TypeSettingsInstanceStoreListener : IUnitOfWorkEventListener
{
	private static TypeSettingsInstanceStoreListener UZYyjpbWjEggAy0rFSH6;

	public void OnStartUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPreFlushUnitofWork(IUnitOfWork unitOfWork, IEnumerable<object> entities)
	{
	}

	public void OnPostFlushUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPreCommitUnitofWork(IUnitOfWork unitOfWork)
	{
		h82h31bWsJ3N7cMIHCMp(BofdgMbWUJYpBcen7JWx());
	}

	public void OnPostCommitUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPostRollbackUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnDisposeUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public TypeSettingsInstanceStoreListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		z0G6PobWcAxly63Pxo15();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object BofdgMbWUJYpBcen7JWx()
	{
		return TypeSettingsInstanceStoreManager.Instance;
	}

	internal static void h82h31bWsJ3N7cMIHCMp(object P_0)
	{
		((TypeSettingsInstanceStoreManager)P_0).SavePending();
	}

	internal static void z0G6PobWcAxly63Pxo15()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool bcysWlbWYBEcOGEFlAWH()
	{
		return UZYyjpbWjEggAy0rFSH6 == null;
	}

	internal static TypeSettingsInstanceStoreListener yHoQ4jbWLgA7n7jyxVpS()
	{
		return UZYyjpbWjEggAy0rFSH6;
	}
}
