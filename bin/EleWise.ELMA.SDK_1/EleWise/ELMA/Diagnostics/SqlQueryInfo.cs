// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.SqlQueryInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Diagnostics.Attributes;
using EleWise.ELMA.Diagnostics.Counters;
using EleWise.ELMA.Diagnostics.Events;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>Информация о SQL запросе</summary>
  [DiagnosticEvents(StartEvent = typeof (SqlCommandExecuteStartEvent), EndEvent = typeof (SqlCommandExecuteEndEvent), ErrorEvent = typeof (SqlCommandExecuteErrorEvent))]
  [Serializable]
  public class SqlQueryInfo : AbstractCallInfo, IEmptyCallInfo
  {
    internal static SqlQueryInfo cwNl4qEWr0tQJvTqiJfY;

    /// <summary>Ctor</summary>
    /// <param name="command">Команда БД</param>
    public SqlQueryInfo(IDbCommand command)
    {
      SqlQueryInfo.QbYdSaEWjaHuiwQIsTDe();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.SetDbCommand(command);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor</summary>
    public SqlQueryInfo()
    {
      SqlQueryInfo.QbYdSaEWjaHuiwQIsTDe();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.CommandId = Guid.NewGuid();
            num = 3;
            continue;
          case 3:
            this.ConnectionId = SqlQueryInfo.Nk4F6dEWYZVDPdN1vIAS();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
            continue;
          default:
            this.Paramaters = (IList<SqlQueryInfo.CommandParamater>) new List<SqlQueryInfo.CommandParamater>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Уникальный идентификатор команды</summary>
    public Guid CommandId
    {
      get => this.\u003CCommandId\u003Ek__BackingField;
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
              this.\u003CCommandId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
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

    /// <summary>Уникальный идентификатор соединения</summary>
    public Guid ConnectionId
    {
      get => this.\u003CConnectionId\u003Ek__BackingField;
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
              this.\u003CConnectionId\u003Ek__BackingField = value;
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
    }

    /// <summary>SQL-запрос</summary>
    public string Sql
    {
      get => this.\u003CSql\u003Ek__BackingField;
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
              this.\u003CSql\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
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

    /// <summary>Параметры запроса</summary>
    public IList<SqlQueryInfo.CommandParamater> Paramaters { get; set; }

    /// <summary>Количество строк, задействованных в запросе</summary>
    public long? RowsAffected { get; set; }

    /// <inheritdoc />
    public override string CallType => (string) SqlQueryInfo.MgOJtCEWUEhsNIENkSqG((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813348079), this.IsPrepare ? SqlQueryInfo.H9QCMoEWLvDLdtqcyavm(~-397266137 ^ 397010832) : (object) "");

    /// <inheritdoc />
    public override string Description => this.Sql;

    /// <summary>Время чтения из команды</summary>
    public TimeSpan ReadTime
    {
      get => this.\u003CReadTime\u003Ek__BackingField;
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
              this.\u003CReadTime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
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

    /// <summary>Подготовка SQL-команда в батчере</summary>
    public bool IsPrepare
    {
      get => this.\u003CIsPrepare\u003Ek__BackingField;
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
              this.\u003CIsPrepare\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
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

    /// <inheritdoc />
    public bool IsEmpty
    {
      get => this.\u003CIsEmpty\u003Ek__BackingField;
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
              this.\u003CIsEmpty\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
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

    /// <summary>Заполнить поля из DbCommand</summary>
    /// <param name="command">Команда</param>
    public void SetDbCommand(IDbCommand command)
    {
      int num = 8;
      int hashCode;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.CommandId = SqlQueryInfo.Nk4F6dEWYZVDPdN1vIAS();
            num = 6;
            continue;
          case 2:
            goto label_4;
          case 3:
            this.ConnectionId = SqlQueryInfo.Nk4F6dEWYZVDPdN1vIAS();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 4 : 10;
            continue;
          case 4:
          case 10:
            this.Sql = command.CommandText;
            num = 9;
            continue;
          case 5:
            this.Paramaters = (IList<SqlQueryInfo.CommandParamater>) new List<SqlQueryInfo.CommandParamater>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 8 : 11;
            continue;
          case 6:
            this.ConnectionId = SqlQueryInfo.Nk4F6dEWYZVDPdN1vIAS();
            num = 5;
            continue;
          case 7:
            hashCode = command.GetHashCode();
            this.CommandId = SqlQueryInfo.VD3XpvEWsS6Nf2KElV4l((object) hashCode.ToString());
            num = 12;
            continue;
          case 8:
            if (command != null)
            {
              num = 7;
              continue;
            }
            goto case 1;
          case 9:
            this.Paramaters = ((IDataParameterCollection) SqlQueryInfo.aylKfkEWzlZlyDnr470g((object) command)).AsQueryInfoCommandParamaters();
            num = 2;
            continue;
          case 11:
            goto label_3;
          case 12:
            if (SqlQueryInfo.QmFOJlEWcIk4RXrVvrlr((object) command) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          default:
            hashCode = command.Connection.GetHashCode();
            this.ConnectionId = SqlQueryInfo.VD3XpvEWsS6Nf2KElV4l((object) hashCode.ToString());
            num = 4;
            continue;
        }
      }
label_4:
      return;
label_3:;
    }

    /// <inheritdoc />
    public override void StartCall(CallContextInfo callContext)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            if (!this.IsPerfomed)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 0;
              continue;
            }
            goto case 8;
          case 3:
            base.StartCall(callContext);
            num = 2;
            continue;
          case 4:
            goto label_15;
          case 5:
            SqlQueryInfo.wYbksbEoW9MT3rqLT88F((object) DiagnosticsManager.Instance.GetCounter<DatabaseQueriesCounter>());
            num = 6;
            continue;
          case 6:
            goto label_16;
          case 7:
            if (DiagnosticsManager.Enabled)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 8:
            if (!this.IsPrepare)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 7 : 4;
              continue;
            }
            goto label_2;
          default:
            if (!SqlQueryInfo.TOR2tZEoBtM6JLMlwIo1(SqlQueryInfo.WajqjrEoFJyiK7GXYa6u()))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 4 : 4;
              continue;
            }
            goto case 5;
        }
      }
label_9:
      return;
label_15:
      return;
label_16:
      return;
label_6:
      return;
label_2:;
    }

    protected override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      int num = 7;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (SqlQueryInfo.Ct3gOFEobCGaK3Mk73ks((object) this.Paramaters) <= 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 2 : 0;
              continue;
            }
            goto case 5;
          case 2:
          case 3:
          case 9:
            SqlQueryInfo.HKBAqyEoopAF946ll8uw((object) info, SqlQueryInfo.H9QCMoEWLvDLdtqcyavm(-606654180 ^ -606922136), (object) this.RowsAffected);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
            continue;
          case 4:
            info.AddValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837935137), this.IsPrepare);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 9 : 10;
            continue;
          case 5:
            info.AddValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398931456), (object) this.Paramaters);
            num = 3;
            continue;
          case 6:
            SqlQueryInfo.HKBAqyEoopAF946ll8uw((object) info, SqlQueryInfo.H9QCMoEWLvDLdtqcyavm(516838154 ^ 516586264), (object) this.ConnectionId);
            num = 8;
            continue;
          case 7:
            SqlQueryInfo.HKBAqyEoopAF946ll8uw((object) info, SqlQueryInfo.H9QCMoEWLvDLdtqcyavm(-787452571 ^ -787199335), (object) this.CommandId);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 5 : 6;
            continue;
          case 8:
            if (this.Paramaters == null)
            {
              num = 9;
              continue;
            }
            goto case 1;
          case 10:
            goto label_10;
          default:
            SqlQueryInfo.HKBAqyEoopAF946ll8uw((object) info, SqlQueryInfo.H9QCMoEWLvDLdtqcyavm(-740338220 ^ -740590012), (object) this.ReadTime);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 4;
            continue;
        }
      }
label_10:;
    }

    internal static void QbYdSaEWjaHuiwQIsTDe() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool dMoVmOEWgAm2RZbUKlRi() => SqlQueryInfo.cwNl4qEWr0tQJvTqiJfY == null;

    internal static SqlQueryInfo AtbvZYEW5wfIcGir7N5I() => SqlQueryInfo.cwNl4qEWr0tQJvTqiJfY;

    internal static Guid Nk4F6dEWYZVDPdN1vIAS() => Guid.NewGuid();

    internal static object H9QCMoEWLvDLdtqcyavm(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object MgOJtCEWUEhsNIENkSqG([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static Guid VD3XpvEWsS6Nf2KElV4l([In] object obj0) => ((string) obj0).GetDeterministicGuid();

    internal static object QmFOJlEWcIk4RXrVvrlr([In] object obj0) => (object) ((IDbCommand) obj0).Connection;

    internal static object aylKfkEWzlZlyDnr470g([In] object obj0) => (object) ((IDbCommand) obj0).Parameters;

    internal static object WajqjrEoFJyiK7GXYa6u() => (object) DiagnosticsManager.Instance;

    internal static bool TOR2tZEoBtM6JLMlwIo1([In] object obj0) => ((DiagnosticsManager) obj0).CountersEnabled;

    internal static void wYbksbEoW9MT3rqLT88F([In] object obj0) => ((Delta64Counter) obj0).Increment();

    internal static void HKBAqyEoopAF946ll8uw([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);

    internal static int Ct3gOFEobCGaK3Mk73ks([In] object obj0) => ((ICollection<SqlQueryInfo.CommandParamater>) obj0).Count;

    /// <summary>Параметр запроса</summary>
    [Serializable]
    public class CommandParamater : ISerializable
    {
      private static SqlQueryInfo.CommandParamater fmgDpf8SEZpID4mNLVhQ;

      /// <summary>Название</summary>
      public string Name
      {
        get => this.\u003CName\u003Ek__BackingField;
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
                this.\u003CName\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
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

      /// <summary>Значение</summary>
      public object Value
      {
        get => this.\u003CValue\u003Ek__BackingField;
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
                this.\u003CValue\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
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

      /// <summary>Тип</summary>
      public string Type
      {
        get => this.\u003CType\u003Ek__BackingField;
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
                this.\u003CType\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
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

      /// <summary>Размер</summary>
      public int Size
      {
        get => this.\u003CSize\u003Ek__BackingField;
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
                this.\u003CSize\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
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

      void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
            case 5:
              if (this.Value == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
                continue;
              }
              goto case 6;
            case 2:
              if (SqlQueryInfo.CommandParamater.e2KQTn8SC7SCfGmIo1p4((object) this.Name))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
                continue;
              }
              goto case 9;
            case 4:
              SqlQueryInfo.CommandParamater.K1KwMK8SZXJ861HwPBcB((object) info, SqlQueryInfo.CommandParamater.xSp5v18SvodFqkRxqurN(-342626196 - 1290888215 ^ -1633649847), this.Size);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 8 : 2;
              continue;
            case 6:
              SqlQueryInfo.CommandParamater.a5AN5B8S8mNfSmQAhDPj((object) info, SqlQueryInfo.CommandParamater.xSp5v18SvodFqkRxqurN(1178210108 ^ 1178249576), (object) this.Value.ToString());
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 3 : 1;
              continue;
            case 7:
              SqlQueryInfo.CommandParamater.a5AN5B8S8mNfSmQAhDPj((object) info, SqlQueryInfo.CommandParamater.xSp5v18SvodFqkRxqurN(1597012150 ^ 1596997712), (object) this.Type);
              num = 4;
              continue;
            case 8:
              goto label_9;
            case 9:
              SqlQueryInfo.CommandParamater.a5AN5B8S8mNfSmQAhDPj((object) info, SqlQueryInfo.CommandParamater.xSp5v18SvodFqkRxqurN(1470440286 ^ 1470451870), (object) this.Name);
              num = 5;
              continue;
            default:
              if (!SqlQueryInfo.CommandParamater.e2KQTn8SC7SCfGmIo1p4((object) this.Type))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 7 : 6;
                continue;
              }
              goto case 4;
          }
        }
label_9:;
      }

      public CommandParamater()
      {
        SqlQueryInfo.CommandParamater.Vw5JNm8Suy6IrKYfL60Q();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool VjRerM8SfwnhIBOmocOW() => SqlQueryInfo.CommandParamater.fmgDpf8SEZpID4mNLVhQ == null;

      internal static SqlQueryInfo.CommandParamater Lvrg5g8SQ8eQTReO37hJ() => SqlQueryInfo.CommandParamater.fmgDpf8SEZpID4mNLVhQ;

      internal static bool e2KQTn8SC7SCfGmIo1p4([In] object obj0) => ((string) obj0).IsNullOrEmpty();

      internal static object xSp5v18SvodFqkRxqurN(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static void a5AN5B8S8mNfSmQAhDPj([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);

      internal static void K1KwMK8SZXJ861HwPBcB([In] object obj0, [In] object obj1, [In] int obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);

      internal static void Vw5JNm8Suy6IrKYfL60Q() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
