using System;
using System.Collections.Generic;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Deploy.Import;

public class CustomActivityImportSaveActions : EntityImportSaveActions
{
	public static readonly Guid Uid;

	internal static CustomActivityImportSaveActions LIydijTdxRx9GVboJnu;

	public override bool IsSupported(Guid typeGuid)
	{
		return typeGuid == Uid;
	}

	public override void ExecSaveActions(IEntity entity, Dictionary<string, string> serviceData)
	{
		if (entity is ICustomActivity customActivity)
		{
			customActivity.CreationAuthor = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<IUser>();
		}
		base.ExecSaveActions(entity, serviceData);
	}

	public CustomActivityImportSaveActions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		PdZ0VnTkW43Z14P5exE();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d526d6cd8ea24dfca60f96f0f0be6307 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static CustomActivityImportSaveActions()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Uid = new Guid((string)VZsDkQTbT4IbgQc6CSq(-254800515 ^ -254771307));
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9bbeebf035a641e28535eada260bd583 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				PdZ0VnTkW43Z14P5exE();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9da417d3072c4857ad8a08ca0cf38980 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static bool fllQJfTj0OERkE15epu()
	{
		return LIydijTdxRx9GVboJnu == null;
	}

	internal static CustomActivityImportSaveActions uqaJr9TSeDUloixewv9()
	{
		return LIydijTdxRx9GVboJnu;
	}

	internal static void PdZ0VnTkW43Z14P5exE()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static object VZsDkQTbT4IbgQc6CSq(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
