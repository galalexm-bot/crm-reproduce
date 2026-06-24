using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Manager;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Services.Impl;

[Service]
internal sealed class ScriptLoader : IScriptLoader
{
	private readonly ScriptModuleManager scriptModuleManager;

	internal static ScriptLoader orxC5dBMFlJmJXaEavyE;

	public ScriptLoader(ScriptModuleManager scriptModuleManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		NcJ1j2BMoT1bI4B0jy3H();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.scriptModuleManager = scriptModuleManager;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public ScriptModule GetScript(Guid? uid)
	{
		if (!uid.HasValue)
		{
			return null;
		}
		return scriptModuleManager.Load(uid.Value);
	}

	internal static void NcJ1j2BMoT1bI4B0jy3H()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool HHq2MjBMBPot7e4iX6Lb()
	{
		return orxC5dBMFlJmJXaEavyE == null;
	}

	internal static ScriptLoader eBYvJGBMWr9GgJB9a6VB()
	{
		return orxC5dBMFlJmJXaEavyE;
	}
}
