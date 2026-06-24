// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Glimpse.MessagesMakers.FindViewMessagesMaker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Events;
using Glimpse.Core.Extensibility;
using Glimpse.Core.Message;
using Glimpse.Core.Tab.Assist;
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
  /// Точка расширения для генерации сообщений в Glimpse для FindView
  /// </summary>
  [Component]
  internal class FindViewMessagesMaker : IGlimpseMessagesMaker
  {
    private static readonly MethodInfo MethodInfo;
    private static FindViewMessagesMaker GcZqkdEqK0rhe1aex4Ot;

    /// <inheritdoc />
    public bool IsAvailable(DiagnosticsEvent @event) => @event is FindViewEndEvent;

    /// <inheritdoc />
    public object[] MakeMessages(DiagnosticsEvent @event)
    {
      int num1 = 8;
      FindViewMessage message;
      while (true)
      {
        int num2 = num1;
        Type baseType;
        TimerResult timerResult1;
        while (true)
        {
          IDiagnosticsCallInfoEvent diagnosticsCallInfoEvent;
          Type type;
          switch (num2)
          {
            case 1:
              type = (Type) null;
              break;
            case 2:
              message = message.AsSourceMessage<FindViewMessage>(FindViewMessagesMaker.MSIMhtEqHf5YyM9DMq8W(FindViewMessagesMaker.g8WOg9Eq6DYXJ3c1EGrQ((object) findViewInfo)).GetType(), FindViewMessagesMaker.MethodInfo);
              num2 = 3;
              continue;
            case 3:
              goto label_6;
            case 4:
              goto label_4;
            case 5:
              goto label_3;
            case 6:
              if (FindViewMessagesMaker.dhKGc4EqtjmSMDTLKw5E((object) findViewInfo))
              {
                num2 = 2;
                continue;
              }
              goto label_6;
            case 7:
              if (diagnosticsCallInfoEvent != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 8:
              diagnosticsCallInfoEvent = @event as IDiagnosticsCallInfoEvent;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 7 : 5;
              continue;
            case 9:
              TimerResult timerResult2 = new TimerResult();
              timerResult2.StartTime = FindViewMessagesMaker.jdM8X0EqnLocUl7TVqQl((object) findViewInfo);
              timerResult2.Offset = FindViewMessagesMaker.RrOOCuEqee84jlCuZoIq(findViewInfo.StartTime, FindViewMessagesMaker.baCdsWEq2RxggVglaK5b(FindViewMessagesMaker.zpH26gEqOJ4jyRxyjxHu((object) findViewInfo)));
              FindViewMessagesMaker.rLSdUXEq1Ds3mQJaACY5((object) timerResult2, FindViewMessagesMaker.IciNYKEqP63tMiJgunm4((object) findViewInfo));
              timerResult1 = timerResult2;
              num2 = 10;
              continue;
            case 10:
              if (FindViewMessagesMaker.HcIjTVEqNyylRIt4Ndux((object) findViewInfo) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 0;
                continue;
              }
              type = FindViewMessagesMaker.DUXkF4Eq3VBYH07LOI3S((object) findViewInfo.ViewContext).GetType();
              break;
            default:
              if (FindViewMessagesMaker.g9xOBFEqkLyq3M9G9jCL((object) diagnosticsCallInfoEvent) is FindViewInfo findViewInfo)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 9 : 3;
                continue;
              }
              goto label_4;
          }
          baseType = type;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 5 : 5;
        }
label_3:
        message = new FindViewMessage(FindViewMessagesMaker.Su2YyMEqpHbldSjW4VAL(), (string) FindViewMessagesMaker.z5TRpKEqaLIQ0GUqpYRX((object) findViewInfo), findViewInfo.MasterName, true, findViewInfo.SearchedLocations, baseType, FindViewMessagesMaker.yJEajZEqDufDqgFZri0r((object) findViewInfo), FindViewMessagesMaker.dhKGc4EqtjmSMDTLKw5E((object) findViewInfo), (string) null, (Type) null).AsActionMessage<FindViewMessage>(findViewInfo.ControllerContext).AsChildActionMessage<FindViewMessage>((ControllerContext) FindViewMessagesMaker.A5N5R6Eqw23yWXa0icEg((object) findViewInfo)).AsTimelineMessage<FindViewMessage>((string) FindViewMessagesMaker.myl0c6Eq4IZkk59NhTfY((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767445139), (object) new object[2]
        {
          FindViewMessagesMaker.z5TRpKEqaLIQ0GUqpYRX((object) findViewInfo),
          (object) findViewInfo.IsFound
        }), GlimpseHelper.FindViewTimelineCategoryItem).AsTimedMessage<FindViewMessage>(timerResult1);
        num1 = 6;
      }
label_4:
      return new object[0];
label_6:
      return new object[1]{ (object) message };
    }

    public FindViewMessagesMaker()
    {
      FindViewMessagesMaker.M4TbbvEqA4Riw7GJqvhF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static FindViewMessagesMaker()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            FindViewMessagesMaker.M4TbbvEqA4Riw7GJqvhF();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            FindViewMessagesMaker.MethodInfo = TypeOf<IViewEngine>.Raw.GetMethod((string) FindViewMessagesMaker.xsUaCnEq75vjj2uZKBqN(-1872275253 >> 6 ^ -28980829));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool omrFFXEqXqt3JFgjgmxY() => FindViewMessagesMaker.GcZqkdEqK0rhe1aex4Ot == null;

    internal static FindViewMessagesMaker JMf3Q5EqTSYWVGENHTLS() => FindViewMessagesMaker.GcZqkdEqK0rhe1aex4Ot;

    internal static object g9xOBFEqkLyq3M9G9jCL([In] object obj0) => (object) ((IDiagnosticsCallInfoEvent) obj0).Info;

    internal static DateTime jdM8X0EqnLocUl7TVqQl([In] object obj0) => ((AbstractCallInfo) obj0).StartTime;

    internal static object zpH26gEqOJ4jyRxyjxHu([In] object obj0) => (object) ((AbstractCallInfo) obj0).ContextInfo;

    internal static DateTime baCdsWEq2RxggVglaK5b([In] object obj0) => ((CallContextInfo) obj0).StartTime;

    internal static TimeSpan RrOOCuEqee84jlCuZoIq([In] DateTime obj0, [In] DateTime obj1) => obj0 - obj1;

    internal static TimeSpan IciNYKEqP63tMiJgunm4([In] object obj0) => ((AbstractCallInfo) obj0).TotalTime;

    internal static void rLSdUXEq1Ds3mQJaACY5([In] object obj0, [In] TimeSpan obj1) => ((TimerResult) obj0).Duration = obj1;

    internal static object HcIjTVEqNyylRIt4Ndux([In] object obj0) => (object) ((FindViewInfo) obj0).ViewContext;

    internal static object DUXkF4Eq3VBYH07LOI3S([In] object obj0) => (object) ((ViewContext) obj0).View;

    internal static Guid Su2YyMEqpHbldSjW4VAL() => Guid.NewGuid();

    internal static object z5TRpKEqaLIQ0GUqpYRX([In] object obj0) => (object) ((FindViewInfo) obj0).ViewName;

    internal static bool yJEajZEqDufDqgFZri0r([In] object obj0) => ((FindViewInfo) obj0).IsPartial;

    internal static bool dhKGc4EqtjmSMDTLKw5E([In] object obj0) => ((FindViewInfo) obj0).IsFound;

    internal static object A5N5R6Eqw23yWXa0icEg([In] object obj0) => (object) ((FindViewInfo) obj0).ControllerContext;

    internal static object myl0c6Eq4IZkk59NhTfY([In] object obj0, [In] object obj1) => (object) ((string) obj0).FormatWith((object[]) obj1);

    internal static object g8WOg9Eq6DYXJ3c1EGrQ([In] object obj0) => (object) ((FindViewInfo) obj0).ViewEngineResult;

    internal static object MSIMhtEqHf5YyM9DMq8W([In] object obj0) => (object) ((ViewEngineResult) obj0).ViewEngine;

    internal static void M4TbbvEqA4Riw7GJqvhF() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object xsUaCnEq75vjj2uZKBqN(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
