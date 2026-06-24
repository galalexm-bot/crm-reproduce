using System;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.UI.DTO.Models;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.DTO.AutoMaps;

public class FormMetadataItemMap : EntityDTOMap<IFormMetadataItem, FormMetadataItemDTO>
{
	private static FormMetadataItemMap n95dXc9WOeDwiiIp8bJ;

	protected override void InitMap(IMappingExpression<IFormMetadataItem, FormMetadataItemDTO> map)
	{
		base.InitMap(map);
	}

	protected override void InitReverseMap(IMappingExpression<FormMetadataItemDTO, IFormMetadataItem> map)
	{
		base.InitReverseMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IFormMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521228044));
		map.ForMember<long?>(Expression.Lambda<Func<IFormMetadataItem, long?>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<FormMetadataItemDTO, IFormMetadataItem, long?>>)delegate(IMemberConfigurationExpression<FormMetadataItemDTO, IFormMetadataItem, long?> p)
		{
			p.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(IFormMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463AA398));
		map.ForMember<DateTime>(Expression.Lambda<Func<IFormMetadataItem, DateTime>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<FormMetadataItemDTO, IFormMetadataItem, DateTime>>)delegate(IMemberConfigurationExpression<FormMetadataItemDTO, IFormMetadataItem, DateTime> a)
		{
			a.Ignore();
		});
	}

	public FormMetadataItemMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool U7PBNS9ojv0WgMcPepA()
	{
		return n95dXc9WOeDwiiIp8bJ == null;
	}

	internal static FormMetadataItemMap SAbJsQ9britqxPQUmK1()
	{
		return n95dXc9WOeDwiiIp8bJ;
	}
}
