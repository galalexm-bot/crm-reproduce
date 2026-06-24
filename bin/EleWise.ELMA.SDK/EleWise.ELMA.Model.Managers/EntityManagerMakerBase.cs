using System;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Managers;

public abstract class EntityManagerMakerBase : IManagerMaker
{
	private static EntityManagerMakerBase R4RuXthhUAer6xt43dWM;

	public virtual Type MakeManager(Type objectType)
	{
		int num = 4;
		int num2 = num;
		Type typeByUid = default(Type);
		Type idType = default(Type);
		EntityMetadata entityMetadata = default(EntityMetadata);
		IMetadataRuntimeService serviceNotNull = default(IMetadataRuntimeService);
		while (true)
		{
			switch (num2)
			{
			case 6:
				return C78pXohGWmaj85x8wdqx(this, objectType, typeByUid, idType);
			case 1:
				if (Xpdf8GhGFiuyQgnSaLWP(entityMetadata) == EntityMetadataType.InterfaceImplementation)
				{
					num2 = 5;
					break;
				}
				goto IL_0048;
			case 7:
				if (entityMetadata != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto IL_0048;
			case 4:
				Contract.ArgumentNotNull(objectType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870779611));
				num2 = 3;
				break;
			case 3:
				serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
				num2 = 2;
				break;
			case 5:
				typeByUid = serviceNotNull.GetTypeByUid(aQEmAohGBSLbX45FlF50(entityMetadata), loadImplementation: false);
				num2 = 6;
				break;
			default:
				idType = S6yMfuhhzG3xj0uUjVbk(objectType);
				num2 = 7;
				break;
			case 2:
				{
					entityMetadata = InterfaceActivator.LoadMetadata(objectType, inherit: true, loadImplementation: false) as EntityMetadata;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 0;
					}
					break;
				}
				IL_0048:
				return fpolk2hGodCMShlpRMkU(this, objectType, idType);
			}
		}
	}

	protected virtual Type MakeEntityImplManager(Type objectType, Type intfType, Type idType)
	{
		return gBamwqhGbyqaDNh4u4PZ(typeof(EntityImplManager<, , >).TypeHandle).MakeGenericType(objectType, intfType, idType);
	}

	protected virtual Type MakeEntityManager(Type objectType, Type idType)
	{
		return typeof(EntityManager<, >).MakeGenericType(objectType, idType);
	}

	protected EntityManagerMakerBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Qx2iJuhGhCssB6Rq3sCt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type S6yMfuhhzG3xj0uUjVbk(Type entityType)
	{
		return ModelHelper.GetEntityIdType(entityType);
	}

	internal static EntityMetadataType Xpdf8GhGFiuyQgnSaLWP(object P_0)
	{
		return ((EntityMetadata)P_0).Type;
	}

	internal static Guid aQEmAohGBSLbX45FlF50(object P_0)
	{
		return ((EntityMetadata)P_0).ImplementationUid;
	}

	internal static Type C78pXohGWmaj85x8wdqx(object P_0, Type objectType, Type intfType, Type idType)
	{
		return ((EntityManagerMakerBase)P_0).MakeEntityImplManager(objectType, intfType, idType);
	}

	internal static Type fpolk2hGodCMShlpRMkU(object P_0, Type objectType, Type idType)
	{
		return ((EntityManagerMakerBase)P_0).MakeEntityManager(objectType, idType);
	}

	internal static bool QybAFNhhskCbnQE8eB5m()
	{
		return R4RuXthhUAer6xt43dWM == null;
	}

	internal static EntityManagerMakerBase YZ7kFOhhco81xhPExGm8()
	{
		return R4RuXthhUAer6xt43dWM;
	}

	internal static Type gBamwqhGbyqaDNh4u4PZ(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void Qx2iJuhGhCssB6Rq3sCt()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
