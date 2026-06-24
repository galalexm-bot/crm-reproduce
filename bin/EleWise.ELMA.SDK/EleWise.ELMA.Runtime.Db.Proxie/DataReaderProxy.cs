using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Driver;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Proxies;

public class DataReaderProxy : DbDataReader, IDataReaderProxy, IDataReader, IDisposable, IDataRecord
{
	private class Interceptor : IDisposable
	{
		private readonly object queryInfo;

		private readonly int affectedRows;

		private object stopwatch;

		internal static object kL19bEQwZoIMqhkkHcCp;

		public Interceptor(DataReaderProxy owner, int affectedRows = 0)
		{
			//Discarded unreachable code: IL_001a, IL_001f, IL_00dd, IL_00f0, IL_00ff
			fgLalyQwVKmOm0dqU3bO();
			base._002Ector();
			int num = 5;
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					if (eRX9j5QwSeW6NeO7fcXy(queryInfo))
					{
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num = 0;
						}
						break;
					}
					goto case 7;
				case 7:
					stopwatch = Stopwatch.StartNew();
					num = 3;
					break;
				case 6:
					this.affectedRows = affectedRows;
					num = 2;
					break;
				case 2:
					if (queryInfo == null)
					{
						num = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num = 4;
						}
						break;
					}
					goto case 1;
				case 5:
					queryInfo = owner.queryInfo;
					num = 6;
					break;
				case 0:
					return;
				case 4:
					return;
				case 3:
					return;
				}
			}
		}

		public void Dispose()
		{
			//Discarded unreachable code: IL_004d, IL_00c9, IL_00d8
			int num = 10;
			long? rowsAffected = default(long?);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 9:
						if (((SqlQueryInfo)queryInfo).IsEmpty)
						{
							num2 = 3;
							continue;
						}
						((Stopwatch)stopwatch).Stop();
						num = 2;
						break;
					case 2:
						rowsAffected = ((SqlQueryInfo)queryInfo).RowsAffected;
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num2 = 7;
						}
						continue;
					case 5:
						((SqlQueryInfo)queryInfo).RowsAffected = 1L;
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num2 = 8;
						}
						continue;
					case 3:
						return;
					case 7:
						if (rowsAffected.HasValue)
						{
							num2 = 6;
							continue;
						}
						goto case 5;
					case 4:
					case 8:
					{
						object obj2 = queryInfo;
						BYLyjaQwK1mLbVXY7KbG(obj2, mKneKhQwqMIMBYLM6Ugg(crtJBiQwiNBr4ZUZrhdO(obj2), GibgRtQwRr3vuvfrBuTU(stopwatch)));
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					case 1:
						return;
					case 10:
						if (queryInfo == null)
						{
							return;
						}
						num = 9;
						break;
					default:
					{
						object obj = queryInfo;
						rowsAffected = ((SqlQueryInfo)obj).RowsAffected;
						long num3 = affectedRows;
						((SqlQueryInfo)obj).RowsAffected = rowsAffected + num3;
						num2 = 4;
						continue;
					}
					}
					break;
				}
			}
		}

		internal static void fgLalyQwVKmOm0dqU3bO()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool eRX9j5QwSeW6NeO7fcXy(object P_0)
		{
			return ((SqlQueryInfo)P_0).IsEmpty;
		}

		internal static bool Hi7ebYQwuDqxswlyADAM()
		{
			return kL19bEQwZoIMqhkkHcCp == null;
		}

		internal static Interceptor ivpOgiQwITbxUEYew2Ij()
		{
			return (Interceptor)kL19bEQwZoIMqhkkHcCp;
		}

		internal static TimeSpan crtJBiQwiNBr4ZUZrhdO(object P_0)
		{
			return ((SqlQueryInfo)P_0).ReadTime;
		}

		internal static TimeSpan GibgRtQwRr3vuvfrBuTU(object P_0)
		{
			return ((Stopwatch)P_0).Elapsed;
		}

		internal static TimeSpan mKneKhQwqMIMBYLM6Ugg(TimeSpan P_0, TimeSpan P_1)
		{
			return P_0 + P_1;
		}

		internal static void BYLyjaQwK1mLbVXY7KbG(object P_0, TimeSpan value)
		{
			((SqlQueryInfo)P_0).ReadTime = value;
		}
	}

	private readonly DbDataReader reader;

	private readonly DbCommand cmd;

	private readonly SqlQueryInfo queryInfo;

	internal static DataReaderProxy nCblicWR6DQB7Py6Nej8;

	public DbDataReader Target => reader;

	public override int Depth
	{
		get
		{
			//Discarded unreachable code: IL_0073, IL_00ab, IL_00e3, IL_00f2
			int num = 2;
			int num2 = num;
			Interceptor interceptor = default(Interceptor);
			int result = default(int);
			while (true)
			{
				switch (num2)
				{
				case 2:
					interceptor = new Interceptor(this);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					try
					{
						result = reader.Depth;
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num3 = 0;
						}
						return num3 switch
						{
							0 => result, 
							_ => result, 
						};
					}
					finally
					{
						if (interceptor != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									((IDisposable)interceptor).Dispose();
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
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
				default:
					return result;
				}
			}
		}
	}

	public override bool IsClosed
	{
		get
		{
			//Discarded unreachable code: IL_0050, IL_0088, IL_00c8, IL_00d7, IL_00e3, IL_00f2
			int num = 2;
			int num2 = num;
			Interceptor interceptor = default(Interceptor);
			bool result = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 1:
					try
					{
						result = f79cDAWRMDO3H7FpJ7qi(reader);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
						{
							num3 = 0;
						}
						return num3 switch
						{
							0 => result, 
							_ => result, 
						};
					}
					finally
					{
						int num4;
						if (interceptor == null)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
							{
								num4 = 0;
							}
							goto IL_008c;
						}
						goto IL_00a2;
						IL_00a2:
						CxTUe5WRmNMaEGpiZkAQ(interceptor);
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num4 = 2;
						}
						goto IL_008c;
						IL_008c:
						switch (num4)
						{
						default:
							goto end_IL_0067;
						case 1:
							break;
						case 0:
							goto end_IL_0067;
						case 2:
							goto end_IL_0067;
						}
						goto IL_00a2;
						end_IL_0067:;
					}
				case 2:
					interceptor = new Interceptor(this);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 1;
					}
					break;
				default:
					return result;
				}
			}
		}
	}

	public override int RecordsAffected
	{
		get
		{
			//Discarded unreachable code: IL_0050, IL_0088, IL_00c0, IL_00cf
			int num = 2;
			int num2 = num;
			Interceptor interceptor = default(Interceptor);
			int result = default(int);
			while (true)
			{
				switch (num2)
				{
				case 1:
					try
					{
						result = g2PmjXWRrYardsRD18er(reader);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num3 = 0;
						}
						return num3 switch
						{
							0 => result, 
							_ => result, 
						};
					}
					finally
					{
						if (interceptor != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									CxTUe5WRmNMaEGpiZkAQ(interceptor);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
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
				case 2:
					interceptor = new Interceptor(this);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return result;
				}
			}
		}
	}

	public override int FieldCount
	{
		get
		{
			//Discarded unreachable code: IL_0076, IL_00ae, IL_00cd, IL_00f9, IL_0108
			int num = 2;
			int num2 = num;
			Interceptor interceptor = default(Interceptor);
			int num3 = default(int);
			while (true)
			{
				switch (num2)
				{
				default:
					return num3;
				case 2:
					interceptor = new Interceptor(this);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					try
					{
						num3 = cqcpAIWR5mavqTCI6ASm(reader);
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num4 = 0;
						}
						return num4 switch
						{
							0 => num3, 
							_ => num3, 
						};
					}
					finally
					{
						int num5;
						if (interceptor == null)
						{
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
							{
								num5 = 0;
							}
							goto IL_00b2;
						}
						goto IL_00d7;
						IL_00d7:
						((IDisposable)interceptor).Dispose();
						num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num5 = 0;
						}
						goto IL_00b2;
						IL_00b2:
						switch (num5)
						{
						default:
							goto end_IL_008d;
						case 0:
							goto end_IL_008d;
						case 2:
							break;
						case 1:
							goto end_IL_008d;
						}
						goto IL_00d7;
						end_IL_008d:;
					}
				}
			}
		}
	}

	public override bool HasRows => reader.HasRows;

	public override object this[string name]
	{
		get
		{
			//Discarded unreachable code: IL_0077, IL_00af, IL_00e7, IL_00f6
			int num = 2;
			int num2 = num;
			Interceptor interceptor = default(Interceptor);
			object obj = default(object);
			while (true)
			{
				switch (num2)
				{
				default:
					return obj;
				case 2:
					interceptor = new Interceptor(this);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					try
					{
						obj = enZwgbWqC8vl3pkqmVkb(reader, name);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num3 = 0;
						}
						return num3 switch
						{
							0 => obj, 
							_ => obj, 
						};
					}
					finally
					{
						if (interceptor != null)
						{
							int num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									((IDisposable)interceptor).Dispose();
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
									{
										num4 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
				}
			}
		}
	}

	public override object this[int ordinal]
	{
		get
		{
			//Discarded unreachable code: IL_0077, IL_00af, IL_00e7, IL_00f6
			int num = 2;
			int num2 = num;
			Interceptor interceptor = default(Interceptor);
			object obj = default(object);
			while (true)
			{
				switch (num2)
				{
				default:
					return obj;
				case 2:
					interceptor = new Interceptor(this);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					try
					{
						obj = reader[ordinal];
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num3 = 0;
						}
						return num3 switch
						{
							0 => obj, 
							_ => obj, 
						};
					}
					finally
					{
						if (interceptor != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									CxTUe5WRmNMaEGpiZkAQ(interceptor);
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
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
				}
			}
		}
	}

	public DataReaderProxy(DbDataReader reader, DbCommand cmd)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		FnHFuaWR7VKJsSsmj1Kw();
		base._002Ector();
		int num = 3;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			default:
				throw new ArgumentNullException((string)m9hA2cWRxCRFKUFdlubn(0x103FE975 ^ 0x103E187B));
			case 3:
				if (reader != null)
				{
					this.reader = reader;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num = 0;
					}
				}
				else
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num = 0;
					}
				}
				break;
			case 2:
				return;
			case 1:
				this.cmd = cmd;
				num = 2;
				break;
			}
		}
	}

	public DataReaderProxy(DbDataReader reader, DbCommand cmd, SqlQueryInfo queryInfo)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		FnHFuaWR7VKJsSsmj1Kw();
		this._002Ector(reader, cmd);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.queryInfo = queryInfo;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override void Close()
	{
		//Discarded unreachable code: IL_0071, IL_0099, IL_00d9, IL_00e8, IL_00f4, IL_0103
		int num = 1;
		int num2 = num;
		Interceptor interceptor = default(Interceptor);
		while (true)
		{
			switch (num2)
			{
			case 1:
				interceptor = new Interceptor(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				NmUk09WR0ajm0VIQlhwu(reader);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				case 0:
					break;
				}
				return;
			}
			finally
			{
				int num4;
				if (interceptor == null)
				{
					num4 = 2;
					goto IL_009d;
				}
				goto IL_00b3;
				IL_009d:
				switch (num4)
				{
				default:
					goto end_IL_0088;
				case 1:
					break;
				case 2:
					goto end_IL_0088;
				case 0:
					goto end_IL_0088;
				}
				goto IL_00b3;
				IL_00b3:
				CxTUe5WRmNMaEGpiZkAQ(interceptor);
				num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num4 = 0;
				}
				goto IL_009d;
				end_IL_0088:;
			}
		}
	}

	public override DataTable GetSchemaTable()
	{
		//Discarded unreachable code: IL_0050, IL_0088, IL_00c0, IL_00cf
		int num = 1;
		int num2 = num;
		Interceptor interceptor = default(Interceptor);
		DataTable result = default(DataTable);
		while (true)
		{
			switch (num2)
			{
			case 1:
				interceptor = new Interceptor(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				result = (DataTable)dlKYy8WRy6ZHPpxgdWCj(reader);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			finally
			{
				if (interceptor != null)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							CxTUe5WRmNMaEGpiZkAQ(interceptor);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
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
		}
	}

	public override bool NextResult()
	{
		//Discarded unreachable code: IL_0053, IL_008b, IL_00cb, IL_00da, IL_00e6, IL_00f5
		int num = 1;
		int num2 = num;
		Interceptor interceptor = default(Interceptor);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				interceptor = new Interceptor(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				result = IcdQMZWRJyVtcEFpwORS(reader);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			finally
			{
				int num4;
				if (interceptor == null)
				{
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num4 = 0;
					}
					goto IL_008f;
				}
				goto IL_00a5;
				IL_00a5:
				CxTUe5WRmNMaEGpiZkAQ(interceptor);
				num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num4 = 2;
				}
				goto IL_008f;
				IL_008f:
				switch (num4)
				{
				default:
					goto end_IL_006a;
				case 1:
					break;
				case 0:
					goto end_IL_006a;
				case 2:
					goto end_IL_006a;
				}
				goto IL_00a5;
				end_IL_006a:;
			}
		}
	}

	public override bool Read()
	{
		//Discarded unreachable code: IL_0077, IL_00aa, IL_00e6, IL_0101, IL_0110, IL_0120, IL_01f3, IL_022b, IL_023a
		int num = 2;
		int num2 = num;
		Interceptor interceptor = default(Interceptor);
		bool flag = default(bool);
		IUnitOfWorkManager service = default(IUnitOfWorkManager);
		ITransformationProvider transformationProvider = default(ITransformationProvider);
		while (true)
		{
			switch (num2)
			{
			case 2:
				interceptor = new Interceptor(this, 1);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return flag;
			case 1:
				try
				{
					flag = fgDmm3WR9V4IsukavHns(reader);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => flag, 
						_ => flag, 
					};
				}
				catch (Exception ex)
				{
					int num4 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num4 = 4;
					}
					while (true)
					{
						object obj;
						switch (num4)
						{
						case 5:
							obj = null;
							goto IL_01c4;
						case 6:
							service = Locator.GetService<IUnitOfWorkManager>();
							num4 = 9;
							continue;
						case 9:
							if (service == null)
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
								{
									num4 = 0;
								}
								continue;
							}
							goto case 2;
						case 4:
							if (!VtHUoZWRdE97SfLvxRwb())
							{
								num4 = 5;
								continue;
							}
							obj = Locator.GetService<ITransformationProvider>();
							goto IL_01c4;
						case 1:
							if (!KhPLLsWRlT8GL25j26C8(transformationProvider, ex))
							{
								num4 = 7;
								continue;
							}
							goto case 6;
						case 2:
							service.ThrowExceptionOnCommit(ex);
							num4 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
							{
								num4 = 3;
							}
							continue;
						case 8:
							{
								if (transformationProvider != null)
								{
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
									{
										num4 = 0;
									}
									continue;
								}
								break;
							}
							IL_01c4:
							transformationProvider = (ITransformationProvider)obj;
							num4 = 8;
							continue;
						}
						break;
					}
					throw;
				}
				finally
				{
					if (interceptor != null)
					{
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								((IDisposable)interceptor).Dispose();
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
								{
									num5 = 1;
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
	}

	protected override void Dispose(bool disposing)
	{
		//Discarded unreachable code: IL_009c, IL_00d4, IL_0114, IL_011f
		int num = 2;
		int num2 = num;
		Interceptor interceptor = default(Interceptor);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				interceptor = new Interceptor(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 1;
				}
				continue;
			case 0:
				return;
			case 3:
				break;
			case 1:
				try
				{
					tciSZiWRgZdpUgwZ4E6x(reader);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
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
					int num4;
					if (interceptor == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
						{
							num4 = 1;
						}
						goto IL_00d8;
					}
					goto IL_00ee;
					IL_00ee:
					CxTUe5WRmNMaEGpiZkAQ(interceptor);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num4 = 0;
					}
					goto IL_00d8;
					IL_00d8:
					switch (num4)
					{
					default:
						goto end_IL_00b3;
					case 2:
						break;
					case 1:
						goto end_IL_00b3;
					case 0:
						goto end_IL_00b3;
					}
					goto IL_00ee;
					end_IL_00b3:;
				}
				break;
			}
			DiagnosticsManager.StopCall(queryInfo);
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
			{
				num2 = 0;
			}
		}
	}

	public override bool GetBoolean(int i)
	{
		//Discarded unreachable code: IL_0077, IL_00af, IL_00e7, IL_00f6
		int num = 1;
		int num2 = num;
		Interceptor interceptor = default(Interceptor);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				interceptor = new Interceptor(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				result = QVNlGRWRj80qLGNAB2JX(reader, i);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			finally
			{
				if (interceptor != null)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							CxTUe5WRmNMaEGpiZkAQ(interceptor);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
							{
								num4 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
			}
		}
	}

	public override byte GetByte(int i)
	{
		//Discarded unreachable code: IL_0051, IL_0089, IL_00c9, IL_00d8, IL_00e4, IL_00f3
		int num = 2;
		int num2 = num;
		Interceptor interceptor = default(Interceptor);
		byte b = default(byte);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					b = yTcbegWRYly6Uplr28yh(reader, i);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => b, 
						_ => b, 
					};
				}
				finally
				{
					int num4;
					if (interceptor == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
						{
							num4 = 0;
						}
						goto IL_008d;
					}
					goto IL_00a3;
					IL_00a3:
					CxTUe5WRmNMaEGpiZkAQ(interceptor);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num4 = 1;
					}
					goto IL_008d;
					IL_008d:
					switch (num4)
					{
					default:
						goto end_IL_0068;
					case 2:
						break;
					case 0:
						goto end_IL_0068;
					case 1:
						goto end_IL_0068;
					}
					goto IL_00a3;
					end_IL_0068:;
				}
			default:
				return b;
			case 2:
				interceptor = new Interceptor(this);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
	{
		//Discarded unreachable code: IL_007a, IL_00b2, IL_00ea, IL_00f9
		int num = 1;
		int num2 = num;
		Interceptor interceptor = default(Interceptor);
		long result = default(long);
		while (true)
		{
			switch (num2)
			{
			case 1:
				interceptor = new Interceptor(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				result = BjOWYLWRLFtDM7BQBO8D(reader, i, fieldOffset, buffer, bufferoffset, length);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			finally
			{
				if (interceptor != null)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							CxTUe5WRmNMaEGpiZkAQ(interceptor);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
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
		}
	}

	public override char GetChar(int i)
	{
		//Discarded unreachable code: IL_0077, IL_00af, IL_00e7, IL_00f6
		int num = 1;
		int num2 = num;
		Interceptor interceptor = default(Interceptor);
		char result = default(char);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				interceptor = new Interceptor(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				result = ljNMWoWRUlWRY5P9cb0k(reader, i);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			finally
			{
				if (interceptor != null)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							CxTUe5WRmNMaEGpiZkAQ(interceptor);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
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
		}
	}

	public override long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
	{
		//Discarded unreachable code: IL_0057, IL_008f, IL_00ae, IL_00bd, IL_00ea, IL_00f9
		int num = 2;
		int num2 = num;
		Interceptor interceptor = default(Interceptor);
		long result = default(long);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					result = CBKqPaWRs1PjbX4noUGb(reader, i, fieldoffset, buffer, bufferoffset, length);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => result, 
						_ => result, 
					};
				}
				finally
				{
					int num4;
					if (interceptor == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
						{
							num4 = 0;
						}
						goto IL_0093;
					}
					goto IL_00c8;
					IL_00c8:
					CxTUe5WRmNMaEGpiZkAQ(interceptor);
					num4 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num4 = 2;
					}
					goto IL_0093;
					IL_0093:
					switch (num4)
					{
					default:
						goto end_IL_006e;
					case 0:
						goto end_IL_006e;
					case 1:
						break;
					case 2:
						goto end_IL_006e;
					}
					goto IL_00c8;
					end_IL_006e:;
				}
			case 2:
				interceptor = new Interceptor(this);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return result;
			}
		}
	}

	protected override DbDataReader GetDbDataReader(int ordinal)
	{
		//Discarded unreachable code: IL_0051, IL_0089, IL_00c1, IL_00d0
		int num = 2;
		int num2 = num;
		Interceptor interceptor = default(Interceptor);
		DbDataReader dbDataReader = default(DbDataReader);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					dbDataReader = (DbDataReader)Rj0DBlWRcQI0XHfiSZ9D(reader, ordinal);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => dbDataReader, 
						_ => dbDataReader, 
					};
				}
				finally
				{
					if (interceptor != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								((IDisposable)interceptor).Dispose();
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			default:
				return dbDataReader;
			case 2:
				interceptor = new Interceptor(this);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override string GetDataTypeName(int i)
	{
		//Discarded unreachable code: IL_0054, IL_008c, IL_00cc, IL_00d7, IL_00e6
		int num = 1;
		int num2 = num;
		Interceptor interceptor = default(Interceptor);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				interceptor = new Interceptor(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				result = (string)dRtaOhWRzNZTFw2vYm8e(reader, i);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			finally
			{
				int num4;
				if (interceptor == null)
				{
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num4 = 0;
					}
					goto IL_0090;
				}
				goto IL_00a6;
				IL_00a6:
				CxTUe5WRmNMaEGpiZkAQ(interceptor);
				num4 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num4 = 1;
				}
				goto IL_0090;
				IL_0090:
				switch (num4)
				{
				default:
					goto end_IL_006b;
				case 2:
					break;
				case 0:
					goto end_IL_006b;
				case 1:
					goto end_IL_006b;
				}
				goto IL_00a6;
				end_IL_006b:;
			}
		}
	}

	public override DateTime GetDateTime(int i)
	{
		//Discarded unreachable code: IL_0074, IL_00ac, IL_00e4, IL_00f3
		int num = 1;
		int num2 = num;
		Interceptor interceptor = default(Interceptor);
		DateTime result = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			case 1:
				interceptor = new Interceptor(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				result = TqYrqKWqFfCuyQNlL4n4(reader, i);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			finally
			{
				if (interceptor != null)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							((IDisposable)interceptor).Dispose();
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
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
		}
	}

	public override decimal GetDecimal(int i)
	{
		//Discarded unreachable code: IL_0077, IL_00af, IL_00e7, IL_00f6
		int num = 1;
		int num2 = num;
		Interceptor interceptor = default(Interceptor);
		decimal result = default(decimal);
		while (true)
		{
			switch (num2)
			{
			case 1:
				interceptor = new Interceptor(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				result = reader.GetDecimal(i);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			finally
			{
				if (interceptor != null)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							CxTUe5WRmNMaEGpiZkAQ(interceptor);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
							{
								num4 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
			}
		}
	}

	public override double GetDouble(int i)
	{
		//Discarded unreachable code: IL_0077, IL_009f, IL_00be, IL_00cd, IL_00fa, IL_0109
		int num = 2;
		int num2 = num;
		Interceptor interceptor = default(Interceptor);
		double num3 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 2:
				interceptor = new Interceptor(this);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return num3;
			case 1:
				try
				{
					num3 = QwrN8QWqBBQU37mroRGD(reader, i);
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num4 = 0;
					}
					return num4 switch
					{
						0 => num3, 
						_ => num3, 
					};
				}
				finally
				{
					int num5;
					if (interceptor == null)
					{
						num5 = 2;
						goto IL_00a3;
					}
					goto IL_00d8;
					IL_00a3:
					switch (num5)
					{
					default:
						goto end_IL_008e;
					case 2:
						goto end_IL_008e;
					case 1:
						break;
					case 0:
						goto end_IL_008e;
					}
					goto IL_00d8;
					IL_00d8:
					CxTUe5WRmNMaEGpiZkAQ(interceptor);
					num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num5 = 0;
					}
					goto IL_00a3;
					end_IL_008e:;
				}
			}
		}
	}

	public override Type GetFieldType(int i)
	{
		//Discarded unreachable code: IL_0077, IL_00af, IL_00e7, IL_00f6
		int num = 1;
		int num2 = num;
		Interceptor interceptor = default(Interceptor);
		Type result = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 1:
				interceptor = new Interceptor(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				result = yo96ldWqW6UaeLJ9aOdD(reader, i);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			finally
			{
				if (interceptor != null)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							CxTUe5WRmNMaEGpiZkAQ(interceptor);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
							{
								num4 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
			}
		}
	}

	public override float GetFloat(int i)
	{
		//Discarded unreachable code: IL_0077, IL_00af, IL_00e7, IL_00f6
		int num = 1;
		int num2 = num;
		Interceptor interceptor = default(Interceptor);
		float result = default(float);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				interceptor = new Interceptor(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				result = KEbiKZWqorZudNXKtDOI(reader, i);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			finally
			{
				if (interceptor != null)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							CxTUe5WRmNMaEGpiZkAQ(interceptor);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
							{
								num4 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
			}
		}
	}

	public override Guid GetGuid(int i)
	{
		//Discarded unreachable code: IL_0051, IL_0089, IL_00c1, IL_00d0
		int num = 1;
		int num2 = num;
		Interceptor interceptor = default(Interceptor);
		Guid result = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 1:
				interceptor = new Interceptor(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				result = L2OXdsWqbyUPUdsZoSPt(reader, i);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			finally
			{
				if (interceptor != null)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							CxTUe5WRmNMaEGpiZkAQ(interceptor);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
							{
								num4 = 0;
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

	public override short GetInt16(int i)
	{
		//Discarded unreachable code: IL_0051, IL_0089, IL_00c1, IL_00d0
		int num = 2;
		int num2 = num;
		Interceptor interceptor = default(Interceptor);
		short result = default(short);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					result = reader.GetInt16(i);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => result, 
						_ => result, 
					};
				}
				finally
				{
					if (interceptor != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								CxTUe5WRmNMaEGpiZkAQ(interceptor);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
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
			case 2:
				interceptor = new Interceptor(this);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return result;
			}
		}
	}

	public override int GetInt32(int i)
	{
		//Discarded unreachable code: IL_0051, IL_0089, IL_00c1, IL_00d0
		int num = 2;
		int num2 = num;
		Interceptor interceptor = default(Interceptor);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					num3 = nCRH6BWqhcjUixGWJUXI(reader, i);
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num4 = 0;
					}
					return num4 switch
					{
						0 => num3, 
						_ => num3, 
					};
				}
				finally
				{
					if (interceptor != null)
					{
						int num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num5 = 1;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								CxTUe5WRmNMaEGpiZkAQ(interceptor);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
								{
									num5 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			default:
				return num3;
			case 2:
				interceptor = new Interceptor(this);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override long GetInt64(int i)
	{
		//Discarded unreachable code: IL_0054, IL_008c, IL_00c4, IL_00d3
		int num = 2;
		int num2 = num;
		long result = default(long);
		Interceptor interceptor = default(Interceptor);
		while (true)
		{
			switch (num2)
			{
			default:
				return result;
			case 1:
				try
				{
					result = reader.GetInt64(i);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => result, 
						_ => result, 
					};
				}
				finally
				{
					if (interceptor != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								((IDisposable)interceptor).Dispose();
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
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
			case 2:
				interceptor = new Interceptor(this);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override string GetName(int i)
	{
		//Discarded unreachable code: IL_0077, IL_00af, IL_00e7, IL_00f6
		int num = 2;
		int num2 = num;
		Interceptor interceptor = default(Interceptor);
		string name = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return name;
			case 2:
				interceptor = new Interceptor(this);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					name = reader.GetName(i);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => name, 
						_ => name, 
					};
				}
				finally
				{
					if (interceptor != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								CxTUe5WRmNMaEGpiZkAQ(interceptor);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
								{
									num4 = 0;
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
	}

	public override int GetOrdinal(string name)
	{
		//Discarded unreachable code: IL_0077, IL_00af, IL_00e7, IL_00f6
		int num = 2;
		int num2 = num;
		Interceptor interceptor = default(Interceptor);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				return num3;
			case 2:
				interceptor = new Interceptor(this);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				try
				{
					num3 = uRZulDWqGx6r0sO9p8Uq(reader, name);
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num4 = 0;
					}
					return num4 switch
					{
						0 => num3, 
						_ => num3, 
					};
				}
				finally
				{
					if (interceptor != null)
					{
						int num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
						{
							num5 = 1;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								((IDisposable)interceptor).Dispose();
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
								{
									num5 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			}
		}
	}

	public override string GetString(int i)
	{
		//Discarded unreachable code: IL_0054, IL_008c, IL_00c4, IL_00d3
		int num = 2;
		int num2 = num;
		string result = default(string);
		Interceptor interceptor = default(Interceptor);
		while (true)
		{
			switch (num2)
			{
			default:
				return result;
			case 1:
				try
				{
					result = reader.GetString(i);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => result, 
						_ => result, 
					};
				}
				finally
				{
					if (interceptor != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								CxTUe5WRmNMaEGpiZkAQ(interceptor);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
								{
									num4 = 0;
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
				interceptor = new Interceptor(this);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override object GetValue(int i)
	{
		//Discarded unreachable code: IL_0077, IL_00af, IL_00ef, IL_00fa, IL_0109
		int num = 1;
		int num2 = num;
		Interceptor interceptor = default(Interceptor);
		object result = default(object);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				interceptor = new Interceptor(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				result = zLjqHmWqEVGgyFyvI14M(reader, i);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			finally
			{
				int num4;
				if (interceptor == null)
				{
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num4 = 0;
					}
					goto IL_00b3;
				}
				goto IL_00c9;
				IL_00c9:
				CxTUe5WRmNMaEGpiZkAQ(interceptor);
				num4 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num4 = 1;
				}
				goto IL_00b3;
				IL_00b3:
				switch (num4)
				{
				default:
					goto end_IL_008e;
				case 2:
					break;
				case 0:
					goto end_IL_008e;
				case 1:
					goto end_IL_008e;
				}
				goto IL_00c9;
				end_IL_008e:;
			}
		}
	}

	public override int GetValues(object[] values)
	{
		//Discarded unreachable code: IL_0051, IL_0089, IL_00c1, IL_00d0
		int num = 1;
		int num2 = num;
		Interceptor interceptor = default(Interceptor);
		int result = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				interceptor = new Interceptor(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				result = FZvJkXWqfdvuGjBPvFe0(reader, values);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			finally
			{
				if (interceptor != null)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							CxTUe5WRmNMaEGpiZkAQ(interceptor);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
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
		}
	}

	public override bool IsDBNull(int i)
	{
		//Discarded unreachable code: IL_0074, IL_00ac, IL_00ec, IL_00f7, IL_0106
		int num = 2;
		int num2 = num;
		Interceptor interceptor = default(Interceptor);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 2:
				interceptor = new Interceptor(this);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					result = WBga1BWqQAdENirrSsvk(reader, i);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => result, 
						_ => result, 
					};
				}
				finally
				{
					int num4;
					if (interceptor == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num4 = 0;
						}
						goto IL_00b0;
					}
					goto IL_00c6;
					IL_00c6:
					((IDisposable)interceptor).Dispose();
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num4 = 0;
					}
					goto IL_00b0;
					IL_00b0:
					switch (num4)
					{
					default:
						goto end_IL_008b;
					case 2:
						break;
					case 1:
						goto end_IL_008b;
					case 0:
						goto end_IL_008b;
					}
					goto IL_00c6;
					end_IL_008b:;
				}
			default:
				return result;
			}
		}
	}

	public override IEnumerator GetEnumerator()
	{
		//Discarded unreachable code: IL_0076, IL_00ae, IL_00e6, IL_00f5
		int num = 1;
		int num2 = num;
		Interceptor interceptor = default(Interceptor);
		IEnumerator result = default(IEnumerator);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				interceptor = new Interceptor(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				result = new DbEnumerator(reader);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			finally
			{
				if (interceptor != null)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							CxTUe5WRmNMaEGpiZkAQ(interceptor);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
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
		}
	}

	internal static void FnHFuaWR7VKJsSsmj1Kw()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object m9hA2cWRxCRFKUFdlubn(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool z1PMqQWRHwDRPllwLnaW()
	{
		return nCblicWR6DQB7Py6Nej8 == null;
	}

	internal static DataReaderProxy k7D5XNWRA5OmiChC3foc()
	{
		return nCblicWR6DQB7Py6Nej8;
	}

	internal static void NmUk09WR0ajm0VIQlhwu(object P_0)
	{
		((DbDataReader)P_0).Close();
	}

	internal static void CxTUe5WRmNMaEGpiZkAQ(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object dlKYy8WRy6ZHPpxgdWCj(object P_0)
	{
		return ((DbDataReader)P_0).GetSchemaTable();
	}

	internal static bool f79cDAWRMDO3H7FpJ7qi(object P_0)
	{
		return ((DbDataReader)P_0).IsClosed;
	}

	internal static bool IcdQMZWRJyVtcEFpwORS(object P_0)
	{
		return ((DbDataReader)P_0).NextResult();
	}

	internal static bool fgDmm3WR9V4IsukavHns(object P_0)
	{
		return ((DbDataReader)P_0).Read();
	}

	internal static bool VtHUoZWRdE97SfLvxRwb()
	{
		return Locator.Initialized;
	}

	internal static bool KhPLLsWRlT8GL25j26C8(object P_0, object P_1)
	{
		return ((ITransformationProvider)P_0).IsUnrecoverableException((Exception)P_1);
	}

	internal static int g2PmjXWRrYardsRD18er(object P_0)
	{
		return ((DbDataReader)P_0).RecordsAffected;
	}

	internal static void tciSZiWRgZdpUgwZ4E6x(object P_0)
	{
		((DbDataReader)P_0).Dispose();
	}

	internal static int cqcpAIWR5mavqTCI6ASm(object P_0)
	{
		return ((DbDataReader)P_0).FieldCount;
	}

	internal static bool QVNlGRWRj80qLGNAB2JX(object P_0, int P_1)
	{
		return ((DbDataReader)P_0).GetBoolean(P_1);
	}

	internal static byte yTcbegWRYly6Uplr28yh(object P_0, int P_1)
	{
		return ((DbDataReader)P_0).GetByte(P_1);
	}

	internal static long BjOWYLWRLFtDM7BQBO8D(object P_0, int P_1, long P_2, object P_3, int P_4, int P_5)
	{
		return ((DbDataReader)P_0).GetBytes(P_1, P_2, (byte[])P_3, P_4, P_5);
	}

	internal static char ljNMWoWRUlWRY5P9cb0k(object P_0, int P_1)
	{
		return ((DbDataReader)P_0).GetChar(P_1);
	}

	internal static long CBKqPaWRs1PjbX4noUGb(object P_0, int P_1, long P_2, object P_3, int P_4, int P_5)
	{
		return ((DbDataReader)P_0).GetChars(P_1, P_2, (char[])P_3, P_4, P_5);
	}

	internal static object Rj0DBlWRcQI0XHfiSZ9D(object P_0, int P_1)
	{
		return ((DbDataReader)P_0).GetData(P_1);
	}

	internal static object dRtaOhWRzNZTFw2vYm8e(object P_0, int P_1)
	{
		return ((DbDataReader)P_0).GetDataTypeName(P_1);
	}

	internal static DateTime TqYrqKWqFfCuyQNlL4n4(object P_0, int P_1)
	{
		return ((DbDataReader)P_0).GetDateTime(P_1);
	}

	internal static double QwrN8QWqBBQU37mroRGD(object P_0, int P_1)
	{
		return ((DbDataReader)P_0).GetDouble(P_1);
	}

	internal static Type yo96ldWqW6UaeLJ9aOdD(object P_0, int P_1)
	{
		return ((DbDataReader)P_0).GetFieldType(P_1);
	}

	internal static float KEbiKZWqorZudNXKtDOI(object P_0, int P_1)
	{
		return ((DbDataReader)P_0).GetFloat(P_1);
	}

	internal static Guid L2OXdsWqbyUPUdsZoSPt(object P_0, int P_1)
	{
		return ((DbDataReader)P_0).GetGuid(P_1);
	}

	internal static int nCRH6BWqhcjUixGWJUXI(object P_0, int P_1)
	{
		return ((DbDataReader)P_0).GetInt32(P_1);
	}

	internal static int uRZulDWqGx6r0sO9p8Uq(object P_0, object P_1)
	{
		return ((DbDataReader)P_0).GetOrdinal((string)P_1);
	}

	internal static object zLjqHmWqEVGgyFyvI14M(object P_0, int P_1)
	{
		return ((DbDataReader)P_0).GetValue(P_1);
	}

	internal static int FZvJkXWqfdvuGjBPvFe0(object P_0, object P_1)
	{
		return ((DbDataReader)P_0).GetValues((object[])P_1);
	}

	internal static bool WBga1BWqQAdENirrSsvk(object P_0, int P_1)
	{
		return ((DbDataReader)P_0).IsDBNull(P_1);
	}

	internal static object enZwgbWqC8vl3pkqmVkb(object P_0, object P_1)
	{
		return ((DbDataReader)P_0)[(string)P_1];
	}
}
