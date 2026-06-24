using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Actions.Impl;

internal class EntityManagerActionsStorage : IEntityManagerTypesStorage
{
	[NotNull]
	private readonly ISet<Type> entityManagerTypes;

	private static EntityManagerActionsStorage XSPpDtf4fvGQdSIuck7Z;

	internal void AddManagerType(Type managerType)
	{
		//Discarded unreachable code: IL_0059, IL_0068
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 2:
					return;
				case 1:
					break;
				case 3:
					if (typeof(IEntityManager).IsAssignableFrom(managerType))
					{
						break;
					}
					goto end_IL_0012;
				}
				entityManagerTypes.Add(managerType);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	public IEnumerable<Type> GetManagerTypes()
	{
		return entityManagerTypes;
	}

	public EntityManagerActionsStorage()
	{
		//Discarded unreachable code: IL_003b, IL_0040
		jSEM0Mf4vDlG4nKIvOIn();
		entityManagerTypes = PublishCacheContext.CreateCache<Type>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool xrM6EFf4QcroM0dUonkj()
	{
		return XSPpDtf4fvGQdSIuck7Z == null;
	}

	internal static EntityManagerActionsStorage bxsKORf4CROUUX2VqgtU()
	{
		return XSPpDtf4fvGQdSIuck7Z;
	}

	internal static void jSEM0Mf4vDlG4nKIvOIn()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
