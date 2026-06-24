using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Scripts;

[Component]
internal abstract class FormMetadataUpdateDataHandler : IMetadataUpdateDataHandler
{
	private readonly FormMetadataItemHeaderManager formMetadataItemHeaderManager;

	internal static FormMetadataUpdateDataHandler ec5hQRlsR251611YlhP;

	protected FormMetadataUpdateDataHandler(FormMetadataItemHeaderManager formMetadataItemHeaderManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		tIW1ETrFJtLYZIkwG7n();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
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
				this.formMetadataItemHeaderManager = formMetadataItemHeaderManager;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public abstract bool Check(IMetadata metadata);

	public IEnumerable<ScriptModule> GetScriptModules(IMetadataUpdateResult updateResult)
	{
		CreateComponent(updateResult);
		IFormMetadataItemHeader formMetadataItemHeader = formMetadataItemHeaderManager.Load(updateResult.Metadata.Uid);
		if (formMetadataItemHeader.Draft.ScriptModule == null)
		{
			return new ScriptModule[0];
		}
		return new ScriptModule[1] { formMetadataItemHeader.Draft.ScriptModule };
	}

	public abstract IEnumerable<Guid> GetFormUids(IMetadataUpdateResult updateResult);

	protected abstract void CreateComponent(IMetadataUpdateResult updateResult);

	internal static void tIW1ETrFJtLYZIkwG7n()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool IIPtXhlcqYaERm6hvCc()
	{
		return ec5hQRlsR251611YlhP == null;
	}

	internal static FormMetadataUpdateDataHandler Cn821alzGA40EmW8uZJ()
	{
		return ec5hQRlsR251611YlhP;
	}
}
