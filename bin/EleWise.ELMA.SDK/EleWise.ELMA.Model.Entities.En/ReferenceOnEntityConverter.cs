using System;
using System.ComponentModel;
using System.Globalization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Entities.EntityReferences;

public class ReferenceOnEntityConverter : TypeConverter
{
	private static ReferenceOnEntityConverter R5XnQphIeuPStn8Uc1qS;

	public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
	{
		return false;
	}

	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return DT9bNShI3MsnIE90moUy(destinationType, typeof(string));
			default:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16644357));
			case 2:
				if (DT9bNShI3MsnIE90moUy(destinationType, bXgYx2hIN2WdaaxJLiwG(typeof(ReferenceOnEntity).TypeHandle)))
				{
					return true;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				if (!(destinationType == null))
				{
					num2 = 2;
					break;
				}
				goto default;
			}
		}
	}

	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		//Discarded unreachable code: IL_0035, IL_0044, IL_009a, IL_00a9
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				throw new ArgumentNullException((string)j3EVB5hIpXnLsLuFeCwu(-1767720453 ^ -1767841339));
			case 3:
				if (DT9bNShI3MsnIE90moUy(sourceType, typeof(ReferenceOnEntity)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 4:
				if (!(sourceType == null))
				{
					num2 = 3;
					break;
				}
				goto case 2;
			default:
				return sourceType == bXgYx2hIN2WdaaxJLiwG(typeof(string).TypeHandle);
			case 1:
				return true;
			}
		}
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		//Discarded unreachable code: IL_003d
		int num = 1;
		int num2 = num;
		ReferenceOnEntity referenceOnEntity = default(ReferenceOnEntity);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (referenceOnEntity == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 6;
					}
					break;
				}
				return referenceOnEntity.ToString();
			default:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751288836));
			case 2:
				referenceOnEntity = (ReferenceOnEntity)value;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 5;
				}
				break;
			case 6:
				return null;
			case 1:
				if (!(destinationType == null))
				{
					if (!DT9bNShI3MsnIE90moUy(destinationType, typeof(ReferenceOnEntity)))
					{
						num2 = 3;
						break;
					}
					goto case 4;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return value;
			case 3:
				if (!DT9bNShI3MsnIE90moUy(destinationType, bXgYx2hIN2WdaaxJLiwG(typeof(string).TypeHandle)))
				{
					throw new NotSupportedException((string)Coq7GBhIaYIe79THRI6c(j3EVB5hIpXnLsLuFeCwu(-1088304168 ^ -1088187506), bXgYx2hIN2WdaaxJLiwG(typeof(ReferenceOnEntity).TypeHandle).FullName, destinationType.FullName));
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		//Discarded unreachable code: IL_00be, IL_00cd, IL_00dd
		int num = 2;
		Type type = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return new ReferenceOnEntity((string)value);
				case 3:
					return null;
				case 1:
					type = value.GetType();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 5;
					}
					continue;
				case 2:
					if (value != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 3;
				case 4:
					return value;
				case 6:
					if (!DT9bNShI3MsnIE90moUy(type, bXgYx2hIN2WdaaxJLiwG(typeof(string).TypeHandle)))
					{
						throw new NotSupportedException((string)Coq7GBhIaYIe79THRI6c(j3EVB5hIpXnLsLuFeCwu(0x2A7797B7 ^ 0x2A75CFE1), type.FullName, typeof(ReferenceOnEntity).FullName));
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					if (!DT9bNShI3MsnIE90moUy(type, bXgYx2hIN2WdaaxJLiwG(typeof(ReferenceOnEntity).TypeHandle)))
					{
						break;
					}
					goto case 4;
				}
				break;
			}
			num = 6;
		}
	}

	public ReferenceOnEntityConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		mpbb3EhIDmRTf30SKrxr();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type bXgYx2hIN2WdaaxJLiwG(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool DT9bNShI3MsnIE90moUy(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool f5R1nehIPe0k8PYRDDwj()
	{
		return R5XnQphIeuPStn8Uc1qS == null;
	}

	internal static ReferenceOnEntityConverter PyvpLPhI1hmDw1BGsgAH()
	{
		return R5XnQphIeuPStn8Uc1qS;
	}

	internal static object j3EVB5hIpXnLsLuFeCwu(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Coq7GBhIaYIe79THRI6c(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void mpbb3EhIDmRTf30SKrxr()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
