using System;
using AutoMapper;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Model.AutoMaps;

public static class AutoMapperExtensions
{
	public static void ConstructAsLoadOrCreateEntity<TSource, TDestination>(this IMappingExpression<TSource, TDestination> map) where TSource : class, IEntityDTO where TDestination : class, IEntity
	{
		map.ConstructUsing((Func<TSource, TDestination>)((TSource source) => LoadOrCreateEntity<TSource, TDestination>(source)));
	}

	private static TEntity LoadOrCreateEntity<TDTO, TEntity>(TDTO source) where TDTO : class, IEntityDTO where TEntity : class, IEntity
	{
		_003C_003Ec__DisplayClass1_0<TDTO, TEntity> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0<TDTO, TEntity>();
		CS_0024_003C_003E8__locals0.source = source;
		if (CS_0024_003C_003E8__locals0.source == null)
		{
			return null;
		}
		CS_0024_003C_003E8__locals0.entity = null;
		Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					CS_0024_003C_003E8__locals0.entity = EntityManager<TEntity>.Instance.LoadOrNull(CS_0024_003C_003E8__locals0.source.Id);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
		if (CS_0024_003C_003E8__locals0.entity == null)
		{
			CS_0024_003C_003E8__locals0.entity = EntityManager<TEntity>.Instance.Create();
		}
		return CS_0024_003C_003E8__locals0.entity;
	}
}
