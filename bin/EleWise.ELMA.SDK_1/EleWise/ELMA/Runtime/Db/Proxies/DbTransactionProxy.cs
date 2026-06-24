// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Proxies.DbTransactionProxy
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Data;
using System.Data.Common;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Db.Proxies
{
  public class DbTransactionProxy : DbTransaction
  {
    private DbConnectionProxy con;
    private DbTransaction tran;
    internal static DbTransactionProxy rbk3ddWRNS56pZG5K6pS;

    public DbTransactionProxy(DbConnectionProxy con, DbTransaction tran)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            goto label_4;
          case 2:
            goto label_6;
          case 3:
            this.tran = tran;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
            continue;
          case 4:
            if (con != null)
            {
              if (tran != null)
              {
                this.con = con;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 3 : 2;
                continue;
              }
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 1;
              continue;
            }
            num = 2;
            continue;
          default:
            goto label_11;
        }
      }
label_2:
      return;
label_11:
      return;
label_4:
      throw new ArgumentNullException((string) DbTransactionProxy.bSUG9dWRaicWDAxoYnbM(-1317790512 ^ -1317671470));
label_6:
      throw new ArgumentNullException((string) DbTransactionProxy.bSUG9dWRaicWDAxoYnbM(-342626196 - 1290888215 ^ -1633452883));
    }

    public DbTransaction RealTransaction => this.tran;

    public override void Commit()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DbTransactionProxy.KSs9vLWRDIyyyAEGVtDs((object) this.tran);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    protected override DbConnection DbConnection => (DbConnection) this.con;

    public override IsolationLevel IsolationLevel => DbTransactionProxy.hjjhRwWRtsWWsEcsOE7W((object) this.tran);

    public override void Rollback()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DbTransactionProxy.Pe5q4MWRwQ0gnu1c9jG2((object) this.tran);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    protected override void Dispose(bool disposing)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (disposing)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            goto label_2;
          default:
            DbTransactionProxy.CLkNZMWR4DeqintShNxh((object) this.tran);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 1 : 2;
            continue;
        }
      }
label_2:
      return;
label_6:;
    }

    internal static object bSUG9dWRaicWDAxoYnbM(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool SeuhZeWR34Zao7MTQ2qf() => DbTransactionProxy.rbk3ddWRNS56pZG5K6pS == null;

    internal static DbTransactionProxy bS5v4WWRpiFWsCpvNf4B() => DbTransactionProxy.rbk3ddWRNS56pZG5K6pS;

    internal static void KSs9vLWRDIyyyAEGVtDs([In] object obj0) => ((DbTransaction) obj0).Commit();

    internal static IsolationLevel hjjhRwWRtsWWsEcsOE7W([In] object obj0) => ((DbTransaction) obj0).IsolationLevel;

    internal static void Pe5q4MWRwQ0gnu1c9jG2([In] object obj0) => ((DbTransaction) obj0).Rollback();

    internal static void CLkNZMWR4DeqintShNxh([In] object obj0) => ((DbTransaction) obj0).Dispose();
  }
}
