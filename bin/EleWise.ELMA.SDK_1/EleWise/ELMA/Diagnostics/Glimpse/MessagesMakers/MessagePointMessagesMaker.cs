// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Glimpse.MessagesMakers.MessagePointMessagesMaker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using Glimpse.Core.Message;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Glimpse.MessagesMakers
{
  /// <summary>
  /// Точка расширения для генерации сообщений в Glimpse для SqlCommand
  /// </summary>
  [Component]
  internal class MessagePointMessagesMaker : IGlimpseMessagesMaker
  {
    internal static MessagePointMessagesMaker kooIb0ERE4k2C3tl3nPD;

    /// <inheritdoc />
    public bool IsAvailable(DiagnosticsEvent @event) => @event is MessagePointEvent;

    /// <inheritdoc />
    public object[] MakeMessages(DiagnosticsEvent @event)
    {
      int num = 2;
      MessagePointEvent messagePointEvent;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (messagePointEvent == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            messagePointEvent = @event as MessagePointEvent;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return new object[0];
label_3:
      object[] objArray = new object[1];
      BaseMessage baseMessage = new BaseMessage();
      MessagePointMessagesMaker.lQmXVlERvJj59OhhO0v9((object) baseMessage, MessagePointMessagesMaker.ayxmJHERCeJGSGmSwfbN((object) messagePointEvent));
      baseMessage.Offset = MessagePointMessagesMaker.Xw4PkYERuaqnMdP0MU0G(MessagePointMessagesMaker.ayxmJHERCeJGSGmSwfbN((object) messagePointEvent), MessagePointMessagesMaker.ycH93vERZd2jYffO1WEq(MessagePointMessagesMaker.c09RTaER8g1nk1w7xAQt((object) messagePointEvent)));
      MessagePointMessagesMaker.bZGGpeERIuJ4YqNuTtQY((object) baseMessage, TimeSpan.Zero);
      MessagePointMessagesMaker.FrudNMERSeHUj0UeIgtT((object) baseMessage, MessagePointMessagesMaker.gJBtruERV08nWnuLYYjo((object) messagePointEvent));
      MessagePointMessagesMaker.n7wrHAERiTcPNIAnlKGy((object) baseMessage, (object) GlimpseHelper.MessagePoinTimelineCategoryItem);
      objArray[0] = (object) baseMessage;
      return objArray;
    }

    public MessagePointMessagesMaker()
    {
      MessagePointMessagesMaker.ymlwiAERRmEF5uwdsZc0();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool cjHVYIERfZTew7ti51KD() => MessagePointMessagesMaker.kooIb0ERE4k2C3tl3nPD == null;

    internal static MessagePointMessagesMaker PJlsiDERQlB4qyjvjncW() => MessagePointMessagesMaker.kooIb0ERE4k2C3tl3nPD;

    internal static DateTime ayxmJHERCeJGSGmSwfbN([In] object obj0) => ((DiagnosticsEvent) obj0).TimeStamp;

    internal static void lQmXVlERvJj59OhhO0v9([In] object obj0, DateTime value) => ((BaseMessage) obj0).StartTime = value;

    internal static object c09RTaER8g1nk1w7xAQt([In] object obj0) => (object) ((DiagnosticsEvent) obj0).CallContextInfo;

    internal static DateTime ycH93vERZd2jYffO1WEq([In] object obj0) => ((CallContextInfo) obj0).StartTime;

    internal static TimeSpan Xw4PkYERuaqnMdP0MU0G([In] DateTime obj0, [In] DateTime obj1) => obj0 - obj1;

    internal static void bZGGpeERIuJ4YqNuTtQY([In] object obj0, TimeSpan value) => ((BaseMessage) obj0).Duration = value;

    internal static object gJBtruERV08nWnuLYYjo([In] object obj0) => (object) ((DiagnosticsEvent) obj0).Message;

    internal static void FrudNMERSeHUj0UeIgtT([In] object obj0, [In] object obj1) => ((BaseMessage) obj0).EventName = (string) obj1;

    internal static void n7wrHAERiTcPNIAnlKGy([In] object obj0, [In] object obj1) => ((BaseMessage) obj0).EventCategory = (TimelineCategoryItem) obj1;

    internal static void ymlwiAERRmEF5uwdsZc0() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
