using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace Microsoft.Web.Mvc.ExpressionUtil;

internal abstract class ExpressionFingerprint
{
	private static ExpressionFingerprint q7Yq2mWeWPgAAG6jPbB;

	public ExpressionType NodeType
	{
		[CompilerGenerated]
		get
		{
			return _003CNodeType_003Ek__BackingField;
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
					_003CNodeType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Type Type
	{
		[CompilerGenerated]
		get
		{
			return _003CType_003Ek__BackingField;
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
					_003CType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected ExpressionFingerprint(ExpressionType nodeType, Type type)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		MMGX3wWN9Xn07uOHtVl();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				NodeType = nodeType;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num = 0;
				}
				break;
			default:
				Type = type;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal virtual void AddToHashCodeCombiner(HashCodeCombiner combiner)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				HqbchpW3yr6CfUv8bK1(combiner, (int)NodeType);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				snTxemWpSKLYhscsJ0F(combiner, Type);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	protected bool Equals(ExpressionFingerprint other)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (NodeType == other.NodeType)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 3:
				if (other == null)
				{
					num2 = 2;
					continue;
				}
				goto case 1;
			default:
				return object.Equals(Type, RMA9XsWaw8kwIesi74w(other));
			case 2:
				break;
			}
			break;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		return Equals(obj as ExpressionFingerprint);
	}

	public override int GetHashCode()
	{
		int num = 2;
		int num2 = num;
		HashCodeCombiner hashCodeCombiner = default(HashCodeCombiner);
		while (true)
		{
			switch (num2)
			{
			default:
				return eb0VibWtSN66uocWjf0(hashCodeCombiner);
			case 1:
				MJE5KmWDssewyJ8Gid1(this, hashCodeCombiner);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				hashCodeCombiner = new HashCodeCombiner();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool gYi5RXWPIMDmEKgqwdk()
	{
		return q7Yq2mWeWPgAAG6jPbB == null;
	}

	internal static ExpressionFingerprint S5k2S8W1l4lvxY2Cew4()
	{
		return q7Yq2mWeWPgAAG6jPbB;
	}

	internal static void MMGX3wWN9Xn07uOHtVl()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void HqbchpW3yr6CfUv8bK1(object P_0, int i)
	{
		((HashCodeCombiner)P_0).AddInt32(i);
	}

	internal static void snTxemWpSKLYhscsJ0F(object P_0, object P_1)
	{
		((HashCodeCombiner)P_0).AddObject(P_1);
	}

	internal static Type RMA9XsWaw8kwIesi74w(object P_0)
	{
		return ((ExpressionFingerprint)P_0).Type;
	}

	internal static void MJE5KmWDssewyJ8Gid1(object P_0, object P_1)
	{
		((ExpressionFingerprint)P_0).AddToHashCodeCombiner((HashCodeCombiner)P_1);
	}

	internal static int eb0VibWtSN66uocWjf0(object P_0)
	{
		return ((HashCodeCombiner)P_0).CombinedHash;
	}
}
