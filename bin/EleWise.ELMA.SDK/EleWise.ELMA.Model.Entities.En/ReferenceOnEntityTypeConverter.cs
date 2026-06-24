using System;
using System.ComponentModel;
using System.Globalization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Entities.EntityReferences;

public class ReferenceOnEntityTypeConverter : TypeConverter
{
	internal static ReferenceOnEntityTypeConverter rNYWaFhISTPQg8SyvgmD;

	public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
	{
		return false;
	}

	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		//Discarded unreachable code: IL_0090, IL_009f
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				throw new ArgumentNullException((string)eA4nVhhIKfZN6HmkTUcw(-1487388570 ^ -1487267718));
			case 3:
				if (!nHkIDvhIqwi5TtvrrttW(destinationType, null))
				{
					if (nHkIDvhIqwi5TtvrrttW(destinationType, typeof(ReferenceOnEntityType)))
					{
						num2 = 4;
						break;
					}
					goto case 1;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 2;
				}
				break;
			default:
				return nHkIDvhIqwi5TtvrrttW(destinationType, typeof(Guid));
			case 4:
				return true;
			case 1:
				if (!nHkIDvhIqwi5TtvrrttW(destinationType, Q1GFqThIXiyQtPvjMk8H(typeof(string).TypeHandle)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (nHkIDvhIqwi5TtvrrttW(sourceType, null))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 1;
					}
					break;
				}
				if (nHkIDvhIqwi5TtvrrttW(sourceType, Q1GFqThIXiyQtPvjMk8H(typeof(ReferenceOnEntityType).TypeHandle)))
				{
					num2 = 4;
					break;
				}
				goto default;
			case 1:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FD9367));
			case 3:
				return nHkIDvhIqwi5TtvrrttW(sourceType, typeof(Guid));
			case 4:
				return true;
			default:
				if (!(sourceType == typeof(string)))
				{
					num2 = 3;
					break;
				}
				goto case 4;
			}
		}
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		//Discarded unreachable code: IL_00e1, IL_00f0, IL_0105, IL_0166, IL_0175
		int num = 7;
		ReferenceOnEntityType referenceOnEntityType2 = default(ReferenceOnEntityType);
		ReferenceOnEntityType referenceOnEntityType = default(ReferenceOnEntityType);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				Guid guid;
				switch (num2)
				{
				case 3:
					if (referenceOnEntityType2 != null)
					{
						return referenceOnEntityType2.ToString();
					}
					goto end_IL_0012;
				case 2:
					referenceOnEntityType = (ReferenceOnEntityType)value;
					num2 = 9;
					break;
				case 1:
					return value;
				default:
					if (!(destinationType == Q1GFqThIXiyQtPvjMk8H(typeof(Guid).TypeHandle)))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 8;
						}
						break;
					}
					goto case 2;
				case 5:
					return null;
				case 8:
					guid = Guid.Empty;
					goto IL_01d0;
				case 9:
					if (referenceOnEntityType == null)
					{
						num2 = 8;
						break;
					}
					guid = xI3fRXhITpa5Qy0ARItf(referenceOnEntityType);
					goto IL_01d0;
				case 6:
					throw new ArgumentNullException((string)eA4nVhhIKfZN6HmkTUcw(-1146510045 ^ -1146356417));
				case 7:
					if (!nHkIDvhIqwi5TtvrrttW(destinationType, null))
					{
						if (!(destinationType == Q1GFqThIXiyQtPvjMk8H(typeof(ReferenceOnEntityType).TypeHandle)))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 1;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 6;
					}
					break;
				case 4:
					referenceOnEntityType2 = (ReferenceOnEntityType)value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 3;
					}
					break;
				case 10:
					{
						if (!(destinationType == Q1GFqThIXiyQtPvjMk8H(typeof(string).TypeHandle)))
						{
							throw new NotSupportedException((string)g5KQZOhIkQCHuQYjbcih(eA4nVhhIKfZN6HmkTUcw(-2112703338 ^ -2112820032), Q1GFqThIXiyQtPvjMk8H(typeof(ReferenceOnEntityType).TypeHandle).FullName, destinationType.FullName));
						}
						num2 = 4;
						break;
					}
					IL_01d0:
					return guid;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		//Discarded unreachable code: IL_0091, IL_00a0, IL_00b0, IL_0102, IL_0187, IL_01cc
		int num = 11;
		Type type = default(Type);
		string text = default(string);
		Guid result = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (!nHkIDvhIqwi5TtvrrttW(type, Q1GFqThIXiyQtPvjMk8H(typeof(ReferenceOnEntityType).TypeHandle)))
					{
						num2 = 2;
						continue;
					}
					goto case 9;
				case 12:
					if (!Guid.TryParse(text, out result))
					{
						num2 = 6;
						continue;
					}
					goto case 7;
				case 7:
				{
					ReferenceOnEntityType referenceOnEntityType = new ReferenceOnEntityType();
					kwZB7ThIOnmP6N6qCsi6(referenceOnEntityType, result);
					return referenceOnEntityType;
				}
				default:
					throw new NotSupportedException((string)g5KQZOhIkQCHuQYjbcih(eA4nVhhIKfZN6HmkTUcw(0x1ECE530A ^ 0x1ECC0B5C), type.FullName, Q1GFqThIXiyQtPvjMk8H(typeof(ReferenceOnEntityType).TypeHandle).FullName));
				case 13:
					text = (string)value;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 4;
					}
					continue;
				case 5:
					return new ReferenceOnEntityType
					{
						TypeUid = (Guid)value
					};
				case 9:
					return value;
				case 2:
					if (!nHkIDvhIqwi5TtvrrttW(type, typeof(Guid)))
					{
						if (!nHkIDvhIqwi5TtvrrttW(type, typeof(string)))
						{
							num2 = 8;
							continue;
						}
						goto case 13;
					}
					num2 = 5;
					continue;
				case 4:
					if (IpRkNthIn3FvqUfJXhly(text))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 12;
				case 11:
					if (value != null)
					{
						num2 = 10;
						continue;
					}
					break;
				case 1:
					break;
				case 10:
					goto end_IL_0012;
				}
				return null;
				continue;
				end_IL_0012:
				break;
			}
			type = value.GetType();
			num = 3;
		}
	}

	public ReferenceOnEntityTypeConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		B737lEhI2OC7f31IhqkX();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool nHkIDvhIqwi5TtvrrttW(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object eA4nVhhIKfZN6HmkTUcw(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type Q1GFqThIXiyQtPvjMk8H(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool GJqvkthIik1jWwKE7MQg()
	{
		return rNYWaFhISTPQg8SyvgmD == null;
	}

	internal static ReferenceOnEntityTypeConverter VBd72dhIRpootl11CLbr()
	{
		return rNYWaFhISTPQg8SyvgmD;
	}

	internal static Guid xI3fRXhITpa5Qy0ARItf(object P_0)
	{
		return ((ReferenceOnEntityType)P_0).TypeUid;
	}

	internal static object g5KQZOhIkQCHuQYjbcih(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static bool IpRkNthIn3FvqUfJXhly(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void kwZB7ThIOnmP6N6qCsi6(object P_0, Guid value)
	{
		((ReferenceOnEntityType)P_0).TypeUid = value;
	}

	internal static void B737lEhI2OC7f31IhqkX()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
