// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Proxies.DbConnectionProxy
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Db.Proxies
{
  public class DbConnectionProxy : DbConnection
  {
    private DbConnection con;
    private readonly bool useSavePoint;
    private static DbConnectionProxy hvMewFWRIyM52c36WRdl;

    /// <summary>Ctor</summary>
    /// <param name="con">Соединение</param>
    public DbConnectionProxy(DbConnection con)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(con, true);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="con">Соединение</param>
    /// <param name="useSavePoint">Использовать точки восстановления</param>
    internal DbConnectionProxy(DbConnection con, bool useSavePoint)
    {
      DbConnectionProxy.at1sl5WRiMykvTy4DvYe();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            DbConnectionProxy.Bgw2GdWRqNfZ2T96xjYe((object) con, DbConnectionProxy.dXUNLiWRRqvbFKjy5QXw(-710283084 ^ -537863435 ^ 173595321));
            num = 3;
            continue;
          case 3:
            this.con = con;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
            continue;
          default:
            this.useSavePoint = useSavePoint;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    public DbConnection RealConnection => this.con;

    protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel)
    {
      int num = 1;
      DbTransaction tran;
      while (true)
      {
        switch (num)
        {
          case 1:
            tran = (DbTransaction) DbConnectionProxy.wfTFFVWRKuMaZ1JAHKVJ((object) this.con, isolationLevel);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            if (tran == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 2 : 2;
              continue;
            }
            goto label_3;
        }
      }
label_2:
      return (DbTransaction) null;
label_3:
      return (DbTransaction) new DbTransactionProxy(this, tran);
    }

    public override void ChangeDatabase(string databaseName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DbConnectionProxy.WN6c9HWRXlNwCyQYH9ED((object) this.con, (object) databaseName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

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
            this.con.Close();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public override string ConnectionString
    {
      get => this.con.ConnectionString;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.con.ConnectionString = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public override int ConnectionTimeout => DbConnectionProxy.BYdOfOWRTDIKtfiIubHU((object) this.con);

    protected override DbCommand CreateDbCommand()
    {
      int num = 5;
      DbCommand cmd;
      while (true)
      {
        switch (num)
        {
          case 2:
            this.OnCreateCommandAction((IDbCommand) cmd);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
            continue;
          case 3:
            goto label_2;
          case 4:
            if (this.OnCreateCommandAction == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 1;
              continue;
            }
            goto case 2;
          case 5:
            cmd = (DbCommand) DbConnectionProxy.BNySK4WRkH5ZIK7VVvmB((object) this.con);
            num = 4;
            continue;
          case 6:
            goto label_3;
          default:
            if (cmd != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 6 : 0;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      return (DbCommand) null;
label_3:
      return (DbCommand) new DbCommandProxy(cmd, this.useSavePoint);
    }

    public override string Database => (string) DbConnectionProxy.wdxHQZWRnhtPEdcJd8GC((object) this.con);

    public override void Open()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DbConnectionProxy.Ss41dbWROSTBILS7pSJG((object) this.con);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public override ConnectionState State => DbConnectionProxy.MbZ9GgWR2ag8RtQ8Gr8t((object) this.con);

    public new void Dispose()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DbConnectionProxy.lutMEOWReVjLL3sqxAV4((object) this.con);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public Action<IDbCommand> OnCreateCommandAction { get; set; }

    public override string DataSource => (string) DbConnectionProxy.C34anGWRP7ahRiNcXRnx((object) this.con);

    public override string ServerVersion => (string) DbConnectionProxy.BwH5hsWR10IWpknTCRsS((object) this.con);

    internal static bool DxZs8cWRVI1hy7xBwMxf() => DbConnectionProxy.hvMewFWRIyM52c36WRdl == null;

    internal static DbConnectionProxy vyrkmCWRSb9lB5EGCjxP() => DbConnectionProxy.hvMewFWRIyM52c36WRdl;

    internal static void at1sl5WRiMykvTy4DvYe() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object dXUNLiWRRqvbFKjy5QXw(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void Bgw2GdWRqNfZ2T96xjYe([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object wfTFFVWRKuMaZ1JAHKVJ([In] object obj0, [In] IsolationLevel obj1) => (object) ((DbConnection) obj0).BeginTransaction(obj1);

    internal static void WN6c9HWRXlNwCyQYH9ED([In] object obj0, [In] object obj1) => ((DbConnection) obj0).ChangeDatabase((string) obj1);

    internal static int BYdOfOWRTDIKtfiIubHU([In] object obj0) => ((DbConnection) obj0).ConnectionTimeout;

    internal static object BNySK4WRkH5ZIK7VVvmB([In] object obj0) => (object) ((DbConnection) obj0).CreateCommand();

    internal static object wdxHQZWRnhtPEdcJd8GC([In] object obj0) => (object) ((DbConnection) obj0).Database;

    internal static void Ss41dbWROSTBILS7pSJG([In] object obj0) => ((DbConnection) obj0).Open();

    internal static ConnectionState MbZ9GgWR2ag8RtQ8Gr8t([In] object obj0) => ((DbConnection) obj0).State;

    internal static void lutMEOWReVjLL3sqxAV4([In] object obj0) => ((Component) obj0).Dispose();

    internal static object C34anGWRP7ahRiNcXRnx([In] object obj0) => (object) ((DbConnection) obj0).DataSource;

    internal static object BwH5hsWR10IWpknTCRsS([In] object obj0) => (object) ((DbConnection) obj0).ServerVersion;
  }
}
