using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
[XmlRoot("LinkToModule")]
public class LinkToModule
{
	internal static LinkToModule SDbfu0bpJDVkGX64hKZx;

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
				case 0:
					return;
				case 1:
					_003CModuleUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual string DisplayName
	{
		[CompilerGenerated]
		get
		{
			return _003CDisplayName_003Ek__BackingField;
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
					_003CDisplayName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
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

	public override string ToString()
	{
		return (string)ztmOGlbplumoAe6vFpEr(this);
	}

	public LinkToModule()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		XK4l2HbprfZNkECLvEoH();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Ik0M5tbp9qoHvpLJIH4H()
	{
		return SDbfu0bpJDVkGX64hKZx == null;
	}

	internal static LinkToModule yD0XUUbpdqiDmqTR9CnL()
	{
		return SDbfu0bpJDVkGX64hKZx;
	}

	internal static object ztmOGlbplumoAe6vFpEr(object P_0)
	{
		return ((LinkToModule)P_0).DisplayName;
	}

	internal static void XK4l2HbprfZNkECLvEoH()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
