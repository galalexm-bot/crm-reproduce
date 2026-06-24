// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.IndexCallInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Diagnostics.Attributes;
using EleWise.ELMA.Diagnostics.Counters;
using EleWise.ELMA.Diagnostics.Events;
using EleWise.ELMA.Diagnostics.Statistics;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>Информация о обращении к индексу</summary>
  [DiagnosticEvents(StartEvent = typeof (IndexCallExecuteStartEvent), EndEvent = typeof (IndexCallExecuteEndEvent), ErrorEvent = typeof (IndexCallExecuteErrorEvent))]
  [Serializable]
  public class IndexCallInfo : AbstractCallInfo, IEmptyCallInfo
  {
    private static IndexCallInfo W0sImDEFai0jDUa5Mh2l;

    /// <summary>Ctor</summary>
    /// <param name="call">Тип обращения</param>
    public IndexCallInfo(IndexCallsType call)
    {
      IndexCallInfo.F1uLm0EFwS9YTfFSt0fS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.CommandId = call.GetHashCode().ToString().GetDeterministicGuid();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
            continue;
          case 3:
            this.Call = call;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 1;
            continue;
          default:
            this.ConnectionId = call.GetHashCode().ToString().GetDeterministicGuid();
            num = 3;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor</summary>
    public IndexCallInfo()
    {
      IndexCallInfo.F1uLm0EFwS9YTfFSt0fS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ConnectionId = IndexCallInfo.hwpHa3EF4Nqua3QUkqn2();
            num = 2;
            continue;
          case 2:
            goto label_3;
          default:
            this.CommandId = Guid.NewGuid();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 1;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
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

    /// <summary>Тип обращения к кешу</summary>
    public IndexCallsType Call
    {
      get => this.\u003CCall\u003Ek__BackingField;
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
              this.\u003CCall\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
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

    /// <summary>Вызов отменен</summary>
    public bool IsCancel
    {
      get => this.\u003CIsCancel\u003Ek__BackingField;
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
              this.\u003CIsCancel\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
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
    public override string CallType => (string) IndexCallInfo.Vfcd64EF6pSf95ah75uA(-882126494 ^ -881854844);

    /// <inheritdoc />
    public override string Description
    {
      get
      {
        int num = 1;
        IndexCallsType call;
        while (true)
        {
          switch (num)
          {
            case 1:
              call = this.Call;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return call.ToString();
      }
    }

    /// <inheritdoc />
    public override void StartCall(CallContextInfo callContext)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            if (!IndexCallInfo.oI41iwEF7brLmTWs2SAn(IndexCallInfo.XTlwOdEFAI1uMw5IwxxG()))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 1;
              continue;
            }
            break;
          case 3:
            if (this.IsPerfomed)
            {
              num = 5;
              continue;
            }
            goto label_4;
          case 4:
            base.StartCall(callContext);
            num = 3;
            continue;
          case 5:
            if (!IndexCallInfo.megarnEFHrGB4bIkhGty())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 5 : 7;
              continue;
            }
            goto case 2;
          case 6:
            goto label_2;
          case 7:
            goto label_13;
        }
        ((DiagnosticsManager) IndexCallInfo.XTlwOdEFAI1uMw5IwxxG()).GetCounter<IndexCallCounter>().Increment();
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 3 : 6;
      }
label_7:
      return;
label_2:
      return;
label_13:
      return;
label_4:;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
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

    protected override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            info.AddValue((string) IndexCallInfo.Vfcd64EF6pSf95ah75uA(-951514650 ^ -951243238), (object) this.CommandId);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          case 2:
            info.AddValue((string) IndexCallInfo.Vfcd64EF6pSf95ah75uA(-1824388195 ^ -1824119897), this.IsCancel);
            num = 3;
            continue;
          case 3:
            goto label_2;
          case 4:
            info.AddValue((string) IndexCallInfo.Vfcd64EF6pSf95ah75uA(-882126494 ^ -881854132), (object) this.Call);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 2 : 1;
            continue;
          default:
            IndexCallInfo.P1rYydEFx0SEHZpmGCuq((object) info, IndexCallInfo.Vfcd64EF6pSf95ah75uA(-649342099 - -1150814748 ^ 501740955), (object) this.ConnectionId);
            num = 4;
            continue;
        }
      }
label_2:;
    }

    internal static void F1uLm0EFwS9YTfFSt0fS() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool QCfU9yEFDxRfDjfXUdm2() => IndexCallInfo.W0sImDEFai0jDUa5Mh2l == null;

    internal static IndexCallInfo MtCfDrEFtWM07XiXnZyM() => IndexCallInfo.W0sImDEFai0jDUa5Mh2l;

    internal static Guid hwpHa3EF4Nqua3QUkqn2() => Guid.NewGuid();

    internal static object Vfcd64EF6pSf95ah75uA(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool megarnEFHrGB4bIkhGty() => DiagnosticsManager.Enabled;

    internal static object XTlwOdEFAI1uMw5IwxxG() => (object) DiagnosticsManager.Instance;

    internal static bool oI41iwEF7brLmTWs2SAn([In] object obj0) => ((DiagnosticsManager) obj0).CountersEnabled;

    internal static void P1rYydEFx0SEHZpmGCuq([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);
  }
}
