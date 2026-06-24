using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.Db;

public class PrimaryKeysCreatingEventArgs : EventArgs
{
	private static PrimaryKeysCreatingEventArgs D5CWjEWiEN35hmuSsnqa;

	public bool SkipCreateKeys
	{
		[CompilerGenerated]
		get
		{
			return _003CSkipCreateKeys_003Ek__BackingField;
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
					_003CSkipCreateKeys_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PrimaryKeysCreatingEventArgs()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
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

	internal static bool lvKjj5WifkQxe2xwf4gp()
	{
		return D5CWjEWiEN35hmuSsnqa == null;
	}

	internal static PrimaryKeysCreatingEventArgs GjVIKDWiQeyZi0nX7rk4()
	{
		return D5CWjEWiEN35hmuSsnqa;
	}
}
