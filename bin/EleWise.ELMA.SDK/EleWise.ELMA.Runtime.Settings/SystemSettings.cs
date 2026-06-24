using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.Settings.Impl;

public class SystemSettings
{
	internal static SystemSettings dOJyuyWhUBoCSytIm6a8;

	public virtual Guid ModuleUid
	{
		[CompilerGenerated]
		get
		{
			return _003CModuleUid_003Ek__BackingField;
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
					_003CModuleUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
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

	public virtual string Key
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
				case 0:
					return;
				case 1:
					_003CKey_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual string Value
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
				case 1:
					_003CValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
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
		//Discarded unreachable code: IL_00b0, IL_00bf
		int num = 2;
		int num2 = num;
		SystemSettings systemSettings = default(SystemSettings);
		while (true)
		{
			switch (num2)
			{
			case 2:
				systemSettings = obj as SystemSettings;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return false;
			case 1:
				if (systemSettings != null)
				{
					if (!VLunZPWGFq2SW62ZGtbc(systemSettings.ModuleUid, WJXTAwWhzEAMZF5PlLZ3(this)))
					{
						num2 = 3;
						break;
					}
					goto case 4;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return (string)Bb04xXWGBlKRIqtj9kly(systemSettings) == (string)Bb04xXWGBlKRIqtj9kly(this);
			case 3:
				return false;
			}
		}
	}

	public override int GetHashCode()
	{
		int num = 1;
		int num2 = num;
		Guid guid = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 1:
				guid = WJXTAwWhzEAMZF5PlLZ3(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (guid.GetHashCode() * 397) ^ (Key ?? "").GetHashCode();
			}
		}
	}

	public SystemSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		As2ZaTWGWijTHQ4kCJ4w();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool jR6G64WhsyBmYqQS8MS4()
	{
		return dOJyuyWhUBoCSytIm6a8 == null;
	}

	internal static SystemSettings dCVCJHWhcDCcKdsSKaba()
	{
		return dOJyuyWhUBoCSytIm6a8;
	}

	internal static Guid WJXTAwWhzEAMZF5PlLZ3(object P_0)
	{
		return ((SystemSettings)P_0).ModuleUid;
	}

	internal static bool VLunZPWGFq2SW62ZGtbc(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object Bb04xXWGBlKRIqtj9kly(object P_0)
	{
		return ((SystemSettings)P_0).Key;
	}

	internal static void As2ZaTWGWijTHQ4kCJ4w()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
