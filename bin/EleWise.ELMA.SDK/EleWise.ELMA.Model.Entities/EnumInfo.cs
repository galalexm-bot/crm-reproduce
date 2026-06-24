using System;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Entities;

[Serializable]
public sealed class EnumInfo
{
	internal static EnumInfo h8hFfeh8ZxFalfweoSX8;

	public Guid Uid
	{
		[CompilerGenerated]
		get
		{
			return _003CUid_003Ek__BackingField;
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
					_003CUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
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

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string DisplayName
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
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

	public int? IntValue { get; set; }

	public string Serialize()
	{
		return (string)t9VPTDh8Vjed5JDlEXb8(new JsonSerializer(), this);
	}

	public static EnumInfo Deserialize(string serialized)
	{
		return new JsonSerializer().Deserialize<EnumInfo>(serialized);
	}

	public EnumInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		i5SERZh8SW1Gu67DcKRs();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool afj1afh8u7nHKmeTJZs5()
	{
		return h8hFfeh8ZxFalfweoSX8 == null;
	}

	internal static EnumInfo aom4Iwh8IliPOSFnHpaW()
	{
		return h8hFfeh8ZxFalfweoSX8;
	}

	internal static object t9VPTDh8Vjed5JDlEXb8(object P_0, object P_1)
	{
		return ((JavaScriptSerializer)P_0).Serialize(P_1);
	}

	internal static void i5SERZh8SW1Gu67DcKRs()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
