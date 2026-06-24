using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Encrypters;

[Component]
public class DropDownListTypeEncrypter : BaseTypeEncrypter
{
	internal static DropDownListTypeEncrypter UXHqESoY2UrhBasyJoRl;

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
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return RoHEJIoYNpHcGkSvW0eS(F7S62ToY18dmmSohFO5n(propertyMetadata2), DropDownListDescriptor.UID);
			case 1:
				if (propertyMetadata2 == null)
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override string ObjectToString(object obj, IMetadata propertyMetadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return string.Empty;
			case 1:
				if (obj != null)
				{
					return ClassSerializationHelper.SerializeObjectByXml(obj);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 0;
				}
				break;
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
			default:
				return null;
			case 1:
				if (!mRHHvdoY3Ism9GytFgXX(obj))
				{
					return ClassSerializationHelper.DeserializeObjectByXml<DropDownItem>(obj);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public DropDownListTypeEncrypter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Edpx1coYpxtWL2SCKI6r();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid F7S62ToY18dmmSohFO5n(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static bool RoHEJIoYNpHcGkSvW0eS(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool A0s2SQoYeLBc4tNlxJ6g()
	{
		return UXHqESoY2UrhBasyJoRl == null;
	}

	internal static DropDownListTypeEncrypter kmfCXwoYPa5rAIqPf7fd()
	{
		return UXHqESoY2UrhBasyJoRl;
	}

	internal static bool mRHHvdoY3Ism9GytFgXX(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void Edpx1coYpxtWL2SCKI6r()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
