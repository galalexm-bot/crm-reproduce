using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata;

public class ReferencesToModule
{
	internal static ReferencesToModule BAqj7AbaFDTCOtU8SSQd;

	public Guid ModuleUid
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
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

	public List<LinkToModule> References { get; set; }

	public ReferencesToModule()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool sVivqVbaBvVTpmHEw2pC()
	{
		return BAqj7AbaFDTCOtU8SSQd == null;
	}

	internal static ReferencesToModule wxfQUNbaW7H6JJF9rWOm()
	{
		return BAqj7AbaFDTCOtU8SSQd;
	}
}
