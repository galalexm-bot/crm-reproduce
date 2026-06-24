using System;
using System.Data.SqlClient;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DataSource;
using EleWise.ELMA.DataSource.ExtensionPoints;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions.MSSQL;

public class MSSQLExternalDataSourceExecutor : DataBaseExternalDataSourceExecutor
{
	internal static MSSQLExternalDataSourceExecutor cl1MfPMoaVHtABPZ7jK;

	protected override string Name => (string)KdsncoMTRc9VGgdQNO3(-370249262 ^ -370252304);

	protected override string RetrieveSchemaQuery => (string)KdsncoMTRc9VGgdQNO3(-1218069071 ^ -1218074239);

	public MSSQLExternalDataSourceExecutor(string connectionString)
	{
		//Discarded unreachable code: IL_0043, IL_0048, IL_0096, IL_013d, IL_01a3, IL_01b2, IL_01ed, IL_0290, IL_02d6, IL_033b, IL_034a
		HYbOioMgiguDMV7D2eQ();
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals0.connectionString = connectionString;
		base._002Ector();
		int num = 3;
		if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a9455caf5a604783b3a743f491182420 == 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			default:
				try
				{
					aNWJ77MUOUwAZjZba37(Logger.Log, string.Format((string)KdsncoMTRc9VGgdQNO3(-1255667900 ^ -1255665584), XcMERyMVtpjwtEBihNb(this)));
					int num4 = 2;
					while (true)
					{
						switch (num4)
						{
						default:
							aNWJ77MUOUwAZjZba37(dxSKWNMRbgMQJnv4RMQ(), KdsncoMTRc9VGgdQNO3(-61500477 ^ -61504355));
							num4 = 1;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_636573f0701e4d3dad6ad17b85776458 != 0)
							{
								num4 = 1;
							}
							break;
						case 2:
							nrdggQMeCj72oMIagKo(this, new MSSQLTransformationProvider(() => new SqlConnection(CS_0024_003C_003E8__locals0.connectionString)));
							num4 = 0;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_937e86e483374781b74ae1d5b232cdfa == 0)
							{
								num4 = 0;
							}
							break;
						case 1:
							return;
						}
					}
				}
				catch (Exception ex2)
				{
					int num5 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_b191e4df737c4fbb97b7fbe68dd7816d != 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						case 1:
							throw new ExternalDataSourceExecutorConnectionException((string)XcMERyMVtpjwtEBihNb(this), ex2);
						}
						((ILogger)dxSKWNMRbgMQJnv4RMQ()).Error(string.Format((string)KdsncoMTRc9VGgdQNO3(0x379281FC ^ 0x37929680), XcMERyMVtpjwtEBihNb(this)), ex2);
						num5 = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_4599535ffcb34731ae493be59317478a != 0)
						{
							num5 = 1;
						}
					}
				}
			case 3:
				try
				{
					aNWJ77MUOUwAZjZba37(dxSKWNMRbgMQJnv4RMQ(), string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1354195022 ^ -1354200488), XcMERyMVtpjwtEBihNb(this)));
					int num2 = 4;
					while (true)
					{
						switch (num2)
						{
						case 2:
							throw new Exception((string)Et0lHNMFvSsUGqCaxgl(KdsncoMTRc9VGgdQNO3(0x12FD2B1 ^ 0x12FC4F3)));
						case 3:
							new SqlConnectionStringBuilder(CS_0024_003C_003E8__locals0.connectionString);
							num2 = 1;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_35105e355f0a469e84490cd889d0fb37 == 0)
							{
								num2 = 0;
							}
							continue;
						case 1:
							aNWJ77MUOUwAZjZba37(dxSKWNMRbgMQJnv4RMQ(), KdsncoMTRc9VGgdQNO3(0x27751E21 ^ 0x277508AB));
							num2 = 0;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_067e68396ca94bf49b212b142d07ac32 != 0)
							{
								num2 = 0;
							}
							continue;
						case 4:
							if (!eLRhKeMGMHirlYH9jar(CS_0024_003C_003E8__locals0.connectionString))
							{
								num2 = 3;
								continue;
							}
							goto case 2;
						case 0:
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					int num3 = 1;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_3af97e9a57d2492f8793e39a552f0f48 == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							AFXkiPM4bUI6mDPyPiK(dxSKWNMRbgMQJnv4RMQ(), BeZTDeMivUAXKl2Jhwl(KdsncoMTRc9VGgdQNO3(-2056810441 ^ -2056812811), XcMERyMVtpjwtEBihNb(this)), ex);
							num3 = 0;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_81833be823b44351b330d2171723abb3 == 0)
							{
								num3 = 0;
							}
							break;
						default:
							throw new ExternalDataSourceExecutorConnectionStringException((string)XcMERyMVtpjwtEBihNb(this), ex);
						}
					}
				}
				break;
			case 1:
				break;
			case 2:
				return;
			}
			num = 0;
			if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ee3b4c6a3b0041bfaa9b5ce28a8e6629 == 0)
			{
				num = 0;
			}
		}
	}

	public MSSQLExternalDataSourceExecutor(ITransformationProvider transformationProvider)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		HYbOioMgiguDMV7D2eQ();
		base._002Ector(transformationProvider);
		int num = 0;
		if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_38564d6ade73482fadcc5aedb5edd1aa != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object KdsncoMTRc9VGgdQNO3(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool IhfYoDMdJouUsws90EX()
	{
		return cl1MfPMoaVHtABPZ7jK == null;
	}

	internal static MSSQLExternalDataSourceExecutor uuDMB8MwEiNjgMxFHjL()
	{
		return cl1MfPMoaVHtABPZ7jK;
	}

	internal static void HYbOioMgiguDMV7D2eQ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.BPCyhsoin5();
	}

	internal static object dxSKWNMRbgMQJnv4RMQ()
	{
		return Logger.Log;
	}

	internal static object XcMERyMVtpjwtEBihNb(object P_0)
	{
		return ((DataBaseExternalDataSourceExecutor)P_0).Name;
	}

	internal static void aNWJ77MUOUwAZjZba37(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}

	internal static bool eLRhKeMGMHirlYH9jar(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object Et0lHNMFvSsUGqCaxgl(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object BeZTDeMivUAXKl2Jhwl(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void AFXkiPM4bUI6mDPyPiK(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void nrdggQMeCj72oMIagKo(object P_0, object P_1)
	{
		((DataBaseExternalDataSourceExecutor)P_0).TransformationProvider = (ITransformationProviderBase)P_1;
	}
}
[Component]
public class MSSQLExternalDataSourceExecutorCreator : IExternalDataSourceExecutorCreator
{
	internal static MSSQLExternalDataSourceExecutorCreator aNDiN8MhXn1F8YIG7gY;

	public string Name => SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1294383846 ^ -1294380744);

	public Guid TypeUid => new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1992046500 ^ -1992040474));

	public IExternalDataSourceExecutor Create(string connectionString)
	{
		return new MSSQLExternalDataSourceExecutor(connectionString);
	}

	public MSSQLExternalDataSourceExecutorCreator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		z0TbfiMc50s4xZ6avqd();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_611f69e7a7a34a4fbeb0099afc53aecd == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool aVq9atMHkJcR7tGmttm()
	{
		return aNDiN8MhXn1F8YIG7gY == null;
	}

	internal static MSSQLExternalDataSourceExecutorCreator kWSgLcMs87uJFeA8ePZ()
	{
		return aNDiN8MhXn1F8YIG7gY;
	}

	internal static void z0TbfiMc50s4xZ6avqd()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.BPCyhsoin5();
	}
}
