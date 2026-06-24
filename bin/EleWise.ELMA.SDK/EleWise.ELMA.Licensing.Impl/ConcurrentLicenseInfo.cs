using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Licensing.Impl;

public class ConcurrentLicenseInfo : WorkplaceLicenseInfo, IConcurrentLicenseInfo, IWorkplaceLicenseInfo, ILicenseInfo
{
	private static ConcurrentLicenseInfo TJmRbK727B57KPHYg2i;

	public bool IsConcurrent
	{
		[CompilerGenerated]
		get
		{
			return _003CIsConcurrent_003Ek__BackingField;
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
					_003CIsConcurrent_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public uint? PrivilegeCount { get; set; }

	public uint UsedPrivilegeCount
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!(base.Owner is IConcurrentLicenseInfoOwner))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
						{
							num2 = 0;
						}
						break;
					}
					return baQjTo71sJntx6oslEK((IConcurrentLicenseInfoOwner)base.Owner);
				default:
					return 0u;
				}
			}
		}
	}

	public ConcurrentLicenseInfo(object owner)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(owner);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool W29s1c7eNJ7dMmKlqZx()
	{
		return TJmRbK727B57KPHYg2i == null;
	}

	internal static ConcurrentLicenseInfo nv90sb7PGdKw3TYGiGs()
	{
		return TJmRbK727B57KPHYg2i;
	}

	internal static uint baQjTo71sJntx6oslEK(object P_0)
	{
		return ((IConcurrentLicenseInfoOwner)P_0).UsedPrivilegeCount;
	}
}
