using System;
using System.Data;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Helpers;

public class StatelessSessionHelper
{
	private readonly SessionFactoryHolder SessionFactoryHolder;

	internal static StatelessSessionHelper QLxQbVhYxj5RfvgHHyJL;

	public StatelessSessionHelper(SessionFactoryHolder sessionFactoryHolder)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				SessionFactoryHolder = sessionFactoryHolder;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void ExecuteOnSeparateTransaction(Action<IStatelessSession> action)
	{
		IStatelessSession val = null;
		try
		{
			val = SessionFactoryHolder.SessionFactory.OpenStatelessSession();
			val.BeginTransaction(IsolationLevel.ReadCommitted);
			action(val);
		}
		catch (Exception exception)
		{
			if (val != null && val.get_Transaction() != null && val.get_Transaction().get_IsActive())
			{
				Logger.Log.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C970F4A));
				val.get_Transaction().Rollback();
			}
			Logger.Log.Debug(exception, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EF8E71));
		}
		finally
		{
			if (val != null)
			{
				try
				{
					if (val.get_Transaction() != null && val.get_Transaction().get_IsActive())
					{
						val.get_Transaction().Commit();
					}
				}
				finally
				{
					val.Close();
					((IDisposable)val).Dispose();
				}
			}
		}
	}

	internal static bool qUC4j2hY0rfj8YcyKS9G()
	{
		return QLxQbVhYxj5RfvgHHyJL == null;
	}

	internal static StatelessSessionHelper oECngYhYmLimD4bCcmiA()
	{
		return QLxQbVhYxj5RfvgHHyJL;
	}
}
