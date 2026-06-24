using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Services;

public class FileWatcherEventArgs : EventArgs
{
	internal static FileWatcherEventArgs aqr63QBHaw8ShwNrLy1v;

	public string WatchPath
	{
		[CompilerGenerated]
		get
		{
			return _003CWatchPath_003Ek__BackingField;
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
					_003CWatchPath_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Path
	{
		[CompilerGenerated]
		get
		{
			return _003CPath_003Ek__BackingField;
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
					_003CPath_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public FileWatcherChangeTypes ChangeType
	{
		[CompilerGenerated]
		get
		{
			return _003CChangeType_003Ek__BackingField;
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
					_003CChangeType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public FileWatcherEventArgs(string watchPath, string path, FileWatcherChangeTypes changeType)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		GPxR8IBHw2KOXCdC82OC();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				WatchPath = watchPath;
				num = 3;
				break;
			case 3:
				Path = path;
				num = 2;
				break;
			case 0:
				return;
			case 2:
				ChangeType = changeType;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void GPxR8IBHw2KOXCdC82OC()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool rMxlBRBHDqGnFekjaoef()
	{
		return aqr63QBHaw8ShwNrLy1v == null;
	}

	internal static FileWatcherEventArgs Rq0NuIBHtFKZnmRvVHTO()
	{
		return aqr63QBHaw8ShwNrLy1v;
	}
}
