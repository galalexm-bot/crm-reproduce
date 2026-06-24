using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.DTO;

[Serializable]
[Component]
public class EntityDTO<TId, TEntity> : EntityDTO<TId>, IEntityDTO<TId, TEntity>, IEntityDTO<TId>, IEntityDTO where TEntity : class, IEntity
{
	private static object oY73YjWjVqxtfDl9FcbB;

	public EntityDTO()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool tEjYk9WjSYmOSs05aaeR()
	{
		return oY73YjWjVqxtfDl9FcbB == null;
	}

	internal static object a61WqYWjiVYw1p5KMoKS()
	{
		return oY73YjWjVqxtfDl9FcbB;
	}
}
[Serializable]
public class EntityDTO<TId> : IEntityDTO<TId>, IEntityDTO
{
	private static object Qe2qsvWjRtxoVWJV2BvE;

	public TId Id { get; set; }

	object IEntityDTO.Id
	{
		get
		{
			return Id;
		}
		set
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
					Id = (TId)value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual void CopyChanges(EntityDTO<TId> saved)
	{
		Contract.ArgumentNotNull(saved, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C206C3));
		Id = saved.Id;
	}

	public EntityDTO()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool z7BIXoWjqb0sgTn2JiBa()
	{
		return Qe2qsvWjRtxoVWJV2BvE == null;
	}

	internal static object ajOFM8WjKdH3bumeMiHY()
	{
		return Qe2qsvWjRtxoVWJV2BvE;
	}
}
