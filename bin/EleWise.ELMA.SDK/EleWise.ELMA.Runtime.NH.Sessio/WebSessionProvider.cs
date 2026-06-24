using System;
using System.Collections.Generic;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;

namespace EleWise.ELMA.Runtime.NH.SessionProviders;

public class WebSessionProvider : ISessionsContainerProvider, ISessionProvider
{
	private static ISessionProvider sessionProvider;

	internal static WebSessionProvider CtB87WWHjp09VcAxqufM;

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
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
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
		return (ISession)xtix3PWHst4lQ7pqDcXD(pnapXTWHUYAEh8J7VYIC(), dbName);
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
			case 0:
				return;
			case 1:
				ky2rhdWHcvFOD5K93FYB(pnapXTWHUYAEh8J7VYIC(), session, dbName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 0;
				}
				break;
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
				((ISessionProvider)pnapXTWHUYAEh8J7VYIC()).EndUnitOfWork(dbName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
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
			case 1:
				VGfkcBWHzvQlD1p17eJE(pnapXTWHUYAEh8J7VYIC(), dbName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	IDictionary<Guid, ISessionsContainer> ISessionsContainerProvider.GetSessionsContainers()
	{
		return (CallContextSessionOwner.Current ?? CallContextSessionOwner.Create()).GetSessionTable();
	}

	internal static void RemoveSessionTable()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
			{
				CallContextSessionOwner current = CallContextSessionOwner.Current;
				if (current == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 1;
					}
					break;
				}
				current.Dispose();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 1:
				return;
			}
		}
	}

	public WebSessionProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object pnapXTWHUYAEh8J7VYIC()
	{
		return SessionProvider;
	}

	internal static object xtix3PWHst4lQ7pqDcXD(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static bool g6LYBMWHYtIi1awJ9au9()
	{
		return CtB87WWHjp09VcAxqufM == null;
	}

	internal static WebSessionProvider QHi2QPWHLfbcXFkexBCi()
	{
		return CtB87WWHjp09VcAxqufM;
	}

	internal static void ky2rhdWHcvFOD5K93FYB(object P_0, object P_1, object P_2)
	{
		((ISessionProvider)P_0).SetCurrentSession((ISession)P_1, (string)P_2);
	}

	internal static void VGfkcBWHzvQlD1p17eJE(object P_0, object P_1)
	{
		((ISessionProvider)P_0).CloseSession((string)P_1);
	}
}
