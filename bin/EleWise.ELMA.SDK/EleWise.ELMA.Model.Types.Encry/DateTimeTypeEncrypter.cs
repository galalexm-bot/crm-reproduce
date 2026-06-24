using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Encrypters;

[Component]
public class DateTimeTypeEncrypter : BaseTypeEncrypter
{
	internal static DateTimeTypeEncrypter yOlqQeoYZtfOfX0NuseU;

	public override bool CheckType(object obj, IMetadata propertyMetadata)
	{
		int num = 2;
		int num2 = num;
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (propertyMetadata2 != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			case 2:
				propertyMetadata2 = propertyMetadata as PropertyMetadata;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return lImEumoYVeGfYlXGEHro(propertyMetadata2.TypeUid, DateTimeDescriptor.UID);
			}
		}
	}

	protected override string ObjectToString(object obj, IMetadata propertyMetadata)
	{
		return ClassSerializationHelper.SerializeObjectByXml(new DateTimeWrapper((DateTime?)obj));
	}

	protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_006f, IL_007e, IL_008e, IL_0100
		int num = 9;
		int num2 = num;
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		DateTime? value = default(DateTime?);
		while (true)
		{
			switch (num2)
			{
			case 7:
				if (!tNGLKvoYSmI2ko3PnEtN(propertyMetadata2))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 6;
			case 3:
				return DateTime.MinValue;
			case 4:
				return value.Value;
			case 8:
				if (propertyMetadata2.Nullable)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			case 2:
				if (!string.IsNullOrEmpty(obj))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 9:
				propertyMetadata2 = (PropertyMetadata)propertyMetadata;
				num2 = 8;
				break;
			case 5:
				return null;
			case 1:
				value = ClassSerializationHelper.DeserializeObjectByXml<DateTimeWrapper>(obj).Value;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 7;
				}
				break;
			case 6:
				return value;
			default:
				if (value.HasValue)
				{
					num2 = 4;
					break;
				}
				goto case 3;
			}
		}
	}

	public DateTimeTypeEncrypter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		s0PraeoYiUK2w5K7uAnE();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool lImEumoYVeGfYlXGEHro(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool FPGUGGoYux0HWDTGlvPx()
	{
		return yOlqQeoYZtfOfX0NuseU == null;
	}

	internal static DateTimeTypeEncrypter nYtSbVoYIsgDfjib4jTM()
	{
		return yOlqQeoYZtfOfX0NuseU;
	}

	internal static bool tNGLKvoYSmI2ko3PnEtN(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static void s0PraeoYiUK2w5K7uAnE()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
