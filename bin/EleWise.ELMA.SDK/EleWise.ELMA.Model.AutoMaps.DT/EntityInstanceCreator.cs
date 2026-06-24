using System;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.InstanceCreators;

internal sealed class EntityInstanceCreator : DefaultInstanceCreator
{
	internal static EntityInstanceCreator cMfGWhh0MYmOYDqsS0ln;

	public override bool CanCreateInstance(Type type)
	{
		return TypeOf<IEntity>.Raw.IsAssignableFrom(type);
	}

	public override object CreateInstance(DataClass dataClass, Type type)
	{
		//Discarded unreachable code: IL_0156, IL_020a
		int num = 6;
		IEntity entity = default(IEntity);
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		DataClassMetadata dataClassMetadata = default(DataClassMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				IEntity entity2;
				switch (num2)
				{
				case 14:
					entity = (_003C_003Ec__DisplayClass1_.entity = _003C_003Ec__DisplayClass1_.manager.Create() as IEntity);
					num = 3;
					break;
				default:
					if (!TypeOf<IMetadata>.Raw.IsAssignableFrom(type))
					{
						num2 = 10;
						continue;
					}
					goto case 4;
				case 13:
					entity2 = _003C_003Ec__DisplayClass1_.entity;
					if (entity2 == null)
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto IL_0278;
				case 6:
					_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
					num2 = 5;
					continue;
				case 8:
					if (propertyMetadata == null)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num2 = 3;
						}
					}
					else
					{
						_003C_003Ec__DisplayClass1_.manager = (IEntityManager)KYGTTeh0rCmY45AoWhsv(type);
						num2 = 15;
					}
					continue;
				case 4:
					return Ta4HNMh0dDiMRuv2o8rX(type);
				case 10:
					dataClassMetadata = _003C_003Ec__DisplayClass1_.dataClass.GetIncludes(onlyFilled: false).First(_003C_003Ec__DisplayClass1_._003CCreateInstance_003Eb__0);
					num = 12;
					break;
				case 5:
					_003C_003Ec__DisplayClass1_.dataClass = dataClass;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					JcBlV4h058WpywWhNhGp(Locator.GetServiceNotNull<ISecurityService>(), new Action(_003C_003Ec__DisplayClass1_._003CCreateInstance_003Eb__1));
					num2 = 13;
					continue;
				case 11:
					return base.CreateInstance(_003C_003Ec__DisplayClass1_.dataClass, type);
				case 12:
					propertyMetadata = (PropertyMetadata)jHoB8Rh0lpkQQvudaRoe(dataClassMetadata);
					num = 8;
					break;
				case 15:
					if (_003C_003Ec__DisplayClass1_.manager != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 9;
				case 9:
					return base.CreateInstance(_003C_003Ec__DisplayClass1_.dataClass, type);
				case 1:
					_003C_003Ec__DisplayClass1_.entity = null;
					num2 = 2;
					continue;
				case 2:
					_003C_003Ec__DisplayClass1_.uid = ((_003C_003Ec__DisplayClass1_.dataClass.GetObject(LxyyuSh0gHm3nl1gv5AA(dataClassMetadata), LxyyuSh0gHm3nl1gv5AA(propertyMetadata)) is Guid guid) ? guid : Guid.Empty);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 7;
					}
					continue;
				case 3:
					{
						entity2 = entity;
						goto IL_0278;
					}
					IL_0278:
					return entity2;
				}
				break;
			}
		}
	}

	public EntityInstanceCreator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Bjbbhhh0j7fF7e4bAoaZ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool lWJ3HOh0JVlws5408DiX()
	{
		return cMfGWhh0MYmOYDqsS0ln == null;
	}

	internal static EntityInstanceCreator XIVxMXh09W36xUUQ21Ja()
	{
		return cMfGWhh0MYmOYDqsS0ln;
	}

	internal static object Ta4HNMh0dDiMRuv2o8rX(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static object jHoB8Rh0lpkQQvudaRoe(object P_0)
	{
		return ((ClassMetadata)P_0).GetUidProperty();
	}

	internal static object KYGTTeh0rCmY45AoWhsv(Type entityType)
	{
		return ModelHelper.GetEntityManagerOrNull(entityType);
	}

	internal static Guid LxyyuSh0gHm3nl1gv5AA(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void JcBlV4h058WpywWhNhGp(object P_0, object P_1)
	{
		((ISecurityService)P_0).RunWithElevatedPrivilegies((Action)P_1);
	}

	internal static void Bjbbhhh0j7fF7e4bAoaZ()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
