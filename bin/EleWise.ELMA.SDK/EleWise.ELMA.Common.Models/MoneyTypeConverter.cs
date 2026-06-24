using System;
using System.ComponentModel;
using System.Globalization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Common.Models;

public class MoneyTypeConverter : TypeConverter
{
	internal static MoneyTypeConverter mnwrHrfS5awDvLkklbin;

	public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
	{
		return false;
	}

	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		//Discarded unreachable code: IL_0105, IL_0114
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				return HtSwXVfSsTXD8yn3p8DK(destinationType, RnRBaEfSUCgqqkjI5vfT(typeof(string).TypeHandle));
			default:
				return true;
			case 1:
				throw new ArgumentNullException((string)i7E0RefSLN6ok9gqjsXG(-1867198571 ^ -1867081847));
			case 3:
				if (!(destinationType == RnRBaEfSUCgqqkjI5vfT(typeof(double).TypeHandle)))
				{
					num2 = 5;
					break;
				}
				goto default;
			case 2:
				if (!(destinationType == null))
				{
					if (!(destinationType == RnRBaEfSUCgqqkjI5vfT(typeof(Money).TypeHandle)))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num2 = 3;
						}
						break;
					}
					goto default;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				if (HtSwXVfSsTXD8yn3p8DK(destinationType, RnRBaEfSUCgqqkjI5vfT(typeof(double?).TypeHandle)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
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
		//Discarded unreachable code: IL_00b7, IL_00c6, IL_00d6, IL_00e5
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				throw new ArgumentNullException((string)i7E0RefSLN6ok9gqjsXG(0x31326106 ^ 0x31303938));
			case 1:
				if (!HtSwXVfSsTXD8yn3p8DK(sourceType, RnRBaEfSUCgqqkjI5vfT(typeof(Money).TypeHandle)))
				{
					num2 = 4;
					break;
				}
				goto case 5;
			case 2:
				if (!HtSwXVfSsTXD8yn3p8DK(sourceType, null))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			case 4:
				if (!HtSwXVfSsTXD8yn3p8DK(sourceType, RnRBaEfSUCgqqkjI5vfT(typeof(double).TypeHandle)))
				{
					num2 = 3;
					break;
				}
				goto case 5;
			case 6:
				return sourceType == RnRBaEfSUCgqqkjI5vfT(typeof(string).TypeHandle);
			case 5:
				return true;
			case 3:
				if (sourceType == RnRBaEfSUCgqqkjI5vfT(typeof(double?).TypeHandle))
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 6;
			}
		}
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		//Discarded unreachable code: IL_0067, IL_0088, IL_00a0, IL_0106, IL_013f, IL_018a, IL_0199, IL_01a9
		int num = 8;
		double? num4 = default(double?);
		Money money = default(Money);
		TypeConverter typeConverter = default(TypeConverter);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				double? num5;
				double num3;
				switch (num2)
				{
				case 5:
					num5 = num4;
					goto IL_028a;
				case 8:
					if (HtSwXVfSsTXD8yn3p8DK(destinationType, null))
					{
						num2 = 7;
						break;
					}
					if (!HtSwXVfSsTXD8yn3p8DK(destinationType, RnRBaEfSUCgqqkjI5vfT(typeof(Money).TypeHandle)))
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 16:
					num3 = 0.0;
					goto IL_0248;
				case 7:
					throw new ArgumentNullException((string)i7E0RefSLN6ok9gqjsXG(-1858887263 ^ -1858995779));
				case 13:
					num4 = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 5;
					}
					break;
				case 6:
					if (!money.HasValue)
					{
						num2 = 16;
						break;
					}
					num3 = money.Value;
					goto IL_0248;
				case 1:
					return value;
				case 2:
					money = (Money)value;
					num2 = 10;
					break;
				case 14:
					if (money.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 9;
				case 3:
					if (money.HasValue)
					{
						num2 = 15;
						break;
					}
					goto case 13;
				case 10:
					if (HtSwXVfSsTXD8yn3p8DK(destinationType, RnRBaEfSUCgqqkjI5vfT(typeof(double).TypeHandle)))
					{
						num2 = 6;
						break;
					}
					if (!HtSwXVfSsTXD8yn3p8DK(destinationType, RnRBaEfSUCgqqkjI5vfT(typeof(double?).TypeHandle)))
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 3;
				case 9:
					return null;
				default:
					return xN7rYWfSzXBNNyGu4JJ2(typeConverter, context, culture, money.Value);
				case 4:
					throw new NotSupportedException((string)ckZbG1fiFVAaZ7hWGsHd(i7E0RefSLN6ok9gqjsXG(0x66F566B6 ^ 0x66F73EE0), RnRBaEfSUCgqqkjI5vfT(typeof(Money).TypeHandle).FullName, destinationType.FullName));
				case 11:
					typeConverter = (TypeConverter)LJSPwLfScgGxXTt4iQWc(RnRBaEfSUCgqqkjI5vfT(typeof(double).TypeHandle));
					num2 = 14;
					break;
				case 15:
					num5 = money.Value;
					goto IL_028a;
				case 12:
					{
						if (!HtSwXVfSsTXD8yn3p8DK(destinationType, RnRBaEfSUCgqqkjI5vfT(typeof(string).TypeHandle)))
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
							{
								num2 = 4;
							}
							break;
						}
						goto case 11;
					}
					IL_028a:
					return num5;
					IL_0248:
					return num3;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		//Discarded unreachable code: IL_013a, IL_0149, IL_01c3
		int num = 6;
		Money money = default(Money);
		Type type = default(Type);
		double value2 = default(double);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 16:
					money.Value = (double)value;
					num2 = 17;
					continue;
				case 18:
					money = default(Money);
					num2 = 16;
					continue;
				case 9:
					if (!HtSwXVfSsTXD8yn3p8DK(type, RnRBaEfSUCgqqkjI5vfT(typeof(Money).TypeHandle)))
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 1;
				case 14:
					return money;
				case 15:
					money.Value = value2;
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 14;
					}
					continue;
				case 7:
					money.HasValue = false;
					num2 = 3;
					continue;
				case 11:
					text = (string)value;
					num2 = 8;
					continue;
				case 6:
					if (value != null)
					{
						num2 = 5;
						continue;
					}
					goto case 10;
				case 4:
					money = default(Money);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 15;
					}
					continue;
				case 8:
				{
					if (YGclvsfiBbxEKfRdWM5G(text))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num2 = 13;
						}
						continue;
					}
					object obj = LJSPwLfScgGxXTt4iQWc(RnRBaEfSUCgqqkjI5vfT(typeof(double).TypeHandle));
					if (!culture.Equals(BHmOwnfiWn6nD8HwYAnC()))
					{
						string currencyDecimalSeparator = ((NumberFormatInfo)zSsrs6fioQwo09xNpx3S(CultureInfo.CurrentCulture)).CurrencyDecimalSeparator;
						string newValue = (string)jbuU05fibjEHP5P7dRCM(zSsrs6fioQwo09xNpx3S(culture));
						text = text.Replace(currencyDecimalSeparator, newValue);
					}
					value2 = (double)((TypeConverter)obj).ConvertFromString(context, culture, text);
					num = 4;
					break;
				}
				case 2:
					money.HasValue = false;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 0;
					}
					continue;
				case 13:
					money = default(Money);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					return money;
				case 5:
					type = value.GetType();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 9;
					}
					continue;
				case 17:
					return money;
				case 10:
					money = default(Money);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 5;
					}
					continue;
				case 1:
					return value;
				case 12:
					if (!HtSwXVfSsTXD8yn3p8DK(type, RnRBaEfSUCgqqkjI5vfT(typeof(double).TypeHandle)))
					{
						if (!HtSwXVfSsTXD8yn3p8DK(type, RnRBaEfSUCgqqkjI5vfT(typeof(string).TypeHandle)))
						{
							throw new NotSupportedException((string)ckZbG1fiFVAaZ7hWGsHd(i7E0RefSLN6ok9gqjsXG(0x34A6D230 ^ 0x34A48A66), type.FullName, RnRBaEfSUCgqqkjI5vfT(typeof(Money).TypeHandle).FullName));
						}
						num = 11;
						break;
					}
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 18;
					}
					continue;
				default:
					return money;
				}
				break;
			}
		}
	}

	public MoneyTypeConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object i7E0RefSLN6ok9gqjsXG(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type RnRBaEfSUCgqqkjI5vfT(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool HtSwXVfSsTXD8yn3p8DK(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool z9trKKfSjZxBQtc7kZIG()
	{
		return mnwrHrfS5awDvLkklbin == null;
	}

	internal static MoneyTypeConverter ogloyHfSYurTiGJN2bXX()
	{
		return mnwrHrfS5awDvLkklbin;
	}

	internal static object LJSPwLfScgGxXTt4iQWc(Type P_0)
	{
		return TypeDescriptor.GetConverter(P_0);
	}

	internal static object xN7rYWfSzXBNNyGu4JJ2(object P_0, object P_1, object P_2, object P_3)
	{
		return ((TypeConverter)P_0).ConvertToString((ITypeDescriptorContext)P_1, (CultureInfo)P_2, P_3);
	}

	internal static object ckZbG1fiFVAaZ7hWGsHd(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static bool YGclvsfiBbxEKfRdWM5G(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object BHmOwnfiWn6nD8HwYAnC()
	{
		return CultureInfo.CurrentCulture;
	}

	internal static object zSsrs6fioQwo09xNpx3S(object P_0)
	{
		return ((CultureInfo)P_0).NumberFormat;
	}

	internal static object jbuU05fibjEHP5P7dRCM(object P_0)
	{
		return ((NumberFormatInfo)P_0).CurrencyDecimalSeparator;
	}
}
