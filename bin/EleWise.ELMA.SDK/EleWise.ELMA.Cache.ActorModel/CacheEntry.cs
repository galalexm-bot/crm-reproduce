using System;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Cache.ActorModel;

internal class CacheEntry
{
	internal static CacheEntry q0WhvhfXH2vAaB3qah7n;

	public string Key { get; }

	public byte[] Value { get; }

	public uint Hash { get; }

	public double Angle { get; }

	public DateTime Expiration { get; }

	public CacheEntry(string key, byte[] value, uint hash, double angle, DateTime expiration)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		gv6SmbfXxOjbi6EwMWf4();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				Angle = angle;
				num = 3;
				break;
			case 5:
				Value = value;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				Hash = hash;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num = 0;
				}
				break;
			case 3:
				Expiration = expiration;
				num = 4;
				break;
			case 4:
				return;
			case 2:
				Key = key;
				num = 5;
				break;
			}
		}
	}

	public override string ToString()
	{
		return (string)M323HPfXmsvTtneHWpy0(RkBdJCfX0WGsEUwSbRkb(-87337865 ^ -87158273), new object[4] { Key, Hash, Angle, Expiration });
	}

	internal static void gv6SmbfXxOjbi6EwMWf4()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool a0ebf8fXAW4bdsnEV0fr()
	{
		return q0WhvhfXH2vAaB3qah7n == null;
	}

	internal static CacheEntry EPNhwyfX7YrILdbDrYiN()
	{
		return q0WhvhfXH2vAaB3qah7n;
	}

	internal static object RkBdJCfX0WGsEUwSbRkb(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object M323HPfXmsvTtneHWpy0(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}
}
