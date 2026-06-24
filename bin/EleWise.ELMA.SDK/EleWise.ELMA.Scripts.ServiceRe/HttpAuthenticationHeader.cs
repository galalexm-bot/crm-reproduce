using System.Collections.Specialized;
using System.Net;
using System.Text;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Scripts.ServiceReference;

public class HttpAuthenticationHeader
{
	private string[] authenticationSchemes;

	internal static HttpAuthenticationHeader rZN5CDBcAWCO4hKjOvQs;

	public string AuthenticationType
	{
		get
		{
			//Discarded unreachable code: IL_0083, IL_0092, IL_00d8
			int num = 9;
			int num2 = num;
			StringBuilder stringBuilder = default(StringBuilder);
			int num4 = default(int);
			string text = default(string);
			int num5 = default(int);
			int num3 = default(int);
			while (true)
			{
				switch (num2)
				{
				case 6:
					return stringBuilder.ToString();
				case 8:
					return string.Empty;
				case 12:
					num4++;
					num2 = 2;
					continue;
				case 15:
					stringBuilder.Append(text);
					num2 = 14;
					continue;
				default:
					if (num5 > 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 15;
				case 4:
					stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345432268));
					num2 = 15;
					continue;
				case 3:
					text = (string)rwguf6BcJ1E1B8vkPX5V(text, 0, num3);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					num4 = 0;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 11;
					}
					continue;
				case 7:
					num5 = 0;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 0;
					}
					continue;
				case 14:
					num5++;
					num2 = 12;
					continue;
				case 5:
					if (num3 > 0)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto default;
				case 2:
				case 11:
					if (num4 >= authenticationSchemes.Length)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				case 9:
					if (!HasAuthenticationSchemes)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 7;
				case 1:
					stringBuilder = new StringBuilder();
					num2 = 10;
					continue;
				case 13:
					num3 = Vva59oBcMqvkJqhn3K1f(text, ' ');
					num2 = 5;
					continue;
				case 16:
					break;
				}
				text = authenticationSchemes[num4];
				num2 = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num2 = 12;
				}
			}
		}
	}

	private bool HasAuthenticationSchemes
	{
		get
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (authenticationSchemes == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				default:
					return authenticationSchemes.Length != 0;
				case 1:
					return false;
				}
			}
		}
	}

	public HttpAuthenticationHeader(WebHeaderCollection headers)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		tRM8BiBc0DfK92JTyENJ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
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
			authenticationSchemes = (string[])wJhR7lBcm8yiwAEpPcw1(headers, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92E93E3));
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
			{
				num = 1;
			}
		}
	}

	public override string ToString()
	{
		//Discarded unreachable code: IL_0087, IL_0121, IL_0130
		int num = 7;
		int num3 = default(int);
		string[] array = default(string[]);
		string value = default(string);
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					num3 = 0;
					num2 = 4;
					continue;
				case 4:
				case 5:
					if (num3 < array.Length)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 12;
				case 2:
				case 11:
					value = array[num3];
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 9;
					}
					continue;
				case 1:
					num3++;
					num2 = 5;
					continue;
				case 9:
					stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F31F9EC));
					num2 = 3;
					continue;
				case 6:
					break;
				case 12:
					return stringBuilder.ToString();
				case 7:
					if (!HasAuthenticationSchemes)
					{
						return string.Empty;
					}
					num2 = 6;
					continue;
				case 3:
					stringBuilder.Append(value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					array = authenticationSchemes;
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 4;
					}
					continue;
				default:
					IPAOcmBcyNUYhcKxXjec(stringBuilder, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BBD600));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			stringBuilder = new StringBuilder();
			num = 8;
		}
	}

	internal static void tRM8BiBc0DfK92JTyENJ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object wJhR7lBcm8yiwAEpPcw1(object P_0, object P_1)
	{
		return ((NameValueCollection)P_0).GetValues((string)P_1);
	}

	internal static bool QlkbnMBc7Av7lbiu3VlI()
	{
		return rZN5CDBcAWCO4hKjOvQs == null;
	}

	internal static HttpAuthenticationHeader bamH4FBcxjnWl6rqMBSh()
	{
		return rZN5CDBcAWCO4hKjOvQs;
	}

	internal static object IPAOcmBcyNUYhcKxXjec(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static int Vva59oBcMqvkJqhn3K1f(object P_0, char P_1)
	{
		return ((string)P_0).IndexOf(P_1);
	}

	internal static object rwguf6BcJ1E1B8vkPX5V(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}
}
