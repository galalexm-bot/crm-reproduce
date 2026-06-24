using System;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts.DTO.AutoMaps;

public class GlobalScriptModuleMap : EntityDTOMap<IGlobalScriptModule, GlobalScriptModuleDto>
{
	internal static GlobalScriptModuleMap UL4YFdbXKPtS0wD2irO9;

	protected override void InitMap(IMappingExpression<IGlobalScriptModule, GlobalScriptModuleDto> map)
	{
		base.InitMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(GlobalScriptModuleDto), z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7DF05C));
		map.ForMember<ProjectInfo>(Expression.Lambda<Func<GlobalScriptModuleDto, ProjectInfo>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<IGlobalScriptModule, GlobalScriptModuleDto, ProjectInfo>>)delegate(IMemberConfigurationExpression<IGlobalScriptModule, GlobalScriptModuleDto, ProjectInfo> a)
		{
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(IGlobalScriptModule), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA581A99));
			a.MapFrom<object>(Expression.Lambda<Func<IGlobalScriptModule, object>>(Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression2 }));
		});
	}

	protected override void InitReverseMap(IMappingExpression<GlobalScriptModuleDto, IGlobalScriptModule> map)
	{
		base.InitReverseMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IGlobalScriptModule), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106475680));
		map.ForMember<object>(Expression.Lambda<Func<IGlobalScriptModule, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<GlobalScriptModuleDto, IGlobalScriptModule, object>>)delegate(IMemberConfigurationExpression<GlobalScriptModuleDto, IGlobalScriptModule, object> a)
		{
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(GlobalScriptModuleDto), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138099791));
			a.MapFrom<ProjectInfo>(Expression.Lambda<Func<GlobalScriptModuleDto, ProjectInfo>>(Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression2 }));
		});
	}

	public GlobalScriptModuleMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vEsqWPbXkhWxbcxV3pKZ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void vEsqWPbXkhWxbcxV3pKZ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool R6D0FrbXXGg7TU1bRJaB()
	{
		return UL4YFdbXKPtS0wD2irO9 == null;
	}

	internal static GlobalScriptModuleMap w2VMfqbXTwRQy8VFkngF()
	{
		return UL4YFdbXKPtS0wD2irO9;
	}
}
