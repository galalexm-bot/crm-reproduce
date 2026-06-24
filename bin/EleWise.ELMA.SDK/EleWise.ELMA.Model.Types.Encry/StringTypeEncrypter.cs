using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Encrypters;

[Component]
public class StringTypeEncrypter : BaseTypeEncrypter
{
	internal static StringTypeEncrypter HJsGodoLAHY7p4ZjFMJ4;

	public override bool CheckType(object obj, IMetadata propertyMetadata)
	{
		int num = 2;
		int num2 = num;
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return omc0LqoL0d8DGiTxvtt2(propertyMetadata2) == TextDescriptor.UID;
			case 1:
				if (propertyMetadata2 == null)
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (VJ22yKoLmyoNX9FT8Nyi(omc0LqoL0d8DGiTxvtt2(propertyMetadata2), StringDescriptor.UID))
				{
					return true;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				propertyMetadata2 = propertyMetadata as PropertyMetadata;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
	{
		return obj;
	}

	public override object EncryptStub(object obj, IMetadata propertyMetadata)
	{
		return Eo8774oLyfmIM3RD9RMn(this, obj, propertyMetadata);
	}

	public StringTypeEncrypter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WDyRB9oLMI94vcNoJt5w();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid omc0LqoL0d8DGiTxvtt2(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static bool VJ22yKoLmyoNX9FT8Nyi(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool yIMIpgoL793BXKF9DjRC()
	{
		return HJsGodoLAHY7p4ZjFMJ4 == null;
	}

	internal static StringTypeEncrypter pDAcpGoLxYpZ0qQGdiA8()
	{
		return HJsGodoLAHY7p4ZjFMJ4;
	}

	internal static object Eo8774oLyfmIM3RD9RMn(object P_0, object P_1, object P_2)
	{
		return ((BaseTypeEncrypter)P_0).GetMaskedVal(P_1, (IMetadata)P_2);
	}

	internal static void WDyRB9oLMI94vcNoJt5w()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
