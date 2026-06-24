using System;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.BPMApps.DTO.Models;
using EleWise.ELMA.BPMApps.Models;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.BPMApps.DTO.AutoMaps;

public class BPMAppMap : EntityDTOMap<IBPMApp, BPMAppDTO>
{
	internal static BPMAppMap KuUvw1fncrqMCrdD0mjH;

	protected override void InitMap(IMappingExpression<IBPMApp, BPMAppDTO> map)
	{
		base.InitMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(BPMAppDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A576FD));
		map.ForMember<ElmaStoreComponentManifest>(Expression.Lambda<Func<BPMAppDTO, ElmaStoreComponentManifest>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<IBPMApp, BPMAppDTO, ElmaStoreComponentManifest>>)delegate(IMemberConfigurationExpression<IBPMApp, BPMAppDTO, ElmaStoreComponentManifest> a)
		{
			ParameterExpression parameterExpression4 = Expression.Parameter(typeof(IBPMApp), z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7FBA3A));
			a.MapFrom<ElmaStoreComponentManifest>(Expression.Lambda<Func<IBPMApp, ElmaStoreComponentManifest>>(Expression.Convert(Expression.Property(parameterExpression4, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(ElmaStoreComponentManifest)), new ParameterExpression[1] { parameterExpression4 }));
		});
		parameterExpression = Expression.Parameter(typeof(BPMAppDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A5D2D2));
		map.ForMember<BPMAppManifest>(Expression.Lambda<Func<BPMAppDTO, BPMAppManifest>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<IBPMApp, BPMAppDTO, BPMAppManifest>>)delegate(IMemberConfigurationExpression<IBPMApp, BPMAppDTO, BPMAppManifest> a)
		{
			ParameterExpression parameterExpression3 = Expression.Parameter(typeof(IBPMApp), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269ED7E2));
			a.MapFrom<BPMAppManifest>(Expression.Lambda<Func<IBPMApp, BPMAppManifest>>(Expression.Convert(Expression.Property(parameterExpression3, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(BPMAppManifest)), new ParameterExpression[1] { parameterExpression3 }));
		});
		parameterExpression = Expression.Parameter(typeof(BPMAppDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334928147));
		map.ForMember<string[]>(Expression.Lambda<Func<BPMAppDTO, string[]>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<IBPMApp, BPMAppDTO, string[]>>)delegate(IMemberConfigurationExpression<IBPMApp, BPMAppDTO, string[]> a)
		{
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(IBPMApp), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108013514));
			a.MapFrom<string[]>(Expression.Lambda<Func<IBPMApp, string[]>>(Expression.Condition(Expression.Not(Expression.Call(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)))), Expression.Call(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Expression.Call(Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[2]
			{
				Expression.NewArrayInit(typeof(char), Expression.Constant(';', typeof(char))),
				Expression.Constant(StringSplitOptions.RemoveEmptyEntries, typeof(StringSplitOptions))
			})), Expression.Constant(null, typeof(string[]))), new ParameterExpression[1] { parameterExpression2 }));
		});
	}

	protected override void InitReverseMap(IMappingExpression<BPMAppDTO, IBPMApp> map)
	{
		base.InitReverseMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IBPMApp), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A1EC27));
		map.ForMember<object>(Expression.Lambda<Func<IBPMApp, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<BPMAppDTO, IBPMApp, object>>)delegate(IMemberConfigurationExpression<BPMAppDTO, IBPMApp, object> a)
		{
			ParameterExpression parameterExpression4 = Expression.Parameter(typeof(BPMAppDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538584844));
			a.MapFrom<ElmaStoreComponentManifest>(Expression.Lambda<Func<BPMAppDTO, ElmaStoreComponentManifest>>(Expression.Property(parameterExpression4, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression4 }));
		});
		parameterExpression = Expression.Parameter(typeof(IBPMApp), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C53B0D7));
		map.ForMember<object>(Expression.Lambda<Func<IBPMApp, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<BPMAppDTO, IBPMApp, object>>)delegate(IMemberConfigurationExpression<BPMAppDTO, IBPMApp, object> a)
		{
			ParameterExpression parameterExpression3 = Expression.Parameter(typeof(BPMAppDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA640DE));
			a.MapFrom<BPMAppManifest>(Expression.Lambda<Func<BPMAppDTO, BPMAppManifest>>(Expression.Property(parameterExpression3, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression3 }));
		});
		parameterExpression = Expression.Parameter(typeof(IBPMApp), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583776036));
		map.ForMember<string>(Expression.Lambda<Func<IBPMApp, string>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<BPMAppDTO, IBPMApp, string>>)delegate(IMemberConfigurationExpression<BPMAppDTO, IBPMApp, string> a)
		{
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(BPMAppDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3267336));
			a.MapFrom<string>(Expression.Lambda<Func<BPMAppDTO, string>>(Expression.Condition(Expression.AndAlso(Expression.NotEqual(Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(null, typeof(object))), Expression.GreaterThan(Expression.ArrayLength(Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), Expression.Constant(0, typeof(int)))), Expression.Call(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[2]
			{
				Expression.Constant(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x12444878), typeof(string)),
				Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))
			}), Expression.Constant(null, typeof(string))), new ParameterExpression[1] { parameterExpression2 }));
		});
	}

	public BPMAppMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool mZb8aEfnzSbPiDCRtPxt()
	{
		return KuUvw1fncrqMCrdD0mjH == null;
	}

	internal static BPMAppMap VhG56TfOFQeHgQ0tFFvM()
	{
		return KuUvw1fncrqMCrdD0mjH;
	}
}
