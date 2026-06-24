using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Signatures;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Settings;

[Serializable]
public class ActionSettings : SimpleTypeSettings, IHasDefaultValue<ActionValue>
{
	private static ActionSettings dQXxCsoUmVg83LybIGqy;

	public TypeSignature ReturnType
	{
		[CompilerGenerated]
		get
		{
			return _003CReturnType_003Ek__BackingField;
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
					_003CReturnType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
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

	public TypeSignature ParameterType
	{
		[CompilerGenerated]
		get
		{
			return _003CParameterType_003Ek__BackingField;
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
					_003CParameterType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ActionValue DefaultValue
	{
		[CompilerGenerated]
		get
		{
			return _003CDefaultValue_003Ek__BackingField;
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
					_003CDefaultValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
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

	public ActionSettings()
	{
		//Discarded unreachable code: IL_004a, IL_004f
		WsECICoUJnud1LdMWFMu();
		ReturnType = new TypeSignature();
		ParameterType = new TypeSignature();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected ActionSettings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_004c, IL_0051
		WsECICoUJnud1LdMWFMu();
		ReturnType = new TypeSignature();
		ParameterType = new TypeSignature();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void WsECICoUJnud1LdMWFMu()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Ae3w3qoUyCkpuGG29cva()
	{
		return dQXxCsoUmVg83LybIGqy == null;
	}

	internal static ActionSettings Bk35lmoUMoA1qp1i6KjO()
	{
		return dQXxCsoUmVg83LybIGqy;
	}
}
