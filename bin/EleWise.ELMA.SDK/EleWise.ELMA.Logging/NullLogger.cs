using System;
using System.Runtime.CompilerServices;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Logging;

public class NullLogger : ILogger
{
	[NotNull]
	private static volatile ILogger instance;

	internal static NullLogger qgZlsmhlpsr84XurRORn;

	[NotNull]
	public static ILogger Instance => instance;

	public event EventHandler ConfigurationChanged
	{
		[CompilerGenerated]
		add
		{
			int num = 1;
			int num2 = num;
			EventHandler eventHandler2 = default(EventHandler);
			EventHandler value2 = default(EventHandler);
			EventHandler eventHandler = default(EventHandler);
			while (true)
			{
				switch (num2)
				{
				case 4:
					eventHandler2 = Interlocked.CompareExchange(ref this.ConfigurationChanged, value2, eventHandler);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 2;
					}
					break;
				case 3:
					return;
				case 1:
					eventHandler2 = this.ConfigurationChanged;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					eventHandler = eventHandler2;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 2;
					}
					break;
				case 5:
					if ((object)eventHandler2 == eventHandler)
					{
						num2 = 3;
						break;
					}
					goto default;
				case 2:
					value2 = (EventHandler)Delegate.Combine(eventHandler, value);
					num2 = 4;
					break;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 2;
			int num2 = num;
			EventHandler eventHandler2 = default(EventHandler);
			EventHandler eventHandler = default(EventHandler);
			EventHandler value2 = default(EventHandler);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					eventHandler2 = eventHandler;
					num2 = 5;
					break;
				case 3:
					eventHandler = Interlocked.CompareExchange(ref this.ConfigurationChanged, value2, eventHandler2);
					num2 = 4;
					break;
				case 5:
					value2 = (EventHandler)udA0WDhlwRUcHtJB90Fv(eventHandler2, value);
					num2 = 3;
					break;
				case 0:
					return;
				case 2:
					eventHandler = this.ConfigurationChanged;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					if ((object)eventHandler == eventHandler2)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				}
			}
		}
	}

	internal static void SetupImpl(ILogger impl)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				if (impl == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
					break;
				}
				instance = impl;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				throw new ArgumentNullException((string)h8HnIkhltqN899YHGfEl(-1852837372 ^ -1853027924));
			case 0:
				return;
			}
		}
	}

	public bool IsEnabled(LogLevel level)
	{
		return false;
	}

	public void Log(LogLevel level, Exception exception, string format, params object[] args)
	{
	}

	public NullLogger()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		rgaPwkhl4LM8QC7XGAC2();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static NullLogger()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				rgaPwkhl4LM8QC7XGAC2();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				instance = new NullLogger();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static object h8HnIkhltqN899YHGfEl(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool yET7Alhlaj3RKrviLjGc()
	{
		return qgZlsmhlpsr84XurRORn == null;
	}

	internal static NullLogger p6Fo6BhlDggx0GuMIXs3()
	{
		return qgZlsmhlpsr84XurRORn;
	}

	internal static object udA0WDhlwRUcHtJB90Fv(object P_0, object P_1)
	{
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	internal static void rgaPwkhl4LM8QC7XGAC2()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
