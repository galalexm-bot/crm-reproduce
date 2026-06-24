// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.ExecuteResultCallInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Diagnostics.Attributes;
using EleWise.ELMA.Diagnostics.Events;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Web.Mvc;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>Информация о вызове ActionResult</summary>
  [DiagnosticEvents(StartEvent = typeof (ExecuteResultCallStartEvent), EndEvent = typeof (ExecuteResultCallEndEvent), ErrorEvent = typeof (ExecuteResultCallErrorEvent))]
  [Serializable]
  public class ExecuteResultCallInfo : AbstractCallInfo, IEmptyCallInfo
  {
    internal static ExecuteResultCallInfo wAhALHEFScXsFPhWyVPv;

    /// <summary>Ctor</summary>
    public ExecuteResultCallInfo()
    {
      ExecuteResultCallInfo.Ht9DZJEFqOm8acx840sd();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="resultExecutingContext">Контекст исполнения</param>
    public ExecuteResultCallInfo(ResultExecutingContext resultExecutingContext)
    {
      ExecuteResultCallInfo.Ht9DZJEFqOm8acx840sd();
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
            this.ResultExecutingContext = resultExecutingContext;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
            continue;
          default:
            this.ControllerType = ExecuteResultCallInfo.RdUDCpEFKw2giyaw9y7K((object) resultExecutingContext).GetType();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Контекст исполнения метода</summary>
    public ResultExecutingContext ResultExecutingContext
    {
      get => this.\u003CResultExecutingContext\u003Ek__BackingField;
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
              this.\u003CResultExecutingContext\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
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

    /// <summary>Контекст исполненного метода</summary>
    public ResultExecutedContext ResultExecutedContext
    {
      get => this.\u003CResultExecutedContext\u003Ek__BackingField;
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
              this.\u003CResultExecutedContext\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
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

    /// <summary>Тип контроллера</summary>
    public Type ControllerType
    {
      get => this.\u003CControllerType\u003Ek__BackingField;
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
              this.\u003CControllerType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
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
    public override string CallType => (string) ExecuteResultCallInfo.vnXxqGEFXy8Oehyvfdab(-1334993905 ^ -1335248139);

    /// <inheritdoc />
    public override string Description => (string) ExecuteResultCallInfo.KmkB8iEFkPeC2pUM41oj(ExecuteResultCallInfo.i6Yd4yEFTFbdBS5T4FhV((object) this.ResultExecutingContext).GetType(), ExecuteResultCallInfo.vnXxqGEFXy8Oehyvfdab(-606654180 ^ -606923260));

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
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
          case 0:
            goto label_2;
          case 1:
            ExecuteResultCallInfo.ngWm6fEFnW3nDHw4F3ul((object) info, ExecuteResultCallInfo.vnXxqGEFXy8Oehyvfdab(1021410165 ^ 1021664727), (object) this.ControllerType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static void Ht9DZJEFqOm8acx840sd() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool gIUuYGEFilAaNxvDIR8T() => ExecuteResultCallInfo.wAhALHEFScXsFPhWyVPv == null;

    internal static ExecuteResultCallInfo HuHB6VEFRcJVZuXyAv3l() => ExecuteResultCallInfo.wAhALHEFScXsFPhWyVPv;

    internal static object RdUDCpEFKw2giyaw9y7K([In] object obj0) => (object) ((ControllerContext) obj0).Controller;

    internal static object vnXxqGEFXy8Oehyvfdab(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object i6Yd4yEFTFbdBS5T4FhV([In] object obj0) => (object) ((ResultExecutingContext) obj0).Result;

    internal static object KmkB8iEFkPeC2pUM41oj(Type controllerType, [In] object obj1) => (object) DiagnosticsHelper.GetControllerActionCallName(controllerType, (string) obj1);

    internal static void ngWm6fEFnW3nDHw4F3ul([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);
  }
}
