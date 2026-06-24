using System;
using System.Collections.Generic;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH.SessionProviders;

public sealed class CallSessionProvider : ISessionsContainerProvider, ISessionProvider
{
	private static ISessionProvider sessionProvider;

	internal static CallSessionProvider kKymkHWHRe6ljsAEaIYa;

	private static ISessionProvider SessionProvider
	{
		get
		{
			int num = 1;
			int num2 = num;
			ISessionProvider obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = sessionProvider;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj = (sessionProvider = Locator.GetServiceNotNull<ISessionProvider>());
					break;
				}
				break;
			}
			return obj;
		}
	}

	[Obsolete("Use ISessionProvider.GetSession", true)]
	public ISession GetSession(string dbName)
	{
		return (ISession)uNH5HAWHTjJEgMRk9fne(jmKDgJWHXTJMZ6naxaam(), dbName);
	}

	[Obsolete("Use ISessionProvider.SetCurrentSession", true)]
	public void SetCurrentSession(ISession session, string dbName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				jneRl5WHkcmPlA6MDJ0D(jmKDgJWHXTJMZ6naxaam(), session, dbName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[Obsolete("Use ISessionProvider.EndUnitOfWork", true)]
	public void EndUnitOfWork(string dbName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				pTR2RlWHnTnlIUZoGuSs(jmKDgJWHXTJMZ6naxaam(), dbName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[Obsolete("Use ISessionProvider.CloseSession", true)]
	public void CloseSession(string dbName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				MgSmGZWHObFy9T6SWUe8(jmKDgJWHXTJMZ6naxaam(), dbName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	IDictionary<Guid, ISessionsContainer> ISessionsContainerProvider.GetSessionsContainers()
	{
		return (CallContextSessionOwner.Current ?? throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x341A7B0B))).GetSessionTable();
	}

	public CallSessionProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object jmKDgJWHXTJMZ6naxaam()
	{
		return SessionProvider;
	}

	internal static object uNH5HAWHTjJEgMRk9fne(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static bool JFvJu6WHqwyIN3VDiao8()
	{
		return kKymkHWHRe6ljsAEaIYa == null;
	}

	internal static CallSessionProvider BHwvTwWHKUkQoMtyHEam()
	{
		return kKymkHWHRe6ljsAEaIYa;
	}

	internal static void jneRl5WHkcmPlA6MDJ0D(object P_0, object P_1, object P_2)
	{
		((ISessionProvider)P_0).SetCurrentSession((ISession)P_1, (string)P_2);
	}

	internal static void pTR2RlWHnTnlIUZoGuSs(object P_0, object P_1)
	{
		((ISessionProvider)P_0).EndUnitOfWork((string)P_1);
	}

	internal static void MgSmGZWHObFy9T6SWUe8(object P_0, object P_1)
	{
		((ISessionProvider)P_0).CloseSession((string)P_1);
	}
}
