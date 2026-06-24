// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.IndexQueryInfo
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
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>Информация о запросе в индекс</summary>
  [DiagnosticEvents(StartEvent = typeof (IndexQueryExecuteStartEvent), EndEvent = typeof (IndexQueryExecuteEndEvent), ErrorEvent = typeof (IndexQueryExecuteErrorEvent))]
  [Serializable]
  public class IndexQueryInfo : AbstractCallInfo, IEmptyCallInfo
  {
    internal static IndexQueryInfo HaJ5x4EFgF24pqoivJyi;

    /// <summary>Ctor</summary>
    /// <param name="query">Запрос в индекс</param>
    public IndexQueryInfo(string query)
    {
      IndexQueryInfo.OXqdj1EFY6jtXRhFUpnw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 4;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
        num = 5;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
            goto label_11;
          case 2:
            this.ConnectionId = IndexQueryInfo.pFDOguEFUbj6Z3QeoGcg();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
            continue;
          case 3:
            this.CommandId = IndexQueryInfo.pFDOguEFUbj6Z3QeoGcg();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 2 : 1;
            continue;
          case 4:
            this.CommandId = IndexQueryInfo.vO47J1EFs7LIhim7Wt7Z((object) query.GetHashCode().ToString());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 6 : 6;
            continue;
          case 5:
            if (!IndexQueryInfo.pu2fVsEFLw6a2ak860UO((object) query))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 4 : 2;
              continue;
            }
            goto case 3;
          case 6:
            this.ConnectionId = IndexQueryInfo.vO47J1EFs7LIhim7Wt7Z((object) query.GetHashCode().ToString());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 7 : 5;
            continue;
          case 7:
            this.Query = query;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_4:
      return;
label_11:
      return;
label_3:;
    }

    /// <summary>Ctor</summary>
    public IndexQueryInfo()
    {
      IndexQueryInfo.OXqdj1EFY6jtXRhFUpnw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.ConnectionId = IndexQueryInfo.pFDOguEFUbj6Z3QeoGcg();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 1;
            continue;
          default:
            this.CommandId = Guid.NewGuid();
            num = 2;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
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

    /// <summary>Запрос в индекс</summary>
    public string Query
    {
      get => this.\u003CQuery\u003Ek__BackingField;
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
              this.\u003CQuery\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
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
    public override string CallType => (string) IndexQueryInfo.VMy3FxEFcstkjNiTDm4M(--1418440330 ^ 1418692308);

    /// <inheritdoc />
    public override string Description => this.Query;

    /// <inheritdoc />
    public override void StartCall(CallContextInfo callContext)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (this.IsPerfomed)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
                continue;
              }
              goto label_13;
            case 2:
              base.StartCall(callContext);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_9;
            case 4:
              goto label_14;
            case 5:
              if (!IndexQueryInfo.ErNA1fEBFRjTvXJWw51W(IndexQueryInfo.raSle8EFziVfAT2CSKUf()))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 4 : 0;
                continue;
              }
              goto case 6;
            case 6:
              IndexQueryInfo.rF8byPEBBjh6voUdbxAv((object) DiagnosticsManager.Instance.GetCounter<IndexQueriesCounter>());
              num2 = 3;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        if (DiagnosticsManager.Enabled)
          num1 = 5;
        else
          goto label_3;
      }
label_9:
      return;
label_14:
      return;
label_3:
      return;
label_13:;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
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
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            IndexQueryInfo.rkOCq8EBWxZ7UDlb0dQs((object) info, IndexQueryInfo.VMy3FxEFcstkjNiTDm4M(1505778440 - 1981636111 ^ -475605781), (object) this.ConnectionId);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
            continue;
          case 2:
            IndexQueryInfo.rkOCq8EBWxZ7UDlb0dQs((object) info, IndexQueryInfo.VMy3FxEFcstkjNiTDm4M(-680446928 - -370807692 ^ -309370816), (object) this.CommandId);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void OXqdj1EFY6jtXRhFUpnw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool pu2fVsEFLw6a2ak860UO([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static Guid pFDOguEFUbj6Z3QeoGcg() => Guid.NewGuid();

    internal static Guid vO47J1EFs7LIhim7Wt7Z([In] object obj0) => ((string) obj0).GetDeterministicGuid();

    internal static bool u7liWjEF5QiiWUexiMqt() => IndexQueryInfo.HaJ5x4EFgF24pqoivJyi == null;

    internal static IndexQueryInfo j5juHrEFjQvUGXv9YA78() => IndexQueryInfo.HaJ5x4EFgF24pqoivJyi;

    internal static object VMy3FxEFcstkjNiTDm4M(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object raSle8EFziVfAT2CSKUf() => (object) DiagnosticsManager.Instance;

    internal static bool ErNA1fEBFRjTvXJWw51W([In] object obj0) => ((DiagnosticsManager) obj0).CountersEnabled;

    internal static void rF8byPEBBjh6voUdbxAv([In] object obj0) => ((Delta64Counter) obj0).Increment();

    internal static void rkOCq8EBWxZ7UDlb0dQs([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);
  }
}
