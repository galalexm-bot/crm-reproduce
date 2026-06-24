using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ComponentModel;

[AttributeUsage(AttributeTargets.Parameter)]
public sealed class PathReferenceAttribute : Attribute
{
	internal static PathReferenceAttribute I21uKpffchjGiSRcJwEs;

	public string BasePath
	{
		[CompilerGenerated]
		get
		{
			return _003CBasePath_003Ek__BackingField;
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
					_003CBasePath_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
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

	public PathReferenceAttribute()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		CTqGOhfQB1dyGUcRl9kk();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public PathReferenceAttribute([PathReference] string basePath)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		CTqGOhfQB1dyGUcRl9kk();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				BasePath = basePath;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void CTqGOhfQB1dyGUcRl9kk()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool JWOlRsffzwLCgswWvQt6()
	{
		return I21uKpffchjGiSRcJwEs == null;
	}

	internal static PathReferenceAttribute B5O9ECfQFgs3lBs0YXiv()
	{
		return I21uKpffchjGiSRcJwEs;
	}
}
