using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Services;

[Service]
public class ConfigurationDirectoryFileWatcher : DirectoryFileWatcher
{
	internal static ConfigurationDirectoryFileWatcher GI90GNB6f7MZB5sZwhSk;

	public void Init(string configurationDirectory)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				InitWatcher(configurationDirectory);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				AddWatchPaths(configurationDirectory);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void ConfigurationDirectoryStopWatchingFiles(bool watching = true)
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
				StopWatchingFiles(watching);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ConfigurationDirectoryFileWatcher()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		MkjpxMB6v7dqH2J7k4Uk();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Q0iNDxB6Q8mrbFqpRjyQ()
	{
		return GI90GNB6f7MZB5sZwhSk == null;
	}

	internal static ConfigurationDirectoryFileWatcher kNGIBdB6CgwhoEAvC5Kb()
	{
		return GI90GNB6f7MZB5sZwhSk;
	}

	internal static void MkjpxMB6v7dqH2J7k4Uk()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
