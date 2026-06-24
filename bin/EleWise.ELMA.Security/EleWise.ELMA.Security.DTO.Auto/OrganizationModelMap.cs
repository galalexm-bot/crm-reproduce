using System;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.DTO.AutoMaps;

public class OrganizationModelMap : BidirectionalMap<IOrganizationModel, OrganizationModelDTO>
{
	internal static OrganizationModelMap DrL9pnmjGpp60Sy5URS;

	protected override void InitReverseMap(IMappingExpression<OrganizationModelDTO, IOrganizationModel> map)
	{
		base.InitReverseMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IOrganizationModel), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD946FDB ^ 0xD94235F));
		map.ForMember<EleWise.ELMA.Security.Models.IUser>(Expression.Lambda<Func<IOrganizationModel, EleWise.ELMA.Security.Models.IUser>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<OrganizationModelDTO, IOrganizationModel, EleWise.ELMA.Security.Models.IUser>>)delegate(IMemberConfigurationExpression<OrganizationModelDTO, IOrganizationModel, EleWise.ELMA.Security.Models.IUser> o)
		{
			o.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(IOrganizationModel), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x40096392 ^ 0x40092F16));
		map.ForMember<DateTime>(Expression.Lambda<Func<IOrganizationModel, DateTime>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<OrganizationModelDTO, IOrganizationModel, DateTime>>)delegate(IMemberConfigurationExpression<OrganizationModelDTO, IOrganizationModel, DateTime> o)
		{
			o.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(IOrganizationModel), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1195916818 ^ -1195930262));
		map.ForMember<EleWise.ELMA.Security.Models.IUser>(Expression.Lambda<Func<IOrganizationModel, EleWise.ELMA.Security.Models.IUser>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<OrganizationModelDTO, IOrganizationModel, EleWise.ELMA.Security.Models.IUser>>)delegate(IMemberConfigurationExpression<OrganizationModelDTO, IOrganizationModel, EleWise.ELMA.Security.Models.IUser> o)
		{
			o.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(IOrganizationModel), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7CAA49C6 ^ 0x7CAA0542));
		map.ForMember<DateTime?>(Expression.Lambda<Func<IOrganizationModel, DateTime?>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<OrganizationModelDTO, IOrganizationModel, DateTime?>>)delegate(IMemberConfigurationExpression<OrganizationModelDTO, IOrganizationModel, DateTime?> o)
		{
			o.Ignore();
		});
	}

	public OrganizationModelMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		kwgKLKmRiiHZYwJgJUg();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void kwgKLKmRiiHZYwJgJUg()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool Alpp9bmHoeByKxiLlTj()
	{
		return DrL9pnmjGpp60Sy5URS == null;
	}

	internal static OrganizationModelMap eDImKEma7pF9yaA7aBW()
	{
		return DrL9pnmjGpp60Sy5URS;
	}
}
