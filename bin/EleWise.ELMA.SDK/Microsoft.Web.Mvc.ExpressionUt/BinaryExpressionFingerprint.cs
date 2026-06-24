using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace Microsoft.Web.Mvc.ExpressionUtil;

internal sealed class BinaryExpressionFingerprint : ExpressionFingerprint
{
	private static BinaryExpressionFingerprint frJFagWv6bPZoVp6OR2;

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
				case 1:
					_003CMethod_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public BinaryExpressionFingerprint(ExpressionType nodeType, Type type, MethodInfo method)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		Gg8XVvWuHZSMUj4uNq9();
		base._002Ector(nodeType, type);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
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
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
			{
				num = 1;
			}
		}
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_00a4, IL_00b3
		int num = 4;
		int num2 = num;
		BinaryExpressionFingerprint binaryExpressionFingerprint = default(BinaryExpressionFingerprint);
		while (true)
		{
			switch (num2)
			{
			case 4:
				binaryExpressionFingerprint = obj as BinaryExpressionFingerprint;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 3;
				}
				continue;
			case 1:
				if (bSjG9qWVoABAH9TDddQ(Method, CtsQiRWIpEEUtrnsGge(binaryExpressionFingerprint)))
				{
					num2 = 2;
					continue;
				}
				break;
			case 3:
				if (binaryExpressionFingerprint == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 1;
			case 2:
				return Equals(binaryExpressionFingerprint);
			}
			break;
		}
		return false;
	}

	internal override void AddToHashCodeCombiner(HashCodeCombiner combiner)
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
				gNEA0tWS06XqPH8j9qY(combiner, Method);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				base.AddToHashCodeCombiner(combiner);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool hPcStqW8FLHwqIQAdIj()
	{
		return frJFagWv6bPZoVp6OR2 == null;
	}

	internal static BinaryExpressionFingerprint LAnthKWZDURSWhuoTUI()
	{
		return frJFagWv6bPZoVp6OR2;
	}

	internal static void Gg8XVvWuHZSMUj4uNq9()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object CtsQiRWIpEEUtrnsGge(object P_0)
	{
		return ((BinaryExpressionFingerprint)P_0).Method;
	}

	internal static bool bSjG9qWVoABAH9TDddQ(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static void gNEA0tWS06XqPH8j9qY(object P_0, object P_1)
	{
		((HashCodeCombiner)P_0).AddObject(P_1);
	}
}
