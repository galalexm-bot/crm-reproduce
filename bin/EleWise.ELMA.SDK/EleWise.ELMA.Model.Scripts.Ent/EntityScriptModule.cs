using System;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Scripts.Entities;

public abstract class EntityScriptModule<TEntity> : NHManager, IManager where TEntity : IEntity
{
	protected static class Logger
	{
		public static ILogger Log => ScriptLogger.Log;
	}

	private static object oiIuTCbP1jHWYQsO3MLp;

	[Obsolete]
	protected ScriptBase.LoggerClass get_Logger()
	{
		return ScriptBase.LoggerClass.Instance;
	}

	protected EntityScriptModule()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool INCIRPbPN6jySq0N0nES()
	{
		return oiIuTCbP1jHWYQsO3MLp == null;
	}

	internal static object y360v1bP3WPw9v1ap2cg()
	{
		return oiIuTCbP1jHWYQsO3MLp;
	}
}
