// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Glimpse.MessagesMakers.RenderViewMessagesMaker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Events;
using Glimpse.Core.Extensibility;
using Glimpse.Core.Extensions;
using Glimpse.Core.Message;
using Glimpse.Core.Tab.Assist;
using Glimpse.Mvc.AlternateType;
using Glimpse.Mvc.Message;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Web.Mvc;

namespace EleWise.ELMA.Diagnostics.Glimpse.MessagesMakers
{
  /// <summary>
  /// Точка расширения для генерации сообщений в Glimpse для RenderView
  /// </summary>
  [Component]
  internal class RenderViewMessagesMaker : AbstractMessagesMaker
  {
    private static RenderViewMessagesMaker yNZKFQERAgOBnYRoqwRv;

    /// <inheritdoc />
    public override Type[] SupportedEventTypes => new Type[2]
    {
      TypeOf<RenderViewEndEvent>.Raw,
      TypeOf<RenderViewStartEvent>.Raw
    };

    /// <inheritdoc />
    public override object[] MakeMessages(DiagnosticsEvent @event)
    {
      int num = 4;
      IDiagnosticsCallInfoEvent diagnosticsCallInfoEvent;
      TimerResult timerResult1;
      Type typeOrNull;
      while (true)
      {
        switch (num)
        {
          case 1:
            TimerResult timerResult2 = new TimerResult();
            timerResult2.StartTime = RenderViewMessagesMaker.QcrZXcERmqVbkoNMxUAq((object) renderViewInfo);
            RenderViewMessagesMaker.HC2s0AER9NT7DPYmyic5((object) timerResult2, RenderViewMessagesMaker.twBjPeERJk4mjB7UC2tt(RenderViewMessagesMaker.QcrZXcERmqVbkoNMxUAq((object) renderViewInfo), RenderViewMessagesMaker.Es5CexERMlJJexnt8Dts(RenderViewMessagesMaker.amx6yEERy6rdAN9YeXwp((object) renderViewInfo))));
            timerResult2.Duration = RenderViewMessagesMaker.zrAUiJERdjL6d68YDBpJ((object) renderViewInfo);
            timerResult1 = timerResult2;
            num = 5;
            continue;
          case 2:
            goto label_6;
          case 3:
            if (diagnosticsCallInfoEvent != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 4:
            diagnosticsCallInfoEvent = @event as IDiagnosticsCallInfoEvent;
            num = 3;
            continue;
          case 5:
            typeOrNull = RenderViewMessagesMaker.Y28kDLERgK8xPBuTpl2f(RenderViewMessagesMaker.kFwjcdERrS4gG4tYfHgf(RenderViewMessagesMaker.qsEyDZERldMNyACInyhl((object) renderViewInfo))).GetTypeOrNull();
            num = 6;
            continue;
          case 6:
            goto label_10;
          default:
            if (RenderViewMessagesMaker.WJbPFMER06faKNevRBTE((object) diagnosticsCallInfoEvent) is RenderViewInfo renderViewInfo)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 1;
              continue;
            }
            goto label_6;
        }
      }
label_6:
      return new object[0];
label_10:
      return new object[1]
      {
        (object) new View.Render.Message(typeOrNull, ((ModelStateDictionary) RenderViewMessagesMaker.Mr1JnWER52Y5Y2ICGmZ8(RenderViewMessagesMaker.kFwjcdERrS4gG4tYfHgf(RenderViewMessagesMaker.qsEyDZERldMNyACInyhl((object) renderViewInfo)))).IsValid, (IDictionary<string, object>) ((ViewContext) RenderViewMessagesMaker.qsEyDZERldMNyACInyhl((object) renderViewInfo)).TempData, (IDictionary<string, object>) RenderViewMessagesMaker.kFwjcdERrS4gG4tYfHgf(RenderViewMessagesMaker.qsEyDZERldMNyACInyhl((object) renderViewInfo)), (ModelMetadata) RenderViewMessagesMaker.I9Ho7gERj1h9Weg6nhja((object) ((ViewContext) RenderViewMessagesMaker.qsEyDZERldMNyACInyhl((object) renderViewInfo)).ViewData), RenderViewMessagesMaker.htk39uERYrMYp8jL0NrI(RenderViewMessagesMaker.qsEyDZERldMNyACInyhl((object) renderViewInfo)).GetType(), (IViewCorrelationMixin) new ViewCorrelationMixin(renderViewInfo.VirtualPath, RenderViewMessagesMaker.AxOwZtERLfrgAYC9YoAk((object) renderViewInfo), RenderViewMessagesMaker.Cml9U2ERUSLOaWn6Rlg2())).AsActionMessage<View.Render.Message>((ControllerContext) renderViewInfo.ViewContext).AsTimelineMessage<View.Render.Message>((string) RenderViewMessagesMaker.La8khRERz2OgxC1vrJVg(RenderViewMessagesMaker.u9GHKfERs8CgGPBymrOH(--1333735954 ^ 1333487212), (object) new object[1]
        {
          RenderViewMessagesMaker.BwAeuNERcxan8OF6NgIe((object) renderViewInfo)
        }), (TimelineCategoryItem) RenderViewMessagesMaker.WabGaOEqF1yS4d1WYay3()).AsTimedMessage<View.Render.Message>(timerResult1)
      };
    }

    public RenderViewMessagesMaker()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool YfFFjeER73OfZf4GGUe6() => RenderViewMessagesMaker.yNZKFQERAgOBnYRoqwRv == null;

    internal static RenderViewMessagesMaker mJX2yrERxfkjDXQZVQc1() => RenderViewMessagesMaker.yNZKFQERAgOBnYRoqwRv;

    internal static object WJbPFMER06faKNevRBTE([In] object obj0) => (object) ((IDiagnosticsCallInfoEvent) obj0).Info;

    internal static DateTime QcrZXcERmqVbkoNMxUAq([In] object obj0) => ((AbstractCallInfo) obj0).StartTime;

    internal static object amx6yEERy6rdAN9YeXwp([In] object obj0) => (object) ((AbstractCallInfo) obj0).ContextInfo;

    internal static DateTime Es5CexERMlJJexnt8Dts([In] object obj0) => ((CallContextInfo) obj0).StartTime;

    internal static TimeSpan twBjPeERJk4mjB7UC2tt([In] DateTime obj0, [In] DateTime obj1) => obj0 - obj1;

    internal static void HC2s0AER9NT7DPYmyic5([In] object obj0, [In] TimeSpan obj1) => ((TimerResult) obj0).Offset = obj1;

    internal static TimeSpan zrAUiJERdjL6d68YDBpJ([In] object obj0) => ((AbstractCallInfo) obj0).TotalTime;

    internal static object qsEyDZERldMNyACInyhl([In] object obj0) => (object) ((RenderViewInfo) obj0).ViewContext;

    internal static object kFwjcdERrS4gG4tYfHgf([In] object obj0) => (object) ((ViewContext) obj0).ViewData;

    internal static object Y28kDLERgK8xPBuTpl2f([In] object obj0) => ((ViewDataDictionary) obj0).Model;

    internal static object Mr1JnWER52Y5Y2ICGmZ8([In] object obj0) => (object) ((ViewDataDictionary) obj0).ModelState;

    internal static object I9Ho7gERj1h9Weg6nhja([In] object obj0) => (object) ((ViewDataDictionary) obj0).ModelMetadata;

    internal static object htk39uERYrMYp8jL0NrI([In] object obj0) => (object) ((ViewContext) obj0).View;

    internal static bool AxOwZtERLfrgAYC9YoAk([In] object obj0) => ((RenderViewInfo) obj0).IsPartial;

    internal static Guid Cml9U2ERUSLOaWn6Rlg2() => Guid.NewGuid();

    internal static object u9GHKfERs8CgGPBymrOH(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object BwAeuNERcxan8OF6NgIe([In] object obj0) => (object) ((RenderViewInfo) obj0).VirtualPath;

    internal static object La8khRERz2OgxC1vrJVg([In] object obj0, [In] object obj1) => (object) ((string) obj0).FormatWith((object[]) obj1);

    internal static object WabGaOEqF1yS4d1WYay3() => (object) MvcTimelineCategory.View;
  }
}
