using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ComponentModel;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.GenericParameter)]
public sealed class MeansImplicitUseAttribute : Attribute
{
	internal static MeansImplicitUseAttribute KiOuFdffHQmPdORnijvn;

	[UsedImplicitly]
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
				case 1:
					_003CUseKindFlags_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
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

	[UsedImplicitly]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
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

	public MeansImplicitUseAttribute()
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		tjaVMkffxevT0c99DD3v();
		this._002Ector(useKindFlags, ImplicitUseTargetFlags.Default);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		tjaVMkffxevT0c99DD3v();
		this._002Ector(ImplicitUseKindFlags.Default, targetFlags);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		tjaVMkffxevT0c99DD3v();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
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
			case 1:
				return;
			case 2:
				TargetFlags = targetFlags;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static bool BH6drfffARxkYj1UfQAq()
	{
		return KiOuFdffHQmPdORnijvn == null;
	}

	internal static MeansImplicitUseAttribute WNkkdkff72Ljfi2GRn3J()
	{
		return KiOuFdffHQmPdORnijvn;
	}

	internal static void tjaVMkffxevT0c99DD3v()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
