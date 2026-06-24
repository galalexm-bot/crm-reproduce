// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Impl.LazyEventHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Events.Impl
{
  /// <summary>
  /// Абстрактный обработчик событий с ленивым разрешением и фактическим типом обработчика
  /// </summary>
  [DebuggerDisplay("Type={EventHandlerType}, Order = {Order}, IsValueCreated={IsValueCreated}, Value={ValueForDebugDisplay}")]
  internal class LazyEventHandler : Lazy<IEventHandler>
  {
    internal static LazyEventHandler bI2PLUGYpWvNPxsBKlsa;

    /// <summary>ctor</summary>
    /// <param name="valueFactory">Фабрика значения</param>
    /// <param name="eventHandlerType">Фактический тип обработчика</param>
    /// <param name="order">Порядок обработчика</param>
    public LazyEventHandler(Func<IEventHandler> valueFactory, Type eventHandlerType, int order)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(valueFactory);
      this.EventHandlerType = eventHandlerType;
      this.Order = order;
    }

    /// <summary>ctor</summary>
    /// <param name="eventHandler">Обработчик события</param>
    public LazyEventHandler(IEventHandler eventHandler)
    {
      LazyEventHandler.qDXvKwGYtC16A90yevi9();
      // ISSUE: explicit constructor call
      base.\u002Ector((Func<IEventHandler>) (() => eventHandler));
      int num = 4;
      OrderAttribute attribute;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (attribute == null)
            {
              num = 2;
              continue;
            }
            goto case 5;
          case 2:
            goto label_4;
          case 3:
            goto label_2;
          case 4:
            this.EventHandlerType = eventHandler.GetType();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
            continue;
          case 5:
            this.Order = LazyEventHandler.iuWNC9GYwQBUmExIt0We((object) attribute);
            num = 3;
            continue;
          default:
            attribute = AttributeHelper<OrderAttribute>.GetAttribute(this.EventHandlerType, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 1;
            continue;
        }
      }
label_4:
      return;
label_2:;
    }

    /// <summary>Фактический тип обработчика</summary>
    public Type EventHandlerType { get; }

    /// <summary>Порядок обработчика</summary>
    public int Order { get; }

    internal static void qDXvKwGYtC16A90yevi9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static int iuWNC9GYwQBUmExIt0We([In] object obj0) => ((OrderAttribute) obj0).Order;

    internal static bool rrsK20GYakEWLYAQ3QNw() => LazyEventHandler.bI2PLUGYpWvNPxsBKlsa == null;

    internal static LazyEventHandler iF9VF9GYDWf3cZyNf1Da() => LazyEventHandler.bI2PLUGYpWvNPxsBKlsa;
  }
}
