using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Licensing.Impl;

public class LicenseInfo : ILicenseInfo, ITrialLicenseInfo
{
	private object _owner;

	internal static LicenseInfo sXQ0xP7lxeLKU4m6e4w;

	public LicenseStatus Status
	{
		[CompilerGenerated]
		get
		{
			return _003CStatus_003Ek__BackingField;
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
					_003CStatus_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
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

	public string Description
	{
		get
		{
			int num = 1;
			int num2 = num;
			LicenseStatus status = default(LicenseStatus);
			while (true)
			{
				switch (num2)
				{
				case 1:
					status = Status;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return status.ToString();
				}
			}
		}
	}

	public DateTime? TrialExpiration { get; set; }

	public byte LicenseType
	{
		[CompilerGenerated]
		get
		{
			return _003CLicenseType_003Ek__BackingField;
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
					_003CLicenseType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected object Owner => _owner;

	public LicenseInfo(object owner)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		wUSi6p75FBTBn9lxNIl();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
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
			_owner = owner;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
			{
				num = 0;
			}
		}
	}

	internal static void wUSi6p75FBTBn9lxNIl()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Senwh97rimhQuAbyXZj()
	{
		return sXQ0xP7lxeLKU4m6e4w == null;
	}

	internal static LicenseInfo uNepAN7gl8GyTZpiHqP()
	{
		return sXQ0xP7lxeLKU4m6e4w;
	}
}
