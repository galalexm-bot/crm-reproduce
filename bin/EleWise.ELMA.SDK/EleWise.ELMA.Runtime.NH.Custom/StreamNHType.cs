using System;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Reflection;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using NHibernate.SqlTypes;
using NHibernate.UserTypes;

namespace EleWise.ELMA.Runtime.NH.CustomTypes;

public abstract class StreamNHType : IUserType
{
	private static readonly SqlType[] sqlTypes;

	internal static StreamNHType s17mbJWxCwFTvYNq16VD;

	public SqlType[] SqlTypes { get; }

	public Type ReturnedType { get; }

	public bool IsMutable { get; }

	public virtual object NullSafeGet(DbDataReader rs, string[] names, ISessionImplementor session, object owner)
	{
		//Discarded unreachable code: IL_0091, IL_00bd, IL_00cc, IL_016a, IL_0179, IL_0189, IL_0198, IL_01b4, IL_021d, IL_022c
		object result = default(object);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				int num = JGE7DbWxZaGuWpY1qsGC(rs, names[0]);
				int num2 = 10;
				int num3 = default(int);
				while (true)
				{
					int num4;
					switch (num2)
					{
					case 1:
						return result;
					case 5:
						return result;
					case 6:
						return result;
					default:
						if (num3 == 0)
						{
							break;
						}
						num4 = 4;
						goto IL_003d;
					case 8:
						result = null;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num2 = 1;
						}
						continue;
					case 10:
						if (!(T4fX45WxuMMyLfOw3aXh(rs, num) is DBNull))
						{
							num4 = 7;
							goto IL_003d;
						}
						goto case 8;
					case 7:
					case 9:
						num3 = (int)lPROMmWxIKxKDTHRMnmR(rs, num, 0L, null, 0, 0);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num2 = 0;
						}
						continue;
					case 2:
					case 4:
						result = MemoryHelper.ActionWithMemoryBuffer<byte, (DbDataReader, int), MemoryStream>(num3, (rs, num), NullSafeGetInternal);
						num2 = 6;
						continue;
					case 3:
						break;
						IL_003d:
						num2 = num4;
						continue;
					}
					result = null;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 1;
					}
				}
			}
			catch (Exception ex)
			{
				int num5 = 2;
				while (true)
				{
					switch (num5)
					{
					default:
						return result;
					case 0:
						return result;
					case 2:
						AF0DiDWxiHT3JOD3UqiN(rki4YKWxVgeNrI6JL8hP(), zvEZg2WxSWi2V1OFynYr(ex), ex);
						num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
						{
							num5 = 1;
						}
						break;
					case 1:
						result = null;
						num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num5 = 0;
						}
						break;
					}
				}
			}
		}
	}

	public virtual void NullSafeSet(DbCommand cmd, object value, int index, ISessionImplementor session)
	{
		//Discarded unreachable code: IL_0122, IL_0131
		int num = 1;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			case 3:
				cOw1LpWxK3awmI70daOp(MfcRftWxqyuQYBZ3McGL(cmd.Parameters, index), memoryStream);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				if (memoryStream.Length != 0L)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 4;
			case 4:
				cOw1LpWxK3awmI70daOp(MfcRftWxqyuQYBZ3McGL(F68iFeWxRvkE6PZZCZnX(cmd), index), DBNull.Value);
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				if (value == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					memoryStream = (MemoryStream)value;
					num2 = 5;
				}
				break;
			case 8:
				return;
			case 6:
				rQIp36WxXExtnxaWQNLI(memoryStream, 0L, SeekOrigin.Begin);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 3;
				}
				break;
			case 7:
				return;
			case 2:
				return;
			default:
				cOw1LpWxK3awmI70daOp(MfcRftWxqyuQYBZ3McGL(F68iFeWxRvkE6PZZCZnX(cmd), index), DBNull.Value);
				num2 = 7;
				break;
			}
		}
	}

	public int GetHashCode(object x)
	{
		//Discarded unreachable code: IL_0054
		int num = 1;
		int num2 = num;
		object memoryStream;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (x == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 0;
					}
					continue;
				}
				memoryStream = (MemoryStream)x;
				break;
			default:
				memoryStream = MemoryHelper.GetMemoryStream(Array.Empty<byte>(), writable: false);
				break;
			}
			break;
		}
		return ((MemoryStream)memoryStream).GetContentHashCode();
	}

	public object DeepCopy(object value)
	{
		//Discarded unreachable code: IL_0093, IL_00a2
		int num = 3;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (value != null)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 1:
				return null;
			case 2:
			{
				MemoryStream obj = (MemoryStream)value;
				memoryStream = (MemoryStream)NCu6UjWxTQdH42xV6ym9();
				rQIp36WxXExtnxaWQNLI(obj, 0L, SeekOrigin.Begin);
				OEPQnAWxkcKPmuqpTkSJ(obj, memoryStream);
				rQIp36WxXExtnxaWQNLI(memoryStream, 0L, SeekOrigin.Begin);
				rQIp36WxXExtnxaWQNLI(obj, 0L, SeekOrigin.Begin);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num2 = 0;
				}
				break;
			}
			default:
				return memoryStream;
			}
		}
	}

	public object Replace(object original, object target, object owner)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (((IUserType)this).Equals(original, target))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return DeepCopy(original);
			default:
				return original;
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

	private MemoryStream NullSafeGetInternal(byte[] buffer, int offset, int length, (DbDataReader, int) param)
	{
		(DbDataReader, int) tuple = param;
		DbDataReader item = tuple.Item1;
		int item2 = tuple.Item2;
		MemoryStream memoryStream = MemoryHelper.GetMemoryStream(length);
		try
		{
			item.GetBytes(item2, 0L, buffer, offset, length);
			memoryStream.Write(buffer, offset, length);
			memoryStream.Seek(0L, SeekOrigin.Begin);
			return memoryStream;
		}
		catch
		{
			memoryStream?.Dispose();
			throw;
		}
	}

	bool IUserType.Equals(object x, object y)
	{
		//Discarded unreachable code: IL_0076
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (y != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 3:
				if (x == y)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 2;
					}
					break;
				}
				if (x != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			case 2:
				return true;
			case 4:
				return false;
			default:
			{
				MemoryStream obj = (MemoryStream)x;
				MemoryStream memoryStream = (MemoryStream)y;
				return sagVZuWxnTeoOp4phLyv(obj, memoryStream);
			}
			}
		}
	}

	protected StreamNHType()
	{
		//Discarded unreachable code: IL_0056, IL_005b
		rmsaXOWxOdpfIERhfyGQ();
		SqlTypes = sqlTypes;
		ReturnedType = TypeOf<MemoryStream>.Raw;
		IsMutable = true;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static StreamNHType()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				sqlTypes = (SqlType[])(object)new SqlType[1]
				{
					new SqlType(DbType.Binary, int.MaxValue)
				};
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static int JGE7DbWxZaGuWpY1qsGC(object P_0, object P_1)
	{
		return ((DbDataReader)P_0).GetOrdinal((string)P_1);
	}

	internal static object T4fX45WxuMMyLfOw3aXh(object P_0, int P_1)
	{
		return ((DbDataReader)P_0)[P_1];
	}

	internal static long lPROMmWxIKxKDTHRMnmR(object P_0, int P_1, long P_2, object P_3, int P_4, int P_5)
	{
		return ((DbDataReader)P_0).GetBytes(P_1, P_2, (byte[])P_3, P_4, P_5);
	}

	internal static object rki4YKWxVgeNrI6JL8hP()
	{
		return Logger.Log;
	}

	internal static object zvEZg2WxSWi2V1OFynYr(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void AF0DiDWxiHT3JOD3UqiN(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static bool XlEnAEWxvOyp7D869pAf()
	{
		return s17mbJWxCwFTvYNq16VD == null;
	}

	internal static StreamNHType TXYg28Wx83M3CsWQklrN()
	{
		return s17mbJWxCwFTvYNq16VD;
	}

	internal static object F68iFeWxRvkE6PZZCZnX(object P_0)
	{
		return ((DbCommand)P_0).Parameters;
	}

	internal static object MfcRftWxqyuQYBZ3McGL(object P_0, int P_1)
	{
		return ((DbParameterCollection)P_0)[P_1];
	}

	internal static void cOw1LpWxK3awmI70daOp(object P_0, object P_1)
	{
		((IDataParameter)P_0).Value = P_1;
	}

	internal static long rQIp36WxXExtnxaWQNLI(object P_0, long P_1, SeekOrigin P_2)
	{
		return ((Stream)P_0).Seek(P_1, P_2);
	}

	internal static object NCu6UjWxTQdH42xV6ym9()
	{
		return MemoryHelper.GetMemoryStream();
	}

	internal static void OEPQnAWxkcKPmuqpTkSJ(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static bool sagVZuWxnTeoOp4phLyv(object P_0, object P_1)
	{
		return ((MemoryStream)P_0).Compare((MemoryStream)P_1);
	}

	internal static void rmsaXOWxOdpfIERhfyGQ()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
