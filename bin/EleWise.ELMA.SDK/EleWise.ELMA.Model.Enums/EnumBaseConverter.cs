using System;
using System.ComponentModel;
using System.Globalization;
using EleWise.ELMA.Model.Common;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Enums;

public class EnumBaseConverter<TEnum> : TypeConverter where TEnum : EnumBase
{
	internal static object hPgt2xofQjp0KrEWbpFu;

	public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
	{
		return false;
	}

	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		//Discarded unreachable code: IL_0076, IL_0085, IL_0095, IL_00a4, IL_0133
		int num = 7;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858995779));
				case 6:
					if (destinationType == typeof(TEnum))
					{
						num2 = 3;
						continue;
					}
					goto case 1;
				case 5:
					return destinationType == typeof(string);
				case 2:
				case 3:
					return true;
				case 4:
					if (!(destinationType == typeof(Guid?)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 2;
				case 7:
					if (!(destinationType == null))
					{
						num = 6;
						break;
					}
					goto default;
				case 1:
					if (destinationType == typeof(Guid))
					{
						num = 2;
						break;
					}
					goto case 4;
				}
				break;
			}
		}
	}

	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		//Discarded unreachable code: IL_005c
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (!(sourceType == typeof(Guid)))
					{
						goto end_IL_0012;
					}
					goto IL_00eb;
				case 3:
					throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822769626));
				default:
					if (!(sourceType == typeof(TEnum)))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto IL_00eb;
				case 4:
					if (!(sourceType == typeof(Guid?)))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto IL_00eb;
				case 5:
					return sourceType == typeof(string);
				case 1:
					{
						if (!(sourceType == null))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 3;
					}
					IL_00eb:
					return true;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		//Discarded unreachable code: IL_005d, IL_014c, IL_01c1, IL_01d0, IL_01e2, IL_01ec, IL_0200
		int num = 11;
		TEnum val = default(TEnum);
		Guid? guid2 = default(Guid?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				Guid? guid3;
				Guid guid;
				switch (num2)
				{
				case 13:
					return null;
				case 9:
					return val.ToString();
				case 7:
					if ((EnumBase)val != (EnumBase)null)
					{
						num = 3;
						break;
					}
					goto case 12;
				case 11:
					if (!(destinationType == null))
					{
						num2 = 10;
						continue;
					}
					goto case 14;
				case 14:
					throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92D4AC9));
				case 10:
					if (destinationType == typeof(TEnum))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					val = (TEnum)value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					if ((EnumBase)val != (EnumBase)null)
					{
						num2 = 9;
						continue;
					}
					goto case 13;
				case 6:
					if (!((EnumBase)val != (EnumBase)null))
					{
						num = 2;
						break;
					}
					guid3 = val.Value;
					goto IL_026c;
				case 2:
					guid2 = null;
					num = 5;
					break;
				default:
					if (destinationType == typeof(Guid))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num2 = 7;
						}
						continue;
					}
					if (!(destinationType == typeof(Guid?)))
					{
						num2 = 8;
						continue;
					}
					goto case 6;
				case 5:
					guid3 = guid2;
					goto IL_026c;
				case 12:
					guid = Guid.Empty;
					goto IL_0235;
				case 4:
					return value;
				case 3:
					guid = val.Value;
					goto IL_0235;
				case 8:
					{
						if (!(destinationType == typeof(string)))
						{
							throw new NotSupportedException(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767841363), typeof(TEnum).FullName, destinationType.FullName));
						}
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					IL_0235:
					return guid;
					IL_026c:
					return guid3;
				}
				break;
			}
		}
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		//Discarded unreachable code: IL_00d3, IL_0106, IL_0115
		int num = 7;
		int num2 = num;
		Guid result = default(Guid);
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 7:
				if (value != null)
				{
					num2 = 6;
					break;
				}
				goto case 5;
			case 4:
				return ModelHelper.GetEnumValue(typeof(TEnum), (Guid)value);
			case 2:
				if (Guid.TryParse((string)value, out result))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					break;
				}
				return ModelHelper.GetEnumValue(typeof(TEnum), (string)value);
			case 1:
				if (!(type == typeof(Guid)))
				{
					if (!(type == typeof(string)))
					{
						num2 = 3;
						break;
					}
					goto case 2;
				}
				num2 = 4;
				break;
			case 5:
				return null;
			case 6:
				type = value.GetType();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return ModelHelper.GetEnumValue(typeof(TEnum), result);
			case 3:
				throw new NotSupportedException(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A77B08), type.FullName, typeof(TEnum).FullName));
			}
		}
	}

	public EnumBaseConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool CPUYbMofCIwpOVj4rbaB()
	{
		return hPgt2xofQjp0KrEWbpFu == null;
	}

	internal static object a7yGKrofvclJoZeJgElD()
	{
		return hPgt2xofQjp0KrEWbpFu;
	}
}
