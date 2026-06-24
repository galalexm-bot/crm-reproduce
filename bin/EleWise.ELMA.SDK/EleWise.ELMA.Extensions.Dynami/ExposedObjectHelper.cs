using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CSharp.RuntimeBinder;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions.Dynamic;

internal class ExposedObjectHelper
{
	private static Type s_csharpInvokePropertyType;

	private static ExposedObjectHelper c9EBrCGxdkCn7qIQRsOT;

	internal static bool InvokeBestMethod(object[] args, object target, List<MethodInfo> instanceMethods, out object result)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.args = args;
		if (instanceMethods.Count == 1)
		{
			if (TryInvoke(instanceMethods[0], target, CS_0024_003C_003E8__locals0.args, out result))
			{
				return true;
			}
		}
		else if (instanceMethods.Count > 1)
		{
			MethodInfo methodInfo = null;
			Type[] arg = null;
			Type[] arg2 = CS_0024_003C_003E8__locals0.args.Select(delegate(object p)
			{
				//Discarded unreachable code: IL_004d, IL_005c
				int num4 = 2;
				int num5 = num4;
				while (true)
				{
					switch (num5)
					{
					case 2:
						if (p == null)
						{
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
							{
								num5 = 1;
							}
							break;
						}
						goto default;
					default:
						return p.GetType();
					case 1:
						return _003C_003Ec.FUnRLA8QUrUPIgqxjSVD(typeof(object).TypeHandle);
					}
				}
			}).ToArray();
			Func<Type[], Type[], bool> func = delegate(Type[] a, Type[] b)
			{
				//Discarded unreachable code: IL_003d, IL_00dd, IL_00ec
				int num = 5;
				int num2 = num;
				int num3 = default(int);
				while (true)
				{
					switch (num2)
					{
					case 5:
						num3 = 0;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
						{
							num2 = 4;
						}
						break;
					case 2:
					case 3:
						if (!a[num3].IsAssignableFrom(b[num3]))
						{
							num2 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
							{
								num2 = 6;
							}
						}
						else
						{
							num3++;
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
							{
								num2 = 1;
							}
						}
						break;
					default:
						return true;
					case 1:
					case 4:
						if (num3 < a.Length)
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
							{
								num2 = 2;
							}
							break;
						}
						goto default;
					case 6:
						return false;
					}
				}
			};
			foreach (MethodInfo item in instanceMethods.Where((MethodInfo m) => ((Array)_003C_003Ec__DisplayClass1_0.dyZQWc8Qg5xa4nIU47Oa(m)).Length == CS_0024_003C_003E8__locals0.args.Length))
			{
				Type[] array = (from x in item.GetParameters()
					select _003C_003Ec.fIAIRG8QsEmKuSeKMItb(x)).ToArray();
				if (func(array, arg2) && (methodInfo == null || func(arg, array)))
				{
					methodInfo = item;
					arg = array;
				}
			}
			if (methodInfo != null && TryInvoke(methodInfo, target, CS_0024_003C_003E8__locals0.args, out result))
			{
				return true;
			}
		}
		result = null;
		return false;
	}

	internal static bool TryInvoke(MethodInfo methodInfo, object target, object[] args, out object result)
	{
		//Discarded unreachable code: IL_004d, IL_00a0, IL_00d2, IL_00e9, IL_00f8
		int num = 1;
		int num2 = num;
		bool result2 = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					result = Xtuy0QGxgG0fpZDheft1(methodInfo, target, args);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							result2 = true;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
							{
								num3 = 0;
							}
							break;
						default:
							return result2;
						case 0:
							return result2;
						}
					}
				}
				catch (TargetInvocationException)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				catch (TargetParameterCountException)
				{
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				break;
			case 2:
				return false;
			}
			result = null;
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
			{
				num2 = 2;
			}
		}
	}

	internal static Type[] GetTypeArgs(InvokeMemberBinder binder)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (s_csharpInvokePropertyType.IsInstanceOfType(binder))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return null;
			default:
				return ((IEnumerable<Type>)ftGabDGx5LKpnyKmNoHb(s_csharpInvokePropertyType.GetProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710310464)), binder, null)).ToArray();
			}
		}
	}

	public ExposedObjectHelper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ExposedObjectHelper()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				s_csharpInvokePropertyType = jZs5fIGxY1gGCmPmejGD(typeof(RuntimeBinderException).Assembly, uAtuo7GxjF6YlnHG6AAZ(0x1FFEF86A ^ 0x1FFAF342));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static object Xtuy0QGxgG0fpZDheft1(object P_0, object P_1, object P_2)
	{
		return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
	}

	internal static bool evwSt2GxlhGARGAtUkOg()
	{
		return c9EBrCGxdkCn7qIQRsOT == null;
	}

	internal static ExposedObjectHelper lgQ6WVGxrhZmtqThjN8q()
	{
		return c9EBrCGxdkCn7qIQRsOT;
	}

	internal static object ftGabDGx5LKpnyKmNoHb(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static object uAtuo7GxjF6YlnHG6AAZ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type jZs5fIGxY1gGCmPmejGD(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetType((string)P_1);
	}
}
