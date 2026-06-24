// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Migrator.Providers.SafeDataReader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.Db.Migrator.Providers
{
  internal class SafeDataReader : DbDataReader
  {
    private DbDataReader reader;
    private DbCommand cmd;
    private static SafeDataReader e9qBlyWnGUSBkb5jHL55;

    /// <summary>Ctor</summary>
    /// <param name="r"></param>
    /// <param name="cmd"></param>
    public SafeDataReader(DbDataReader r, DbCommand cmd)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            if (r == null)
            {
              num = 2;
              continue;
            }
            this.reader = r;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 3 : 0;
            continue;
          case 2:
            goto label_7;
          case 3:
            this.cmd = cmd;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
            continue;
          default:
            goto label_9;
        }
      }
label_3:
      return;
label_9:
      return;
label_7:
      throw new ArgumentNullException((string) SafeDataReader.gkmqGWWnQEAMCfUayiWo(1917256330 ^ 1917252484));
    }

    /// <inheritdoc />
    public override void Close()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            SafeDataReader.fswH6hWnCtZlvmvLTXCV((object) this.reader);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    public override int Depth => this.reader.Depth;

    /// <inheritdoc />
    public override DataTable GetSchemaTable() => (DataTable) SafeDataReader.cNki1AWnv2yhxPcRLnOM((object) this.reader);

    /// <inheritdoc />
    public override bool IsClosed => SafeDataReader.My18IeWn8XTK7VmyQ0lY((object) this.reader);

    /// <inheritdoc />
    public override bool NextResult() => SafeDataReader.Oyy5NSWnZgaS22dOhQYt((object) this.reader);

    /// <inheritdoc />
    public override bool Read() => SafeDataReader.psQmfEWnuFpUlGBpZSDO((object) this.reader);

    /// <inheritdoc />
    public override int RecordsAffected => SafeDataReader.h38MVNWnIgJTmfiJ5EFd((object) this.reader);

    /// <inheritdoc />
    protected override void Dispose(bool disposing)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            SafeDataReader.J7iSmRWnVCTgVcjrvIeF((object) this.reader);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            SafeDataReader.cK9OcHWnSNr5K9tvyahi((object) this.cmd);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    public override int FieldCount => SafeDataReader.tjG8WTWniaT9u1rOVvbQ((object) this.reader);

    /// <inheritdoc />
    public override bool GetBoolean(int i) => SafeDataReader.FFOfKwWnRabTkkcGZgCi((object) this.reader, i);

    /// <inheritdoc />
    public override byte GetByte(int i) => SafeDataReader.t1txjvWnKJHQlskNKwXM(SafeDataReader.UaOkZYWnqm6SIngjGajU((object) this.reader, i));

    /// <inheritdoc />
    public override long GetBytes(
      int i,
      long fieldOffset,
      byte[] buffer,
      int bufferoffset,
      int length)
    {
      return SafeDataReader.bufOGvWnXGeH3Gckc1ec((object) this.reader, i, fieldOffset, (object) buffer, bufferoffset, length);
    }

    /// <inheritdoc />
    public override char GetChar(int i) => SafeDataReader.WuMC2XWnTZ2UUXS1hdkV((object) this.reader, i);

    /// <inheritdoc />
    public override long GetChars(
      int i,
      long fieldoffset,
      char[] buffer,
      int bufferoffset,
      int length)
    {
      return SafeDataReader.pCnlx6Wnk3anT5a2Et5I((object) this.reader, i, fieldoffset, (object) buffer, bufferoffset, length);
    }

    /// <inheritdoc />
    protected override DbDataReader GetDbDataReader(int i) => (DbDataReader) SafeDataReader.YH0AJ0WnnJU5ihuP8kgZ((object) this.reader, i);

    /// <inheritdoc />
    public override string GetDataTypeName(int i) => (string) SafeDataReader.LSgCEMWnOlyDkc0aXtWp((object) this.reader, i);

    /// <inheritdoc />
    public override DateTime GetDateTime(int i) => SafeDataReader.TRiBbkWn2wuWUnOWMR12((object) this.reader, i);

    /// <inheritdoc />
    public override Decimal GetDecimal(int i) => SafeDataReader.zJsQB4WnesFrnvej6dJL(SafeDataReader.UaOkZYWnqm6SIngjGajU((object) this.reader, i));

    /// <inheritdoc />
    public override double GetDouble(int i) => SafeDataReader.KJMk7OWnPxZULAeddL64(SafeDataReader.UaOkZYWnqm6SIngjGajU((object) this.reader, i));

    /// <inheritdoc />
    public override Type GetFieldType(int i) => this.reader.GetFieldType(i);

    /// <inheritdoc />
    public override float GetFloat(int i) => SafeDataReader.NkbWwDWn18H1lQ1gJB4q((object) this.reader, i);

    /// <inheritdoc />
    public override Guid GetGuid(int i) => SafeDataReader.R8CiSNWnNxrYheINtK3I((object) this.reader, i);

    /// <inheritdoc />
    public override short GetInt16(int i) => SafeDataReader.goJnL1Wn3NqALNofHRsl(SafeDataReader.UaOkZYWnqm6SIngjGajU((object) this.reader, i));

    /// <inheritdoc />
    public override int GetInt32(int i) => SafeDataReader.kMnInqWnp2d97dEjc25V(SafeDataReader.UaOkZYWnqm6SIngjGajU((object) this.reader, i));

    /// <inheritdoc />
    public override long GetInt64(int i) => SafeDataReader.v4JAa1Wna45tS9bnIha6(SafeDataReader.UaOkZYWnqm6SIngjGajU((object) this.reader, i));

    /// <inheritdoc />
    public override string GetName(int i) => (string) SafeDataReader.fIP24RWnDt3fPayxU8yk((object) this.reader, i);

    /// <inheritdoc />
    public override int GetOrdinal(string name) => SafeDataReader.t7XHEmWntiUGNTG1qJHt((object) this.reader, (object) name);

    /// <inheritdoc />
    public override string GetString(int i) => (string) SafeDataReader.c43nuTWnw53V9l9H5qgr((object) this.reader, i);

    /// <inheritdoc />
    public override object GetValue(int i) => this.reader.GetValue(i);

    /// <inheritdoc />
    public override int GetValues(object[] values) => SafeDataReader.BikChCWn4wGlxiTEiR1U((object) this.reader, (object) values);

    /// <inheritdoc />
    public override bool IsDBNull(int i) => SafeDataReader.qsjaFpWn6owSvBDO3rKv((object) this.reader, i);

    /// <inheritdoc />
    public override object this[string name] => SafeDataReader.hu2XdWWnHqvZjkyK4OJ4((object) this.reader, (object) name);

    /// <inheritdoc />
    public override object this[int i] => SafeDataReader.kv2qxaWnARvFRhl1rqmK((object) this.reader, i);

    /// <inheritdoc />
    public override bool HasRows => SafeDataReader.mwaYnrWn7UdPgAuYKyHj((object) this.reader);

    /// <inheritdoc />
    public override IEnumerator GetEnumerator() => (IEnumerator) SafeDataReader.dAsMS6Wnx1PVx00d23g2((object) this.reader);

    /// <inheritdoc />
    public override Task<bool> ReadAsync(CancellationToken cancellationToken) => this.reader.ReadAsync(cancellationToken);

    /// <inheritdoc />
    public override Task<bool> NextResultAsync(CancellationToken cancellationToken) => this.reader.NextResultAsync(cancellationToken);

    /// <inheritdoc />
    public override Task<bool> IsDBNullAsync(int ordinal, CancellationToken cancellationToken) => this.reader.IsDBNullAsync(ordinal, cancellationToken);

    internal static object gkmqGWWnQEAMCfUayiWo(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool qbm5eEWnEjYeseWLwODQ() => SafeDataReader.e9qBlyWnGUSBkb5jHL55 == null;

    internal static SafeDataReader dNX9K2WnfHQjW2AGcZC4() => SafeDataReader.e9qBlyWnGUSBkb5jHL55;

    internal static void fswH6hWnCtZlvmvLTXCV([In] object obj0) => ((DbDataReader) obj0).Close();

    internal static object cNki1AWnv2yhxPcRLnOM([In] object obj0) => (object) ((DbDataReader) obj0).GetSchemaTable();

    internal static bool My18IeWn8XTK7VmyQ0lY([In] object obj0) => ((DbDataReader) obj0).IsClosed;

    internal static bool Oyy5NSWnZgaS22dOhQYt([In] object obj0) => ((DbDataReader) obj0).NextResult();

    internal static bool psQmfEWnuFpUlGBpZSDO([In] object obj0) => ((DbDataReader) obj0).Read();

    internal static int h38MVNWnIgJTmfiJ5EFd([In] object obj0) => ((DbDataReader) obj0).RecordsAffected;

    internal static void J7iSmRWnVCTgVcjrvIeF([In] object obj0) => ((DbDataReader) obj0).Dispose();

    internal static void cK9OcHWnSNr5K9tvyahi([In] object obj0) => ((Component) obj0).Dispose();

    internal static int tjG8WTWniaT9u1rOVvbQ([In] object obj0) => ((DbDataReader) obj0).FieldCount;

    internal static bool FFOfKwWnRabTkkcGZgCi([In] object obj0, [In] int obj1) => ((DbDataReader) obj0).GetBoolean(obj1);

    internal static object UaOkZYWnqm6SIngjGajU([In] object obj0, [In] int obj1) => ((DbDataReader) obj0).GetValue(obj1);

    internal static byte t1txjvWnKJHQlskNKwXM([In] object obj0) => Convert.ToByte(obj0);

    internal static long bufOGvWnXGeH3Gckc1ec(
      [In] object obj0,
      [In] int obj1,
      [In] long obj2,
      [In] object obj3,
      [In] int obj4,
      [In] int obj5)
    {
      return ((DbDataReader) obj0).GetBytes(obj1, obj2, (byte[]) obj3, obj4, obj5);
    }

    internal static char WuMC2XWnTZ2UUXS1hdkV([In] object obj0, [In] int obj1) => ((DbDataReader) obj0).GetChar(obj1);

    internal static long pCnlx6Wnk3anT5a2Et5I(
      [In] object obj0,
      [In] int obj1,
      [In] long obj2,
      [In] object obj3,
      [In] int obj4,
      [In] int obj5)
    {
      return ((DbDataReader) obj0).GetChars(obj1, obj2, (char[]) obj3, obj4, obj5);
    }

    internal static object YH0AJ0WnnJU5ihuP8kgZ([In] object obj0, [In] int obj1) => (object) ((DbDataReader) obj0).GetData(obj1);

    internal static object LSgCEMWnOlyDkc0aXtWp([In] object obj0, [In] int obj1) => (object) ((DbDataReader) obj0).GetDataTypeName(obj1);

    internal static DateTime TRiBbkWn2wuWUnOWMR12([In] object obj0, [In] int obj1) => ((DbDataReader) obj0).GetDateTime(obj1);

    internal static Decimal zJsQB4WnesFrnvej6dJL([In] object obj0) => Convert.ToDecimal(obj0);

    internal static double KJMk7OWnPxZULAeddL64([In] object obj0) => Convert.ToDouble(obj0);

    internal static float NkbWwDWn18H1lQ1gJB4q([In] object obj0, [In] int obj1) => ((DbDataReader) obj0).GetFloat(obj1);

    internal static Guid R8CiSNWnNxrYheINtK3I([In] object obj0, [In] int obj1) => ((DbDataReader) obj0).GetGuid(obj1);

    internal static short goJnL1Wn3NqALNofHRsl([In] object obj0) => Convert.ToInt16(obj0);

    internal static int kMnInqWnp2d97dEjc25V([In] object obj0) => Convert.ToInt32(obj0);

    internal static long v4JAa1Wna45tS9bnIha6([In] object obj0) => Convert.ToInt64(obj0);

    internal static object fIP24RWnDt3fPayxU8yk([In] object obj0, [In] int obj1) => (object) ((DbDataReader) obj0).GetName(obj1);

    internal static int t7XHEmWntiUGNTG1qJHt([In] object obj0, [In] object obj1) => ((DbDataReader) obj0).GetOrdinal((string) obj1);

    internal static object c43nuTWnw53V9l9H5qgr([In] object obj0, [In] int obj1) => (object) ((DbDataReader) obj0).GetString(obj1);

    internal static int BikChCWn4wGlxiTEiR1U([In] object obj0, [In] object obj1) => ((DbDataReader) obj0).GetValues((object[]) obj1);

    internal static bool qsjaFpWn6owSvBDO3rKv([In] object obj0, [In] int obj1) => ((DbDataReader) obj0).IsDBNull(obj1);

    internal static object hu2XdWWnHqvZjkyK4OJ4([In] object obj0, [In] object obj1) => ((DbDataReader) obj0)[(string) obj1];

    internal static object kv2qxaWnARvFRhl1rqmK([In] object obj0, [In] int obj1) => ((DbDataReader) obj0)[obj1];

    internal static bool mwaYnrWn7UdPgAuYKyHj([In] object obj0) => ((DbDataReader) obj0).HasRows;

    internal static object dAsMS6Wnx1PVx00d23g2([In] object obj0) => (object) ((DbDataReader) obj0).GetEnumerator();
  }
}
