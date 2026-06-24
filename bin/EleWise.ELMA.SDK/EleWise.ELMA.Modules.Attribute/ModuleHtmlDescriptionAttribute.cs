using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Modules.Attributes;

[AttributeUsage(AttributeTargets.Assembly)]
public class ModuleHtmlDescriptionAttribute : Attribute
{
	private string description;

	private static ModuleHtmlDescriptionAttribute mRgBMDavVgjYGH6Qpgy;

	public string Description => description;

	public ModuleHtmlDescriptionAttribute(string description)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Txkns0aupJI23fx5n50();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.description = description;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
			{
				num = 1;
			}
		}
	}

	internal static void Txkns0aupJI23fx5n50()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool jjdmvXa8qdhy77H3uNx()
	{
		return mRgBMDavVgjYGH6Qpgy == null;
	}

	internal static ModuleHtmlDescriptionAttribute Xr53ecaZuvPeNWZsw3m()
	{
		return mRgBMDavVgjYGH6Qpgy;
	}
}
