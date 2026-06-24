using System;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Models;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.AutoMaps;

public class CustomActivityFolderMap : EntityDTOMap<ICustomActivityFolder, CustomActivityFolderDTO>
{
	private static CustomActivityFolderMap mYZJU1P14Ggn4Mr6Pdc;

	protected override void InitMap(IMappingExpression<ICustomActivityFolder, CustomActivityFolderDTO> map)
	{
		base.InitMap(map);
	}

	protected override void InitReverseMap(IMappingExpression<CustomActivityFolderDTO, ICustomActivityFolder> map)
	{
		base.InitReverseMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(ICustomActivityFolder), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-275456087 ^ -275467737));
		map.ForMember<ISet<ICustomActivityHeader>>(Expression.Lambda<Func<ICustomActivityFolder, ISet<ICustomActivityHeader>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<CustomActivityFolderDTO, ICustomActivityFolder, ISet<ICustomActivityHeader>>>)delegate(IMemberConfigurationExpression<CustomActivityFolderDTO, ICustomActivityFolder, ISet<ICustomActivityHeader>> a)
		{
			a.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(ICustomActivityFolder), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882678999 ^ -882700633));
		map.ForMember<ISet<ICustomActivityFolder>>(Expression.Lambda<Func<ICustomActivityFolder, ISet<ICustomActivityFolder>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<CustomActivityFolderDTO, ICustomActivityFolder, ISet<ICustomActivityFolder>>>)delegate(IMemberConfigurationExpression<CustomActivityFolderDTO, ICustomActivityFolder, ISet<ICustomActivityFolder>> a)
		{
			a.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(ICustomActivityFolder), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882646278 ^ -882667660));
		map.ForMember<ICustomActivityFolder>(Expression.Lambda<Func<ICustomActivityFolder, ICustomActivityFolder>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<CustomActivityFolderDTO, ICustomActivityFolder, ICustomActivityFolder>>)delegate(IMemberConfigurationExpression<CustomActivityFolderDTO, ICustomActivityFolder, ICustomActivityFolder> a)
		{
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(CustomActivityFolderDTO), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1CF99A4A ^ 0x1CF9F7D4));
			a.MapFrom<ICustomActivityFolder>(Expression.Lambda<Func<CustomActivityFolderDTO, ICustomActivityFolder>>(Expression.Call(Expression.Property(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(EntityManager<ICustomActivityFolder>).TypeHandle)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntityManager<ICustomActivityFolder>).TypeHandle), Expression.Convert(Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object))), new ParameterExpression[1] { parameterExpression2 }));
		});
	}

	public CustomActivityFolderMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		qKnXurPzufgGWYqMebQ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13175fe1d68b47f98df2806801617f3f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void qKnXurPzufgGWYqMebQ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static bool xuTM3APIiFKAtJ4NJVT()
	{
		return mYZJU1P14Ggn4Mr6Pdc == null;
	}

	internal static CustomActivityFolderMap B0xVklPZOT2Bxp0WqQ4()
	{
		return mYZJU1P14Ggn4Mr6Pdc;
	}
}
