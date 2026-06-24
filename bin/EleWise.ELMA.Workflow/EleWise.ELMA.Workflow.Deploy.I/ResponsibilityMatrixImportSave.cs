using System;
using System.Collections.Generic;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Deploy.Import;

public class ResponsibilityMatrixImportSaveActions : EntityImportSaveActions
{
	public static readonly Guid UID;

	internal static ResponsibilityMatrixImportSaveActions dMAvN4OODyOjjJv1YdqD;

	public override bool IsSupported(Guid typeGuid)
	{
		return tl48ZuOOLTybGONBBYUl(typeGuid, UID);
	}

	public override List<TestImportMessages> ExecPreSaveActions(IEntity entity, ImportEntityPreSaveData data)
	{
		IResponsibilityMatrixItem responsibilityMatrixItem = entity as IResponsibilityMatrixItem;
		long? num = null;
		if (responsibilityMatrixItem.WorkerId.HasValue)
		{
			_ = responsibilityMatrixItem.WorkerType;
			num = (responsibilityMatrixItem.WorkerId = GetCorrectWorkerId(responsibilityMatrixItem.WorkerId, data.ServiceData, responsibilityMatrixItem.WorkerType));
			return new List<TestImportMessages>();
		}
		return new List<TestImportMessages>();
	}

	private long? GetCorrectWorkerId(long? workerId, Dictionary<string, string> serviceData, Guid workerType)
	{
		Guid guid = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xB7793C9 ^ 0xB76ECF1));
		Guid guid2 = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x438A0E43 ^ 0x438B71C7));
		if (!workerId.HasValue)
		{
			return null;
		}
		if (workerType == guid)
		{
			string key = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-947937941 ^ -947981715) + workerId;
			if (serviceData.ContainsKey(key) && Guid.TryParse(serviceData[key], out var result))
			{
				return Locator.GetServiceNotNull<OrganizationItemManager>().LoadOrNull(result)?.Id;
			}
		}
		if (workerType == guid2)
		{
			string key2 = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xF400DF8 ^ 0xF4162E2) + workerId;
			if (serviceData.ContainsKey(key2) && Guid.TryParse(serviceData[key2], out var result2))
			{
				return Locator.GetServiceNotNull<UserGroupManager>().LoadOrNull(result2)?.Id;
			}
		}
		return null;
	}

	public ResponsibilityMatrixImportSaveActions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		lfUGZVOOfHuohKKtoPD8();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ResponsibilityMatrixImportSaveActions()
	{
		int num = 2;
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
				UID = new Guid((string)U3ZIiQOO9dfDuBpm3axh(0x1843E01F ^ 0x18429FCF));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				lfUGZVOOfHuohKKtoPD8();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool tl48ZuOOLTybGONBBYUl(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool LX9NvfOOnZtu2BoAGOxu()
	{
		return dMAvN4OODyOjjJv1YdqD == null;
	}

	internal static ResponsibilityMatrixImportSaveActions nTRBElOOHpRKBcXs6rsD()
	{
		return dMAvN4OODyOjjJv1YdqD;
	}

	internal static void lfUGZVOOfHuohKKtoPD8()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object U3ZIiQOO9dfDuBpm3axh(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
