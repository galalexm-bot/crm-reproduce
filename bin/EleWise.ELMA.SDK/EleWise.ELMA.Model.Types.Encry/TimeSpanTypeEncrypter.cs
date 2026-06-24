using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Encrypters;

[Component]
public class TimeSpanTypeEncrypter : BaseTypeEncrypter
{
	internal static TimeSpanTypeEncrypter pkgcp7oLJP1OhRDEMZik;

	public override bool CheckType(object obj, IMetadata propertyMetadata)
	{
		int num = 2;
		int num2 = num;
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				propertyMetadata2 = propertyMetadata as PropertyMetadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return YTVZeuoLr28VwPrYGwsC(phoDjGoLl33i33n2iSJm(propertyMetadata2), TimeSpanDescriptor.UID);
			case 1:
				if (propertyMetadata2 == null)
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override string ObjectToString(object obj, IMetadata propertyMetadata)
	{
		return ClassSerializationHelper.SerializeObjectByXml(new TimeSpanWrapper((TimeSpan?)obj));
	}

	protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_00e4, IL_00f3
		int num = 1;
		int num2 = num;
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		TimeSpan? value = default(TimeSpan?);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return new TimeSpan(0, 0, 0, 0);
			case 1:
				propertyMetadata2 = (PropertyMetadata)propertyMetadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (DFxrhToLgEyGJijWIMhE(propertyMetadata2))
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 5;
					}
					break;
				}
				if (value.HasValue)
				{
					return value.Value;
				}
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				if (Hj7NlaoL5B8CgFYJVDl4(obj))
				{
					num2 = 3;
					break;
				}
				goto case 4;
			case 3:
				return null;
			case 4:
				value = ClassSerializationHelper.DeserializeObjectByXml<TimeSpanWrapper>(obj).Value;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 2;
				}
				break;
			default:
				if (!DFxrhToLgEyGJijWIMhE(propertyMetadata2))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 7;
			case 6:
				return value;
			}
		}
	}

	public TimeSpanTypeEncrypter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		IdN7NMoLjOesc9bs6O9U();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid phoDjGoLl33i33n2iSJm(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static bool YTVZeuoLr28VwPrYGwsC(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool iecE1LoL9K1jYrTn6wdg()
	{
		return pkgcp7oLJP1OhRDEMZik == null;
	}

	internal static TimeSpanTypeEncrypter AJPjAgoLdCxF5MpWnTP9()
	{
		return pkgcp7oLJP1OhRDEMZik;
	}

	internal static bool DFxrhToLgEyGJijWIMhE(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static bool Hj7NlaoL5B8CgFYJVDl4(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void IdN7NMoLjOesc9bs6O9U()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
