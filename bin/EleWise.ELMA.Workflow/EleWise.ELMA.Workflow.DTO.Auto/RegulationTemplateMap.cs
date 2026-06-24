using System;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Files;
using EleWise.ELMA.Files.DTO.Models;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.AutoMaps;

public class RegulationTemplateMap : EntityDTOMap<IRegulationTemplate, RegulationTemplateDTO>
{
	internal static RegulationTemplateMap sUa0IcSY5LXJ8qLbsqy;

	protected override void InitMap(IMappingExpression<IRegulationTemplate, RegulationTemplateDTO> map)
	{
		base.InitMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(RegulationTemplateDTO), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75872B6 ^ 0x7592B1C));
		IMappingExpression<IRegulationTemplate, RegulationTemplateDTO> obj = map.ForMember<bool>(Expression.Lambda<Func<RegulationTemplateDTO, bool>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<IRegulationTemplate, RegulationTemplateDTO, bool>>)delegate(IMemberConfigurationExpression<IRegulationTemplate, RegulationTemplateDTO, bool> a)
		{
			a.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(RegulationTemplateDTO), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-14356676 ^ -14305642));
		IMappingExpression<IRegulationTemplate, RegulationTemplateDTO> obj2 = obj.ForMember<string>(Expression.Lambda<Func<RegulationTemplateDTO, string>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<IRegulationTemplate, RegulationTemplateDTO, string>>)delegate(IMemberConfigurationExpression<IRegulationTemplate, RegulationTemplateDTO, string> a)
		{
			a.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(RegulationTemplateDTO), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1386448964 ^ -1386402282));
		obj2.ForMember<BinaryFileDTO>(Expression.Lambda<Func<RegulationTemplateDTO, BinaryFileDTO>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<IRegulationTemplate, RegulationTemplateDTO, BinaryFileDTO>>)delegate(IMemberConfigurationExpression<IRegulationTemplate, RegulationTemplateDTO, BinaryFileDTO> a)
		{
			a.NullSubstitute((object)new BinaryFile
			{
				DeleteTempFileAfterSave = true
			});
		});
	}

	protected override void InitReverseMap(IMappingExpression<RegulationTemplateDTO, IRegulationTemplate> map)
	{
		base.InitReverseMap(map);
	}

	public RegulationTemplateMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool CAnAJOS8WymkvGPI0Kj()
	{
		return sUa0IcSY5LXJ8qLbsqy == null;
	}

	internal static RegulationTemplateMap JVFDfRSs0raJLWn3Ltm()
	{
		return sUa0IcSY5LXJ8qLbsqy;
	}
}
