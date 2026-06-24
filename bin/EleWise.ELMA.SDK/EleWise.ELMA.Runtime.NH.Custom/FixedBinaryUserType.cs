using System;
using System.Data;
using System.Data.Common;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using NHibernate.SqlTypes;
using NHibernate.UserTypes;

namespace EleWise.ELMA.Runtime.NH.CustomTypes;

[Serializable]
public class FixedBinaryUserType : IUserType
{
	private readonly SqlType[] sqlTypes;

	internal static FixedBinaryUserType XIuN8oWmiBoBudb80q83;

	public SqlType[] SqlTypes => sqlTypes;

	public Type ReturnedType => dhYv78Wm1DvClax4X1Zy(typeof(byte[]).TypeHandle);

	public bool IsMutable => true;

	bool IUserType.Equals(object x, object y)
	{
		//Discarded unreachable code: IL_006a, IL_0079
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return false;
			case 1:
				if (y != null)
				{
					return SCnguVWmKc8HwjutKTds((byte[])x, (byte[])y);
				}
				num2 = 4;
				break;
			case 3:
				if (x == y)
				{
					num2 = 2;
					break;
				}
				if (x == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 2:
				return true;
			}
		}
	}

	public int GetHashCode(object x)
	{
		//Discarded unreachable code: IL_0049, IL_0058, IL_00d7, IL_00e6, IL_0145
		int num = 9;
		int num2 = num;
		int num3 = default(int);
		byte[] array = default(byte[]);
		int num4 = default(int);
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
				if (num3 >= array.Length)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 4;
			case 1:
				num3 = 0;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
				num4 = 1;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 1;
				}
				continue;
			case 9:
				if (x != null)
				{
					num2 = 8;
					continue;
				}
				goto case 6;
			case 4:
				num4 = 31 * num4 + array[num3];
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 4;
				}
				continue;
			case 5:
				return num4;
			case 7:
				num3++;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
				continue;
			case 6:
				obj = Array.Empty<byte>();
				break;
			case 8:
				obj = (byte[])x;
				break;
			}
			array = (byte[])obj;
			num2 = 3;
		}
	}

	public object NullSafeGet(DbDataReader rs, string[] names, ISessionImplementor session, object owner)
	{
		//Discarded unreachable code: IL_0078, IL_00bb, IL_00ca, IL_0103, IL_016c, IL_017b
		object result = default(object);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				int ordinal = rs.GetOrdinal(names[0]);
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 2:
						return result;
					case 5:
						return result;
					default:
						if (!(rs[ordinal] is DBNull))
						{
							int num2 = 4;
							num = num2;
							continue;
						}
						break;
					case 1:
					case 4:
						result = rs.GetBytes(ordinal);
						num = 2;
						continue;
					case 3:
						break;
					}
					result = null;
					num = 5;
				}
			}
			catch (Exception ex)
			{
				int num3 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					default:
						return result;
					case 0:
						return result;
					case 2:
						WHHAqYWmk0FVhjVeTY2C(BHLQqEWmXvFccW2IxNvA(), TadIJbWmT9r5X1y06SyJ(ex), ex);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
						{
							num3 = 1;
						}
						break;
					case 1:
						result = null;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
						{
							num3 = 0;
						}
						break;
					}
				}
			}
		}
	}

	public void NullSafeSet(DbCommand cmd, object value, int index, ISessionImplementor session)
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
				UjJFteWm2kZF5oUvbMXm(FGBcSdWmOmG08YHKk0Ul(us41E8WmnwObbPGSvxsp(cmd), index), value ?? DBNull.Value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public object DeepCopy(object value)
	{
		//Discarded unreachable code: IL_0075, IL_0084
		int num = 3;
		int num2 = num;
		byte[] array2 = default(byte[]);
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return array2;
			case 5:
				array2 = new byte[array.Length];
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 2;
				}
				break;
			default:
				return null;
			case 2:
				array = (byte[])value;
				num2 = 5;
				break;
			case 4:
				z5OBm8WmevDtQKILPJtD(array, 0, array2, 0, array.Length);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (value != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public object Replace(object original, object target, object owner)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return original;
			case 1:
				if (!oMDCADWmP4VVssvJVPRL(this, original, target))
				{
					return DeepCopy(original);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public object Assemble(object cached, object owner)
	{
		return cached;
	}

	public object Disassemble(object value)
	{
		return value;
	}

	public FixedBinaryUserType()
	{
		//Discarded unreachable code: IL_0049, IL_004e
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		ELhTg7WmNXXYjQs7Hau2();
		sqlTypes = (SqlType[])(object)new SqlType[1]
		{
			new SqlType(DbType.Binary, int.MaxValue)
		};
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool SCnguVWmKc8HwjutKTds(object P_0, object P_1)
	{
		return CollectionExtensions.ByteArrayCompare((byte[])P_0, (byte[])P_1);
	}

	internal static bool tDGItHWmRlhaKTkKxYct()
	{
		return XIuN8oWmiBoBudb80q83 == null;
	}

	internal static FixedBinaryUserType gD1Y4RWmqh84EXbS3QiJ()
	{
		return XIuN8oWmiBoBudb80q83;
	}

	internal static object BHLQqEWmXvFccW2IxNvA()
	{
		return Logger.Log;
	}

	internal static object TadIJbWmT9r5X1y06SyJ(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void WHHAqYWmk0FVhjVeTY2C(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object us41E8WmnwObbPGSvxsp(object P_0)
	{
		return ((DbCommand)P_0).Parameters;
	}

	internal static object FGBcSdWmOmG08YHKk0Ul(object P_0, int P_1)
	{
		return ((DbParameterCollection)P_0)[P_1];
	}

	internal static void UjJFteWm2kZF5oUvbMXm(object P_0, object P_1)
	{
		((IDataParameter)P_0).Value = P_1;
	}

	internal static void z5OBm8WmevDtQKILPJtD(object P_0, int P_1, object P_2, int P_3, int P_4)
	{
		Array.Copy((Array)P_0, P_1, (Array)P_2, P_3, P_4);
	}

	internal static bool oMDCADWmP4VVssvJVPRL(object P_0, object P_1, object P_2)
	{
		return ((IUserType)P_0).Equals(P_1, P_2);
	}

	internal static Type dhYv78Wm1DvClax4X1Zy(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void ELhTg7WmNXXYjQs7Hau2()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
