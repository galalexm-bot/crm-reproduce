// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Glimpse.MessagesMakers.AbstractMessagesMaker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Glimpse.MessagesMakers
{
  /// <summary>
  /// Базовый абстрактный класс генератора сообщений Glimpse
  /// </summary>
  internal abstract class AbstractMessagesMaker : IGlimpseMessagesMaker
  {
    internal static AbstractMessagesMaker PCOsI7ERqIYhUjS1upgG;

    /// <summary>Поддерживаемые типы событий системы диагностики</summary>
    public virtual Type[] SupportedEventTypes => new Type[0];

    /// <inheritdoc />
    public virtual bool IsAvailable(DiagnosticsEvent @event)
    {
      int num = 2;
      Type eventType;
      while (true)
      {
        switch (num)
        {
          case 1:
            eventType = @event.GetType();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return ((IEnumerable<Type>) AbstractMessagesMaker.BxOq4HERTpHLXEMt9qjd((object) this)).Any<Type>((Func<Type, bool>) (t => t.IsAssignableFrom(eventType)));
    }

    /// <inheritdoc />
    public abstract object[] MakeMessages(DiagnosticsEvent @event);

    protected AbstractMessagesMaker()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object BxOq4HERTpHLXEMt9qjd([In] object obj0) => (object) ((AbstractMessagesMaker) obj0).SupportedEventTypes;

    internal static bool R0CsK1ERKpsmLcsbG6cY() => AbstractMessagesMaker.PCOsI7ERqIYhUjS1upgG == null;

    internal static AbstractMessagesMaker Me4VSsERXj6Yleso8dga() => AbstractMessagesMaker.PCOsI7ERqIYhUjS1upgG;
  }
}
