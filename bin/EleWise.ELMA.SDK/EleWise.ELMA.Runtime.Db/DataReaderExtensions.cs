using System;
using System.Data;
using System.IO;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Memory;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db;

public static class DataReaderExtensions
{
	internal static DataReaderExtensions xhkxcyW8KqwbR1dlaR8K;

	public static byte[] GetBytes([NotNull] this IDataReader reader, [NotNull] string columnName)
	{
		return reader.GetBytes(reader.GetOrdinal(columnName));
	}

	public static byte[] GetBytes([NotNull] this IDataReader reader, int column)
	{
		//Discarded unreachable code: IL_0039
		int num = 2;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return null;
			case 2:
				Contract.ArgumentNotNull(reader, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70058458));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return Array.Empty<byte>();
			case 5:
				return MemoryHelper.ActionWithMemoryBuffer<byte, (IDataReader, int), byte[]>(num3, (reader, column), GetBytesAction);
			default:
				if (num3 != 0)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 4;
			case 1:
				if (!(ueexaJW8kHyrsNo8uBmK(reader, column) is DBNull))
				{
					num3 = (int)G0G5WVW8nQAHI5no9v9d(reader, column, 0L, null, 0, 0);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 3;
					}
				}
				break;
			}
		}
	}

	public static MemoryStream GetStream([NotNull] this IDataReader reader, [NotNull] string columnName)
	{
		return (MemoryStream)piw5GpW824gx0LQm0Zba(reader, QcBb0fW8OSFbqW6ZHaRE(reader, columnName));
	}

	public static MemoryStream GetStream(this IDataReader reader, int column)
	{
		int num = 4;
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					V5qOejW8PtO8cmhtyLRj(reader, FddvqVW8eLAnKsdU1R76(-583745292 ^ -583700238));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 3;
					}
					break;
				case 1:
					return null;
				case 2:
					if (num3 != 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num2 = 0;
						}
						break;
					}
					return null;
				default:
					return MemoryHelper.ActionWithMemoryBuffer<byte, (IDataReader, int), MemoryStream>(num3, (reader, column), GetStreamAction);
				case 3:
					if (!(ueexaJW8kHyrsNo8uBmK(reader, column) is DBNull))
					{
						num3 = (int)reader.GetBytes(column, 0L, null, 0, 0);
						num = 2;
						goto end_IL_0012;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 1;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
		}
	}

	private static MemoryStream GetStreamAction(object buffer, int offset, int length, (IDataReader, int) param)
	{
		var (dataReader, i) = param;
		dataReader.GetBytes(i, 0L, (byte[])buffer, offset, length);
		MemoryStream memoryStream = MemoryHelper.GetMemoryStream(length);
		memoryStream.Write((byte[])buffer, offset, length);
		memoryStream.Seek(0L, SeekOrigin.Begin);
		return memoryStream;
	}

	private static byte[] GetBytesAction(object buffer, int offset, int length, (IDataReader, int) param)
	{
		var (dataReader, i) = param;
		dataReader.GetBytes(i, 0L, (byte[])buffer, offset, length);
		byte[] array = new byte[length];
		Array.Copy((Array)buffer, offset, array, 0, length);
		return array;
	}

	internal static bool ytd3y9W8XstbfY03OfcG()
	{
		return xhkxcyW8KqwbR1dlaR8K == null;
	}

	internal static DataReaderExtensions cPuCOXW8TZNwp4Zalcrd()
	{
		return xhkxcyW8KqwbR1dlaR8K;
	}

	internal static object ueexaJW8kHyrsNo8uBmK(object P_0, int P_1)
	{
		return ((IDataRecord)P_0)[P_1];
	}

	internal static long G0G5WVW8nQAHI5no9v9d(object P_0, int P_1, long P_2, object P_3, int P_4, int P_5)
	{
		return ((IDataRecord)P_0).GetBytes(P_1, P_2, (byte[])P_3, P_4, P_5);
	}

	internal static int QcBb0fW8OSFbqW6ZHaRE(object P_0, object P_1)
	{
		return ((IDataRecord)P_0).GetOrdinal((string)P_1);
	}

	internal static object piw5GpW824gx0LQm0Zba(object P_0, int column)
	{
		return ((IDataReader)P_0).GetStream(column);
	}

	internal static object FddvqVW8eLAnKsdU1R76(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void V5qOejW8PtO8cmhtyLRj(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}
}
