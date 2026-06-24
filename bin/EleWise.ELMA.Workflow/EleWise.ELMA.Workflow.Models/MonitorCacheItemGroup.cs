using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models;

public class MonitorCacheItemGroup
{
	private static MonitorCacheItemGroup K3ieQZOXSMw4q85J1bT2;

	public IUser User
	{
		[CompilerGenerated]
		get
		{
			return _003CUser_003Ek__BackingField;
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
					_003CUser_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 != 0)
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

	public IProcessHeader ProcessHeader
	{
		[CompilerGenerated]
		get
		{
			return _003CProcessHeader_003Ek__BackingField;
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
					_003CProcessHeader_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid ActionUid
	{
		[CompilerGenerated]
		get
		{
			return _003CActionUid_003Ek__BackingField;
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
					_003CActionUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
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

	public override bool Equals(object obj)
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return true;
				case 1:
					return false;
				case 2:
					if (obj != null)
					{
						if (this != obj)
						{
							if (!smhJSnOXEUn3E8bPKldh(obj.GetType(), typeof(MonitorCacheItemGroup)))
							{
								return Equals((MonitorCacheItemGroup)obj);
							}
							goto end_IL_0012;
						}
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
						{
							num2 = 1;
						}
					}
					break;
				case 3:
					return false;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public bool Equals(MonitorCacheItemGroup obj)
	{
		//Discarded unreachable code: IL_00dc, IL_00eb
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return true;
			case 2:
				if (obj == null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (this != obj)
				{
					if (object.Equals(L8nns4OXwFphgHRZXWTR(obj), User))
					{
						num2 = 5;
						continue;
					}
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				if (!zaHknTOXz8NOoD6WwQNi(uOEVVDOX4shRRHGgxG4V(obj), ProcessHeader))
				{
					num2 = 4;
					continue;
				}
				goto case 3;
			case 1:
				return false;
			case 3:
				return zaHknTOXz8NOoD6WwQNi(SL21AIOdKNCFuXwIIovo(obj), ActionUid);
			case 4:
				break;
			}
			break;
		}
		return false;
	}

	public override int GetHashCode()
	{
		//Discarded unreachable code: IL_003e
		int num = 1;
		int num2 = num;
		int num3;
		while (true)
		{
			switch (num2)
			{
			default:
				num3 = typeof(IUser).GetHashCode() * 396;
				break;
			case 1:
				if (User == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
					{
						num2 = 0;
					}
					continue;
				}
				num3 = User.GetHashCode() * 396;
				break;
			}
			break;
		}
		int num4 = ((ProcessHeader != null) ? (ProcessHeader.GetHashCode() * 46) : (XiKNGMOdOAdvjVJrsVht(typeof(IProcessHeader).TypeHandle).GetHashCode() * 46));
		return num3 ^ num4 ^ ActionUid.GetHashCode();
	}

	public MonitorCacheItemGroup()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		omRZZcOdZKisAGBaAV2v();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool GsYbL5OX1S4R8lP316WA()
	{
		return K3ieQZOXSMw4q85J1bT2 == null;
	}

	internal static MonitorCacheItemGroup goPcwlOXhSG1GNRESuWV()
	{
		return K3ieQZOXSMw4q85J1bT2;
	}

	internal static bool smhJSnOXEUn3E8bPKldh(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object L8nns4OXwFphgHRZXWTR(object P_0)
	{
		return ((MonitorCacheItemGroup)P_0).User;
	}

	internal static object uOEVVDOX4shRRHGgxG4V(object P_0)
	{
		return ((MonitorCacheItemGroup)P_0).ProcessHeader;
	}

	internal static bool zaHknTOXz8NOoD6WwQNi(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static Guid SL21AIOdKNCFuXwIIovo(object P_0)
	{
		return ((MonitorCacheItemGroup)P_0).ActionUid;
	}

	internal static Type XiKNGMOdOAdvjVJrsVht(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void omRZZcOdZKisAGBaAV2v()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
