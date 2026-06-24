using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using EleWise.ELMA.Diagnostics;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Proxies;

public class DbCommandProxy : DbCommand
{
	private DbCommand cmd;

	private readonly bool useSavePoint;

	private DbConnectionProxy conProxy;

	private DbTransactionProxy tranProxy;

	private static DbCommandProxy YheojxWixSvY3nIMeBJP;

	public DbCommand RealCommand => cmd;

	public override string CommandText
	{
		get
		{
			return (string)OT2hZ4WiJASqWRQP6Mqo(cmd);
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
					NUE7FaWi9d89lwWZigjV(cmd, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override int CommandTimeout
	{
		get
		{
			return GrEF2FWidNfw7Vyca4Rd(cmd);
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
					fdtZ2TWiluFgMSlmPDuX(cmd, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override CommandType CommandType
	{
		get
		{
			return cmd.CommandType;
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
				case 1:
					P8enEeWir08UfohbTusm(cmd, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
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

	protected override DbConnection DbConnection
	{
		get
		{
			//Discarded unreachable code: IL_0056
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (conProxy == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				case 3:
					if (qo4wKmWigSPhJUXRp81C(conProxy) != PLPiuvWi54TRfk0j7Dd8(cmd))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num2 = 0;
						}
						break;
					}
					return conProxy;
				default:
					return (DbConnection)PLPiuvWi54TRfk0j7Dd8(cmd);
				}
			}
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					conProxy = value as DbConnectionProxy;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				default:
					L29c3JWijP5yJEo58JXE(cmd, (conProxy != null) ? qo4wKmWigSPhJUXRp81C(conProxy) : value);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
	}

	protected override DbParameterCollection DbParameterCollection => (DbParameterCollection)EVKpWNWRb57a284Eh2kn(cmd);

	protected override DbTransaction DbTransaction
	{
		get
		{
			//Discarded unreachable code: IL_009e
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (tranProxy == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				case 3:
					if (tranProxy.RealTransaction != cmd.Transaction)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
						{
							num2 = 2;
						}
						break;
					}
					return tranProxy;
				default:
					return (DbTransaction)Qu6fESWRGY55riGTQtL1(cmd);
				}
			}
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
					tranProxy = value as DbTransactionProxy;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				case 1:
					f4lHBRWRftNtYgAjQfUi(cmd, (tranProxy != null) ? sgXCbiWREiXhD9U6NsvI(tranProxy) : value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override UpdateRowSource UpdatedRowSource
	{
		get
		{
			return kfks96WRQCDCeGP7YVqj(cmd);
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
					qyVMwrWRC4T8dnpNH5b2(cmd, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override bool DesignTimeVisible
	{
		get
		{
			return nnfh4eWRvHWsicDfvDP2(cmd);
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
					NClqwDWR8pc2fK5kpqfr(cmd, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public DbCommandProxy(DbCommand cmd)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		xTiFiyWiyCq6cdIpiGLx();
		this._002Ector(cmd, useSavePoint: true);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal DbCommandProxy(DbCommand cmd, bool useSavePoint)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		xTiFiyWiyCq6cdIpiGLx();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				this.cmd = cmd;
				num = 3;
				continue;
			case 3:
				this.useSavePoint = useSavePoint;
				num = 2;
				continue;
			case 2:
				return;
			}
			cnQxFEWiMyfLIHuElmAc(cmd, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112666504));
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
			{
				num = 1;
			}
		}
	}

	public override void Cancel()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				cmd.Cancel();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected override DbParameter CreateDbParameter()
	{
		return cmd.CreateParameter();
	}

	public override int ExecuteNonQuery()
	{
		//Discarded unreachable code: IL_007e, IL_00a1, IL_00b0, IL_00c5, IL_011e, IL_0191, IL_01f1, IL_01fb, IL_020a, IL_025c, IL_026b, IL_02b2, IL_02f4, IL_036c, IL_0389, IL_03a8, IL_03b7, IL_03e4, IL_03f3
		int num = 2;
		int num2 = num;
		int result = default(int);
		SqlQueryInfo sqlQueryInfo = default(SqlQueryInfo);
		bool flag = default(bool);
		int num5 = default(int);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return result;
			case 2:
				sqlQueryInfo = DiagnosticsManager.StartCall(delegate
				{
					int num9 = 1;
					int num10 = num9;
					while (true)
					{
						switch (num10)
						{
						default:
							return null;
						case 1:
							if (!iQ0a9oWRuJJIX7vaPNaa(cmd.CommandText))
							{
								return new SqlQueryInfo(cmd);
							}
							num10 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
							{
								num10 = 0;
							}
							break;
						}
					}
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					int num3;
					if (useSavePoint)
					{
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num3 = 1;
						}
						goto IL_0082;
					}
					goto IL_00bb;
					IL_0082:
					while (true)
					{
						switch (num3)
						{
						case 3:
							flag = false;
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							goto IL_00e7;
						case 2:
							try
							{
								int num4;
								if (!useSavePoint)
								{
									num4 = 7;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
									{
										num4 = 5;
									}
									goto IL_0122;
								}
								goto IL_01df;
								IL_0122:
								while (true)
								{
									switch (num4)
									{
									case 3:
										return result;
									case 11:
										sqlQueryInfo.RowsAffected = num5;
										num4 = 8;
										continue;
									case 5:
										o39RYQWisJ0G0j7YIsMM(text, cmd);
										num4 = 10;
										continue;
									case 10:
										flag = false;
										num4 = 4;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
										{
											num4 = 0;
										}
										continue;
									case 6:
										num5 = bhkxCPWiU04UhfFijFro(cmd);
										num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
										{
											num4 = 2;
										}
										continue;
									case 9:
										break;
									case 2:
										if (!flag)
										{
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
											{
												num4 = 1;
											}
											continue;
										}
										goto case 5;
									case 1:
									case 4:
										if (sqlQueryInfo == null)
										{
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
											{
												num4 = 0;
											}
											continue;
										}
										goto case 11;
									default:
										result = num5;
										num4 = 3;
										continue;
									case 7:
										goto IL_0284;
									}
									break;
								}
								goto IL_01df;
								IL_0284:
								int num6 = 0;
								goto IL_0285;
								IL_01df:
								num6 = (aArDKSWiLqtPDPl3C6tU(text, cmd) ? 1 : 0);
								goto IL_0285;
								IL_0285:
								flag = (byte)num6 != 0;
								num4 = 6;
								goto IL_0122;
							}
							catch (Exception ex)
							{
								int num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
								{
									num7 = 1;
								}
								while (true)
								{
									switch (num7)
									{
									case 6:
										LU17PLWizhS99HY3qcuK(sqlQueryInfo, ex);
										num7 = 2;
										break;
									case 4:
										cwYPdhWicCLgcWP4J05G(text, cmd);
										num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
										{
											num7 = 0;
										}
										break;
									case 1:
										if (!flag)
										{
											num7 = 3;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
											{
												num7 = 3;
											}
											break;
										}
										goto case 4;
									default:
										if (sqlQueryInfo == null)
										{
											num7 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
											{
												num7 = 5;
											}
											break;
										}
										goto case 6;
									case 2:
									case 5:
										throw;
									}
								}
							}
						}
						break;
					}
					goto IL_00bb;
					IL_00e7:
					object obj = hObtjlWiYrXfqCup4TtA();
					goto IL_00ec;
					IL_00bb:
					obj = string.Empty;
					goto IL_00ec;
					IL_00ec:
					text = (string)obj;
					num3 = 3;
					goto IL_0082;
				}
				finally
				{
					int num8;
					if (sqlQueryInfo == null)
					{
						num8 = 2;
						goto IL_038d;
					}
					goto IL_03c2;
					IL_038d:
					switch (num8)
					{
					case 2:
						goto end_IL_0378;
					case 1:
						goto end_IL_0378;
					}
					goto IL_03c2;
					IL_03c2:
					yphrHFWRFXvKxxFm2rS6(sqlQueryInfo);
					num8 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num8 = 1;
					}
					goto IL_038d;
					end_IL_0378:;
				}
			}
		}
	}

	public new DbDataReader ExecuteReader()
	{
		//Discarded unreachable code: IL_005a, IL_0069, IL_0159, IL_0163, IL_0172, IL_0183, IL_019e, IL_01ad, IL_02a0, IL_02af, IL_02bc, IL_02d0
		int num = 6;
		int num2 = num;
		bool flag = default(bool);
		DbDataReader dbDataReader = default(DbDataReader);
		DbDataReader result = default(DbDataReader);
		SqlQueryInfo sqlQueryInfo = default(SqlQueryInfo);
		string text = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
				flag = false;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 3;
				}
				continue;
			case 5:
				if (useSavePoint)
				{
					num2 = 2;
					continue;
				}
				goto case 1;
			case 3:
				try
				{
					int num3;
					if (useSavePoint)
					{
						num3 = 9;
						goto IL_00a3;
					}
					int num4 = 0;
					goto IL_01b9;
					IL_00a3:
					while (true)
					{
						object obj2;
						switch (num3)
						{
						case 7:
							dbDataReader = cmd.ExecuteReader();
							num3 = 10;
							continue;
						case 6:
							result = dbDataReader;
							num3 = 4;
							continue;
						default:
							if (dbDataReader != null)
							{
								num3 = 2;
								continue;
							}
							goto case 8;
						case 1:
							break;
						case 5:
							flag = false;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
							{
								num3 = 0;
							}
							continue;
						case 9:
							goto IL_0147;
						case 8:
							obj2 = null;
							goto IL_01d3;
						case 10:
							if (!flag)
							{
								num3 = 3;
								continue;
							}
							break;
						case 2:
							obj2 = new DataReaderProxy(dbDataReader, this, sqlQueryInfo);
							goto IL_01d3;
						case 4:
							{
								return result;
							}
							IL_01d3:
							dbDataReader = (DbDataReader)obj2;
							num3 = 6;
							continue;
						}
						break;
					}
					o39RYQWisJ0G0j7YIsMM(text, cmd);
					int num5 = 5;
					goto IL_009f;
					IL_0147:
					num4 = (aArDKSWiLqtPDPl3C6tU(text, cmd) ? 1 : 0);
					goto IL_01b9;
					IL_01b9:
					flag = (byte)num4 != 0;
					num5 = 7;
					goto IL_009f;
					IL_009f:
					num3 = num5;
					goto IL_00a3;
				}
				catch (Exception exception)
				{
					int num6 = 5;
					while (true)
					{
						switch (num6)
						{
						case 2:
							cwYPdhWicCLgcWP4J05G(text, cmd);
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
							{
								num6 = 1;
							}
							break;
						case 4:
							sqlQueryInfo.Exception = exception;
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
							{
								num6 = 0;
							}
							break;
						default:
							poABfeWRBC1T3baMd2gT(sqlQueryInfo);
							num6 = 3;
							break;
						case 5:
							if (flag)
							{
								num6 = 2;
								break;
							}
							goto case 1;
						case 1:
							if (sqlQueryInfo == null)
							{
								int num7 = 6;
								num6 = num7;
								break;
							}
							goto case 4;
						case 3:
						case 6:
							throw;
						}
					}
				}
			case 1:
				obj = string.Empty;
				break;
			case 4:
				return result;
			case 6:
				sqlQueryInfo = DiagnosticsManager.StartCall(delegate
				{
					//Discarded unreachable code: IL_0064
					int num8 = 2;
					int num9 = num8;
					while (true)
					{
						switch (num9)
						{
						case 2:
							if (cmd == null)
							{
								num9 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
								{
									num9 = 1;
								}
								continue;
							}
							break;
						default:
							return null;
						case 3:
							break;
						}
						if (!iQ0a9oWRuJJIX7vaPNaa(OT2hZ4WiJASqWRQP6Mqo(cmd)))
						{
							break;
						}
						num9 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num9 = 0;
						}
					}
					return new SqlQueryInfo(cmd);
				});
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num2 = 5;
				}
				continue;
			case 2:
				obj = hObtjlWiYrXfqCup4TtA();
				break;
			}
			text = (string)obj;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
			{
				num2 = 0;
			}
		}
	}

	protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior)
	{
		//Discarded unreachable code: IL_0051, IL_0096, IL_00a0, IL_00af, IL_00e1, IL_0156, IL_0165
		int num = 2;
		int num2 = num;
		SqlQueryInfo sqlQueryInfo = default(SqlQueryInfo);
		DbDataReader result = default(DbDataReader);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					DbDataReader dbDataReader = (DbDataReader)E3YknHWRWBm0DkwtMlC1(cmd, behavior);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						object obj;
						switch (num3)
						{
						default:
							if (dbDataReader != null)
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
								{
									num3 = 1;
								}
								break;
							}
							goto case 3;
						case 3:
							obj = null;
							goto IL_00c4;
						case 1:
							obj = new DataReaderProxy(dbDataReader, this, sqlQueryInfo);
							goto IL_00c4;
						case 2:
							{
								return result;
							}
							IL_00c4:
							result = (DbDataReader)obj;
							num3 = 2;
							break;
						}
					}
				}
				catch (Exception ex)
				{
					int num4 = 3;
					while (true)
					{
						switch (num4)
						{
						case 3:
							if (sqlQueryInfo != null)
							{
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
								{
									num4 = 0;
								}
								continue;
							}
							break;
						default:
							poABfeWRBC1T3baMd2gT(sqlQueryInfo);
							num4 = 2;
							continue;
						case 1:
							LU17PLWizhS99HY3qcuK(sqlQueryInfo, ex);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
							{
								num4 = 0;
							}
							continue;
						case 2:
							break;
						}
						break;
					}
					throw;
				}
			case 2:
				sqlQueryInfo = DiagnosticsManager.StartCall(delegate
				{
					//Discarded unreachable code: IL_0093
					int num5 = 1;
					int num6 = num5;
					while (true)
					{
						switch (num6)
						{
						default:
							return null;
						case 1:
							if (cmd == null)
							{
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
								{
									num6 = 0;
								}
								continue;
							}
							break;
						case 3:
							break;
						}
						if (!iQ0a9oWRuJJIX7vaPNaa(cmd.CommandText))
						{
							break;
						}
						num6 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num6 = 0;
						}
					}
					return new SqlQueryInfo(cmd);
				});
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return result;
			}
		}
	}

	public override object ExecuteScalar()
	{
		//Discarded unreachable code: IL_003e, IL_006e, IL_007d, IL_0092, IL_0145, IL_0224, IL_0272, IL_0281, IL_02f8, IL_0338, IL_0347, IL_0353, IL_0362
		int num = 1;
		int num2 = num;
		object result = default(object);
		SqlQueryInfo sqlQueryInfo = default(SqlQueryInfo);
		bool flag = default(bool);
		object obj = default(object);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				sqlQueryInfo = DiagnosticsManager.StartCall(delegate
				{
					int num9 = 1;
					int num10 = num9;
					while (true)
					{
						switch (num10)
						{
						case 1:
							if (!iQ0a9oWRuJJIX7vaPNaa(OT2hZ4WiJASqWRQP6Mqo(cmd)))
							{
								return new SqlQueryInfo(cmd);
							}
							num10 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
							{
								num10 = 0;
							}
							break;
						default:
							return null;
						}
					}
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				int num3;
				if (useSavePoint)
				{
					num3 = 2;
					goto IL_0042;
				}
				goto IL_0088;
				IL_0042:
				while (true)
				{
					switch (num3)
					{
					default:
						flag = false;
						num3 = 3;
						continue;
					case 1:
						break;
					case 2:
						goto IL_0097;
					case 3:
						try
						{
							int num4;
							if (useSavePoint)
							{
								num4 = 8;
								goto IL_00d2;
							}
							int num5 = 0;
							goto IL_01e7;
							IL_0178:
							num4 = 5;
							goto IL_00d2;
							IL_00d2:
							int num6 = num4;
							goto IL_00d6;
							IL_01e7:
							flag = (byte)num5 != 0;
							num6 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
							{
								num6 = 2;
							}
							goto IL_00d6;
							IL_01cb:
							obj = jqGHrfWRod9qu7vImX8b(cmd);
							num4 = 7;
							goto IL_00d2;
							IL_00d6:
							while (true)
							{
								switch (num6)
								{
								default:
									result = obj;
									num6 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
									{
										num6 = 3;
									}
									continue;
								case 7:
									if (flag)
									{
										num6 = 6;
										continue;
									}
									goto case 1;
								case 8:
									break;
								case 6:
									o39RYQWisJ0G0j7YIsMM(text, cmd);
									num6 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
									{
										num6 = 4;
									}
									continue;
								case 1:
									if (sqlQueryInfo == null)
									{
										goto default;
									}
									goto IL_0178;
								case 5:
									sqlQueryInfo.RowsAffected = 1L;
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
									{
										num6 = 0;
									}
									continue;
								case 4:
									flag = false;
									num6 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
									{
										num6 = 1;
									}
									continue;
								case 2:
									goto IL_01cb;
								case 3:
									return result;
								}
								break;
							}
							num5 = (SavePointHelper.SavePoint(text, cmd) ? 1 : 0);
							goto IL_01e7;
						}
						catch (Exception ex)
						{
							int num7 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
							{
								num7 = 2;
							}
							while (true)
							{
								switch (num7)
								{
								case 3:
									LU17PLWizhS99HY3qcuK(sqlQueryInfo, ex);
									num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
									{
										num7 = 0;
									}
									break;
								case 4:
									if (flag)
									{
										num7 = 5;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
										{
											num7 = 1;
										}
										break;
									}
									goto case 2;
								case 5:
									cwYPdhWicCLgcWP4J05G(text, cmd);
									num7 = 2;
									break;
								case 2:
									if (sqlQueryInfo == null)
									{
										num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
										{
											num7 = 1;
										}
										break;
									}
									goto case 3;
								default:
									throw;
								}
							}
						}
					}
					break;
				}
				goto IL_0088;
				IL_0088:
				object obj2 = string.Empty;
				goto IL_009c;
				IL_009c:
				text = (string)obj2;
				num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num3 = 0;
				}
				goto IL_0042;
				IL_0097:
				obj2 = hObtjlWiYrXfqCup4TtA();
				goto IL_009c;
			}
			finally
			{
				int num8;
				if (sqlQueryInfo == null)
				{
					num8 = 2;
					goto IL_02fc;
				}
				goto IL_0312;
				IL_02fc:
				switch (num8)
				{
				default:
					goto end_IL_02e7;
				case 1:
					break;
				case 2:
					goto end_IL_02e7;
				case 0:
					goto end_IL_02e7;
				}
				goto IL_0312;
				IL_0312:
				yphrHFWRFXvKxxFm2rS6(sqlQueryInfo);
				num8 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num8 = 0;
				}
				goto IL_02fc;
				end_IL_02e7:;
			}
		}
	}

	public override void Prepare()
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
				iqpGUaWRhsIlASi5G8CE(cmd);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		//Discarded unreachable code: IL_0067, IL_0076
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 3:
				return;
			case 2:
				if (!disposing)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			eEKpgBWRZtgajwlBEB0v(cmd);
			num2 = 3;
		}
	}

	internal static void xTiFiyWiyCq6cdIpiGLx()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool FoZSDtWi0xgyylYSvWg5()
	{
		return YheojxWixSvY3nIMeBJP == null;
	}

	internal static DbCommandProxy gnEOH4WimWSZjxMAYF5C()
	{
		return YheojxWixSvY3nIMeBJP;
	}

	internal static void cnQxFEWiMyfLIHuElmAc(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object OT2hZ4WiJASqWRQP6Mqo(object P_0)
	{
		return ((DbCommand)P_0).CommandText;
	}

	internal static void NUE7FaWi9d89lwWZigjV(object P_0, object P_1)
	{
		((DbCommand)P_0).CommandText = (string)P_1;
	}

	internal static int GrEF2FWidNfw7Vyca4Rd(object P_0)
	{
		return ((DbCommand)P_0).CommandTimeout;
	}

	internal static void fdtZ2TWiluFgMSlmPDuX(object P_0, int P_1)
	{
		((DbCommand)P_0).CommandTimeout = P_1;
	}

	internal static void P8enEeWir08UfohbTusm(object P_0, CommandType P_1)
	{
		((DbCommand)P_0).CommandType = P_1;
	}

	internal static object qo4wKmWigSPhJUXRp81C(object P_0)
	{
		return ((DbConnectionProxy)P_0).RealConnection;
	}

	internal static object PLPiuvWi54TRfk0j7Dd8(object P_0)
	{
		return ((DbCommand)P_0).Connection;
	}

	internal static void L29c3JWijP5yJEo58JXE(object P_0, object P_1)
	{
		((DbCommand)P_0).Connection = (DbConnection)P_1;
	}

	internal static object hObtjlWiYrXfqCup4TtA()
	{
		return SavePointHelper.GetSavePointKey();
	}

	internal static bool aArDKSWiLqtPDPl3C6tU(object P_0, object P_1)
	{
		return SavePointHelper.SavePoint((string)P_0, (IDbCommand)P_1);
	}

	internal static int bhkxCPWiU04UhfFijFro(object P_0)
	{
		return ((DbCommand)P_0).ExecuteNonQuery();
	}

	internal static void o39RYQWisJ0G0j7YIsMM(object P_0, object P_1)
	{
		SavePointHelper.ReleaseSavePoint((string)P_0, (IDbCommand)P_1);
	}

	internal static void cwYPdhWicCLgcWP4J05G(object P_0, object P_1)
	{
		SavePointHelper.RollBackSavePoint((string)P_0, (IDbCommand)P_1);
	}

	internal static void LU17PLWizhS99HY3qcuK(object P_0, object P_1)
	{
		((AbstractCallInfo)P_0).Exception = (Exception)P_1;
	}

	internal static void yphrHFWRFXvKxxFm2rS6(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void poABfeWRBC1T3baMd2gT(object P_0)
	{
		((AbstractCallInfo)P_0).Dispose();
	}

	internal static object E3YknHWRWBm0DkwtMlC1(object P_0, CommandBehavior P_1)
	{
		return ((DbCommand)P_0).ExecuteReader(P_1);
	}

	internal static object jqGHrfWRod9qu7vImX8b(object P_0)
	{
		return ((DbCommand)P_0).ExecuteScalar();
	}

	internal static object EVKpWNWRb57a284Eh2kn(object P_0)
	{
		return ((DbCommand)P_0).Parameters;
	}

	internal static void iqpGUaWRhsIlASi5G8CE(object P_0)
	{
		((DbCommand)P_0).Prepare();
	}

	internal static object Qu6fESWRGY55riGTQtL1(object P_0)
	{
		return ((DbCommand)P_0).Transaction;
	}

	internal static object sgXCbiWREiXhD9U6NsvI(object P_0)
	{
		return ((DbTransactionProxy)P_0).RealTransaction;
	}

	internal static void f4lHBRWRftNtYgAjQfUi(object P_0, object P_1)
	{
		((DbCommand)P_0).Transaction = (DbTransaction)P_1;
	}

	internal static UpdateRowSource kfks96WRQCDCeGP7YVqj(object P_0)
	{
		return ((DbCommand)P_0).UpdatedRowSource;
	}

	internal static void qyVMwrWRC4T8dnpNH5b2(object P_0, UpdateRowSource P_1)
	{
		((DbCommand)P_0).UpdatedRowSource = P_1;
	}

	internal static bool nnfh4eWRvHWsicDfvDP2(object P_0)
	{
		return ((DbCommand)P_0).DesignTimeVisible;
	}

	internal static void NClqwDWR8pc2fK5kpqfr(object P_0, bool P_1)
	{
		((DbCommand)P_0).DesignTimeVisible = P_1;
	}

	internal static void eEKpgBWRZtgajwlBEB0v(object P_0)
	{
		((Component)P_0).Dispose();
	}

	internal static bool iQ0a9oWRuJJIX7vaPNaa(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}
}
