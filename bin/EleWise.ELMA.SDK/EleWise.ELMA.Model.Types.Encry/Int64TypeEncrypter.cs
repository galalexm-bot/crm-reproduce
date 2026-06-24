using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Encrypters;

[Component]
public class Int64TypeEncrypter : BaseTypeEncrypter
{
	internal static Int64TypeEncrypter RLP64DoLfSgcvEj5ixWR;

	public override bool CheckType(object obj, IMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0067, IL_0076
		int num = 3;
		int num2 = num;
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return qweyeSoL8tqhY7fOnWTn(n7mVtqoLvpUCsYnbYoWs(propertyMetadata2), Int64Descriptor.UID);
			default:
				return false;
			case 3:
				propertyMetadata2 = propertyMetadata as PropertyMetadata;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				if (propertyMetadata2 == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	protected override string ObjectToString(object obj, IMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0031
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!suHqB2oLZ8lsmdsAm4Vu((PropertyMetadata)propertyMetadata))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 3:
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
					break;
				}
				return base.ObjectToString(Convert.ToInt64(obj), propertyMetadata);
			default:
				return string.Empty;
			case 1:
				return base.ObjectToString(obj, propertyMetadata);
			}
		}
	}

	protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return null;
			case 1:
				if (suHqB2oLZ8lsmdsAm4Vu((PropertyMetadata)propertyMetadata))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_002a;
			default:
				{
					if (ecgeGNoLuQvDVlyCp52A(obj))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_002a;
				}
				IL_002a:
				return zSTfcuoLICu90iyG87De(obj);
			}
		}
	}

	public Int64TypeEncrypter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid n7mVtqoLvpUCsYnbYoWs(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static bool qweyeSoL8tqhY7fOnWTn(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool FLeFvYoLQPDMb8GdHYkl()
	{
		return RLP64DoLfSgcvEj5ixWR == null;
	}

	internal static Int64TypeEncrypter L7chEsoLCBrRbXPOEcQJ()
	{
		return RLP64DoLfSgcvEj5ixWR;
	}

	internal static bool suHqB2oLZ8lsmdsAm4Vu(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static bool ecgeGNoLuQvDVlyCp52A(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static long zSTfcuoLICu90iyG87De(object P_0)
	{
		return Convert.ToInt64((string)P_0);
	}
}
