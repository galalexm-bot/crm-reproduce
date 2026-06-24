using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Modules.Attributes;

[AttributeUsage(AttributeTargets.Assembly)]
public class ModuleTitleAttribute : Attribute
{
	private string title;

	private static ModuleTitleAttribute QmMARRaIuukceTMBVTZ;

	public string Title => title;

	public ModuleTitleAttribute(string title)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ckpTnwai04tZqKHMhvf();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
		{
			num = 0;
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
				this.title = title;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void ckpTnwai04tZqKHMhvf()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool MbVT72aVDiPxk5Wnr6Z()
	{
		return QmMARRaIuukceTMBVTZ == null;
	}

	internal static ModuleTitleAttribute dPY57RaSDycM8x6JuCi()
	{
		return QmMARRaIuukceTMBVTZ;
	}
}
