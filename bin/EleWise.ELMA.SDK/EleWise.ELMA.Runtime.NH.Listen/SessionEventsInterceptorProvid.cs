using System;
using System.Collections;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Type;

namespace EleWise.ELMA.Runtime.NH.Listeners;

[Service]
public class SessionEventsInterceptorProvider : IInterceptorProvider
{
	[Serializable]
	private class Intercptor : EmptyInterceptor
	{
		private static object muwiejQjtIwLbqGeXarI;

		public override void PreFlush(ICollection entitites)
		{
		}

		public override bool OnSave(object entity, object id, object[] state, string[] propertyNames, IType[] types)
		{
			return false;
		}

		public Intercptor()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			GMg9BYQj67QJivZJ46wB();
			((EmptyInterceptor)this)._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void GMg9BYQj67QJivZJ46wB()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool AhxeNVQjwQJJOhH33MbV()
		{
			return muwiejQjtIwLbqGeXarI == null;
		}

		internal static Intercptor em4TmAQj4foLA2tUDIVC()
		{
			return (Intercptor)muwiejQjtIwLbqGeXarI;
		}
	}

	internal static SessionEventsInterceptorProvider WGXL4EWAl1p1ySJxbFyg;

	public IInterceptor GetInterceptor(ISessionFactory factory)
	{
		return (IInterceptor)(object)new Intercptor();
	}

	public SessionEventsInterceptorProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		oIINKBWA5LFSSK9PFiAO();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void oIINKBWA5LFSSK9PFiAO()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Y4g5POWArtrEygbkQmvM()
	{
		return WGXL4EWAl1p1ySJxbFyg == null;
	}

	internal static SessionEventsInterceptorProvider Jpbxn9WAgg4QysgBVvGf()
	{
		return WGXL4EWAl1p1ySJxbFyg;
	}
}
