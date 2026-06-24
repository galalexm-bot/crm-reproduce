using System;
using System.Web;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Encrypters;

[Component]
public class HtmlStringTypeEncrypter : BaseTypeEncrypter
{
	internal static HtmlStringTypeEncrypter KViGTNoLWQFTha3fit7p;

	public override bool CheckType(object obj, IMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_007c, IL_008b
		int num = 1;
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return y5hi0woLG7biL7GPAGOV(G7Tt4roLhTgRF7DHJi9B(propertyMetadata2), HtmlStringDescriptor.UID);
				case 3:
					return false;
				case 1:
					propertyMetadata2 = propertyMetadata as PropertyMetadata;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					if (propertyMetadata2 == null)
					{
						break;
					}
					goto case 2;
				}
				break;
			}
			num = 3;
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
			case 1:
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return new HtmlString(obj);
			default:
				return null;
			}
		}
	}

	public override object EncryptStub(object obj, IMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_005d, IL_006c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (obj != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return null;
			default:
				return new HtmlString((string)XsHQ6uoLEqJxdDrMU8Ji(this, obj, propertyMetadata));
			}
		}
	}

	public HtmlStringTypeEncrypter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid G7Tt4roLhTgRF7DHJi9B(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static bool y5hi0woLG7biL7GPAGOV(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool jkLZNkoLoUDFquWEFUlq()
	{
		return KViGTNoLWQFTha3fit7p == null;
	}

	internal static HtmlStringTypeEncrypter MseEGdoLbIRtViXbgkhE()
	{
		return KViGTNoLWQFTha3fit7p;
	}

	internal static object XsHQ6uoLEqJxdDrMU8Ji(object P_0, object P_1, object P_2)
	{
		return ((BaseTypeEncrypter)P_0).GetMaskedVal(P_1, (IMetadata)P_2);
	}
}
