// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Glimpse.MessagesMakers.MethodCallMessagesMaker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Events;
using Glimpse.Core.Message;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Glimpse.MessagesMakers
{
  /// <summary>
  /// Точка расширения для генерации сообщений в Glimpse для MethodCall
  /// </summary>
  [Component]
  internal class MethodCallMessagesMaker : AbstractMessagesMaker
  {
    internal static MethodCallMessagesMaker xitE61EqBWlC7F2KuBmG;

    /// <inheritdoc />
    public override Type[] SupportedEventTypes => new Type[2]
    {
      TypeOf<MethodCallEndEvent>.Raw,
      TypeOf<MethodCallErrorEvent>.Raw
    };

    /// <inheritdoc />
    public override object[] MakeMessages(DiagnosticsEvent @event)
    {
      int num = 3;
      IDiagnosticsCallInfoEvent diagnosticsCallInfoEvent;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            if (diagnosticsCallInfoEvent != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 3:
            diagnosticsCallInfoEvent = @event as IDiagnosticsCallInfoEvent;
            num = 2;
            continue;
          default:
            if (!(MethodCallMessagesMaker.NvpL3HEqbuwrqEpLRhTG((object) diagnosticsCallInfoEvent) is MethodCallInfo methodCallInfo))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 1 : 1;
              continue;
            }
            goto label_8;
        }
      }
label_7:
      return new object[0];
label_8:
      object[] objArray = new object[1];
      MethodMessage methodMessage = new MethodMessage();
      methodMessage.StartTime = methodCallInfo.StartTime;
      MethodCallMessagesMaker.igaBZqEqQCp1vgIlgBTt((object) methodMessage, MethodCallMessagesMaker.ATob7OEqfixBtfbOHIrU(MethodCallMessagesMaker.DfoK8oEqhQJTJ4MXx9J9((object) methodCallInfo), MethodCallMessagesMaker.tbUBbSEqET3cSUdnckbN(MethodCallMessagesMaker.PLB3ElEqGa5J4JFyaGwO((object) methodCallInfo))));
      MethodCallMessagesMaker.NHQAATEqvqvA2SkNZmJM((object) methodMessage, MethodCallMessagesMaker.GXmhO3EqCTApGrS28XwA((object) methodCallInfo));
      MethodCallMessagesMaker.BxxxNNEqZk8k9kvKGmbU((object) methodMessage, MethodCallMessagesMaker.GgThgREq8Ox2lTW6djAR((object) methodCallInfo));
      MethodCallMessagesMaker.bFwtjuEquVmQ83yLdac7((object) methodMessage, (object) GlimpseHelper.MethodTimelineCategoryItem);
      MethodCallMessagesMaker.xFCnN1EqVhM4EUvX3WQ7((object) methodMessage, MethodCallMessagesMaker.BpvNVGEqIALHyhf8evpg((object) methodCallInfo));
      MethodCallMessagesMaker.YL0J8NEqiJ6PAkiFSFjN((object) methodMessage, MethodCallMessagesMaker.SCJVbkEqSTDI5IkCCngy((object) methodCallInfo));
      methodMessage.EventSubText = MethodCallMessagesMaker.iiTRjbEqR5wQLKFIT8Zr((object) methodCallInfo) != null ? (string) MethodCallMessagesMaker.gq66xREqql3htAUhie5m((object) methodCallInfo.Exception) : "";
      objArray[0] = (object) methodMessage;
      return objArray;
    }

    public MethodCallMessagesMaker()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool QwTMofEqWogbcHP4B9Cn() => MethodCallMessagesMaker.xitE61EqBWlC7F2KuBmG == null;

    internal static MethodCallMessagesMaker qZQy3IEqo9qbD7nW7aHr() => MethodCallMessagesMaker.xitE61EqBWlC7F2KuBmG;

    internal static object NvpL3HEqbuwrqEpLRhTG([In] object obj0) => (object) ((IDiagnosticsCallInfoEvent) obj0).Info;

    internal static DateTime DfoK8oEqhQJTJ4MXx9J9([In] object obj0) => ((AbstractCallInfo) obj0).StartTime;

    internal static object PLB3ElEqGa5J4JFyaGwO([In] object obj0) => (object) ((AbstractCallInfo) obj0).ContextInfo;

    internal static DateTime tbUBbSEqET3cSUdnckbN([In] object obj0) => ((CallContextInfo) obj0).StartTime;

    internal static TimeSpan ATob7OEqfixBtfbOHIrU([In] DateTime obj0, [In] DateTime obj1) => obj0 - obj1;

    internal static void igaBZqEqQCp1vgIlgBTt([In] object obj0, TimeSpan value) => ((BaseMessage) obj0).Offset = value;

    internal static TimeSpan GXmhO3EqCTApGrS28XwA([In] object obj0) => ((AbstractCallInfo) obj0).TotalTime;

    internal static void NHQAATEqvqvA2SkNZmJM([In] object obj0, TimeSpan value) => ((BaseMessage) obj0).Duration = value;

    internal static object GgThgREq8Ox2lTW6djAR([In] object obj0) => (object) ((AbstractCallInfo) obj0).Description;

    internal static void BxxxNNEqZk8k9kvKGmbU([In] object obj0, [In] object obj1) => ((BaseMessage) obj0).EventName = (string) obj1;

    internal static void bFwtjuEquVmQ83yLdac7([In] object obj0, [In] object obj1) => ((BaseMessage) obj0).EventCategory = (TimelineCategoryItem) obj1;

    internal static Type BpvNVGEqIALHyhf8evpg([In] object obj0) => ((MethodCallInfo) obj0).OwnerType;

    internal static void xFCnN1EqVhM4EUvX3WQ7([In] object obj0, Type value) => ((MethodMessage) obj0).ExecutedType = value;

    internal static object SCJVbkEqSTDI5IkCCngy([In] object obj0) => (object) ((MethodCallInfo) obj0).Method;

    internal static void YL0J8NEqiJ6PAkiFSFjN([In] object obj0, [In] object obj1) => ((MethodMessage) obj0).ExecutedMethod = (MethodInfo) obj1;

    internal static object iiTRjbEqR5wQLKFIT8Zr([In] object obj0) => (object) ((AbstractCallInfo) obj0).Exception;

    internal static object gq66xREqql3htAUhie5m([In] object obj0) => (object) ((Exception) obj0).Message;
  }
}
