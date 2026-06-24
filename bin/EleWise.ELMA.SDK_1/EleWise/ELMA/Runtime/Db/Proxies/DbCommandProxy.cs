// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Proxies.DbCommandProxy
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Diagnostics;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Db.Proxies
{
  public class DbCommandProxy : DbCommand
  {
    private DbCommand cmd;
    private readonly bool useSavePoint;
    private DbConnectionProxy conProxy;
    private DbTransactionProxy tranProxy;
    private static DbCommandProxy YheojxWixSvY3nIMeBJP;

    /// <summary>Ctor</summary>
    /// <param name="cmd">Команда</param>
    public DbCommandProxy(DbCommand cmd)
    {
      DbCommandProxy.xTiFiyWiyCq6cdIpiGLx();
      // ISSUE: explicit constructor call
      this.\u002Ector(cmd, true);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="cmd">Команда</param>
    /// <param name="useSavePoint">Использовать точки восстановления</param>
    internal DbCommandProxy(DbCommand cmd, bool useSavePoint)
    {
      DbCommandProxy.xTiFiyWiyCq6cdIpiGLx();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.cmd = cmd;
            num = 3;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.useSavePoint = useSavePoint;
            num = 2;
            continue;
          default:
            DbCommandProxy.cnQxFEWiMyfLIHuElmAc((object) cmd, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112666504));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    public DbCommand RealCommand => this.cmd;

    public override void Cancel()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.cmd.Cancel();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public override string CommandText
    {
      get => (string) DbCommandProxy.OT2hZ4WiJASqWRQP6Mqo((object) this.cmd);
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
              DbCommandProxy.NUE7FaWi9d89lwWZigjV((object) this.cmd, (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
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

    public override int CommandTimeout
    {
      get => DbCommandProxy.GrEF2FWidNfw7Vyca4Rd((object) this.cmd);
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
              DbCommandProxy.fdtZ2TWiluFgMSlmPDuX((object) this.cmd, value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
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

    public override CommandType CommandType
    {
      get => this.cmd.CommandType;
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
              DbCommandProxy.P8enEeWir08UfohbTusm((object) this.cmd, value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
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

    protected override DbConnection DbConnection
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 2:
              if (this.conProxy == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 0;
                continue;
              }
              goto case 3;
            case 3:
              if (DbCommandProxy.qo4wKmWigSPhJUXRp81C((object) this.conProxy) != DbCommandProxy.PLPiuvWi54TRfk0j7Dd8((object) this.cmd))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
                continue;
              }
              goto label_7;
            default:
              goto label_6;
          }
        }
label_6:
        return (DbConnection) DbCommandProxy.PLPiuvWi54TRfk0j7Dd8((object) this.cmd);
label_7:
        return (DbConnection) this.conProxy;
      }
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.conProxy = value as DbConnectionProxy;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              DbCommandProxy.L29c3JWijP5yJEo58JXE((object) this.cmd, this.conProxy != null ? DbCommandProxy.qo4wKmWigSPhJUXRp81C((object) this.conProxy) : (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 2 : 1;
              continue;
          }
        }
label_2:;
      }
    }

    protected override DbParameter CreateDbParameter() => this.cmd.CreateParameter();

    public override int ExecuteNonQuery()
    {
      int num1 = 2;
      SqlQueryInfo sqlQueryInfo;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            sqlQueryInfo = DiagnosticsManager.StartCall<SqlQueryInfo>((Func<SqlQueryInfo>) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    if (DbCommandProxy.iQ0a9oWRuJJIX7vaPNaa((object) this.cmd.CommandText))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_3;
                  default:
                    goto label_2;
                }
              }
label_2:
              return (SqlQueryInfo) null;
label_3:
              return new SqlQueryInfo((IDbCommand) this.cmd);
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      int num3;
      return num3;
label_4:
      try
      {
        int num4;
        if (this.useSavePoint)
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 1 : 1;
        else
          goto label_7;
label_6:
        bool flag;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_9;
            case 2:
              goto label_11;
            case 3:
              flag = false;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 2 : 1;
              continue;
            default:
              goto label_7;
          }
        }
label_9:
        object obj = DbCommandProxy.hObtjlWiYrXfqCup4TtA();
        goto label_10;
label_11:
        string str;
        try
        {
          int num5;
          if (!this.useSavePoint)
            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 7 : 5;
          else
            goto label_18;
label_13:
          int num6;
          while (true)
          {
            switch (num5)
            {
              case 1:
              case 4:
                if (sqlQueryInfo == null)
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
                  continue;
                }
                goto case 11;
              case 2:
                if (!flag)
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 1;
                  continue;
                }
                goto case 5;
              case 3:
                goto label_2;
              case 5:
                DbCommandProxy.o39RYQWisJ0G0j7YIsMM((object) str, (object) this.cmd);
                num5 = 10;
                continue;
              case 6:
                num6 = DbCommandProxy.bhkxCPWiU04UhfFijFro((object) this.cmd);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 1 : 2;
                continue;
              case 7:
                goto label_24;
              case 9:
                goto label_18;
              case 10:
                flag = false;
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 4 : 0;
                continue;
              case 11:
                sqlQueryInfo.RowsAffected = new long?((long) num6);
                num5 = 8;
                continue;
              default:
                num3 = num6;
                num5 = 3;
                continue;
            }
          }
label_24:
          int num7 = 0;
          goto label_25;
label_18:
          num7 = DbCommandProxy.aArDKSWiLqtPDPl3C6tU((object) str, (object) this.cmd) ? 1 : 0;
label_25:
          flag = num7 != 0;
          num5 = 6;
          goto label_13;
        }
        catch (Exception ex)
        {
          int num8 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
            num8 = 1;
          while (true)
          {
            switch (num8)
            {
              case 1:
                if (!flag)
                {
                  num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 3 : 3;
                  continue;
                }
                goto case 4;
              case 2:
              case 5:
                goto label_35;
              case 4:
                DbCommandProxy.cwYPdhWicCLgcWP4J05G((object) str, (object) this.cmd);
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
                continue;
              case 6:
                DbCommandProxy.LU17PLWizhS99HY3qcuK((object) sqlQueryInfo, (object) ex);
                num8 = 2;
                continue;
              default:
                if (sqlQueryInfo == null)
                {
                  num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 2 : 5;
                  continue;
                }
                goto case 6;
            }
          }
label_35:
          throw;
        }
label_7:
        obj = (object) string.Empty;
label_10:
        str = (string) obj;
        num4 = 3;
        goto label_6;
      }
      finally
      {
        int num9;
        if (sqlQueryInfo == null)
          num9 = 2;
        else
          goto label_39;
label_38:
        switch (num9)
        {
          case 1:
          case 2:
        }
label_39:
        DbCommandProxy.yphrHFWRFXvKxxFm2rS6((object) sqlQueryInfo);
        num9 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
        {
          num9 = 1;
          goto label_38;
        }
        else
          goto label_38;
      }
    }

    public new DbDataReader ExecuteReader()
    {
      int num1 = 6;
      bool flag;
      string str;
      SqlQueryInfo queryInfo;
      while (true)
      {
        object obj;
        switch (num1)
        {
          case 1:
            obj = (object) string.Empty;
            break;
          case 2:
            obj = DbCommandProxy.hObtjlWiYrXfqCup4TtA();
            break;
          case 3:
            goto label_5;
          case 4:
            goto label_34;
          case 5:
            if (this.useSavePoint)
            {
              num1 = 2;
              continue;
            }
            goto case 1;
          case 6:
            queryInfo = DiagnosticsManager.StartCall<SqlQueryInfo>((Func<SqlQueryInfo>) (() =>
            {
              int num2 = 2;
              while (true)
              {
                switch (num2)
                {
                  case 2:
                    if (this.cmd == null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 1;
                      continue;
                    }
                    goto case 3;
                  case 3:
                    if (DbCommandProxy.iQ0a9oWRuJJIX7vaPNaa(DbCommandProxy.OT2hZ4WiJASqWRQP6Mqo((object) this.cmd)))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_5;
                  default:
                    goto label_4;
                }
              }
label_4:
              return (SqlQueryInfo) null;
label_5:
              return new SqlQueryInfo((IDbCommand) this.cmd);
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 5 : 5;
            continue;
          default:
            flag = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 3 : 3;
            continue;
        }
        str = (string) obj;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
      }
label_5:
      DbDataReader dbDataReader;
      try
      {
        int num3;
        if (this.useSavePoint)
        {
          num3 = 9;
          goto label_8;
        }
        else
          goto label_19;
label_7:
        int num4;
        num3 = num4;
label_8:
        while (true)
        {
          DbDataReader reader;
          DataReaderProxy dataReaderProxy;
          switch (num3)
          {
            case 1:
              goto label_13;
            case 2:
              dataReaderProxy = new DataReaderProxy(reader, (DbCommand) this, queryInfo);
              break;
            case 4:
              goto label_34;
            case 5:
              flag = false;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
              continue;
            case 6:
              dbDataReader = reader;
              num3 = 4;
              continue;
            case 7:
              reader = this.cmd.ExecuteReader();
              num3 = 10;
              continue;
            case 8:
              dataReaderProxy = (DataReaderProxy) null;
              break;
            case 9:
              goto label_15;
            case 10:
              if (!flag)
              {
                num3 = 3;
                continue;
              }
              goto label_13;
            default:
              if (reader != null)
              {
                num3 = 2;
                continue;
              }
              goto case 8;
          }
          reader = (DbDataReader) dataReaderProxy;
          num3 = 6;
        }
label_13:
        DbCommandProxy.o39RYQWisJ0G0j7YIsMM((object) str, (object) this.cmd);
        num4 = 5;
        goto label_7;
label_15:
        int num5 = DbCommandProxy.aArDKSWiLqtPDPl3C6tU((object) str, (object) this.cmd) ? 1 : 0;
        goto label_20;
label_19:
        num5 = 0;
label_20:
        flag = num5 != 0;
        num4 = 7;
        goto label_7;
      }
      catch (Exception ex)
      {
        int num6 = 5;
        while (true)
        {
          switch (num6)
          {
            case 1:
              if (queryInfo == null)
              {
                num6 = 6;
                continue;
              }
              goto case 4;
            case 2:
              DbCommandProxy.cwYPdhWicCLgcWP4J05G((object) str, (object) this.cmd);
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 1 : 1;
              continue;
            case 3:
            case 6:
              goto label_32;
            case 4:
              queryInfo.Exception = ex;
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
              continue;
            case 5:
              if (flag)
              {
                num6 = 2;
                continue;
              }
              goto case 1;
            default:
              DbCommandProxy.poABfeWRBC1T3baMd2gT((object) queryInfo);
              num6 = 3;
              continue;
          }
        }
label_32:
        throw;
      }
label_34:
      return dbDataReader;
    }

    protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior)
    {
      int num1 = 2;
      SqlQueryInfo queryInfo;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            queryInfo = DiagnosticsManager.StartCall<SqlQueryInfo>((Func<SqlQueryInfo>) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    if (this.cmd == null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
                      continue;
                    }
                    goto case 3;
                  case 3:
                    if (DbCommandProxy.iQ0a9oWRuJJIX7vaPNaa((object) this.cmd.CommandText))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 2 : 0;
                      continue;
                    }
                    goto label_3;
                  default:
                    goto label_2;
                }
              }
label_2:
              return (SqlQueryInfo) null;
label_3:
              return new SqlQueryInfo((IDbCommand) this.cmd);
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 1 : 0;
            continue;
          default:
            goto label_18;
        }
      }
label_2:
      DbDataReader dbDataReader;
      try
      {
        DbDataReader reader = (DbDataReader) DbCommandProxy.E3YknHWRWBm0DkwtMlC1((object) this.cmd, behavior);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
          num3 = 0;
        while (true)
        {
          DataReaderProxy dataReaderProxy;
          switch (num3)
          {
            case 1:
              dataReaderProxy = new DataReaderProxy(reader, (DbCommand) this, queryInfo);
              break;
            case 2:
              goto label_18;
            case 3:
              dataReaderProxy = (DataReaderProxy) null;
              break;
            default:
              if (reader != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 1 : 1;
                continue;
              }
              goto case 3;
          }
          dbDataReader = (DbDataReader) dataReaderProxy;
          num3 = 2;
        }
      }
      catch (Exception ex)
      {
        int num4 = 3;
        while (true)
        {
          switch (num4)
          {
            case 1:
              DbCommandProxy.LU17PLWizhS99HY3qcuK((object) queryInfo, (object) ex);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_16;
            case 3:
              if (queryInfo != null)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 0;
                continue;
              }
              goto label_16;
            default:
              DbCommandProxy.poABfeWRBC1T3baMd2gT((object) queryInfo);
              num4 = 2;
              continue;
          }
        }
label_16:
        throw;
      }
label_18:
      return dbDataReader;
    }

    public override object ExecuteScalar()
    {
      int num1 = 1;
      SqlQueryInfo sqlQueryInfo;
      while (true)
      {
        switch (num1)
        {
          case 1:
            sqlQueryInfo = DiagnosticsManager.StartCall<SqlQueryInfo>((Func<SqlQueryInfo>) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    if (DbCommandProxy.iQ0a9oWRuJJIX7vaPNaa(DbCommandProxy.OT2hZ4WiJASqWRQP6Mqo((object) this.cmd)))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_5;
                  default:
                    goto label_4;
                }
              }
label_4:
              return (SqlQueryInfo) null;
label_5:
              return new SqlQueryInfo((IDbCommand) this.cmd);
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_44;
          default:
            goto label_2;
        }
      }
label_2:
      object obj1;
      try
      {
        int num3;
        if (this.useSavePoint)
          num3 = 2;
        else
          goto label_7;
label_5:
        bool flag;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_7;
            case 2:
              goto label_8;
            case 3:
              goto label_11;
            default:
              flag = false;
              num3 = 3;
              continue;
          }
        }
label_8:
        object obj2 = DbCommandProxy.hObtjlWiYrXfqCup4TtA();
        goto label_9;
label_11:
        string key;
        try
        {
          int num4;
          if (this.useSavePoint)
            num4 = 8;
          else
            goto label_25;
label_13:
          int num5 = num4;
label_14:
          object obj3;
          while (true)
          {
            switch (num5)
            {
              case 1:
                if (sqlQueryInfo == null)
                  break;
                goto label_21;
              case 2:
                goto label_24;
              case 3:
                goto label_44;
              case 4:
                flag = false;
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 1;
                continue;
              case 5:
                sqlQueryInfo.RowsAffected = new long?(1L);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
                continue;
              case 6:
                DbCommandProxy.o39RYQWisJ0G0j7YIsMM((object) key, (object) this.cmd);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 3 : 4;
                continue;
              case 7:
                if (flag)
                {
                  num5 = 6;
                  continue;
                }
                goto case 1;
              case 8:
                goto label_18;
            }
            obj1 = obj3;
            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 3 : 3;
          }
label_18:
          int num6 = SavePointHelper.SavePoint(key, (IDbCommand) this.cmd) ? 1 : 0;
          goto label_26;
label_21:
          num4 = 5;
          goto label_13;
label_24:
          obj3 = DbCommandProxy.jqGHrfWRod9qu7vImX8b((object) this.cmd);
          num4 = 7;
          goto label_13;
label_25:
          num6 = 0;
label_26:
          flag = num6 != 0;
          num5 = 2;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
          {
            num5 = 2;
            goto label_14;
          }
          else
            goto label_14;
        }
        catch (Exception ex)
        {
          int num7 = 4;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
            num7 = 2;
          while (true)
          {
            switch (num7)
            {
              case 2:
                if (sqlQueryInfo == null)
                {
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 1;
                  continue;
                }
                goto case 3;
              case 3:
                DbCommandProxy.LU17PLWizhS99HY3qcuK((object) sqlQueryInfo, (object) ex);
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
                continue;
              case 4:
                if (flag)
                {
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 5 : 1;
                  continue;
                }
                goto case 2;
              case 5:
                DbCommandProxy.cwYPdhWicCLgcWP4J05G((object) key, (object) this.cmd);
                num7 = 2;
                continue;
              default:
                goto label_37;
            }
          }
label_37:
          throw;
        }
label_7:
        obj2 = (object) string.Empty;
label_9:
        key = (string) obj2;
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        {
          num3 = 0;
          goto label_5;
        }
        else
          goto label_5;
      }
      finally
      {
        int num8;
        if (sqlQueryInfo == null)
          num8 = 2;
        else
          goto label_41;
label_40:
        switch (num8)
        {
          case 1:
            break;
          default:
        }
label_41:
        DbCommandProxy.yphrHFWRFXvKxxFm2rS6((object) sqlQueryInfo);
        num8 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
        {
          num8 = 0;
          goto label_40;
        }
        else
          goto label_40;
      }
label_44:
      return obj1;
    }

    protected override DbParameterCollection DbParameterCollection => (DbParameterCollection) DbCommandProxy.EVKpWNWRb57a284Eh2kn((object) this.cmd);

    public override void Prepare()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DbCommandProxy.iqpGUaWRhsIlASi5G8CE((object) this.cmd);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    protected override DbTransaction DbTransaction
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.tranProxy == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 3:
              if (this.tranProxy.RealTransaction != this.cmd.Transaction)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 2 : 2;
                continue;
              }
              goto label_7;
            default:
              goto label_6;
          }
        }
label_6:
        return (DbTransaction) DbCommandProxy.Qu6fESWRGY55riGTQtL1((object) this.cmd);
label_7:
        return (DbTransaction) this.tranProxy;
      }
      set
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_5;
            case 1:
              DbCommandProxy.f4lHBRWRftNtYgAjQfUi((object) this.cmd, this.tranProxy == null ? (object) value : DbCommandProxy.sgXCbiWREiXhD9U6NsvI((object) this.tranProxy));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
              continue;
            case 2:
              this.tranProxy = value as DbTransactionProxy;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 1;
              continue;
            default:
              goto label_2;
          }
        }
label_5:
        return;
label_2:;
      }
    }

    public override UpdateRowSource UpdatedRowSource
    {
      get => DbCommandProxy.kfks96WRQCDCeGP7YVqj((object) this.cmd);
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
              DbCommandProxy.qyVMwrWRC4T8dnpNH5b2((object) this.cmd, value);
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
    }

    public override bool DesignTimeVisible
    {
      get => DbCommandProxy.nnfh4eWRvHWsicDfvDP2((object) this.cmd);
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
              DbCommandProxy.NClqwDWR8pc2fK5kpqfr((object) this.cmd, value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
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

    protected override void Dispose(bool disposing)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (!disposing)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 1;
              continue;
            }
            break;
          case 3:
            goto label_2;
        }
        DbCommandProxy.eEKpgBWRZtgajwlBEB0v((object) this.cmd);
        num = 3;
      }
label_6:
      return;
label_2:;
    }

    internal static void xTiFiyWiyCq6cdIpiGLx() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool FoZSDtWi0xgyylYSvWg5() => DbCommandProxy.YheojxWixSvY3nIMeBJP == null;

    internal static DbCommandProxy gnEOH4WimWSZjxMAYF5C() => DbCommandProxy.YheojxWixSvY3nIMeBJP;

    internal static void cnQxFEWiMyfLIHuElmAc([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object OT2hZ4WiJASqWRQP6Mqo([In] object obj0) => (object) ((DbCommand) obj0).CommandText;

    internal static void NUE7FaWi9d89lwWZigjV([In] object obj0, [In] object obj1) => ((DbCommand) obj0).CommandText = (string) obj1;

    internal static int GrEF2FWidNfw7Vyca4Rd([In] object obj0) => ((DbCommand) obj0).CommandTimeout;

    internal static void fdtZ2TWiluFgMSlmPDuX([In] object obj0, [In] int obj1) => ((DbCommand) obj0).CommandTimeout = obj1;

    internal static void P8enEeWir08UfohbTusm([In] object obj0, [In] CommandType obj1) => ((DbCommand) obj0).CommandType = obj1;

    internal static object qo4wKmWigSPhJUXRp81C([In] object obj0) => (object) ((DbConnectionProxy) obj0).RealConnection;

    internal static object PLPiuvWi54TRfk0j7Dd8([In] object obj0) => (object) ((DbCommand) obj0).Connection;

    internal static void L29c3JWijP5yJEo58JXE([In] object obj0, [In] object obj1) => ((DbCommand) obj0).Connection = (DbConnection) obj1;

    internal static object hObtjlWiYrXfqCup4TtA() => (object) SavePointHelper.GetSavePointKey();

    internal static bool aArDKSWiLqtPDPl3C6tU([In] object obj0, [In] object obj1) => SavePointHelper.SavePoint((string) obj0, (IDbCommand) obj1);

    internal static int bhkxCPWiU04UhfFijFro([In] object obj0) => ((DbCommand) obj0).ExecuteNonQuery();

    internal static void o39RYQWisJ0G0j7YIsMM([In] object obj0, [In] object obj1) => SavePointHelper.ReleaseSavePoint((string) obj0, (IDbCommand) obj1);

    internal static void cwYPdhWicCLgcWP4J05G([In] object obj0, [In] object obj1) => SavePointHelper.RollBackSavePoint((string) obj0, (IDbCommand) obj1);

    internal static void LU17PLWizhS99HY3qcuK([In] object obj0, [In] object obj1) => ((AbstractCallInfo) obj0).Exception = (Exception) obj1;

    internal static void yphrHFWRFXvKxxFm2rS6([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void poABfeWRBC1T3baMd2gT([In] object obj0) => ((AbstractCallInfo) obj0).Dispose();

    internal static object E3YknHWRWBm0DkwtMlC1([In] object obj0, [In] CommandBehavior obj1) => (object) ((DbCommand) obj0).ExecuteReader(obj1);

    internal static object jqGHrfWRod9qu7vImX8b([In] object obj0) => ((DbCommand) obj0).ExecuteScalar();

    internal static object EVKpWNWRb57a284Eh2kn([In] object obj0) => (object) ((DbCommand) obj0).Parameters;

    internal static void iqpGUaWRhsIlASi5G8CE([In] object obj0) => ((DbCommand) obj0).Prepare();

    internal static object Qu6fESWRGY55riGTQtL1([In] object obj0) => (object) ((DbCommand) obj0).Transaction;

    internal static object sgXCbiWREiXhD9U6NsvI([In] object obj0) => (object) ((DbTransactionProxy) obj0).RealTransaction;

    internal static void f4lHBRWRftNtYgAjQfUi([In] object obj0, [In] object obj1) => ((DbCommand) obj0).Transaction = (DbTransaction) obj1;

    internal static UpdateRowSource kfks96WRQCDCeGP7YVqj([In] object obj0) => ((DbCommand) obj0).UpdatedRowSource;

    internal static void qyVMwrWRC4T8dnpNH5b2([In] object obj0, [In] UpdateRowSource obj1) => ((DbCommand) obj0).UpdatedRowSource = obj1;

    internal static bool nnfh4eWRvHWsicDfvDP2([In] object obj0) => ((DbCommand) obj0).DesignTimeVisible;

    internal static void NClqwDWR8pc2fK5kpqfr([In] object obj0, [In] bool obj1) => ((DbCommand) obj0).DesignTimeVisible = obj1;

    internal static void eEKpgBWRZtgajwlBEB0v([In] object obj0) => ((Component) obj0).Dispose();

    internal static bool iQ0a9oWRuJJIX7vaPNaa([In] object obj0) => string.IsNullOrEmpty((string) obj0);
  }
}
