using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ComponentModel;

[AttributeUsage(AttributeTargets.All)]
public sealed class UsedImplicitlyAttribute : Attribute
{
	private static UsedImplicitlyAttribute JI8P4LfftpIMGJXI4OCI;

	public ImplicitUseKindFlags UseKindFlags
	{
		[CompilerGenerated]
		get
		{
			return _003CUseKindFlags_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CUseKindFlags_003Ek__BackingField = value;
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

	public ImplicitUseTargetFlags TargetFlags
	{
		[CompilerGenerated]
		get
		{
			return _003CTargetFlags_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CTargetFlags_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
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

	public UsedImplicitlyAttribute()
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		yFCQfTff6vr4D5iCwupK();
		this._002Ector(useKindFlags, ImplicitUseTargetFlags.Default);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(ImplicitUseKindFlags.Default, targetFlags);
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

	public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		yFCQfTff6vr4D5iCwupK();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				UseKindFlags = useKindFlags;
				num = 2;
				break;
			case 2:
				TargetFlags = targetFlags;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	internal static bool t8PpI0ffwwpQ4v4DmbIk()
	{
		return JI8P4LfftpIMGJXI4OCI == null;
	}

	internal static UsedImplicitlyAttribute YPCGfXff4E5dn1PMAkLL()
	{
		return JI8P4LfftpIMGJXI4OCI;
	}

	internal static void yFCQfTff6vr4D5iCwupK()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
