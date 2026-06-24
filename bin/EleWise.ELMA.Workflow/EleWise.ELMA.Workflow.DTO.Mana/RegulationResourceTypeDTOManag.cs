using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.DTO.Managers;

public class RegulationResourceTypeDTOManager : DTOManager, IRegulationResourceTypeDTOManager, IConfigurationService
{
	private static RegulationResourceTypeDTOManager bqaAa3eiCiabhi3qeDb;

	public static IRegulationResourceTypeDTOManager Instance => Locator.GetServiceNotNull<IRegulationResourceTypeDTOManager>();

	public virtual RegulationResourceTypeDTO Load(Guid uid)
	{
		return Mapper.Map<IRegulationResourceType, RegulationResourceTypeDTO>(EntityManager<IRegulationResourceType>.Instance.LoadOrNull(uid));
	}

	public virtual RegulationResourceTypeDTO Load(long id)
	{
		return Mapper.Map<IRegulationResourceType, RegulationResourceTypeDTO>(EntityManager<IRegulationResourceType>.Instance.LoadOrNull(id));
	}

	public virtual RegulationResourceTypeDTO Save(RegulationResourceTypeDTO resourceType)
	{
		IRegulationResourceType regulationResourceType = Mapper.Map<RegulationResourceTypeDTO, IRegulationResourceType>(resourceType);
		GGWqfAerRonRTTPHR8d(regulationResourceType);
		return Mapper.Map<IRegulationResourceType, RegulationResourceTypeDTO>(regulationResourceType);
	}

	public virtual List<RegulationResourceTypeDTO> LoadAll()
	{
		return ((IEnumerable<IRegulationResourceType>)EntityManager<IRegulationResourceType>.Instance.FindAll()).Select((Func<IRegulationResourceType, RegulationResourceTypeDTO>)Mapper.Map<IRegulationResourceType, RegulationResourceTypeDTO>).ToList();
	}

	public virtual bool Delete(long id)
	{
		int num = 1;
		int num2 = num;
		IRegulationResourceType regulationResourceType = default(IRegulationResourceType);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return false;
			case 3:
				return true;
			case 1:
				regulationResourceType = EntityManager<IRegulationResourceType>.Instance.LoadOrNull(id);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (regulationResourceType != null)
			{
				VtetE0eeqGTmIYij0KT(regulationResourceType);
				num2 = 3;
				continue;
			}
			num2 = 2;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
			{
				num2 = 2;
			}
		}
	}

	public virtual bool Delete(Guid uid)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 1;
		int num2 = num;
		IRegulationResourceType regulationResourceType = default(IRegulationResourceType);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return true;
			case 2:
				return false;
			case 4:
				VtetE0eeqGTmIYij0KT(regulationResourceType);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
				{
					num2 = 3;
				}
				break;
			default:
				if (regulationResourceType != null)
				{
					num2 = 4;
					break;
				}
				goto case 2;
			case 1:
				regulationResourceType = EntityManager<IRegulationResourceType>.Instance.LoadOrNull(uid);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public RegulationResourceTypeDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		NGCbKDeNSdLKX07hBQm();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool T9iGBweIIgnCXRE44WB()
	{
		return bqaAa3eiCiabhi3qeDb == null;
	}

	internal static RegulationResourceTypeDTOManager CHwqvheabxOoYstOCHA()
	{
		return bqaAa3eiCiabhi3qeDb;
	}

	internal static void GGWqfAerRonRTTPHR8d(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static void VtetE0eeqGTmIYij0KT(object P_0)
	{
		((IEntity)P_0).Delete();
	}

	internal static void NGCbKDeNSdLKX07hBQm()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
