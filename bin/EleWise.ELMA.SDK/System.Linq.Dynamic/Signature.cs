using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace System.Linq.Dynamic;

internal class Signature : IEquatable<Signature>
{
	public DynamicProperty[] properties;

	public int hashCode;

	private static Signature rmnLHpbjjwt1s00H5mB;

	public Signature(IEnumerable<DynamicProperty> properties)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.properties = properties.ToArray();
		hashCode = 0;
		foreach (DynamicProperty property in properties)
		{
			hashCode ^= property.Name.GetHashCode() ^ property.Type.GetHashCode();
		}
	}

	public override int GetHashCode()
	{
		return hashCode;
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_003c, IL_004b
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return false;
			case 1:
				return Equals((Signature)obj);
			case 2:
				if (obj is Signature)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public bool Equals(Signature other)
	{
		//Discarded unreachable code: IL_00dd, IL_00ec, IL_00fc
		int num = 8;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
			case 2:
				if (num3 >= properties.Length)
				{
					num2 = 3;
					break;
				}
				goto case 4;
			default:
				if (Tr6gk1bzeIW8fgaOtgv(nR3hJMbcCHQIPa1i503(properties[num3]), other.properties[num3].Type))
				{
					num2 = 6;
					break;
				}
				num3++;
				num2 = 2;
				break;
			case 7:
				return false;
			case 4:
				if (XCYyVAbs18vu68lxRJk(properties[num3].Name, syf582bUtLw2cPT7odm(other.properties[num3])))
				{
					num2 = 5;
					break;
				}
				goto default;
			case 8:
				if (properties.Length == other.properties.Length)
				{
					num3 = 0;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 7;
					}
				}
				break;
			case 5:
			case 6:
				return false;
			case 3:
				return true;
			}
		}
	}

	internal static bool C9qqkIbYeF3nfxdAUpY()
	{
		return rmnLHpbjjwt1s00H5mB == null;
	}

	internal static Signature wdK8b3bL0jEbAVAFiiP()
	{
		return rmnLHpbjjwt1s00H5mB;
	}

	internal static object syf582bUtLw2cPT7odm(object P_0)
	{
		return ((DynamicProperty)P_0).Name;
	}

	internal static bool XCYyVAbs18vu68lxRJk(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static Type nR3hJMbcCHQIPa1i503(object P_0)
	{
		return ((DynamicProperty)P_0).Type;
	}

	internal static bool Tr6gk1bzeIW8fgaOtgv(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}
}
