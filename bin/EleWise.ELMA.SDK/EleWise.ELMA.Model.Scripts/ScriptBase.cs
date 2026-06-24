using System;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Scripts;

public class ScriptBase : IScriptBaseInitializer
{
	protected static class Logger
	{
		public static ILogger Log => (ILogger)tRi2rhC1RE6DBqff9hmO();

		internal static object tRi2rhC1RE6DBqff9hmO()
		{
			return ScriptLogger.Log;
		}
	}

	[Obsolete]
	public class LoggerClass
	{
		internal static readonly LoggerClass Instance;

		internal static LoggerClass YG58IkC1qA6U1yqhXAIS;

		public ILogger Log => (ILogger)c98jx6C1TgyVKrn0opQ0();

		public LoggerClass()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static LoggerClass()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					MtHNFAC1kcd9JcpDj4Jc();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					Instance = new LoggerClass();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return;
				}
			}
		}

		internal static object c98jx6C1TgyVKrn0opQ0()
		{
			return ScriptLogger.Log;
		}

		internal static bool l0evO7C1KMFIQhRkr3vU()
		{
			return YG58IkC1qA6U1yqhXAIS == null;
		}

		internal static LoggerClass R2gvE4C1XvNJeAX8MHu5()
		{
			return YG58IkC1qA6U1yqhXAIS;
		}

		internal static void MtHNFAC1kcd9JcpDj4Jc()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private IScriptConsole console;

	private bool isDebug;

	internal static ScriptBase zG9etfbi6OsY27I6DRNn;

	public IScriptConsole Console => console;

	public bool IsDebug => isDebug;

	void IScriptBaseInitializer.SetConsole(IScriptConsole console)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 3:
					if (console != null)
					{
						break;
					}
					goto end_IL_0012;
				case 1:
					return;
				}
				this.console = console;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	void IScriptBaseInitializer.SetIsDebug(bool isDebug)
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
				this.isDebug = isDebug;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[Obsolete]
	protected LoggerClass get_Logger()
	{
		return LoggerClass.Instance;
	}

	public ScriptBase()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		CA3w8Sbi7UHs10u8EmTo();
		console = new ScriptConsoleStub();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool I53Au7biHu8vwH9Md3mt()
	{
		return zG9etfbi6OsY27I6DRNn == null;
	}

	internal static ScriptBase LbFaFWbiAGbtSMSMcoyD()
	{
		return zG9etfbi6OsY27I6DRNn;
	}

	internal static void CA3w8Sbi7UHs10u8EmTo()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
