using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using NHibernate.AdoNet.Util;
using NHibernate.Connection;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Engine;
using NHibernate.Id;
using NHibernate.Mapping.ByCode;
using NHibernate.SqlCommand;
using NHibernate.SqlTypes;
using NHibernate.Type;
using NHibernate.Util;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH.Id;

public class IdentityHiLoFromTableGenerator : TransactionHelper, IPersistentIdentifierGenerator, IIdentifierGenerator, IConfigurable
{
	private class GeneratorDefInternal : IGeneratorDef
	{
		internal static object xnipxOQLoniQ8o92iKoo;

		public string Class => typeof(IdentityHiLoFromTableGenerator).AssemblyQualifiedName;

		public object Params => null;

		public Type DefaultReturnType => TypeOf<long>.Raw;

		public bool SupportedAsCollectionElementId => false;

		public GeneratorDefInternal()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			RbwcxHQLGLaEcVpqPNvs();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool NnP7wqQLbIOOHfwOmU9j()
		{
			return xnipxOQLoniQ8o92iKoo == null;
		}

		internal static GeneratorDefInternal XcqUJrQLhRHVBsfTgfJK()
		{
			return (GeneratorDefInternal)xnipxOQLoniQ8o92iKoo;
		}

		internal static void RbwcxHQLGLaEcVpqPNvs()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private static readonly ILogger Log;

	public const string WhereParamName = "where";

	public const string ColumnParamName = "column";

	public const string WhereColumnParamName = "whereColumn";

	public const string WhereValueParamName = "whereValue";

	public const string TableParamName = "table";

	public const string MaxLoParamName = "max_lo";

	public const string DefaultColumnName = "NextValue";

	public const string DefaultTableName = "Sys_TableGenerators";

	private long hi;

	private long lo;

	private long maxLo;

	private Type returnClass;

	private string tableName;

	private string columnName;

	private string whereColumnName;

	private string whereValue;

	private string whereClause;

	private string query;

	protected SqlType ColumnSqlType;

	protected PrimitiveType ColumnType;

	private SqlString updateSql;

	private SqlType[] parameterTypes;

	private static IGeneratorDef generatorDef;

	internal static IdentityHiLoFromTableGenerator hoF7nNWytsJdVxM74BsT;

	public static IGeneratorDef GeneratorDef
	{
		get
		{
			int num = 1;
			int num2 = num;
			IGeneratorDef obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = generatorDef;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj = (generatorDef = (IGeneratorDef)(object)new GeneratorDefInternal());
					break;
				}
				break;
			}
			return obj;
		}
	}

	[AsyncStateMachine(typeof(_003CGenerateAsync_003Ed__0))]
	public Task<object> GenerateAsync(ISessionImplementor session, object obj, CancellationToken cancellationToken)
	{
		_003CGenerateAsync_003Ed__0 stateMachine = default(_003CGenerateAsync_003Ed__0);
		stateMachine._003C_003E4__this = this;
		stateMachine.session = session;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<object>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<object> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CDoWorkInCurrentTransactionAsync_003Ed__1))]
	public override Task<object> DoWorkInCurrentTransactionAsync(ISessionImplementor session, DbConnection conn, DbTransaction transaction, CancellationToken cancellationToken)
	{
		_003CDoWorkInCurrentTransactionAsync_003Ed__1 stateMachine = default(_003CDoWorkInCurrentTransactionAsync_003Ed__1);
		stateMachine._003C_003E4__this = this;
		stateMachine.session = session;
		stateMachine.conn = conn;
		stateMachine.transaction = transaction;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<object>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<object> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public virtual void Configure(IType type, IDictionary<string, string> parms, Dialect dialect)
	{
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected O, but got Unknown
		tableName = PropertiesHelper.GetString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108691246), parms, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103DC521));
		columnName = PropertiesHelper.GetString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234282982), parms, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269C73B4));
		whereClause = PropertiesHelper.GetString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F325422), parms, "");
		whereColumnName = PropertiesHelper.GetString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -629704320), parms, "");
		whereValue = PropertiesHelper.GetString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA5B06FD), parms, "");
		string @string = PropertiesHelper.GetString(PersistentIdGeneratorParmsNames.Schema, parms, (string)null);
		string string2 = PropertiesHelper.GetString(PersistentIdGeneratorParmsNames.Catalog, parms, (string)null);
		maxLo = PropertiesHelper.GetInt64(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822766500), parms, 32767L);
		lo = maxLo + 1;
		returnClass = type.get_ReturnedClass();
		if (tableName.IndexOf('.') < 0)
		{
			tableName = dialect.Qualify(string2, @string, tableName);
		}
		SqlStringBuilder val = new SqlStringBuilder(100);
		val.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B369309) + columnName).Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A15C1D) + tableName);
		if (!string.IsNullOrEmpty(whereClause))
		{
			val.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53D80F5)).Add(whereClause);
		}
		query = ((object)val).ToString();
		ColumnType = (PrimitiveType)(object)((type is PrimitiveType) ? type : null);
		if (ColumnType == null)
		{
			Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x31304DD2));
			throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477282074), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112702284));
		}
		if (type is Int16Type)
		{
			ColumnSqlType = SqlTypeFactory.Int16;
		}
		else if (type is Int64Type)
		{
			ColumnSqlType = SqlTypeFactory.Int64;
		}
		else
		{
			ColumnSqlType = SqlTypeFactory.Int32;
		}
		parameterTypes = (SqlType[])(object)new SqlType[2] { ColumnSqlType, ColumnSqlType };
		SqlStringBuilder val2 = new SqlStringBuilder(100);
		val2.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307CB2A7) + tableName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD77DD8)).Add(columnName).Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107938686))
			.Add(Parameter.get_Placeholder())
			.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35918459))
			.Add(columnName)
			.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571F0705))
			.Add(Parameter.get_Placeholder());
		if (!string.IsNullOrEmpty(whereClause))
		{
			val2.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7E96B4)).Add(whereClause);
		}
		updateSql = val2.ToSqlString();
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public object Generate(ISessionImplementor session, object obj)
	{
		//Discarded unreachable code: IL_017b
		int num = 2;
		int num2 = num;
		long num4 = default(long);
		long num3 = default(long);
		while (true)
		{
			switch (num2)
			{
			case 9:
				num4 = dBiDNZWy6vvBMGyeMD0i(GenerateInternal(session, obj));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				num3 = dBiDNZWy6vvBMGyeMD0i(GenerateInternal(session, obj));
				num2 = 5;
				break;
			case 2:
				if (maxLo < 1)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 1;
					}
					break;
				}
				if (lo > maxLo)
				{
					num2 = 6;
					break;
				}
				goto case 7;
			case 3:
				if (num4 != 0L)
				{
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 9;
			case 8:
				hi = num3;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return qem7EkWyHYo1MJojh5QF(num4, returnClass);
			case 4:
				Log.Debug(nJfmujWyAkNVFJCcANFW(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A631828), num3));
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				num4 = Convert.ToInt64(GenerateInternal(session, obj));
				num2 = 3;
				break;
			case 7:
				return IdentifierGeneratorFactory.CreateNumber(hi + lo++, returnClass);
			case 5:
				lo = ((num3 == 0L) ? 1 : 0);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 8;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	protected object GenerateInternal(ISessionImplementor session, object obj)
	{
		return ((TransactionHelper)this).DoWorkInNewTransaction(session);
	}

	public virtual string[] SqlCreateStrings(Dialect dialect)
	{
		return new string[2]
		{
			(string)VFKjtTWyx7wLH9wpRBQJ(new string[7]
			{
				(string)waFpDcWy7EVaLiFe1qYD(0x12A5FAC7 ^ 0x12A7D77D),
				tableName,
				(string)waFpDcWy7EVaLiFe1qYD(--1333735954 ^ 0x4F7D1FCA),
				columnName,
				(string)waFpDcWy7EVaLiFe1qYD(-1146510045 ^ -1146491903),
				dialect.GetTypeName(ColumnSqlType),
				(string)waFpDcWy7EVaLiFe1qYD(0x3A5D5EF ^ 0x3A7F80D)
			}),
			(string)SWtxGYWy08MDROkD7PQ1(waFpDcWy7EVaLiFe1qYD(0x5A4C7B29 ^ 0x5A4E56C3), tableName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488739379))
		};
	}

	public virtual string[] SqlDropString(Dialect dialect)
	{
		return new string[1] { (string)OD1lH9WymxixhW6xV74X(dialect, tableName) };
	}

	public string GeneratorKey()
	{
		return tableName;
	}

	public override object DoWorkInCurrentTransaction(ISessionImplementor session, DbConnection conn, DbTransaction transaction)
	{
		//Discarded unreachable code: IL_0096, IL_012b, IL_013a, IL_0209, IL_0278, IL_029b, IL_02dc, IL_04ab, IL_052b, IL_053e
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		int num = 5;
		int num2 = num;
		long num3 = default(long);
		DbCommand dbCommand2 = default(DbCommand);
		DbDataReader dbDataReader = default(DbDataReader);
		string text = default(string);
		DbCommand dbCommand = default(DbCommand);
		int num6 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return num3;
			case 8:
				qfJ2uLWyJSGNylCubNEX(dbCommand2, transaction);
				num2 = 12;
				break;
			case 11:
				UHdtpdWyMUUfIwAdk5QY(dbCommand2, query);
				num2 = 10;
				break;
			case 2:
				try
				{
					dbDataReader = (DbDataReader)gASccUWydVQWEr4U37D7(dbCommand2);
					int num9 = 4;
					while (true)
					{
						switch (num9)
						{
						case 1:
							text = (string)a3t1s9Wyr5wOIsHZUcIs(waFpDcWy7EVaLiFe1qYD(--1418440330 ^ 0x548980C4), tableName);
							num9 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
							{
								num9 = 6;
							}
							continue;
						case 6:
							if (JcKi5nWygyBayZLwFkIj(whereClause))
							{
								num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
								{
									num9 = 0;
								}
								continue;
							}
							goto case 7;
						default:
							Log.Error(text);
							num9 = 2;
							continue;
						case 2:
							throw new IdentifierGenerationException(text);
						case 7:
							text = text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751317206) + whereClause;
							num9 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
							{
								num9 = 5;
							}
							continue;
						case 4:
							if (UHBqmcWylZBFLiRISi9x(dbDataReader))
							{
								num3 = Convert.ToInt64(rXRwZkWy5lGq2WDWKJn0(ColumnType, dbDataReader, 0, session));
								num9 = 3;
								continue;
							}
							num9 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
							{
								num9 = 1;
							}
							continue;
						case 3:
							break;
						}
						break;
					}
				}
				catch (Exception ex2)
				{
					int num10 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num10 = 0;
					}
					while (true)
					{
						switch (num10)
						{
						case 1:
							throw;
						}
						zrF06OWyjVRXASGVMi4G(Log, waFpDcWy7EVaLiFe1qYD(-643786247 ^ -643647731), ex2);
						num10 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
						{
							num10 = 1;
						}
					}
				}
				finally
				{
					int num11;
					if (dbDataReader == null)
					{
						num11 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num11 = 1;
						}
						goto IL_027c;
					}
					goto IL_02ba;
					IL_02ba:
					uPICRHWyYBcgw06dVceP(dbDataReader);
					num11 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num11 = 0;
					}
					goto IL_027c;
					IL_027c:
					while (true)
					{
						switch (num11)
						{
						default:
							goto IL_02a9;
						case 3:
							break;
						case 2:
							goto end_IL_027c;
						}
						goto IL_02ba;
						IL_02a9:
						d0KDR8WyLKBD7a8rHsaD(dbCommand2);
						num11 = 2;
						continue;
						end_IL_027c:
						break;
					}
				}
				goto case 7;
			case 7:
				dbCommand = (DbCommand)gIXH4ZWyzWyO8WsKCYXU(Nr1DpKWycdSYkvce0ee5(G93c3EWysOoGNkA7lsqe(bIv5bHWyUAsoBaRF09lN(session))), CommandType.Text, updateSql, parameterTypes);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				if (num6 != 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 5;
			default:
				pmRcyjWMFwAOtBdxtLr3(dbCommand, conn);
				num2 = 9;
				break;
			case 9:
				qfJ2uLWyJSGNylCubNEX(dbCommand, transaction);
				num2 = 3;
				break;
			case 12:
				eCWqKMWy9q8el7oSmFvI(PersistentIdGeneratorParmsNames.SqlStatementLogger, waFpDcWy7EVaLiFe1qYD(0x1FFEF86A ^ 0x1FFCD64E), dbCommand2, FormatStyle.Basic);
				num2 = 2;
				break;
			case 3:
				try
				{
					((NullableType)ColumnType).Set(dbCommand, (object)(num3 + ((maxLo > 0) ? (maxLo + 1) : 1)), 0, session);
					int num4 = 2;
					int num5 = num4;
					while (true)
					{
						switch (num5)
						{
						default:
							eCWqKMWy9q8el7oSmFvI(PersistentIdGeneratorParmsNames.SqlStatementLogger, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882246072), dbCommand, FormatStyle.Basic);
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
							{
								num5 = 1;
							}
							continue;
						case 2:
							((NullableType)ColumnType).Set(dbCommand, (object)num3, 1, session);
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
							{
								num5 = 0;
							}
							continue;
						case 1:
							num6 = dbCommand.ExecuteNonQuery();
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
							{
								num5 = 3;
							}
							continue;
						case 3:
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					int num7 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num7 = 0;
					}
					while (true)
					{
						switch (num7)
						{
						case 1:
							zrF06OWyjVRXASGVMi4G(Log, (string)waFpDcWy7EVaLiFe1qYD(0x63ABA4E8 ^ 0x63A98BBE) + tableName, ex);
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
							{
								num7 = 0;
							}
							break;
						default:
							throw;
						}
					}
				}
				finally
				{
					d0KDR8WyLKBD7a8rHsaD(dbCommand);
					int num8 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num8 = 0;
					}
					switch (num8)
					{
					case 0:
						break;
					}
				}
				goto case 6;
			case 5:
				dbCommand2 = (DbCommand)UWL0S1WyyY3j6vF2baUn(conn);
				num2 = 4;
				break;
			case 10:
				dbCommand2.CommandType = CommandType.Text;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num2 = 3;
				}
				break;
			case 4:
				dbDataReader = null;
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 6;
				}
				break;
			}
		}
	}

	public IdentityHiLoFromTableGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		XEwKeXWMBmZvroHt5dZr();
		((TransactionHelper)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static IdentityHiLoFromTableGenerator()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				Log = Logger.GetLogger(typeof(IdentityHiLoFromTableGenerator));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static long dBiDNZWy6vvBMGyeMD0i(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static object qem7EkWyHYo1MJojh5QF(long P_0, Type P_1)
	{
		return IdentifierGeneratorFactory.CreateNumber(P_0, P_1);
	}

	internal static object nJfmujWyAkNVFJCcANFW(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static bool umlGpIWywnJQAX1v85c0()
	{
		return hoF7nNWytsJdVxM74BsT == null;
	}

	internal static IdentityHiLoFromTableGenerator edpM3UWy4Npct8E83Bnh()
	{
		return hoF7nNWytsJdVxM74BsT;
	}

	internal static object waFpDcWy7EVaLiFe1qYD(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object VFKjtTWyx7wLH9wpRBQJ(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static object SWtxGYWy08MDROkD7PQ1(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object OD1lH9WymxixhW6xV74X(object P_0, object P_1)
	{
		return ((Dialect)P_0).GetDropTableString((string)P_1);
	}

	internal static object UWL0S1WyyY3j6vF2baUn(object P_0)
	{
		return ((DbConnection)P_0).CreateCommand();
	}

	internal static void UHdtpdWyMUUfIwAdk5QY(object P_0, object P_1)
	{
		((DbCommand)P_0).CommandText = (string)P_1;
	}

	internal static void qfJ2uLWyJSGNylCubNEX(object P_0, object P_1)
	{
		((DbCommand)P_0).Transaction = (DbTransaction)P_1;
	}

	internal static void eCWqKMWy9q8el7oSmFvI(object P_0, object P_1, object P_2, object P_3)
	{
		((SqlStatementLogger)P_0).LogCommand((string)P_1, (DbCommand)P_2, (FormatStyle)P_3);
	}

	internal static object gASccUWydVQWEr4U37D7(object P_0)
	{
		return ((DbCommand)P_0).ExecuteReader();
	}

	internal static bool UHBqmcWylZBFLiRISi9x(object P_0)
	{
		return ((DbDataReader)P_0).Read();
	}

	internal static object a3t1s9Wyr5wOIsHZUcIs(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool JcKi5nWygyBayZLwFkIj(object P_0)
	{
		return ((string)P_0).IsNullOrWhiteSpace();
	}

	internal static object rXRwZkWy5lGq2WDWKJn0(object P_0, object P_1, int P_2, object P_3)
	{
		return ((NullableType)P_0).Get((DbDataReader)P_1, P_2, (ISessionImplementor)P_3);
	}

	internal static void zrF06OWyjVRXASGVMi4G(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void uPICRHWyYBcgw06dVceP(object P_0)
	{
		((DbDataReader)P_0).Close();
	}

	internal static void d0KDR8WyLKBD7a8rHsaD(object P_0)
	{
		((Component)P_0).Dispose();
	}

	internal static object bIv5bHWyUAsoBaRF09lN(object P_0)
	{
		return ((ISessionImplementor)P_0).get_Factory();
	}

	internal static object G93c3EWysOoGNkA7lsqe(object P_0)
	{
		return ((ISessionFactoryImplementor)P_0).get_ConnectionProvider();
	}

	internal static object Nr1DpKWycdSYkvce0ee5(object P_0)
	{
		return ((IConnectionProvider)P_0).get_Driver();
	}

	internal static object gIXH4ZWyzWyO8WsKCYXU(object P_0, CommandType P_1, object P_2, object P_3)
	{
		return ((IDriver)P_0).GenerateCommand(P_1, (SqlString)P_2, (SqlType[])P_3);
	}

	internal static void pmRcyjWMFwAOtBdxtLr3(object P_0, object P_1)
	{
		((DbCommand)P_0).Connection = (DbConnection)P_1;
	}

	internal static void XEwKeXWMBmZvroHt5dZr()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
