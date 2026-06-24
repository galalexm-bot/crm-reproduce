using System;
using System.ComponentModel;
using System.Globalization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Common.Models;

public class WorkTimeTypeConverter : TypeConverter
{
	internal static WorkTimeTypeConverter AR16CufS6JHkZQ1288wN;

	public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
	{
		return false;
	}

	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		//Discarded unreachable code: IL_0063, IL_0072, IL_00e7
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (G9ktJFfS70ojUrPgEMlK(destinationType, null))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num2 = 1;
						}
						break;
					}
					if (G9ktJFfS70ojUrPgEMlK(destinationType, Hhq5wmfS0Lt20e2PmO5f(typeof(WorkTime).TypeHandle)))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
						{
							num2 = 6;
						}
						break;
					}
					goto case 3;
				case 4:
					return G9ktJFfS70ojUrPgEMlK(destinationType, Hhq5wmfS0Lt20e2PmO5f(typeof(string).TypeHandle));
				case 5:
				case 6:
					return true;
				default:
					if (!G9ktJFfS70ojUrPgEMlK(destinationType, Hhq5wmfS0Lt20e2PmO5f(typeof(long?).TypeHandle)))
					{
						goto end_IL_0012;
					}
					goto case 5;
				case 3:
					if (G9ktJFfS70ojUrPgEMlK(destinationType, Hhq5wmfS0Lt20e2PmO5f(typeof(long).TypeHandle)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto default;
				case 1:
					throw new ArgumentNullException((string)DLpG5AfSxBkKSwDwcgOk(-1146510045 ^ -1146356417));
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		//Discarded unreachable code: IL_0067, IL_0076, IL_0085, IL_00da
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (!G9ktJFfS70ojUrPgEMlK(sourceType, null))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 7;
			case 7:
				throw new ArgumentNullException((string)DLpG5AfSxBkKSwDwcgOk(0x35C0467B ^ 0x35C21E45));
			case 4:
				if (G9ktJFfS70ojUrPgEMlK(sourceType, Hhq5wmfS0Lt20e2PmO5f(typeof(WorkTime).TypeHandle)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 6;
			case 2:
				if (!G9ktJFfS70ojUrPgEMlK(sourceType, typeof(long?)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			default:
				return G9ktJFfS70ojUrPgEMlK(sourceType, Hhq5wmfS0Lt20e2PmO5f(typeof(string).TypeHandle));
			case 1:
			case 3:
				return true;
			case 6:
				if (sourceType == Hhq5wmfS0Lt20e2PmO5f(typeof(long).TypeHandle))
				{
					num2 = 3;
					break;
				}
				goto case 2;
			}
		}
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		//Discarded unreachable code: IL_0087, IL_0096, IL_00f3, IL_0102, IL_0111, IL_021f, IL_022b
		int num = 1;
		WorkTime workTime = default(WorkTime);
		TypeConverter converter = default(TypeConverter);
		long? num5 = default(long?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				long? num3;
				long num4;
				switch (num2)
				{
				case 6:
					if (workTime.HasValue)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num2 = 4;
						}
						break;
					}
					goto case 11;
				case 9:
					converter = TypeDescriptor.GetConverter(typeof(long));
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 14;
					}
					break;
				case 2:
					num5 = null;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 3;
					}
					break;
				case 14:
					if (workTime.HasValue)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 13;
				default:
					throw new ArgumentNullException((string)DLpG5AfSxBkKSwDwcgOk(0x7C1EE318 ^ 0x7C1CBB04));
				case 13:
					return null;
				case 5:
					return ue1hUrfSmhufTcfjMRIj(converter, context, culture, workTime.Value);
				case 12:
					return value;
				case 1:
					if (!G9ktJFfS70ojUrPgEMlK(destinationType, null))
					{
						if (G9ktJFfS70ojUrPgEMlK(destinationType, Hhq5wmfS0Lt20e2PmO5f(typeof(WorkTime).TypeHandle)))
						{
							num2 = 12;
							break;
						}
						workTime = (WorkTime)value;
						num2 = 15;
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
						{
							num2 = 0;
						}
					}
					break;
				case 7:
					if (workTime.HasValue)
					{
						num2 = 10;
						break;
					}
					goto case 2;
				case 3:
					num3 = num5;
					goto IL_028d;
				case 11:
					num4 = 0L;
					goto IL_0257;
				case 15:
					if (G9ktJFfS70ojUrPgEMlK(destinationType, typeof(long)))
					{
						num2 = 6;
						break;
					}
					if (!(destinationType == typeof(long?)))
					{
						goto end_IL_0012;
					}
					goto case 7;
				case 4:
					num4 = workTime.Value;
					goto IL_0257;
				case 10:
					num3 = workTime.Value;
					goto IL_028d;
				case 8:
					{
						if (!(destinationType == Hhq5wmfS0Lt20e2PmO5f(typeof(string).TypeHandle)))
						{
							throw new NotSupportedException(string.Format((string)DLpG5AfSxBkKSwDwcgOk(--1360331293 ^ 0x51175A4B), Hhq5wmfS0Lt20e2PmO5f(typeof(WorkTime).TypeHandle).FullName, destinationType.FullName));
						}
						num2 = 9;
						break;
					}
					IL_028d:
					return num3;
					IL_0257:
					return num4;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 8;
		}
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		//Discarded unreachable code: IL_0111, IL_0162
		int num = 3;
		string text = default(string);
		WorkTime workTime = default(WorkTime);
		Type type = default(Type);
		long value2 = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 14:
					if (!string.IsNullOrEmpty(text))
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num2 = 16;
						}
						continue;
					}
					goto case 4;
				case 4:
					workTime = default(WorkTime);
					num2 = 12;
					continue;
				case 17:
					return workTime;
				case 10:
					text = (string)value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 14;
					}
					continue;
				default:
					workTime = default(WorkTime);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 0;
					}
					continue;
				case 13:
					if (!G9ktJFfS70ojUrPgEMlK(type, Hhq5wmfS0Lt20e2PmO5f(typeof(WorkTime).TypeHandle)))
					{
						num2 = 9;
						continue;
					}
					goto case 11;
				case 5:
					workTime = default(WorkTime);
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 18;
					}
					continue;
				case 3:
					if (value == null)
					{
						num2 = 2;
						continue;
					}
					type = value.GetType();
					num2 = 13;
					continue;
				case 12:
					break;
				case 15:
					workTime.HasValue = false;
					num2 = 8;
					continue;
				case 6:
					return workTime;
				case 16:
					value2 = (long)TypeDescriptor.GetConverter(Hhq5wmfS0Lt20e2PmO5f(typeof(long).TypeHandle)).ConvertFromString(context, culture, text);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					return workTime;
				case 2:
					workTime = default(WorkTime);
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 15;
					}
					continue;
				case 1:
					workTime.Value = value2;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 6;
					}
					continue;
				case 18:
					workTime.Value = (long)value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 17;
					}
					continue;
				case 7:
					return workTime;
				case 11:
					return value;
				case 9:
					if (!(type == Hhq5wmfS0Lt20e2PmO5f(typeof(long).TypeHandle)))
					{
						if (!(type == Hhq5wmfS0Lt20e2PmO5f(typeof(string).TypeHandle)))
						{
							throw new NotSupportedException(string.Format((string)DLpG5AfSxBkKSwDwcgOk(0x57A5235E ^ 0x57A77B08), type.FullName, Hhq5wmfS0Lt20e2PmO5f(typeof(WorkTime).TypeHandle).FullName));
						}
						num2 = 10;
					}
					else
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
						{
							num2 = 1;
						}
					}
					continue;
				}
				break;
			}
			workTime.HasValue = false;
			num = 6;
		}
	}

	public WorkTimeTypeConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		dHZWXMfSy9neDSsCwYUW();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool G9ktJFfS70ojUrPgEMlK(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object DLpG5AfSxBkKSwDwcgOk(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type Hhq5wmfS0Lt20e2PmO5f(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool AEyhgmfSHnPIOE7hCpOW()
	{
		return AR16CufS6JHkZQ1288wN == null;
	}

	internal static WorkTimeTypeConverter pkZ9T7fSArqUeEFu6LSQ()
	{
		return AR16CufS6JHkZQ1288wN;
	}

	internal static object ue1hUrfSmhufTcfjMRIj(object P_0, object P_1, object P_2, object P_3)
	{
		return ((TypeConverter)P_0).ConvertToString((ITypeDescriptorContext)P_1, (CultureInfo)P_2, P_3);
	}

	internal static void dHZWXMfSy9neDSsCwYUW()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
