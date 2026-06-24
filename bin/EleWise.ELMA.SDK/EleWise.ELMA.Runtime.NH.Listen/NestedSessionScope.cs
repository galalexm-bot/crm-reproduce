using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH.Listeners;

internal class NestedSessionScope : IDisposable
{
	private readonly ISession originalSession;

	private readonly ISession nestedSession;

	private readonly string dbName;

	private readonly CallContextSessionOwner callContextSessionOwner;

	private static NestedSessionScope qYhNveW7pFxsDM7GsQNS;

	private ISessionProvider SessionProvider => Locator.GetServiceNotNull<ISessionProvider>();

	public NestedSessionScope(ISession nestedSession, string dbName)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		UEybn8W7tFSw0xq6M63C();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				callContextSessionOwner = (CallContextSessionOwner)OrJ7oDW7wDFWliZ6CKE4();
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num = 2;
				}
				break;
			case 3:
				originalSession = (ISession)vp5nc8W74KELEbunxZ75(SessionProvider, dbName);
				num = 5;
				break;
			case 1:
				this.nestedSession = nestedSession;
				num = 2;
				break;
			case 4:
				return;
			case 5:
				giqUQDW76Xp0rPBWdMVl(SessionProvider, nestedSession, dbName);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num = 4;
				}
				break;
			case 2:
				this.dbName = dbName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	void IDisposable.Dispose()
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
				giqUQDW76Xp0rPBWdMVl(SessionProvider, originalSession, dbName);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
			{
				CallContextSessionOwner obj = callContextSessionOwner;
				if (obj == null)
				{
					num2 = 3;
					break;
				}
				obj.Dispose();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 0;
				}
				break;
			}
			case 3:
				return;
			}
		}
	}

	public static void DoWith([NotNull] ISession nestedSession, [NotNull] string dbName, [NotNull] Action action)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
				num2 = 2;
				break;
			case 1:
				return;
			case 2:
				_003C_003Ec__DisplayClass8_.action = action;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				DoWith(nestedSession, dbName, (Func<int>)_003C_003Ec__DisplayClass8_._003CDoWith_003Eb__0);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public static T DoWith<T>([NotNull] ISession nestedSession, [NotNull] string dbName, [NotNull] Func<T> action)
	{
		if (nestedSession == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4E535F));
		}
		if (dbName == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EE3DAB));
		}
		if (action == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35923929));
		}
		using (new NestedSessionScope(nestedSession, dbName))
		{
			return action();
		}
	}

	internal static void UEybn8W7tFSw0xq6M63C()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object OrJ7oDW7wDFWliZ6CKE4()
	{
		return CallContextSessionOwner.Create();
	}

	internal static object vp5nc8W74KELEbunxZ75(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static void giqUQDW76Xp0rPBWdMVl(object P_0, object P_1, object P_2)
	{
		((ISessionProvider)P_0).SetCurrentSession((ISession)P_1, (string)P_2);
	}

	internal static bool XHJ53WW7aRHU3MK2r9QQ()
	{
		return qYhNveW7pFxsDM7GsQNS == null;
	}

	internal static NestedSessionScope URNjCKW7DODWsPETbLRU()
	{
		return qYhNveW7pFxsDM7GsQNS;
	}
}
