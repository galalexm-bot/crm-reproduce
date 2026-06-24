using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Modules.Attributes;

[AttributeUsage(AttributeTargets.Assembly)]
public class ModuleAttribute : Attribute
{
	private string id;

	private Guid uid;

	private static ModuleAttribute NjhGBtaftS7q38fGlSi;

	public string Id => id;

	public Guid Uid => uid;

	public ModuleAttribute(string id, string uid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
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
			case 2:
				this.id = id;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				this.uid = new Guid(uid);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static bool llLRPsaQIRgZxZkIKpC()
	{
		return NjhGBtaftS7q38fGlSi == null;
	}

	internal static ModuleAttribute joGvD4aCx6Jg7C3NIUV()
	{
		return NjhGBtaftS7q38fGlSi;
	}
}
