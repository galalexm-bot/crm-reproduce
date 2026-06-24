// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.ControllerActionCallInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Diagnostics.Attributes;
using EleWise.ELMA.Diagnostics.Events;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Web.Mvc;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>Информация о вызове метода контроллера</summary>
  [DiagnosticEvents(StartEvent = typeof (ControllerActionCallStartEvent), EndEvent = typeof (ControllerActionCallEndEvent), ErrorEvent = typeof (ControllerActionCallErrorEvent))]
  [Serializable]
  public class ControllerActionCallInfo : AbstractCallInfo, IEmptyCallInfo
  {
    internal static ControllerActionCallInfo LABG2cEFb63YqCIOPBgX;

    /// <summary>Ctor</summary>
    public ControllerActionCallInfo()
    {
      ControllerActionCallInfo.yekxtPEFEQlItGFLAJBg();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="actionExecutingContext">Контекст исполняемого метода</param>
    public ControllerActionCallInfo(ActionExecutingContext actionExecutingContext)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ControllerType = ControllerActionCallInfo.VEUEqFEFfDhgLiYhqqfj((object) actionExecutingContext).GetType();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
            continue;
          case 2:
            this.ActionExecutingContext = actionExecutingContext;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 1;
            continue;
          case 3:
            this.ActionName = (string) ControllerActionCallInfo.crLsgoEF8qItTnZ6qD4n((object) actionExecutingContext.ActionDescriptor);
            num = 4;
            continue;
          case 4:
            goto label_2;
          default:
            this.ControllerName = (string) ControllerActionCallInfo.TRocy2EFvWbIRaO7yLfs(ControllerActionCallInfo.Xb49lXEFC7DTxGehEWEV(ControllerActionCallInfo.g2Z3MuEFQ2whPvQYpc9y((object) actionExecutingContext)));
            num = 3;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Контекст исполненного метода</summary>
    public ActionExecutedContext ActionExecutedContext
    {
      get => this.\u003CActionExecutedContext\u003Ek__BackingField;
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
              this.\u003CActionExecutedContext\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
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

    /// <summary>Контекст исполняемого метода</summary>
    public ActionExecutingContext ActionExecutingContext
    {
      get => this.\u003CActionExecutingContext\u003Ek__BackingField;
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
              this.\u003CActionExecutingContext\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
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

    /// <summary>Название контроллера</summary>
    public string ControllerName
    {
      get => this.\u003CControllerName\u003Ek__BackingField;
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
              this.\u003CControllerName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
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

    /// <summary>Название действия</summary>
    public string ActionName
    {
      get => this.\u003CActionName\u003Ek__BackingField;
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
              this.\u003CActionName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
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
    public override string CallType => z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239833880);

    /// <inheritdoc />
    public override string Description => (string) ControllerActionCallInfo.I1nsr7EFZi664vWmWFM7(this.ControllerType, (object) this.ActionName);

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
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
    protected override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_10;
            case 2:
              if (this.ActionName.IsNullOrEmpty())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 1;
                continue;
              }
              break;
            case 3:
              goto label_6;
            case 4:
              if (!ControllerActionCallInfo.XZ5aEiEFuCGBowYsKvLd((object) this.ControllerName))
              {
                num2 = 3;
                continue;
              }
              goto case 2;
            case 5:
              info.AddValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583997866), (object) this.ControllerType);
              num2 = 4;
              continue;
            case 6:
              goto label_3;
          }
          info.AddValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978604055), (object) this.ActionName);
          num2 = 6;
        }
label_6:
        ControllerActionCallInfo.fFCLiyEFVXtADjHXgJ3p((object) info, ControllerActionCallInfo.R5u1IPEFIBncxLbCpuIb(92412609 - 1050237057 ^ -957553534), (object) this.ControllerName);
        num1 = 2;
      }
label_10:
      return;
label_3:;
    }

    internal static void yekxtPEFEQlItGFLAJBg() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool L9A4nXEFhtyMLN0u2H9d() => ControllerActionCallInfo.LABG2cEFb63YqCIOPBgX == null;

    internal static ControllerActionCallInfo KTMFW7EFGJBIMyEIA4p3() => ControllerActionCallInfo.LABG2cEFb63YqCIOPBgX;

    internal static object VEUEqFEFfDhgLiYhqqfj([In] object obj0) => (object) ((ControllerContext) obj0).Controller;

    internal static object g2Z3MuEFQ2whPvQYpc9y([In] object obj0) => (object) ((ActionExecutingContext) obj0).ActionDescriptor;

    internal static object Xb49lXEFC7DTxGehEWEV([In] object obj0) => (object) ((ActionDescriptor) obj0).ControllerDescriptor;

    internal static object TRocy2EFvWbIRaO7yLfs([In] object obj0) => (object) ((ControllerDescriptor) obj0).ControllerName;

    internal static object crLsgoEF8qItTnZ6qD4n([In] object obj0) => (object) ((ActionDescriptor) obj0).ActionName;

    internal static object I1nsr7EFZi664vWmWFM7(Type controllerType, [In] object obj1) => (object) DiagnosticsHelper.GetControllerActionCallName(controllerType, (string) obj1);

    internal static bool XZ5aEiEFuCGBowYsKvLd([In] object obj0) => ((string) obj0).IsNullOrEmpty();

    internal static object R5u1IPEFIBncxLbCpuIb(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void fFCLiyEFVXtADjHXgJ3p([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);
  }
}
