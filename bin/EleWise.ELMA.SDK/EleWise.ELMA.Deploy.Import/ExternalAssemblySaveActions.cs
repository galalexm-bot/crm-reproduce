using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import;

public class ExternalAssemblySaveActions : EntityImportSaveActions
{
	public static readonly Guid Uid;

	private static ExternalAssemblySaveActions G0NdHyEmBusNZvVaoLnh;

	public override bool IsSupported(Guid typeGuid)
	{
		return PTOw8vEmbXg0XvB9OM1i(typeGuid, Uid);
	}

	public override void ExecSaveActions(IEntity entity, Dictionary<string, string> serviceData)
	{
		if (entity is IExternalAssembly externalAssembly)
		{
			IExternalAssemblyFilter externalAssemblyFilter = InterfaceActivator.Create<IExternalAssemblyFilter>();
			externalAssemblyFilter.HashCode = externalAssembly.HashCode;
			IExternalAssembly externalAssembly2 = ExternalAssemblyManager.Instance.Find(externalAssemblyFilter, null).FirstOrDefault();
			if (externalAssembly2 != null)
			{
				serviceData[externalAssembly.Uid.ToString()] = externalAssembly2.Uid.ToString();
				externalAssembly.Uid = externalAssembly2.Uid;
			}
		}
		base.ExecSaveActions(entity, serviceData);
	}

	public ExternalAssemblySaveActions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		v4jVtNEmhYuMG51G3ljJ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ExternalAssemblySaveActions()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				v4jVtNEmhYuMG51G3ljJ();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				Uid = new Guid((string)YpiAdWEmGTtTw3jsm4X8(0x31326106 ^ 0x3136C848));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool PTOw8vEmbXg0XvB9OM1i(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool n8qmNtEmWMt1xq22NBEY()
	{
		return G0NdHyEmBusNZvVaoLnh == null;
	}

	internal static ExternalAssemblySaveActions wOLoB5Emoev45ZaXj8vu()
	{
		return G0NdHyEmBusNZvVaoLnh;
	}

	internal static void v4jVtNEmhYuMG51G3ljJ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object YpiAdWEmGTtTw3jsm4X8(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
