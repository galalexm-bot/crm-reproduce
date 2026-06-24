using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace Microsoft.Web.Mvc.ExpressionUtil;

internal sealed class MemberExpressionFingerprint : ExpressionFingerprint
{
	internal static MemberExpressionFingerprint NyqxEsonjP7Unghn9n3;

	public MemberInfo Member
	{
		[CompilerGenerated]
		get
		{
			return _003CMember_003Ek__BackingField;
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
					_003CMember_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
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

	public MemberExpressionFingerprint(ExpressionType nodeType, Type type, MemberInfo member)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		EXh6WsoeZoFITGvgeZH();
		base._002Ector(nodeType, type);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Member = member;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override bool Equals(object obj)
	{
		int num = 3;
		int num2 = num;
		MemberExpressionFingerprint memberExpressionFingerprint = default(MemberExpressionFingerprint);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (memberExpressionFingerprint != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 3:
				memberExpressionFingerprint = obj as MemberExpressionFingerprint;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 1;
				}
				continue;
			default:
				if (N8AMlyo1MSQXsFv90m2(Member, RtnwihoPjJUV6TFqU5o(memberExpressionFingerprint)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 1:
				return Equals(memberExpressionFingerprint);
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
				ew5FLsoNJI0WVw83Z3j(combiner, Member);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				base.AddToHashCodeCombiner(combiner);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool Da278toOMc54JAYXpOl()
	{
		return NyqxEsonjP7Unghn9n3 == null;
	}

	internal static MemberExpressionFingerprint wwGM2qo2NVbmYZnKsOX()
	{
		return NyqxEsonjP7Unghn9n3;
	}

	internal static void EXh6WsoeZoFITGvgeZH()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object RtnwihoPjJUV6TFqU5o(object P_0)
	{
		return ((MemberExpressionFingerprint)P_0).Member;
	}

	internal static bool N8AMlyo1MSQXsFv90m2(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static void ew5FLsoNJI0WVw83Z3j(object P_0, object P_1)
	{
		((HashCodeCombiner)P_0).AddObject(P_1);
	}
}
