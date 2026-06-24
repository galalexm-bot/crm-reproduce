using System;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Model.Managers;

public static class IEntityManagerExtensions
{
	internal static IEntityManagerExtensions XkGxIohQGX9TGDpQo0rs;

	public static T Get<T>(this IEntityManager<T> manager, Expression<Func<T, bool>> predicate) where T : class, IEntity
	{
		return manager.Find(predicate, FetchOptions.First).SingleOrDefault();
	}

	public static T Get<T>(this IEntityManager<T> manager, IEntityFilter filter) where T : IEntity
	{
		return manager.Find(filter, FetchOptions.First).SingleOrDefault();
	}

	public static bool Exists(this IEntityManager manager)
	{
		int num = 1;
		int num2 = num;
		IEntityExistsManager entityExistsManager = default(IEntityExistsManager);
		while (true)
		{
			switch (num2)
			{
			default:
				return entityExistsManager.Exists();
			case 1:
				if ((entityExistsManager = manager as IEntityExistsManager) == null)
				{
					return YhorkthQQx28bQYfOsYA(manager) > 0;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static bool Exists(this IEntityManager manager, IEntityFilter filter)
	{
		int num = 1;
		int num2 = num;
		IEntityExistsManager entityExistsManager = default(IEntityExistsManager);
		while (true)
		{
			switch (num2)
			{
			default:
				return bvu97bhQCdpFZN7HVLUh(entityExistsManager, filter);
			case 1:
				if ((entityExistsManager = manager as IEntityExistsManager) == null)
				{
					return manager.Count(filter) > 0;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static long YhorkthQQx28bQYfOsYA(object P_0)
	{
		return ((IEntityManager)P_0).Count();
	}

	internal static bool m5cym9hQEYC30iuOl7wn()
	{
		return XkGxIohQGX9TGDpQo0rs == null;
	}

	internal static IEntityManagerExtensions hrFE4JhQfvDEfq4DbMq8()
	{
		return XkGxIohQGX9TGDpQo0rs;
	}

	internal static bool bvu97bhQCdpFZN7HVLUh(object P_0, object P_1)
	{
		return ((IEntityExistsManager)P_0).Exists((IEntityFilter)P_1);
	}
}
