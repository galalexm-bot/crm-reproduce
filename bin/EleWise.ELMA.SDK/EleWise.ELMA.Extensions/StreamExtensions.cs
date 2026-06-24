using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.Memory;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public static class StreamExtensions
{
	internal static StreamExtensions E4bIBFGtgUKZRfUjQRP3;

	public static byte[] ReadAllBytes(this Stream stream)
	{
		//Discarded unreachable code: IL_007a, IL_00c9, IL_00e8, IL_00f7, IL_0124, IL_0133
		int num = 1;
		int num2 = num;
		byte[] result = default(byte[]);
		MemoryStream memoryStream = default(MemoryStream);
		MemoryStream memoryStream2 = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				if ((memoryStream = stream as MemoryStream) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					memoryStream2 = (memoryStream = MemoryHelper.GetMemoryStream());
					num2 = 3;
				}
				break;
			case 3:
				try
				{
					bwy9YgGtYY1sMB7KL3Kj(stream, memoryStream);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							return result;
						}
						result = (byte[])IQtKajGtLDWaD8tvXf14(memoryStream);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
						{
							num3 = 1;
						}
					}
				}
				finally
				{
					int num4;
					if (memoryStream2 == null)
					{
						num4 = 2;
						goto IL_00cd;
					}
					goto IL_0102;
					IL_00cd:
					switch (num4)
					{
					case 2:
						goto end_IL_00b8;
					case 1:
						goto end_IL_00b8;
					}
					goto IL_0102;
					IL_0102:
					((IDisposable)memoryStream2).Dispose();
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num4 = 1;
					}
					goto IL_00cd;
					end_IL_00b8:;
				}
			default:
				return memoryStream.ToArray();
			}
		}
	}

	public static void CopyAllBytesToStream(this Stream source, Stream destination)
	{
		//Discarded unreachable code: IL_006e, IL_00a2, IL_00ca, IL_00e9, IL_00f8, IL_0146, IL_017e, IL_018d
		int num = 3;
		int num2 = num;
		Stream stream = default(Stream);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				lhiySPGts4yfY1NHyQP3(source, UBsgpoGtU2OS2em8vEpU(-97972138 ^ -97969424));
				num2 = 2;
				break;
			case 1:
				try
				{
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					}
					try
					{
						bwy9YgGtYY1sMB7KL3Kj(source, destination);
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
						return;
					}
					finally
					{
						int num5;
						if (destination == null)
						{
							num5 = 2;
							goto IL_00ce;
						}
						goto IL_0103;
						IL_00ce:
						switch (num5)
						{
						case 2:
							goto end_IL_00b9;
						case 1:
							goto end_IL_00b9;
						}
						goto IL_0103;
						IL_0103:
						hTSvXYGtcVrIeG1eEnLl(destination);
						num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num5 = 1;
						}
						goto IL_00ce;
						end_IL_00b9:;
					}
				}
				finally
				{
					if (stream != null)
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								((IDisposable)stream).Dispose();
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
								{
									num6 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 2:
				Contract.ArgumentNotNull(destination, (string)UBsgpoGtU2OS2em8vEpU(--1418440330 ^ 0x548850C6));
				num2 = 4;
				break;
			case 0:
				return;
			case 4:
				stream = source;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public static void SaveToFile(this Stream stream, string filePath)
	{
		//Discarded unreachable code: IL_0058, IL_0090, IL_00c8
		int num = 2;
		int num2 = num;
		FileStream fileStream = default(FileStream);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			default:
				try
				{
					bwy9YgGtYY1sMB7KL3Kj(stream, fileStream);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				finally
				{
					if (fileStream != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								hTSvXYGtcVrIeG1eEnLl(fileStream);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 4;
			case 4:
				U3UoMBGwF9AmFlcD8L9O(stream, 0L, SeekOrigin.Begin);
				num2 = 3;
				break;
			case 2:
				lhiySPGts4yfY1NHyQP3(stream, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A50C8C));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				W0KuAOGtzP5R2s4xZ1h5(filePath, UBsgpoGtU2OS2em8vEpU(0xA592A41 ^ 0xA5AD427));
				num2 = 5;
				break;
			case 5:
				fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static Task<int> ReadAsync(this Stream stream, byte[] buffer, int offset, int count)
	{
		Contract.ArgumentNotNull(stream, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710657930));
		return Task<int>.Factory.FromAsync(stream.BeginRead, stream.EndRead, buffer, offset, count, stream);
	}

	public static Task WriteAsync(this Stream stream, byte[] buffer, int offset, int count)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Contract.ArgumentNotNull(stream, (string)UBsgpoGtU2OS2em8vEpU(-1852837372 ^ -1853084488));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return ((TaskFactory)d5PmTLGwBAoMSoxX4RRX()).FromAsync((Func<byte[], int, int, AsyncCallback, object, IAsyncResult>)stream.BeginWrite, (Action<IAsyncResult>)stream.EndWrite, buffer, offset, count, (object)stream);
			}
		}
	}

	public static Task<byte[]> ReadAllBytesAsync(this Stream stream)
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals0.stream = stream;
		Contract.ArgumentNotNull(CS_0024_003C_003E8__locals0.stream, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x832AA8E));
		int requiredSize = (int)(CS_0024_003C_003E8__locals0.stream.CanSeek ? CS_0024_003C_003E8__locals0.stream.Length : 0);
		CS_0024_003C_003E8__locals0.readData = MemoryHelper.GetMemoryStream(requiredSize);
		return CS_0024_003C_003E8__locals0.stream.CopyStreamToStreamAsync(CS_0024_003C_003E8__locals0.readData).ContinueWith(delegate(Task t)
		{
			//Discarded unreachable code: IL_004e, IL_0081, IL_00e4, IL_013d, IL_0175, IL_0184
			int num = 2;
			int num2 = num;
			byte[] result = default(byte[]);
			Stream stream2 = default(Stream);
			while (true)
			{
				switch (num2)
				{
				default:
					return result;
				case 1:
					try
					{
						MemoryStream readData = CS_0024_003C_003E8__locals0.readData;
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						default:
							try
							{
								_003C_003Ec__DisplayClass6_0.KPqWS58boA5Usir6DaRQ(t);
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
								{
									num4 = 0;
								}
								while (true)
								{
									switch (num4)
									{
									case 1:
										return result;
									default:
										result = (byte[])_003C_003Ec__DisplayClass6_0.uPV9AS8bbC7GoAt0X3Xj(CS_0024_003C_003E8__locals0.readData);
										num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
										{
											num4 = 1;
										}
										break;
									}
								}
							}
							finally
							{
								if (readData != null)
								{
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
									{
										num5 = 0;
									}
									while (true)
									{
										switch (num5)
										{
										default:
											_003C_003Ec__DisplayClass6_0.lQC6Ul8bh9A0NFnw1XjS(readData);
											num5 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
											{
												num5 = 0;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
							}
						}
					}
					finally
					{
						if (stream2 != null)
						{
							int num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
							{
								num6 = 1;
							}
							while (true)
							{
								switch (num6)
								{
								case 1:
									_003C_003Ec__DisplayClass6_0.lQC6Ul8bh9A0NFnw1XjS(stream2);
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
									{
										num6 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
				case 2:
					stream2 = CS_0024_003C_003E8__locals0.stream;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
	}

	public static Task CopyStreamToStreamAsync(this Stream source, Stream destination)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				lhiySPGts4yfY1NHyQP3(source, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x202610E9));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				Contract.ArgumentNotNull(destination, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -575972888));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return Task.Factory.Iterate(CopyStreamIterator(source, destination));
			}
		}
	}

	[IteratorStateMachine(typeof(_003CCopyStreamIterator_003Ed__8))]
	private static IEnumerable<Task> CopyStreamIterator(object input, object output)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CCopyStreamIterator_003Ed__8(-2)
		{
			_003C_003E3__input = (Stream)input,
			_003C_003E3__output = (Stream)output
		};
	}

	internal static void bwy9YgGtYY1sMB7KL3Kj(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static object IQtKajGtLDWaD8tvXf14(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static bool GO9h7YGt5wbFUILjvjpV()
	{
		return E4bIBFGtgUKZRfUjQRP3 == null;
	}

	internal static StreamExtensions WmqOa3GtjqVp9IrCnfp4()
	{
		return E4bIBFGtgUKZRfUjQRP3;
	}

	internal static object UBsgpoGtU2OS2em8vEpU(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void lhiySPGts4yfY1NHyQP3(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void hTSvXYGtcVrIeG1eEnLl(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void W0KuAOGtzP5R2s4xZ1h5(object P_0, object P_1)
	{
		Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static long U3UoMBGwF9AmFlcD8L9O(object P_0, long P_1, SeekOrigin P_2)
	{
		return ((Stream)P_0).Seek(P_1, P_2);
	}

	internal static object d5PmTLGwBAoMSoxX4RRX()
	{
		return Task.Factory;
	}
}
