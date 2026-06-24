using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Globalization;

internal class Block
{
	private int _msgidhash;

	private string _msgid;

	private static Block I02X3bGEOIxoti3YSvpk;

	public List<string> Comments { get; set; }

	public List<string> MsgId { get; set; }

	public List<string> MsgStr { get; set; }

	public int MsgIdHash => _msgidhash;

	public bool IsJsBlock
	{
		[CompilerGenerated]
		get
		{
			return _003CIsJsBlock_003Ek__BackingField;
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
					_003CIsJsBlock_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
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

	public Block()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				MsgId = new List<string>();
				num = 2;
				break;
			default:
				Comments = new List<string>();
				num = 3;
				break;
			case 1:
				return;
			case 2:
				MsgStr = new List<string>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void MsgIdHashRecalc(string s)
	{
		int num = 3;
		int num2 = num;
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				if (num4 == num3)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 5;
					}
					continue;
				}
				break;
			case 3:
				num4 = tDRSxdGEPhfjlPk91ecd(s, '"');
				num2 = 2;
				continue;
			case 6:
				return;
			case 5:
				num3 = s.Length - 1;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 4;
				}
				continue;
			case 1:
				_msgidhash = _msgid.GetHashCode();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 6;
				}
				continue;
			case 2:
				num3 = s.LastIndexOf('"');
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				break;
			}
			_msgid += (string)PRtolBGE1stu5TTOBhj9(s, num4 + 1, num3 - num4 - 1);
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
			{
				num2 = 1;
			}
		}
	}

	internal static bool vO7BcnGE2M2dlx7tnqV2()
	{
		return I02X3bGEOIxoti3YSvpk == null;
	}

	internal static Block RUUTuTGEemnSiIpIgPAg()
	{
		return I02X3bGEOIxoti3YSvpk;
	}

	internal static int tDRSxdGEPhfjlPk91ecd(object P_0, char P_1)
	{
		return ((string)P_0).IndexOf(P_1);
	}

	internal static object PRtolBGE1stu5TTOBhj9(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}
}
