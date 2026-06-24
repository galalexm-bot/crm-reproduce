using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts.Manager;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Scripts.Entities;

[Component]
public abstract class BaseMetadataUpdateDataHandler : IMetadataUpdateDataHandler
{
	protected readonly ScriptModuleManager ScriptModuleManager;

	internal static BaseMetadataUpdateDataHandler UI38Shb2EBHUG5mNVW1b;

	public BaseMetadataUpdateDataHandler(ScriptModuleManager scriptModuleManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		OkP98Eb2COJQeOgaaQ08();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				ScriptModuleManager = scriptModuleManager;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public abstract bool Check(IMetadata metadata);

	public virtual IEnumerable<ScriptModule> GetScriptModules(IMetadataUpdateResult updateResult)
	{
		return Enumerable.Empty<ScriptModule>();
	}

	public virtual IEnumerable<Guid> GetFormUids(IMetadataUpdateResult updateResult)
	{
		return Enumerable.Empty<Guid>();
	}

	internal static void OkP98Eb2COJQeOgaaQ08()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool G0Qr5Hb2fGr7UlYRVg4I()
	{
		return UI38Shb2EBHUG5mNVW1b == null;
	}

	internal static BaseMetadataUpdateDataHandler iKTDwPb2QSNg8vK53S49()
	{
		return UI38Shb2EBHUG5mNVW1b;
	}
}
