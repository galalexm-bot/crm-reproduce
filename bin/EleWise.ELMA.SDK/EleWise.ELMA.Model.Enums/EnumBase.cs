using System;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Enums;

[Serializable]
public abstract class EnumBase : ISerializable
{
	private readonly Guid _value;

	private readonly string _name;

	internal static EnumBase uXp1gsoEYE2WnElNiAUJ;

	public Guid Value => _value;

	public string Name => _name;

	protected EnumBase(Guid value, string name)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				_name = name;
				num = 2;
				continue;
			}
			_value = value;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
			{
				num = 1;
			}
		}
	}

	public override string ToString()
	{
		return (string)dFs96roEcg4d5G23nRgv(new object[4]
		{
			_name,
			KS3VpRoEs9GHDR7Od2x7(-1123633026 ^ -1123637304),
			_value,
			KS3VpRoEs9GHDR7Od2x7(-1824388195 ^ -1824386015)
		});
	}

	public override bool Equals(object obj)
	{
		return AemyeYoEzvr8iODbkW0k(this, obj as EnumBase);
	}

	public override int GetHashCode()
	{
		return NdIxoLofBGubLTCFVFHN(ymYlRiofFt1Z1UdaCtti(this).FullName, KS3VpRoEs9GHDR7Od2x7(0x4EDCBA32 ^ 0x4EDCB45E), _value).GetHashCode();
	}

	public static implicit operator Guid(EnumBase m)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return Guid.Empty;
			case 1:
				if (sBUdiqofWuVRmPB12j4q(m, null))
				{
					return e7AulhofocK6rPCdMeEb(m);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static bool operator ==(EnumBase m1, EnumBase m2)
	{
		return AemyeYoEzvr8iODbkW0k(m1, m2);
	}

	public static bool operator !=(EnumBase m1, EnumBase m2)
	{
		return !AemyeYoEzvr8iODbkW0k(m1, m2);
	}

	private static bool IsEqual(object m1, object m2)
	{
		//Discarded unreachable code: IL_0079, IL_00ae, IL_00bd, IL_00df, IL_00ee, IL_00fd
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (m2 != null)
				{
					num2 = 5;
					break;
				}
				goto case 2;
			case 1:
				if (m1 != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 8;
			case 2:
				return false;
			case 5:
				if (!ayxZMjofbSLw0WZp8RNP(m1.GetType(), m2.GetType()))
				{
					num2 = 4;
					break;
				}
				goto case 9;
			case 7:
				return true;
			default:
				if (m1 != null)
				{
					num2 = 6;
					break;
				}
				goto case 2;
			case 8:
				if (m2 != null)
				{
					num2 = 3;
					break;
				}
				goto case 7;
			case 9:
				return e7AulhofocK6rPCdMeEb(m1) == ((EnumBase)m2).Value;
			case 4:
				return false;
			}
		}
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
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
				V7gBGGofh16Bg1Q0XjKc(info, KS3VpRoEs9GHDR7Od2x7(0x92F12D5 ^ 0x92FB481), _value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				V7gBGGofh16Bg1Q0XjKc(info, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099764073), _name);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected EnumBase(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		fDtxmwofGUrHkf7DU0k5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				_name = (string)j1psyEofEWTNy5JtpPkZ(info, KS3VpRoEs9GHDR7Od2x7(-35995181 ^ -35999213));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num = 2;
				}
				break;
			case 2:
				_value = (Guid)NU38N8offDiHJirCwbe6(info, KS3VpRoEs9GHDR7Od2x7(0x3CE17B75 ^ 0x3CE1DD21), typeof(Guid));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	internal static bool WigwTRoELpSWDUBRMsOn()
	{
		return (object)uXp1gsoEYE2WnElNiAUJ == null;
	}

	internal static EnumBase R5G0IZoEU8Bf0KPA49HW()
	{
		return uXp1gsoEYE2WnElNiAUJ;
	}

	internal static object KS3VpRoEs9GHDR7Od2x7(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object dFs96roEcg4d5G23nRgv(object P_0)
	{
		return string.Concat((object[])P_0);
	}

	internal static bool AemyeYoEzvr8iODbkW0k(object P_0, object P_1)
	{
		return IsEqual(P_0, P_1);
	}

	internal static Type ymYlRiofFt1Z1UdaCtti(object P_0)
	{
		return P_0.GetType();
	}

	internal static object NdIxoLofBGubLTCFVFHN(object P_0, object P_1, object P_2)
	{
		return string.Concat(P_0, P_1, P_2);
	}

	internal static bool sBUdiqofWuVRmPB12j4q(object P_0, object P_1)
	{
		return (EnumBase)P_0 != (EnumBase)P_1;
	}

	internal static Guid e7AulhofocK6rPCdMeEb(object P_0)
	{
		return ((EnumBase)P_0).Value;
	}

	internal static bool ayxZMjofbSLw0WZp8RNP(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static void V7gBGGofh16Bg1Q0XjKc(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}

	internal static void fDtxmwofGUrHkf7DU0k5()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object j1psyEofEWTNy5JtpPkZ(object P_0, object P_1)
	{
		return ((SerializationInfo)P_0).GetString((string)P_1);
	}

	internal static object NU38N8offDiHJirCwbe6(object P_0, object P_1, Type P_2)
	{
		return ((SerializationInfo)P_0).GetValue((string)P_1, P_2);
	}
}
