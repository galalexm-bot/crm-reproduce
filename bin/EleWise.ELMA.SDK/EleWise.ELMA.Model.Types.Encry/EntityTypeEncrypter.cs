using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Encrypters;

[Component(Order = 100)]
public class EntityTypeEncrypter : BaseTypeEncrypter
{
	private static EntityTypeEncrypter tBShx9oYaqDJLWVNmdFn;

	public override bool CheckType(object obj, IMetadata propertyMetadata)
	{
		int num = 2;
		int num2 = num;
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return WYYsNCoY6S6PMmvhCJYA(propertyMetadata2) != EnumDescriptor.UID;
			case 2:
				propertyMetadata2 = propertyMetadata as PropertyMetadata;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				if (WiotpnoY4qqZeJu7T3m8(VtuoVloYwcPeE3bRFXjS(propertyMetadata2), Guid.Empty))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_003e;
			case 1:
				{
					if (propertyMetadata2 != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_003e;
				}
				IL_003e:
				return false;
			}
		}
	}

	protected override string ObjectToString(object obj, IMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (obj != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return string.Empty;
			case 1:
				return ClassSerializationHelper.SerializeObjectByXml(new EntityWrapper((IEntity)obj));
			}
		}
	}

	protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0055, IL_00b1
		int num = 8;
		int num2 = num;
		Type typeByUid = default(Type);
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		_003C_003Ec__DisplayClass2_1 _003C_003Ec__DisplayClass2_2 = default(_003C_003Ec__DisplayClass2_1);
		while (true)
		{
			switch (num2)
			{
			case 11:
				typeByUid = Locator.GetService<IMetadataRuntimeService>().GetTypeByUid(so5sLPoYHVYkDUEiYDuT(_003C_003Ec__DisplayClass2_.entityWrapper));
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 0;
				}
				break;
			case 10:
				return null;
			case 3:
				_003C_003Ec__DisplayClass2_.entityWrapper = ClassSerializationHelper.DeserializeObjectByXml<EntityWrapper>(obj);
				num2 = 11;
				break;
			case 1:
				t9A9jRoY77ReSWDaDqdI(Locator.GetServiceNotNull<ISecurityService>(), new Action(_003C_003Ec__DisplayClass2_2._003CGetObjectFromString_003Eb__0));
				num2 = 4;
				break;
			case 2:
				if (_003C_003Ec__DisplayClass2_.manager == null)
				{
					num2 = 12;
					break;
				}
				goto case 5;
			case 4:
				return _003C_003Ec__DisplayClass2_2.res;
			case 12:
				return null;
			case 6:
				_003C_003Ec__DisplayClass2_2.res = null;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				if (!string.IsNullOrEmpty(obj))
				{
					num2 = 3;
					break;
				}
				goto case 10;
			default:
				_003C_003Ec__DisplayClass2_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass2_;
				num2 = 6;
				break;
			case 9:
				_003C_003Ec__DisplayClass2_.manager = (IEntityManager)hMRyetoYA1eyy4m3Udlc(typeByUid);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				_003C_003Ec__DisplayClass2_2 = new _003C_003Ec__DisplayClass2_1();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 7;
				break;
			}
		}
	}

	public EntityTypeEncrypter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		bDlFVuoYxLN6fIRGJinm();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid VtuoVloYwcPeE3bRFXjS(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static bool WiotpnoY4qqZeJu7T3m8(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static Guid WYYsNCoY6S6PMmvhCJYA(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static bool cKQKPOoYDqmXVo1YGQdy()
	{
		return tBShx9oYaqDJLWVNmdFn == null;
	}

	internal static EntityTypeEncrypter NVbZFGoYtwBB5oebNmS7()
	{
		return tBShx9oYaqDJLWVNmdFn;
	}

	internal static Guid so5sLPoYHVYkDUEiYDuT(object P_0)
	{
		return ((EntityWrapper)P_0).TypeUid;
	}

	internal static object hMRyetoYA1eyy4m3Udlc(Type entityType)
	{
		return ModelHelper.GetEntityManager(entityType);
	}

	internal static void t9A9jRoY77ReSWDaDqdI(object P_0, object P_1)
	{
		((ISecurityService)P_0).RunWithElevatedPrivilegies((Action)P_1);
	}

	internal static void bDlFVuoYxLN6fIRGJinm()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
