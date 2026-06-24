using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Migrator.Providers;

internal class SafeDataReader : DbDataReader
{
	private DbDataReader reader;

	private DbCommand cmd;

	private static SafeDataReader e9qBlyWnGUSBkb5jHL55;

	public override int Depth => reader.Depth;

	public override bool IsClosed => My18IeWn8XTK7VmyQ0lY(reader);

	public override int RecordsAffected => h38MVNWnIgJTmfiJ5EFd(reader);

	public override int FieldCount => tjG8WTWniaT9u1rOVvbQ(reader);

	public override object this[string name] => hu2XdWWnHqvZjkyK4OJ4(reader, name);

	public override object this[int i] => kv2qxaWnARvFRhl1rqmK(reader, i);

	public override bool HasRows => mwaYnrWn7UdPgAuYKyHj(reader);

	public SafeDataReader(DbDataReader r, DbCommand cmd)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
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
				if (r == null)
				{
					num = 2;
					break;
				}
				reader = r;
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num = 0;
				}
				break;
			case 3:
				this.cmd = cmd;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				throw new ArgumentNullException((string)gkmqGWWnQEAMCfUayiWo(0x7247028A ^ 0x7246F384));
			case 0:
				return;
			}
		}
	}

	public override void Close()
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
				fswH6hWnCtZlvmvLTXCV(reader);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override DataTable GetSchemaTable()
	{
		return (DataTable)cNki1AWnv2yhxPcRLnOM(reader);
	}

	public override bool NextResult()
	{
		return Oyy5NSWnZgaS22dOhQYt(reader);
	}

	public override bool Read()
	{
		return psQmfEWnuFpUlGBpZSDO(reader);
	}

	protected override void Dispose(bool disposing)
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
				J7iSmRWnVCTgVcjrvIeF(reader);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				cK9OcHWnSNr5K9tvyahi(cmd);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public override bool GetBoolean(int i)
	{
		return FFOfKwWnRabTkkcGZgCi(reader, i);
	}

	public override byte GetByte(int i)
	{
		return t1txjvWnKJHQlskNKwXM(UaOkZYWnqm6SIngjGajU(reader, i));
	}

	public override long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
	{
		return bufOGvWnXGeH3Gckc1ec(reader, i, fieldOffset, buffer, bufferoffset, length);
	}

	public override char GetChar(int i)
	{
		return WuMC2XWnTZ2UUXS1hdkV(reader, i);
	}

	public override long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
	{
		return pCnlx6Wnk3anT5a2Et5I(reader, i, fieldoffset, buffer, bufferoffset, length);
	}

	protected override DbDataReader GetDbDataReader(int i)
	{
		return (DbDataReader)YH0AJ0WnnJU5ihuP8kgZ(reader, i);
	}

	public override string GetDataTypeName(int i)
	{
		return (string)LSgCEMWnOlyDkc0aXtWp(reader, i);
	}

	public override DateTime GetDateTime(int i)
	{
		return TRiBbkWn2wuWUnOWMR12(reader, i);
	}

	public override decimal GetDecimal(int i)
	{
		return zJsQB4WnesFrnvej6dJL(UaOkZYWnqm6SIngjGajU(reader, i));
	}

	public override double GetDouble(int i)
	{
		return KJMk7OWnPxZULAeddL64(UaOkZYWnqm6SIngjGajU(reader, i));
	}

	public override Type GetFieldType(int i)
	{
		return reader.GetFieldType(i);
	}

	public override float GetFloat(int i)
	{
		return NkbWwDWn18H1lQ1gJB4q(reader, i);
	}

	public override Guid GetGuid(int i)
	{
		return R8CiSNWnNxrYheINtK3I(reader, i);
	}

	public override short GetInt16(int i)
	{
		return goJnL1Wn3NqALNofHRsl(UaOkZYWnqm6SIngjGajU(reader, i));
	}

	public override int GetInt32(int i)
	{
		return kMnInqWnp2d97dEjc25V(UaOkZYWnqm6SIngjGajU(reader, i));
	}

	public override long GetInt64(int i)
	{
		return v4JAa1Wna45tS9bnIha6(UaOkZYWnqm6SIngjGajU(reader, i));
	}

	public override string GetName(int i)
	{
		return (string)fIP24RWnDt3fPayxU8yk(reader, i);
	}

	public override int GetOrdinal(string name)
	{
		return t7XHEmWntiUGNTG1qJHt(reader, name);
	}

	public override string GetString(int i)
	{
		return (string)c43nuTWnw53V9l9H5qgr(reader, i);
	}

	public override object GetValue(int i)
	{
		return reader.GetValue(i);
	}

	public override int GetValues(object[] values)
	{
		return BikChCWn4wGlxiTEiR1U(reader, values);
	}

	public override bool IsDBNull(int i)
	{
		return qsjaFpWn6owSvBDO3rKv(reader, i);
	}

	public override IEnumerator GetEnumerator()
	{
		return (IEnumerator)dAsMS6Wnx1PVx00d23g2(reader);
	}

	public override Task<bool> ReadAsync(CancellationToken cancellationToken)
	{
		return reader.ReadAsync(cancellationToken);
	}

	public override Task<bool> NextResultAsync(CancellationToken cancellationToken)
	{
		return reader.NextResultAsync(cancellationToken);
	}

	public override Task<bool> IsDBNullAsync(int ordinal, CancellationToken cancellationToken)
	{
		return reader.IsDBNullAsync(ordinal, cancellationToken);
	}

	internal static object gkmqGWWnQEAMCfUayiWo(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool qbm5eEWnEjYeseWLwODQ()
	{
		return e9qBlyWnGUSBkb5jHL55 == null;
	}

	internal static SafeDataReader dNX9K2WnfHQjW2AGcZC4()
	{
		return e9qBlyWnGUSBkb5jHL55;
	}

	internal static void fswH6hWnCtZlvmvLTXCV(object P_0)
	{
		((DbDataReader)P_0).Close();
	}

	internal static object cNki1AWnv2yhxPcRLnOM(object P_0)
	{
		return ((DbDataReader)P_0).GetSchemaTable();
	}

	internal static bool My18IeWn8XTK7VmyQ0lY(object P_0)
	{
		return ((DbDataReader)P_0).IsClosed;
	}

	internal static bool Oyy5NSWnZgaS22dOhQYt(object P_0)
	{
		return ((DbDataReader)P_0).NextResult();
	}

	internal static bool psQmfEWnuFpUlGBpZSDO(object P_0)
	{
		return ((DbDataReader)P_0).Read();
	}

	internal static int h38MVNWnIgJTmfiJ5EFd(object P_0)
	{
		return ((DbDataReader)P_0).RecordsAffected;
	}

	internal static void J7iSmRWnVCTgVcjrvIeF(object P_0)
	{
		((DbDataReader)P_0).Dispose();
	}

	internal static void cK9OcHWnSNr5K9tvyahi(object P_0)
	{
		((Component)P_0).Dispose();
	}

	internal static int tjG8WTWniaT9u1rOVvbQ(object P_0)
	{
		return ((DbDataReader)P_0).FieldCount;
	}

	internal static bool FFOfKwWnRabTkkcGZgCi(object P_0, int P_1)
	{
		return ((DbDataReader)P_0).GetBoolean(P_1);
	}

	internal static object UaOkZYWnqm6SIngjGajU(object P_0, int P_1)
	{
		return ((DbDataReader)P_0).GetValue(P_1);
	}

	internal static byte t1txjvWnKJHQlskNKwXM(object P_0)
	{
		return Convert.ToByte(P_0);
	}

	internal static long bufOGvWnXGeH3Gckc1ec(object P_0, int P_1, long P_2, object P_3, int P_4, int P_5)
	{
		return ((DbDataReader)P_0).GetBytes(P_1, P_2, (byte[])P_3, P_4, P_5);
	}

	internal static char WuMC2XWnTZ2UUXS1hdkV(object P_0, int P_1)
	{
		return ((DbDataReader)P_0).GetChar(P_1);
	}

	internal static long pCnlx6Wnk3anT5a2Et5I(object P_0, int P_1, long P_2, object P_3, int P_4, int P_5)
	{
		return ((DbDataReader)P_0).GetChars(P_1, P_2, (char[])P_3, P_4, P_5);
	}

	internal static object YH0AJ0WnnJU5ihuP8kgZ(object P_0, int P_1)
	{
		return ((DbDataReader)P_0).GetData(P_1);
	}

	internal static object LSgCEMWnOlyDkc0aXtWp(object P_0, int P_1)
	{
		return ((DbDataReader)P_0).GetDataTypeName(P_1);
	}

	internal static DateTime TRiBbkWn2wuWUnOWMR12(object P_0, int P_1)
	{
		return ((DbDataReader)P_0).GetDateTime(P_1);
	}

	internal static decimal zJsQB4WnesFrnvej6dJL(object P_0)
	{
		return Convert.ToDecimal(P_0);
	}

	internal static double KJMk7OWnPxZULAeddL64(object P_0)
	{
		return Convert.ToDouble(P_0);
	}

	internal static float NkbWwDWn18H1lQ1gJB4q(object P_0, int P_1)
	{
		return ((DbDataReader)P_0).GetFloat(P_1);
	}

	internal static Guid R8CiSNWnNxrYheINtK3I(object P_0, int P_1)
	{
		return ((DbDataReader)P_0).GetGuid(P_1);
	}

	internal static short goJnL1Wn3NqALNofHRsl(object P_0)
	{
		return Convert.ToInt16(P_0);
	}

	internal static int kMnInqWnp2d97dEjc25V(object P_0)
	{
		return Convert.ToInt32(P_0);
	}

	internal static long v4JAa1Wna45tS9bnIha6(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static object fIP24RWnDt3fPayxU8yk(object P_0, int P_1)
	{
		return ((DbDataReader)P_0).GetName(P_1);
	}

	internal static int t7XHEmWntiUGNTG1qJHt(object P_0, object P_1)
	{
		return ((DbDataReader)P_0).GetOrdinal((string)P_1);
	}

	internal static object c43nuTWnw53V9l9H5qgr(object P_0, int P_1)
	{
		return ((DbDataReader)P_0).GetString(P_1);
	}

	internal static int BikChCWn4wGlxiTEiR1U(object P_0, object P_1)
	{
		return ((DbDataReader)P_0).GetValues((object[])P_1);
	}

	internal static bool qsjaFpWn6owSvBDO3rKv(object P_0, int P_1)
	{
		return ((DbDataReader)P_0).IsDBNull(P_1);
	}

	internal static object hu2XdWWnHqvZjkyK4OJ4(object P_0, object P_1)
	{
		return ((DbDataReader)P_0)[(string)P_1];
	}

	internal static object kv2qxaWnARvFRhl1rqmK(object P_0, int P_1)
	{
		return ((DbDataReader)P_0)[P_1];
	}

	internal static bool mwaYnrWn7UdPgAuYKyHj(object P_0)
	{
		return ((DbDataReader)P_0).HasRows;
	}

	internal static object dAsMS6Wnx1PVx00d23g2(object P_0)
	{
		return ((DbDataReader)P_0).GetEnumerator();
	}
}
