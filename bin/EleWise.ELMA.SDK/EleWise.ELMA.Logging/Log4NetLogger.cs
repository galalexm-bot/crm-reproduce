using System;
using System.Globalization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using log4net;
using log4net.Core;
using log4net.Repository;
using log4net.Util;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Logging;

[Serializable]
internal class Log4NetLogger : MarshalByRefObject, ILogger
{
	private static readonly Type DeclaringType;

	private static readonly Type DefaultCallerType;

	private readonly ILogger logger;

	private static readonly Lazy<ILogger> Instance;

	internal static Log4NetLogger yIoIKOhd7iS5X804JP0W;

	public static ILogger DefaultInstance
	{
		get
		{
			//Discarded unreachable code: IL_004e, IL_0080, IL_00bc, IL_00cb
			ILogger logger = default(ILogger);
			switch (1)
			{
			default:
				return logger;
			case 1:
				try
				{
					logger = Instance.Value;
					int num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num = 0;
					}
					return num switch
					{
						0 => logger, 
						_ => logger, 
					};
				}
				catch
				{
					int num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 0;
					}
					while (true)
					{
						switch (num2)
						{
						case 1:
							return logger;
						}
						logger = new NullLogger();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
						{
							num2 = 1;
						}
					}
				}
			}
		}
	}

	public event EventHandler ConfigurationChanged
	{
		add
		{
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected O, but got Unknown
			int num = 3;
			int num2 = num;
			_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = default(_003C_003Ec__DisplayClass14_0);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					_003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					sImVEkhd51Z3YaoPeb9r(isOO2NhdgvXMDFRPkO1L(logger), (object)new LoggerRepositoryConfigurationChangedEventHandler(_003C_003Ec__DisplayClass14_._003Cadd_ConfigurationChanged_003Eb__0));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					_003C_003Ec__DisplayClass14_.value = value;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				}
			}
		}
		remove
		{
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Expected O, but got Unknown
			int num = 2;
			int num2 = num;
			_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_0);
			while (true)
			{
				switch (num2)
				{
				case 2:
					_003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					_003C_003Ec__DisplayClass15_.value = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					krPItrhdjAIAPb6gPM2R(isOO2NhdgvXMDFRPkO1L(logger), (object)new LoggerRepositoryConfigurationChangedEventHandler(_003C_003Ec__DisplayClass15_._003Cremove_ConfigurationChanged_003Eb__0));
					num2 = 3;
					break;
				case 3:
					return;
				}
			}
		}
	}

	static Log4NetLogger()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 4:
				DefaultCallerType = typeof(LoggingExtensions);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				DeclaringType = dlUFBLhdyp4gUyfGkkru(typeof(Log4NetLogger).TypeHandle);
				num2 = 4;
				break;
			case 2:
				Instance = new Lazy<ILogger>(() => new Log4NetFactory().CreateLogger(_003C_003Ec.jXAEnCvHPcCjbGYsd3R6(typeof(Logger).TypeHandle)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				nWL3brhdmDapZ2oNiPd5();
				num2 = 2;
				break;
			}
		}
	}

	internal Log4NetLogger()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		nWL3brhdmDapZ2oNiPd5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public Log4NetLogger(ILogger logger)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		nWL3brhdmDapZ2oNiPd5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
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
			this.logger = logger;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
			{
				num = 1;
			}
		}
	}

	internal Log4NetLogger(ILog log)
	{
		//Discarded unreachable code: IL_0030, IL_0035
		nWL3brhdmDapZ2oNiPd5();
		this._002Ector(((ILoggerWrapper)log).get_Logger());
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Level GetLevel(LogLevel level)
	{
		//Discarded unreachable code: IL_0099, IL_00a8
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return Level.Verbose;
			default:
				return Level.All;
			case 1:
				{
					switch (level)
					{
					case LogLevel.Verbose:
						break;
					case LogLevel.Trace:
						return Level.Trace;
					case LogLevel.Debug:
						return Level.Debug;
					case LogLevel.Information:
						return Level.Info;
					case LogLevel.Warning:
						return Level.Warn;
					case LogLevel.Error:
						return Level.Error;
					case LogLevel.Fatal:
						return Level.Fatal;
					default:
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num2 = 0;
						}
						goto end_IL_0012;
					}
					goto case 2;
				}
				end_IL_0012:
				break;
			}
		}
	}

	public bool IsEnabled(LogLevel level)
	{
		return G7MEWshdM662KBHYltXC(logger, GetLevel(level));
	}

	public void Log(LogLevel level, Exception exception, string format, params object[] args)
	{
		//Discarded unreachable code: IL_008b, IL_00a7
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		int num = 7;
		int num2 = num;
		Type value = default(Type);
		while (true)
		{
			switch (num2)
			{
			default:
				ContextVars.TryGetValue<Type>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882358398), out value);
				num2 = 4;
				continue;
			case 8:
				if (zOQcSphdJw1ka7L2hZYr())
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 3:
				if (piaefChddMvUMynYvjLf(ComponentManager.Current) != 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 7:
				if (IsEnabled(level))
				{
					num2 = 6;
					continue;
				}
				return;
			case 5:
				return;
			case 1:
				if (((ComponentManager)DtueSxhd94AenMIi76KD()).Stage != ComponentManager.LifetimeStage.Disposed)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			case 2:
				return;
			case 6:
				value = DeclaringType;
				num2 = 8;
				continue;
			case 4:
				break;
			}
			logger.Log(value ?? DefaultCallerType, (Level)VsXPr9hdlTbdsp3aH0OB(level), (object)new SystemStringFormat((IFormatProvider)kAeT3VhdrjybIS5um6j8(), format, args), exception);
			num2 = 5;
		}
	}

	internal static bool dcFAA8hdxtrtYe9imr4Z()
	{
		return yIoIKOhd7iS5X804JP0W == null;
	}

	internal static Log4NetLogger Ei6vfZhd0FcMtxbJ6CQI()
	{
		return yIoIKOhd7iS5X804JP0W;
	}

	internal static void nWL3brhdmDapZ2oNiPd5()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type dlUFBLhdyp4gUyfGkkru(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool G7MEWshdM662KBHYltXC(object P_0, object P_1)
	{
		return ((ILogger)P_0).IsEnabledFor((Level)P_1);
	}

	internal static bool zOQcSphdJw1ka7L2hZYr()
	{
		return ComponentManager.Initialized;
	}

	internal static object DtueSxhd94AenMIi76KD()
	{
		return ComponentManager.Current;
	}

	internal static ComponentManager.LifetimeStage piaefChddMvUMynYvjLf(object P_0)
	{
		return ((ComponentManager)P_0).Stage;
	}

	internal static object VsXPr9hdlTbdsp3aH0OB(LogLevel level)
	{
		return GetLevel(level);
	}

	internal static object kAeT3VhdrjybIS5um6j8()
	{
		return CultureInfo.InvariantCulture;
	}

	internal static object isOO2NhdgvXMDFRPkO1L(object P_0)
	{
		return ((ILogger)P_0).get_Repository();
	}

	internal static void sImVEkhd51Z3YaoPeb9r(object P_0, object P_1)
	{
		((ILoggerRepository)P_0).add_ConfigurationChanged((LoggerRepositoryConfigurationChangedEventHandler)P_1);
	}

	internal static void krPItrhdjAIAPb6gPM2R(object P_0, object P_1)
	{
		((ILoggerRepository)P_0).remove_ConfigurationChanged((LoggerRepositoryConfigurationChangedEventHandler)P_1);
	}
}
