using System;
using System.ComponentModel.DataAnnotations;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Validation;

public class RangeValueAttribute : RangeAttribute
{
	internal static RangeValueAttribute za5lclog1JypZFGOqSsH;

	private static string GetMessage(object minimum, object maximum)
	{
		//Discarded unreachable code: IL_0051, IL_00ea, IL_0186, IL_0195
		int num = 6;
		string result = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (minimum == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 8;
				case 4:
					result = SR.T((string)eBEQSZogpCeDDicEP8b3(-1217523399 ^ -1217514421), maximum);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					break;
				case 9:
					result = SR.T((string)eBEQSZogpCeDDicEP8b3(-629844702 ^ -629837772), minimum, maximum);
					num2 = 11;
					continue;
				default:
					return result;
				case 1:
				case 10:
					if (minimum != null)
					{
						num2 = 7;
						continue;
					}
					goto case 3;
				case 3:
					if (maximum != null)
					{
						num2 = 4;
						continue;
					}
					goto default;
				case 8:
					if (maximum != null)
					{
						num2 = 9;
						continue;
					}
					goto case 1;
				case 6:
					result = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345413570));
					num2 = 5;
					continue;
				}
				break;
			}
			result = SR.T((string)eBEQSZogpCeDDicEP8b3(0xE1229CF ^ 0xE120C79), minimum);
			num = 2;
		}
	}

	public RangeValueAttribute(long minimum, long maximum)
	{
		//Discarded unreachable code: IL_002e, IL_0033
		EEW3TIoga5UJXuumYJTv();
		base._002Ector(minimum, maximum);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
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
			QZpQeyogDFCaTj5nv9dL(this, GetMessage(minimum, maximum));
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
			{
				num = 0;
			}
		}
	}

	public RangeValueAttribute(long minimum, long maximum, string message)
	{
		//Discarded unreachable code: IL_001e, IL_0023
		EEW3TIoga5UJXuumYJTv();
		base._002Ector(minimum, maximum);
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				message = (string)hJYkkLogwIpQFgbJ03BN(minimum, maximum);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num = 1;
				}
				continue;
			case 0:
				return;
			case 3:
				if (VuCHSxogtilFULqrSxmp(message))
				{
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num = 2;
					}
					continue;
				}
				break;
			case 1:
				break;
			}
			QZpQeyogDFCaTj5nv9dL(this, message);
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
			{
				num = 0;
			}
		}
	}

	public RangeValueAttribute(short minimum, short maximum)
	{
		//Discarded unreachable code: IL_0042, IL_0047
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(Df49i0og4pLnolBa0GlG(typeof(short).TypeHandle), minimum.ToString(), maximum.ToString());
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
				QZpQeyogDFCaTj5nv9dL(this, hJYkkLogwIpQFgbJ03BN(minimum, maximum));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public RangeValueAttribute(short minimum, short maximum, string message)
	{
		//Discarded unreachable code: IL_0042, IL_0047, IL_006e
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(Df49i0og4pLnolBa0GlG(typeof(short).TypeHandle), minimum.ToString(), maximum.ToString());
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				QZpQeyogDFCaTj5nv9dL(this, message);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num = 2;
				}
				break;
			case 3:
				message = (string)hJYkkLogwIpQFgbJ03BN(minimum, maximum);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			case 1:
				if (!string.IsNullOrEmpty(message))
				{
					num = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num = 1;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public RangeValueAttribute(int minimum, int maximum)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		EEW3TIoga5UJXuumYJTv();
		base._002Ector(minimum, maximum);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
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
				QZpQeyogDFCaTj5nv9dL(this, hJYkkLogwIpQFgbJ03BN(minimum, maximum));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public RangeValueAttribute(int minimum, int maximum, string message)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		EEW3TIoga5UJXuumYJTv();
		base._002Ector(minimum, maximum);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				if (VuCHSxogtilFULqrSxmp(message))
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num = 0;
					}
					continue;
				}
				break;
			default:
				message = (string)hJYkkLogwIpQFgbJ03BN(minimum, maximum);
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num = 3;
				}
				continue;
			case 2:
				return;
			case 3:
				break;
			}
			QZpQeyogDFCaTj5nv9dL(this, message);
			num = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
			{
				num = 0;
			}
		}
	}

	public RangeValueAttribute(double minimum, double maximum)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(minimum, maximum);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				QZpQeyogDFCaTj5nv9dL(this, GetMessage(minimum, maximum));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public RangeValueAttribute(double minimum, double maximum, string message)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		EEW3TIoga5UJXuumYJTv();
		base._002Ector(minimum, maximum);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				if (VuCHSxogtilFULqrSxmp(message))
				{
					num = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num = 0;
					}
					continue;
				}
				break;
			case 3:
				return;
			case 2:
				message = GetMessage(minimum, maximum);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num = 0;
				}
				continue;
			}
			base.ErrorMessage = message;
			num = 3;
		}
	}

	public RangeValueAttribute(Type type, string minimum, string maximum)
	{
		//Discarded unreachable code: IL_002d, IL_0032, IL_00b2
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(type, minimum, maximum);
		int num = 4;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
			case 6:
				QZpQeyogDFCaTj5nv9dL(this, hJYkkLogwIpQFgbJ03BN(minimum, maximum));
				num = 5;
				break;
			case 1:
				minimum = null;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num = 0;
				}
				break;
			case 3:
				maximum = null;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num = 2;
				}
				break;
			case 5:
				return;
			default:
				if (!string.IsNullOrEmpty(maximum))
				{
					num = 6;
					break;
				}
				goto case 3;
			case 4:
				if (VuCHSxogtilFULqrSxmp(minimum))
				{
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public RangeValueAttribute(Type type, string minimum, string maximum, string message)
	{
		//Discarded unreachable code: IL_002d
		EEW3TIoga5UJXuumYJTv();
		base._002Ector(type, minimum, maximum);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
		{
			num = 0;
		}
		while (true)
		{
			int num2;
			switch (num)
			{
			case 1:
				if (string.IsNullOrEmpty(maximum))
				{
					num = 7;
					break;
				}
				goto case 6;
			case 7:
				maximum = null;
				num = 6;
				break;
			case 5:
				QZpQeyogDFCaTj5nv9dL(this, message);
				num2 = 3;
				goto IL_0032;
			case 4:
				message = (string)hJYkkLogwIpQFgbJ03BN(minimum, maximum);
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num = 5;
				}
				break;
			default:
				if (VuCHSxogtilFULqrSxmp(minimum))
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num = 2;
					}
					break;
				}
				goto case 1;
			case 3:
				return;
			case 2:
				minimum = null;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num = 1;
				}
				break;
			case 6:
				{
					if (string.IsNullOrEmpty(message))
					{
						num2 = 4;
						goto IL_0032;
					}
					goto case 5;
				}
				IL_0032:
				num = num2;
				break;
			}
		}
	}

	internal static object eBEQSZogpCeDDicEP8b3(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool t89nsTogNI4g1qebdHpU()
	{
		return za5lclog1JypZFGOqSsH == null;
	}

	internal static RangeValueAttribute m9IhDhog3nPjf58YMsRT()
	{
		return za5lclog1JypZFGOqSsH;
	}

	internal static void EEW3TIoga5UJXuumYJTv()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void QZpQeyogDFCaTj5nv9dL(object P_0, object P_1)
	{
		((ValidationAttribute)P_0).ErrorMessage = (string)P_1;
	}

	internal static bool VuCHSxogtilFULqrSxmp(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object hJYkkLogwIpQFgbJ03BN(object P_0, object P_1)
	{
		return GetMessage(P_0, P_1);
	}

	internal static Type Df49i0og4pLnolBa0GlG(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
