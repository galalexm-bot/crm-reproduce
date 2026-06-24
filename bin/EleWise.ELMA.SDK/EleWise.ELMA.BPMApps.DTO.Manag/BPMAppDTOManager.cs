using System.Collections.Generic;
using EleWise.ELMA.BPMApps.DTO.Models;
using EleWise.ELMA.BPMApps.Services;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.BPMApps.DTO.Managers;

public class BPMAppDTOManager : DTOManager, IBPMAppDTOManager, IConfigurationService
{
	private readonly IBpmAppService bpmAppService;

	internal static BPMAppDTOManager Uve4QjfnrlHBf5GN1TbX;

	public BPMAppDTOManager(IBpmAppService bpmAppService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
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
				this.bpmAppService = bpmAppService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public virtual IEnumerable<BPMAppDTO> LoadAll()
	{
		return bpmAppService.LoadAll();
	}

	public virtual BPMAppDTO Save(BPMAppDTO bpmApp, byte[] helpFileContent, byte[] additionalFilesContent)
	{
		return bpmAppService.Save(bpmApp, helpFileContent, additionalFilesContent);
	}

	public virtual BPMAppDTO Save(BPMAppDTO bpmApp)
	{
		return (BPMAppDTO)x9sLnvfnjMZaODjesl7h(bpmAppService, bpmApp);
	}

	public virtual void Delete(long id)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				PxXjdLfnYdx97Ej2mhIA(bpmAppService, id);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual void LoadFiles(long id, out byte[] helpFileContent, out byte[] additionalFilesContent)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				bpmAppService.LoadFiles(id, out helpFileContent, out additionalFilesContent);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool yOHBdUfng6c1ZF6jka5G()
	{
		return Uve4QjfnrlHBf5GN1TbX == null;
	}

	internal static BPMAppDTOManager oGuRF0fn51QQxkuVFRHG()
	{
		return Uve4QjfnrlHBf5GN1TbX;
	}

	internal static object x9sLnvfnjMZaODjesl7h(object P_0, object P_1)
	{
		return ((IBpmAppService)P_0).Save((BPMAppDTO)P_1);
	}

	internal static void PxXjdLfnYdx97Ej2mhIA(object P_0, long id)
	{
		((IBpmAppService)P_0).Delete(id);
	}
}
