using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Encrypters;

[Component]
public class EnumTypeEncrypter : BaseTypeEncrypter
{
	private static EnumTypeEncrypter zq0Iv7oY0YLJWdqxMr7S;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return jMiSkToYMrMeUH4MQoi3(propertyMetadata2) == EnumDescriptor.UID;
			case 2:
				propertyMetadata2 = propertyMetadata as PropertyMetadata;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override string ObjectToString(object obj, IMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_00ce, IL_00dd, IL_012e
		int num = 4;
		EnumValueMetadata enumValueMetadata = default(EnumValueMetadata);
		EnumMetadata enumMetadata = default(EnumMetadata);
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		int num3 = default(int);
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					enumValueMetadata = enumMetadata.Values.FirstOrDefault(_003C_003Ec__DisplayClass1_._003CObjectToString_003Eb__0);
					num2 = 7;
					continue;
				default:
					return num3.ToString();
				case 9:
					_003C_003Ec__DisplayClass1_.sVal = obj.ToString();
					num2 = 5;
					continue;
				case 3:
					propertyMetadata2 = (PropertyMetadata)propertyMetadata;
					num2 = 6;
					continue;
				case 1:
					if (IQdMOKoY9mXD4i2DfQyx(enumMetadata) == EnumMetadataType.Enum)
					{
						break;
					}
					goto end_IL_0012;
				case 4:
					_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
					num2 = 3;
					continue;
				case 6:
					enumMetadata = (EnumMetadata)Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadata(FO3aZToYJ0PR37twvEZg(propertyMetadata2));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					return string.Empty;
				case 8:
					return (string)TWwYIUoYlmcC6prViKw5(enumValueMetadata);
				case 7:
					if (enumValueMetadata != null)
					{
						num2 = 8;
						continue;
					}
					goto case 2;
				case 10:
					break;
				}
				num3 = Q0LAh7oYdI0gZiGV5mun(obj);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 9;
		}
	}

	protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_00de, IL_01a1, IL_01b0
		int num = 13;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_2 = default(_003C_003Ec__DisplayClass2_0);
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		EnumMetadata enumMetadata = default(EnumMetadata);
		EnumValueMetadata enumValueMetadata = default(EnumValueMetadata);
		_003C_003Ec__DisplayClass2_1 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_1);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					_003C_003Ec__DisplayClass2_2 = new _003C_003Ec__DisplayClass2_0();
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 12;
					}
					continue;
				case 4:
					return null;
				case 7:
				case 14:
					break;
				case 6:
					if (!l3IrtloYryjfdEvoedtx(propertyMetadata2))
					{
						num2 = 7;
						continue;
					}
					goto case 2;
				default:
					return null;
				case 3:
					_003C_003Ec__DisplayClass2_2.enumUid = new Guid(obj);
					num2 = 8;
					continue;
				case 8:
					return enumMetadata.Values.FirstOrDefault(_003C_003Ec__DisplayClass2_2._003CGetObjectFromString_003Eb__0).EnumValue;
				case 5:
					if (IQdMOKoY9mXD4i2DfQyx(enumMetadata) != 0)
					{
						num2 = 3;
						continue;
					}
					goto case 10;
				case 1:
					if (enumValueMetadata != null)
					{
						return jn6CnhoYjNs7qVUiMA99(enumValueMetadata);
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					propertyMetadata2 = (PropertyMetadata)propertyMetadata;
					num2 = 6;
					continue;
				case 11:
					_003C_003Ec__DisplayClass2_.enumInt = TafAUCoY5EIABoj1sqRN(obj);
					num2 = 9;
					continue;
				case 9:
					enumValueMetadata = enumMetadata.Values.FirstOrDefault(_003C_003Ec__DisplayClass2_._003CGetObjectFromString_003Eb__1);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 1;
					}
					continue;
				case 10:
					_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_1();
					num2 = 11;
					continue;
				case 2:
					if (!aMt8dpoYg6N2Oa6FyPRa(obj))
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 4;
				}
				break;
			}
			enumMetadata = (EnumMetadata)Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadata(FO3aZToYJ0PR37twvEZg(propertyMetadata2));
			num = 5;
		}
	}

	public EnumTypeEncrypter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ekU0H8oYYM2ZBVajFhil();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid jMiSkToYMrMeUH4MQoi3(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static bool NKXfFloYmQUi5lmkpDhR()
	{
		return zq0Iv7oY0YLJWdqxMr7S == null;
	}

	internal static EnumTypeEncrypter sO7tLLoYywK26Nv0Cn5P()
	{
		return zq0Iv7oY0YLJWdqxMr7S;
	}

	internal static Guid FO3aZToYJ0PR37twvEZg(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static EnumMetadataType IQdMOKoY9mXD4i2DfQyx(object P_0)
	{
		return ((EnumMetadata)P_0).Type;
	}

	internal static int Q0LAh7oYdI0gZiGV5mun(object P_0)
	{
		return Convert.ToInt32(P_0);
	}

	internal static object TWwYIUoYlmcC6prViKw5(object P_0)
	{
		return ((AbstractMetadata)P_0).UidStr;
	}

	internal static bool l3IrtloYryjfdEvoedtx(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static bool aMt8dpoYg6N2Oa6FyPRa(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static int TafAUCoY5EIABoj1sqRN(object P_0)
	{
		return Convert.ToInt32((string)P_0);
	}

	internal static object jn6CnhoYjNs7qVUiMA99(object P_0)
	{
		return ((EnumValueMetadata)P_0).EnumValue;
	}

	internal static void ekU0H8oYYM2ZBVajFhil()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
