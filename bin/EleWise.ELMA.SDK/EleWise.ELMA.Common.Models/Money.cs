using System;
using System.ComponentModel;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Common.Models;

[Component]
[TypeConverter(typeof(MoneyTypeConverter))]
public struct Money : IComparable, IXsiType
{
	private double value;

	private bool hasValue;

	private static object vb3FJFfSMse5ODPSJfSG;

	public double Value
	{
		get
		{
			return value;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					this.value = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					hasValue = true;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public bool HasValue
	{
		get
		{
			return hasValue;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					hasValue = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override string ToString()
	{
		//Discarded unreachable code: IL_007a, IL_0089
		int num = 1;
		double num3 = default(double);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return num3.ToString();
				case 2:
					return "";
				case 1:
					if (HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				}
				break;
			}
			num3 = Value;
			num = 3;
		}
	}

	public static implicit operator double(Money m)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!m.HasValue)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					break;
				}
				return m.Value;
			default:
				return 0.0;
			}
		}
	}

	public static implicit operator Money(double d)
	{
		int num = 1;
		int num2 = num;
		Money result = default(Money);
		while (true)
		{
			switch (num2)
			{
			default:
				result.Value = d;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return result;
			case 1:
				result = default(Money);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public int CompareTo(object obj)
	{
		//Discarded unreachable code: IL_003d, IL_0178
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return Compare((double?)obj);
			case 4:
				if (obj == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 3;
					}
					break;
				}
				if (!oZwlV0fSgLMywJ57JJlY(obj.GetType(), ec9oHDfSrP87Uum4dStk(typeof(Money).TypeHandle)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 6;
			case 5:
				return Compare((double)obj);
			default:
				throw new InvalidOperationException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107666852)), aJLArVfSld2s4wtJ6puu(MauWOcfSdwlQwWBYIfBU(-583745292 ^ -583645290)), obj.GetType().FullName));
			case 3:
				throw new InvalidOperationException(SR.T((string)MauWOcfSdwlQwWBYIfBU(0x18A6761F ^ 0x18A337FD), aJLArVfSld2s4wtJ6puu(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978640496))));
			case 6:
				return Compare(((Money)obj).HasValue ? new double?(((Money)obj).Value) : null);
			case 1:
				if (!oZwlV0fSgLMywJ57JJlY(obj.GetType(), ec9oHDfSrP87Uum4dStk(typeof(double?).TypeHandle)))
				{
					if (!(obj.GetType() == ec9oHDfSrP87Uum4dStk(typeof(double).TypeHandle)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 5;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private int Compare(double? value)
	{
		int num = HasValue.CompareTo(value.HasValue);
		if (num == 0 && HasValue)
		{
			return Value.CompareTo(value);
		}
		return num;
	}

	internal static bool n20DSJfSJyAFunc6wRlM()
	{
		return vb3FJFfSMse5ODPSJfSG == null;
	}

	internal static object Opbi8NfS98EgMwXwmhhS()
	{
		return vb3FJFfSMse5ODPSJfSG;
	}

	internal static object MauWOcfSdwlQwWBYIfBU(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object aJLArVfSld2s4wtJ6puu(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static Type ec9oHDfSrP87Uum4dStk(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool oZwlV0fSgLMywJ57JJlY(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}
}
