using System;
using System.Collections.Concurrent;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.AdoNet;
using NHibernate.Cfg;
using NHibernate.Connection;
using NHibernate.Engine;

namespace EleWise.ELMA.Runtime.NH;

public class CustomBatcherFactory : IBatcherFactory
{
	private static readonly ConcurrentDictionary<Type, IBatcherFactory> InnerFactoryList;

	private static CustomBatcherFactory yeJlsIWtfHvQg0PHUcRa;

	public virtual IBatcher CreateBatcher(ConnectionManager connectionManager, IInterceptor interceptor)
	{
		//Discarded unreachable code: IL_0130, IL_01b7, IL_01c6
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		int num = 8;
		int num2 = num;
		IBatcher val = default(IBatcher);
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		IEmbeddedBatcherFactoryProvider val2 = default(IEmbeddedBatcherFactoryProvider);
		while (true)
		{
			switch (num2)
			{
			case 1:
			case 9:
				if (val == null)
				{
					num2 = 12;
					break;
				}
				goto case 13;
			default:
				_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
				num2 = 10;
				break;
			case 2:
			{
				object obj = hl0SXgWtuWdKQLJRMYwf(bexXN5WtZbdDv8TKiuyb(Sm7f2bWtvK79eJUjxmGQ(connectionManager)));
				val2 = (IEmbeddedBatcherFactoryProvider)((obj is IEmbeddedBatcherFactoryProvider) ? obj : null);
				num2 = 6;
				break;
			}
			case 5:
				val = (IBatcher)RijFgPWtS55s7a23V74L(InnerFactoryList.GetOrAdd(_003C_003Ec__DisplayClass1_.tBatcher, (Func<Type, IBatcherFactory>)_003C_003Ec__DisplayClass1_._003CCreateBatcher_003Eb__0), connectionManager, interceptor);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 1;
				}
				break;
			case 10:
				_003C_003Ec__DisplayClass1_.tBatcher = null;
				num2 = 2;
				break;
			case 6:
				if (val2 == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 14;
			case 14:
				if (y8fZ0fWtV3xQnsudZgYY(P6pMBgWtIpbYXa2Q7iPb(val2), null))
				{
					num2 = 4;
					break;
				}
				goto case 3;
			case 7:
				if (cBHtH4Wt8dwK6Lt9tknK(((ISessionFactoryImplementor)Sm7f2bWtvK79eJUjxmGQ(connectionManager)).get_Settings()) <= 0)
				{
					num2 = 9;
					break;
				}
				goto default;
			case 3:
			case 11:
				if (y8fZ0fWtV3xQnsudZgYY(_003C_003Ec__DisplayClass1_.tBatcher, null))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 1;
			case 13:
				return (IBatcher)(object)new CustomBatcher(val, interceptor);
			case 12:
				val = (IBatcher)new NonBatchingBatcher(connectionManager, interceptor);
				num2 = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				_003C_003Ec__DisplayClass1_.tBatcher = val2.get_BatcherFactoryClass();
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
				{
					num2 = 11;
				}
				break;
			case 8:
				val = null;
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public CustomBatcherFactory()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static CustomBatcherFactory()
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
				vD0EMgWtiJHwUNZMusNr();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				InnerFactoryList = new ConcurrentDictionary<Type, IBatcherFactory>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static object Sm7f2bWtvK79eJUjxmGQ(object P_0)
	{
		return ((ConnectionManager)P_0).get_Factory();
	}

	internal static int cBHtH4Wt8dwK6Lt9tknK(object P_0)
	{
		return ((Settings)P_0).get_AdoBatchSize();
	}

	internal static object bexXN5WtZbdDv8TKiuyb(object P_0)
	{
		return ((ISessionFactoryImplementor)P_0).get_ConnectionProvider();
	}

	internal static object hl0SXgWtuWdKQLJRMYwf(object P_0)
	{
		return ((IConnectionProvider)P_0).get_Driver();
	}

	internal static Type P6pMBgWtIpbYXa2Q7iPb(object P_0)
	{
		return ((IEmbeddedBatcherFactoryProvider)P_0).get_BatcherFactoryClass();
	}

	internal static bool y8fZ0fWtV3xQnsudZgYY(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object RijFgPWtS55s7a23V74L(object P_0, object P_1, object P_2)
	{
		return ((IBatcherFactory)P_0).CreateBatcher((ConnectionManager)P_1, (IInterceptor)P_2);
	}

	internal static bool Ui0MaHWtQyeuXyoeptit()
	{
		return yeJlsIWtfHvQg0PHUcRa == null;
	}

	internal static CustomBatcherFactory IkxPS3WtCuE7GM94vNEP()
	{
		return yeJlsIWtfHvQg0PHUcRa;
	}

	internal static void vD0EMgWtiJHwUNZMusNr()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
