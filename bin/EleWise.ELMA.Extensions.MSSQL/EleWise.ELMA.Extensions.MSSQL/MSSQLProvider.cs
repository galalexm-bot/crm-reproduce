using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Providers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Cfg;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions.MSSQL;

[Component]
public class MSSQLProvider : NHProvider
{
	private enum CompatibilityLevel
	{
		MSSQL2008 = 100,
		MSSQL2012 = 110,
		MSSQL2014 = 120,
		MSSQL2016 = 130,
		MSSQL2017 = 140,
		MSSQL2019 = 150
	}

	private enum SQLEngineVersion
	{
		MSSQL2008 = 10,
		MSSQL2012,
		MSSQL2014,
		MSSQL2016,
		MSSQL2017,
		MSSQL2019
	}

	public const string UID_S = "{D7FCF41C-45BA-4663-AE0D-0712EFF0D145}";

	public static readonly Guid UID;

	private Dictionary<string, string> VersionToEdition;

	protected IDataBaseSettingsSection sqlSettings;

	protected ITransformationProvider provider;

	private bool initialized;

	private static MSSQLProvider LZoLZTMfSot2xulM65y;

	private MSSQLProviderImpl Impl => (MSSQLProviderImpl)((ILicensedModuleAssembly)((ComponentManager)yUaxglMlldutLiq7Y5n()).ModuleManager.FindUnitByUid(__AssemblyInfo.UID)).LicenseUnit;

	public override string ConnectionString => (string)YYqrXuMbPBKP2lBXRU6(ECMgAEMvBEE0HZbwRXI(sqlSettings));

	public override string DataProviderName => (string)H3vjvcM1E5InPkDgJVu(-1556144321 ^ -1556150505);

	public override Guid Uid => UID;

	public override string Name => SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5E19FB22 ^ 0x5E19E31C);

	protected override Version MinServerVersion => new Version(10, 0);

	protected override IMapIdentityProvider MapIdentityProvider => new MSSQLMapIdentityProvider();

	protected override Type TransformationProviderType => Fwm0OaYKayu4JOmjYXc(typeof(MSSQLTransformationProvider).TypeHandle);

	internal static string UpdateConnectionString(string connectionString)
	{
		//Discarded unreachable code: IL_006d, IL_007c, IL_00c6
		int num = 5;
		int num3 = default(int);
		SqlConnectionStringBuilder sqlConnectionStringBuilder = default(SqlConnectionStringBuilder);
		int workerThreads = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (num3 < wER6LsMPI8LsfJRdQoX(sqlConnectionStringBuilder))
					{
						num2 = 7;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ac9723878e2248bcb9bd99e393b431fd == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 3:
					num3 = workerThreads * 2;
					num2 = 1;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_eef77c3bebfa4d668f7e6bb309dba438 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					sqlConnectionStringBuilder = new SqlConnectionStringBuilder(connectionString);
					num2 = 4;
					continue;
				case 2:
				case 7:
				case 8:
					return sqlConnectionStringBuilder.ToString();
				case 4:
					if (((string)KNtmvsMSp1yXh0NDFkc(connectionString)).Contains((string)miLwRkMrYkqSEvsmkUt(H3vjvcM1E5InPkDgJVu(0x4960B0BA ^ 0x4960A8B0))))
					{
						num2 = 8;
						continue;
					}
					goto end_IL_0012;
				default:
					goto end_IL_0012;
				case 6:
					break;
				}
				sqlConnectionStringBuilder.MaxPoolSize = num3;
				num2 = 2;
				continue;
				end_IL_0012:
				break;
			}
			ThreadPool.GetMaxThreads(out workerThreads, out var _);
			num = 3;
		}
	}

	public override IProjection GenerateOrderByProjection(EntityMetadata metadata, PropertyMetadata propertyMetadata, string entityName = null, string si = null)
	{
		//Discarded unreachable code: IL_00a6, IL_00b5, IL_010b, IL_011a, IL_012c
		int num = 7;
		int num2 = num;
		IProjection val = default(IProjection);
		IMetadataRuntimeService service = default(IMetadataRuntimeService);
		IProjection prj = default(IProjection);
		while (true)
		{
			object obj;
			IProjection obj2;
			switch (num2)
			{
			case 2:
			case 4:
				obj = si;
				if (obj == null)
				{
					num2 = 8;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_5ae23e79a5ef4ec9a6a58c0daa87c096 != 0)
					{
						num2 = 8;
					}
					break;
				}
				goto IL_0137;
			case 3:
			{
				val = (IProjection)(object)NHQueryExtensions.PropertyProjection(UdFVJjM2rUlyTotDi5c(service, wJnCTiMW7Om7s3OKsf6(metadata), true), entityName, si, forOrder: true, out var _, out var _, out var _);
				num2 = 5;
				break;
			}
			case 7:
				service = Locator.GetService<IMetadataRuntimeService>();
				num2 = 6;
				break;
			case 6:
				if (XPtlw8MaVUi5RFJ3okX(entityName))
				{
					num2 = 4;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_533d0278bbeb47caa283bab50134e84d == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto default;
			default:
				if (service == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_9457c8cc16bd407492ec82836e6ece2b != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 3;
			case 5:
				obj2 = val;
				goto IL_015a;
			case 8:
				obj = mEZ7qIM7AOlsfEd273Q(propertyMetadata);
				goto IL_0137;
			case 1:
				obj2 = val;
				goto IL_015a;
			case 9:
				{
					return PrepareOrderByProjection(prj, (propertyMetadata != null) ? new Guid?(yT6xvJMzdwUAYD8eTGj(propertyMetadata)) : null);
				}
				IL_0137:
				val = (IProjection)V8TThOM3CGGfdtgT5mV(obj);
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_5ae23e79a5ef4ec9a6a58c0daa87c096 != 0)
				{
					num2 = 0;
				}
				break;
				IL_015a:
				prj = obj2;
				num2 = 9;
				break;
			}
		}
	}

	public override IProjection GenerateComparableStringProjection(IProjection propertyProjection, int maxLength = 255)
	{
		return propertyProjection;
	}

	public override ProviderSettingsSection CreateSettings()
	{
		MainBaseSettingsSection mainBaseSettingsSection = new MainBaseSettingsSection();
		t5tNlpYMpGjoUUZKwmQ(mainBaseSettingsSection, Fwm0OaYKayu4JOmjYXc(typeof(MSSQLProvider).TypeHandle));
		return mainBaseSettingsSection;
	}

	public override string GuidQuerySintaxis(Guid guid)
	{
		return (string)IifygfYYOUomKgVlhVj(guid);
	}

	protected override void InitInternal()
	{
		//Discarded unreachable code: IL_008d, IL_00bc, IL_0100, IL_015d, IL_019d, IL_01a8, IL_01b7, IL_02a8, IL_02e0, IL_0318, IL_0409, IL_0418, IL_04b8, IL_04c7, IL_04d6, IL_0632, IL_06a2, IL_06b1, IL_06e4, IL_07b3, IL_07eb, IL_086c, IL_08d0, IL_0908, IL_0917, IL_0948, IL_0980, IL_098f, IL_09ba, IL_09d1, IL_0a17, IL_0a81, IL_0acb
		int num = 25;
		SqlConnection sqlConnection2 = default(SqlConnection);
		bool flag2 = default(bool);
		IStartInformation startInformation = default(IStartInformation);
		int num11 = default(int);
		bool flag = default(bool);
		string text = default(string);
		IDbCommand dbCommand = default(IDbCommand);
		SqlConnectionStringBuilder sqlConnectionStringBuilder = default(SqlConnectionStringBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					try
					{
						((ILogger)mFHkGpYNwbCdyDMWDuV()).Debug(H3vjvcM1E5InPkDgJVu(0x6080D1CC ^ 0x6080CB82));
						int num12 = 2;
						while (true)
						{
							switch (num12)
							{
							case 3:
								try
								{
									unpKt8YOHKQY822xlD0(sqlConnection2);
									int num13 = 0;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_b98765ef3c444c499e843eecd7ad6cc5 != 0)
									{
										num13 = 0;
									}
									while (true)
									{
										switch (num13)
										{
										default:
											uHGsBbYCl1p2loaTHto(sqlConnection2);
											num13 = 1;
											if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_db0266f588ec4dba9939e9dffe57b346 != 0)
											{
												num13 = 1;
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
									int num14;
									if (sqlConnection2 == null)
									{
										num14 = 0;
										if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_b4635cff01354ae4b0b87f6365b6f3d3 != 0)
										{
											num14 = 0;
										}
										goto IL_0161;
									}
									goto IL_0177;
									IL_0177:
									KUYLCLYjrCZMaaoG0oQ(sqlConnection2);
									num14 = 1;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_7b9eb7c7ce494b779c3d495b11db0ee8 == 0)
									{
										num14 = 0;
									}
									goto IL_0161;
									IL_0161:
									switch (num14)
									{
									default:
										goto end_IL_013c;
									case 2:
										break;
									case 0:
										goto end_IL_013c;
									case 1:
										goto end_IL_013c;
									}
									goto IL_0177;
									end_IL_013c:;
								}
								goto default;
							default:
								AG1rkFYJTKhRBuAvbAY(Logger.Log, H3vjvcM1E5InPkDgJVu(-15819198 ^ -15825710));
								num12 = 4;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_b98765ef3c444c499e843eecd7ad6cc5 == 0)
								{
									num12 = 0;
								}
								continue;
							case 2:
								sqlConnection2 = new SqlConnection(ConnectionString);
								num12 = 3;
								continue;
							case 4:
								flag2 = true;
								num12 = 0;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ac8b4db689fb4d85a7bb7ce35db5e4d5 == 0)
								{
									num12 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					catch (Exception ex2)
					{
						int num15 = 1;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_2ab8f47a08004d748d8cbfeb51d65089 != 0)
						{
							num15 = 1;
						}
						while (true)
						{
							switch (num15)
							{
							case 8:
								try
								{
									CreateDatabase(ConnectionString);
									int num17 = 0;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_3f149d3899664c3e92db5de6fde4f35a != 0)
									{
										num17 = 0;
									}
									switch (num17)
									{
									case 0:
										break;
									}
								}
								finally
								{
									if (startInformation != null)
									{
										int num18 = 0;
										if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_38564d6ade73482fadcc5aedb5edd1aa != 0)
										{
											num18 = 0;
										}
										while (true)
										{
											switch (num18)
											{
											default:
												KUYLCLYjrCZMaaoG0oQ(startInformation);
												num18 = 0;
												if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_50026842ab044d008d304fc8fda891b4 == 0)
												{
													num18 = 1;
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
							case 9:
								if (!XD4XoWYIjAUiuqwYP8s(q5HnTHYuE4TJWm4DcnR(this)))
								{
									num15 = 0;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_0e8b96b511f849c7b3cd2b1ffcea4179 != 0)
									{
										num15 = 0;
									}
									continue;
								}
								break;
							case 4:
								lNSulkYL7hA0IByVTr4(mFHkGpYNwbCdyDMWDuV(), H3vjvcM1E5InPkDgJVu(--471720024 ^ 0x1C1DFA98), ex2);
								num15 = 1;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_01fcbf7f4c0245c8970ab01c215239fb == 0)
								{
									num15 = 3;
								}
								continue;
							default:
							{
								startInformation = (IStartInformation)dc5CgVYTAjYhLLV7xmD(1.0, k7yvp8Yw7OAcaaerP6y(H3vjvcM1E5InPkDgJVu(-1513901977 ^ -1513903161)));
								int num16 = 8;
								num15 = num16;
								continue;
							}
							case 1:
								if (num11 >= bPfHWaYoPqQOAyZKRwc(sqlSettings))
								{
									num15 = 4;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_992aa32d3a3449929072ecd77a2ed007 == 0)
									{
										num15 = 1;
									}
									continue;
								}
								Logger.Log.Warn(KWIZtAYd7UOYhhi8TDM(H3vjvcM1E5InPkDgJVu(-2056810441 ^ -2056811651), num11, H3vjvcM1E5InPkDgJVu(-1505501660 ^ -1505507906)), ex2);
								num15 = 4;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_c2cab395bbae4d16ab33c46363a0e09f != 0)
								{
									num15 = 7;
								}
								continue;
							case 7:
								if (flag)
								{
									num15 = 4;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_7d9c3f1bd5704dffa8a30fba06b99cdf == 0)
									{
										num15 = 5;
									}
									continue;
								}
								goto case 9;
							case 3:
								throw new InvalidOperationException((string)TtsbdxYk72m5JmlTVXk(H3vjvcM1E5InPkDgJVu(-1218069071 ^ -1218074803)), ex2);
							case 5:
							case 6:
								break;
							case 2:
								goto end_IL_024f;
							}
							c2S0FWYQ6GVg0MYrc0b(sqlSettings.ConnectionAttemptInverval * 1000);
							num15 = 2;
							continue;
							end_IL_024f:
							break;
						}
					}
					goto case 1;
				case 6:
					return;
				case 14:
					initialized = true;
					num = 21;
					break;
				case 18:
					flag2 = false;
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_992aa32d3a3449929072ecd77a2ed007 != 0)
					{
						num2 = 1;
					}
					continue;
				case 25:
					eRdk3DYtUIiOZgZuR6Q(sqlSettings, H3vjvcM1E5InPkDgJVu(0x29617E28 ^ 0x29616666));
					num2 = 24;
					continue;
				case 2:
				case 26:
					num11 = 0;
					num2 = 6;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_88b018be80f64052a4b6364462094eef == 0)
					{
						num2 = 18;
					}
					continue;
				case 22:
					if (num11 >= sqlSettings.ConnectionAttemptCount)
					{
						num2 = 19;
						continue;
					}
					goto case 7;
				case 7:
					num11++;
					num2 = 10;
					continue;
				case 1:
				case 9:
					if (!flag2)
					{
						num2 = 22;
						continue;
					}
					return;
				case 24:
					if (initialized)
					{
						return;
					}
					num = 14;
					break;
				case 16:
					flag = false;
					num2 = 12;
					continue;
				case 20:
					if (XPtlw8MaVUi5RFJ3okX(text))
					{
						num2 = 13;
						continue;
					}
					goto case 23;
				case 12:
					if (!Cp0Bs1Y8kDK34PVf7pW(sqlSettings))
					{
						num2 = 23;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_610637caa58f480dbbd64235291b457a != 0)
						{
							num2 = 26;
						}
						continue;
					}
					goto case 8;
				default:
					BGcm7LYEDE0NMFb7WtT(Logger.Log, H3vjvcM1E5InPkDgJVu(-512790910 ^ -512788758));
					num2 = 1;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a1374360d15f4247b418e6f0fa5eef4e == 0)
					{
						num2 = 5;
					}
					continue;
				case 13:
				case 17:
					CreateDatabase((string)q5HnTHYuE4TJWm4DcnR(this));
					num2 = 4;
					continue;
				case 21:
					MmhxNSYZoLPQaysaHCY(this);
					num = 16;
					break;
				case 3:
					if (XD4XoWYIjAUiuqwYP8s(q5HnTHYuE4TJWm4DcnR(this)))
					{
						num2 = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_5bd098bed6154f4ea8b455a24c427093 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 20;
				case 8:
					text = null;
					num2 = 3;
					continue;
				case 5:
					try
					{
						SqlConnectionStringBuilder sqlConnectionStringBuilder2 = new SqlConnectionStringBuilder(ConnectionString);
						int num3 = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_aa8cb810f1524b20abd541fee0197a14 == 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								if (XPtlw8MaVUi5RFJ3okX(DjRmOXY90MfP2yGl7O2(sqlConnectionStringBuilder2)))
								{
									num3 = 3;
									continue;
								}
								goto case 2;
							case 2:
								OVAZ16YxnG5pyQ7KpAl(q5HnTHYuE4TJWm4DcnR(this));
								num3 = 6;
								continue;
							case 6:
								c2S0FWYQ6GVg0MYrc0b(2500);
								num3 = 0;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a9455caf5a604783b3a743f491182420 != 0)
								{
									num3 = 0;
								}
								continue;
							default:
								BGcm7LYEDE0NMFb7WtT(Logger.Log, H3vjvcM1E5InPkDgJVu(-564335650 ^ -564333984));
								num3 = 5;
								continue;
							case 4:
								try
								{
									SqlConnection sqlConnection = new SqlConnection((string)RIa5OLYnwvpkKTHFYjw(q5HnTHYuE4TJWm4DcnR(this)));
									int num4 = 0;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_c4f350cb93ad41c2a93de4e094bd3eae == 0)
									{
										num4 = 0;
									}
									switch (num4)
									{
									default:
										try
										{
											unpKt8YOHKQY822xlD0(sqlConnection);
											int num5 = 1;
											if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_7b9eb7c7ce494b779c3d495b11db0ee8 == 0)
											{
												num5 = 0;
											}
											while (true)
											{
												switch (num5)
												{
												case 1:
													goto IL_0805;
												case 2:
													try
													{
														dbCommand.CommandText = (string)TETXHFYApkMv9ETfRmj(H3vjvcM1E5InPkDgJVu(0x43EF8209 ^ 0x43EF9A9D), mSkmnIYyRYr4FF6Iux4(sqlConnectionStringBuilder2), H3vjvcM1E5InPkDgJVu(-786261895 ^ -786267661));
														int num6 = 1;
														if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_88b018be80f64052a4b6364462094eef == 0)
														{
															num6 = 1;
														}
														while (true)
														{
															switch (num6)
															{
															case 1:
																text = (string)dbCommand.ExecuteScalar();
																num6 = 0;
																if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_9457c8cc16bd407492ec82836e6ece2b == 0)
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
													finally
													{
														if (dbCommand != null)
														{
															int num7 = 1;
															if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_536a197f18c04d92abf9ab236ddc733a != 0)
															{
																num7 = 1;
															}
															while (true)
															{
																switch (num7)
																{
																case 1:
																	KUYLCLYjrCZMaaoG0oQ(dbCommand);
																	num7 = 0;
																	if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_25f0dcdb5c5e4e6fbd7fee91aad234f3 != 0)
																	{
																		num7 = 0;
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
												case 0:
													break;
												}
												break;
												IL_0805:
												dbCommand = sqlConnection.CreateCommand();
												num5 = 2;
											}
										}
										finally
										{
											if (sqlConnection != null)
											{
												int num8 = 1;
												if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_4599535ffcb34731ae493be59317478a == 0)
												{
													num8 = 1;
												}
												while (true)
												{
													switch (num8)
													{
													case 1:
														KUYLCLYjrCZMaaoG0oQ(sqlConnection);
														num8 = 0;
														if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a2b331cfbee74083865b99663c080fcb != 0)
														{
															num8 = 0;
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
									case 1:
										break;
									}
								}
								catch
								{
									int num9 = 0;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_0d93129ec5af4fc5926990956e624437 == 0)
									{
										num9 = 0;
									}
									switch (num9)
									{
									case 0:
										break;
									}
								}
								goto case 2;
							case 3:
								if (!string.IsNullOrEmpty((string)mSkmnIYyRYr4FF6Iux4(sqlConnectionStringBuilder2)))
								{
									num3 = 4;
									continue;
								}
								goto case 2;
							case 5:
								break;
							}
							break;
						}
					}
					catch (Exception ex)
					{
						int num10 = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_1ac7b80080314bbdb29619485c5fbb66 == 0)
						{
							num10 = 0;
						}
						while (true)
						{
							switch (num10)
							{
							case 1:
								throw new InvalidOperationException((string)TtsbdxYk72m5JmlTVXk(H3vjvcM1E5InPkDgJVu(0x44957A45 ^ 0x44956049)), ex);
							}
							lNSulkYL7hA0IByVTr4(mFHkGpYNwbCdyDMWDuV(), H3vjvcM1E5InPkDgJVu(0x4152E1C2 ^ 0x4152F820), ex);
							num10 = 1;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ac8b4db689fb4d85a7bb7ce35db5e4d5 == 0)
							{
								num10 = 1;
							}
						}
					}
					goto case 20;
				case 15:
					CreateDatabase(sqlConnectionStringBuilder.ConnectionString);
					num2 = 11;
					continue;
				case 23:
				{
					SqlConnectionStringBuilder sqlConnectionStringBuilder3 = new SqlConnectionStringBuilder((string)q5HnTHYuE4TJWm4DcnR(this));
					vJplJKY6TWx6iGoRF3o(sqlConnectionStringBuilder3, text);
					sqlConnectionStringBuilder = sqlConnectionStringBuilder3;
					num = 15;
					break;
				}
				case 19:
					return;
				case 4:
				case 11:
					flag = true;
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	public override void Configure(ProviderSettingsSection settings, RuntimeConfiguration configuration)
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
				z4YH7RYgstiBPG3Tt5d(this, settings, configuration);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_937e86e483374781b74ae1d5b232cdfa != 0)
				{
					num2 = 0;
				}
				break;
			default:
				sqlSettings = (IDataBaseSettingsSection)settings;
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_537fedc41bac4a50bc41e21f4171db7f == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	protected override void Configure(Configuration cfg)
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
				BRqg4aYRdDlH2tVwVqR(Impl, cfg, sqlSettings);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ee3b4c6a3b0041bfaa9b5ce28a8e6629 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override ITransformationProvider CreateTransformationProvider()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return new MSSQLTransformationProvider(() => new SqlConnection((string)q5HnTHYuE4TJWm4DcnR(this)));
			case 1:
				rJPLmPYV7lcRy2PQa5r(this);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_3af97e9a57d2492f8793e39a552f0f48 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected static string BuildAttachDatabaseCommand(string dbFileName, ref string dbName, string logFileName = null)
	{
		//Discarded unreachable code: IL_011d
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				pFtgFRYUUa7oGpSuDDd(dbFileName, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E17A152 ^ 0x7E17BA9E));
				num2 = 4;
				continue;
			case 3:
			case 6:
				if (string.IsNullOrEmpty(logFileName))
				{
					num2 = 2;
					continue;
				}
				goto case 1;
			default:
				if (!XPtlw8MaVUi5RFJ3okX(dbName))
				{
					num2 = 3;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_611f69e7a7a34a4fbeb0099afc53aecd == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 1:
			{
				StringBuilder stringBuilder = new StringBuilder();
				LRJp7BYHwBoXQApG6aj(stringBuilder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x27751E21 ^ 0x27750205));
				stringBuilder.Append(dbName);
				LRJp7BYHwBoXQApG6aj(stringBuilder, H3vjvcM1E5InPkDgJVu(0x5766B69D ^ 0x5766AAD7));
				LRJp7BYHwBoXQApG6aj(stringBuilder, dbFileName);
				LRJp7BYHwBoXQApG6aj(stringBuilder, H3vjvcM1E5InPkDgJVu(0x483FFC8B ^ 0x483FE0FB));
				stringBuilder.Append(logFileName);
				stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2E102DC0 ^ 0x2E103154));
				return stringBuilder.ToString();
			}
			case 4:
				Contract.CheckWithMessage<FileNotFoundException>(UIbei9YGrXL9OycCDLy(dbFileName), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1179530319 ^ -1179529131), dbFileName));
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_53c81d4dd9814619a62ac7ac8ba96c27 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				logFileName = (string)vdsgNOYhWQMMKPkwNAV(DxiMPbY4EviB8Omyr5I(dbFileName), GZtaU5YeJyAZiqCWIYQ(q2sUCWYia3CP80HMrUM(dbFileName), H3vjvcM1E5InPkDgJVu(-786261895 ^ -786267031)));
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_b14550e4462b4c7190663aa2ba86338f == 0)
				{
					num2 = 1;
				}
				continue;
			case 7:
				break;
			}
			dbName = (string)q2sUCWYia3CP80HMrUM(vH9AtVYFqP8KoN2mvwa());
			num2 = 6;
		}
	}

	protected static string BuildCreateDatabaseCommand(string connectionString, SqlConnection connection)
	{
		//Discarded unreachable code: IL_0191, IL_01a0, IL_0340, IL_034f, IL_037b, IL_03a5, IL_057e
		int num = 2;
		StringBuilder stringBuilder = default(StringBuilder);
		string text = default(string);
		SqlConnectionStringBuilder sqlConnectionStringBuilder = default(SqlConnectionStringBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 32:
					LRJp7BYHwBoXQApG6aj(stringBuilder, H3vjvcM1E5InPkDgJVu(0x5D699727 ^ 0x5D698A7F));
					num2 = 10;
					continue;
				case 27:
					if (int.Parse((string)((object[])fTrS9xYpOurLSC9r30t(connection.ServerVersion, new string[1] { (string)H3vjvcM1E5InPkDgJVu(-1110620200 ^ -1110615518) }, StringSplitOptions.None))[0]) < 11)
					{
						num2 = 30;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_320834a8cf884af9b8ab446a590e0483 != 0)
						{
							num2 = 22;
						}
						continue;
					}
					goto case 33;
				case 31:
					LRJp7BYHwBoXQApG6aj(stringBuilder, H3vjvcM1E5InPkDgJVu(0x483FFC8B ^ 0x483FE167));
					num2 = 5;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a88ccd6fbe9d4d31ba568282bf848b44 == 0)
					{
						num2 = 2;
					}
					continue;
				case 8:
					LRJp7BYHwBoXQApG6aj(stringBuilder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--471720024 ^ 0x1C1DFDDC));
					num = 35;
					break;
				case 10:
					LRJp7BYHwBoXQApG6aj(stringBuilder, text);
					num2 = 8;
					continue;
				case 23:
				case 26:
					stringBuilder = new StringBuilder();
					num2 = 14;
					continue;
				case 17:
				case 30:
					if (l1307HYsZHBAFw9BBlL(sqlConnectionStringBuilder))
					{
						num2 = 24;
						continue;
					}
					goto case 6;
				case 2:
					sqlConnectionStringBuilder = new SqlConnectionStringBuilder(connectionString);
					num2 = 1;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_2059ad9f6d154822929fea8fa23b2b60 != 0)
					{
						num2 = 0;
					}
					continue;
				case 19:
					if (XPtlw8MaVUi5RFJ3okX(mSkmnIYyRYr4FF6Iux4(sqlConnectionStringBuilder)))
					{
						num2 = 25;
						continue;
					}
					goto case 23;
				case 28:
					throw new InvalidOperationException((string)TtsbdxYk72m5JmlTVXk(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1676901510 ^ -1676894264)));
				case 13:
					text = (string)mSkmnIYyRYr4FF6Iux4(sqlConnectionStringBuilder);
					num2 = 9;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ca63e6162aaa4aaeaa1385bd9f3ad6e0 != 0)
					{
						num2 = 9;
					}
					continue;
				case 16:
					LRJp7BYHwBoXQApG6aj(stringBuilder, XPQsgvYcVnaLYr5QBP0(DjRmOXY90MfP2yGl7O2(sqlConnectionStringBuilder), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1296333093 ^ -1296327877)));
					num2 = 31;
					continue;
				case 22:
					LRJp7BYHwBoXQApG6aj(stringBuilder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2078768493 ^ -2078764219));
					num2 = 36;
					continue;
				case 36:
					LRJp7BYHwBoXQApG6aj(stringBuilder, H3vjvcM1E5InPkDgJVu(-174174226 ^ -174173068));
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_25f0dcdb5c5e4e6fbd7fee91aad234f3 == 0)
					{
						num2 = 0;
					}
					continue;
				case 14:
					LRJp7BYHwBoXQApG6aj(stringBuilder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2032417070 ^ -2032411914));
					num2 = 7;
					continue;
				case 15:
				case 34:
					stringBuilder.Append((string)H3vjvcM1E5InPkDgJVu(-391025629 ^ -391024237));
					num2 = 12;
					continue;
				case 21:
					LRJp7BYHwBoXQApG6aj(stringBuilder, H3vjvcM1E5InPkDgJVu(-1117619588 ^ -1117624344));
					num2 = 16;
					continue;
				case 6:
				case 11:
					return stringBuilder.ToString();
				case 12:
					LRJp7BYHwBoXQApG6aj(stringBuilder, text);
					num2 = 20;
					continue;
				case 24:
					if (!XPtlw8MaVUi5RFJ3okX(mSkmnIYyRYr4FF6Iux4(sqlConnectionStringBuilder)))
					{
						num2 = 11;
						continue;
					}
					goto case 3;
				case 3:
					TSFKulYBgmC2IY4gj3b(stringBuilder, TETXHFYApkMv9ETfRmj(H3vjvcM1E5InPkDgJVu(-2078768493 ^ -2078761913), text, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-174174226 ^ -174173930)));
					num2 = 18;
					continue;
				case 35:
					LRJp7BYHwBoXQApG6aj(stringBuilder, H3vjvcM1E5InPkDgJVu(0x1FD7E9B3 ^ 0x1FD7F427));
					num = 4;
					break;
				case 7:
					LRJp7BYHwBoXQApG6aj(stringBuilder, text);
					num2 = 32;
					continue;
				case 25:
					text = (string)q2sUCWYia3CP80HMrUM(vH9AtVYFqP8KoN2mvwa());
					num = 26;
					break;
				case 4:
					LRJp7BYHwBoXQApG6aj(stringBuilder, DjRmOXY90MfP2yGl7O2(sqlConnectionStringBuilder));
					num2 = 22;
					continue;
				default:
					if (!l1307HYsZHBAFw9BBlL(sqlConnectionStringBuilder))
					{
						num2 = 15;
						continue;
					}
					goto case 29;
				case 1:
					if (!string.IsNullOrEmpty((string)DjRmOXY90MfP2yGl7O2(sqlConnectionStringBuilder)))
					{
						num2 = 13;
						continue;
					}
					goto case 28;
				case 18:
					TSFKulYBgmC2IY4gj3b(stringBuilder, TETXHFYApkMv9ETfRmj(H3vjvcM1E5InPkDgJVu(-1869634592 ^ -1869628240), text, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x202D46BC ^ 0x202D592C)));
					num2 = 6;
					continue;
				case 29:
					if (!XPtlw8MaVUi5RFJ3okX(mSkmnIYyRYr4FF6Iux4(sqlConnectionStringBuilder)))
					{
						num2 = 34;
						continue;
					}
					goto case 5;
				case 5:
					TSFKulYBgmC2IY4gj3b(stringBuilder, H3vjvcM1E5InPkDgJVu(0x7323CF8E ^ 0x7323D27A));
					num2 = 27;
					continue;
				case 9:
					if (!l1307HYsZHBAFw9BBlL(sqlConnectionStringBuilder))
					{
						num2 = 23;
						continue;
					}
					goto case 19;
				case 20:
					stringBuilder.Append((string)H3vjvcM1E5InPkDgJVu(0x2E102DC0 ^ 0x2E103012));
					num = 21;
					break;
				case 33:
					TSFKulYBgmC2IY4gj3b(stringBuilder, GQ5ok4YXmEH7hD3uEaK(H3vjvcM1E5InPkDgJVu(0x5A09CFB9 ^ 0x5A09D1B9), text, 110));
					num2 = 10;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_7d9c3f1bd5704dffa8a30fba06b99cdf == 0)
					{
						num2 = 17;
					}
					continue;
				}
				break;
			}
		}
	}

	protected static bool IsDatabaseExists(string connectionString)
	{
		//Discarded unreachable code: IL_007e, IL_008d, IL_00ec, IL_011f, IL_0160, IL_016f, IL_0215, IL_0393, IL_03d3, IL_03e2, IL_040f, IL_042e, IL_043d, IL_0476, IL_04a6, IL_04b5
		int num = 2;
		int num2 = num;
		bool result = default(bool);
		SqlConnection sqlConnection = default(SqlConnection);
		SqlCommand sqlCommand = default(SqlCommand);
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder(connectionString);
					int num3 = 5;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_eef77c3bebfa4d668f7e6bb309dba438 != 0)
					{
						num3 = 7;
					}
					while (true)
					{
						switch (num3)
						{
						case 6:
							if (!XPtlw8MaVUi5RFJ3okX(DjRmOXY90MfP2yGl7O2(sqlConnectionStringBuilder)))
							{
								num3 = 4;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_9b1d47db702148b5af71c10bd42d90c2 == 0)
								{
									num3 = 3;
								}
								continue;
							}
							goto case 1;
						case 4:
							try
							{
								result = UIbei9YGrXL9OycCDLy(DjRmOXY90MfP2yGl7O2(sqlConnectionStringBuilder));
								int num5 = 0;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bc105917f678426d88a775d433c07fc2 != 0)
								{
									num5 = 0;
								}
								return num5 switch
								{
									0 => result, 
									_ => result, 
								};
							}
							catch (Exception message)
							{
								int num6 = 1;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_d2ea3571782f460a8fcf4212c4b89aef == 0)
								{
									num6 = 1;
								}
								while (true)
								{
									switch (num6)
									{
									case 1:
										Logger.Log.Debug(message);
										num6 = 0;
										if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a66ccd03acd144368047b44c2d5d0065 == 0)
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
							goto case 3;
						case 3:
							result = false;
							num3 = 5;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_0d427f376f09408b923d32447c167eeb == 0)
							{
								num3 = 5;
							}
							continue;
						case 2:
							if (XPtlw8MaVUi5RFJ3okX(mSkmnIYyRYr4FF6Iux4(sqlConnectionStringBuilder)))
							{
								num3 = 6;
								continue;
							}
							goto case 1;
						case 1:
							sqlConnection = new SqlConnection((string)RIa5OLYnwvpkKTHFYjw(connectionString));
							num3 = 0;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ec5f92fd6ddb449a9afc09c18f0a77db != 0)
							{
								num3 = 0;
							}
							continue;
						case 7:
							if (l1307HYsZHBAFw9BBlL(sqlConnectionStringBuilder))
							{
								int num4 = 2;
								num3 = num4;
								continue;
							}
							goto case 1;
						case 5:
							return result;
						}
						try
						{
							unpKt8YOHKQY822xlD0(sqlConnection);
							int num7 = 0;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a88af087375c48b1b8354e3e8d657ff7 == 0)
							{
								num7 = 0;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									sqlCommand = sqlConnection.CreateCommand();
									num7 = 1;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_6e4085613a434991b7308d69af884312 == 0)
									{
										num7 = 1;
									}
									break;
								case 1:
									try
									{
										JP9cJVY58BLeUwi9JLZ(sqlCommand, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-318240169 ^ -318231977));
										int num8 = 3;
										while (true)
										{
											switch (num8)
											{
											case 1:
												result = flag;
												num8 = 4;
												break;
											default:
											{
												flag = Convert.ToInt32(fx0aeCYDZqWGNhwXU7Z(sqlCommand)) > 0;
												int num9 = 2;
												num8 = num9;
												break;
											}
											case 3:
												((SqlParameterCollection)in7BKKYqDY58KlrRQXm(sqlCommand)).Add(new SqlParameter((string)H3vjvcM1E5InPkDgJVu(0x36554C4C ^ 0x36556C3C), mSkmnIYyRYr4FF6Iux4(sqlConnectionStringBuilder)));
												num8 = 0;
												if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_762cf717254743a4a1d5f3fcfeb2849f == 0)
												{
													num8 = 0;
												}
												break;
											case 2:
												((ILogger)mFHkGpYNwbCdyDMWDuV()).Debug(GZtaU5YeJyAZiqCWIYQ(H3vjvcM1E5InPkDgJVu(-1374979190 ^ -1374987510), flag ? SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A09CFB9 ^ 0x5A09EF01) : H3vjvcM1E5InPkDgJVu(-1239877681 ^ -1239885991)));
												num8 = 1;
												if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_f2714faf8916422f9e6c3d85072d62cb != 0)
												{
													num8 = 1;
												}
												break;
											case 4:
												return result;
											}
										}
									}
									finally
									{
										int num10;
										if (sqlCommand == null)
										{
											num10 = 2;
											if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_537fedc41bac4a50bc41e21f4171db7f != 0)
											{
												num10 = 1;
											}
											goto IL_0397;
										}
										goto IL_03ad;
										IL_03ad:
										KUYLCLYjrCZMaaoG0oQ(sqlCommand);
										num10 = 0;
										if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a66ccd03acd144368047b44c2d5d0065 != 0)
										{
											num10 = 0;
										}
										goto IL_0397;
										IL_0397:
										switch (num10)
										{
										default:
											goto end_IL_0372;
										case 1:
											break;
										case 2:
											goto end_IL_0372;
										case 0:
											goto end_IL_0372;
										}
										goto IL_03ad;
										end_IL_0372:;
									}
								}
							}
						}
						finally
						{
							int num11;
							if (sqlConnection == null)
							{
								num11 = 1;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_d77c90c2b1934f16bf9cfe858d8dba6d == 0)
								{
									num11 = 1;
								}
								goto IL_0413;
							}
							goto IL_0448;
							IL_0448:
							((IDisposable)sqlConnection).Dispose();
							num11 = 2;
							goto IL_0413;
							IL_0413:
							switch (num11)
							{
							case 1:
								goto end_IL_03ee;
							case 2:
								goto end_IL_03ee;
							}
							goto IL_0448;
							end_IL_03ee:;
						}
					}
				}
				catch (Exception innerException)
				{
					int num12 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_eef77c3bebfa4d668f7e6bb309dba438 == 0)
					{
						num12 = 0;
					}
					switch (num12)
					{
					default:
						throw new InvalidOperationException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x671942FC ^ 0x67196236), innerException);
					}
				}
			default:
				return result;
			case 2:
				((ILogger)mFHkGpYNwbCdyDMWDuV()).Debug(H3vjvcM1E5InPkDgJVu(0x1ACAC88E ^ 0x1ACAD748));
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_c07718730a1849a8a092e51c2522f212 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected static void DropDatabase(string connectionString)
	{
		//Discarded unreachable code: IL_00c5, IL_00f3, IL_0148, IL_01b4, IL_02b8, IL_02f0, IL_0354, IL_0394, IL_03a3, IL_03af, IL_03f7, IL_0448, IL_0457, IL_04af, IL_0567, IL_05ed, IL_0646, IL_067e, IL_0748, IL_0757, IL_077d, IL_078c, IL_07d3, IL_0852, IL_08e9, IL_0942, IL_097a
		int num = 16;
		int num2 = num;
		string connectionString2 = default(string);
		SqlConnection sqlConnection = default(SqlConnection);
		IDbCommand dbCommand3 = default(IDbCommand);
		SqlConnectionStringBuilder sqlConnectionStringBuilder = default(SqlConnectionStringBuilder);
		bool flag = default(bool);
		SqlConnection sqlConnection2 = default(SqlConnection);
		IDbCommand dbCommand2 = default(IDbCommand);
		string dbName = default(string);
		IDbCommand dbCommand = default(IDbCommand);
		while (true)
		{
			switch (num2)
			{
			case 16:
				connectionString2 = BuildMasterConnectionString(connectionString);
				num2 = 6;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_d2ea3571782f460a8fcf4212c4b89aef != 0)
				{
					num2 = 15;
				}
				break;
			case 12:
				sqlConnection = new SqlConnection(connectionString2);
				num2 = 8;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a9455caf5a604783b3a743f491182420 == 0)
				{
					num2 = 2;
				}
				break;
			case 6:
				return;
			case 17:
				return;
			case 7:
				try
				{
					SqlConnection sqlConnection3 = new SqlConnection(connectionString2);
					int num11 = 1;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_273c06d8704c4280a5fc2b25c62f33f4 != 0)
					{
						num11 = 1;
					}
					while (true)
					{
						switch (num11)
						{
						default:
							goto end_IL_00f7;
						case 1:
							try
							{
								BGcm7LYEDE0NMFb7WtT(mFHkGpYNwbCdyDMWDuV(), GZtaU5YeJyAZiqCWIYQ(H3vjvcM1E5InPkDgJVu(0x2F47749 ^ 0x2F4564F), connectionString));
								int num12 = 0;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_eef77c3bebfa4d668f7e6bb309dba438 == 0)
								{
									num12 = 0;
								}
								while (true)
								{
									switch (num12)
									{
									case 1:
										try
										{
											I3HudpYf6JU46jZPmdu(dbCommand3, TETXHFYApkMv9ETfRmj(H3vjvcM1E5InPkDgJVu(-2056810441 ^ -2056810781), DjRmOXY90MfP2yGl7O2(sqlConnectionStringBuilder), H3vjvcM1E5InPkDgJVu(0x53BC9C29 ^ 0x53BCBD7F)));
											int num13 = 2;
											if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_3af97e9a57d2492f8793e39a552f0f48 == 0)
											{
												num13 = 0;
											}
											while (true)
											{
												switch (num13)
												{
												case 2:
													SIAKQ2Y0UuH3HwkWgKf(dbCommand3);
													num13 = 4;
													continue;
												case 4:
													dbCommand3.CommandText = (string)TETXHFYApkMv9ETfRmj(H3vjvcM1E5InPkDgJVu(0x4CDC671 ^ 0x4CDE7DD), DjRmOXY90MfP2yGl7O2(sqlConnectionStringBuilder), H3vjvcM1E5InPkDgJVu(-813696680 ^ -813700834));
													num13 = 3;
													if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_937e86e483374781b74ae1d5b232cdfa == 0)
													{
														num13 = 2;
													}
													continue;
												default:
													BGcm7LYEDE0NMFb7WtT(mFHkGpYNwbCdyDMWDuV(), H3vjvcM1E5InPkDgJVu(0x341D5AB0 ^ 0x341D7B7E));
													num13 = 1;
													if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_320834a8cf884af9b8ab446a590e0483 != 0)
													{
														num13 = 0;
													}
													continue;
												case 3:
													dbCommand3.ExecuteNonQuery();
													num13 = 0;
													if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_db0266f588ec4dba9939e9dffe57b346 == 0)
													{
														num13 = 0;
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
											if (dbCommand3 != null)
											{
												int num14 = 0;
												if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_992aa32d3a3449929072ecd77a2ed007 == 0)
												{
													num14 = 0;
												}
												while (true)
												{
													switch (num14)
													{
													default:
														KUYLCLYjrCZMaaoG0oQ(dbCommand3);
														num14 = 1;
														if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_4d5fabaf870f450c93de24e9225e7993 != 0)
														{
															num14 = 1;
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
									default:
										unpKt8YOHKQY822xlD0(sqlConnection3);
										num12 = 1;
										if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_da020ace8b12415a904b6d9c77d7515c == 0)
										{
											num12 = 3;
										}
										continue;
									case 3:
										dbCommand3 = sqlConnection3.CreateCommand();
										num12 = 1;
										if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_3f5427a24f2948678f15f0286379c485 != 0)
										{
											num12 = 1;
										}
										continue;
									case 2:
										break;
									}
									break;
								}
							}
							finally
							{
								int num15;
								if (sqlConnection3 == null)
								{
									num15 = 2;
									goto IL_0358;
								}
								goto IL_036e;
								IL_0358:
								switch (num15)
								{
								default:
									goto end_IL_0343;
								case 1:
									break;
								case 2:
									goto end_IL_0343;
								case 0:
									goto end_IL_0343;
								}
								goto IL_036e;
								IL_036e:
								KUYLCLYjrCZMaaoG0oQ(sqlConnection3);
								num15 = 0;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_846eae8b3f494ae2b3aeba9a1f80b104 == 0)
								{
									num15 = 0;
								}
								goto IL_0358;
								end_IL_0343:;
							}
							break;
						case 2:
							break;
						case 0:
							goto end_IL_00f7;
						}
						flag = true;
						num11 = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_9f50fa62c83545aa885cad260f298366 == 0)
						{
							num11 = 0;
						}
						continue;
						end_IL_00f7:
						break;
					}
				}
				catch (Exception ex)
				{
					int num16 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_81833be823b44351b330d2171723abb3 == 0)
					{
						num16 = 0;
					}
					while (true)
					{
						switch (num16)
						{
						default:
							JN7CkMYmTPHMdJ6dAUp(mFHkGpYNwbCdyDMWDuV(), H3vjvcM1E5InPkDgJVu(0x1D5BEF19 ^ 0x1D5BCD15), ex);
							num16 = 1;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ac8b4db689fb4d85a7bb7ce35db5e4d5 == 0)
							{
								num16 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				goto case 11;
			case 15:
				sqlConnectionStringBuilder = new SqlConnectionStringBuilder(connectionString);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_5ae23e79a5ef4ec9a6a58c0daa87c096 == 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				try
				{
					BGcm7LYEDE0NMFb7WtT(mFHkGpYNwbCdyDMWDuV(), GZtaU5YeJyAZiqCWIYQ(H3vjvcM1E5InPkDgJVu(-800941032 ^ -800932578), connectionString));
					int num7 = 2;
					while (true)
					{
						switch (num7)
						{
						case 2:
							unpKt8YOHKQY822xlD0(sqlConnection2);
							num7 = 0;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_88b018be80f64052a4b6364462094eef == 0)
							{
								num7 = 0;
							}
							break;
						default:
							dbCommand2 = (IDbCommand)MbNGl2YlQEFjWU9mvRj(sqlConnection2);
							num7 = 1;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a2b331cfbee74083865b99663c080fcb == 0)
							{
								num7 = 1;
							}
							break;
						case 1:
							try
							{
								dbCommand2.CommandText = (string)TETXHFYApkMv9ETfRmj(H3vjvcM1E5InPkDgJVu(0x28823350 ^ 0x288212FC), sqlConnectionStringBuilder.InitialCatalog, H3vjvcM1E5InPkDgJVu(0x2CDCAD98 ^ 0x2CDCBDDE));
								int num8 = 0;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_da020ace8b12415a904b6d9c77d7515c == 0)
								{
									num8 = 0;
								}
								while (true)
								{
									switch (num8)
									{
									case 1:
										return;
									default:
										SIAKQ2Y0UuH3HwkWgKf(dbCommand2);
										num8 = 2;
										break;
									case 2:
										BGcm7LYEDE0NMFb7WtT(mFHkGpYNwbCdyDMWDuV(), H3vjvcM1E5InPkDgJVu(0x1ACAC88E ^ 0x1ACAE940));
										num8 = 1;
										if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_01fcbf7f4c0245c8970ab01c215239fb != 0)
										{
											num8 = 1;
										}
										break;
									}
								}
							}
							finally
							{
								if (dbCommand2 != null)
								{
									int num9 = 1;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a88af087375c48b1b8354e3e8d657ff7 == 0)
									{
										num9 = 1;
									}
									while (true)
									{
										switch (num9)
										{
										case 1:
											KUYLCLYjrCZMaaoG0oQ(dbCommand2);
											num9 = 0;
											if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ad871fba51dd42b7aa862ab51c3e4a86 == 0)
											{
												num9 = 0;
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
				finally
				{
					if (sqlConnection2 != null)
					{
						int num10 = 1;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ec5f92fd6ddb449a9afc09c18f0a77db == 0)
						{
							num10 = 1;
						}
						while (true)
						{
							switch (num10)
							{
							case 1:
								KUYLCLYjrCZMaaoG0oQ(sqlConnection2);
								num10 = 0;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_50026842ab044d008d304fc8fda891b4 == 0)
								{
									num10 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 13:
				if (!string.IsNullOrEmpty(sqlConnectionStringBuilder.InitialCatalog))
				{
					num2 = 5;
					break;
				}
				goto case 3;
			case 3:
				if (XPtlw8MaVUi5RFJ3okX(DjRmOXY90MfP2yGl7O2(sqlConnectionStringBuilder)))
				{
					num2 = 4;
					break;
				}
				goto case 18;
			case 2:
				c2S0FWYQ6GVg0MYrc0b(2500);
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_6c4bacaf03bd45578009f4720a268b0d == 0)
				{
					num2 = 1;
				}
				break;
			case 18:
				flag = false;
				num2 = 7;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_35105e355f0a469e84490cd889d0fb37 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
			case 5:
			case 10:
			case 14:
				sqlConnection2 = new SqlConnection(connectionString2);
				num2 = 8;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_7937bb5aeb374034837b9426eced6cfc == 0)
				{
					num2 = 9;
				}
				break;
			case 11:
				if (!flag)
				{
					dbName = "";
					num2 = 12;
					break;
				}
				num2 = 6;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_533d0278bbeb47caa283bab50134e84d == 0)
				{
					num2 = 5;
				}
				break;
			default:
				if (!l1307HYsZHBAFw9BBlL(sqlConnectionStringBuilder))
				{
					num2 = 14;
					break;
				}
				goto case 13;
			case 8:
				try
				{
					BGcm7LYEDE0NMFb7WtT(Logger.Log, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1974253802 ^ 0x75AC9AD4) + connectionString);
					int num3 = 1;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_9457c8cc16bd407492ec82836e6ece2b != 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							dbCommand = (IDbCommand)MbNGl2YlQEFjWU9mvRj(sqlConnection);
							num3 = 2;
							continue;
						case 1:
							unpKt8YOHKQY822xlD0(sqlConnection);
							num3 = 0;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_b13d731cb79641de887177267153d656 == 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							try
							{
								dbCommand.CommandText = BuildAttachDatabaseCommand((string)DjRmOXY90MfP2yGl7O2(sqlConnectionStringBuilder), ref dbName);
								int num4 = 0;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_762cf717254743a4a1d5f3fcfeb2849f != 0)
								{
									num4 = 0;
								}
								while (true)
								{
									switch (num4)
									{
									case 1:
										BGcm7LYEDE0NMFb7WtT(mFHkGpYNwbCdyDMWDuV(), H3vjvcM1E5InPkDgJVu(-1992046500 ^ -1992037684));
										num4 = 2;
										if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_6c4bacaf03bd45578009f4720a268b0d == 0)
										{
											num4 = 2;
										}
										continue;
									default:
										SIAKQ2Y0UuH3HwkWgKf(dbCommand);
										num4 = 1;
										if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_25f0dcdb5c5e4e6fbd7fee91aad234f3 == 0)
										{
											num4 = 1;
										}
										continue;
									case 2:
										break;
									}
									break;
								}
							}
							finally
							{
								if (dbCommand != null)
								{
									int num5 = 0;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_914e5983c8d84fee9bd54eba99b82441 != 0)
									{
										num5 = 0;
									}
									while (true)
									{
										switch (num5)
										{
										default:
											KUYLCLYjrCZMaaoG0oQ(dbCommand);
											num5 = 1;
											if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_d1a34b21803e45aa91fae87c4eb8443a == 0)
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
							break;
						}
						break;
					}
				}
				finally
				{
					if (sqlConnection != null)
					{
						int num6 = 1;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_536a197f18c04d92abf9ab236ddc733a == 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								KUYLCLYjrCZMaaoG0oQ(sqlConnection);
								num6 = 0;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_2580d923b4ce4bd0b5bb01b45f02c594 == 0)
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
				goto case 2;
			case 1:
				r2sercYvNE2wPWFEIbT(sqlConnectionStringBuilder, dbName);
				num2 = 10;
				break;
			}
		}
	}

	protected void CreateDatabase(string connectionString)
	{
		//Discarded unreachable code: IL_0050, IL_00d9, IL_0121, IL_01e1, IL_0200, IL_022c, IL_023b, IL_02a0, IL_02bf, IL_02eb, IL_02fa, IL_0326, IL_0395, IL_03a4
		int num = 1;
		int num2 = num;
		IDbCommand dbCommand = default(IDbCommand);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				((ILogger)mFHkGpYNwbCdyDMWDuV()).Info(H3vjvcM1E5InPkDgJVu(-862174492 ^ -862166988));
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_914e5983c8d84fee9bd54eba99b82441 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				SqlConnection sqlConnection = new SqlConnection((string)RIa5OLYnwvpkKTHFYjw(connectionString));
				int num3 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bbc137d911274e6c8ec7374800482ba2 != 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 2:
						break;
					default:
						try
						{
							BGcm7LYEDE0NMFb7WtT(mFHkGpYNwbCdyDMWDuV(), GZtaU5YeJyAZiqCWIYQ(H3vjvcM1E5InPkDgJVu(-214073528 ^ -214082484), sqlSettings.ConnectionString));
							int num4 = 1;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_eef77c3bebfa4d668f7e6bb309dba438 != 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 2:
									try
									{
										I3HudpYf6JU46jZPmdu(dbCommand, fv7RgkYbXocsBYP8QNn(connectionString, sqlConnection));
										int num5 = 2;
										if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_6c4bacaf03bd45578009f4720a268b0d == 0)
										{
											num5 = 0;
										}
										while (true)
										{
											switch (num5)
											{
											case 3:
												dbCommand.ExecuteNonQuery();
												num5 = 1;
												if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_adccb0765c0e42dbaf186220f45b757c != 0)
												{
													num5 = 1;
												}
												continue;
											case 2:
												dbCommand.CommandTimeout = Et8XxDYSRP5UbVpbf8g();
												num5 = 3;
												if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_c07718730a1849a8a092e51c2522f212 == 0)
												{
													num5 = 0;
												}
												continue;
											case 1:
												BGcm7LYEDE0NMFb7WtT(mFHkGpYNwbCdyDMWDuV(), H3vjvcM1E5InPkDgJVu(-1239877681 ^ -1239886693));
												num5 = 0;
												if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_636573f0701e4d3dad6ad17b85776458 == 0)
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
									finally
									{
										int num6;
										if (dbCommand == null)
										{
											num6 = 0;
											if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_7d9c3f1bd5704dffa8a30fba06b99cdf == 0)
											{
												num6 = 0;
											}
											goto IL_01e5;
										}
										goto IL_020a;
										IL_020a:
										KUYLCLYjrCZMaaoG0oQ(dbCommand);
										num6 = 1;
										if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a88af087375c48b1b8354e3e8d657ff7 == 0)
										{
											num6 = 0;
										}
										goto IL_01e5;
										IL_01e5:
										switch (num6)
										{
										default:
											goto end_IL_01c0;
										case 0:
											goto end_IL_01c0;
										case 2:
											break;
										case 1:
											goto end_IL_01c0;
										}
										goto IL_020a;
										end_IL_01c0:;
									}
									break;
								default:
									dbCommand = sqlConnection.CreateCommand();
									num4 = 2;
									continue;
								case 1:
									unpKt8YOHKQY822xlD0(sqlConnection);
									num4 = 0;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_0d93129ec5af4fc5926990956e624437 == 0)
									{
										num4 = 0;
									}
									continue;
								case 3:
									break;
								}
								break;
							}
						}
						finally
						{
							int num7;
							if (sqlConnection == null)
							{
								num7 = 1;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bdc18f4c9e6b474ea4d1521d9166d946 != 0)
								{
									num7 = 1;
								}
								goto IL_02a4;
							}
							goto IL_02c9;
							IL_02c9:
							KUYLCLYjrCZMaaoG0oQ(sqlConnection);
							num7 = 0;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ad871fba51dd42b7aa862ab51c3e4a86 != 0)
							{
								num7 = 0;
							}
							goto IL_02a4;
							IL_02a4:
							switch (num7)
							{
							default:
								goto end_IL_027f;
							case 1:
								goto end_IL_027f;
							case 2:
								break;
							case 0:
								goto end_IL_027f;
							}
							goto IL_02c9;
							end_IL_027f:;
						}
						break;
					case 1:
						return;
					}
					Thread.Sleep(2500);
					num3 = 1;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_aa8cb810f1524b20abd541fee0197a14 != 0)
					{
						num3 = 1;
					}
				}
			}
			catch (Exception ex)
			{
				int num8 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_914e5983c8d84fee9bd54eba99b82441 != 0)
				{
					num8 = 0;
				}
				while (true)
				{
					switch (num8)
					{
					case 1:
						lNSulkYL7hA0IByVTr4(Logger.Log, H3vjvcM1E5InPkDgJVu(0x2219352 ^ 0x221B0C0), ex);
						num8 = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ca63e6162aaa4aaeaa1385bd9f3ad6e0 == 0)
						{
							num8 = 0;
						}
						break;
					default:
						throw new InvalidOperationException((string)TtsbdxYk72m5JmlTVXk(H3vjvcM1E5InPkDgJVu(0x1ACAC88E ^ 0x1ACAEB4E)), ex);
					}
				}
			}
		}
	}

	protected static string BuildMasterConnectionString(string baseConnectionString)
	{
		SqlConnectionStringBuilder obj = new SqlConnectionStringBuilder(baseConnectionString)
		{
			InitialCatalog = (string)H3vjvcM1E5InPkDgJVu(0x44957A45 ^ 0x44957AB7)
		};
		vJplJKY6TWx6iGoRF3o(obj, "");
		return (string)YHZpG7Y11DpoI64eFIJ(obj);
	}

	protected override string GetDatabaseServerName(Version version)
	{
		int num = 1;
		int num2 = num;
		string value = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				value = version.ToString();
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_80b6e3007a3e4355a8078b16fb1979e5 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return (string)o3J4YVYrYEuq3de2hJW(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-603134395 ^ -603143609), value);
			case 1:
				if (!VersionToEdition.TryGetValue(version.ToString(), out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_d2ea3571782f460a8fcf4212c4b89aef != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	protected override Version GetDatabaseServerVersion()
	{
		//Discarded unreachable code: IL_008a, IL_00b6, IL_0209, IL_0241, IL_0250, IL_02c5, IL_0305, IL_0310, IL_031f, IL_0359, IL_03c1, IL_03d0
		int num = 1;
		int num2 = num;
		Version result = default(Version);
		SqlCommand sqlCommand = default(SqlCommand);
		string text = default(string);
		Version version = default(Version);
		while (true)
		{
			switch (num2)
			{
			case 1:
				Logger.Log.Info(H3vjvcM1E5InPkDgJVu(--1974253802 ^ 0x75AC9CC8));
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a83396b5f3ee40bd928548245e32bc43 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				SqlConnection sqlConnection = new SqlConnection(BuildMasterConnectionString((string)q5HnTHYuE4TJWm4DcnR(this)));
				int num3 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_30d379f142a04774b5dae7c74c918bb8 != 0)
				{
					num3 = 1;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						try
						{
							unpKt8YOHKQY822xlD0(sqlConnection);
							int num4 = 3;
							while (true)
							{
								switch (num4)
								{
								default:
									try
									{
										sqlCommand.CommandTimeout = Et8XxDYSRP5UbVpbf8g();
										int num5 = 3;
										if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_376bf28cb84b46e183378b59ae583e45 != 0)
										{
											num5 = 0;
										}
										while (true)
										{
											switch (num5)
											{
											case 3:
												JP9cJVY58BLeUwi9JLZ(sqlCommand, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53BC9C29 ^ 0x53BCB877));
												num5 = 0;
												if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_e4ca8eb6304c45b5b9866ec7523159cd == 0)
												{
													num5 = 0;
												}
												continue;
											case 1:
											{
												BGcm7LYEDE0NMFb7WtT(Logger.Log, GZtaU5YeJyAZiqCWIYQ(H3vjvcM1E5InPkDgJVu(0x43EF8209 ^ 0x43EFA6B9), text));
												int num6 = 2;
												num5 = num6;
												continue;
											}
											default:
												text = (string)wlhUSEYPwKyuoLqn5rw(Convert.ToString(fx0aeCYDZqWGNhwXU7Z(sqlCommand)), new char[2] { '\r', '\n' });
												num5 = 0;
												if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_15400f29239a48f5a6f7d131d55cff1f != 0)
												{
													num5 = 4;
												}
												continue;
											case 4:
												version = Version.Parse(text);
												num5 = 1;
												if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_6e4085613a434991b7308d69af884312 != 0)
												{
													num5 = 1;
												}
												continue;
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
											int num7 = 1;
											if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_74c50b4541604f879acc41487ba8662e == 0)
											{
												num7 = 0;
											}
											while (true)
											{
												switch (num7)
												{
												case 1:
													KUYLCLYjrCZMaaoG0oQ(sqlCommand);
													num7 = 0;
													if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_3f149d3899664c3e92db5de6fde4f35a == 0)
													{
														num7 = 0;
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
									uHGsBbYCl1p2loaTHto(sqlConnection);
									num4 = 0;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bbc137d911274e6c8ec7374800482ba2 == 0)
									{
										num4 = 2;
									}
									continue;
								case 3:
									sqlCommand = (SqlCommand)MbNGl2YlQEFjWU9mvRj(sqlConnection);
									num4 = 0;
									if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bf52420e3f0049cf9dbec307e6d391c7 != 0)
									{
										num4 = 0;
									}
									continue;
								case 2:
									break;
								}
								break;
							}
						}
						finally
						{
							int num8;
							if (sqlConnection == null)
							{
								num8 = 0;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_9b1d47db702148b5af71c10bd42d90c2 == 0)
								{
									num8 = 0;
								}
								goto IL_02c9;
							}
							goto IL_02df;
							IL_02df:
							((IDisposable)sqlConnection).Dispose();
							num8 = 1;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_c4f350cb93ad41c2a93de4e094bd3eae != 0)
							{
								num8 = 0;
							}
							goto IL_02c9;
							IL_02c9:
							switch (num8)
							{
							default:
								goto end_IL_02a4;
							case 2:
								break;
							case 0:
								goto end_IL_02a4;
							case 1:
								goto end_IL_02a4;
							}
							goto IL_02df;
							end_IL_02a4:;
						}
						break;
					case 2:
						return result;
					}
					result = version;
					num3 = 2;
				}
			}
			catch (Exception ex)
			{
				int num9 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a83396b5f3ee40bd928548245e32bc43 != 0)
				{
					num9 = 0;
				}
				while (true)
				{
					switch (num9)
					{
					case 1:
						result = null;
						num9 = 2;
						continue;
					case 2:
						return result;
					}
					lNSulkYL7hA0IByVTr4(mFHkGpYNwbCdyDMWDuV(), H3vjvcM1E5InPkDgJVu(-1934387638 ^ -1934380362), ex);
					num9 = 1;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_7b9eb7c7ce494b779c3d495b11db0ee8 == 0)
					{
						num9 = 1;
					}
				}
			}
		}
	}

	public MSSQLProvider()
	{
		//Discarded unreachable code: IL_015c, IL_0161
		XIXuoQYaF1rWGi3dgXu();
		VersionToEdition = new Dictionary<string, string>
		{
			{
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-798966336 ^ -798975848),
				(string)H3vjvcM1E5InPkDgJVu(0x6647693 ^ 0x66453F1)
			},
			{
				(string)H3vjvcM1E5InPkDgJVu(-1296333093 ^ -1296325707),
				(string)H3vjvcM1E5InPkDgJVu(0x510BFFD ^ 0x5109A85)
			},
			{
				(string)H3vjvcM1E5InPkDgJVu(0x25153744 ^ 0x251512C0),
				(string)H3vjvcM1E5InPkDgJVu(0x2381262 ^ 0x23837F2)
			},
			{
				(string)H3vjvcM1E5InPkDgJVu(0x1D5BEF19 ^ 0x1D5BCA85),
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1508074661 ^ -1508065551)
			},
			{
				(string)H3vjvcM1E5InPkDgJVu(-786261895 ^ -786252347),
				(string)H3vjvcM1E5InPkDgJVu(-964056903 ^ -964063887)
			},
			{
				(string)H3vjvcM1E5InPkDgJVu(0x816BBA1 ^ 0x8169E75),
				(string)H3vjvcM1E5InPkDgJVu(-1505501660 ^ -1505494076)
			},
			{
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-798966336 ^ -798975956),
				(string)H3vjvcM1E5InPkDgJVu(-969579703 ^ -969587023)
			}
		};
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bdc18f4c9e6b474ea4d1521d9166d946 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static MSSQLProvider()
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
				XIXuoQYaF1rWGi3dgXu();
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bdc18f4c9e6b474ea4d1521d9166d946 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				UID = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x44957A45 ^ 0x44955C41));
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_dcc36b50df1c4388b3314014303f132a != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object yUaxglMlldutLiq7Y5n()
	{
		return ComponentManager.Current;
	}

	internal static bool GkNhnsM0UufN5odjwgW()
	{
		return LZoLZTMfSot2xulM65y == null;
	}

	internal static MSSQLProvider zbWDNCMmseBj6xpT2pf()
	{
		return LZoLZTMfSot2xulM65y;
	}

	internal static object ECMgAEMvBEE0HZbwRXI(object P_0)
	{
		return ((IDataBaseSettingsSection)P_0).ConnectionString;
	}

	internal static object YYqrXuMbPBKP2lBXRU6(object P_0)
	{
		return UpdateConnectionString((string)P_0);
	}

	internal static object KNtmvsMSp1yXh0NDFkc(object P_0)
	{
		return ((string)P_0).ToUpper();
	}

	internal static object H3vjvcM1E5InPkDgJVu(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object miLwRkMrYkqSEvsmkUt(object P_0)
	{
		return ((string)P_0).ToUpper();
	}

	internal static int wER6LsMPI8LsfJRdQoX(object P_0)
	{
		return ((SqlConnectionStringBuilder)P_0).MaxPoolSize;
	}

	internal static bool XPtlw8MaVUi5RFJ3okX(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static Guid wJnCTiMW7Om7s3OKsf6(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static Type UdFVJjM2rUlyTotDi5c(object P_0, Guid P_1, bool P_2)
	{
		return ((IMetadataRuntimeService)P_0).GetTypeByUid(P_1, P_2);
	}

	internal static object mEZ7qIM7AOlsfEd273Q(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object V8TThOM3CGGfdtgT5mV(object P_0)
	{
		return Projections.Property((string)P_0);
	}

	internal static Guid yT6xvJMzdwUAYD8eTGj(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static Type Fwm0OaYKayu4JOmjYXc(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void t5tNlpYMpGjoUUZKwmQ(object P_0, Type P_1)
	{
		((ProviderSettingsSection)P_0).ProviderType = P_1;
	}

	internal static object IifygfYYOUomKgVlhVj(Guid guid)
	{
		return MSSQLTransformationProvider.GuidQuerySintaxisStatic(guid);
	}

	internal static void eRdk3DYtUIiOZgZuR6Q(object P_0, object P_1)
	{
		Contract.NotNull(P_0, (string)P_1);
	}

	internal static void MmhxNSYZoLPQaysaHCY(object P_0)
	{
		((NHProvider)P_0).CheckDatabaseServerVersion();
	}

	internal static bool Cp0Bs1Y8kDK34PVf7pW(object P_0)
	{
		return ((IDataBaseSettingsSection)P_0).DropDatabaseOnStart;
	}

	internal static object q5HnTHYuE4TJWm4DcnR(object P_0)
	{
		return ((NHProvider)P_0).ConnectionString;
	}

	internal static bool XD4XoWYIjAUiuqwYP8s(object P_0)
	{
		return IsDatabaseExists((string)P_0);
	}

	internal static void BGcm7LYEDE0NMFb7WtT(object P_0, object P_1)
	{
		((ILogger)P_0).Info(P_1);
	}

	internal static object DjRmOXY90MfP2yGl7O2(object P_0)
	{
		return ((SqlConnectionStringBuilder)P_0).AttachDBFilename;
	}

	internal static object mSkmnIYyRYr4FF6Iux4(object P_0)
	{
		return ((SqlConnectionStringBuilder)P_0).InitialCatalog;
	}

	internal static object RIa5OLYnwvpkKTHFYjw(object P_0)
	{
		return BuildMasterConnectionString((string)P_0);
	}

	internal static void unpKt8YOHKQY822xlD0(object P_0)
	{
		((DbConnection)P_0).Open();
	}

	internal static object TETXHFYApkMv9ETfRmj(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static void KUYLCLYjrCZMaaoG0oQ(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void OVAZ16YxnG5pyQ7KpAl(object P_0)
	{
		DropDatabase((string)P_0);
	}

	internal static void c2S0FWYQ6GVg0MYrc0b(int P_0)
	{
		Thread.Sleep(P_0);
	}

	internal static object mFHkGpYNwbCdyDMWDuV()
	{
		return Logger.Log;
	}

	internal static void lNSulkYL7hA0IByVTr4(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object TtsbdxYk72m5JmlTVXk(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void vJplJKY6TWx6iGoRF3o(object P_0, object P_1)
	{
		((SqlConnectionStringBuilder)P_0).AttachDBFilename = (string)P_1;
	}

	internal static void uHGsBbYCl1p2loaTHto(object P_0)
	{
		((DbConnection)P_0).Close();
	}

	internal static void AG1rkFYJTKhRBuAvbAY(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}

	internal static int bPfHWaYoPqQOAyZKRwc(object P_0)
	{
		return ((IDataBaseSettingsSection)P_0).ConnectionAttemptCount;
	}

	internal static object KWIZtAYd7UOYhhi8TDM(object P_0, object P_1, object P_2)
	{
		return string.Concat(P_0, P_1, P_2);
	}

	internal static object k7yvp8Yw7OAcaaerP6y(object P_0)
	{
		return SR.M((string)P_0);
	}

	internal static object dc5CgVYTAjYhLLV7xmD(double P_0, object P_1)
	{
		return StartInformation.Operation(P_0, (string)P_1);
	}

	internal static void z4YH7RYgstiBPG3Tt5d(object P_0, object P_1, object P_2)
	{
		((AbstractProvider)P_0).Configure((ProviderSettingsSection)P_1, (RuntimeConfiguration)P_2);
	}

	internal static void BRqg4aYRdDlH2tVwVqR(object P_0, object P_1, object P_2)
	{
		((MSSQLProviderImpl)P_0).Configure((Configuration)P_1, (IDataBaseSettingsSection)P_2);
	}

	internal static void rJPLmPYV7lcRy2PQa5r(object P_0)
	{
		((NHProvider)P_0).InitInternal();
	}

	internal static void pFtgFRYUUa7oGpSuDDd(object P_0, object P_1)
	{
		Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static bool UIbei9YGrXL9OycCDLy(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object vH9AtVYFqP8KoN2mvwa()
	{
		return IOExtensions.GetTempFileName();
	}

	internal static object q2sUCWYia3CP80HMrUM(object P_0)
	{
		return Path.GetFileNameWithoutExtension((string)P_0);
	}

	internal static object DxiMPbY4EviB8Omyr5I(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static object GZtaU5YeJyAZiqCWIYQ(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object vdsgNOYhWQMMKPkwNAV(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object LRJp7BYHwBoXQApG6aj(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static bool l1307HYsZHBAFw9BBlL(object P_0)
	{
		return ((SqlConnectionStringBuilder)P_0).UserInstance;
	}

	internal static object XPQsgvYcVnaLYr5QBP0(object P_0, object P_1)
	{
		return Path.ChangeExtension((string)P_0, (string)P_1);
	}

	internal static object TSFKulYBgmC2IY4gj3b(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).AppendLine((string)P_1);
	}

	internal static object fTrS9xYpOurLSC9r30t(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((string[])P_1, P_2);
	}

	internal static object GQ5ok4YXmEH7hD3uEaK(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void JP9cJVY58BLeUwi9JLZ(object P_0, object P_1)
	{
		((DbCommand)P_0).CommandText = (string)P_1;
	}

	internal static object in7BKKYqDY58KlrRQXm(object P_0)
	{
		return ((SqlCommand)P_0).Parameters;
	}

	internal static object fx0aeCYDZqWGNhwXU7Z(object P_0)
	{
		return ((DbCommand)P_0).ExecuteScalar();
	}

	internal static void I3HudpYf6JU46jZPmdu(object P_0, object P_1)
	{
		((IDbCommand)P_0).CommandText = (string)P_1;
	}

	internal static int SIAKQ2Y0UuH3HwkWgKf(object P_0)
	{
		return ((IDbCommand)P_0).ExecuteNonQuery();
	}

	internal static void JN7CkMYmTPHMdJ6dAUp(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Info(P_1, (Exception)P_2);
	}

	internal static object MbNGl2YlQEFjWU9mvRj(object P_0)
	{
		return ((SqlConnection)P_0).CreateCommand();
	}

	internal static void r2sercYvNE2wPWFEIbT(object P_0, object P_1)
	{
		((SqlConnectionStringBuilder)P_0).InitialCatalog = (string)P_1;
	}

	internal static object fv7RgkYbXocsBYP8QNn(object P_0, object P_1)
	{
		return BuildCreateDatabaseCommand((string)P_0, (SqlConnection)P_1);
	}

	internal static int Et8XxDYSRP5UbVpbf8g()
	{
		return TransformationProviderBase.DefaultCommandTimeout;
	}

	internal static object YHZpG7Y11DpoI64eFIJ(object P_0)
	{
		return ((DbConnectionStringBuilder)P_0).ConnectionString;
	}

	internal static object o3J4YVYrYEuq3de2hJW(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object wlhUSEYPwKyuoLqn5rw(object P_0, object P_1)
	{
		return ((string)P_0).Trim((char[])P_1);
	}

	internal static void XIXuoQYaF1rWGi3dgXu()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.BPCyhsoin5();
	}
}
