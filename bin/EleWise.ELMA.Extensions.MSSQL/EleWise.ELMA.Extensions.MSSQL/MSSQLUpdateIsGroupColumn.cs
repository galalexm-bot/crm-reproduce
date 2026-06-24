using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db.ExtensionPoints;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions.MSSQL;

[Component]
internal class MSSQLUpdateIsGroupColumn : IUpdateIsGroupColumnExtension
{
	internal static MSSQLUpdateIsGroupColumn cxGCpZ8A0mewu02rqtA;

	public Guid ProviderUid => MSSQLProvider.UID;

	public void Execute(string tableName, string isGroupColumnName, string parentColumnName)
	{
		//Discarded unreachable code: IL_0046, IL_0138, IL_0198, IL_01a7
		switch (1)
		{
		case 1:
			try
			{
				ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				int num = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_adccb0765c0e42dbaf186220f45b757c != 0)
				{
					num = 1;
				}
				string sql = default(string);
				while (true)
				{
					switch (num)
					{
					case 1:
						sql = string.Format((string)K7V0Rs8Q05D6SR4LbgU(0x8F848CE ^ 0x8F8D1E2), RI7GvK8LGAndnrEh1Ft(k6U7878NX4m0cPLxwmZ(serviceNotNull), tableName), RI7GvK8LGAndnrEh1Ft(k6U7878NX4m0cPLxwmZ(serviceNotNull), isGroupColumnName), RI7GvK8LGAndnrEh1Ft(k6U7878NX4m0cPLxwmZ(serviceNotNull), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1934387638 ^ -1934378714)), RI7GvK8LGAndnrEh1Ft(k6U7878NX4m0cPLxwmZ(serviceNotNull), parentColumnName));
						num = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ad871fba51dd42b7aa862ab51c3e4a86 == 0)
						{
							num = 0;
						}
						break;
					default:
						serviceNotNull.ExecuteNonQuery(sql);
						num = 2;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_38564d6ade73482fadcc5aedb5edd1aa != 0)
						{
							num = 1;
						}
						break;
					case 2:
						return;
					}
				}
			}
			catch (Exception ex)
			{
				int num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bb8b65c62a044e0a9142fed3b497ae35 != 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						return;
					}
					MV2I8n8CXHh7xeuehhs(KkdV5A8kJ43sOMo1RZu(), Hf8Pnp86f5egWbv793V(K7V0Rs8Q05D6SR4LbgU(0x5188C8F7 ^ 0x51885115), new object[1] { tableName }), ex);
					num2 = 1;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_50026842ab044d008d304fc8fda891b4 != 0)
					{
						num2 = 1;
					}
				}
			}
		case 0:
			break;
		}
	}

	public MSSQLUpdateIsGroupColumn()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.BPCyhsoin5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_7942d4fd0d374965b627e0b9f3e5b0e4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object K7V0Rs8Q05D6SR4LbgU(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object k6U7878NX4m0cPLxwmZ(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object RI7GvK8LGAndnrEh1Ft(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object KkdV5A8kJ43sOMo1RZu()
	{
		return Logger.Log;
	}

	internal static object Hf8Pnp86f5egWbv793V(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static void MV2I8n8CXHh7xeuehhs(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static bool SN0KI68jehpiVBWtNhA()
	{
		return cxGCpZ8A0mewu02rqtA == null;
	}

	internal static MSSQLUpdateIsGroupColumn CuSylV8xYSIlEXqxMaI()
	{
		return cxGCpZ8A0mewu02rqtA;
	}
}
