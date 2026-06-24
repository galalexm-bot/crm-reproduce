using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Common;

[Serializable]
[TypeConverter(typeof(DropDownItemTypeConverter))]
[Component]
public class DropDownItem : IXsiType
{
	private static DropDownItem GebeIrhK02YtVIhLqw9L;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return _003CKey_003Ek__BackingField;
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
				case 1:
					_003CKey_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public string Value
	{
		[CompilerGenerated]
		get
		{
			return _003CValue_003Ek__BackingField;
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
					_003CValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string ToolTip
	{
		[CompilerGenerated]
		get
		{
			return _003CToolTip_003Ek__BackingField;
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
					_003CToolTip_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string ToolTipTitle
	{
		[CompilerGenerated]
		get
		{
			return _003CToolTipTitle_003Ek__BackingField;
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
				case 1:
					_003CToolTipTitle_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[XmlIgnore]
	public object DataTag
	{
		[CompilerGenerated]
		get
		{
			return _003CDataTag_003Ek__BackingField;
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
					_003CDataTag_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public DropDownItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		s1LfInhKMKT2UnEhbqa0();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public DropDownItem(string key, string value)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		s1LfInhKMKT2UnEhbqa0();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				Key = key;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num = 1;
				}
				break;
			case 1:
				Value = value;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public DropDownItem(string key, string value, string toolTipTitle, string toolTipText)
	{
		//Discarded unreachable code: IL_002a
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
		{
			num = 0;
		}
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				Key = key;
				num = 2;
				break;
			case 3:
				ToolTipTitle = toolTipTitle;
				num2 = 4;
				goto IL_002f;
			case 4:
				return;
			case 2:
				Value = value;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				{
					ToolTip = toolTipText;
					num2 = 3;
					goto IL_002f;
				}
				IL_002f:
				num = num2;
				break;
			}
		}
	}

	public DropDownItem(string stringValue)
	{
		//Discarded unreachable code: IL_001a, IL_0145
		s1LfInhKMKT2UnEhbqa0();
		base._002Ector();
		int num = 5;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 5:
				Key = null;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num = 4;
				}
				break;
			case 6:
				if (!V2XlqfhKJVGFi0kEc4HC(stringValue))
				{
					num = 9;
					break;
				}
				return;
			case 7:
				Value = stringValue;
				num = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			case 2:
				Value = stringValue;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num = 1;
				}
				break;
			case 4:
			{
				Value = "";
				int num3 = 6;
				num = num3;
				break;
			}
			case 11:
				return;
			case 0:
				return;
			case 8:
				if (num2 > 0)
				{
					Key = (string)dUjXGVhKlj3kxeZ8Kvk2(stringValue, 1, num2 - 1);
					num = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num = 10;
					}
				}
				else
				{
					num = 7;
				}
				break;
			case 3:
				return;
			case 9:
				if (SGSH2PhKdTpmi3LCTZ6Z(stringValue, ijtCgjhK9K95JfLNPUTC(-195614443 ^ -195616023)))
				{
					num2 = stringValue.IndexOf('}');
					num = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num = 1;
					}
				}
				else
				{
					num = 2;
				}
				break;
			case 10:
				Value = stringValue.Substring(num2 + 1);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public string GetLocalizedValue()
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!string.IsNullOrEmpty(Key))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return Value;
			default:
				return (string)Q95Np8hKrkVpmJ8L1tWq(Value);
			}
		}
	}

	public override string ToString()
	{
		//Discarded unreachable code: IL_0057, IL_0066, IL_007b
		int num = 1;
		int num2 = num;
		object obj;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!V2XlqfhKJVGFi0kEc4HC(Key))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 2;
			case 2:
				obj = string.Empty;
				break;
			default:
				obj = dWE5oRhKgr3LwDewch97(ijtCgjhK9K95JfLNPUTC(0x17ADCCD8 ^ 0x17ADC724), Key, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76DD89E));
				break;
			}
			break;
		}
		return (string)n1GZ2XhK5YgfdMyLARW6(obj, Value ?? string.Empty);
	}

	public override int GetHashCode()
	{
		return ToString().GetHashCode();
	}

	public override bool Equals(object obj)
	{
		int num = 1;
		int num2 = num;
		string text;
		while (true)
		{
			switch (num2)
			{
			default:
				return false;
			case 1:
				if (obj != null)
				{
					text = obj.ToString();
					if (text == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				text = string.Empty;
				break;
			}
			break;
		}
		return Df4dNAhKjn81yh1225MF(text, ToString());
	}

	internal static void s1LfInhKMKT2UnEhbqa0()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool yade7vhKmSdnT58rk47T()
	{
		return GebeIrhK02YtVIhLqw9L == null;
	}

	internal static DropDownItem QeT3dQhKyG3Cqlb50tcF()
	{
		return GebeIrhK02YtVIhLqw9L;
	}

	internal static bool V2XlqfhKJVGFi0kEc4HC(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object ijtCgjhK9K95JfLNPUTC(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool SGSH2PhKdTpmi3LCTZ6Z(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static object dUjXGVhKlj3kxeZ8Kvk2(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static object Q95Np8hKrkVpmJ8L1tWq(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object dWE5oRhKgr3LwDewch97(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object n1GZ2XhK5YgfdMyLARW6(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool Df4dNAhKjn81yh1225MF(object P_0, object P_1)
	{
		return ((string)P_0).Equals((string)P_1);
	}
}
