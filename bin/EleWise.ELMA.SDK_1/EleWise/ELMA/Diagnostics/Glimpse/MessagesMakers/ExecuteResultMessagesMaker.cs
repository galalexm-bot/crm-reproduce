// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Glimpse.MessagesMakers.ExecuteResultMessagesMaker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Events;
using Glimpse.Core.Extensibility;
using Glimpse.Core.Message;
using Glimpse.Mvc.Message;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Web.Mvc;

namespace EleWise.ELMA.Diagnostics.Glimpse.MessagesMakers
{
  /// <summary>
  /// Точка расширения для генерации сообщений в Glimpse для ExecuteResult
  /// </summary>
  [Component]
  internal class ExecuteResultMessagesMaker : AbstractMessagesMaker
  {
    private static readonly MethodInfo MethodInfo;
    internal static ExecuteResultMessagesMaker iWpfNMEqxiJYwrCnkWr0;

    /// <inheritdoc />
    public override Type[] SupportedEventTypes => new Type[2]
    {
      TypeOf<ExecuteResultCallEndEvent>.Raw,
      TypeOf<ExecuteResultCallErrorEvent>.Raw
    };

    /// <inheritdoc />
    public override object[] MakeMessages(DiagnosticsEvent @event)
    {
      int num1 = 1;
      TimerResult timerResult1;
      while (true)
      {
        int num2 = num1;
        IDiagnosticsCallInfoEvent diagnosticsCallInfoEvent;
        while (true)
        {
          switch (num2)
          {
            case 1:
              diagnosticsCallInfoEvent = @event as IDiagnosticsCallInfoEvent;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_6;
            case 3:
              TimerResult timerResult2 = new TimerResult();
              ExecuteResultMessagesMaker.qF0sveEqM1ieuNQYrWh8((object) timerResult2, ExecuteResultMessagesMaker.x54ToWEqyasoD6x5JPws((object) info));
              timerResult2.Offset = ExecuteResultMessagesMaker.om9PqIEqdu6keMIpVrym(ExecuteResultMessagesMaker.x54ToWEqyasoD6x5JPws((object) info), ExecuteResultMessagesMaker.PjlGwtEq9lMFYi7ZHDw3(ExecuteResultMessagesMaker.JHU2uEEqJZBPSPCWjqYe((object) info)));
              ExecuteResultMessagesMaker.CnuN1HEqrQKpAv8OGroQ((object) timerResult2, ExecuteResultMessagesMaker.Dtd2VJEqlb3nZ2W2s8Ec((object) info));
              timerResult1 = timerResult2;
              num2 = 5;
              continue;
            case 4:
              if (diagnosticsCallInfoEvent.Info is ExecuteResultCallInfo info)
              {
                num2 = 3;
                continue;
              }
              goto label_6;
            case 5:
              goto label_10;
            default:
              goto label_3;
          }
        }
label_3:
        if (diagnosticsCallInfoEvent != null)
          num1 = 4;
        else
          break;
      }
label_6:
      return new object[0];
label_10:
      object[] objArray = new object[1];
      ExecuteResultMessage message = new ExecuteResultMessage();
      ExecuteResultMessagesMaker.HY9MR4EqjPMnri9yBa8v((object) message, ExecuteResultMessagesMaker.JOluJdEqg8pO3efREk9H((object) info) != null ? ExecuteResultMessagesMaker.VNCnLCEq5iNH5exULxcb(ExecuteResultMessagesMaker.JOluJdEqg8pO3efREk9H((object) info)) : (object) "");
      objArray[0] = (object) message.AsSourceMessage<ExecuteResultMessage>(((ControllerContext) ExecuteResultMessagesMaker.OZ2Jo2EqYw9E8Ze9VMtg((object) info)).Controller.GetType(), ExecuteResultMessagesMaker.MethodInfo).AsActionMessage<ExecuteResultMessage>((ControllerContext) info.ResultExecutingContext).AsMvcTimelineMessage<ExecuteResultMessage>(MvcTimelineCategory.Controller).AsChildActionMessage<ExecuteResultMessage>((ControllerContext) ExecuteResultMessagesMaker.OZ2Jo2EqYw9E8Ze9VMtg((object) info)).AsTimedMessage<ExecuteResultMessage>(timerResult1);
      return objArray;
    }

    public ExecuteResultMessagesMaker()
    {
      ExecuteResultMessagesMaker.vMRHk9EqLFTQx8MG7I3i();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ExecuteResultMessagesMaker()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ExecuteResultMessagesMaker.vMRHk9EqLFTQx8MG7I3i();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ExecuteResultMessagesMaker.MethodInfo = TypeOf<ActionResult>.Raw.GetMethod((string) ExecuteResultMessagesMaker.nLcmUpEqU5XgE0YsceOG(-606654180 ^ -606923260), new Type[1]
            {
              TypeOf<ControllerContext>.Raw
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool YPqnMjEq01QJoaF8yUXB() => ExecuteResultMessagesMaker.iWpfNMEqxiJYwrCnkWr0 == null;

    internal static ExecuteResultMessagesMaker xBZbklEqmc2tgYljHqyP() => ExecuteResultMessagesMaker.iWpfNMEqxiJYwrCnkWr0;

    internal static DateTime x54ToWEqyasoD6x5JPws([In] object obj0) => ((AbstractCallInfo) obj0).StartTime;

    internal static void qF0sveEqM1ieuNQYrWh8([In] object obj0, [In] DateTime obj1) => ((TimerResult) obj0).StartTime = obj1;

    internal static object JHU2uEEqJZBPSPCWjqYe([In] object obj0) => (object) ((AbstractCallInfo) obj0).ContextInfo;

    internal static DateTime PjlGwtEq9lMFYi7ZHDw3([In] object obj0) => ((CallContextInfo) obj0).StartTime;

    internal static TimeSpan om9PqIEqdu6keMIpVrym([In] DateTime obj0, [In] DateTime obj1) => obj0 - obj1;

    internal static TimeSpan Dtd2VJEqlb3nZ2W2s8Ec([In] object obj0) => ((AbstractCallInfo) obj0).TotalTime;

    internal static void CnuN1HEqrQKpAv8OGroQ([In] object obj0, [In] TimeSpan obj1) => ((TimerResult) obj0).Duration = obj1;

    internal static object JOluJdEqg8pO3efREk9H([In] object obj0) => (object) ((AbstractCallInfo) obj0).Exception;

    internal static object VNCnLCEq5iNH5exULxcb([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static void HY9MR4EqjPMnri9yBa8v([In] object obj0, [In] object obj1) => ((BaseMessage) obj0).EventSubText = (string) obj1;

    internal static object OZ2Jo2EqYw9E8Ze9VMtg([In] object obj0) => (object) ((ExecuteResultCallInfo) obj0).ResultExecutingContext;

    internal static void vMRHk9EqLFTQx8MG7I3i() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object nLcmUpEqU5XgE0YsceOG(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
