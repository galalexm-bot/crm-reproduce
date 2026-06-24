using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Events;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Events.Audit;

public abstract class BaseEntityActionHistoryCollectorRelated : IEntityActionHistoryCollectorRelated
{
	internal static BaseEntityActionHistoryCollectorRelated bXRXVQGLnL7XrxIPqe04;

	public virtual bool CanUse(long id, Guid actionObject)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return !actionObject.Equals(Guid.Empty);
			case 1:
				if (id <= 0)
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public abstract IEnumerable<EntityActionEventArgs> CollectHistory(long id, Guid actionObject, IEnumerable<EntityActionEventArgs> relatedEventList, IEnumerable<HistoryCollectorRelatedModel> relatedObjectList);

	public abstract IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(long id, Guid actionObject);

	protected BaseEntityActionHistoryCollectorRelated()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool I7fTQHGLOdqYPtVJtDuO()
	{
		return bXRXVQGLnL7XrxIPqe04 == null;
	}

	internal static BaseEntityActionHistoryCollectorRelated kyut3VGL2mLNQYLIvqVH()
	{
		return bXRXVQGLnL7XrxIPqe04;
	}
}
