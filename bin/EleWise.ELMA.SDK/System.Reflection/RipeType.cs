using j3AmrhgkCleVTGdEwA;

namespace System.Reflection;

public class RipeType
{
	private string name;

	private string fullName;

	private Assembly assembly;

	internal static RipeType ArUZicGU8kUQ5g8bbB2;

	public Type Raw { get; }

	public string Name
	{
		get
		{
			int num = 1;
			int num2 = num;
			string text = default(string);
			string text2;
			while (true)
			{
				switch (num2)
				{
				default:
					text = (name = (string)pQieMiGzcfVThOf0IBt(Raw));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					text2 = name;
					if (text2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					text2 = text;
					break;
				}
				break;
			}
			return text2;
		}
	}

	public string FullName
	{
		get
		{
			int num = 1;
			int num2 = num;
			string text = default(string);
			string text2;
			while (true)
			{
				switch (num2)
				{
				default:
					text = (fullName = Raw.FullName);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					text2 = fullName;
					if (text2 != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					text2 = text;
					break;
				}
				break;
			}
			return text2;
		}
	}

	public Assembly Assembly
	{
		get
		{
			int num = 2;
			int num2 = num;
			Assembly assembly = default(Assembly);
			Assembly obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					assembly = (this.assembly = Raw.Assembly);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj = this.assembly;
					if ((object)obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					obj = assembly;
					break;
				}
				break;
			}
			return obj;
		}
	}

	internal RipeType(Type raw)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
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
				Raw = raw;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool z7pwsUGsurIIK4U6Xc7()
	{
		return ArUZicGU8kUQ5g8bbB2 == null;
	}

	internal static RipeType oHGDT9GcLFJWcOmmo5r()
	{
		return ArUZicGU8kUQ5g8bbB2;
	}

	internal static object pQieMiGzcfVThOf0IBt(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}
}
