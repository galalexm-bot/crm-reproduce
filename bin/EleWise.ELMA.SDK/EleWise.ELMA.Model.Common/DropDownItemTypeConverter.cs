using System;
using System.ComponentModel;
using System.Globalization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Common;

public class DropDownItemTypeConverter : TypeConverter
{
	private static DropDownItemTypeConverter m6L1bwhKaXjc0BkKLkMQ;

	public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
	{
		return false;
	}

	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		//Discarded unreachable code: IL_0035, IL_0044, IL_0053
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!qdWlSMhKwdyP5bOEtX8h(destinationType, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				throw new ArgumentNullException((string)rTLXE7hK4OxZ3SkGJmUk(-1765851862 ^ -1765972682));
			default:
				if (qdWlSMhKwdyP5bOEtX8h(destinationType, JUOlMghK6uAr6ecpRgO0(typeof(DropDownItem).TypeHandle)))
				{
					num2 = 4;
					break;
				}
				goto case 3;
			case 3:
				return qdWlSMhKwdyP5bOEtX8h(destinationType, JUOlMghK6uAr6ecpRgO0(typeof(string).TypeHandle));
			case 4:
				return true;
			}
		}
	}

	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		//Discarded unreachable code: IL_005a, IL_0069
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return sourceType == typeof(string);
			case 3:
				if (!qdWlSMhKwdyP5bOEtX8h(sourceType, null))
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 1:
				throw new ArgumentNullException((string)rTLXE7hK4OxZ3SkGJmUk(-1867198571 ^ -1867081813));
			case 2:
				if (qdWlSMhKwdyP5bOEtX8h(sourceType, typeof(DropDownItem)))
				{
					return true;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		//Discarded unreachable code: IL_011d, IL_012c, IL_013b, IL_014b, IL_015a
		int num = 1;
		int num2 = num;
		DropDownItem dropDownItem = default(DropDownItem);
		while (true)
		{
			switch (num2)
			{
			case 2:
				throw new ArgumentNullException((string)rTLXE7hK4OxZ3SkGJmUk(0x53FA00CE ^ 0x53F858D2));
			default:
				if (qdWlSMhKwdyP5bOEtX8h(destinationType, JUOlMghK6uAr6ecpRgO0(typeof(DropDownItem).TypeHandle)))
				{
					num2 = 6;
					break;
				}
				if (!qdWlSMhKwdyP5bOEtX8h(destinationType, JUOlMghK6uAr6ecpRgO0(typeof(string).TypeHandle)))
				{
					num2 = 4;
					break;
				}
				goto case 3;
			case 1:
				if (!(destinationType == null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 6:
				return value;
			case 3:
				dropDownItem = (DropDownItem)value;
				num2 = 8;
				break;
			case 7:
				return null;
			case 5:
				return dropDownItem.ToString();
			case 4:
				throw new NotSupportedException((string)Ywlj8ihKHdUROHVYi6yI(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A42E49), typeof(DropDownItem).FullName, destinationType.FullName));
			case 8:
				if (dropDownItem != null)
				{
					num2 = 5;
					break;
				}
				goto case 7;
			}
		}
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		//Discarded unreachable code: IL_006f, IL_007e, IL_0125
		int num = 3;
		int num2 = num;
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return value;
			case 1:
				if (qdWlSMhKwdyP5bOEtX8h(type, JUOlMghK6uAr6ecpRgO0(typeof(string).TypeHandle)))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 4;
					}
					break;
				}
				throw new NotSupportedException((string)Ywlj8ihKHdUROHVYi6yI(rTLXE7hK4OxZ3SkGJmUk(-234299632 ^ -234191034), type.FullName, JUOlMghK6uAr6ecpRgO0(typeof(DropDownItem).TypeHandle).FullName));
			case 6:
				return null;
			case 2:
				type = value.GetType();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return new DropDownItem((string)value);
			default:
				if (!qdWlSMhKwdyP5bOEtX8h(type, JUOlMghK6uAr6ecpRgO0(typeof(DropDownItem).TypeHandle)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 5;
			case 3:
				if (value != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 6;
			}
		}
	}

	public DropDownItemTypeConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool qdWlSMhKwdyP5bOEtX8h(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object rTLXE7hK4OxZ3SkGJmUk(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type JUOlMghK6uAr6ecpRgO0(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool A7WLRhhKDUH68dv1xV9r()
	{
		return m6L1bwhKaXjc0BkKLkMQ == null;
	}

	internal static DropDownItemTypeConverter erMZ08hKtPap0ZphNBbw()
	{
		return m6L1bwhKaXjc0BkKLkMQ;
	}

	internal static object Ywlj8ihKHdUROHVYi6yI(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}
}
