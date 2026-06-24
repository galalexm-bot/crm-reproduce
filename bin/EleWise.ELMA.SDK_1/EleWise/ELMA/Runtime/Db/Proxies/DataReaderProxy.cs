// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Proxies.DataReaderProxy
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Driver;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Db.Proxies
{
  /// <summary>Прокси для DataReader</summary>
  public class DataReaderProxy : 
    DbDataReader,
    IDataReaderProxy,
    IDataReader,
    IDisposable,
    IDataRecord
  {
    private readonly DbDataReader reader;
    private readonly DbCommand cmd;
    private readonly SqlQueryInfo queryInfo;
    internal static DataReaderProxy nCblicWR6DQB7Py6Nej8;

    /// <summary>Ctor</summary>
    /// <param name="reader"></param>
    /// <param name="cmd"></param>
    public DataReaderProxy(DbDataReader reader, DbCommand cmd)
    {
      DataReaderProxy.FnHFuaWR7VKJsSsmj1Kw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
        num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.cmd = cmd;
            num = 2;
            continue;
          case 2:
            goto label_3;
          case 3:
            if (reader != null)
            {
              this.reader = reader;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_3:
      return;
label_4:
      throw new ArgumentNullException((string) DataReaderProxy.m9hA2cWRxCRFKUFdlubn(272623989 ^ 272504955));
    }

    /// <summary>Ctor</summary>
    /// <param name="reader"></param>
    /// <param name="cmd"></param>
    /// <param name="queryInfo"></param>
    public DataReaderProxy(DbDataReader reader, DbCommand cmd, SqlQueryInfo queryInfo)
    {
      DataReaderProxy.FnHFuaWR7VKJsSsmj1Kw();
      // ISSUE: explicit constructor call
      this.\u002Ector(reader, cmd);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.queryInfo = queryInfo;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public DbDataReader Target => this.reader;

    /// <inheritdoc />
    public override void Close()
    {
      int num1 = 1;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_14;
          default:
            goto label_3;
        }
      }
label_14:
      return;
label_3:
      try
      {
        DataReaderProxy.NmUk09WR0ajm0VIQlhwu((object) this.reader);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        int num3;
        if (interceptor == null)
          num3 = 2;
        else
          goto label_12;
label_10:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_12:
        DataReaderProxy.CxTUe5WRmNMaEGpiZkAQ((object) interceptor);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
        {
          num3 = 0;
          goto label_10;
        }
        else
          goto label_10;
      }
    }

    /// <inheritdoc />
    public override int Depth
    {
      get
      {
        int num1 = 2;
        DataReaderProxy.Interceptor interceptor;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_3;
            case 2:
              interceptor = new DataReaderProxy.Interceptor(this);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 0;
              continue;
            default:
              goto label_12;
          }
        }
label_3:
        int depth;
        try
        {
          depth = this.reader.Depth;
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
            num2 = 0;
          switch (num2)
          {
          }
        }
        finally
        {
          if (interceptor != null)
          {
            int num3 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
              num3 = 0;
            while (true)
            {
              switch (num3)
              {
                case 1:
                  goto label_11;
                default:
                  interceptor.Dispose();
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 1 : 1;
                  continue;
              }
            }
          }
label_11:;
        }
label_12:
        return depth;
      }
    }

    /// <inheritdoc />
    public override DataTable GetSchemaTable()
    {
      int num1 = 1;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_13;
          default:
            goto label_2;
        }
      }
label_2:
      DataTable schemaTable;
      try
      {
        schemaTable = (DataTable) DataReaderProxy.dlKYy8WRy6ZHPpxgdWCj((object) this.reader);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        if (interceptor != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_11;
              default:
                DataReaderProxy.CxTUe5WRmNMaEGpiZkAQ((object) interceptor);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 1;
                continue;
            }
          }
        }
label_11:;
      }
label_13:
      return schemaTable;
    }

    /// <inheritdoc />
    public override bool IsClosed
    {
      get
      {
        int num1 = 2;
        DataReaderProxy.Interceptor interceptor;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_2;
            case 2:
              interceptor = new DataReaderProxy.Interceptor(this);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 1;
              continue;
            default:
              goto label_12;
          }
        }
label_2:
        bool isClosed;
        try
        {
          isClosed = DataReaderProxy.f79cDAWRMDO3H7FpJ7qi((object) this.reader);
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
            num2 = 0;
          switch (num2)
          {
          }
        }
        finally
        {
          int num3;
          if (interceptor == null)
            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
          else
            goto label_8;
label_7:
          switch (num3)
          {
            case 1:
              break;
            default:
          }
label_8:
          DataReaderProxy.CxTUe5WRmNMaEGpiZkAQ((object) interceptor);
          num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
          {
            num3 = 2;
            goto label_7;
          }
          else
            goto label_7;
        }
label_12:
        return isClosed;
      }
    }

    /// <inheritdoc />
    public override bool NextResult()
    {
      int num1 = 1;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      bool flag;
      return flag;
label_3:
      try
      {
        flag = DataReaderProxy.IcdQMZWRJyVtcEFpwORS((object) this.reader);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_2;
        }
      }
      finally
      {
        int num3;
        if (interceptor == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
        else
          goto label_10;
label_9:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_10:
        DataReaderProxy.CxTUe5WRmNMaEGpiZkAQ((object) interceptor);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
        {
          num3 = 2;
          goto label_9;
        }
        else
          goto label_9;
      }
    }

    /// <inheritdoc />
    public override bool Read()
    {
      int num1 = 2;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            interceptor = new DataReaderProxy.Interceptor(this, 1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      bool flag;
      return flag;
label_4:
      try
      {
        flag = DataReaderProxy.fgDmm3WR9V4IsukavHns((object) this.reader);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_3;
        }
      }
      catch (Exception ex)
      {
        int num3 = 4;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
          num3 = 4;
        while (true)
        {
          IUnitOfWorkManager service;
          ITransformationProvider transformationProvider1;
          ITransformationProvider transformationProvider2;
          switch (num3)
          {
            case 1:
              if (!DataReaderProxy.KhPLLsWRlT8GL25j26C8((object) transformationProvider1, (object) ex))
              {
                num3 = 7;
                continue;
              }
              goto case 6;
            case 2:
              service.ThrowExceptionOnCommit(ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 3 : 3;
              continue;
            case 4:
              if (!DataReaderProxy.VtHUoZWRdE97SfLvxRwb())
              {
                num3 = 5;
                continue;
              }
              transformationProvider2 = Locator.GetService<ITransformationProvider>();
              break;
            case 5:
              transformationProvider2 = (ITransformationProvider) null;
              break;
            case 6:
              service = Locator.GetService<IUnitOfWorkManager>();
              num3 = 9;
              continue;
            case 8:
              if (transformationProvider1 != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 1 : 0;
                continue;
              }
              goto label_23;
            case 9:
              if (service == null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            default:
              goto label_23;
          }
          transformationProvider1 = transformationProvider2;
          num3 = 8;
        }
label_23:
        throw;
      }
      finally
      {
        if (interceptor != null)
        {
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
            num4 = 0;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_29;
              default:
                interceptor.Dispose();
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 1;
                continue;
            }
          }
        }
label_29:;
      }
    }

    /// <inheritdoc />
    public override int RecordsAffected
    {
      get
      {
        int num1 = 2;
        DataReaderProxy.Interceptor interceptor;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_2;
            case 2:
              interceptor = new DataReaderProxy.Interceptor(this);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 1 : 0;
              continue;
            default:
              goto label_12;
          }
        }
label_2:
        int recordsAffected;
        try
        {
          recordsAffected = DataReaderProxy.g2PmjXWRrYardsRD18er((object) this.reader);
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
            num2 = 0;
          switch (num2)
          {
          }
        }
        finally
        {
          if (interceptor != null)
          {
            int num3 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
              num3 = 0;
            while (true)
            {
              switch (num3)
              {
                case 1:
                  goto label_10;
                default:
                  DataReaderProxy.CxTUe5WRmNMaEGpiZkAQ((object) interceptor);
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 1;
                  continue;
              }
            }
          }
label_10:;
        }
label_12:
        return recordsAffected;
      }
    }

    /// <inheritdoc />
    protected override void Dispose(bool disposing)
    {
      int num1 = 2;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_13;
          case 1:
            try
            {
              DataReaderProxy.tciSZiWRgZdpUgwZ4E6x((object) this.reader);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_3;
              }
            }
            finally
            {
              int num3;
              if (interceptor == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 1;
              else
                goto label_11;
label_9:
              switch (num3)
              {
                case 2:
                  break;
                default:
              }
label_11:
              DataReaderProxy.CxTUe5WRmNMaEGpiZkAQ((object) interceptor);
              num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
              {
                num3 = 0;
                goto label_9;
              }
              else
                goto label_9;
            }
          case 2:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 1;
            continue;
          case 3:
label_3:
            DiagnosticsManager.StopCall((AbstractCallInfo) this.queryInfo);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
            continue;
          default:
            goto label_10;
        }
      }
label_13:
      return;
label_10:;
    }

    /// <inheritdoc />
    public override int FieldCount
    {
      get
      {
        int num1 = 2;
        DataReaderProxy.Interceptor interceptor;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_4;
            case 2:
              interceptor = new DataReaderProxy.Interceptor(this);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 1;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        int fieldCount;
        return fieldCount;
label_4:
        try
        {
          fieldCount = DataReaderProxy.cqcpAIWR5mavqTCI6ASm((object) this.reader);
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
            num2 = 0;
          switch (num2)
          {
            default:
              goto label_2;
          }
        }
        finally
        {
          int num3;
          if (interceptor == null)
            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
          else
            goto label_10;
label_9:
          switch (num3)
          {
            case 2:
              break;
            default:
          }
label_10:
          interceptor.Dispose();
          num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
          {
            num3 = 0;
            goto label_9;
          }
          else
            goto label_9;
        }
      }
    }

    /// <inheritdoc />
    public override bool HasRows => this.reader.HasRows;

    /// <inheritdoc />
    public override bool GetBoolean(int i)
    {
      int num1 = 1;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_4;
        }
      }
label_2:
      bool boolean;
      return boolean;
label_4:
      try
      {
        boolean = DataReaderProxy.QVNlGRWRj80qLGNAB2JX((object) this.reader, i);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_2;
        }
      }
      finally
      {
        if (interceptor != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                DataReaderProxy.CxTUe5WRmNMaEGpiZkAQ((object) interceptor);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
                continue;
              default:
                goto label_13;
            }
          }
        }
label_13:;
      }
    }

    /// <inheritdoc />
    public override byte GetByte(int i)
    {
      int num1 = 2;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 0;
            continue;
          default:
            goto label_11;
        }
      }
label_2:
      byte num2;
      try
      {
        num2 = DataReaderProxy.yTcbegWRYly6Uplr28yh((object) this.reader, i);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
      finally
      {
        int num4;
        if (interceptor == null)
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
        else
          goto label_8;
label_7:
        switch (num4)
        {
          case 2:
            break;
          default:
        }
label_8:
        DataReaderProxy.CxTUe5WRmNMaEGpiZkAQ((object) interceptor);
        num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
        {
          num4 = 1;
          goto label_7;
        }
        else
          goto label_7;
      }
label_11:
      return num2;
    }

    /// <inheritdoc />
    public override long GetBytes(
      int i,
      long fieldOffset,
      byte[] buffer,
      int bufferoffset,
      int length)
    {
      int num1 = 1;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_13;
          default:
            goto label_3;
        }
      }
label_3:
      long bytes;
      try
      {
        bytes = DataReaderProxy.BjOWYLWRLFtDM7BQBO8D((object) this.reader, i, fieldOffset, (object) buffer, bufferoffset, length);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        if (interceptor != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_12;
              default:
                DataReaderProxy.CxTUe5WRmNMaEGpiZkAQ((object) interceptor);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_12:;
      }
label_13:
      return bytes;
    }

    /// <inheritdoc />
    public override char GetChar(int i)
    {
      int num1 = 1;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_4;
        }
      }
label_2:
      char ch;
      return ch;
label_4:
      try
      {
        ch = DataReaderProxy.ljNMWoWRUlWRY5P9cb0k((object) this.reader, i);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_2;
        }
      }
      finally
      {
        if (interceptor != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_13;
              default:
                DataReaderProxy.CxTUe5WRmNMaEGpiZkAQ((object) interceptor);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_13:;
      }
    }

    /// <inheritdoc />
    public override long GetChars(
      int i,
      long fieldoffset,
      char[] buffer,
      int bufferoffset,
      int length)
    {
      int num1 = 2;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 1;
            continue;
          default:
            goto label_12;
        }
      }
label_2:
      long chars;
      try
      {
        chars = DataReaderProxy.CBKqPaWRs1PjbX4noUGb((object) this.reader, i, fieldoffset, (object) buffer, bufferoffset, length);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        int num3;
        if (interceptor == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
        else
          goto label_8;
label_7:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_8:
        DataReaderProxy.CxTUe5WRmNMaEGpiZkAQ((object) interceptor);
        num3 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
        {
          num3 = 2;
          goto label_7;
        }
        else
          goto label_7;
      }
label_12:
      return chars;
    }

    /// <summary>
    /// Возвращает <see cref="T:System.Data.Common.DbDataReader" /> объекта для запрошенного порядкового номера столбца.
    /// </summary>
    /// <param name="ordinal">Порядковый номер столбца (от нуля)</param>
    /// <returns><see cref="T:System.Data.Common.DbDataReader" /></returns>
    protected override DbDataReader GetDbDataReader(int ordinal)
    {
      int num1 = 2;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 1 : 1;
            continue;
          default:
            goto label_11;
        }
      }
label_2:
      DbDataReader dbDataReader;
      try
      {
        dbDataReader = (DbDataReader) DataReaderProxy.Rj0DBlWRcQI0XHfiSZ9D((object) this.reader, ordinal);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        if (interceptor != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                interceptor.Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
                continue;
              default:
                goto label_10;
            }
          }
        }
label_10:;
      }
label_11:
      return dbDataReader;
    }

    /// <inheritdoc />
    public override string GetDataTypeName(int i)
    {
      int num1 = 1;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      string dataTypeName;
      return dataTypeName;
label_3:
      try
      {
        dataTypeName = (string) DataReaderProxy.dRtaOhWRzNZTFw2vYm8e((object) this.reader, i);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_2;
        }
      }
      finally
      {
        int num3;
        if (interceptor == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
        else
          goto label_10;
label_9:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_10:
        DataReaderProxy.CxTUe5WRmNMaEGpiZkAQ((object) interceptor);
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
        {
          num3 = 1;
          goto label_9;
        }
        else
          goto label_9;
      }
    }

    /// <inheritdoc />
    public override DateTime GetDateTime(int i)
    {
      int num1 = 1;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_13;
          default:
            goto label_3;
        }
      }
label_3:
      DateTime dateTime;
      try
      {
        dateTime = DataReaderProxy.TqYrqKWqFfCuyQNlL4n4((object) this.reader, i);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        if (interceptor != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_12;
              default:
                interceptor.Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_12:;
      }
label_13:
      return dateTime;
    }

    /// <inheritdoc />
    public override Decimal GetDecimal(int i)
    {
      int num1 = 1;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            goto label_4;
        }
      }
label_3:
      Decimal num2;
      return num2;
label_4:
      try
      {
        num2 = this.reader.GetDecimal(i);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
          num3 = 0;
        switch (num3)
        {
          default:
            goto label_3;
        }
      }
      finally
      {
        if (interceptor != null)
        {
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
            num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 1:
                DataReaderProxy.CxTUe5WRmNMaEGpiZkAQ((object) interceptor);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                continue;
              default:
                goto label_13;
            }
          }
        }
label_13:;
      }
    }

    /// <inheritdoc />
    public override double GetDouble(int i)
    {
      int num1 = 2;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      double num2;
      return num2;
label_4:
      try
      {
        num2 = DataReaderProxy.QwrN8QWqBBQU37mroRGD((object) this.reader, i);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
            goto label_3;
        }
      }
      finally
      {
        int num4;
        if (interceptor == null)
          num4 = 2;
        else
          goto label_10;
label_9:
        switch (num4)
        {
          case 1:
            break;
          default:
        }
label_10:
        DataReaderProxy.CxTUe5WRmNMaEGpiZkAQ((object) interceptor);
        num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
        {
          num4 = 0;
          goto label_9;
        }
        else
          goto label_9;
      }
    }

    /// <inheritdoc />
    public override Type GetFieldType(int i)
    {
      int num1 = 1;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            goto label_4;
        }
      }
label_3:
      Type fieldType;
      return fieldType;
label_4:
      try
      {
        fieldType = DataReaderProxy.yo96ldWqW6UaeLJ9aOdD((object) this.reader, i);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_3;
        }
      }
      finally
      {
        if (interceptor != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                DataReaderProxy.CxTUe5WRmNMaEGpiZkAQ((object) interceptor);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
                continue;
              default:
                goto label_13;
            }
          }
        }
label_13:;
      }
    }

    /// <inheritdoc />
    public override float GetFloat(int i)
    {
      int num1 = 1;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_4;
        }
      }
label_2:
      float num2;
      return num2;
label_4:
      try
      {
        num2 = DataReaderProxy.KEbiKZWqorZudNXKtDOI((object) this.reader, i);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
            goto label_2;
        }
      }
      finally
      {
        if (interceptor != null)
        {
          int num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
            num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 1:
                DataReaderProxy.CxTUe5WRmNMaEGpiZkAQ((object) interceptor);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
                continue;
              default:
                goto label_13;
            }
          }
        }
label_13:;
      }
    }

    /// <inheritdoc />
    public override Guid GetGuid(int i)
    {
      int num1 = 1;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_13;
          default:
            goto label_2;
        }
      }
label_2:
      Guid guid;
      try
      {
        guid = DataReaderProxy.L2OXdsWqbyUPUdsZoSPt((object) this.reader, i);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        if (interceptor != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_11;
              default:
                DataReaderProxy.CxTUe5WRmNMaEGpiZkAQ((object) interceptor);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 1 : 0;
                continue;
            }
          }
        }
label_11:;
      }
label_13:
      return guid;
    }

    /// <inheritdoc />
    public override short GetInt16(int i)
    {
      int num1 = 2;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 0;
            continue;
          default:
            goto label_12;
        }
      }
label_2:
      short int16;
      try
      {
        int16 = this.reader.GetInt16(i);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        if (interceptor != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_10;
              default:
                DataReaderProxy.CxTUe5WRmNMaEGpiZkAQ((object) interceptor);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_10:;
      }
label_12:
      return int16;
    }

    /// <inheritdoc />
    public override int GetInt32(int i)
    {
      int num1 = 2;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 1;
            continue;
          default:
            goto label_11;
        }
      }
label_2:
      int int32;
      try
      {
        int32 = DataReaderProxy.nCRH6BWqhcjUixGWJUXI((object) this.reader, i);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        if (interceptor != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                DataReaderProxy.CxTUe5WRmNMaEGpiZkAQ((object) interceptor);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
                continue;
              default:
                goto label_10;
            }
          }
        }
label_10:;
      }
label_11:
      return int32;
    }

    /// <inheritdoc />
    public override long GetInt64(int i)
    {
      int num1 = 2;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      long int64;
      return int64;
label_3:
      try
      {
        int64 = this.reader.GetInt64(i);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_2;
        }
      }
      finally
      {
        if (interceptor != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_11;
              default:
                interceptor.Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_11:;
      }
    }

    /// <inheritdoc />
    public override string GetName(int i)
    {
      int num1 = 2;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      string name;
      return name;
label_4:
      try
      {
        name = this.reader.GetName(i);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_2;
        }
      }
      finally
      {
        if (interceptor != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_12;
              default:
                DataReaderProxy.CxTUe5WRmNMaEGpiZkAQ((object) interceptor);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 0;
                continue;
            }
          }
        }
label_12:;
      }
    }

    /// <inheritdoc />
    public override int GetOrdinal(string name)
    {
      int num1 = 2;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      int ordinal;
      return ordinal;
label_4:
      try
      {
        ordinal = DataReaderProxy.uRZulDWqGx6r0sO9p8Uq((object) this.reader, (object) name);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_2;
        }
      }
      finally
      {
        if (interceptor != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                interceptor.Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                continue;
              default:
                goto label_12;
            }
          }
        }
label_12:;
      }
    }

    /// <inheritdoc />
    public override string GetString(int i)
    {
      int num1 = 2;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      string str;
      return str;
label_3:
      try
      {
        str = this.reader.GetString(i);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_2;
        }
      }
      finally
      {
        if (interceptor != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                DataReaderProxy.CxTUe5WRmNMaEGpiZkAQ((object) interceptor);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
                continue;
              default:
                goto label_11;
            }
          }
        }
label_11:;
      }
    }

    /// <inheritdoc />
    public override object GetValue(int i)
    {
      int num1 = 1;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_4;
        }
      }
label_2:
      object obj;
      return obj;
label_4:
      try
      {
        obj = DataReaderProxy.zLjqHmWqEVGgyFyvI14M((object) this.reader, i);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_2;
        }
      }
      finally
      {
        int num3;
        if (interceptor == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
        else
          goto label_11;
label_10:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_11:
        DataReaderProxy.CxTUe5WRmNMaEGpiZkAQ((object) interceptor);
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
        {
          num3 = 1;
          goto label_10;
        }
        else
          goto label_10;
      }
    }

    /// <inheritdoc />
    public override int GetValues(object[] values)
    {
      int num1 = 1;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_13;
          default:
            goto label_2;
        }
      }
label_2:
      int values1;
      try
      {
        values1 = DataReaderProxy.FZvJkXWqfdvuGjBPvFe0((object) this.reader, (object) values);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        if (interceptor != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_11;
              default:
                DataReaderProxy.CxTUe5WRmNMaEGpiZkAQ((object) interceptor);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_11:;
      }
label_13:
      return values1;
    }

    /// <inheritdoc />
    public override bool IsDBNull(int i)
    {
      int num1 = 2;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 1;
            continue;
          default:
            goto label_12;
        }
      }
label_3:
      bool flag;
      try
      {
        flag = DataReaderProxy.WBga1BWqQAdENirrSsvk((object) this.reader, i);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        int num3;
        if (interceptor == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 0;
        else
          goto label_9;
label_8:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_9:
        interceptor.Dispose();
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
        {
          num3 = 0;
          goto label_8;
        }
        else
          goto label_8;
      }
label_12:
      return flag;
    }

    /// <inheritdoc />
    public override object this[string name]
    {
      get
      {
        int num1 = 2;
        DataReaderProxy.Interceptor interceptor;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_4;
            case 2:
              interceptor = new DataReaderProxy.Interceptor(this);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 1;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        object obj;
        return obj;
label_4:
        try
        {
          obj = DataReaderProxy.enZwgbWqC8vl3pkqmVkb((object) this.reader, (object) name);
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
            num2 = 0;
          switch (num2)
          {
            default:
              goto label_2;
          }
        }
        finally
        {
          if (interceptor != null)
          {
            int num3 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
              num3 = 0;
            while (true)
            {
              switch (num3)
              {
                case 1:
                  interceptor.Dispose();
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_12;
              }
            }
          }
label_12:;
        }
      }
    }

    /// <inheritdoc />
    public override object this[int ordinal]
    {
      get
      {
        int num1 = 2;
        DataReaderProxy.Interceptor interceptor;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_4;
            case 2:
              interceptor = new DataReaderProxy.Interceptor(this);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        object obj;
        return obj;
label_4:
        try
        {
          obj = this.reader[ordinal];
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
            num2 = 0;
          switch (num2)
          {
            default:
              goto label_2;
          }
        }
        finally
        {
          if (interceptor != null)
          {
            int num3 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
              num3 = 0;
            while (true)
            {
              switch (num3)
              {
                case 1:
                  goto label_12;
                default:
                  DataReaderProxy.CxTUe5WRmNMaEGpiZkAQ((object) interceptor);
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 1;
                  continue;
              }
            }
          }
label_12:;
        }
      }
    }

    /// <inheritdoc />
    public override IEnumerator GetEnumerator()
    {
      int num1 = 1;
      DataReaderProxy.Interceptor interceptor;
      while (true)
      {
        switch (num1)
        {
          case 1:
            interceptor = new DataReaderProxy.Interceptor(this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_4;
        }
      }
label_2:
      IEnumerator enumerator;
      return enumerator;
label_4:
      try
      {
        enumerator = (IEnumerator) new DbEnumerator(this.reader);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_2;
        }
      }
      finally
      {
        if (interceptor != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_13;
              default:
                DataReaderProxy.CxTUe5WRmNMaEGpiZkAQ((object) interceptor);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_13:;
      }
    }

    internal static void FnHFuaWR7VKJsSsmj1Kw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object m9hA2cWRxCRFKUFdlubn(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool z1PMqQWRHwDRPllwLnaW() => DataReaderProxy.nCblicWR6DQB7Py6Nej8 == null;

    internal static DataReaderProxy k7D5XNWRA5OmiChC3foc() => DataReaderProxy.nCblicWR6DQB7Py6Nej8;

    internal static void NmUk09WR0ajm0VIQlhwu([In] object obj0) => ((DbDataReader) obj0).Close();

    internal static void CxTUe5WRmNMaEGpiZkAQ([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object dlKYy8WRy6ZHPpxgdWCj([In] object obj0) => (object) ((DbDataReader) obj0).GetSchemaTable();

    internal static bool f79cDAWRMDO3H7FpJ7qi([In] object obj0) => ((DbDataReader) obj0).IsClosed;

    internal static bool IcdQMZWRJyVtcEFpwORS([In] object obj0) => ((DbDataReader) obj0).NextResult();

    internal static bool fgDmm3WR9V4IsukavHns([In] object obj0) => ((DbDataReader) obj0).Read();

    internal static bool VtHUoZWRdE97SfLvxRwb() => Locator.Initialized;

    internal static bool KhPLLsWRlT8GL25j26C8([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).IsUnrecoverableException((Exception) obj1);

    internal static int g2PmjXWRrYardsRD18er([In] object obj0) => ((DbDataReader) obj0).RecordsAffected;

    internal static void tciSZiWRgZdpUgwZ4E6x([In] object obj0) => ((DbDataReader) obj0).Dispose();

    internal static int cqcpAIWR5mavqTCI6ASm([In] object obj0) => ((DbDataReader) obj0).FieldCount;

    internal static bool QVNlGRWRj80qLGNAB2JX([In] object obj0, [In] int obj1) => ((DbDataReader) obj0).GetBoolean(obj1);

    internal static byte yTcbegWRYly6Uplr28yh([In] object obj0, [In] int obj1) => ((DbDataReader) obj0).GetByte(obj1);

    internal static long BjOWYLWRLFtDM7BQBO8D(
      [In] object obj0,
      [In] int obj1,
      [In] long obj2,
      [In] object obj3,
      [In] int obj4,
      [In] int obj5)
    {
      return ((DbDataReader) obj0).GetBytes(obj1, obj2, (byte[]) obj3, obj4, obj5);
    }

    internal static char ljNMWoWRUlWRY5P9cb0k([In] object obj0, [In] int obj1) => ((DbDataReader) obj0).GetChar(obj1);

    internal static long CBKqPaWRs1PjbX4noUGb(
      [In] object obj0,
      [In] int obj1,
      [In] long obj2,
      [In] object obj3,
      [In] int obj4,
      [In] int obj5)
    {
      return ((DbDataReader) obj0).GetChars(obj1, obj2, (char[]) obj3, obj4, obj5);
    }

    internal static object Rj0DBlWRcQI0XHfiSZ9D([In] object obj0, [In] int obj1) => (object) ((DbDataReader) obj0).GetData(obj1);

    internal static object dRtaOhWRzNZTFw2vYm8e([In] object obj0, [In] int obj1) => (object) ((DbDataReader) obj0).GetDataTypeName(obj1);

    internal static DateTime TqYrqKWqFfCuyQNlL4n4([In] object obj0, [In] int obj1) => ((DbDataReader) obj0).GetDateTime(obj1);

    internal static double QwrN8QWqBBQU37mroRGD([In] object obj0, [In] int obj1) => ((DbDataReader) obj0).GetDouble(obj1);

    internal static Type yo96ldWqW6UaeLJ9aOdD([In] object obj0, [In] int obj1) => ((DbDataReader) obj0).GetFieldType(obj1);

    internal static float KEbiKZWqorZudNXKtDOI([In] object obj0, [In] int obj1) => ((DbDataReader) obj0).GetFloat(obj1);

    internal static Guid L2OXdsWqbyUPUdsZoSPt([In] object obj0, [In] int obj1) => ((DbDataReader) obj0).GetGuid(obj1);

    internal static int nCRH6BWqhcjUixGWJUXI([In] object obj0, [In] int obj1) => ((DbDataReader) obj0).GetInt32(obj1);

    internal static int uRZulDWqGx6r0sO9p8Uq([In] object obj0, [In] object obj1) => ((DbDataReader) obj0).GetOrdinal((string) obj1);

    internal static object zLjqHmWqEVGgyFyvI14M([In] object obj0, [In] int obj1) => ((DbDataReader) obj0).GetValue(obj1);

    internal static int FZvJkXWqfdvuGjBPvFe0([In] object obj0, [In] object obj1) => ((DbDataReader) obj0).GetValues((object[]) obj1);

    internal static bool WBga1BWqQAdENirrSsvk([In] object obj0, [In] int obj1) => ((DbDataReader) obj0).IsDBNull(obj1);

    internal static object enZwgbWqC8vl3pkqmVkb([In] object obj0, [In] object obj1) => ((DbDataReader) obj0)[(string) obj1];

    private class Interceptor : IDisposable
    {
      private readonly object queryInfo;
      private readonly int affectedRows;
      private object stopwatch;
      internal static object kL19bEQwZoIMqhkkHcCp;

      public Interceptor(DataReaderProxy owner, int affectedRows = 0)
      {
        DataReaderProxy.Interceptor.fgLalyQwVKmOm0dqU3bO();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 5;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_11;
            case 1:
              if (DataReaderProxy.Interceptor.eRX9j5QwSeW6NeO7fcXy(this.queryInfo))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
                continue;
              }
              goto case 7;
            case 2:
              if (this.queryInfo == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 4 : 4;
                continue;
              }
              goto case 1;
            case 3:
              goto label_10;
            case 4:
              goto label_2;
            case 5:
              this.queryInfo = (object) owner.queryInfo;
              num = 6;
              continue;
            case 6:
              this.affectedRows = affectedRows;
              num = 2;
              continue;
            case 7:
              this.stopwatch = (object) Stopwatch.StartNew();
              num = 3;
              continue;
            default:
              goto label_12;
          }
        }
label_11:
        return;
label_10:
        return;
label_2:
        return;
label_12:;
      }

      public void Dispose()
      {
        int num1 = 10;
        while (true)
        {
          int num2 = num1;
          long? rowsAffected;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_8;
              case 2:
                rowsAffected = ((SqlQueryInfo) this.queryInfo).RowsAffected;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 7 : 7;
                continue;
              case 3:
                goto label_16;
              case 4:
              case 8:
                object queryInfo1 = this.queryInfo;
                DataReaderProxy.Interceptor.BYLyjaQwK1mLbVXY7KbG(queryInfo1, DataReaderProxy.Interceptor.mKneKhQwqMIMBYLM6Ugg(DataReaderProxy.Interceptor.crtJBiQwiNBr4ZUZrhdO(queryInfo1), DataReaderProxy.Interceptor.GibgRtQwRr3vuvfrBuTU(this.stopwatch)));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
                continue;
              case 5:
                ((SqlQueryInfo) this.queryInfo).RowsAffected = new long?(1L);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 8 : 8;
                continue;
              case 7:
                if (rowsAffected.HasValue)
                {
                  num2 = 6;
                  continue;
                }
                goto case 5;
              case 9:
                if (((SqlQueryInfo) this.queryInfo).IsEmpty)
                {
                  num2 = 3;
                  continue;
                }
                goto label_9;
              case 10:
                goto label_13;
              default:
                object queryInfo2 = this.queryInfo;
                rowsAffected = ((SqlQueryInfo) queryInfo2).RowsAffected;
                long affectedRows = (long) this.affectedRows;
                ((SqlQueryInfo) queryInfo2).RowsAffected = !rowsAffected.HasValue ? new long?() : new long?(rowsAffected.GetValueOrDefault() + affectedRows);
                num2 = 4;
                continue;
            }
          }
label_9:
          ((Stopwatch) this.stopwatch).Stop();
          num1 = 2;
          continue;
label_13:
          if (this.queryInfo != null)
            num1 = 9;
          else
            goto label_7;
        }
label_8:
        return;
label_16:
        return;
label_7:;
      }

      internal static void fgLalyQwVKmOm0dqU3bO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool eRX9j5QwSeW6NeO7fcXy([In] object obj0) => ((SqlQueryInfo) obj0).IsEmpty;

      internal static bool Hi7ebYQwuDqxswlyADAM() => DataReaderProxy.Interceptor.kL19bEQwZoIMqhkkHcCp == null;

      internal static DataReaderProxy.Interceptor ivpOgiQwITbxUEYew2Ij() => (DataReaderProxy.Interceptor) DataReaderProxy.Interceptor.kL19bEQwZoIMqhkkHcCp;

      internal static TimeSpan crtJBiQwiNBr4ZUZrhdO([In] object obj0) => ((SqlQueryInfo) obj0).ReadTime;

      internal static TimeSpan GibgRtQwRr3vuvfrBuTU([In] object obj0) => ((Stopwatch) obj0).Elapsed;

      internal static TimeSpan mKneKhQwqMIMBYLM6Ugg([In] TimeSpan obj0, [In] TimeSpan obj1) => obj0 + obj1;

      internal static void BYLyjaQwK1mLbVXY7KbG([In] object obj0, TimeSpan value) => ((SqlQueryInfo) obj0).ReadTime = value;
    }
  }
}
