using System;
using System.Linq.Expressions;
using j3AmrhgkCleVTGdEwA;

namespace Microsoft.Web.Mvc.ExpressionUtil;

internal sealed class ConditionalExpressionFingerprint : ExpressionFingerprint
{
	internal static ConditionalExpressionFingerprint kNQySeWiuUcmCoQB9mu;

	public ConditionalExpressionFingerprint(ExpressionType nodeType, Type type)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.PushGlobal();
		base._002Ector(nodeType, type);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override bool Equals(object obj)
	{
		int num = 2;
		int num2 = num;
		ConditionalExpressionFingerprint conditionalExpressionFingerprint = default(ConditionalExpressionFingerprint);
		while (true)
		{
			switch (num2)
			{
			case 2:
				conditionalExpressionFingerprint = obj as ConditionalExpressionFingerprint;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return Equals(conditionalExpressionFingerprint);
			case 1:
				if (conditionalExpressionFingerprint == null)
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool zHZ3EpWRBGA5lXlabIS()
	{
		return kNQySeWiuUcmCoQB9mu == null;
	}

	internal static ConditionalExpressionFingerprint kRE6IaWqC4SUg4OppUb()
	{
		return kNQySeWiuUcmCoQB9mu;
	}
}
