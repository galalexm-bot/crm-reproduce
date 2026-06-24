using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component(Order = 100)]
public class EntityWrapperDescriptor : ITypeWrapperDescriptor
{
	private static EntityWrapperDescriptor SGAyK1bQK9PLM3HKob4N;

	public Type OriginalType => typeof(IEntity);

	public Type WrapperType => tuj9CXbQkZ4Sj8e1YOaW(typeof(EntityWrapper).TypeHandle);

	public object CreateWrapper(object obj)
	{
		return new EntityWrapper((IEntity)obj);
	}

	public object GetObject(object wrapper)
	{
		//Discarded unreachable code: IL_004d, IL_005c
		int num = 4;
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_2 = default(_003C_003Ec__DisplayClass5_0);
		Type typeByUid = default(Type);
		_003C_003Ec__DisplayClass5_1 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_1);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					_003C_003Ec__DisplayClass5_2 = new _003C_003Ec__DisplayClass5_0();
					num2 = 3;
					continue;
				case 6:
					if (_003C_003Ec__DisplayClass5_2.manager == null)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto default;
				case 10:
					_003C_003Ec__DisplayClass5_2.manager = (IEntityManager)EYoghnbQOFbP6nE25QiC(typeByUid);
					num2 = 6;
					continue;
				case 7:
					typeByUid = Locator.GetService<IMetadataRuntimeService>().GetTypeByUid(XIfIbZbQn8vrkJ18OreJ(_003C_003Ec__DisplayClass5_2.info));
					num = 10;
					break;
				default:
					_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_1();
					num2 = 8;
					continue;
				case 1:
					_003C_003Ec__DisplayClass5_.res = null;
					num = 2;
					break;
				case 8:
					_003C_003Ec__DisplayClass5_.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass5_2;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					_003C_003Ec__DisplayClass5_2.info = (EntityWrapper)wrapper;
					num2 = 7;
					continue;
				case 2:
					L9xEbBbQ2U0Sp2whRi2h(Locator.GetServiceNotNull<ISecurityService>(), new Action(_003C_003Ec__DisplayClass5_._003CGetObject_003Eb__0));
					num2 = 9;
					continue;
				case 9:
					return _003C_003Ec__DisplayClass5_.res;
				case 5:
					return null;
				}
				break;
			}
		}
	}

	public bool TestType(Type type)
	{
		return false;
	}

	public EntityWrapperDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		JKCRkAbQeUQQmOFMvLlK();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type tuj9CXbQkZ4Sj8e1YOaW(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool d4TTK0bQXhpn0gNUN6GI()
	{
		return SGAyK1bQK9PLM3HKob4N == null;
	}

	internal static EntityWrapperDescriptor KFJu0FbQTPkiEn8Mwk4l()
	{
		return SGAyK1bQK9PLM3HKob4N;
	}

	internal static Guid XIfIbZbQn8vrkJ18OreJ(object P_0)
	{
		return ((EntityWrapper)P_0).TypeUid;
	}

	internal static object EYoghnbQOFbP6nE25QiC(Type entityType)
	{
		return ModelHelper.GetEntityManager(entityType);
	}

	internal static void L9xEbBbQ2U0Sp2whRi2h(object P_0, object P_1)
	{
		((ISecurityService)P_0).RunWithElevatedPrivilegies((Action)P_1);
	}

	internal static void JKCRkAbQeUQQmOFMvLlK()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
