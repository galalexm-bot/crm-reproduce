using System;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.AutoMaps;

public class CustomActivityHeaderMap : EntityDTOMap<ICustomActivityHeader, CustomActivityHeaderDTO>
{
	internal static CustomActivityHeaderMap Tmcgd7Pr9a5s3dQbDDG;

	protected override void InitMap(IMappingExpression<ICustomActivityHeader, CustomActivityHeaderDTO> map)
	{
		base.InitMap(map);
	}

	protected override void InitReverseMap(IMappingExpression<CustomActivityHeaderDTO, ICustomActivityHeader> map)
	{
		base.InitReverseMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(ICustomActivityHeader), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x138E9AEB ^ 0x138EC107));
		map.ForMember<ICustomActivityFolder>(Expression.Lambda<Func<ICustomActivityHeader, ICustomActivityFolder>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<CustomActivityHeaderDTO, ICustomActivityHeader, ICustomActivityFolder>>)delegate(IMemberConfigurationExpression<CustomActivityHeaderDTO, ICustomActivityHeader, ICustomActivityFolder> p)
		{
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(CustomActivityHeaderDTO), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-30505303 ^ -30479561));
			p.MapFrom<ICustomActivityFolder>(Expression.Lambda<Func<CustomActivityHeaderDTO, ICustomActivityFolder>>(Expression.Call(Expression.Property(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(EntityManager<ICustomActivityFolder>).TypeHandle)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntityManager<ICustomActivityFolder>).TypeHandle), Expression.Convert(Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object))), new ParameterExpression[1] { parameterExpression2 }));
		});
	}

	public CustomActivityHeaderMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		KyHAndPgIUQM4JeN30a();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_12d847d953a942998a65b55f3d0b7ddb == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void KyHAndPgIUQM4JeN30a()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static bool nZrYujP7xiDiMXJHfj7()
	{
		return Tmcgd7Pr9a5s3dQbDDG == null;
	}

	internal static CustomActivityHeaderMap abaSAeP55dSDvn6UpB3()
	{
		return Tmcgd7Pr9a5s3dQbDDG;
	}
}
