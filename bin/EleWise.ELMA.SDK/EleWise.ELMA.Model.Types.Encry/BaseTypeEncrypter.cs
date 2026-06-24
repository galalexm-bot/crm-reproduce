using System.Text;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Encrypters;

public abstract class BaseTypeEncrypter : ITypeEncrypter
{
	private static BaseTypeEncrypter Fd3PVSojgJS46TOWSYpx;

	public abstract bool CheckType(object obj, IMetadata propertyMetadata);

	protected abstract object GetObjectFromString(string obj, IMetadata propertyMetadata);

	protected virtual string ObjectToString(object obj, IMetadata propertyMetadata)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return obj.ToString();
			default:
				return string.Empty;
			}
		}
	}

	public virtual string Encrypt(object obj, string password, string salt, IMetadata propertyMetadata)
	{
		return (string)gm4V2cojYR91SdmgHxAk(ObjectToString(obj, propertyMetadata), salt, password);
	}

	public virtual object Decrypt(string encrypted, string password, string salt, IMetadata propertyMetadata)
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return bby7Z8ojUuRqmOl64emc(this, text, propertyMetadata);
			case 1:
				text = (string)sS9hjbojLBDZpZ0SJmHG(encrypted, salt, password);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual object EncryptStub(object obj, IMetadata propertyMetadata)
	{
		return null;
	}

	protected virtual string GetMaskedVal(object obj, IMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0172, IL_01d0
		int num = 1;
		string text = default(string);
		string text2 = default(string);
		int num4 = default(int);
		StringBuilder stringBuilder = default(StringBuilder);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					text = text2;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 4;
					}
					continue;
				case 2:
					if (num4 < 4)
					{
						num2 = 3;
						continue;
					}
					goto case 8;
				case 8:
					return stringBuilder.ToString();
				case 5:
					HSwq5BoYF8fjEY9Ao4Sl(text, num3);
					num = 13;
					break;
				case 13:
					MK6kKtoYB8fbqaAwUQJM(stringBuilder, AiywKwojzRc3Qak0E7bJ(0x3630F361 ^ 0x3630A131));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					return null;
				default:
					text2 = (string)zcxaTjojsD1vT9OS0XrY(this, obj, propertyMetadata);
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 2;
					}
					continue;
				case 14:
					num3++;
					num2 = 7;
					continue;
				case 1:
					if (obj != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 11:
					return (string)AiywKwojzRc3Qak0E7bJ(-740338220 ^ -740358268);
				case 12:
					num4 = 0;
					num2 = 9;
					continue;
				case 15:
					if (!K7Rfp4ojcPr1KPItM0sx(text2))
					{
						stringBuilder = new StringBuilder();
						num = 12;
						break;
					}
					num2 = 11;
					continue;
				case 7:
				case 10:
					if (num3 >= g9BXExoYWqw2enyplhDo(text))
					{
						num2 = 8;
						continue;
					}
					goto case 5;
				case 3:
					num4++;
					num2 = 14;
					continue;
				case 4:
					num3 = 0;
					num = 10;
					break;
				}
				break;
			}
		}
	}

	protected BaseTypeEncrypter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool xrBbDyoj5ZxelSIqDW5M()
	{
		return Fd3PVSojgJS46TOWSYpx == null;
	}

	internal static BaseTypeEncrypter hcHRLfojjnR7E9G3hrbs()
	{
		return Fd3PVSojgJS46TOWSYpx;
	}

	internal static object gm4V2cojYR91SdmgHxAk(object P_0, object P_1, object P_2)
	{
		return EncryptionHelper.Encrypt((string)P_0, (string)P_1, (string)P_2);
	}

	internal static object sS9hjbojLBDZpZ0SJmHG(object P_0, object P_1, object P_2)
	{
		return EncryptionHelper.Decrypt((string)P_0, (string)P_1, (string)P_2);
	}

	internal static object bby7Z8ojUuRqmOl64emc(object P_0, object P_1, object P_2)
	{
		return ((BaseTypeEncrypter)P_0).GetObjectFromString((string)P_1, (IMetadata)P_2);
	}

	internal static object zcxaTjojsD1vT9OS0XrY(object P_0, object P_1, object P_2)
	{
		return ((BaseTypeEncrypter)P_0).ObjectToString(P_1, (IMetadata)P_2);
	}

	internal static bool K7Rfp4ojcPr1KPItM0sx(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object AiywKwojzRc3Qak0E7bJ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static char HSwq5BoYF8fjEY9Ao4Sl(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	internal static object MK6kKtoYB8fbqaAwUQJM(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static int g9BXExoYWqw2enyplhDo(object P_0)
	{
		return ((string)P_0).Length;
	}
}
