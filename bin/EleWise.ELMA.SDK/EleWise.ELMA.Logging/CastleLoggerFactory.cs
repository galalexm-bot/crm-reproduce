using System;
using Castle.Core.Logging;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Logging;

internal class CastleLoggerFactory : ILoggerFactory
{
	private readonly ILoggerFactory castleLoggerFactory;

	private static CastleLoggerFactory rKjpAvhdKkWAVa8s48bP;

	public CastleLoggerFactory(ILoggerFactory castleLoggerFactory)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		xfq1eThdkZd2JjfMuu7m();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
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
			this.castleLoggerFactory = castleLoggerFactory;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
			{
				num = 1;
			}
		}
	}

	public ILogger CreateLogger(Type type)
	{
		return new CastleLogger((ILogger)wTDmOehdn53GCYvAE48x(castleLoggerFactory, type));
	}

	public ILogger CreateLogger(string name)
	{
		return new CastleLogger((ILogger)sL6RumhdOjpnZYk81kmq(castleLoggerFactory, name));
	}

	internal static void xfq1eThdkZd2JjfMuu7m()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool YDUGvchdXs99tIbfb0tA()
	{
		return rKjpAvhdKkWAVa8s48bP == null;
	}

	internal static CastleLoggerFactory feq2NHhdTsEUGN5y2Rdd()
	{
		return rKjpAvhdKkWAVa8s48bP;
	}

	internal static object wTDmOehdn53GCYvAE48x(object P_0, Type P_1)
	{
		return ((ILoggerFactory)P_0).Create(P_1);
	}

	internal static object sL6RumhdOjpnZYk81kmq(object P_0, object P_1)
	{
		return ((ILoggerFactory)P_0).Create((string)P_1);
	}
}
