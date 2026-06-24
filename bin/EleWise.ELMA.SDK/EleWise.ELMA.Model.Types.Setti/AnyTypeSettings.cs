using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Settings;

[Serializable]
public class AnyTypeSettings : TypeSettings
{
	internal static AnyTypeSettings apsLGQozdPX5kP1bCVAU;

	[PublicationBehaviour(PublicationType.Restart)]
	[DefaultValue("")]
	[XmlElement("FullTypeName")]
	public string FullTypeName
	{
		[CompilerGenerated]
		get
		{
			return _003CFullTypeName_003Ek__BackingField;
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
					_003CFullTypeName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public AnyTypeSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		o1lAqLozgZ7icPaSeiX4();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected AnyTypeSettings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		o1lAqLozgZ7icPaSeiX4();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override bool Equals(object obj)
	{
		int num = 2;
		int num2 = num;
		AnyTypeSettings anyTypeSettings = default(AnyTypeSettings);
		while (true)
		{
			switch (num2)
			{
			case 2:
				anyTypeSettings = obj as AnyTypeSettings;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (anyTypeSettings == null)
				{
					num2 = 3;
					break;
				}
				if (base.Equals(obj))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			case 3:
				return false;
			default:
				return VV0sCQozjQKPyO79aIvf(FullTypeName, vMtxLRoz5LIJwf3P2nC0(anyTypeSettings));
			}
		}
	}

	internal static void o1lAqLozgZ7icPaSeiX4()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool SaBUyvozlTmPPwPxAKI3()
	{
		return apsLGQozdPX5kP1bCVAU == null;
	}

	internal static AnyTypeSettings nbaxDqozr6HGAWCELxXq()
	{
		return apsLGQozdPX5kP1bCVAU;
	}

	internal static object vMtxLRoz5LIJwf3P2nC0(object P_0)
	{
		return ((AnyTypeSettings)P_0).FullTypeName;
	}

	internal static bool VV0sCQozjQKPyO79aIvf(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}
}
