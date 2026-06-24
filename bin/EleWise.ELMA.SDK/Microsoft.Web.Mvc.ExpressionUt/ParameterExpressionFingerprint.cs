using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace Microsoft.Web.Mvc.ExpressionUtil;

internal sealed class ParameterExpressionFingerprint : ExpressionFingerprint
{
	internal static ParameterExpressionFingerprint e6gG3Lo4XTn1ya1Dmc8;

	public int ParameterIndex
	{
		[CompilerGenerated]
		get
		{
			return _003CParameterIndex_003Ek__BackingField;
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
					_003CParameterIndex_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ParameterExpressionFingerprint(ExpressionType nodeType, Type type, int parameterIndex)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		w2dqoWoAjpgwUd5aPTd();
		base._002Ector(nodeType, type);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
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
			ParameterIndex = parameterIndex;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
			{
				num = 1;
			}
		}
	}

	public override bool Equals(object obj)
	{
		int num = 3;
		int num2 = num;
		ParameterExpressionFingerprint parameterExpressionFingerprint = default(ParameterExpressionFingerprint);
		while (true)
		{
			switch (num2)
			{
			default:
				return Equals(parameterExpressionFingerprint);
			case 2:
				if (parameterExpressionFingerprint != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_0035;
			case 1:
				if (ParameterIndex == SGMUkuo73foXH9psla2(parameterExpressionFingerprint))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_0035;
			case 3:
				{
					parameterExpressionFingerprint = obj as ParameterExpressionFingerprint;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 1;
					}
					break;
				}
				IL_0035:
				return false;
			}
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
			case 2:
				N65G7IoxXuQF9epGYVu(combiner, ParameterIndex);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				base.AddToHashCodeCombiner(combiner);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool rFiT2xo6DqNJLUPCKe3()
	{
		return e6gG3Lo4XTn1ya1Dmc8 == null;
	}

	internal static ParameterExpressionFingerprint PbnYcqoHkHVhZpwnkkW()
	{
		return e6gG3Lo4XTn1ya1Dmc8;
	}

	internal static void w2dqoWoAjpgwUd5aPTd()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static int SGMUkuo73foXH9psla2(object P_0)
	{
		return ((ParameterExpressionFingerprint)P_0).ParameterIndex;
	}

	internal static void N65G7IoxXuQF9epGYVu(object P_0, int i)
	{
		((HashCodeCombiner)P_0).AddInt32(i);
	}
}
