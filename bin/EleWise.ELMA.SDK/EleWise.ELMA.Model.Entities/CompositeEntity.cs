using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Entities;

public abstract class CompositeEntity<IdT> : Entity<IdT>, ICompositeEntity<IdT>, IEntity<IdT>, IEntity, IIdentified, ICompositeEntity
{
	internal static object ANZ0eShZLnTN8vR9ufbx;

	public abstract IEnumerable<IEntity> GetCompositeEntities();

	protected CompositeEntity()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Y1WRolhZUhJJHF6FslwS()
	{
		return ANZ0eShZLnTN8vR9ufbx == null;
	}

	internal static object rLdGAFhZsRB1fWQVk5x0()
	{
		return ANZ0eShZLnTN8vR9ufbx;
	}
}
