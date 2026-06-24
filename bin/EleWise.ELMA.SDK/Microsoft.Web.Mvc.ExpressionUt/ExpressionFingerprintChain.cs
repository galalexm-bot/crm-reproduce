using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace Microsoft.Web.Mvc.ExpressionUtil;

internal sealed class ExpressionFingerprintChain : IEquatable<ExpressionFingerprintChain>
{
	public readonly List<ExpressionFingerprint> Elements;

	internal static ExpressionFingerprintChain Nc8msPWwRFCTBp84VlC;

	public bool Equals(ExpressionFingerprintChain other)
	{
		//Discarded unreachable code: IL_0072, IL_0112, IL_0131
		int num = 6;
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					if (tBCn0pWHGken9Pi2Mxr(Elements) != other.Elements.Count)
					{
						num = 3;
						break;
					}
					num3 = 0;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					if (tk9FZ5WACLxs1PqwaE4(Elements[num3], other.Elements[num3]))
					{
						num2 = 8;
						continue;
					}
					goto case 9;
				case 9:
					return false;
				case 8:
					num3++;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					if (num3 >= tBCn0pWHGken9Pi2Mxr(Elements))
					{
						num = 2;
						break;
					}
					goto case 4;
				case 2:
					return true;
				case 3:
				case 5:
					return false;
				case 6:
					if (other == null)
					{
						num2 = 5;
						continue;
					}
					goto case 7;
				}
				break;
			}
		}
	}

	public override bool Equals(object obj)
	{
		return Equals(obj as ExpressionFingerprintChain);
	}

	public override int GetHashCode()
	{
		int num = 1;
		int num2 = num;
		HashCodeCombiner hashCodeCombiner = default(HashCodeCombiner);
		while (true)
		{
			switch (num2)
			{
			default:
				Elements.ForEach(hashCodeCombiner.AddFingerprint);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return xWjutVW78N9NKbuWoxZ(hashCodeCombiner);
			case 1:
				hashCodeCombiner = new HashCodeCombiner();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ExpressionFingerprintChain()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		mpUDkiWxPiX17eU0d7A();
		Elements = new List<ExpressionFingerprint>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static int tBCn0pWHGken9Pi2Mxr(object P_0)
	{
		return ((List<ExpressionFingerprint>)P_0).Count;
	}

	internal static bool tk9FZ5WACLxs1PqwaE4(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static bool FXEpnfW49CUa8xK0NFZ()
	{
		return Nc8msPWwRFCTBp84VlC == null;
	}

	internal static ExpressionFingerprintChain W6lexRW6I50aDlFJHOp()
	{
		return Nc8msPWwRFCTBp84VlC;
	}

	internal static int xWjutVW78N9NKbuWoxZ(object P_0)
	{
		return ((HashCodeCombiner)P_0).CombinedHash;
	}

	internal static void mpUDkiWxPiX17eU0d7A()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
