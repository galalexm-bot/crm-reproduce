using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Exceptions;
using EleWise.ELMA.Runtime.NH.Id;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Id;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions.MSSQL;

public class MSSQLTransformationProvider : TransformationProvider
{
	private enum ConstraintType
	{
		AF,
		C,
		D,
		F,
		L,
		FN,
		FS,
		FT,
		IF,
		IT,
		P,
		PC,
		PK,
		RF,
		S,
		SN,
		SQ,
		TA,
		TF,
		TR,
		TT,
		U,
		UQ,
		V,
		X
	}

	public static string UidString;

	public static Guid ProviderUID;

	public const string GeneratorTable = "Sys_TableGenerators";

	public static readonly string[] GeneratorColumns;

	private Version engineVersion;

	public const string LocalLoopName = "elma-local-loop";

	private bool? isSequenceSupport;

	private static readonly string SqlGetPrimaryKeyByTable;

	private static readonly string SqlGetForeignKeys;

	private Dialect dialect;

	private AbstractDbMetadataProvider dbMetadataProvider;

	private string schemaName;

	private string defaultLoopCount;

	private static MSSQLTransformationProvider KYEEULtwerVAHoXosUo;

	public override Guid Uid => ProviderUID;

	public override Dialect Dialect
	{
		get
		{
			int num = 1;
			int num2 = num;
			Dialect obj;
			Dialect dialect = default(Dialect);
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = this.dialect;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a9455caf5a604783b3a743f491182420 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					dialect = (this.dialect = new MSSQLDialect(GetReservedWords(), GetCurrentSchemaName()));
					num2 = 2;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bf52420e3f0049cf9dbec307e6d391c7 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj = dialect;
					break;
				}
				break;
			}
			return obj;
		}
	}

	public override AbstractDbMetadataProvider DbMetadataProvider
	{
		get
		{
			int num = 1;
			int num2 = num;
			AbstractDbMetadataProvider abstractDbMetadataProvider2;
			AbstractDbMetadataProvider abstractDbMetadataProvider = default(AbstractDbMetadataProvider);
			while (true)
			{
				switch (num2)
				{
				case 1:
					abstractDbMetadataProvider2 = dbMetadataProvider;
					if (abstractDbMetadataProvider2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_adccb0765c0e42dbaf186220f45b757c != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					abstractDbMetadataProvider = (dbMetadataProvider = new MSSQLDbMetadataProvider(this));
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_636573f0701e4d3dad6ad17b85776458 == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					abstractDbMetadataProvider2 = abstractDbMetadataProvider;
					break;
				}
				break;
			}
			return abstractDbMetadataProvider2;
		}
	}

	private Version EngineVersion
	{
		get
		{
			int num = 2;
			int num2 = num;
			Version version = default(Version);
			Version version2;
			while (true)
			{
				switch (num2)
				{
				case 1:
					version = (engineVersion = (Version)f7gstBtBV49M9ZmHmgG(this));
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_636573f0701e4d3dad6ad17b85776458 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					version2 = engineVersion;
					if ((object)version2 != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_3f149d3899664c3e92db5de6fde4f35a != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					version2 = version;
					break;
				}
				break;
			}
			return version2;
		}
	}

	public override int TableRecordMaxSize => 7600;

	internal bool IsSequenceSupport
	{
		get
		{
			//Discarded unreachable code: IL_0037
			int num = 1;
			bool? flag3 = default(bool?);
			bool? flag = default(bool?);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					bool? flag2;
					switch (num2)
					{
					case 4:
						flag2 = flag3;
						break;
					case 2:
						return flag3.Value;
					case 3:
						goto end_IL_0012;
					case 1:
						flag = isSequenceSupport;
						num2 = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_443e20b770184f91ab3dcde8e39895cc == 0)
						{
							num2 = 0;
						}
						continue;
					default:
						if (!flag.HasValue)
						{
							num2 = 3;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ac8b4db689fb4d85a7bb7ce35db5e4d5 == 0)
							{
								num2 = 3;
							}
							continue;
						}
						flag2 = flag;
						break;
					}
					flag3 = flag2;
					num2 = 2;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a20e3edfdf494639a8a8084ef15a8911 == 0)
					{
						num2 = 0;
					}
					continue;
					end_IL_0012:
					break;
				}
				flag3 = (isSequenceSupport = GetCompatibilityLevel() > 100);
				num = 4;
			}
		}
	}

	public override bool HasFullAutoBackupSupport => true;

	[Obsolete("Не использовать", true)]
	public MSSQLTransformationProvider()
	{
		//Discarded unreachable code: IL_0045, IL_004a
		SgTqECtRaKUsLKOxgKV();
		defaultLoopCount = (string)XGqPdBtVvuc7MujvoVy(-800941032 ^ -800933024);
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_26c4d17a35c943fbaf0ef30e123de177 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public MSSQLTransformationProvider(Func<IDbConnection> connectionCreateFunc)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.BPCyhsoin5();
		defaultLoopCount = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1131190530 ^ -1131200122);
		base._002Ector(connectionCreateFunc);
	}

	public MSSQLTransformationProvider(string connectionString)
	{
		//Discarded unreachable code: IL_006c, IL_0071
		SgTqECtRaKUsLKOxgKV();
		defaultLoopCount = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--471720024 ^ 0x1C1DC720);
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
		CS_0024_003C_003E8__locals0.connectionString = connectionString;
		base._002Ector(() => new SqlConnection(CS_0024_003C_003E8__locals0.connectionString));
		int num = 0;
		if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a88ccd6fbe9d4d31ba568282bf848b44 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override ITransformationProvider CreateWithNewConnection()
	{
		return new MSSQLTransformationProvider(this);
	}

	private MSSQLTransformationProvider(MSSQLTransformationProvider other)
	{
		//Discarded unreachable code: IL_004b, IL_0050
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.BPCyhsoin5();
		defaultLoopCount = (string)XGqPdBtVvuc7MujvoVy(-1296333093 ^ -1296326237);
		base._002Ector(other.ConnectionCreateFunc);
		int num = 1;
		if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_e28a31dd97e1464f96b9d0b056879391 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				dialect = other.dialect;
				num = 2;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_846eae8b3f494ae2b3aeba9a1f80b104 == 0)
				{
					num = 2;
				}
				break;
			case 2:
				schemaName = other.schemaName;
				num = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_e4ca8eb6304c45b5b9866ec7523159cd != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected override bool CanRetryAfterException(Exception ex)
	{
		//Discarded unreachable code: IL_0055, IL_0064, IL_00d2, IL_00e1, IL_0108, IL_0154, IL_0163
		int num = 4;
		Exception ex3 = default(Exception);
		SqlException ex2 = default(SqlException);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					return false;
				case 2:
					return true;
				case 7:
					ex3 = (Exception)RlDc4xtGsuWvX2E1biV(ex3);
					num2 = 10;
					continue;
				default:
					if (ex3 == null)
					{
						num2 = 9;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a2b331cfbee74083865b99663c080fcb != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 5;
				case 5:
					if (ex3 is SqlException)
					{
						num2 = 1;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_0d93129ec5af4fc5926990956e624437 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 7;
				case 1:
				case 9:
					break;
				case 4:
					vM2RiHtUqW6g9Gee6Yc(ex, XGqPdBtVvuc7MujvoVy(0x586FD9AE ^ 0x586FFE2A));
					num2 = 3;
					continue;
				case 3:
					ex3 = ex;
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_25f0dcdb5c5e4e6fbd7fee91aad234f3 == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					if (ex2 != null)
					{
						num2 = 12;
						continue;
					}
					goto case 11;
				case 11:
					return false;
				case 12:
					if (((IEnumerable)THenNxtFPE8KO75tiZY(ex2)).Cast<SqlError>().Any(delegate(SqlError error)
					{
						int num3 = 2;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 1:
								if (_003C_003Ec.fgbjPNuypgNJl1xFinN(error) != 1222)
								{
									num4 = 0;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a2b331cfbee74083865b99663c080fcb != 0)
									{
										num4 = 0;
									}
									continue;
								}
								break;
							case 2:
								if (error.Number != 1205)
								{
									num4 = 0;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_53c81d4dd9814619a62ac7ac8ba96c27 == 0)
									{
										num4 = 1;
									}
									continue;
								}
								break;
							default:
								return _003C_003Ec.fgbjPNuypgNJl1xFinN(error) == 3960;
							}
							break;
						}
						return true;
					}))
					{
						num2 = 2;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ac9723878e2248bcb9bd99e393b431fd != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 6;
				}
				break;
			}
			ex2 = ex3 as SqlException;
			num = 8;
		}
	}

	public override bool IsUnrecoverableException(Exception ex)
	{
		//Discarded unreachable code: IL_004d, IL_005c, IL_00a2, IL_00b1, IL_0105, IL_0114
		int num = 5;
		Exception ex3 = default(Exception);
		SqlException ex2 = default(SqlException);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 10:
					ex3 = (Exception)RlDc4xtGsuWvX2E1biV(ex3);
					num2 = 7;
					break;
				case 3:
					ex2 = ex3 as SqlException;
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_30d379f142a04774b5dae7c74c918bb8 != 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					if (ex == null)
					{
						num2 = 4;
						break;
					}
					ex3 = ex;
					num2 = 4;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_1ac7b80080314bbdb29619485c5fbb66 != 0)
					{
						num2 = 9;
					}
					break;
				case 4:
					return false;
				default:
					if (ex2 != null)
					{
						goto end_IL_0012;
					}
					goto case 8;
				case 2:
					if (!(ex3 is SqlException))
					{
						num2 = 10;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_80b6e3007a3e4355a8078b16fb1979e5 == 0)
						{
							num2 = 6;
						}
						break;
					}
					goto case 3;
				case 7:
				case 9:
					if (ex3 != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_846eae8b3f494ae2b3aeba9a1f80b104 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 3;
				case 8:
					return false;
				case 6:
					return ((IEnumerable)THenNxtFPE8KO75tiZY(ex2)).Cast<SqlError>().Any((SqlError error) => _003C_003Ec.fgbjPNuypgNJl1xFinN(error) == 1205);
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	public override void ProcessException(Exception ex, IDbConnection dbConnection)
	{
		//Discarded unreachable code: IL_0072, IL_0081
		int num = 1;
		int num2 = num;
		SqlException ex2 = default(SqlException);
		while (true)
		{
			switch (num2)
			{
			default:
				ex2 = ex.InnerException as SqlException;
				num2 = 5;
				continue;
			case 1:
				Gnv4gjtio9mS5t3plFx(this, ex, dbConnection);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_8cc4e99f5f9a4922bb7991de4d990c7f != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			case 5:
				if (ex2 == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_88b018be80f64052a4b6364462094eef == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 4:
				throw new Exception((string)fFj9Mht4X6bWClKSKi9(XGqPdBtVvuc7MujvoVy(-1131190530 ^ -1131200142)), ex);
			case 3:
				break;
			}
			if (ex2.Number != 547)
			{
				break;
			}
			num2 = 4;
		}
	}

	public override string GetDatabaseServerVersion()
	{
		int num = 2;
		int compatibilityLevel = default(int);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (compatibilityLevel > 0)
					{
						return (string)HiksGQtskVtGrkx73rX(new object[4]
						{
							text,
							UN8vmWtHDYVtEOHI6Ev(),
							XGqPdBtVvuc7MujvoVy(0x720B60EA ^ 0x720B486A),
							compatibilityLevel
						});
					}
					goto end_IL_0012;
				case 3:
					return text;
				case 2:
					text = (string)wVIHN7thWqK5pmfeoh7(rBKgO9teL7U3AtqFykL(ExecuteScalar((string)XGqPdBtVvuc7MujvoVy(-1676901510 ^ -1676891354))), new char[2] { '\r', '\n' });
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_30d379f142a04774b5dae7c74c918bb8 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					compatibilityLevel = GetCompatibilityLevel();
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_c4f350cb93ad41c2a93de4e094bd3eae != 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	internal int GetCompatibilityLevel()
	{
		//Discarded unreachable code: IL_0060, IL_0092, IL_00ca, IL_00d9
		int num = default(int);
		switch (1)
		{
		default:
			return num;
		case 1:
			try
			{
				num = NvaINVtcbUxYxG0HGaj(ExecuteScalar(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x77B5510C ^ 0x77B579A2)));
				int num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_937e86e483374781b74ae1d5b232cdfa != 0)
				{
					num2 = 0;
				}
				return num2 switch
				{
					0 => num, 
					_ => num, 
				};
			}
			catch
			{
				int num3 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a66ccd03acd144368047b44c2d5d0065 == 0)
				{
					num3 = 1;
				}
				while (true)
				{
					switch (num3)
					{
					default:
						return num;
					case 0:
						return num;
					case 1:
						num = 0;
						num3 = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a83396b5f3ee40bd928548245e32bc43 == 0)
						{
							num3 = 0;
						}
						break;
					}
				}
			}
		}
	}

	public override Version GetEngineVersion()
	{
		int num = 1;
		int num2 = num;
		Version result = default(Version);
		while (true)
		{
			switch (num2)
			{
			default:
				return result;
			case 1:
				Version.TryParse((string)wVIHN7thWqK5pmfeoh7(rBKgO9teL7U3AtqFykL(ExecuteScalar((string)XGqPdBtVvuc7MujvoVy(-1374979190 ^ -1374986284))), new char[2] { '\r', '\n' }), out result);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_adcdf8abe8194ee7810e832bda7e08e7 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override string GuidQuerySintaxis(Guid guid)
	{
		return GuidQuerySintaxisStatic(guid);
	}

	public override string GetCurrentSchemaName()
	{
		int num = 2;
		int num2 = num;
		string text = default(string);
		string text2;
		while (true)
		{
			switch (num2)
			{
			case 1:
				text = (schemaName = GetSchemaName());
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_4599535ffcb34731ae493be59317478a == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				text2 = schemaName;
				if (text2 != null)
				{
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bc105917f678426d88a775d433c07fc2 == 0)
				{
					num2 = 1;
				}
				continue;
			default:
				text2 = text;
				break;
			}
			break;
		}
		return text2;
	}

	internal static string GuidQuerySintaxisStatic(Guid guid)
	{
		return (string)uMFAPatpGiPJkACEaAw(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1374979190 ^ -1374989648), guid.ToString().ToLower());
	}

	public override string SetupFetchOptions(string query, FetchOptions fetchOptions, bool quoteIfNeededSortExpression)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (vuLpu8tX29GaSWtmraT(EngineVersion) >= 11)
				{
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a83396b5f3ee40bd928548245e32bc43 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return SetupFetchOptions2008(query, fetchOptions, quoteIfNeededSortExpression);
			default:
				return SetupFetchOptions2012(query, fetchOptions, quoteIfNeededSortExpression);
			}
		}
	}

	private string SetupFetchOptions2008(string query, FetchOptions fetchOptions, bool quoteIfNeededSortExpression)
	{
		//Discarded unreachable code: IL_0089, IL_0098, IL_00b5
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass33_0 _003C_003Ec__DisplayClass33_ = default(_003C_003Ec__DisplayClass33_0);
		StringBuilder stringBuilder = default(StringBuilder);
		StringBuilder stringBuilder2 = default(StringBuilder);
		bool flag = default(bool);
		string text = default(string);
		while (true)
		{
			int num3;
			bool flag2;
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass33_.quoteIfNeededSortExpression = quoteIfNeededSortExpression;
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_9b1d47db702148b5af71c10bd42d90c2 != 0)
				{
					num2 = 8;
				}
				continue;
			case 1:
				query = (string)iPPsXyt5saR0K4YXBZj(query);
				num2 = 6;
				continue;
			case 12:
				num3 = ((!object.Equals(fetchOptions, PZ5K9StDsWB96ktohY6())) ? 1 : 0);
				goto IL_01b0;
			case 3:
				_003C_003Ec__DisplayClass33_ = new _003C_003Ec__DisplayClass33_0();
				num2 = 2;
				continue;
			case 8:
				_003C_003Ec__DisplayClass33_._003C_003E4__this = this;
				num2 = 9;
				continue;
			case 4:
				if (hMWJ2jtlhB6Ckmq6WYm(fetchOptions) != 0)
				{
					num2 = 11;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_38564d6ade73482fadcc5aedb5edd1aa != 0)
					{
						num2 = 11;
					}
					continue;
				}
				break;
			case 6:
				if (E6ZTH8tqEJDrGBQGDI1(fetchOptions, null))
				{
					num2 = 12;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_2580d923b4ce4bd0b5bb01b45f02c594 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				num3 = 0;
				goto IL_01b0;
			case 7:
			case 11:
				bkVA4OtbRoOvUHOEukM(stringBuilder, y9oZtWt1lCoeAtg9rgu(XGqPdBtVvuc7MujvoVy(-370249262 ^ -370254986), stringBuilder2, fetchOptions.FirstResult + 1, g9m6lMtvSUcqZsQq10Z(fetchOptions) + hMWJ2jtlhB6Ckmq6WYm(fetchOptions)));
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_d1a34b21803e45aa91fae87c4eb8443a == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				return stringBuilder.ToString();
			case 9:
				stringBuilder = new StringBuilder();
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_dcc36b50df1c4388b3314014303f132a == 0)
				{
					num2 = 0;
				}
				continue;
			case 10:
				break;
				IL_01b0:
				flag = fetchOptions != null && (!string.IsNullOrEmpty((string)cxZoTetfbN7WkyP7CMV(fetchOptions)) || fetchOptions.SortDescriptors.Any());
				flag2 = num3 != 0 && hyn7pft0F7Y2SolMZnX(query, XGqPdBtVvuc7MujvoVy(-603134395 ^ -603140339), StringComparison.OrdinalIgnoreCase);
				stringBuilder2 = new StringBuilder();
				if (flag)
				{
					if (!fetchOptions.SortDescriptors.Any())
					{
						fetchOptions.SortDescriptors.Add(new FetchOptionsSortDescriptor(fetchOptions.SortExpression, xQZqw6tmi8BAn715Lqa(fetchOptions)));
					}
					IEnumerable<string> values = fetchOptions.SortDescriptors.Select(_003C_003Ec__DisplayClass33_._003CSetupFetchOptions2008_003Eb__0);
					text = (string)uMFAPatpGiPJkACEaAw(XGqPdBtVvuc7MujvoVy(0x63BC7D18 ^ 0x63BC5444), string.Join((string)XGqPdBtVvuc7MujvoVy(0x720B60EA ^ 0x720B4990), values));
				}
				else
				{
					text = (string)XGqPdBtVvuc7MujvoVy(0x6E68FD33 ^ 0x6E68D4B1);
				}
				if (num3 != 0)
				{
					if (hMWJ2jtlhB6Ckmq6WYm(fetchOptions) == 0)
					{
						bkVA4OtbRoOvUHOEukM(stringBuilder2, uMFAPatpGiPJkACEaAw(XGqPdBtVvuc7MujvoVy(-564335650 ^ -564346256), g9m6lMtvSUcqZsQq10Z(fetchOptions)));
					}
					else
					{
						stringBuilder2.Append(string.Format((string)XGqPdBtVvuc7MujvoVy(-846750580 ^ -846744232), text));
					}
				}
				else
				{
					bkVA4OtbRoOvUHOEukM(stringBuilder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x816BBA1 ^ 0x816919B));
				}
				if (num3 == 0)
				{
					bkVA4OtbRoOvUHOEukM(stringBuilder, query);
				}
				else
				{
					bkVA4OtbRoOvUHOEukM(stringBuilder2, (!flag2) ? query : uMFAPatpGiPJkACEaAw(XGqPdBtVvuc7MujvoVy(0x4960B0BA ^ 0x49609AF4), query));
				}
				if (num3 != 0)
				{
					num2 = 4;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a1374360d15f4247b418e6f0fa5eef4e != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto default;
			}
			stringBuilder.Append((string)MKCnfitShvd4jGmR7IN(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x816BBA1 ^ 0x8169133), stringBuilder2, flag ? text : ""));
			num2 = 5;
		}
	}

	private string SetupFetchOptions2012(string query, FetchOptions fetchOptions, bool quoteIfNeededSortExpression)
	{
		//Discarded unreachable code: IL_0110, IL_011f, IL_018d, IL_01b3, IL_01bd, IL_01cc, IL_025d, IL_026c, IL_02dd, IL_03d4
		int num = 14;
		int num2 = num;
		bool flag = default(bool);
		StringBuilder stringBuilder = default(StringBuilder);
		IEnumerable<string> values = default(IEnumerable<string>);
		_003C_003Ec__DisplayClass34_0 _003C_003Ec__DisplayClass34_ = default(_003C_003Ec__DisplayClass34_0);
		while (true)
		{
			int num4;
			int num3;
			switch (num2)
			{
			case 5:
				if (fetchOptions.SortDescriptors.Any())
				{
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bc105917f678426d88a775d433c07fc2 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 19;
			case 17:
			case 22:
				if (flag)
				{
					num2 = 9;
					break;
				}
				goto case 10;
			case 26:
				query = (string)iPPsXyt5saR0K4YXBZj(query);
				num2 = 20;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_b98765ef3c444c499e843eecd7ad6cc5 != 0)
				{
					num2 = 25;
				}
				break;
			case 16:
				if (E6ZTH8tqEJDrGBQGDI1(fetchOptions, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_24d54149ebc348d09713294df311806b == 0)
					{
						num2 = 4;
					}
					break;
				}
				num4 = 0;
				goto IL_03fd;
			case 2:
				bkVA4OtbRoOvUHOEukM(stringBuilder, string.Join((string)XGqPdBtVvuc7MujvoVy(-1294383846 ^ -1294373792), values));
				num2 = 17;
				break;
			case 14:
				_003C_003Ec__DisplayClass34_ = new _003C_003Ec__DisplayClass34_0();
				num2 = 11;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_d1a34b21803e45aa91fae87c4eb8443a == 0)
				{
					num2 = 13;
				}
				break;
			case 24:
				num3 = ((!Y1jvnutrZIjN3J033Qy(fetchOptions, PZ5K9StDsWB96ktohY6())) ? 1 : 0);
				goto IL_03f0;
			case 6:
				stringBuilder = new StringBuilder();
				num2 = 26;
				break;
			case 23:
				num4 = (fetchOptions.SortDescriptors.Any() ? 1 : 0);
				goto IL_03fd;
			case 8:
			case 18:
				if (flag)
				{
					num2 = 5;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_c07718730a1849a8a092e51c2522f212 != 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 17;
			case 12:
				bkVA4OtbRoOvUHOEukM(stringBuilder, XGqPdBtVvuc7MujvoVy(-125369401 ^ -125359547));
				num2 = 22;
				break;
			default:
				bkVA4OtbRoOvUHOEukM(stringBuilder, XGqPdBtVvuc7MujvoVy(-1179530319 ^ -1179524893));
				num2 = 2;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_473ad8036e884220a80a5543064a2d98 == 0)
				{
					num2 = 5;
				}
				break;
			case 9:
				if (hMWJ2jtlhB6Ckmq6WYm(fetchOptions) > 0)
				{
					num2 = 2;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bbc137d911274e6c8ec7374800482ba2 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 10;
			case 1:
			case 20:
				values = fetchOptions.SortDescriptors.Select(_003C_003Ec__DisplayClass34_._003CSetupFetchOptions2012_003Eb__0);
				num2 = 2;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ac9723878e2248bcb9bd99e393b431fd == 0)
				{
					num2 = 2;
				}
				break;
			case 10:
				return stringBuilder.ToString();
			case 15:
				_003C_003Ec__DisplayClass34_._003C_003E4__this = this;
				num2 = 6;
				break;
			case 3:
				stringBuilder.Append((string)MKCnfitShvd4jGmR7IN(XGqPdBtVvuc7MujvoVy(0x6647693 ^ 0x6645DF9), fetchOptions.FirstResult, fetchOptions.MaxResults));
				num2 = 10;
				break;
			case 4:
				if (!string.IsNullOrEmpty(fetchOptions.SortExpression))
				{
					num2 = 5;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_da020ace8b12415a904b6d9c77d7515c == 0)
					{
						num2 = 21;
					}
					break;
				}
				goto case 23;
			case 25:
				if (!(fetchOptions != null))
				{
					num2 = 11;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bbc137d911274e6c8ec7374800482ba2 == 0)
					{
						num2 = 11;
					}
					break;
				}
				goto case 24;
			case 13:
				_003C_003Ec__DisplayClass34_.quoteIfNeededSortExpression = quoteIfNeededSortExpression;
				num2 = 15;
				break;
			case 19:
				fetchOptions.SortDescriptors.Add(new FetchOptionsSortDescriptor(fetchOptions.SortExpression, xQZqw6tmi8BAn715Lqa(fetchOptions)));
				num2 = 20;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_2580d923b4ce4bd0b5bb01b45f02c594 == 0)
				{
					num2 = 0;
				}
				break;
			case 21:
				num4 = 1;
				goto IL_03fd;
			case 7:
				if (fetchOptions.FirstResult > 0)
				{
					num2 = 12;
					break;
				}
				goto case 17;
			case 11:
				{
					num3 = 0;
					goto IL_03f0;
				}
				IL_03fd:
				bkVA4OtbRoOvUHOEukM(stringBuilder, XGqPdBtVvuc7MujvoVy(-603134395 ^ -603140993));
				if (flag && hMWJ2jtlhB6Ckmq6WYm(fetchOptions) == 0)
				{
					stringBuilder.Append((string)uMFAPatpGiPJkACEaAw(XGqPdBtVvuc7MujvoVy(-1526402459 ^ -1526408865), fetchOptions.MaxResults));
				}
				bkVA4OtbRoOvUHOEukM(stringBuilder, query);
				if (num4 == 0)
				{
					num2 = 8;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_b191e4df737c4fbb97b7fbe68dd7816d == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto default;
				IL_03f0:
				flag = (byte)num3 != 0;
				num2 = 16;
				break;
			}
		}
	}

	public override string Count(string query)
	{
		return (string)MKCnfitShvd4jGmR7IN(XGqPdBtVvuc7MujvoVy(0x4E15D4BA ^ 0x4E15FF7A), query, Dialect.QuoteIfNeeded((string)XGqPdBtVvuc7MujvoVy(-868652467 ^ -868661683)));
	}

	public override string GetSqlOrderBy(PropertyMetadata propertyMetadata, string columnName)
	{
		return columnName;
	}

	public override string GetSqlHierarchicalChilds(string tableName, string parentColumnName, string nameColumnName, long? parentId, int indent, int deep)
	{
		if (!TableExists(tableName))
		{
			throw new Exception(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1296333093 ^ -1296323901), tableName));
		}
		if (!ColumnExists(tableName, parentColumnName))
		{
			throw new Exception(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x816BBA1 ^ 0x81697EF), tableName, parentColumnName));
		}
		if (!string.IsNullOrWhiteSpace(nameColumnName) && !ColumnExists(tableName, nameColumnName))
		{
			throw new Exception(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4CDC671 ^ 0x4CDEA3F), tableName, parentColumnName));
		}
		long num = parentId ?? 0;
		return string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1508074661 ^ -1508067333) + ((!parentId.HasValue) ? SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x36554C4C ^ 0x3655612C) : SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-964056903 ^ -964065911)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4152E1C2 ^ 0x4152CC56) + ((!string.IsNullOrWhiteSpace(nameColumnName)) ? SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2115681549 ^ -2115670939) : SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1497017110 ^ -1497007460)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C6497C8 ^ 0x6C64B90E), Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x483FFC8B ^ 0x483FD3E7)), Dialect.QuoteIfNeeded(parentColumnName), Dialect.QuoteIfNeeded(tableName), deep + indent, num, (!string.IsNullOrWhiteSpace(nameColumnName)) ? Dialect.QuoteIfNeeded(nameColumnName) : "", indent);
	}

	public override string BitAndExpression(string idcolumn, long mask)
	{
		return (string)QtymB2tPVpr3HQNsawe(this, idcolumn, mask.ToString());
	}

	public override string BitAndExpression(string idcolumn, string mask)
	{
		return (string)MKCnfitShvd4jGmR7IN(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-536897350 ^ -536889394), idcolumn, mask);
	}

	public override string NoLockTableExpression(string tableName, string alias)
	{
		return (string)MKCnfitShvd4jGmR7IN(XGqPdBtVvuc7MujvoVy(-880913840 ^ -880902694), NJvbMEtWcZWYUnSGhUH(AOInkota5rqbJBHlvcS(this), tableName), alias);
	}

	public override int Insert(string table, string[] columns, object[] values, bool isNeedInsertId)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		System.Threading.Tasks.ValueTask<int> valueTask = default(System.Threading.Tasks.ValueTask<int>);
		ValueTaskAwaiter<int> awaiter = default(ValueTaskAwaiter<int>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				valueTask = InsertAsync(table, columns, values, isNeedInsertId, isAsync: false);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bc105917f678426d88a775d433c07fc2 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				awaiter = valueTask.GetAwaiter();
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_adcdf8abe8194ee7810e832bda7e08e7 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return awaiter.GetResult();
			}
		}
	}

	public override Task<int> InsertAsync(string table, string[] columns, object[] values, bool isNeedInsertId, CancellationToken cancellationToken = default(CancellationToken))
	{
		return InsertAsync(table, columns, values, isNeedInsertId, isAsync: true, cancellationToken).AsTask();
	}

	[AsyncStateMachine(typeof(_003CInsertAsync_003Ed__43))]
	private System.Threading.Tasks.ValueTask<int> InsertAsync(string table, string[] columns, object[] values, bool isNeedInsertId, bool isAsync, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		_003CInsertAsync_003Ed__43 _003CInsertAsync_003Ed__ = default(_003CInsertAsync_003Ed__43);
		_003CInsertAsync_003Ed__._003C_003E4__this = this;
		_003CInsertAsync_003Ed__.table = table;
		_003CInsertAsync_003Ed__.columns = columns;
		_003CInsertAsync_003Ed__.values = values;
		_003CInsertAsync_003Ed__.isNeedInsertId = isNeedInsertId;
		_003CInsertAsync_003Ed__.isAsync = isAsync;
		_003CInsertAsync_003Ed__.cancellationToken = cancellationToken;
		_003CInsertAsync_003Ed__._003C_003Et__builder = AsyncValueTaskMethodBuilder<int>.Create();
		_003CInsertAsync_003Ed__._003C_003E1__state = -1;
		AsyncValueTaskMethodBuilder<int> _003C_003Et__builder = _003CInsertAsync_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CInsertAsync_003Ed__43>(ref _003CInsertAsync_003Ed__);
		return _003CInsertAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	public override int Insert(string table, string[] columns, string selectColName, string selectFrom, bool isNeedInsertId, Dictionary<string, object> paramValues = null)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		return InsertAsync(table, columns, selectColName, selectFrom, isNeedInsertId, paramValues, isAsync: false, CancellationToken.None).GetAwaiter().GetResult();
	}

	public override Task<int> InsertAsync(string table, string[] columns, string selectColName, string selectFrom, bool isNeedInsertId, Dictionary<string, object> paramValues = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		return InsertAsync(table, columns, selectColName, selectFrom, isNeedInsertId, paramValues, isAsync: true, cancellationToken).AsTask();
	}

	[AsyncStateMachine(typeof(_003CInsertAsync_003Ed__46))]
	private System.Threading.Tasks.ValueTask<int> InsertAsync(string table, string[] columns, string selectColName, string selectFrom, bool isNeedInsertId, Dictionary<string, object> paramValues, bool isAsync, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		_003CInsertAsync_003Ed__46 _003CInsertAsync_003Ed__ = default(_003CInsertAsync_003Ed__46);
		_003CInsertAsync_003Ed__._003C_003E4__this = this;
		_003CInsertAsync_003Ed__.table = table;
		_003CInsertAsync_003Ed__.columns = columns;
		_003CInsertAsync_003Ed__.selectColName = selectColName;
		_003CInsertAsync_003Ed__.selectFrom = selectFrom;
		_003CInsertAsync_003Ed__.isNeedInsertId = isNeedInsertId;
		_003CInsertAsync_003Ed__.paramValues = paramValues;
		_003CInsertAsync_003Ed__.isAsync = isAsync;
		_003CInsertAsync_003Ed__.cancellationToken = cancellationToken;
		_003CInsertAsync_003Ed__._003C_003Et__builder = AsyncValueTaskMethodBuilder<int>.Create();
		_003CInsertAsync_003Ed__._003C_003E1__state = -1;
		AsyncValueTaskMethodBuilder<int> _003C_003Et__builder = _003CInsertAsync_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CInsertAsync_003Ed__46>(ref _003CInsertAsync_003Ed__);
		return _003CInsertAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	protected override void AddTable(string table, string columns, bool sequence)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				AddTableSequence(table);
				num2 = 3;
				break;
			case 1:
				if (sequence)
				{
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bc105917f678426d88a775d433c07fc2 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 3:
				return;
			case 2:
				JOQiZut2fbLrIH9ZEnu(this, table, columns, sequence);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_611f69e7a7a34a4fbeb0099afc53aecd != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected override void AddTable(string table, string columns, bool sequence, bool isTemporary)
	{
		//Discarded unreachable code: IL_0035
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				base.AddTable(table, columns, sequence, isTemporary);
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_b14550e4462b4c7190663aa2ba86338f != 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				if (!sequence)
				{
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_d2ea3571782f460a8fcf4212c4b89aef == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 3:
				break;
			case 4:
				return;
			}
			aI2nBOt745gCH9CqytV(this, table);
			num2 = 4;
		}
	}

	public override void CheckPrerequisites()
	{
		//Discarded unreachable code: IL_00a3, IL_01c7, IL_0239, IL_0272, IL_031f, IL_0357, IL_0366, IL_0392, IL_0401, IL_0414, IL_0423, IL_056b, IL_05a3, IL_05b2, IL_0640, IL_0670, IL_067f, IL_068b, IL_06b8, IL_076c, IL_07a4, IL_07b3, IL_07e4, IL_081c, IL_082b, IL_08e7, IL_0927, IL_0932, IL_0979, IL_09b1, IL_09dc, IL_0a79, IL_0a8c, IL_0a9b, IL_0b0b, IL_0b2a, IL_0b39, IL_0b66, IL_0b75, IL_0d4d, IL_0d80, IL_0dd1, IL_0de0, IL_0e54, IL_0ecd, IL_0edc, IL_0f73, IL_0f82, IL_0f91, IL_0f9d, IL_0fac, IL_1005
		int num = 7;
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		SqlConnection sqlConnection = default(SqlConnection);
		string text3 = default(string);
		bool flag5 = default(bool);
		bool flag4 = default(bool);
		SqlCommand sqlCommand = default(SqlCommand);
		SqlCommand sqlCommand3 = default(SqlCommand);
		SqlCommand sqlCommand2 = default(SqlCommand);
		SqlDataReader sqlDataReader = default(SqlDataReader);
		string text4 = default(string);
		SqlConnection sqlConnection2 = default(SqlConnection);
		bool flag = default(bool);
		string text2 = default(string);
		int num7 = default(int);
		string text = default(string);
		Guid guid = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					flag3 = false;
					num2 = 4;
					break;
				case 4:
					flag2 = false;
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_6c4bacaf03bd45578009f4720a268b0d != 0)
					{
						num2 = 2;
					}
					break;
				case 7:
					base.CheckPrerequisites();
					num2 = 6;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_0d93129ec5af4fc5926990956e624437 == 0)
					{
						num2 = 3;
					}
					break;
				case 13:
					try
					{
						sqlConnection.Open();
						int num9 = 6;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_5ae23e79a5ef4ec9a6a58c0daa87c096 != 0)
						{
							num9 = 0;
						}
						while (true)
						{
							switch (num9)
							{
							case 14:
								text3 = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-536897350 ^ -536893396));
								num9 = 2;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_762cf717254743a4a1d5f3fcfeb2849f != 0)
								{
									num9 = 2;
								}
								continue;
							case 8:
								if (!flag5)
								{
									num9 = 10;
									continue;
								}
								break;
							case 3:
								flag4 = false;
								num9 = 13;
								continue;
							case 5:
								zyupxQZtRwXKaTMefqr(sqlConnection);
								num9 = 4;
								continue;
							case 1:
							{
								text3 = (string)CxEtKxZuSTfcl8FeJTE(new SqlConnectionStringBuilder((string)uJRPyAZ84jGYCkeCJy1(sqlConnection)));
								int num25 = 7;
								num9 = num25;
								continue;
							}
							case 2:
								flag4 = true;
								num9 = 11;
								continue;
							case 4:
								text3 = sqlConnection.DataSource;
								num9 = 3;
								continue;
							case 13:
								if (Gs5JvTZZXy7MxrFiPhM(text3))
								{
									num9 = 1;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_536a197f18c04d92abf9ab236ddc733a == 0)
									{
										num9 = 1;
									}
									continue;
								}
								goto case 7;
							case 6:
								flag5 = false;
								num9 = 0;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a20e3edfdf494639a8a8084ef15a8911 == 0)
								{
									num9 = 0;
								}
								continue;
							default:
								try
								{
									SqlCommand sqlCommand4 = (SqlCommand)qiP9R7t3Q96uIMDXavF(sqlConnection);
									int num26 = 0;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ec5f92fd6ddb449a9afc09c18f0a77db != 0)
									{
										num26 = 0;
									}
									switch (num26)
									{
									default:
										try
										{
											lewHvxtz6W2QCH9a81r(sqlCommand4, CommandType.Text);
											int num27 = 0;
											if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_da020ace8b12415a904b6d9c77d7515c == 0)
											{
												num27 = 0;
											}
											while (true)
											{
												switch (num27)
												{
												default:
													DTmiu9ZK3uitCW7W2vt(sqlCommand4, string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4CDC671 ^ 0x4CDE9C7), XGqPdBtVvuc7MujvoVy(0x7486AEA8 ^ 0x74869E9A)));
													num27 = 2;
													continue;
												case 2:
													flag5 = NvaINVtcbUxYxG0HGaj(sqlCommand4.ExecuteScalar()) == 1;
													num27 = 1;
													if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_1ac7b80080314bbdb29619485c5fbb66 == 0)
													{
														num27 = 0;
													}
													continue;
												case 1:
													break;
												}
												break;
											}
										}
										finally
										{
											if (sqlCommand4 != null)
											{
												int num28 = 0;
												if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_611f69e7a7a34a4fbeb0099afc53aecd == 0)
												{
													num28 = 0;
												}
												while (true)
												{
													switch (num28)
													{
													default:
														b7Z9UsZMPYIQOaNIN6H(sqlCommand4);
														num28 = 1;
														if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_e4ca8eb6304c45b5b9866ec7523159cd != 0)
														{
															num28 = 1;
														}
														continue;
													case 1:
														break;
													}
													break;
												}
											}
										}
										break;
									case 1:
										break;
									}
								}
								catch (Exception exception)
								{
									int num29 = 0;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_937e86e483374781b74ae1d5b232cdfa != 0)
									{
										num29 = 0;
									}
									while (true)
									{
										switch (num29)
										{
										case 1:
											throw;
										}
										Logger.Log.Error(XGqPdBtVvuc7MujvoVy(-1676901510 ^ -1676889298), exception);
										num29 = 1;
										if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_9b1d47db702148b5af71c10bd42d90c2 == 0)
										{
											num29 = 0;
										}
									}
								}
								finally
								{
									Qoe8AtZYG98lpnGFEW8(sqlConnection);
									int num30 = 0;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_da020ace8b12415a904b6d9c77d7515c == 0)
									{
										num30 = 0;
									}
									switch (num30)
									{
									case 0:
										break;
									}
								}
								goto case 8;
							case 10:
								sqlConnection = (SqlConnection)base.ConnectionCreateFunc();
								num9 = 5;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_b191e4df737c4fbb97b7fbe68dd7816d != 0)
								{
									num9 = 5;
								}
								continue;
							case 15:
								try
								{
									int num10;
									if (flag4)
									{
										num10 = 0;
										if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_369aa437eac94c37881db865ddabe863 == 0)
										{
											num10 = 0;
										}
										goto IL_0481;
									}
									sqlCommand = (SqlCommand)qiP9R7t3Q96uIMDXavF(sqlConnection);
									int num11 = 6;
									goto IL_047d;
									IL_047d:
									num10 = num11;
									goto IL_0481;
									IL_0481:
									while (true)
									{
										switch (num10)
										{
										default:
											throw new Exception((string)fFj9Mht4X6bWClKSKi9(XGqPdBtVvuc7MujvoVy(-15819198 ^ -15815654)));
										case 2:
											sqlCommand3 = (SqlCommand)qiP9R7t3Q96uIMDXavF(sqlConnection);
											num11 = 5;
											break;
										case 4:
											sqlCommand2 = (SqlCommand)qiP9R7t3Q96uIMDXavF(sqlConnection);
											num10 = 0;
											if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bdc18f4c9e6b474ea4d1521d9166d946 == 0)
											{
												num10 = 1;
											}
											continue;
										case 5:
											try
											{
												lewHvxtz6W2QCH9a81r(sqlCommand3, CommandType.Text);
												int num19 = 2;
												while (true)
												{
													switch (num19)
													{
													case 1:
														try
														{
														}
														finally
														{
															if (sqlDataReader != null)
															{
																int num20 = 0;
																if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_8b024ba6fa664698aa135d9537ef281b == 0)
																{
																	num20 = 1;
																}
																while (true)
																{
																	switch (num20)
																	{
																	case 1:
																		b7Z9UsZMPYIQOaNIN6H(sqlDataReader);
																		num20 = 0;
																		if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_992aa32d3a3449929072ecd77a2ed007 == 0)
																		{
																			num20 = 0;
																		}
																		continue;
																	case 0:
																		break;
																	}
																	break;
																}
															}
														}
														break;
													case 2:
													{
														DTmiu9ZK3uitCW7W2vt(sqlCommand3, uMFAPatpGiPJkACEaAw(XGqPdBtVvuc7MujvoVy(0x2CE25C3E ^ 0x2CE26FCC), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-147020345 ^ -147024395)));
														int num21 = 3;
														num19 = num21;
														continue;
													}
													case 3:
														sqlDataReader = (SqlDataReader)ovupgMZI32LumL2PTKQ(sqlCommand3);
														num19 = 0;
														if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_db0266f588ec4dba9939e9dffe57b346 == 0)
														{
															num19 = 1;
														}
														continue;
													case 0:
														break;
													}
													break;
												}
											}
											finally
											{
												int num22;
												if (sqlCommand3 == null)
												{
													num22 = 0;
													if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_24d54149ebc348d09713294df311806b == 0)
													{
														num22 = 1;
													}
													goto IL_0644;
												}
												goto IL_065a;
												IL_065a:
												((IDisposable)sqlCommand3).Dispose();
												num22 = 2;
												goto IL_0644;
												IL_0644:
												switch (num22)
												{
												case 1:
													goto end_IL_061f;
												case 2:
													goto end_IL_061f;
												}
												goto IL_065a;
												end_IL_061f:;
											}
											goto case 4;
										case 1:
											try
											{
												lewHvxtz6W2QCH9a81r(sqlCommand2, CommandType.Text);
												int num16 = 1;
												if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_273c06d8704c4280a5fc2b25c62f33f4 == 0)
												{
													num16 = 2;
												}
												while (true)
												{
													switch (num16)
													{
													case 2:
														sqlCommand2.CommandText = (string)uMFAPatpGiPJkACEaAw(XGqPdBtVvuc7MujvoVy(-397159490 ^ -397154506), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-880913840 ^ -880909726));
														num16 = 0;
														if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_595bc6899ac747d989e6cbc941c80562 != 0)
														{
															num16 = 0;
														}
														continue;
													default:
														sqlDataReader = sqlCommand2.ExecuteReader();
														num16 = 0;
														if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_53c81d4dd9814619a62ac7ac8ba96c27 == 0)
														{
															num16 = 1;
														}
														continue;
													case 1:
														try
														{
														}
														finally
														{
															if (sqlDataReader != null)
															{
																int num17 = 1;
																if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_5bed8957b9564941b8d84bad58ce64d0 == 0)
																{
																	num17 = 0;
																}
																while (true)
																{
																	switch (num17)
																	{
																	case 1:
																		((IDisposable)sqlDataReader).Dispose();
																		num17 = 0;
																		if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_9b1d47db702148b5af71c10bd42d90c2 != 0)
																		{
																			num17 = 0;
																		}
																		continue;
																	case 0:
																		break;
																	}
																	break;
																}
															}
														}
														break;
													case 3:
														break;
													}
													break;
												}
											}
											finally
											{
												if (sqlCommand2 != null)
												{
													int num18 = 1;
													if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_273c06d8704c4280a5fc2b25c62f33f4 == 0)
													{
														num18 = 1;
													}
													while (true)
													{
														switch (num18)
														{
														case 1:
															((IDisposable)sqlCommand2).Dispose();
															num18 = 0;
															if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_610637caa58f480dbbd64235291b457a == 0)
															{
																num18 = 0;
															}
															continue;
														case 0:
															break;
														}
														break;
													}
												}
											}
											goto end_IL_0481;
										case 6:
											try
											{
												lewHvxtz6W2QCH9a81r(sqlCommand, CommandType.Text);
												int num12 = 0;
												if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_26c4d17a35c943fbaf0ef30e123de177 != 0)
												{
													num12 = 0;
												}
												while (true)
												{
													switch (num12)
													{
													default:
														sqlCommand.CommandText = (string)MKCnfitShvd4jGmR7IN(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x202D46BC ^ 0x202D75C2), XGqPdBtVvuc7MujvoVy(-813696680 ^ -813708950), text3);
														num12 = 1;
														if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_d77c90c2b1934f16bf9cfe858d8dba6d == 0)
														{
															num12 = 0;
														}
														continue;
													case 3:
														try
														{
														}
														finally
														{
															int num14;
															if (sqlDataReader == null)
															{
																num14 = 0;
																if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_8cc4e99f5f9a4922bb7991de4d990c7f == 0)
																{
																	num14 = 0;
																}
																goto IL_08eb;
															}
															goto IL_0901;
															IL_0901:
															b7Z9UsZMPYIQOaNIN6H(sqlDataReader);
															num14 = 1;
															if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_c76ae84e13cb4972824810f3a682325a == 0)
															{
																num14 = 1;
															}
															goto IL_08eb;
															IL_08eb:
															switch (num14)
															{
															default:
																goto end_IL_08c6;
															case 2:
																break;
															case 0:
																goto end_IL_08c6;
															case 1:
																goto end_IL_08c6;
															}
															goto IL_0901;
															end_IL_08c6:;
														}
														break;
													case 1:
													{
														sqlDataReader = sqlCommand.ExecuteReader();
														int num13 = 3;
														num12 = num13;
														continue;
													}
													case 2:
														break;
													}
													break;
												}
											}
											finally
											{
												if (sqlCommand != null)
												{
													int num15 = 0;
													if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_7d9c3f1bd5704dffa8a30fba06b99cdf != 0)
													{
														num15 = 0;
													}
													while (true)
													{
														switch (num15)
														{
														default:
															b7Z9UsZMPYIQOaNIN6H(sqlCommand);
															num15 = 1;
															if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_536a197f18c04d92abf9ab236ddc733a == 0)
															{
																num15 = 0;
															}
															continue;
														case 1:
															break;
														}
														break;
													}
												}
											}
											goto case 2;
										case 3:
											goto end_IL_0481;
										}
										goto IL_047d;
										continue;
										end_IL_0481:
										break;
									}
								}
								catch (Exception ex2)
								{
									int num23 = 0;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_88b018be80f64052a4b6364462094eef == 0)
									{
										num23 = 0;
									}
									while (true)
									{
										switch (num23)
										{
										case 1:
											throw new CheckPrerequisitesException((string)KH5wMDZyd6y6irkktcE(XGqPdBtVvuc7MujvoVy(-564335650 ^ -564339008), new object[2] { text4, ex2.Message }));
										}
										kP79T2Z9lGK1c1haqCo(d6IMEnZEgix4nwnvQgO(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1117619588 ^ -1117630828), ex2);
										num23 = 1;
										if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_067e68396ca94bf49b212b142d07ac32 == 0)
										{
											num23 = 1;
										}
									}
								}
								finally
								{
									Qoe8AtZYG98lpnGFEW8(sqlConnection);
									int num24 = 0;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_c07718730a1849a8a092e51c2522f212 != 0)
									{
										num24 = 0;
									}
									switch (num24)
									{
									case 0:
										break;
									}
								}
								break;
							case 11:
							case 12:
								text4 = (string)MKCnfitShvd4jGmR7IN(XGqPdBtVvuc7MujvoVy(0x816BBA1 ^ 0x8168B6B), XGqPdBtVvuc7MujvoVy(-214073528 ^ -214085766), text3);
								num9 = 15;
								continue;
							case 7:
								if (!Gs5JvTZZXy7MxrFiPhM(text3))
								{
									num9 = 12;
									continue;
								}
								goto case 14;
							case 9:
								break;
							}
							break;
						}
					}
					finally
					{
						int num31;
						if (sqlConnection2 == null)
						{
							num31 = 2;
							goto IL_0b0f;
						}
						goto IL_0b44;
						IL_0b0f:
						switch (num31)
						{
						case 2:
							goto end_IL_0afa;
						case 1:
							goto end_IL_0afa;
						}
						goto IL_0b44;
						IL_0b44:
						b7Z9UsZMPYIQOaNIN6H(sqlConnection2);
						num31 = 1;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bdc18f4c9e6b474ea4d1521d9166d946 != 0)
						{
							num31 = 0;
						}
						goto IL_0b0f;
						end_IL_0afa:;
					}
					goto case 1;
				case 9:
					flag = false;
					num2 = 3;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_e4ca8eb6304c45b5b9866ec7523159cd == 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					if (!IsSequenceSupport)
					{
						num2 = 12;
						break;
					}
					return;
				default:
					throw new CheckPrerequisitesException((string)KH5wMDZyd6y6irkktcE(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-603134395 ^ -603137657), new object[1] { text2 }));
				case 8:
					return;
				case 2:
					try
					{
						nwJriCZnXbmWoWpWbGx(this, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E7071FB ^ 0x7E7046B3), false, new Column[1]
						{
							new Column((string)XGqPdBtVvuc7MujvoVy(-147020345 ^ -147025233), DbType.String, 128, ColumnProperty.NotNull)
						});
						int num3 = 9;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 2:
								ExecuteNonQuery((string)XGqPdBtVvuc7MujvoVy(0x5B204BE7 ^ 0x5B207C99));
								num4 = 5;
								continue;
							case 3:
								num7 = ExecuteNonQuery((string)uMFAPatpGiPJkACEaAw(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-798966336 ^ -798981898), text));
								num4 = 6;
								continue;
							case 8:
								guid = vIk1yWZOQPvHWTuWZQR();
								num4 = 0;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_15400f29239a48f5a6f7d131d55cff1f == 0)
								{
									num4 = 0;
								}
								continue;
							case 5:
								flag3 = true;
								num4 = 7;
								continue;
							case 7:
								ExecuteNonQuery((string)XGqPdBtVvuc7MujvoVy(-2027299446 ^ -2027297446));
								num4 = 1;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_8cc4e99f5f9a4922bb7991de4d990c7f != 0)
								{
									num4 = 0;
								}
								continue;
							case 4:
								try
								{
									ExecuteNonQuery((string)uMFAPatpGiPJkACEaAw(XGqPdBtVvuc7MujvoVy(-2078768493 ^ -2078753235), text));
									int num5 = 0;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_c66a81b3385f4e6fa960aa83b221484b != 0)
									{
										num5 = 0;
									}
									switch (num5)
									{
									case 0:
										break;
									}
								}
								catch (Exception ex)
								{
									int num6 = 0;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_611f69e7a7a34a4fbeb0099afc53aecd != 0)
									{
										num6 = 0;
									}
									while (true)
									{
										switch (num6)
										{
										default:
											kP79T2Z9lGK1c1haqCo(Logger.Log, XGqPdBtVvuc7MujvoVy(0x816BBA1 ^ 0x816875B), ex);
											num6 = 0;
											if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_762cf717254743a4a1d5f3fcfeb2849f == 0)
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
								goto case 3;
							case 1:
								flag2 = true;
								num4 = 8;
								continue;
							default:
								text = guid.ToString((string)XGqPdBtVvuc7MujvoVy(0x327794E4 ^ 0x3277A85C));
								num4 = 4;
								continue;
							case 9:
								flag = true;
								num4 = 2;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_e28a31dd97e1464f96b9d0b056879391 == 0)
								{
									num4 = 2;
								}
								continue;
							case 6:
								break;
							}
							break;
						}
					}
					finally
					{
						int num8;
						if (!flag)
						{
							num8 = 2;
							goto IL_0e58;
						}
						goto IL_0f0d;
						IL_0e58:
						while (true)
						{
							switch (num8)
							{
							case 3:
							case 7:
								if (!flag3)
								{
									num8 = 3;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_3af97e9a57d2492f8793e39a552f0f48 != 0)
									{
										num8 = 6;
									}
									continue;
								}
								goto case 5;
							case 2:
							case 8:
								if (!flag2)
								{
									num8 = 7;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_4d5fabaf870f450c93de24e9225e7993 == 0)
									{
										num8 = 6;
									}
									continue;
								}
								goto default;
							default:
								Kc38fiZj0re2hY6lO5Z(this, XGqPdBtVvuc7MujvoVy(0x510BFFD ^ 0x510825B));
								num8 = 3;
								continue;
							case 4:
								break;
							case 5:
								Kc38fiZj0re2hY6lO5Z(this, XGqPdBtVvuc7MujvoVy(0x202D46BC ^ 0x202D7B74));
								num8 = 1;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_4599535ffcb34731ae493be59317478a == 0)
								{
									num8 = 1;
								}
								continue;
							case 6:
								goto end_IL_0e58;
							case 1:
								goto end_IL_0e58;
							}
							goto IL_0f0d;
							continue;
							end_IL_0e58:
							break;
						}
						goto end_IL_0e43;
						IL_0f0d:
						LVNq3BZA31m7mBikiec(this, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2078768493 ^ -2078755365), false);
						num8 = 8;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_4d065835d8a940d6b1a650963bebccc9 == 0)
						{
							num8 = 5;
						}
						goto IL_0e58;
						end_IL_0e43:;
					}
					goto case 11;
				case 10:
					text2 = (string)MKCnfitShvd4jGmR7IN(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-261945208 ^ -261933702), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x36554C4C ^ 0x36557C7E), sqlConnection.DataSource);
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_0d93129ec5af4fc5926990956e624437 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					num7 = 0;
					num2 = 9;
					break;
				case 11:
					if (num7 != 0)
					{
						goto end_IL_0012;
					}
					goto case 10;
				case 5:
					return;
				case 12:
					sqlConnection2 = (sqlConnection = (SqlConnection)base.ConnectionCreateFunc());
					num2 = 13;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 8;
		}
	}

	public override void InitTableGenerators()
	{
		//Discarded unreachable code: IL_01c6, IL_01d5, IL_01e5, IL_0241, IL_0250, IL_025b, IL_037c, IL_03bc, IL_03cb, IL_03d7, IL_03e6
		int num = 1;
		int num2 = num;
		bool flag = default(bool);
		Table table2 = default(Table);
		IDataReader dataReader = default(IDataReader);
		string sql = default(string);
		double num4 = default(double);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 13:
				return;
			case 8:
			case 10:
				if (flag)
				{
					num2 = 1;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_c4f350cb93ad41c2a93de4e094bd3eae == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 7;
			case 14:
				G_GenId();
				num2 = 5;
				break;
			case 15:
				AddTable(table2);
				num2 = 4;
				break;
			case 4:
				UpdateDbMetadataTable();
				num2 = 12;
				break;
			case 1:
				flag = H0JvYRZxPuqkhaVoQSH(this, XGqPdBtVvuc7MujvoVy(-1104925895 ^ -1104925929));
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_dda363349c784d1da4ad7d915f94c5c7 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				dataReader = ExecuteQuery(sql);
				num2 = 3;
				break;
			case 9:
				if (!flag)
				{
					Table table = new Table();
					p2GLguZQGUpZh31fbt2(table, false);
					J01KwNZNRNrF1jMix9j(table, XGqPdBtVvuc7MujvoVy(0x58D4045 ^ 0x58D406B));
					table.Columns = new List<Column>
					{
						new Column(GeneratorColumns[0], DbType.String, 255, ColumnProperty.PrimaryKey),
						new Column(GeneratorColumns[1], DbType.Int64)
					};
					table2 = table;
					num2 = 13;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_c07718730a1849a8a092e51c2522f212 != 0)
					{
						num2 = 15;
					}
				}
				else
				{
					num2 = 13;
				}
				break;
			case 7:
			case 12:
				G_GenId_Real();
				num2 = 14;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_faa672bf6a2f49a78a1354d82d84ea0c != 0)
				{
					num2 = 12;
				}
				break;
			case 11:
				LVNq3BZA31m7mBikiec(this, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1918094472 ^ -1918094506), false);
				num2 = 7;
				break;
			case 2:
				sql = (string)y9oZtWt1lCoeAtg9rgu(XGqPdBtVvuc7MujvoVy(0x6E68FD33 ^ 0x6E68BCD5), XGqPdBtVvuc7MujvoVy(-1934387638 ^ -1934387612), GeneratorColumns[0], GeneratorColumns[1]);
				num2 = 6;
				break;
			case 5:
				return;
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!Dil0GSZJRf2KerNoQmn(dataReader))
						{
							num3 = 2;
							goto IL_025f;
						}
						goto IL_0318;
						IL_025f:
						while (true)
						{
							switch (num3)
							{
							case 1:
								num4 = KUKV2GZC1ojvHb5Kdwk((double)igKjakZ6kwCOTA4AOZa(dataReader[1]) / 100.0);
								num3 = 0;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a20e3edfdf494639a8a8084ef15a8911 != 0)
								{
									num3 = 0;
								}
								continue;
							case 3:
								break;
							default:
								ExecuteNonQuery((string)MKCnfitShvd4jGmR7IN(XGqPdBtVvuc7MujvoVy(0x341D5AB0 ^ 0x341D1892), text, num4), new Dictionary<string, object> { 
								{
									(string)XGqPdBtVvuc7MujvoVy(-1227940259 ^ -1227924005),
									text
								} });
								num3 = 3;
								continue;
							case 4:
								goto IL_0318;
							case 2:
								goto end_IL_02b6;
							}
							break;
						}
						continue;
						IL_0318:
						text = (string)w95JdNZkMmkYJfivZM7(XGqPdBtVvuc7MujvoVy(-2027299446 ^ -2027315312), Convert.ToString(LS1Qi7ZL6xLJyGeo3kN(dataReader, 0)));
						num3 = 1;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_6e2d684142f942fa9bd2bf6977aa1751 != 0)
						{
							num3 = 1;
						}
						goto IL_025f;
						continue;
						end_IL_02b6:
						break;
					}
				}
				finally
				{
					int num5;
					if (dataReader == null)
					{
						num5 = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_e28a31dd97e1464f96b9d0b056879391 == 0)
						{
							num5 = 1;
						}
						goto IL_0380;
					}
					goto IL_0396;
					IL_0396:
					b7Z9UsZMPYIQOaNIN6H(dataReader);
					num5 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_1ac7b80080314bbdb29619485c5fbb66 == 0)
					{
						num5 = 0;
					}
					goto IL_0380;
					IL_0380:
					switch (num5)
					{
					default:
						goto end_IL_035b;
					case 2:
						break;
					case 1:
						goto end_IL_035b;
					case 0:
						goto end_IL_035b;
					}
					goto IL_0396;
					end_IL_035b:;
				}
				goto case 11;
			default:
				if (IsSequenceSupport)
				{
					num2 = 8;
					break;
				}
				goto case 9;
			}
		}
	}

	private bool ProcedureExists(string procedureName)
	{
		return Convert.ToInt32(ExecuteScalar((string)XGqPdBtVvuc7MujvoVy(--471720024 ^ 0x1C1DA3FA), new Dictionary<string, object> { 
		{
			(string)XGqPdBtVvuc7MujvoVy(-862174492 ^ -862190004),
			FDe1tfZogo2FQrBAErI(procedureName)
		} })) > 0;
	}

	internal void G_GenId_Real()
	{
		int num = 1;
		int num2 = num;
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
				flag = !ProcedureExists(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6080D1CC ^ 0x6080D1DE));
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_3f5427a24f2948678f15f0286379c485 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				ExecuteNonQuery((string)w95JdNZkMmkYJfivZM7(flag ? SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-798966336 ^ -798951158) : XGqPdBtVvuc7MujvoVy(0x4960B0BA ^ 0x4960F406), string.Format((string)XGqPdBtVvuc7MujvoVy(0x202D46BC ^ 0x202D0266), 100)));
				num2 = 4;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_b13d731cb79641de887177267153d656 == 0)
				{
					num2 = 2;
				}
				continue;
			case 4:
				return;
			}
			if (IsSequenceSupport)
			{
				num2 = 2;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_443e20b770184f91ab3dcde8e39895cc == 0)
				{
					num2 = 2;
				}
			}
			else
			{
				ExecuteNonQuery((string)w95JdNZkMmkYJfivZM7(flag ? XGqPdBtVvuc7MujvoVy(-536897350 ^ -536880016) : SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1918094472 ^ -1918076988), XGqPdBtVvuc7MujvoVy(-1104925895 ^ -1104905445)));
				num2 = 3;
			}
		}
	}

	private void G_GenId()
	{
		int num = 3;
		int num2 = num;
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (IsSequenceSupport)
				{
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_611f69e7a7a34a4fbeb0099afc53aecd != 0)
					{
						num2 = 0;
					}
					break;
				}
				ExecuteNonQuery((string)w95JdNZkMmkYJfivZM7(flag ? XGqPdBtVvuc7MujvoVy(-1296333093 ^ -1296317935) : XGqPdBtVvuc7MujvoVy(0x2CDCAD98 ^ 0x2CDCE924), XGqPdBtVvuc7MujvoVy(0x43EF8209 ^ 0x43EFDE25)));
				num2 = 3;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bdc18f4c9e6b474ea4d1521d9166d946 == 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				flag = !ProcedureExists((string)XGqPdBtVvuc7MujvoVy(0x565F4BCE ^ 0x565F4BCE));
				num2 = 2;
				break;
			case 4:
				return;
			default:
				ExecuteNonQuery((string)w95JdNZkMmkYJfivZM7(flag ? XGqPdBtVvuc7MujvoVy(0x553E4A6A ^ 0x553E0EA0) : XGqPdBtVvuc7MujvoVy(0x5D699727 ^ 0x5D69D39B), XGqPdBtVvuc7MujvoVy(0x4F69E90A ^ 0x4F69B340)));
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_b191e4df737c4fbb97b7fbe68dd7816d != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	private void UpdateDbMetadataTable()
	{
		int num = 5;
		PrimaryKey primaryKey = default(PrimaryKey);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 4:
					return;
				case 1:
					sW5kcQZTrxglTGYd2t9(this, XGqPdBtVvuc7MujvoVy(-1661472630 ^ -1661496674), primaryKey.Name);
					num2 = 9;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_6e4085613a434991b7308d69af884312 == 0)
					{
						num2 = 5;
					}
					break;
				case 5:
					if (H0JvYRZxPuqkhaVoQSH(this, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x720B60EA ^ 0x720B02FE)))
					{
						primaryKey = (PrimaryKey)UFXaNNZdCR7pEblUwYy(this, XGqPdBtVvuc7MujvoVy(0x3897EFFA ^ 0x38978DEE));
						num2 = 1;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bf52420e3f0049cf9dbec307e6d391c7 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto end_IL_0012;
				case 6:
					shK5MoZgjuL7wo37VOW(this, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1227940259 ^ -1227916215), XGqPdBtVvuc7MujvoVy(0x1FD7E9B3 ^ 0x1FD78B89), XGqPdBtVvuc7MujvoVy(0x5766B69D ^ 0x576699F1));
					num2 = 7;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ac8b4db689fb4d85a7bb7ce35db5e4d5 != 0)
					{
						num2 = 4;
					}
					break;
				case 7:
					Cy4ErKZVMSvFn9fp2PQ(this, dIq5dvZR73l7yoYXZIA(primaryKey), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8F848CE ^ 0x8F82ADA), new string[1] { SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2027299446 ^ -2027293978) });
					num2 = 8;
					break;
				case 9:
					RemoveColumn((string)XGqPdBtVvuc7MujvoVy(0x483FFC8B ^ 0x483F9E9F), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1934387638 ^ -1934378714));
					num2 = 6;
					break;
				case 3:
					Update((string)XGqPdBtVvuc7MujvoVy(0x6E68FD33 ^ 0x6E689F27), new string[1] { (string)XGqPdBtVvuc7MujvoVy(-2008939226 ^ -2008914148) }, new object[1]
					{
						new SqlExpressionParameter((string)NJvbMEtWcZWYUnSGhUH(AOInkota5rqbJBHlvcS(this), XGqPdBtVvuc7MujvoVy(0x5E19FB22 ^ 0x5E19D44E)))
					}, null);
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bb8b65c62a044e0a9142fed3b497ae35 == 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					fksNNvZw1qP34T2qK5Y(this, XGqPdBtVvuc7MujvoVy(0x4F69E90A ^ 0x4F698B1E), new Column(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C6497C8 ^ 0x6C64F5F2), DbType.Int64, ColumnProperty.NotNull, 0L));
					num2 = 3;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ac8b4db689fb4d85a7bb7ce35db5e4d5 != 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				case 8:
					aI2nBOt745gCH9CqytV(this, XGqPdBtVvuc7MujvoVy(0x4152E1C2 ^ 0x415283D6));
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_e28a31dd97e1464f96b9d0b056879391 == 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public override void BackupTables(string[] tableNames, string[] newTableNames)
	{
		//Discarded unreachable code: IL_00a0, IL_00af
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass56_0 _003C_003Ec__DisplayClass56_ = default(_003C_003Ec__DisplayClass56_0);
		int num3 = default(int);
		string text = default(string);
		string text2 = default(string);
		while (true)
		{
			switch (num2)
			{
			case 8:
				dBFrpgZUBJ7M0dN7wPt(this, 0, new Action(_003C_003Ec__DisplayClass56_._003CBackupTables_003Eb__0));
				num2 = 2;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_8cc4e99f5f9a4922bb7991de4d990c7f == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				num3++;
				num2 = 9;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a88af087375c48b1b8354e3e8d657ff7 == 0)
				{
					num2 = 1;
				}
				break;
			case 11:
				return;
			default:
				text = tableNames[num3];
				num2 = 5;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_88b018be80f64052a4b6364462094eef == 0)
				{
					num2 = 7;
				}
				break;
			case 6:
				_003C_003Ec__DisplayClass56_._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ac8b4db689fb4d85a7bb7ce35db5e4d5 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				num3 = 0;
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_adcdf8abe8194ee7810e832bda7e08e7 != 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				text2 = newTableNames[num3];
				num2 = 4;
				break;
			case 4:
				_003C_003Ec__DisplayClass56_.sql = (string)MKCnfitShvd4jGmR7IN(XGqPdBtVvuc7MujvoVy(--500400671 ^ 0x1DD3E055), NJvbMEtWcZWYUnSGhUH(AOInkota5rqbJBHlvcS(this), text2), NJvbMEtWcZWYUnSGhUH(Dialect, text));
				num2 = 8;
				break;
			case 1:
			case 9:
				if (num3 >= tableNames.Length)
				{
					return;
				}
				num2 = 10;
				break;
			case 5:
			case 10:
				_003C_003Ec__DisplayClass56_ = new _003C_003Ec__DisplayClass56_0();
				num2 = 6;
				break;
			}
		}
	}

	public override bool TableExists(string table)
	{
		int num = 1;
		int num2 = num;
		string sql = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				sql = (string)uMFAPatpGiPJkACEaAw(XGqPdBtVvuc7MujvoVy(0x6FC42799 ^ 0x6FC44509), table.ToUpper());
				num2 = 2;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_b191e4df737c4fbb97b7fbe68dd7816d == 0)
				{
					num2 = 2;
				}
				break;
			default:
				R0204ZZGrEUp05GcmFO(table, XGqPdBtVvuc7MujvoVy(-169056146 ^ -169080084));
				num2 = 3;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_9f50fa62c83545aa885cad260f298366 != 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				return NvaINVtcbUxYxG0HGaj(ExecuteScalar(sql)) > 0;
			case 1:
				vM2RiHtUqW6g9Gee6Yc(table, XGqPdBtVvuc7MujvoVy(0x341D5AB0 ^ 0x341D3832));
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ac8b4db689fb4d85a7bb7ce35db5e4d5 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void RenameTable(string oldTableName, string newTableName)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				OYEleSZFqLHXIWBAmqE(this, oldTableName, newTableName);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_25f0dcdb5c5e4e6fbd7fee91aad234f3 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				ExecuteNonQuery((string)MKCnfitShvd4jGmR7IN(XGqPdBtVvuc7MujvoVy(-250283594 ^ -250307944), oldTableName, newTableName));
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_4599535ffcb34731ae493be59317478a != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override void RenameSequence(string oldTableName, string newTableName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				JkADZ6ZiMZoWIxcqSDg(this, oldTableName);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_6e4085613a434991b7308d69af884312 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				aI2nBOt745gCH9CqytV(this, newTableName);
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a66ccd03acd144368047b44c2d5d0065 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public override int GetTableColumnsSize(string table)
	{
		//Discarded unreachable code: IL_00d3, IL_0138, IL_0157, IL_0166, IL_0183
		int num = 1;
		int num2 = num;
		int result = default(int);
		string sql = default(string);
		IDataReader dataReader = default(IDataReader);
		while (true)
		{
			switch (num2)
			{
			case 1:
				result = 0;
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_6e2d684142f942fa9bd2bf6977aa1751 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				sql = (string)XGqPdBtVvuc7MujvoVy(0xEA75DDC ^ 0xEA73EB4);
				num2 = 2;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_fd530154b89d4815aee35b4d6e45073c == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				dataReader = ExecuteQuery(sql, new Dictionary<string, object> { 
				{
					(string)XGqPdBtVvuc7MujvoVy(-1526402459 ^ -1526400793),
					table
				} });
				num2 = 3;
				break;
			case 4:
				return result;
			case 3:
				try
				{
					if (!Dil0GSZJRf2KerNoQmn(dataReader))
					{
						return result;
					}
					int num3 = 1;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_1ac7b80080314bbdb29619485c5fbb66 != 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							return result;
						case 0:
							return result;
						case 1:
							result = Convert.ToInt32(dataReader[0]);
							num3 = 0;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_80b6e3007a3e4355a8078b16fb1979e5 != 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}
				finally
				{
					int num4;
					if (dataReader == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_d2ea3571782f460a8fcf4212c4b89aef != 0)
						{
							num4 = 1;
						}
						goto IL_013c;
					}
					goto IL_0171;
					IL_0171:
					dataReader.Dispose();
					num4 = 2;
					goto IL_013c;
					IL_013c:
					switch (num4)
					{
					case 1:
						goto end_IL_0117;
					case 2:
						goto end_IL_0117;
					}
					goto IL_0171;
					end_IL_0117:;
				}
			}
		}
	}

	public override List<string> GetTables()
	{
		List<string> list = new List<string>();
		using IDataReader dataReader = ExecuteQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4F69E90A ^ 0x4F698D54));
		while (dataReader.Read())
		{
			list.Add(((string)dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x202D46BC ^ 0x202D23A2)]).Trim());
		}
		return list;
	}

	public override void AddTableSequence(string tableName)
	{
		//Discarded unreachable code: IL_00da, IL_0105, IL_0114, IL_013c, IL_01db
		int num = 9;
		string value2 = default(string);
		string sql = default(string);
		string text = default(string);
		PrimaryKey primaryKeyByTable = default(PrimaryKey);
		object obj = default(object);
		long value = default(long);
		long num5 = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				long num3;
				long num4;
				switch (num2)
				{
				case 12:
					value2 = Convert.ToString(ExecuteScalar(sql, new Dictionary<string, object>
					{
						{
							(string)XGqPdBtVvuc7MujvoVy(-1058192528 ^ -1058200258),
							tableName
						},
						{
							SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-786261895 ^ -786235875),
							text
						}
					}));
					num2 = 17;
					continue;
				case 11:
					if (primaryKeyByTable.Columns == null)
					{
						return;
					}
					goto end_IL_0012;
				case 15:
					return;
				case 5:
					if (EyysZFZ4cRsIM1IrJ4B(primaryKeyByTable.Columns) != 1)
					{
						num2 = 3;
						continue;
					}
					sql = (string)XGqPdBtVvuc7MujvoVy(0x43EF8209 ^ 0x43EFE723);
					num2 = 6;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_2ab8f47a08004d748d8cbfeb51d65089 != 0)
					{
						num2 = 6;
					}
					continue;
				case 2:
					num3 = (long)Math.Ceiling((double)igKjakZ6kwCOTA4AOZa(obj) / 100.0);
					break;
				case 8:
					primaryKeyByTable = GetPrimaryKeyByTable(tableName);
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_273c06d8704c4280a5fc2b25c62f33f4 == 0)
					{
						num2 = 0;
					}
					continue;
				case 18:
					return;
				case 4:
					obj = ExecuteScalar((string)MKCnfitShvd4jGmR7IN(XGqPdBtVvuc7MujvoVy(0x341D5AB0 ^ 0x341D3C04), text, NJvbMEtWcZWYUnSGhUH(Dialect, tableName)));
					num2 = 7;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_4d5fabaf870f450c93de24e9225e7993 == 0)
					{
						num2 = 5;
					}
					continue;
				case 9:
					JkADZ6ZiMZoWIxcqSDg(this, tableName);
					num2 = 8;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a790b36cf25c47829dbedbeba78b0de0 != 0)
					{
						num2 = 4;
					}
					continue;
				case 16:
					num4 = Convert.ToInt64(obj) + 1;
					goto IL_0382;
				case 14:
					CheckSequenceExists(tableName, value);
					num2 = 13;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ca63e6162aaa4aaeaa1385bd9f3ad6e0 != 0)
					{
						num2 = 15;
					}
					continue;
				case 3:
					return;
				case 7:
					if (IsSequenceSupport)
					{
						num2 = 7;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_536a197f18c04d92abf9ab236ddc733a != 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 10;
				case 19:
					Insert((string)XGqPdBtVvuc7MujvoVy(-862174492 ^ -862174518), GeneratorColumns, new object[2] { tableName, num5 });
					num2 = 1;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_b14550e4462b4c7190663aa2ba86338f == 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					text = primaryKeyByTable.Columns.First();
					num2 = 12;
					continue;
				default:
					if (primaryKeyByTable == null)
					{
						return;
					}
					num2 = 11;
					continue;
				case 17:
					if (!new string[4]
					{
						SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--471720024 ^ 0x1C1D862C),
						SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-19828073 ^ -19852271),
						(string)XGqPdBtVvuc7MujvoVy(-964056903 ^ -964047325),
						(string)XGqPdBtVvuc7MujvoVy(-1934387638 ^ -1934364434)
					}.Contains(value2))
					{
						return;
					}
					num2 = 4;
					continue;
				case 10:
					if (!(obj is DBNull))
					{
						num2 = 16;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a9455caf5a604783b3a743f491182420 == 0)
						{
							num2 = 11;
						}
						continue;
					}
					num4 = 1L;
					goto IL_0382;
				case 1:
					return;
				case 13:
					{
						if (!(obj is DBNull))
						{
							num2 = 2;
							continue;
						}
						num3 = 0L;
						break;
					}
					IL_0382:
					num5 = num4;
					num2 = 19;
					continue;
				}
				value = num3;
				num2 = 14;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_3f5427a24f2948678f15f0286379c485 != 0)
				{
					num2 = 5;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	internal void CheckSequenceExists(string tableName, long value = 0L)
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
				ExecuteNonQuery((string)MKCnfitShvd4jGmR7IN(XGqPdBtVvuc7MujvoVy(0x55622768 ^ 0x55624180), tableName, value));
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a1374360d15f4247b418e6f0fa5eef4e == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void RemoveTable(string tableName, bool removeSequence)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				JkADZ6ZiMZoWIxcqSDg(this, tableName);
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_914e5983c8d84fee9bd54eba99b82441 == 0)
				{
					num2 = 3;
				}
				continue;
			case 1:
				etBtlCZeJJDfw9Rwe80(this, tableName, removeSequence);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_4f783759df564a788bd78dfdef3c9c5f == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return;
			}
			if (removeSequence)
			{
				num2 = 2;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_7937bb5aeb374034837b9426eced6cfc != 0)
				{
					num2 = 1;
				}
				continue;
			}
			return;
		}
	}

	public override void RemoveTableSequence(string tableName)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				if (!IsSequenceSupport)
				{
					num2 = 1;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_762cf717254743a4a1d5f3fcfeb2849f != 0)
					{
						num2 = 0;
					}
					break;
				}
				ExecuteNonQuery((string)uMFAPatpGiPJkACEaAw(XGqPdBtVvuc7MujvoVy(-860755570 ^ -860782176), tableName));
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_4d065835d8a940d6b1a650963bebccc9 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				ExecuteNonQuery((string)y9oZtWt1lCoeAtg9rgu(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x44957A45 ^ 0x44951DAD), vlyCcXZh4I1u4WIg3aY(this, XGqPdBtVvuc7MujvoVy(-169056146 ^ -169056192)), vlyCcXZh4I1u4WIg3aY(this, GeneratorColumns[0]), tableName));
				num2 = 3;
				break;
			case 3:
				return;
			}
		}
	}

	public override bool ColumnExists(string table, string column)
	{
		int num = 3;
		int num2 = num;
		string sql = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				vM2RiHtUqW6g9Gee6Yc(column, XGqPdBtVvuc7MujvoVy(0x5A09CFB9 ^ 0x5A09A76B));
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_9b1d47db702148b5af71c10bd42d90c2 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return NvaINVtcbUxYxG0HGaj(ExecuteScalar(sql)) > 0;
			case 4:
				sql = (string)MKCnfitShvd4jGmR7IN(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5E19FB22 ^ 0x5E1993C0), FDe1tfZogo2FQrBAErI(table), FDe1tfZogo2FQrBAErI(column));
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a9455caf5a604783b3a743f491182420 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				vM2RiHtUqW6g9Gee6Yc(table, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x202D46BC ^ 0x202D243E));
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_c4f350cb93ad41c2a93de4e094bd3eae == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				Contract.ArgumentNotNullOrEmpty(table, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1646885874 ^ -1646860660));
				num2 = 5;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_b13d731cb79641de887177267153d656 == 0)
				{
					num2 = 3;
				}
				break;
			case 5:
				R0204ZZGrEUp05GcmFO(column, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-738220528 ^ -738210110));
				num2 = 4;
				break;
			}
		}
	}

	protected override void AddColumn(string table, string sqlColumn, string columnName)
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
				ExecuteNonQuery((string)MKCnfitShvd4jGmR7IN(XGqPdBtVvuc7MujvoVy(0x379281FC ^ 0x3792E838), QuoteIfNeeded(table), sqlColumn));
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_536a197f18c04d92abf9ab236ddc733a == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void RenameColumn(string table, string oldColumnName, string newColumnName)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				ExecuteNonQuery((string)y9oZtWt1lCoeAtg9rgu(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5E77F19D ^ 0x5E77986B), table, oldColumnName, newColumnName));
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_f2714faf8916422f9e6c3d85072d62cb == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				GlGQtkZHPLcKexxUWFL(this, table, oldColumnName);
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_c66a81b3385f4e6fa960aa83b221484b != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override void RemoveColumn(string table, string column)
	{
		//Discarded unreachable code: IL_01e3, IL_01ed, IL_02c6, IL_02d9, IL_02e8, IL_031c, IL_0326, IL_03b5, IL_03f5, IL_0404, IL_0410, IL_041f, IL_0457
		int num = 8;
		int num2 = num;
		IDataReader dataReader = default(IDataReader);
		string sql = default(string);
		List<string> list = default(List<string>);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string current = default(string);
		while (true)
		{
			switch (num2)
			{
			case 8:
				Contract.ArgumentNotNull(table, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-370249262 ^ -370273456));
				num2 = 2;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_81833be823b44351b330d2171723abb3 == 0)
				{
					num2 = 7;
				}
				break;
			case 13:
				R0204ZZGrEUp05GcmFO(table, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1838952473 ^ 0x6D9C529B));
				num2 = 4;
				break;
			case 1:
				dataReader = ExecuteQuery(sql);
				num2 = 3;
				break;
			case 2:
			case 10:
				T10ssFZByP0jQQb0g06(this, table, column);
				num2 = 16;
				break;
			case 5:
				ExecuteNonQuery(sql);
				num2 = 2;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_4d5fabaf870f450c93de24e9225e7993 == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				R0204ZZGrEUp05GcmFO(column, XGqPdBtVvuc7MujvoVy(0x6647693 ^ 0x6641E41));
				num2 = 14;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_fd530154b89d4815aee35b4d6e45073c == 0)
				{
					num2 = 15;
				}
				break;
			case 6:
				list = new List<string>();
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ac8b4db689fb4d85a7bb7ce35db5e4d5 != 0)
				{
					num2 = 0;
				}
				break;
			case 14:
				sql = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x671942FC ^ 0x67192EA4), QuoteIfNeeded(table), vlyCcXZh4I1u4WIg3aY(this, column));
				num2 = 5;
				break;
			case 12:
				sql = (string)MKCnfitShvd4jGmR7IN(XGqPdBtVvuc7MujvoVy(0x720B60EA ^ 0x720B0AA6), table, column);
				num2 = 6;
				break;
			case 9:
				GlGQtkZHPLcKexxUWFL(this, table, column);
				num2 = 14;
				break;
			case 7:
				vM2RiHtUqW6g9Gee6Yc(column, XGqPdBtVvuc7MujvoVy(0x142041AF ^ 0x1420297D));
				num2 = 13;
				break;
			default:
				try
				{
					while (true)
					{
						IL_022e:
						int num5;
						if (!enumerator.MoveNext())
						{
							num5 = 1;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_2580d923b4ce4bd0b5bb01b45f02c594 == 0)
							{
								num5 = 0;
							}
							goto IL_01f1;
						}
						goto IL_020b;
						IL_020b:
						current = enumerator.Current;
						num5 = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_7937bb5aeb374034837b9426eced6cfc != 0)
						{
							num5 = 0;
						}
						goto IL_01f1;
						IL_01f1:
						while (true)
						{
							switch (num5)
							{
							case 2:
								break;
							case 3:
								goto IL_022e;
							default:
								ExecuteNonQuery(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2381262 ^ 0x2387E6C), vlyCcXZh4I1u4WIg3aY(this, table), vlyCcXZh4I1u4WIg3aY(this, current)));
								num5 = 1;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_adccb0765c0e42dbaf186220f45b757c == 0)
								{
									num5 = 3;
								}
								continue;
							case 1:
								goto end_IL_022e;
							}
							break;
						}
						goto IL_020b;
						continue;
						end_IL_022e:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num6 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_74c50b4541604f879acc41487ba8662e != 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
				goto case 9;
			case 11:
				enumerator = list.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_846eae8b3f494ae2b3aeba9a1f80b104 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!Dil0GSZJRf2KerNoQmn(dataReader))
						{
							num3 = 0;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_5bd098bed6154f4ea8b455a24c427093 != 0)
							{
								num3 = 1;
							}
							goto IL_032a;
						}
						goto IL_0340;
						IL_0340:
						list.Add((string)rIDCcMZcDDCySleMUIi(dataReader, 0));
						num3 = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_d2ea3571782f460a8fcf4212c4b89aef != 0)
						{
							num3 = 0;
						}
						goto IL_032a;
						IL_032a:
						switch (num3)
						{
						case 2:
							break;
						default:
							continue;
						case 1:
							goto end_IL_0369;
						}
						goto IL_0340;
						continue;
						end_IL_0369:
						break;
					}
				}
				finally
				{
					int num4;
					if (dataReader == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_0e8b96b511f849c7b3cd2b1ffcea4179 == 0)
						{
							num4 = 1;
						}
						goto IL_03b9;
					}
					goto IL_03cf;
					IL_03cf:
					dataReader.Dispose();
					num4 = 2;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bdc18f4c9e6b474ea4d1521d9166d946 != 0)
					{
						num4 = 1;
					}
					goto IL_03b9;
					IL_03b9:
					switch (num4)
					{
					case 1:
						goto end_IL_0394;
					case 2:
						goto end_IL_0394;
					}
					goto IL_03cf;
					end_IL_0394:;
				}
				goto case 11;
			case 15:
				if (!LIjy5sZsaQKWgcV6Oq8(this, table, column))
				{
					num2 = 10;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_74c50b4541604f879acc41487ba8662e == 0)
					{
						num2 = 10;
					}
					break;
				}
				goto case 12;
			case 16:
				return;
			}
		}
	}

	public override void RemoveColumnConstraints(string table, string column)
	{
		//Discarded unreachable code: IL_004e, IL_005d, IL_0068, IL_011e, IL_0131, IL_0161, IL_016b, IL_0213, IL_024b, IL_025a
		int num = 5;
		int num2 = num;
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string current = default(string);
		IDataReader dataReader = default(IDataReader);
		List<string> list = default(List<string>);
		string sql = default(string);
		while (true)
		{
			switch (num2)
			{
			case 6:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_536a197f18c04d92abf9ab236ddc733a != 0)
							{
								num3 = 2;
							}
							goto IL_006c;
						}
						goto IL_00ac;
						IL_00ac:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_762cf717254743a4a1d5f3fcfeb2849f == 0)
						{
							num3 = 1;
						}
						goto IL_006c;
						IL_006c:
						while (true)
						{
							switch (num3)
							{
							case 3:
								break;
							default:
								goto IL_00ac;
							case 1:
								uIne73ZpaGSIPYl0XPF(this, table, current);
								num3 = 2;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_443e20b770184f91ab3dcde8e39895cc != 0)
								{
									num3 = 3;
								}
								continue;
							case 2:
								return;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a20e3edfdf494639a8a8084ef15a8911 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 5:
				vM2RiHtUqW6g9Gee6Yc(table, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1227940259 ^ -1227916065));
				num2 = 4;
				break;
			case 7:
				try
				{
					while (true)
					{
						int num5;
						if (!Dil0GSZJRf2KerNoQmn(dataReader))
						{
							num5 = 1;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_4b85c84f12944d10ab6668398e7fff15 == 0)
							{
								num5 = 1;
							}
							goto IL_016f;
						}
						goto IL_01ab;
						IL_01ab:
						list.Add((string)iPPsXyt5saR0K4YXBZj((string)dataReader[(string)XGqPdBtVvuc7MujvoVy(-1704098005 ^ -1704074699)]));
						num5 = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a88ccd6fbe9d4d31ba568282bf848b44 == 0)
						{
							num5 = 0;
						}
						goto IL_016f;
						IL_016f:
						switch (num5)
						{
						case 2:
							goto IL_01ab;
						case 1:
							goto end_IL_0185;
						}
						continue;
						end_IL_0185:
						break;
					}
				}
				finally
				{
					if (dataReader != null)
					{
						int num6 = 1;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_65ce79c871be4e148c284823cf722edd == 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								dataReader.Dispose();
								num6 = 0;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_3af97e9a57d2492f8793e39a552f0f48 == 0)
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
				goto case 1;
			case 1:
				enumerator = list.GetEnumerator();
				num2 = 2;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_1ac7b80080314bbdb29619485c5fbb66 != 0)
				{
					num2 = 6;
				}
				break;
			default:
				dataReader = ExecuteQuery(sql);
				num2 = 3;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bdc18f4c9e6b474ea4d1521d9166d946 == 0)
				{
					num2 = 7;
				}
				break;
			case 10:
				list = new List<string>();
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a790b36cf25c47829dbedbeba78b0de0 == 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				R0204ZZGrEUp05GcmFO(table, XGqPdBtVvuc7MujvoVy(-1179530319 ^ -1179539149));
				num2 = 8;
				break;
			case 4:
				Contract.ArgumentNotNull(column, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1992046500 ^ -1992056690));
				num2 = 9;
				break;
			case 8:
				Contract.ArgumentNotNullOrEmpty(column, (string)XGqPdBtVvuc7MujvoVy(0x25153744 ^ 0x25155F96));
				num2 = 3;
				break;
			case 3:
				sql = FindConstraints(table, column, new List<ConstraintType> { ConstraintType.F });
				num2 = 3;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_846eae8b3f494ae2b3aeba9a1f80b104 != 0)
				{
					num2 = 10;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public override bool ConstraintExists(string table, string name)
	{
		//Discarded unreachable code: IL_00f8, IL_014f, IL_015e, IL_017f
		int num = 2;
		int num2 = num;
		IDataReader dataReader = default(IDataReader);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				R0204ZZGrEUp05GcmFO(name, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E17A152 ^ 0x7E17C44C));
				num2 = 3;
				continue;
			case 2:
				vM2RiHtUqW6g9Gee6Yc(name, XGqPdBtVvuc7MujvoVy(-318240169 ^ -318214327));
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ca63e6162aaa4aaeaa1385bd9f3ad6e0 != 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
				dataReader = ExecuteQuery((string)XGqPdBtVvuc7MujvoVy(0x15436EBF ^ 0x15430223), new Dictionary<string, object> { 
				{
					(string)XGqPdBtVvuc7MujvoVy(0x202D46BC ^ 0x202D2B8C),
					FDe1tfZogo2FQrBAErI(name)
				} });
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_65ce79c871be4e148c284823cf722edd != 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				return result;
			}
			try
			{
				result = Dil0GSZJRf2KerNoQmn(dataReader);
				int num3 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_b98765ef3c444c499e843eecd7ad6cc5 == 0)
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
				if (dataReader == null)
				{
					num4 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_6c4bacaf03bd45578009f4720a268b0d != 0)
					{
						num4 = 1;
					}
					goto IL_0134;
				}
				goto IL_0169;
				IL_0169:
				dataReader.Dispose();
				int num5 = 2;
				num4 = num5;
				goto IL_0134;
				IL_0134:
				switch (num4)
				{
				case 1:
					goto end_IL_010f;
				case 2:
					goto end_IL_010f;
				}
				goto IL_0169;
				end_IL_010f:;
			}
		}
	}

	public override IDictionary<string, PrimaryKey> GetAllPrimaryKeys()
	{
		Dictionary<string, PrimaryKey> dictionary = new Dictionary<string, PrimaryKey>();
		using IDataReader dataReader = ExecuteQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x341D5AB0 ^ 0x341D378C));
		while (dataReader.Read())
		{
			string text = ((string)dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6647693 ^ 0x6641935)]).Trim();
			if (!dictionary.TryGetValue(text, out var value))
			{
				value = new PrimaryKey
				{
					TableName = text,
					Name = ((string)dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-798966336 ^ -798961026)]).Trim(),
					Columns = new List<string>()
				};
				dictionary.Add(text, value);
			}
			value.Columns.Add(((string)dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x341D5AB0 ^ 0x341D3550)]).Trim());
		}
		return dictionary;
	}

	public override PrimaryKey GetPrimaryKeyByTable(string table)
	{
		//Discarded unreachable code: IL_0082, IL_011c, IL_012b, IL_015c, IL_018c, IL_019b, IL_01a7, IL_01b6
		int num = 1;
		int num2 = num;
		IDataReader dataReader = default(IDataReader);
		PrimaryKey result = default(PrimaryKey);
		while (true)
		{
			switch (num2)
			{
			case 1:
				dataReader = ExecuteQuery(SqlGetPrimaryKeyByTable, new Dictionary<string, object> { 
				{
					(string)XGqPdBtVvuc7MujvoVy(-2078768493 ^ -2078767087),
					table
				} });
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_50026842ab044d008d304fc8fda891b4 == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				try
				{
					if (!Dil0GSZJRf2KerNoQmn(dataReader))
					{
						break;
					}
					int num3 = 2;
					while (true)
					{
						switch (num3)
						{
						case 2:
						{
							PrimaryKey primaryKey = new PrimaryKey();
							OyrOBhZXcWtG5v2SDqi(primaryKey, table);
							primaryKey.Name = (string)iPPsXyt5saR0K4YXBZj((string)pcx1m4Z5Vkp41oOsxdc(dataReader, XGqPdBtVvuc7MujvoVy(-1661472630 ^ -1661493452)));
							primaryKey.Columns.Add(((string)pcx1m4Z5Vkp41oOsxdc(dataReader, XGqPdBtVvuc7MujvoVy(-1296333093 ^ -1296307909))).Trim());
							result = primaryKey;
							num3 = 0;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_74c50b4541604f879acc41487ba8662e == 0)
							{
								num3 = 0;
							}
							continue;
						}
						case 1:
							break;
						default:
							return result;
						case 0:
							return result;
						}
						break;
					}
				}
				finally
				{
					int num4;
					if (dataReader == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_f2714faf8916422f9e6c3d85072d62cb == 0)
						{
							num4 = 0;
						}
						goto IL_0160;
					}
					goto IL_0176;
					IL_0176:
					b7Z9UsZMPYIQOaNIN6H(dataReader);
					num4 = 2;
					goto IL_0160;
					IL_0160:
					switch (num4)
					{
					default:
						goto end_IL_013b;
					case 1:
						break;
					case 0:
						goto end_IL_013b;
					case 2:
						goto end_IL_013b;
					}
					goto IL_0176;
					end_IL_013b:;
				}
				break;
			case 2:
				break;
			}
			break;
		}
		return null;
	}

	public override void AddForeignKey(ForeignKey foreignKey)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				return;
			case 0:
				return;
			case 1:
			{
				Index index = new Index();
				VGGm0lZm2FQNfAoKpFP(index, GetIndexNameByForeignKey((string)GakbjaZ0OIlEn0ZS5xN(foreignKey)));
				hagYYIZl1r49gBapwXx(index, OHEZULZqZkaanwssOGq(foreignKey));
				index.Columns = foreignKey.Columns.ToList();
				NQkKUkZvnkcBG1nvZsk(this, index);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a1374360d15f4247b418e6f0fa5eef4e == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 3:
				if (!YlGEGOZDuRXy27KydE3(this, OHEZULZqZkaanwssOGq(foreignKey), foreignKey.Name))
				{
					SQlrqWZfWRGNok0TGJB(this, foreignKey);
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_db0266f588ec4dba9939e9dffe57b346 == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public override void RemoveForeignKey(string tableName, string fkName)
	{
		int num = 2;
		int num2 = num;
		string indexName = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				RemoveIndex(tableName, indexName);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_4b85c84f12944d10ab6668398e7fff15 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				base.RemoveForeignKey(tableName, fkName);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_81833be823b44351b330d2171723abb3 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				indexName = (string)pYyTtUZbODfV0GnTIUw(this, fkName);
				num2 = 3;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_6e4085613a434991b7308d69af884312 != 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public override List<ForeignKey> GetForeignKeys(string tableName)
	{
		Contract.ArgumentNotNullOrEmpty(tableName, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x586FD9AE ^ 0x586FBFE0));
		List<ForeignKey> list = new List<ForeignKey>();
		using IDataReader dataReader = ExecuteQuery(SqlGetForeignKeys, new Dictionary<string, object> { 
		{
			SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1676901510 ^ -1676876492),
			tableName.ToUpper()
		} });
		while (dataReader.Read())
		{
			ForeignKey foreignKey = new ForeignKey
			{
				Name = ((string)dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53BC9C29 ^ 0x53BCF3D3)]).Trim(),
				TableName = tableName,
				RefTableName = ((string)dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-424049965 ^ -424021263)]).Trim()
			};
			foreignKey.Columns.Add(((string)dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-19828073 ^ -19856697)]).Trim());
			foreignKey.RefColumns.Add(((string)dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4211224B ^ 0x4211523B)]).Trim());
			list.Add(foreignKey);
		}
		return list;
	}

	public override IList<ForeignKey> GetForeignKeys()
	{
		List<ForeignKey> list = new List<ForeignKey>();
		using IDataReader dataReader = ExecuteQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1374979190 ^ -1375007958));
		while (dataReader.Read())
		{
			string tableName = ((string)dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-370249262 ^ -370276656)]).Trim();
			ForeignKey foreignKey = new ForeignKey
			{
				Name = ((string)dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-860755570 ^ -860780940)]).Trim(),
				TableName = tableName,
				RefTableName = ((string)dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-61500477 ^ -61479967)]).Trim()
			};
			foreignKey.Columns.Add(((string)dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--500400671 ^ 0x1DD3F24F)]).Trim());
			foreignKey.RefColumns.Add(((string)dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1179530319 ^ -1179534399)]).Trim());
			list.Add(foreignKey);
		}
		return list;
	}

	public override string[] GetTableColumnsNames(string tableName)
	{
		//Discarded unreachable code: IL_00a7, IL_00b6, IL_00c1, IL_0164, IL_019c, IL_01ab
		int num = 3;
		int num2 = num;
		string sql = default(string);
		List<string> list = default(List<string>);
		IDataReader dataReader = default(IDataReader);
		while (true)
		{
			switch (num2)
			{
			case 3:
				sql = (string)uMFAPatpGiPJkACEaAw(XGqPdBtVvuc7MujvoVy(0x5A09CFB9 ^ 0x5A09B8A3), tableName);
				num2 = 2;
				break;
			default:
				return (string[])U6VrFNZSp35Yv6A1lq9(list);
			case 2:
				list = new List<string>();
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_aa8cb810f1524b20abd541fee0197a14 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				dataReader = ExecuteQuery(sql);
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_7942d4fd0d374965b627e0b9f3e5b0e4 == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				try
				{
					while (true)
					{
						int num3;
						if (!Dil0GSZJRf2KerNoQmn(dataReader))
						{
							num3 = 1;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_80b6e3007a3e4355a8078b16fb1979e5 == 0)
							{
								num3 = 1;
							}
							goto IL_00c5;
						}
						goto IL_0101;
						IL_0101:
						list.Add(pcx1m4Z5Vkp41oOsxdc(dataReader, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x36554C4C ^ 0x36553516)).ToString());
						num3 = 1;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_473ad8036e884220a80a5543064a2d98 == 0)
						{
							num3 = 2;
						}
						goto IL_00c5;
						IL_00c5:
						switch (num3)
						{
						case 2:
							break;
						default:
							goto IL_0101;
						case 1:
							goto end_IL_00db;
						}
						continue;
						end_IL_00db:
						break;
					}
				}
				finally
				{
					if (dataReader != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_cdc960c8d7b3434c87091f57ea1faa93 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								dataReader.Dispose();
								num4 = 1;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_937e86e483374781b74ae1d5b232cdfa == 0)
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
				goto default;
			}
		}
	}

	protected override List<KeyValuePair<string, string>> GetTriggers()
	{
		List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
		using IDataReader dataReader = ExecuteQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x28823350 ^ 0x28824A3C));
		while (dataReader.Read())
		{
			list.Add(new KeyValuePair<string, string>(((string)dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1218069071 ^ -1218061313)]).Trim(), ((string)dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8F848CE ^ 0x8F82DD0)]).Trim()));
		}
		return list;
	}

	public override void RemoveProcedure(string procedureName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Kc38fiZj0re2hY6lO5Z(this, procedureName);
				num2 = 3;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_992aa32d3a3449929072ecd77a2ed007 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (Convert.ToInt32(ExecuteScalar(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-969579703 ^ -969598537), new Dictionary<string, object> { 
				{
					(string)XGqPdBtVvuc7MujvoVy(-1869634592 ^ -1869617336),
					FDe1tfZogo2FQrBAErI(procedureName)
				} })) > 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ca63e6162aaa4aaeaa1385bd9f3ad6e0 == 0)
					{
						num2 = 0;
					}
					break;
				}
				RemoveMsSqlFunction(procedureName);
				num2 = 2;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a790b36cf25c47829dbedbeba78b0de0 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 3:
				return;
			}
		}
	}

	protected virtual void RemoveMsSqlProcedure(string procedureName)
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
				ExecuteNonQuery((string)w95JdNZkMmkYJfivZM7(XGqPdBtVvuc7MujvoVy(-2008939226 ^ -2008908150), FDe1tfZogo2FQrBAErI(procedureName)));
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_db0266f588ec4dba9939e9dffe57b346 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected virtual void RemoveMsSqlFunction(string procedureName)
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
				ExecuteNonQuery((string)w95JdNZkMmkYJfivZM7(XGqPdBtVvuc7MujvoVy(0x6080D1CC ^ 0x6080AA02), FDe1tfZogo2FQrBAErI(procedureName)));
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_376bf28cb84b46e183378b59ae583e45 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override List<string> GetProcedures()
	{
		List<string> list = new List<string>();
		using (IDataReader dataReader = ExecuteQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-397159490 ^ -397170608)))
		{
			while (dataReader.Read())
			{
				list.Add(((string)dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-868652467 ^ -868675757)]).Trim());
			}
		}
		using IDataReader dataReader2 = ExecuteQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-169056146 ^ -169077592));
		while (dataReader2.Read())
		{
			list.Add(((string)dataReader2[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x510BFFD ^ 0x510DAE3)]).Trim());
		}
		return list;
	}

	public override List<string> GetViews()
	{
		List<string> list = new List<string>();
		using IDataReader dataReader = ExecuteQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2032417070 ^ -2032420672));
		while (dataReader.Read())
		{
			list.Add(((string)dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4CDC671 ^ 0x4CDA36F)]).Trim());
		}
		return list;
	}

	public override void RemoveIndexes(IList<string> skipNames, IList<string> useNames)
	{
		ExecuteMethod(skipNames, useNames, GetIndexes(false), delegate(KeyValuePair<string, string> p)
		{
			RemoveMsSqlIndex(p.Key, p.Value);
		});
		ExecuteMethod(skipNames, useNames, GetIndexes(true), delegate(KeyValuePair<string, string> p)
		{
			RemoveMsSqlIndex(p.Key, p.Value);
		});
		ExecuteMethod(skipNames, useNames, GetStatistics(), delegate(KeyValuePair<string, string> p)
		{
			RemoveMsSqlStat(p.Key, p.Value);
		});
	}

	public override List<string> GetIndexes(string tableName)
	{
		string sql = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x25153744 ^ 0x2515499E), tableName);
		List<string> list = new List<string>();
		using IDataReader dataReader = ExecuteQuery(sql);
		while (dataReader.Read())
		{
			list.Add(dataReader[0].ToString());
		}
		return list;
	}

	private void DoAddIndex(Index index, bool isUnique = false)
	{
		//Discarded unreachable code: IL_0104, IL_0137, IL_01cb, IL_01da, IL_027e
		int num = 6;
		int num2 = num;
		_003C_003Ec__DisplayClass96_0 _003C_003Ec__DisplayClass96_ = default(_003C_003Ec__DisplayClass96_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass96_.columns = (string)VGx53iZaPWa7mYODliB(XGqPdBtVvuc7MujvoVy(0x4F69E90A ^ 0x4F69C070), index.Columns.Select(_003C_003Ec__DisplayClass96_._003CDoAddIndex_003Eb__0).ToArray());
				num2 = 7;
				break;
			case 1:
				if (!iqP5mSZrAmeIZHWaKO4(this, QiFei6Z10i4NsKre8Of(index), index.Name))
				{
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_adcdf8abe8194ee7810e832bda7e08e7 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 9:
				_003C_003Ec__DisplayClass96_.tableName = (string)vlyCcXZh4I1u4WIg3aY(this, index.TableName);
				num2 = 3;
				break;
			case 7:
				try
				{
					ExecuteWithTimeout(0, _003C_003Ec__DisplayClass96_._003CDoAddIndex_003Eb__1);
					int num3 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_d19adf20f6ad477ba0f485a1097d78a1 != 0)
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
				catch (Exception ex)
				{
					int num4 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_e28a31dd97e1464f96b9d0b056879391 == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							kP79T2Z9lGK1c1haqCo(d6IMEnZEgix4nwnvQgO(), MKCnfitShvd4jGmR7IN(XGqPdBtVvuc7MujvoVy(-1239877681 ^ -1239910443), _003C_003Ec__DisplayClass96_.indexName, _003C_003Ec__DisplayClass96_.tableName), ex);
							num4 = 0;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a790b36cf25c47829dbedbeba78b0de0 == 0)
							{
								num4 = 0;
							}
							break;
						default:
							throw new DbStructureException((string)y9oZtWt1lCoeAtg9rgu(fFj9Mht4X6bWClKSKi9(XGqPdBtVvuc7MujvoVy(-1508074661 ^ -1508107459)), _003C_003Ec__DisplayClass96_.indexName, _003C_003Ec__DisplayClass96_.tableName, _003C_003Ec__DisplayClass96_.columns));
						}
					}
				}
			case 2:
				_003C_003Ec__DisplayClass96_.isUnique = isUnique;
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bf52420e3f0049cf9dbec307e6d391c7 != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				_003C_003Ec__DisplayClass96_ = new _003C_003Ec__DisplayClass96_0();
				num2 = 5;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_24d54149ebc348d09713294df311806b != 0)
				{
					num2 = 5;
				}
				break;
			case 5:
				_003C_003Ec__DisplayClass96_._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_3af97e9a57d2492f8793e39a552f0f48 != 0)
				{
					num2 = 2;
				}
				break;
			case 8:
				return;
			case 4:
				return;
			default:
				_003C_003Ec__DisplayClass96_.indexName = (string)vlyCcXZh4I1u4WIg3aY(this, zUIKJmZPEttqranu90G(index));
				num2 = 8;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ca63e6162aaa4aaeaa1385bd9f3ad6e0 != 0)
				{
					num2 = 9;
				}
				break;
			}
		}
	}

	public override void AddUniqueIndex(Index index)
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
				DoAddIndex(index, isUnique: true);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_53c81d4dd9814619a62ac7ac8ba96c27 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void AddIndex(Index index)
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
				DoAddIndex(index);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_e4ca8eb6304c45b5b9866ec7523159cd != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override bool IndexExists(string tableName, string indexName)
	{
		int num = 1;
		int num2 = num;
		string sql = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				sql = FindIndexes(tableName, indexName, selectCount: true);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_4d065835d8a940d6b1a650963bebccc9 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return Convert.ToInt32(ExecuteScalar(sql)) > 0;
			}
		}
	}

	public override void RemoveIndex(string tableName, string indexName)
	{
		//Discarded unreachable code: IL_00a4, IL_00b3
		int num = 1;
		int num2 = num;
		string sql2 = default(string);
		string sql = default(string);
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 3:
				rU2m1KZ2nAEcOvuacIF(this, tableName, indexName);
				num2 = 2;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a1374360d15f4247b418e6f0fa5eef4e == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 4:
				return;
			case 1:
				sql2 = FindIndexes(tableName, indexName, selectCount: true);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_3f5427a24f2948678f15f0286379c485 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				sql = FindStat(tableName, indexName, selectCount: true);
				num2 = 5;
				break;
			default:
				flag = NvaINVtcbUxYxG0HGaj(ExecuteScalar(sql2)) > 0;
				num2 = 6;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_4599535ffcb34731ae493be59317478a == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
			{
				bool num3 = NvaINVtcbUxYxG0HGaj(ExecuteScalar(sql)) > 0;
				if (flag)
				{
					G2VqL0ZWyo2AovVf95k(this, tableName, indexName);
				}
				if (!num3)
				{
					num2 = 1;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bb8b65c62a044e0a9142fed3b497ae35 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 3;
			}
			}
		}
	}

	protected virtual void RemoveMsSqlIndex(string tableName, string indexName)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass101_0 _003C_003Ec__DisplayClass101_ = default(_003C_003Ec__DisplayClass101_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass101_ = new _003C_003Ec__DisplayClass101_0();
				num2 = 2;
				break;
			case 4:
				return;
			default:
				_003C_003Ec__DisplayClass101_.tableName = tableName;
				num2 = 4;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_7d9c3f1bd5704dffa8a30fba06b99cdf == 0)
				{
					num2 = 5;
				}
				break;
			case 5:
				ExecuteWithTimeout(0, _003C_003Ec__DisplayClass101_._003CRemoveMsSqlIndex_003Eb__0);
				num2 = 4;
				break;
			case 1:
				_003C_003Ec__DisplayClass101_.indexName = indexName;
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a1374360d15f4247b418e6f0fa5eef4e == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass101_._003C_003E4__this = this;
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_473ad8036e884220a80a5543064a2d98 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected virtual void RemoveMsSqlStat(string tableName, string indexName)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass102_0 _003C_003Ec__DisplayClass102_ = default(_003C_003Ec__DisplayClass102_0);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return;
			default:
				_003C_003Ec__DisplayClass102_._003C_003E4__this = this;
				num2 = 3;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_937e86e483374781b74ae1d5b232cdfa != 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass102_ = new _003C_003Ec__DisplayClass102_0();
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_7937bb5aeb374034837b9426eced6cfc != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass102_.indexName = indexName;
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_0e8b96b511f849c7b3cd2b1ffcea4179 == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				_003C_003Ec__DisplayClass102_.tableName = tableName;
				num2 = 3;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_01fcbf7f4c0245c8970ab01c215239fb != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				dBFrpgZUBJ7M0dN7wPt(this, 0, new Action(_003C_003Ec__DisplayClass102_._003CRemoveMsSqlStat_003Eb__0));
				num2 = 5;
				break;
			}
		}
	}

	protected override List<KeyValuePair<string, string>> GetIndexes()
	{
		return GetIndexes(false).Union(GetIndexes(true)).Union(GetStatistics()).ToList();
	}

	protected List<KeyValuePair<string, string>> GetIndexes(bool? clustered)
	{
		string sql = FindIndexes(null, null, selectCount: false, clustered);
		List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
		using IDataReader dataReader = ExecuteQuery(sql);
		while (dataReader.Read())
		{
			list.Add(new KeyValuePair<string, string>(((string)dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x28823350 ^ 0x2882551E)]).Trim(), ((string)dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-738220528 ^ -738253140)]).Trim()));
		}
		return list;
	}

	protected List<KeyValuePair<string, string>> GetStatistics()
	{
		List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
		string sql = FindStat();
		using IDataReader dataReader = ExecuteQuery(sql);
		while (dataReader.Read())
		{
			list.Add(new KeyValuePair<string, string>(((string)dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-424049965 ^ -424082943)]).Trim(), ((string)dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5E19FB22 ^ 0x5E197BC8)]).Trim()));
		}
		return list;
	}

	public override string GetDisableIndexOnTable(string tableName)
	{
		return (string)uMFAPatpGiPJkACEaAw(XGqPdBtVvuc7MujvoVy(0x63BC7D18 ^ 0x63BCFC18), tableName);
	}

	public override string GetRebuildIndexOnTable(string tableName)
	{
		return (string)uMFAPatpGiPJkACEaAw(XGqPdBtVvuc7MujvoVy(0x12FD2B1 ^ 0x12F54E5), tableName);
	}

	public override string BackupDatabase(string connectionString, string outputPath)
	{
		//Discarded unreachable code: IL_005d, IL_00f3, IL_015c, IL_01ba, IL_01fa, IL_0209, IL_0215, IL_029e, IL_0310, IL_039d
		int num = 3;
		string text = default(string);
		SqlConnectionStringBuilder sqlConnectionStringBuilder = default(SqlConnectionStringBuilder);
		IDbCommand dbCommand = default(IDbCommand);
		string text2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 4:
					return text;
				case 3:
					if (FHT5JkZ7t8VGrgsfoIa(connectionString))
					{
						num2 = 2;
						continue;
					}
					sqlConnectionStringBuilder = new SqlConnectionStringBuilder(connectionString);
					num2 = 6;
					continue;
				case 2:
					throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2027299446 ^ -2027333936));
				case 6:
					if (outputPath == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_b191e4df737c4fbb97b7fbe68dd7816d == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 7;
				default:
					try
					{
						BYk2hE8YsdjOOWY9gMx(d6IMEnZEgix4nwnvQgO(), twCrIa8KT65bqNI8Ljf(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1513901977 ^ -1513931811), suvcAcZzCFwX7t0SfjC(sqlConnectionStringBuilder), XGqPdBtVvuc7MujvoVy(-424049965 ^ -424081089), text));
						int num3 = 4;
						while (true)
						{
							switch (num3)
							{
							case 3:
								return text;
							case 2:
								BYk2hE8YsdjOOWY9gMx(d6IMEnZEgix4nwnvQgO(), XGqPdBtVvuc7MujvoVy(-15819198 ^ -15855070));
								num3 = 3;
								break;
							default:
								try
								{
									agwePx8ZpdEPWVwTcrK(dbCommand, 0);
									int num4 = 0;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_81833be823b44351b330d2171723abb3 == 0)
									{
										num4 = 0;
									}
									while (true)
									{
										switch (num4)
										{
										default:
											dbCommand.ExecuteNonQuery();
											num4 = 1;
											if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_3af97e9a57d2492f8793e39a552f0f48 != 0)
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
								finally
								{
									int num5;
									if (dbCommand == null)
									{
										num5 = 1;
										if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_50026842ab044d008d304fc8fda891b4 != 0)
										{
											num5 = 0;
										}
										goto IL_01be;
									}
									goto IL_01d4;
									IL_01d4:
									dbCommand.Dispose();
									num5 = 2;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a88ccd6fbe9d4d31ba568282bf848b44 == 0)
									{
										num5 = 2;
									}
									goto IL_01be;
									IL_01be:
									switch (num5)
									{
									case 1:
										goto end_IL_0199;
									case 2:
										goto end_IL_0199;
									}
									goto IL_01d4;
									end_IL_0199:;
								}
								goto case 2;
							case 1:
								dbCommand = (IDbCommand)IJfCHI8tP7hS5wqMnyH(this, text2);
								num3 = 0;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_adccb0765c0e42dbaf186220f45b757c != 0)
								{
									num3 = 0;
								}
								break;
							case 4:
								text2 = (string)MKCnfitShvd4jGmR7IN(XGqPdBtVvuc7MujvoVy(-1374979190 ^ -1374947430), sqlConnectionStringBuilder.InitialCatalog, text);
								num3 = 1;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a2b331cfbee74083865b99663c080fcb == 0)
								{
									num3 = 1;
								}
								break;
							}
						}
					}
					catch (Exception ex)
					{
						int num6 = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_5bed8957b9564941b8d84bad58ce64d0 == 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								throw new InvalidOperationException((string)KH5wMDZyd6y6irkktcE(XGqPdBtVvuc7MujvoVy(0x483FFC8B ^ 0x483F7035), new object[1] { text }));
							}
							kP79T2Z9lGK1c1haqCo(d6IMEnZEgix4nwnvQgO(), XGqPdBtVvuc7MujvoVy(0x816BBA1 ^ 0x816372F), ex);
							num6 = 1;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ee3b4c6a3b0041bfaa9b5ce28a8e6629 != 0)
							{
								num6 = 0;
							}
						}
					}
				case 7:
					text = (string)KV6xrO8MLIlnBZ8sPQP(outputPath, twCrIa8KT65bqNI8Ljf(suvcAcZzCFwX7t0SfjC(sqlConnectionStringBuilder), XGqPdBtVvuc7MujvoVy(0x4F69E90A ^ 0x4F696274), DateTime.Now.ToString((string)XGqPdBtVvuc7MujvoVy(-900013974 ^ -900043794)), XGqPdBtVvuc7MujvoVy(-1117619588 ^ -1117589038)));
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_da020ace8b12415a904b6d9c77d7515c != 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					obj = Path.GetDirectoryName((string)KEPt62Z3eFJsUBeOTIx(sqlConnectionStringBuilder));
					break;
				case 1:
					if (FHT5JkZ7t8VGrgsfoIa(sqlConnectionStringBuilder.AttachDBFilename))
					{
						goto end_IL_0012;
					}
					goto case 8;
				case 5:
					obj = "";
					break;
				}
				outputPath = (string)obj;
				num2 = 6;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_7942d4fd0d374965b627e0b9f3e5b0e4 == 0)
				{
					num2 = 7;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	public override DateTime GetDateTimeNow()
	{
		return KPnGIJ8ubGlvvEu1bHw(ExecuteScalar((string)w95JdNZkMmkYJfivZM7(XGqPdBtVvuc7MujvoVy(0x43EF8209 ^ 0x43EF0F3D), LminVh8820Bd3kYAKqN(Dialect))));
	}

	public override DateTime GetUtcDateTimeNow()
	{
		return KPnGIJ8ubGlvvEu1bHw(ExecuteScalar((string)w95JdNZkMmkYJfivZM7(XGqPdBtVvuc7MujvoVy(-250283594 ^ -250317694), cnTfM68IrZYtTCR0eNA(AOInkota5rqbJBHlvcS(this)))));
	}

	private string FindConstraints(string table, string column, List<ConstraintType> constraints)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-880913840 ^ -880877802));
		if (!string.IsNullOrEmpty(table))
		{
			stringBuilder.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2DA80A2B ^ 0x2DA89AF5), table.ToUpper()));
		}
		if (!string.IsNullOrEmpty(column))
		{
			stringBuilder.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4E15D4BA ^ 0x4E154594), column.ToUpper()));
		}
		if (constraints != null && constraints.Count > 0)
		{
			List<string> list = new List<string>();
			foreach (ConstraintType constraint in constraints)
			{
				list.Add(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5E19FB22 ^ 0x5E19D218), constraint));
			}
			stringBuilder.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6FC42799 ^ 0x6FC4B6C7), string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-174174226 ^ -174137732), list.ToArray())));
		}
		return stringBuilder.ToString();
	}

	private string FindIndexes(string tableName = null, string indexName = null, bool selectCount = false, bool? clustered = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2F47749 ^ 0x2F4E6D1));
		if (selectCount)
		{
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-61500477 ^ -61537685));
		}
		else
		{
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ACAC88E ^ 0x1ACA5930));
		}
		stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-813696680 ^ -813733102));
		if (!string.IsNullOrEmpty(tableName))
		{
			stringBuilder.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C6497C8 ^ 0x6C6403EE), tableName));
		}
		if (!string.IsNullOrEmpty(indexName))
		{
			stringBuilder.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1497017110 ^ -1496989538), indexName.ToUpper()));
		}
		if (clustered.HasValue)
		{
			stringBuilder.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x379281FC ^ 0x3792154C), clustered.Value ? SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1526402459 ^ -1526438265) : SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51286021 ^ 0x5128F4FB)));
		}
		return stringBuilder.ToString();
	}

	private string FindStat(string tableName = null, string indexName = null, bool selectCount = false)
	{
		//Discarded unreachable code: IL_00fb, IL_010a, IL_013c, IL_014b, IL_0170
		int num = 4;
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					stringBuilder.Append((string)uMFAPatpGiPJkACEaAw(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2F47749 ^ 0x2F4E03B), tableName));
					num2 = 10;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ec5f92fd6ddb449a9afc09c18f0a77db == 0)
					{
						num2 = 2;
					}
					continue;
				case 8:
					bkVA4OtbRoOvUHOEukM(stringBuilder, XGqPdBtVvuc7MujvoVy(0x7486AEA8 ^ 0x74863F00));
					num2 = 12;
					continue;
				default:
					bkVA4OtbRoOvUHOEukM(stringBuilder, XGqPdBtVvuc7MujvoVy(0x5766B69D ^ 0x57662275));
					num2 = 11;
					continue;
				case 9:
					if (!selectCount)
					{
						num2 = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_067e68396ca94bf49b212b142d07ac32 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 8;
				case 3:
					stringBuilder.Append((string)XGqPdBtVvuc7MujvoVy(-19828073 ^ -19799281));
					num2 = 9;
					continue;
				case 6:
					if (FHT5JkZ7t8VGrgsfoIa(tableName))
					{
						num2 = 5;
						continue;
					}
					goto case 2;
				case 11:
				case 12:
					stringBuilder.Append((string)XGqPdBtVvuc7MujvoVy(0x6080D1CC ^ 0x608044A4));
					num2 = 6;
					continue;
				case 5:
				case 10:
					if (!FHT5JkZ7t8VGrgsfoIa(indexName))
					{
						num2 = 13;
						continue;
					}
					break;
				case 13:
					goto end_IL_0012;
				case 4:
					stringBuilder = new StringBuilder();
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_4f783759df564a788bd78dfdef3c9c5f == 0)
					{
						num2 = 3;
					}
					continue;
				case 7:
					break;
				}
				return stringBuilder.ToString();
				continue;
				end_IL_0012:
				break;
			}
			bkVA4OtbRoOvUHOEukM(stringBuilder, uMFAPatpGiPJkACEaAw(XGqPdBtVvuc7MujvoVy(0x3B41FCB7 ^ 0x3B416B0D), indexName.ToUpper()));
			num = 7;
		}
	}

	private string GetSchemaName()
	{
		//Discarded unreachable code: IL_0089, IL_00ee, IL_0126
		int num = 4;
		int num2 = num;
		string sql = default(string);
		IDataReader dataReader = default(IDataReader);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				sql = (string)XGqPdBtVvuc7MujvoVy(-214073528 ^ -214046532);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_9457c8cc16bd407492ec82836e6ece2b == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				try
				{
					if (Dil0GSZJRf2KerNoQmn(dataReader))
					{
						int num3 = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bb662a6d5969493581c2c367e740adde == 0)
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
							result = dataReader[0].ToString();
							num3 = 0;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_610637caa58f480dbbd64235291b457a != 0)
							{
								num3 = 1;
							}
						}
					}
					return result;
				}
				finally
				{
					if (dataReader != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bbc137d911274e6c8ec7374800482ba2 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								b7Z9UsZMPYIQOaNIN6H(dataReader);
								num4 = 0;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_d2ea3571782f460a8fcf4212c4b89aef != 0)
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
			case 4:
				result = "";
				num2 = 3;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bbc137d911274e6c8ec7374800482ba2 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return result;
			default:
				dataReader = ExecuteQuery(sql);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_24d54149ebc348d09713294df311806b == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override long[] ReserveIds(int count, string table)
	{
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass122_0 _003C_003Ec__DisplayClass122_ = default(_003C_003Ec__DisplayClass122_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass122_.table = table;
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bdc18f4c9e6b474ea4d1521d9166d946 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass122_._003C_003E4__this = this;
				num2 = 2;
				break;
			case 4:
				_003C_003Ec__DisplayClass122_ = new _003C_003Ec__DisplayClass122_0();
				num2 = 3;
				break;
			default:
				_003C_003Ec__DisplayClass122_.count = count;
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_53c81d4dd9814619a62ac7ac8ba96c27 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return ReserveIds(_003C_003Ec__DisplayClass122_.count, _003C_003Ec__DisplayClass122_.table, IsSequenceSupport ? ((Func<Dictionary<string, string>, IIdentifierGenerator>)((Dictionary<string, string> _) => (IIdentifierGenerator)(object)new ElmaSequenceHiLoGenerator())) : null, _003C_003Ec__DisplayClass122_._003CReserveIds_003Eb__1);
			}
		}
	}

	public override void BulkInsert(string tableName, DataTable data)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				BJPI8Z8ErwtoHGXRise(this, data);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_4f783759df564a788bd78dfdef3c9c5f == 0)
				{
					num2 = 0;
				}
				break;
			default:
				BulkInsert(tableName, data, shouldGenerateId: true);
				num2 = 2;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_db0266f588ec4dba9939e9dffe57b346 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override void BulkInsert(string tableName, DataTable data, bool shouldGenerateId)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		System.Threading.Tasks.ValueTask valueTask = default(System.Threading.Tasks.ValueTask);
		ValueTaskAwaiter awaiter = default(ValueTaskAwaiter);
		while (true)
		{
			switch (num2)
			{
			case 1:
				valueTask = BulkInsertAsync(tableName, data, shouldGenerateId, isAsync: false);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_dd87e5ded93948d0bf26853dd7df12f5 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				awaiter = valueTask.GetAwaiter();
				num2 = 2;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_dda363349c784d1da4ad7d915f94c5c7 == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				return;
			case 2:
				((ValueTaskAwaiter)(ref awaiter)).GetResult();
				num2 = 3;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_937e86e483374781b74ae1d5b232cdfa == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override Task BulkInsertAsync(string tableName, DataTable data, CancellationToken cancellationToken = default(CancellationToken))
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (Task)NW0Pbp89Rm8kEm15D7P(this, tableName, data, true, cancellationToken);
			case 1:
				TransformIntoServerDateTime(data);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_cdc960c8d7b3434c87091f57ea1faa93 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				cancellationToken.ThrowIfCancellationRequested();
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_3f149d3899664c3e92db5de6fde4f35a == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override Task BulkInsertAsync(string tableName, DataTable data, bool shouldGenerateId, CancellationToken cancellationToken = default(CancellationToken))
	{
		int num = 1;
		int num2 = num;
		System.Threading.Tasks.ValueTask valueTask = default(System.Threading.Tasks.ValueTask);
		while (true)
		{
			switch (num2)
			{
			default:
				return valueTask.AsTask();
			case 1:
				valueTask = BulkInsertAsync(tableName, data, shouldGenerateId, isAsync: true, cancellationToken);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_26c4d17a35c943fbaf0ef30e123de177 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CBulkInsertAsync_003Ed__127))]
	private System.Threading.Tasks.ValueTask BulkInsertAsync(string tableName, DataTable data, bool shouldGenerateId, bool isAsync, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		int num = 9;
		_003CBulkInsertAsync_003Ed__127 _003CBulkInsertAsync_003Ed__ = default(_003CBulkInsertAsync_003Ed__127);
		AsyncValueTaskMethodBuilder _003C_003Et__builder = default(AsyncValueTaskMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					_003CBulkInsertAsync_003Ed__.tableName = tableName;
					num2 = 5;
					continue;
				case 7:
					_003C_003Et__builder = _003CBulkInsertAsync_003Ed__._003C_003Et__builder;
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_53c81d4dd9814619a62ac7ac8ba96c27 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					_003CBulkInsertAsync_003Ed__.isAsync = isAsync;
					num2 = 4;
					continue;
				case 4:
					_003CBulkInsertAsync_003Ed__.cancellationToken = cancellationToken;
					num2 = 2;
					continue;
				case 5:
					_003CBulkInsertAsync_003Ed__.data = data;
					num2 = 10;
					continue;
				case 3:
					_003CBulkInsertAsync_003Ed__._003C_003E1__state = -1;
					num2 = 7;
					continue;
				case 6:
					return ((AsyncValueTaskMethodBuilder)(ref _003CBulkInsertAsync_003Ed__._003C_003Et__builder)).get_Task();
				case 9:
					_003CBulkInsertAsync_003Ed__._003C_003E4__this = this;
					num2 = 8;
					continue;
				case 2:
					_003CBulkInsertAsync_003Ed__._003C_003Et__builder = dtomFe8yd7bZLyZqjrx();
					num2 = 3;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_914e5983c8d84fee9bd54eba99b82441 == 0)
					{
						num2 = 3;
					}
					continue;
				case 10:
					_003CBulkInsertAsync_003Ed__.shouldGenerateId = shouldGenerateId;
					num2 = 1;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_15400f29239a48f5a6f7d131d55cff1f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			((AsyncValueTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CBulkInsertAsync_003Ed__127>(ref _003CBulkInsertAsync_003Ed__);
			num = 6;
		}
	}

	public override void BulkUpdate(string tableName, DataTable data)
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
				BulkUpdate(tableName, data, (string)XGqPdBtVvuc7MujvoVy(-1933751546 ^ -1933716698));
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_cdc960c8d7b3434c87091f57ea1faa93 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void BulkUpdate(string tableName, DataTable data, string keyColumn)
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
				BulkUpdate(tableName, data, new List<ColumnLink>
				{
					new ColumnLink(keyColumn)
				});
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_d2ea3571782f460a8fcf4212c4b89aef != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void BulkUpdate(string tableName, DataTable data, List<ColumnLink> keyColumns)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		ValueTaskAwaiter awaiter = BulkUpdateAsync(tableName, data, keyColumns, isAsync: false).GetAwaiter();
		((ValueTaskAwaiter)(ref awaiter)).GetResult();
	}

	public override Task BulkUpdateAsync(string tableName, DataTable data, CancellationToken cancellationToken = default(CancellationToken))
	{
		return (Task)RhJA7C8ni2lXvncFDbh(this, tableName, data, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1869634592 ^ -1869661248), cancellationToken);
	}

	public override Task BulkUpdateAsync(string tableName, DataTable data, string keyColumn, CancellationToken cancellationToken = default(CancellationToken))
	{
		return BulkUpdateAsync(tableName, data, new List<ColumnLink>
		{
			new ColumnLink(keyColumn)
		}, cancellationToken);
	}

	public override Task BulkUpdateAsync(string tableName, DataTable data, List<ColumnLink> keyColumns, CancellationToken cancellationToken = default(CancellationToken))
	{
		return BulkUpdateAsync(tableName, data, keyColumns, isAsync: true, cancellationToken).AsTask();
	}

	[AsyncStateMachine(typeof(_003CBulkUpdateAsync_003Ed__134))]
	private System.Threading.Tasks.ValueTask BulkUpdateAsync(string tableName, DataTable data, IReadOnlyList<ColumnLink> keyColumns, bool isAsync, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		_003CBulkUpdateAsync_003Ed__134 _003CBulkUpdateAsync_003Ed__ = default(_003CBulkUpdateAsync_003Ed__134);
		_003CBulkUpdateAsync_003Ed__._003C_003E4__this = this;
		_003CBulkUpdateAsync_003Ed__.tableName = tableName;
		_003CBulkUpdateAsync_003Ed__.data = data;
		_003CBulkUpdateAsync_003Ed__.keyColumns = keyColumns;
		_003CBulkUpdateAsync_003Ed__.isAsync = isAsync;
		_003CBulkUpdateAsync_003Ed__.cancellationToken = cancellationToken;
		_003CBulkUpdateAsync_003Ed__._003C_003Et__builder = AsyncValueTaskMethodBuilder.Create();
		_003CBulkUpdateAsync_003Ed__._003C_003E1__state = -1;
		AsyncValueTaskMethodBuilder _003C_003Et__builder = _003CBulkUpdateAsync_003Ed__._003C_003Et__builder;
		((AsyncValueTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CBulkUpdateAsync_003Ed__134>(ref _003CBulkUpdateAsync_003Ed__);
		return ((AsyncValueTaskMethodBuilder)(ref _003CBulkUpdateAsync_003Ed__._003C_003Et__builder)).get_Task();
	}

	public override int BulkDelete(string table, string where, Dictionary<string, object> paramValues = null)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		return BulkDeleteAsync(table, where, paramValues, isAsync: false).GetAwaiter().GetResult();
	}

	public override int BulkDelete(BulkDeleteArg arg)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		int num2 = num;
		ValueTaskAwaiter<int> awaiter = default(ValueTaskAwaiter<int>);
		System.Threading.Tasks.ValueTask<int> valueTask = default(System.Threading.Tasks.ValueTask<int>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				awaiter = valueTask.GetAwaiter();
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_537fedc41bac4a50bc41e21f4171db7f != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				valueTask = BulkDeleteAsync(arg, isAsync: false);
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_26c4d17a35c943fbaf0ef30e123de177 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return awaiter.GetResult();
			}
		}
	}

	public override Task<int> BulkDeleteAsync(string table, string where, Dictionary<string, object> paramValues = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		return BulkDeleteAsync(table, where, paramValues, isAsync: true, cancellationToken).AsTask();
	}

	public override Task<int> BulkDeleteAsync(BulkDeleteArg arg, CancellationToken cancellationToken = default(CancellationToken))
	{
		return BulkDeleteAsync(arg, isAsync: true, cancellationToken).AsTask();
	}

	[AsyncStateMachine(typeof(_003CBulkDeleteAsync_003Ed__139))]
	private System.Threading.Tasks.ValueTask<int> BulkDeleteAsync(string table, string where, Dictionary<string, object> paramValues, bool isAsync, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		_003CBulkDeleteAsync_003Ed__139 _003CBulkDeleteAsync_003Ed__ = default(_003CBulkDeleteAsync_003Ed__139);
		_003CBulkDeleteAsync_003Ed__._003C_003E4__this = this;
		_003CBulkDeleteAsync_003Ed__.table = table;
		_003CBulkDeleteAsync_003Ed__.where = where;
		_003CBulkDeleteAsync_003Ed__.paramValues = paramValues;
		_003CBulkDeleteAsync_003Ed__.isAsync = isAsync;
		_003CBulkDeleteAsync_003Ed__.cancellationToken = cancellationToken;
		_003CBulkDeleteAsync_003Ed__._003C_003Et__builder = AsyncValueTaskMethodBuilder<int>.Create();
		_003CBulkDeleteAsync_003Ed__._003C_003E1__state = -1;
		AsyncValueTaskMethodBuilder<int> _003C_003Et__builder = _003CBulkDeleteAsync_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CBulkDeleteAsync_003Ed__139>(ref _003CBulkDeleteAsync_003Ed__);
		return _003CBulkDeleteAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	[AsyncStateMachine(typeof(_003CBulkDeleteAsync_003Ed__140))]
	private System.Threading.Tasks.ValueTask<int> BulkDeleteAsync(BulkDeleteArg arg, bool isAsync, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		_003CBulkDeleteAsync_003Ed__140 _003CBulkDeleteAsync_003Ed__ = default(_003CBulkDeleteAsync_003Ed__140);
		_003CBulkDeleteAsync_003Ed__._003C_003E4__this = this;
		_003CBulkDeleteAsync_003Ed__.arg = arg;
		_003CBulkDeleteAsync_003Ed__.isAsync = isAsync;
		_003CBulkDeleteAsync_003Ed__.cancellationToken = cancellationToken;
		_003CBulkDeleteAsync_003Ed__._003C_003Et__builder = AsyncValueTaskMethodBuilder<int>.Create();
		_003CBulkDeleteAsync_003Ed__._003C_003E1__state = -1;
		AsyncValueTaskMethodBuilder<int> _003C_003Et__builder = _003CBulkDeleteAsync_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CBulkDeleteAsync_003Ed__140>(ref _003CBulkDeleteAsync_003Ed__);
		return _003CBulkDeleteAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	static MSSQLTransformationProvider()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				SqlGetForeignKeys = (string)w95JdNZkMmkYJfivZM7(XGqPdBtVvuc7MujvoVy(0x142041AF ^ 0x1420310F), XGqPdBtVvuc7MujvoVy(0x6FC42799 ^ 0x6FC4BF4D));
				num2 = 4;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_595bc6899ac747d989e6cbc941c80562 == 0)
				{
					num2 = 4;
				}
				break;
			case 6:
				SqlGetPrimaryKeyByTable = (string)XGqPdBtVvuc7MujvoVy(0x15436EBF ^ 0x15430383) + (string)XGqPdBtVvuc7MujvoVy(-1526402459 ^ -1526437131);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bdc18f4c9e6b474ea4d1521d9166d946 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				GeneratorColumns = new string[2]
				{
					(string)XGqPdBtVvuc7MujvoVy(0x55622768 ^ 0x55622DEA),
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A09CFB9 ^ 0x5A0957C3)
				};
				num2 = 6;
				break;
			case 1:
				UidString = (string)XGqPdBtVvuc7MujvoVy(-1573941355 ^ -1573972033);
				num2 = 3;
				break;
			case 4:
				return;
			case 2:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.BPCyhsoin5();
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_dec9bc2de6b0466ebcda5b628a0a78a9 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				ProviderUID = new Guid(UidString);
				num2 = 5;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_3f5427a24f2948678f15f0286379c485 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void SgTqECtRaKUsLKOxgKV()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.BPCyhsoin5();
	}

	internal static object XGqPdBtVvuc7MujvoVy(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool nUvuYbtTwPtDoJEWFKZ()
	{
		return KYEEULtwerVAHoXosUo == null;
	}

	internal static MSSQLTransformationProvider EG5DrRtg80gtqefeBNt()
	{
		return KYEEULtwerVAHoXosUo;
	}

	internal static void vM2RiHtUqW6g9Gee6Yc(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object RlDc4xtGsuWvX2E1biV(object P_0)
	{
		return ((Exception)P_0).InnerException;
	}

	internal static object THenNxtFPE8KO75tiZY(object P_0)
	{
		return ((SqlException)P_0).Errors;
	}

	internal static void Gnv4gjtio9mS5t3plFx(object P_0, object P_1, object P_2)
	{
		((TransformationProvider)P_0).ProcessException((Exception)P_1, (IDbConnection)P_2);
	}

	internal static object fFj9Mht4X6bWClKSKi9(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object rBKgO9teL7U3AtqFykL(object P_0)
	{
		return Convert.ToString(P_0);
	}

	internal static object wVIHN7thWqK5pmfeoh7(object P_0, object P_1)
	{
		return ((string)P_0).Trim((char[])P_1);
	}

	internal static object UN8vmWtHDYVtEOHI6Ev()
	{
		return Environment.NewLine;
	}

	internal static object HiksGQtskVtGrkx73rX(object P_0)
	{
		return string.Concat((object[])P_0);
	}

	internal static int NvaINVtcbUxYxG0HGaj(object P_0)
	{
		return Convert.ToInt32(P_0);
	}

	internal static object f7gstBtBV49M9ZmHmgG(object P_0)
	{
		return ((TransformationProvider)P_0).GetEngineVersion();
	}

	internal static object uMFAPatpGiPJkACEaAw(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static int vuLpu8tX29GaSWtmraT(object P_0)
	{
		return ((Version)P_0).Major;
	}

	internal static object iPPsXyt5saR0K4YXBZj(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static bool E6ZTH8tqEJDrGBQGDI1(object P_0, object P_1)
	{
		return (FetchOptions)P_0 != (FetchOptions)P_1;
	}

	internal static object PZ5K9StDsWB96ktohY6()
	{
		return FetchOptions.All;
	}

	internal static object cxZoTetfbN7WkyP7CMV(object P_0)
	{
		return ((FetchOptions)P_0).SortExpression;
	}

	internal static bool hyn7pft0F7Y2SolMZnX(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).StartsWith((string)P_1, P_2);
	}

	internal static ListSortDirection xQZqw6tmi8BAn715Lqa(object P_0)
	{
		return ((FetchOptions)P_0).SortDirection;
	}

	internal static int hMWJ2jtlhB6Ckmq6WYm(object P_0)
	{
		return ((FetchOptions)P_0).FirstResult;
	}

	internal static int g9m6lMtvSUcqZsQq10Z(object P_0)
	{
		return ((FetchOptions)P_0).MaxResults;
	}

	internal static object bkVA4OtbRoOvUHOEukM(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object MKCnfitShvd4jGmR7IN(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object y9oZtWt1lCoeAtg9rgu(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static bool Y1jvnutrZIjN3J033Qy(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static object QtymB2tPVpr3HQNsawe(object P_0, object P_1, object P_2)
	{
		return ((TransformationProvider)P_0).BitAndExpression((string)P_1, (string)P_2);
	}

	internal static object AOInkota5rqbJBHlvcS(object P_0)
	{
		return ((TransformationProviderBase)P_0).Dialect;
	}

	internal static object NJvbMEtWcZWYUnSGhUH(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static void JOQiZut2fbLrIH9ZEnu(object P_0, object P_1, object P_2, bool P_3)
	{
		((TransformationProvider)P_0).AddTable((string)P_1, (string)P_2, P_3);
	}

	internal static void aI2nBOt745gCH9CqytV(object P_0, object P_1)
	{
		((TransformationProvider)P_0).AddTableSequence((string)P_1);
	}

	internal static object qiP9R7t3Q96uIMDXavF(object P_0)
	{
		return ((SqlConnection)P_0).CreateCommand();
	}

	internal static void lewHvxtz6W2QCH9a81r(object P_0, CommandType P_1)
	{
		((DbCommand)P_0).CommandType = P_1;
	}

	internal static void DTmiu9ZK3uitCW7W2vt(object P_0, object P_1)
	{
		((DbCommand)P_0).CommandText = (string)P_1;
	}

	internal static void b7Z9UsZMPYIQOaNIN6H(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void Qoe8AtZYG98lpnGFEW8(object P_0)
	{
		((DbConnection)P_0).Close();
	}

	internal static void zyupxQZtRwXKaTMefqr(object P_0)
	{
		((DbConnection)P_0).Open();
	}

	internal static bool Gs5JvTZZXy7MxrFiPhM(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object uJRPyAZ84jGYCkeCJy1(object P_0)
	{
		return ((DbConnection)P_0).ConnectionString;
	}

	internal static object CxEtKxZuSTfcl8FeJTE(object P_0)
	{
		return ((SqlConnectionStringBuilder)P_0).DataSource;
	}

	internal static object ovupgMZI32LumL2PTKQ(object P_0)
	{
		return ((SqlCommand)P_0).ExecuteReader();
	}

	internal static object d6IMEnZEgix4nwnvQgO()
	{
		return Logger.Log;
	}

	internal static void kP79T2Z9lGK1c1haqCo(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object KH5wMDZyd6y6irkktcE(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static void nwJriCZnXbmWoWpWbGx(object P_0, object P_1, bool P_2, object P_3)
	{
		((TransformationProvider)P_0).AddTable((string)P_1, P_2, (Column[])P_3);
	}

	internal static Guid vIk1yWZOQPvHWTuWZQR()
	{
		return Guid.NewGuid();
	}

	internal static void LVNq3BZA31m7mBikiec(object P_0, object P_1, bool P_2)
	{
		((TransformationProvider)P_0).RemoveTable((string)P_1, P_2);
	}

	internal static void Kc38fiZj0re2hY6lO5Z(object P_0, object P_1)
	{
		((MSSQLTransformationProvider)P_0).RemoveMsSqlProcedure((string)P_1);
	}

	internal static bool H0JvYRZxPuqkhaVoQSH(object P_0, object P_1)
	{
		return ((TransformationProvider)P_0).TableExists((string)P_1);
	}

	internal static void p2GLguZQGUpZh31fbt2(object P_0, bool P_1)
	{
		((Table)P_0).Sequence = P_1;
	}

	internal static void J01KwNZNRNrF1jMix9j(object P_0, object P_1)
	{
		((Table)P_0).Name = (string)P_1;
	}

	internal static object LS1Qi7ZL6xLJyGeo3kN(object P_0, int P_1)
	{
		return ((IDataRecord)P_0)[P_1];
	}

	internal static object w95JdNZkMmkYJfivZM7(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static long igKjakZ6kwCOTA4AOZa(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static double KUKV2GZC1ojvHb5Kdwk(double P_0)
	{
		return Math.Ceiling(P_0);
	}

	internal static bool Dil0GSZJRf2KerNoQmn(object P_0)
	{
		return ((IDataReader)P_0).Read();
	}

	internal static object FDe1tfZogo2FQrBAErI(object P_0)
	{
		return ((string)P_0).ToUpper();
	}

	internal static object UFXaNNZdCR7pEblUwYy(object P_0, object P_1)
	{
		return ((TransformationProvider)P_0).GetPrimaryKeyByTable((string)P_1);
	}

	internal static void fksNNvZw1qP34T2qK5Y(object P_0, object P_1, object P_2)
	{
		((TransformationProvider)P_0).AddColumn((string)P_1, (Column)P_2);
	}

	internal static void sW5kcQZTrxglTGYd2t9(object P_0, object P_1, object P_2)
	{
		((TransformationProvider)P_0).RemovePrimaryKey((string)P_1, (string)P_2);
	}

	internal static void shK5MoZgjuL7wo37VOW(object P_0, object P_1, object P_2, object P_3)
	{
		((TransformationProvider)P_0).RenameColumn((string)P_1, (string)P_2, (string)P_3);
	}

	internal static object dIq5dvZR73l7yoYXZIA(object P_0)
	{
		return ((PrimaryKey)P_0).Name;
	}

	internal static void Cy4ErKZVMSvFn9fp2PQ(object P_0, object P_1, object P_2, object P_3)
	{
		((TransformationProvider)P_0).AddPrimaryKey((string)P_1, (string)P_2, (string[])P_3);
	}

	internal static void dBFrpgZUBJ7M0dN7wPt(object P_0, int P_1, object P_2)
	{
		((TransformationProviderBase)P_0).ExecuteWithTimeout(P_1, (Action)P_2);
	}

	internal static void R0204ZZGrEUp05GcmFO(object P_0, object P_1)
	{
		Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static void OYEleSZFqLHXIWBAmqE(object P_0, object P_1, object P_2)
	{
		((TransformationProvider)P_0).RenameSequence((string)P_1, (string)P_2);
	}

	internal static void JkADZ6ZiMZoWIxcqSDg(object P_0, object P_1)
	{
		((TransformationProvider)P_0).RemoveTableSequence((string)P_1);
	}

	internal static int EyysZFZ4cRsIM1IrJ4B(object P_0)
	{
		return ((List<string>)P_0).Count;
	}

	internal static void etBtlCZeJJDfw9Rwe80(object P_0, object P_1, bool P_2)
	{
		((TransformationProvider)P_0).RemoveTable((string)P_1, P_2);
	}

	internal static object vlyCcXZh4I1u4WIg3aY(object P_0, object P_1)
	{
		return ((TransformationProviderBase)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static void GlGQtkZHPLcKexxUWFL(object P_0, object P_1, object P_2)
	{
		((TransformationProvider)P_0).RemoveColumnConstraints((string)P_1, (string)P_2);
	}

	internal static bool LIjy5sZsaQKWgcV6Oq8(object P_0, object P_1, object P_2)
	{
		return ((TransformationProvider)P_0).ColumnExists((string)P_1, (string)P_2);
	}

	internal static object rIDCcMZcDDCySleMUIi(object P_0, int P_1)
	{
		return ((IDataRecord)P_0).GetString(P_1);
	}

	internal static void T10ssFZByP0jQQb0g06(object P_0, object P_1, object P_2)
	{
		((TransformationProvider)P_0).RemoveColumn((string)P_1, (string)P_2);
	}

	internal static void uIne73ZpaGSIPYl0XPF(object P_0, object P_1, object P_2)
	{
		((TransformationProvider)P_0).RemoveForeignKey((string)P_1, (string)P_2);
	}

	internal static void OyrOBhZXcWtG5v2SDqi(object P_0, object P_1)
	{
		((PrimaryKey)P_0).TableName = (string)P_1;
	}

	internal static object pcx1m4Z5Vkp41oOsxdc(object P_0, object P_1)
	{
		return ((IDataRecord)P_0)[(string)P_1];
	}

	internal static object OHEZULZqZkaanwssOGq(object P_0)
	{
		return ((ForeignKey)P_0).TableName;
	}

	internal static bool YlGEGOZDuRXy27KydE3(object P_0, object P_1, object P_2)
	{
		return ((TransformationProvider)P_0).ConstraintExists((string)P_1, (string)P_2);
	}

	internal static void SQlrqWZfWRGNok0TGJB(object P_0, object P_1)
	{
		((TransformationProvider)P_0).AddForeignKey((ForeignKey)P_1);
	}

	internal static object GakbjaZ0OIlEn0ZS5xN(object P_0)
	{
		return ((ForeignKey)P_0).Name;
	}

	internal static void VGGm0lZm2FQNfAoKpFP(object P_0, object P_1)
	{
		((Index)P_0).Name = (string)P_1;
	}

	internal static void hagYYIZl1r49gBapwXx(object P_0, object P_1)
	{
		((Index)P_0).TableName = (string)P_1;
	}

	internal static void NQkKUkZvnkcBG1nvZsk(object P_0, object P_1)
	{
		((TransformationProvider)P_0).AddIndex((Index)P_1);
	}

	internal static object pYyTtUZbODfV0GnTIUw(object P_0, object P_1)
	{
		return ((TransformationProvider)P_0).GetIndexNameByForeignKey((string)P_1);
	}

	internal static object U6VrFNZSp35Yv6A1lq9(object P_0)
	{
		return ((List<string>)P_0).ToArray();
	}

	internal static object QiFei6Z10i4NsKre8Of(object P_0)
	{
		return ((Index)P_0).TableName;
	}

	internal static bool iqP5mSZrAmeIZHWaKO4(object P_0, object P_1, object P_2)
	{
		return ((TransformationProvider)P_0).IndexExists((string)P_1, (string)P_2);
	}

	internal static object zUIKJmZPEttqranu90G(object P_0)
	{
		return ((Index)P_0).Name;
	}

	internal static object VGx53iZaPWa7mYODliB(object P_0, object P_1)
	{
		return string.Join((string)P_0, (string[])P_1);
	}

	internal static void G2VqL0ZWyo2AovVf95k(object P_0, object P_1, object P_2)
	{
		((MSSQLTransformationProvider)P_0).RemoveMsSqlIndex((string)P_1, (string)P_2);
	}

	internal static void rU2m1KZ2nAEcOvuacIF(object P_0, object P_1, object P_2)
	{
		((MSSQLTransformationProvider)P_0).RemoveMsSqlStat((string)P_1, (string)P_2);
	}

	internal static bool FHT5JkZ7t8VGrgsfoIa(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object KEPt62Z3eFJsUBeOTIx(object P_0)
	{
		return ((SqlConnectionStringBuilder)P_0).AttachDBFilename;
	}

	internal static object suvcAcZzCFwX7t0SfjC(object P_0)
	{
		return ((SqlConnectionStringBuilder)P_0).InitialCatalog;
	}

	internal static object twCrIa8KT65bqNI8Ljf(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static object KV6xrO8MLIlnBZ8sPQP(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static void BYk2hE8YsdjOOWY9gMx(object P_0, object P_1)
	{
		((ILogger)P_0).Info(P_1);
	}

	internal static object IJfCHI8tP7hS5wqMnyH(object P_0, object P_1)
	{
		return ((TransformationProviderBase)P_0).BuildCommand((string)P_1);
	}

	internal static void agwePx8ZpdEPWVwTcrK(object P_0, int P_1)
	{
		((IDbCommand)P_0).CommandTimeout = P_1;
	}

	internal static object LminVh8820Bd3kYAKqN(object P_0)
	{
		return ((Dialect)P_0).CurrentTimestamp;
	}

	internal static DateTime KPnGIJ8ubGlvvEu1bHw(object P_0)
	{
		return Convert.ToDateTime(P_0);
	}

	internal static object cnTfM68IrZYtTCR0eNA(object P_0)
	{
		return ((Dialect)P_0).CurrentUtcTimestamp;
	}

	internal static void BJPI8Z8ErwtoHGXRise(object P_0, object P_1)
	{
		((TransformationProvider)P_0).TransformIntoServerDateTime((DataTable)P_1);
	}

	internal static object NW0Pbp89Rm8kEm15D7P(object P_0, object P_1, object P_2, bool P_3, CancellationToken P_4)
	{
		return ((TransformationProvider)P_0).BulkInsertAsync((string)P_1, (DataTable)P_2, P_3, P_4);
	}

	internal static AsyncValueTaskMethodBuilder dtomFe8yd7bZLyZqjrx()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return AsyncValueTaskMethodBuilder.Create();
	}

	internal static object RhJA7C8ni2lXvncFDbh(object P_0, object P_1, object P_2, object P_3, CancellationToken P_4)
	{
		return ((TransformationProvider)P_0).BulkUpdateAsync((string)P_1, (DataTable)P_2, (string)P_3, P_4);
	}

	internal static int VG8DAl8OEjIadmQhXtG(object P_0, object P_1, object P_2, object P_3, bool P_4)
	{
		return ((TransformationProvider)P_0).Insert((string)P_1, (string[])P_2, (object[])P_3, P_4);
	}
}
