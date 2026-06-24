using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ActorModel;

public struct GuidCompoundKey : IEquatable<GuidCompoundKey>
{
	private static object OQ2nhGf3qTp5pXs9R9ME;

	public Guid GuidKey
	{
		[CompilerGenerated]
		get
		{
			return _003CGuidKey_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CGuidKey_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string StringKey
	{
		[CompilerGenerated]
		get
		{
			return _003CStringKey_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CStringKey_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override bool Equals(object obj)
	{
		int num = 2;
		int num2 = num;
		GuidCompoundKey other = default(GuidCompoundKey);
		object obj2 = default(object);
		while (true)
		{
			switch (num2)
			{
			default:
				return Equals(other);
			case 1:
				other = (GuidCompoundKey)obj2;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (!((obj2 = obj) is GuidCompoundKey))
				{
					return false;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public bool Equals(GuidCompoundKey other)
	{
		//Discarded unreachable code: IL_0095, IL_00a4
		int num = 1;
		int num2 = num;
		Guid guidKey = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 1:
				guidKey = GuidKey;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (!guidKey.Equals(other.GuidKey))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 3;
			case 3:
				return ofCcqKf3TsumkwaHDhWj(StringKey, other.StringKey);
			case 2:
				return false;
			}
		}
	}

	public override int GetHashCode()
	{
		return (1925753114 * -1521134295 + EqualityComparer<Guid>.Default.GetHashCode(GuidKey)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(StringKey);
	}

	public override string ToString()
	{
		return (string)qLXKtLf3kCg0rxDD669O(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978427880), GuidKey, StringKey);
	}

	internal static bool EYSs5Vf3KmiLRxohTPJD()
	{
		return OQ2nhGf3qTp5pXs9R9ME == null;
	}

	internal static object eHnH6kf3XCxLaQrboVyW()
	{
		return OQ2nhGf3qTp5pXs9R9ME;
	}

	internal static bool ofCcqKf3TsumkwaHDhWj(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object qLXKtLf3kCg0rxDD669O(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}
}
