using System;
using System.IO;
using j3AmrhgkCleVTGdEwA;
using log4net;
using log4net.Config;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Logging;

internal class Log4NetFactory : ILoggerFactory
{
	private static string configFile;

	internal static Log4NetFactory bPFNvKhdYbxRxsVP8Tjy;

	public Log4NetFactory()
	{
		//Discarded unreachable code: IL_0051, IL_0056
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(configFile ?? SR.GetSetting((string)yV7X5UhdsAxjtaN8ZEw4(-345420348 ^ -345318764)));
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public Log4NetFactory(string configFile)
	{
		//Discarded unreachable code: IL_001a, IL_001f, IL_0098
		Oy67OJhdchTaynEenbZP();
		base._002Ector();
		int num = 5;
		string text = default(string);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				return;
			case 4:
				QIdBx3hlBGyKWtq2sI21(new FileInfo(text));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num = 0;
				}
				break;
			case 1:
				if (!UX8j9XhlFigVMNOhudhu(text))
				{
					num = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num = 0;
					}
					break;
				}
				goto case 4;
			case 2:
				text = (string)RlsTF7hdzJ3ofifEcivy(configFile);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num = 1;
				}
				break;
			case 5:
				Log4NetFactory.configFile = configFile;
				num = 2;
				break;
			}
		}
	}

	public ILogger Create(string name)
	{
		return new Log4NetLogger((ILog)eDAoPlhlWPf2lOJ3TAlt(name));
	}

	public ILogger CreateLogger(string name)
	{
		return Create(name);
	}

	public ILogger CreateLogger(Type type)
	{
		return Create(type.FullName);
	}

	internal static object yV7X5UhdsAxjtaN8ZEw4(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool u9V3BThdLSFodBsqyXDJ()
	{
		return bPFNvKhdYbxRxsVP8Tjy == null;
	}

	internal static Log4NetFactory E03CaUhdUYECBZbkWc7C()
	{
		return bPFNvKhdYbxRxsVP8Tjy;
	}

	internal static void Oy67OJhdchTaynEenbZP()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object RlsTF7hdzJ3ofifEcivy(object P_0)
	{
		return Logger.GetConfigFile((string)P_0);
	}

	internal static bool UX8j9XhlFigVMNOhudhu(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object QIdBx3hlBGyKWtq2sI21(object P_0)
	{
		return XmlConfigurator.ConfigureAndWatch((FileInfo)P_0);
	}

	internal static object eDAoPlhlWPf2lOJ3TAlt(object P_0)
	{
		return LogManager.GetLogger((string)P_0);
	}
}
