using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Common.Models;

[Serializable]
[DataContract]
[KnownType(typeof(WebData))]
[KnownType(typeof(WebData[]))]
public class WebDataItem
{
	protected string name;

	protected string value;

	protected WebData data;

	protected WebData[] dataArray;

	internal static WebDataItem pYd1Onfitr37UJ0eSXm4;

	[DataMember]
	public virtual string Name
	{
		get
		{
			return name;
		}
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
					name = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public virtual string Value
	{
		get
		{
			return value;
		}
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
					this.value = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public virtual WebData Data
	{
		get
		{
			return data;
		}
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
					data = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public virtual WebData[] DataArray
	{
		get
		{
			return dataArray;
		}
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
					dataArray = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WebDataItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		jdp3bVfi6iJow1PlLPys();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
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
			dataArray = new WebData[0];
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
			{
				num = 1;
			}
		}
	}

	public override string ToString()
	{
		//Discarded unreachable code: IL_0061, IL_0070, IL_007f, IL_00dc, IL_00eb
		int num = 2;
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					if (data == null)
					{
						num2 = 15;
						continue;
					}
					goto case 14;
				case 11:
					c2l5Hrfi7RU5ZH7Y1nxu(stringBuilder, lKUvHFfiHgZOtEttueh1(0x4D1C1EE4 ^ 0x4D1CE806));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					c2l5Hrfi7RU5ZH7Y1nxu(stringBuilder, lKUvHFfiHgZOtEttueh1(-1765851862 ^ -1765815358));
					num2 = 13;
					continue;
				case 1:
					cLdHSffiAgJMsKe14wRO(stringBuilder, name + (string)lKUvHFfiHgZOtEttueh1(0x3C5338FF ^ 0x3C5350AB));
					num2 = 4;
					continue;
				case 9:
					cLdHSffiAgJMsKe14wRO(stringBuilder, (string)lKUvHFfiHgZOtEttueh1(-1638402543 ^ -1638405303) + value + (string)lKUvHFfiHgZOtEttueh1(0x637E299B ^ 0x637E34C3));
					num2 = 6;
					continue;
				case 6:
				case 7:
				case 12:
				case 13:
					return stringBuilder.ToString();
				case 2:
					stringBuilder = new StringBuilder();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 1;
					}
					continue;
				case 14:
					stringBuilder.Append(data);
					num2 = 7;
					continue;
				case 5:
					cLdHSffiAgJMsKe14wRO(stringBuilder, lKUvHFfiHgZOtEttueh1(-672123589 ^ -672127523));
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 3;
					}
					continue;
				case 4:
					if (value != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 10;
				case 8:
				case 15:
					if (dataArray != null)
					{
						num2 = 11;
						continue;
					}
					goto case 5;
				default:
					cLdHSffiAgJMsKe14wRO(stringBuilder, string.Join((string)xZC2Uefi0qGfFFBh8PBi(lKUvHFfiHgZOtEttueh1(-1886646897 ^ -1886625921), G0Mh6nfixQ0ARMdhclPU()), dataArray.Select((WebData d) => d.ToString())));
					num = 3;
					break;
				}
				break;
			}
		}
	}

	internal static void jdp3bVfi6iJow1PlLPys()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool IfVA4YfiwOZmdBNHvNbq()
	{
		return pYd1Onfitr37UJ0eSXm4 == null;
	}

	internal static WebDataItem MFFWCQfi447epb3Y2DMg()
	{
		return pYd1Onfitr37UJ0eSXm4;
	}

	internal static object lKUvHFfiHgZOtEttueh1(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object cLdHSffiAgJMsKe14wRO(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object c2l5Hrfi7RU5ZH7Y1nxu(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).AppendLine((string)P_1);
	}

	internal static object G0Mh6nfixQ0ARMdhclPU()
	{
		return Environment.NewLine;
	}

	internal static object xZC2Uefi0qGfFFBh8PBi(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}
}
