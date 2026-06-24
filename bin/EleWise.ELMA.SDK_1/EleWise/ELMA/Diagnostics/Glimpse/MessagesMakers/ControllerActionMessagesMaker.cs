// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Glimpse.MessagesMakers.ControllerActionMessagesMaker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Events;
using Glimpse.Core.Extensibility;
using Glimpse.Core.Message;
using Glimpse.Mvc.AlternateType;
using Glimpse.Mvc.Message;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Web.Mvc;

namespace EleWise.ELMA.Diagnostics.Glimpse.MessagesMakers
{
  /// <summary>
  /// Точка расширения для генерации сообщений в Glimpse для ControllerAction
  /// </summary>
  [Component]
  internal class ControllerActionMessagesMaker : AbstractMessagesMaker
  {
    private static ControllerActionMessagesMaker EhWfxhEqsFPGfhSSSBHm;

    /// <inheritdoc />
    public override Type[] SupportedEventTypes => new Type[2]
    {
      TypeOf<ControllerActionCallEndEvent>.Raw,
      TypeOf<ControllerActionCallErrorEvent>.Raw
    };

    /// <inheritdoc />
    public override object[] MakeMessages(DiagnosticsEvent @event)
    {
      int num1 = 5;
      MethodInfo executedMethod;
      TimerResult timerResult1;
      while (true)
      {
        int num2 = num1;
        ReflectedActionDescriptor actionDescriptor;
        IDiagnosticsCallInfoEvent diagnosticsCallInfoEvent;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 7:
              TimerResult timerResult2 = new TimerResult();
              ControllerActionMessagesMaker.ehonn2EKfoI2C1L4eY2m((object) timerResult2, ControllerActionMessagesMaker.RFsr2GEKEv56QD9iGYf8((object) controllerActionCallInfo));
              ControllerActionMessagesMaker.WZ6iZiEK8f1dnXPps5uj((object) timerResult2, ControllerActionMessagesMaker.xIFthUEKvqyE9GR79iCt(controllerActionCallInfo.StartTime, ControllerActionMessagesMaker.QBs6crEKCAcg0vlIYOIU(ControllerActionMessagesMaker.nbw4a2EKQBPlWaGUC1N2((object) controllerActionCallInfo))));
              ControllerActionMessagesMaker.I1a0tdEKZHOarwIWZWNB((object) timerResult2, controllerActionCallInfo.TotalTime);
              timerResult1 = timerResult2;
              num2 = 8;
              continue;
            case 2:
              if (actionDescriptor == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 10 : 0;
                continue;
              }
              goto case 3;
            case 3:
              executedMethod = (MethodInfo) ControllerActionMessagesMaker.B8vU2OEKo9du7UPFLeX0((object) actionDescriptor);
              num2 = 7;
              continue;
            case 4:
              if (diagnosticsCallInfoEvent != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 5 : 6;
                continue;
              }
              goto label_10;
            case 5:
              goto label_6;
            case 6:
              if (!(ControllerActionMessagesMaker.PjSGtcEKF9OAfA5PjVPk((object) diagnosticsCallInfoEvent) is ControllerActionCallInfo controllerActionCallInfo))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
                continue;
              }
              actionDescriptor = ControllerActionMessagesMaker.aZnZWSEKWY12lEKpl6AT(ControllerActionMessagesMaker.OqwbPSEKB9QBYHktmGfV((object) controllerActionCallInfo)) as ReflectedActionDescriptor;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 2;
              continue;
            case 8:
              goto label_15;
            case 9:
            case 10:
              ControllerDescriptor controllerDescriptor = ((ActionDescriptor) ControllerActionMessagesMaker.aZnZWSEKWY12lEKpl6AT((object) controllerActionCallInfo.ActionExecutedContext)).ControllerDescriptor;
              string name = (string) ControllerActionMessagesMaker.Mm7kX6EKbniiSYUOMLDw((object) ((ActionExecutedContext) ControllerActionMessagesMaker.OqwbPSEKB9QBYHktmGfV((object) controllerActionCallInfo)).ActionDescriptor);
              Type[] array = ((IEnumerable<ParameterDescriptor>) ControllerActionMessagesMaker.J12WyfEKho1xbctEessm(ControllerActionMessagesMaker.aZnZWSEKWY12lEKpl6AT(ControllerActionMessagesMaker.OqwbPSEKB9QBYHktmGfV((object) controllerActionCallInfo)))).Select<ParameterDescriptor, Type>((Func<ParameterDescriptor, Type>) (p => p.ParameterType)).ToArray<Type>();
              executedMethod = ControllerActionMessagesMaker.HRPZHlEKGNoWETwivq7i((object) controllerDescriptor).GetMethod(name, array);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 1;
              continue;
            default:
              goto label_10;
          }
        }
label_6:
        diagnosticsCallInfoEvent = @event as IDiagnosticsCallInfoEvent;
        num1 = 4;
      }
label_10:
      return new object[0];
label_15:
      return new object[1]
      {
        (object) new ActionInvoker.InvokeActionMethod.Message(controllerActionCallInfo.ActionExecutedContext.Result.GetType())
        {
          EventSubText = (ControllerActionMessagesMaker.AeXGFSEKuu33UW7sKINl((object) controllerActionCallInfo) != null ? controllerActionCallInfo.Exception.Message : "")
        }.AsSourceMessage<ActionInvoker.InvokeActionMethod.Message>(ControllerActionMessagesMaker.HRPZHlEKGNoWETwivq7i(ControllerActionMessagesMaker.hNIcwREKIujVfpQUWxfh((object) ((ActionExecutedContext) ControllerActionMessagesMaker.OqwbPSEKB9QBYHktmGfV((object) controllerActionCallInfo)).ActionDescriptor)), executedMethod).AsActionMessage<ActionInvoker.InvokeActionMethod.Message>((ActionDescriptor) ControllerActionMessagesMaker.aZnZWSEKWY12lEKpl6AT((object) controllerActionCallInfo.ActionExecutedContext)).AsChildActionMessage<ActionInvoker.InvokeActionMethod.Message>((ControllerContext) controllerActionCallInfo.ActionExecutedContext).AsMvcTimelineMessage<ActionInvoker.InvokeActionMethod.Message>((TimelineCategoryItem) ControllerActionMessagesMaker.p57lXCEKVT5J9YVpiHhF()).AsTimedMessage<ActionInvoker.InvokeActionMethod.Message>(timerResult1)
      };
    }

    public ControllerActionMessagesMaker()
    {
      ControllerActionMessagesMaker.WEB1C8EKSoFCE3cArJy2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool rRVvMREqcwpw5HdKNTZj() => ControllerActionMessagesMaker.EhWfxhEqsFPGfhSSSBHm == null;

    internal static ControllerActionMessagesMaker in39T7EqzFcT7VWUoLcX() => ControllerActionMessagesMaker.EhWfxhEqsFPGfhSSSBHm;

    internal static object PjSGtcEKF9OAfA5PjVPk([In] object obj0) => (object) ((IDiagnosticsCallInfoEvent) obj0).Info;

    internal static object OqwbPSEKB9QBYHktmGfV([In] object obj0) => (object) ((ControllerActionCallInfo) obj0).ActionExecutedContext;

    internal static object aZnZWSEKWY12lEKpl6AT([In] object obj0) => (object) ((ActionExecutedContext) obj0).ActionDescriptor;

    internal static object B8vU2OEKo9du7UPFLeX0([In] object obj0) => (object) ((ReflectedActionDescriptor) obj0).MethodInfo;

    internal static object Mm7kX6EKbniiSYUOMLDw([In] object obj0) => (object) ((ActionDescriptor) obj0).ActionName;

    internal static object J12WyfEKho1xbctEessm([In] object obj0) => (object) ((ActionDescriptor) obj0).GetParameters();

    internal static Type HRPZHlEKGNoWETwivq7i([In] object obj0) => ((ControllerDescriptor) obj0).ControllerType;

    internal static DateTime RFsr2GEKEv56QD9iGYf8([In] object obj0) => ((AbstractCallInfo) obj0).StartTime;

    internal static void ehonn2EKfoI2C1L4eY2m([In] object obj0, [In] DateTime obj1) => ((TimerResult) obj0).StartTime = obj1;

    internal static object nbw4a2EKQBPlWaGUC1N2([In] object obj0) => (object) ((AbstractCallInfo) obj0).ContextInfo;

    internal static DateTime QBs6crEKCAcg0vlIYOIU([In] object obj0) => ((CallContextInfo) obj0).StartTime;

    internal static TimeSpan xIFthUEKvqyE9GR79iCt([In] DateTime obj0, [In] DateTime obj1) => obj0 - obj1;

    internal static void WZ6iZiEK8f1dnXPps5uj([In] object obj0, [In] TimeSpan obj1) => ((TimerResult) obj0).Offset = obj1;

    internal static void I1a0tdEKZHOarwIWZWNB([In] object obj0, [In] TimeSpan obj1) => ((TimerResult) obj0).Duration = obj1;

    internal static object AeXGFSEKuu33UW7sKINl([In] object obj0) => (object) ((AbstractCallInfo) obj0).Exception;

    internal static object hNIcwREKIujVfpQUWxfh([In] object obj0) => (object) ((ActionDescriptor) obj0).ControllerDescriptor;

    internal static object p57lXCEKVT5J9YVpiHhF() => (object) MvcTimelineCategory.Controller;

    internal static void WEB1C8EKSoFCE3cArJy2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
