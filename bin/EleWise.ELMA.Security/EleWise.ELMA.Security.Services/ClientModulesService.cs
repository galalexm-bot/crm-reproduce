using System;
using System.Collections.Generic;
using EleWise.ELMA.API;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models.API;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Services.API;

[Service(Type = ComponentType.Server)]
internal class ClientModulesService : IClientModulesService
{
	private readonly ClientSessionDataSetsManager sessionDataSetsManager;

	internal static ClientModulesService U7AAy7CoAvSWVa47abQ;

	public ClientModulesService(ClientSessionDataSetsManager sessionDataSetsManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		YnGS4CCty7fLhaLIpe7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da != 0)
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
			this.sessionDataSetsManager = sessionDataSetsManager;
			num = 1;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d133bac4622e4b5596f3c44ee791169d != 0)
			{
				num = 1;
			}
		}
	}

	public EleWise.ELMA.API.Models.IClientSessionDataSets GetSessionModules(string sessionToken)
	{
		return (EleWise.ELMA.API.Models.IClientSessionDataSets)zdjmoRChmJVI7EWojXn(sessionDataSetsManager, sessionToken);
	}

	public bool UpdateDataSets(string sessionToken, List<Guid> dataSets)
	{
		if (sessionToken == null || sessionToken.Length != 128)
		{
			return false;
		}
		EleWise.ELMA.Security.Models.API.IClientSessionDataSets clientSessionDataSets = sessionDataSetsManager.FindByToken(sessionToken);
		if (dataSets != null && dataSets.Count > 0)
		{
			if (clientSessionDataSets == null)
			{
				InstanceOf<EleWise.ELMA.Security.Models.API.IClientSessionDataSets> instanceOf = new InstanceOf<EleWise.ELMA.Security.Models.API.IClientSessionDataSets>();
				instanceOf.New.SessionToken = sessionToken;
				clientSessionDataSets = instanceOf.New;
			}
			clientSessionDataSets.DataSets = ((dataSets.Count > 0) ? dataSets : null);
			sessionDataSetsManager.Save(clientSessionDataSets);
		}
		else if (clientSessionDataSets != null)
		{
			sessionDataSetsManager.Delete(clientSessionDataSets);
		}
		return true;
	}

	internal static void YnGS4CCty7fLhaLIpe7()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool nCmxhBCJMLFbmgPuQ40()
	{
		return U7AAy7CoAvSWVa47abQ == null;
	}

	internal static ClientModulesService hPcAGSCK1RaNFQGm5SH()
	{
		return U7AAy7CoAvSWVa47abQ;
	}

	internal static object zdjmoRChmJVI7EWojXn(object P_0, object P_1)
	{
		return ((ClientSessionDataSetsManager)P_0).FindByToken((string)P_1);
	}
}
