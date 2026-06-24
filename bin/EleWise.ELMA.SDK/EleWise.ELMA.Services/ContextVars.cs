using System;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public static class ContextVars
{
	public class Local<T>
	{
		private readonly string key;

		private readonly Func<T> valueFactory;

		internal static object Fye4dUQnZnGQs2phXgfv;

		public T Value
		{
			get
			{
				if (TryGetValue<T>(key, out var value))
				{
					return value;
				}
				if (valueFactory == null)
				{
					return default(T);
				}
				value = valueFactory();
				Set(key, value);
				return value;
			}
			set
			{
				Set(key, value);
			}
		}

		public Local()
		{
			//Discarded unreachable code: IL_0049, IL_004e
			SingletonReader.JJCZtPuTvSt();
			key = Guid.NewGuid().ToString();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public Local(Func<T> valueFactory)
		{
			SingletonReader.JJCZtPuTvSt();
			key = Guid.NewGuid().ToString();
			base._002Ector();
			this.valueFactory = valueFactory;
		}

		public void Reset()
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
					Remove(key);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static bool CtXcLcQnuH7jbZJOdSPt()
		{
			return Fye4dUQnZnGQs2phXgfv == null;
		}

		internal static object iKYtc8QnIdfDIIbjKiIi()
		{
			return Fye4dUQnZnGQs2phXgfv;
		}
	}

	private static IContextBoundVariableService service;

	internal static ContextVars P2gMhkBxAicA39XmEuYU;

	public static bool HasImpl => service != null;

	public static void SetImpl(IContextBoundVariableService service)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				ContextVars.service = service;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				Contract.ArgumentNotNull(service, (string)NHBU0dBx0xvvWKBO6Xn4(-1998538950 ^ -1998465190));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public static bool Contains(string name)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return idalSIBxygkaKFtlwJx0(service, name);
			case 1:
				l0u5jWBxme0RbFRemaod();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static T Get<T>(string name)
	{
		CheckImpl();
		return service.Get<T>(name);
	}

	public static T GetOrDefault<T>(string name)
	{
		TryGetValue<T>(name, out var value);
		return value;
	}

	public static bool TryGetValue<T>(string name, out T value)
	{
		CheckImpl();
		return service.TryGetValue<T>(name, out value);
	}

	public static T GetOrAdd<T>(string name, Func<T> val)
	{
		CheckImpl();
		if (service.TryGetValue<T>(name, out var value))
		{
			return value;
		}
		if (val == null)
		{
			throw new VariableNotFoundException(name);
		}
		T val2 = val();
		service.Set(name, val2);
		return val2;
	}

	public static void Set<T>(string name, T value)
	{
		CheckImpl();
		service.Set(name, value);
	}

	public static void Remove(string name)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				YhauegBxMbVabMMVEOFd(service, name);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				l0u5jWBxme0RbFRemaod();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void ClearContext()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				return;
			case 1:
			{
				IClearableContextBoundVariableService obj = service as IClearableContextBoundVariableService;
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					break;
				}
				qUWXMtBxJ2DdjZucww29(obj);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 0:
				return;
			}
		}
	}

	private static void CheckImpl()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (service == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			default:
				throw new NotInitializedException((string)FcjPJoBx9T7vHueTFaV7(NHBU0dBx0xvvWKBO6Xn4(0x34A6D230 ^ 0x34A7B242)));
			}
		}
	}

	internal static bool nunQCYBx7BQjwpfGAPkh()
	{
		return P2gMhkBxAicA39XmEuYU == null;
	}

	internal static ContextVars x64SLdBxx5CDb0lHYRC7()
	{
		return P2gMhkBxAicA39XmEuYU;
	}

	internal static object NHBU0dBx0xvvWKBO6Xn4(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void l0u5jWBxme0RbFRemaod()
	{
		CheckImpl();
	}

	internal static bool idalSIBxygkaKFtlwJx0(object P_0, object P_1)
	{
		return ((IAbstractBoundVariableService)P_0).Contains((string)P_1);
	}

	internal static void YhauegBxMbVabMMVEOFd(object P_0, object P_1)
	{
		((IAbstractBoundVariableService)P_0).Remove((string)P_1);
	}

	internal static void qUWXMtBxJ2DdjZucww29(object P_0)
	{
		((IClearableContextBoundVariableService)P_0).ClearContext();
	}

	internal static object FcjPJoBx9T7vHueTFaV7(object P_0)
	{
		return SR.T((string)P_0);
	}
}
