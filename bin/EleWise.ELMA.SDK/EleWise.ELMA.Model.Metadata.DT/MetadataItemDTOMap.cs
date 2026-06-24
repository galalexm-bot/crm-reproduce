using System;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.DTO.AutoMaps;

public class MetadataItemDTOMap : EntityDTOMap<IMetadataItem, MetadataItemDTO>
{
	private static MetadataItemDTOMap F2Gd0dbjVgyyCWhfGqKV;

	protected override void InitMap(IMappingExpression<IMetadataItem, MetadataItemDTO> map)
	{
		base.InitMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(MetadataItemDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A6D50D));
		map.ForMember<DateTime>(Expression.Lambda<Func<MetadataItemDTO, DateTime>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, DateTime>>)delegate(IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, DateTime> o)
		{
			ParameterExpression parameterExpression12 = Expression.Parameter(typeof(IMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740303364));
			o.MapFrom<DateTime>(Expression.Lambda<Func<IMetadataItem, DateTime>>(Expression.Property(parameterExpression12, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression12 }));
		});
		parameterExpression = Expression.Parameter(typeof(MetadataItemDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859083965));
		map.ForMember<long>(Expression.Lambda<Func<MetadataItemDTO, long>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, long>>)delegate(IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, long> o)
		{
			ParameterExpression parameterExpression11 = Expression.Parameter(typeof(IMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561109684));
			o.MapFrom<long>(Expression.Lambda<Func<IMetadataItem, long>>(Expression.Condition(Expression.NotEqual(Expression.Property(parameterExpression11, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant((long?)null, typeof(long?))), Expression.Property(Expression.Property(parameterExpression11, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(long?).TypeHandle)), Expression.Constant(-1L, typeof(long))), new ParameterExpression[1] { parameterExpression11 }));
		});
		parameterExpression = Expression.Parameter(typeof(MetadataItemDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x83274D0));
		map.ForMember<bool>(Expression.Lambda<Func<MetadataItemDTO, bool>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, bool>>)delegate(IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, bool> o)
		{
			ParameterExpression parameterExpression10 = Expression.Parameter(typeof(IMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x3132E92E));
			o.MapFrom<bool>(Expression.Lambda<Func<IMetadataItem, bool>>(Expression.Condition(Expression.NotEqual(Expression.Property(parameterExpression10, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(null, typeof(object))), Expression.Property(Expression.Property(parameterExpression10, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(false, typeof(bool))), new ParameterExpression[1] { parameterExpression10 }));
		});
		parameterExpression = Expression.Parameter(typeof(MetadataItemDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x5488AE68));
		map.ForMember<long>(Expression.Lambda<Func<MetadataItemDTO, long>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, long>>)delegate(IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, long> o)
		{
			ParameterExpression parameterExpression9 = Expression.Parameter(typeof(IMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576180340));
			o.MapFrom<long>(Expression.Lambda<Func<IMetadataItem, long>>(Expression.Condition(Expression.NotEqual(Expression.Property(parameterExpression9, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(null, typeof(object))), Expression.Property(Expression.Property(parameterExpression9, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<long>).TypeHandle)), Expression.Constant(0L, typeof(long))), new ParameterExpression[1] { parameterExpression9 }));
		});
		parameterExpression = Expression.Parameter(typeof(MetadataItemDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC1B1AF));
		map.ForMember<long>(Expression.Lambda<Func<MetadataItemDTO, long>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, long>>)delegate(IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, long> o)
		{
			ParameterExpression parameterExpression8 = Expression.Parameter(typeof(IMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463A8714));
			o.MapFrom<long>(Expression.Lambda<Func<IMetadataItem, long>>(Expression.Condition(Expression.AndAlso(Expression.NotEqual(Expression.Property(parameterExpression8, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(null, typeof(object))), Expression.NotEqual(Expression.Property(Expression.Property(parameterExpression8, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(null, typeof(object)))), Expression.Property(Expression.Property(Expression.Property(parameterExpression8, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<long>).TypeHandle)), Expression.Constant(0L, typeof(long))), new ParameterExpression[1] { parameterExpression8 }));
		});
		parameterExpression = Expression.Parameter(typeof(MetadataItemDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x313161E4));
		map.ForMember<DateTime>(Expression.Lambda<Func<MetadataItemDTO, DateTime>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, DateTime>>)delegate(IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, DateTime> o)
		{
			ParameterExpression parameterExpression7 = Expression.Parameter(typeof(IMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x20269267));
			o.MapFrom<DateTime>(Expression.Lambda<Func<IMetadataItem, DateTime>>(Expression.Condition(Expression.NotEqual(Expression.Property(parameterExpression7, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(null, typeof(object))), Expression.Property(Expression.Property(parameterExpression7, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(null, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression7 }));
		});
		parameterExpression = Expression.Parameter(typeof(MetadataItemDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F337854));
		map.ForMember<long>(Expression.Lambda<Func<MetadataItemDTO, long>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, long>>)delegate(IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, long> o)
		{
			ParameterExpression parameterExpression6 = Expression.Parameter(typeof(IMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870857697));
			o.MapFrom<long>(Expression.Lambda<Func<IMetadataItem, long>>(Expression.Condition(Expression.AndAlso(Expression.NotEqual(Expression.Property(parameterExpression6, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(null, typeof(object))), Expression.NotEqual(Expression.Property(Expression.Property(parameterExpression6, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant((long?)null, typeof(long?)))), Expression.Property(Expression.Property(Expression.Property(parameterExpression6, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(long?).TypeHandle)), Expression.Constant(-1L, typeof(long))), new ParameterExpression[1] { parameterExpression6 }));
		});
		parameterExpression = Expression.Parameter(typeof(MetadataItemDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD3EEF9C));
		map.ForMember<string>(Expression.Lambda<Func<MetadataItemDTO, string>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, string>>)delegate(IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, string> o)
		{
			ParameterExpression parameterExpression5 = Expression.Parameter(typeof(IMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195583683));
			o.MapFrom<string>(Expression.Lambda<Func<IMetadataItem, string>>(Expression.Condition(Expression.NotEqual(Expression.Property(parameterExpression5, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(null, typeof(object))), Expression.Property(Expression.Property(parameterExpression5, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(null, typeof(string))), new ParameterExpression[1] { parameterExpression5 }));
		});
		parameterExpression = Expression.Parameter(typeof(MetadataItemDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269D5F28));
		map.ForMember<long?>(Expression.Lambda<Func<MetadataItemDTO, long?>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, long?>>)delegate(IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, long?> o)
		{
			ParameterExpression parameterExpression4 = Expression.Parameter(typeof(IMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x47853425));
			o.MapFrom<long?>(Expression.Lambda<Func<IMetadataItem, long?>>(Expression.Condition(Expression.AndAlso(Expression.NotEqual(Expression.Property(parameterExpression4, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(null, typeof(object))), Expression.NotEqual(Expression.Property(Expression.Property(parameterExpression4, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(null, typeof(object)))), Expression.Convert(Expression.Property(Expression.Property(Expression.Property(parameterExpression4, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<long>).TypeHandle)), typeof(long?)), Expression.Constant((long?)null, typeof(long?))), new ParameterExpression[1] { parameterExpression4 }));
		});
		parameterExpression = Expression.Parameter(typeof(MetadataItemDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307D9F33));
		map.ForMember<DateTime>(Expression.Lambda<Func<MetadataItemDTO, DateTime>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, DateTime>>)delegate(IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, DateTime> o)
		{
			ParameterExpression parameterExpression3 = Expression.Parameter(typeof(IMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889494936));
			o.MapFrom<DateTime>(Expression.Lambda<Func<IMetadataItem, DateTime>>(Expression.Condition(Expression.AndAlso(Expression.NotEqual(Expression.Property(parameterExpression3, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(null, typeof(object))), Expression.NotEqual(Expression.Property(Expression.Property(parameterExpression3, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(null, typeof(object)))), Expression.Property(Expression.Property(Expression.Property(parameterExpression3, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(null, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression3 }));
		});
		parameterExpression = Expression.Parameter(typeof(MetadataItemDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138084067));
		map.ForMember<long?>(Expression.Lambda<Func<MetadataItemDTO, long?>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, long?>>)delegate(IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, long?> o)
		{
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(IMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767755309));
			o.MapFrom<long>(Expression.Lambda<Func<IMetadataItem, long>>(Expression.Condition(Expression.AndAlso(Expression.AndAlso(Expression.NotEqual(Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(null, typeof(object))), Expression.NotEqual(Expression.Property(Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(null, typeof(object)))), Expression.NotEqual(Expression.Property(Expression.Property(Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant((long?)null, typeof(long?)))), Expression.Property(Expression.Property(Expression.Property(Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(long?).TypeHandle)), Expression.Constant(-1L, typeof(long))), new ParameterExpression[1] { parameterExpression2 }));
		});
	}

	protected override void InitReverseMap(IMappingExpression<MetadataItemDTO, IMetadataItem> map)
	{
		base.InitReverseMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x745162A));
		map.ForMember<IMetadataItemHeader>(Expression.Lambda<Func<IMetadataItem, IMetadataItemHeader>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<MetadataItemDTO, IMetadataItem, IMetadataItemHeader>>)delegate(IMemberConfigurationExpression<MetadataItemDTO, IMetadataItem, IMetadataItemHeader> o)
		{
			o.Ignore();
		});
		map.AfterMap((Action<MetadataItemDTO, IMetadataItem>)delegate(MetadataItemDTO d, IMetadataItem e)
		{
			//Discarded unreachable code: IL_0047, IL_0056
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (_003C_003Ec.q0uMYCC0kIjKx4gI2fpP(e) == null)
					{
						num2 = 2;
						continue;
					}
					break;
				case 1:
					return;
				case 2:
					return;
				}
				_003C_003Ec.l1tUsyC0O3xuts0QYsoA(_003C_003Ec.q0uMYCC0kIjKx4gI2fpP(e), (_003C_003Ec.RZVHTRC0nD41afYEXMyP(d) > 0) ? EntityManager<IMetadataItemGroup>.Instance.LoadOrNull(d.HeaderGroupId) : null);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 1;
				}
			}
		});
	}

	public MetadataItemDTOMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		PJS1y0bjR9YRUJ2QjIkv();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void PJS1y0bjR9YRUJ2QjIkv()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool R73jPVbjSFpHuL39Y9M6()
	{
		return F2Gd0dbjVgyyCWhfGqKV == null;
	}

	internal static MetadataItemDTOMap JwbLsAbjiBiwhEHdkuX5()
	{
		return F2Gd0dbjVgyyCWhfGqKV;
	}
}
