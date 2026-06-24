using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Managers;

[Component(EnableInterceptiors = false)]
public abstract class EntityChangesLoader : IEntityChangesLoader
{
	internal static EntityChangesLoader eibS27hGDu5VEsHxL5Fu;

	protected IEntityModelHistoryService EntityModelHistoryService => Locator.GetServiceNotNull<IEntityModelHistoryService>();

	public abstract bool IsTypeSupported(Guid typeUid);

	public virtual IEnumerable<IEntityModelHistoryItem> LoadChanges(Guid typeUid, DateTime? fromDateTime, string selectExpression = null)
	{
		return EntityModelHistoryService.Find(typeUid, fromDateTime, selectExpression);
	}

	protected EntityChangesLoader()
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

	internal static bool B2WBV3hGtbkWU0ioZpWT()
	{
		return eibS27hGDu5VEsHxL5Fu == null;
	}

	internal static EntityChangesLoader UUGoLohGw7i1RGFcPmew()
	{
		return eibS27hGDu5VEsHxL5Fu;
	}
}
