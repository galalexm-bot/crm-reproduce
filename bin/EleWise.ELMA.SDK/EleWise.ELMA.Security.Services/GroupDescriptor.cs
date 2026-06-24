using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Services;

public class GroupDescriptor
{
	private Guid uid;

	private string name;

	private string description;

	private static GroupDescriptor hVohvtBUz6pnkNK2m39J;

	public Guid Uid => uid;

	public string Name => name;

	public string Description => description;

	public GroupDescriptor(Guid uid, string name, string description)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		fVO9FPBsWqCwpcfR5wQk();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				this.uid = uid;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				this.name = name;
				num = 3;
				break;
			case 3:
				this.description = description;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void fVO9FPBsWqCwpcfR5wQk()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool THan3OBsFkPFNV6d5p5u()
	{
		return hVohvtBUz6pnkNK2m39J == null;
	}

	internal static GroupDescriptor xqydYdBsBsEEIRD9WOgV()
	{
		return hVohvtBUz6pnkNK2m39J;
	}
}
