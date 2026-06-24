using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Files;

[Serializable]
public sealed class StructuredFileFolder
{
	internal static StructuredFileFolder FKmm1WGKGvK7ueDDveY9;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<StructuredFileFolder> Folders { get; set; }

	public List<StructuredFileFile> Files { get; set; }

	public StructuredFileFolder()
	{
		//Discarded unreachable code: IL_004a, IL_004f
		OquG1uGKQh4kfJRPD73w();
		Folders = new List<StructuredFileFolder>();
		Files = new List<StructuredFileFile>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void OquG1uGKQh4kfJRPD73w()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool o4SMxlGKEcFKx4mgYIAt()
	{
		return FKmm1WGKGvK7ueDDveY9 == null;
	}

	internal static StructuredFileFolder k6YEXNGKfNU87WOeIAJ4()
	{
		return FKmm1WGKGvK7ueDDveY9;
	}
}
