using AutoMapper;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.AutoMaps;

public class EntityDTOMap<TEntity, TDTO> : BidirectionalMap<TEntity, TDTO> where TEntity : class, IEntity where TDTO : class, IEntityDTO
{
	internal static object KTnU00h70ZKmXjgbspVJ;

	protected override void InitReverseMap(IMappingExpression<TDTO, TEntity> map)
	{
		base.InitReverseMap(map);
		map.ConstructAsLoadOrCreateEntity<TDTO, TEntity>();
	}

	public EntityDTOMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool PfjDDAh7mE91NEmlhVcq()
	{
		return KTnU00h70ZKmXjgbspVJ == null;
	}

	internal static object okVAZth7yxO2eYc8Ogi6()
	{
		return KTnU00h70ZKmXjgbspVJ;
	}
}
