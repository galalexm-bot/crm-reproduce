using System.Reflection;
using EleWise.ELMA.Events.Audit;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.Settings.Events;

public class GlobalSettingsEventArgs : AuditEventArgs
{
	protected PropertyInfo property;

	internal static GlobalSettingsEventArgs o8txwtWGwVyW5CJCdBrA;

	public string Name => (string)k93uXLWGHo4uYsyl39u1(property);

	public GlobalSettingsEventArgs(PropertyInfo property)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.property = property;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static bool jtJ4LkWG4auVeghSPSUH()
	{
		return o8txwtWGwVyW5CJCdBrA == null;
	}

	internal static GlobalSettingsEventArgs ybFGapWG6evOUQ7EyZgB()
	{
		return o8txwtWGwVyW5CJCdBrA;
	}

	internal static object k93uXLWGHo4uYsyl39u1(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}
}
