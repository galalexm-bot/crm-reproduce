using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace Microsoft.Web.Mvc.ExpressionUtil;

internal sealed class MethodCallExpressionFingerprint : ExpressionFingerprint
{
	internal static MethodCallExpressionFingerprint XVR33Uo3uR8WSVt0r6H;

	public MethodInfo Method
	{
		[CompilerGenerated]
		get
		{
			return _003CMethod_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CMethod_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public MethodCallExpressionFingerprint(ExpressionType nodeType, Type type, MethodInfo method)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		iGgivsoD0589NBAYbml();
		base._002Ector(nodeType, type);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			Method = method;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
			{
				num = 1;
			}
		}
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_0062, IL_0071
		int num = 3;
		int num2 = num;
		MethodCallExpressionFingerprint methodCallExpressionFingerprint = default(MethodCallExpressionFingerprint);
		while (true)
		{
			switch (num2)
			{
			case 3:
				methodCallExpressionFingerprint = obj as MethodCallExpressionFingerprint;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 2;
				}
				break;
			default:
				return Equals(methodCallExpressionFingerprint);
			case 1:
				return false;
			case 2:
				if (methodCallExpressionFingerprint != null)
				{
					num2 = 4;
					break;
				}
				goto case 1;
			case 4:
				if (!wZM943ot7wl0g3bnTNn(Method, methodCallExpressionFingerprint.Method))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	internal override void AddToHashCodeCombiner(HashCodeCombiner combiner)
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
				XnWMg4owc326Td6HY0w(combiner, Method);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 0;
				}
				break;
			default:
				base.AddToHashCodeCombiner(combiner);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static bool ayO6T8op4UT1MPgZucM()
	{
		return XVR33Uo3uR8WSVt0r6H == null;
	}

	internal static MethodCallExpressionFingerprint BghCjxoauBVIaILbiBg()
	{
		return XVR33Uo3uR8WSVt0r6H;
	}

	internal static void iGgivsoD0589NBAYbml()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool wZM943ot7wl0g3bnTNn(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static void XnWMg4owc326Td6HY0w(object P_0, object P_1)
	{
		((HashCodeCombiner)P_0).AddObject(P_1);
	}
}
