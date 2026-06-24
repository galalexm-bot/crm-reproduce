using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace Microsoft.Web.Mvc.ExpressionUtil;

internal sealed class UnaryExpressionFingerprint : ExpressionFingerprint
{
	internal static UnaryExpressionFingerprint wDmSl8o9UxBl6XVXnyZ;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
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

	public UnaryExpressionFingerprint(ExpressionType nodeType, Type type, MethodInfo method)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		v60cqjorwuSNUrVNEd9();
		base._002Ector(nodeType, type);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
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
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
			{
				num = 0;
			}
		}
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 4;
		UnaryExpressionFingerprint unaryExpressionFingerprint = default(UnaryExpressionFingerprint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (ldOk2Go5vV87fXIiapH(Method, ivqcOCogKOhPrIX9bqC(unaryExpressionFingerprint)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				case 4:
					break;
				default:
					return Equals(unaryExpressionFingerprint);
				case 1:
					return false;
				case 3:
					if (unaryExpressionFingerprint == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 2;
				}
				break;
			}
			unaryExpressionFingerprint = obj as UnaryExpressionFingerprint;
			num = 3;
		}
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
			case 1:
				base.AddToHashCodeCombiner(combiner);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				combiner.AddObject(Method);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool KxDRHFod08JChKlDk3V()
	{
		return wDmSl8o9UxBl6XVXnyZ == null;
	}

	internal static UnaryExpressionFingerprint e8cAElolbUGElb7brTX()
	{
		return wDmSl8o9UxBl6XVXnyZ;
	}

	internal static void v60cqjorwuSNUrVNEd9()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object ivqcOCogKOhPrIX9bqC(object P_0)
	{
		return ((UnaryExpressionFingerprint)P_0).Method;
	}

	internal static bool ldOk2Go5vV87fXIiapH(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}
}
