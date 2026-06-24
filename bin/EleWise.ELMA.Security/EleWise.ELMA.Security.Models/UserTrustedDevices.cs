using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Models;

[Serializable]
public class UserTrustedDevices
{
	private static UserTrustedDevices WQlA84hPFSk5X8oM9nq;

	[DisplayName(typeof(UserTrustedDevices_SR), "TrustedLogonEnabled")]
	public bool LogonFromTrustedDevicesOnly
	{
		[CompilerGenerated]
		get
		{
			return _003CLogonFromTrustedDevicesOnly_003Ek__BackingField;
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
					_003CLogonFromTrustedDevicesOnly_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b700f854946b45dfa4de8ce28732acad == 0)
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

	public List<DeviceToken> Tokens { get; set; }

	public UserTrustedDevices()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		YQqp42hUmeuNcmalonJ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 != 0)
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
			Tokens = new List<DeviceToken>();
			num = 1;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 == 0)
			{
				num = 1;
			}
		}
	}

	internal static void YQqp42hUmeuNcmalonJ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool dyYwREhvLfo2NNa7u9Q()
	{
		return WQlA84hPFSk5X8oM9nq == null;
	}

	internal static UserTrustedDevices kK1YUVhC2hWRrIk3ZyB()
	{
		return WQlA84hPFSk5X8oM9nq;
	}
}
