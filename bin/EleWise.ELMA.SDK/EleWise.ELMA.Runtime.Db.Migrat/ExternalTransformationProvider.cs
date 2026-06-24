using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Migrator.Providers;

public abstract class ExternalTransformationProvider : TransformationProviderBase
{
	private List<string> reservedWords;

	private static ExternalTransformationProvider rZNnouWkMlX2A3MWQIWr;

	protected virtual string QuoteReservedWordsSymbolStart => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939378220);

	protected virtual string QuoteReservedWordsSymbolEnd => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70002091);

	protected virtual string QuoteTemplate => (string)xhuT9YWksiPO6GsQO0vM(cMlagSWkLa9ShOGaGaOV(-234299632 ^ -234169350), QpAXp8Wkgn4fXTFvsUEw(this), UUZ8SjWkUlS9m2tSDIix(this));

	[Obsolete("Не использовать", true)]
	public ExternalTransformationProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WMq4ogWkdKvyjbGZ6sEQ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ExternalTransformationProvider(Func<IDbConnection> connectionCreateFunc)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(connectionCreateFunc);
	}

	public virtual string GetParamName(string queryPart)
	{
		return (string)htUbh7WklTXotK6bDEyf(queryPart, 1);
	}

	protected override string QuoteIfNeeded(string name)
	{
		int num = 5;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return name;
			case 4:
				if (t8YtmpWk5VtyM0VmY3FT(text, QpAXp8Wkgn4fXTFvsUEw(this)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_00af;
			case 5:
				text = (string)iDY8OhWkrapQ8wD8Tmxa(name);
				num2 = 4;
				break;
			default:
				if (text.EndsWith(QuoteReservedWordsSymbolEnd))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto IL_00af;
			case 3:
				return name;
			case 2:
				{
					if (mmJP4oWkYH4LBeYWiwka(name))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto IL_0036;
				}
				IL_0036:
				return string.Format(QuoteTemplate, name);
				IL_00af:
				if (!OygyGsWkjxlUYqjtD6CZ(this, name))
				{
					num2 = 2;
					break;
				}
				goto IL_0036;
			}
		}
	}

	protected virtual bool IsReservedWord(string name)
	{
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				AddReservedWord(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A47D83));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass5_.trimedName = (string)iDY8OhWkrapQ8wD8Tmxa(name);
				num2 = 5;
				break;
			case 4:
				_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
				num2 = 3;
				break;
			case 3:
				if (reservedWords == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 5:
				return reservedWords.Any(_003C_003Ec__DisplayClass5_._003CIsReservedWord_003Eb__0);
			case 1:
				reservedWords = GetReservedWords() ?? new List<string>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected void AddReservedWord(string word)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				if (IsReservedWord(word))
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				reservedWords.Add(word);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void WMq4ogWkdKvyjbGZ6sEQ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool TpcDCZWkJ0fF0RsUlKoP()
	{
		return rZNnouWkMlX2A3MWQIWr == null;
	}

	internal static ExternalTransformationProvider oqhLoMWk9UXLYNfLEhow()
	{
		return rZNnouWkMlX2A3MWQIWr;
	}

	internal static object htUbh7WklTXotK6bDEyf(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static object iDY8OhWkrapQ8wD8Tmxa(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static object QpAXp8Wkgn4fXTFvsUEw(object P_0)
	{
		return ((ExternalTransformationProvider)P_0).QuoteReservedWordsSymbolStart;
	}

	internal static bool t8YtmpWk5VtyM0VmY3FT(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static bool OygyGsWkjxlUYqjtD6CZ(object P_0, object P_1)
	{
		return ((ExternalTransformationProvider)P_0).IsReservedWord((string)P_1);
	}

	internal static bool mmJP4oWkYH4LBeYWiwka(object P_0)
	{
		return ((string)P_0).IsValidIdentifier();
	}

	internal static object cMlagSWkLa9ShOGaGaOV(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object UUZ8SjWkUlS9m2tSDIix(object P_0)
	{
		return ((ExternalTransformationProvider)P_0).QuoteReservedWordsSymbolEnd;
	}

	internal static object xhuT9YWksiPO6GsQO0vM(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}
}
