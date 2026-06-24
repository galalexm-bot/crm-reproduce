// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.PropertyHandlerAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Атрибут свойства класса, указывающий его обработчик</summary>
  [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
  public class PropertyHandlerAttribute : Attribute
  {
    private Guid handlerUid;
    private static PropertyHandlerAttribute ps6l5JoZH5QvbQ0pXghi;

    /// <summary>Ctor</summary>
    /// <param name="handlerUid">Uid обработчика</param>
    public PropertyHandlerAttribute(string handlerUid)
    {
      PropertyHandlerAttribute.c015f5oZxxdEoSbYkZp2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.handlerUid = new Guid(handlerUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Uid обработчика</summary>
    public Guid HandlerUid => this.handlerUid;

    internal static void c015f5oZxxdEoSbYkZp2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool UKNF1CoZAXowKSIB8E7O() => PropertyHandlerAttribute.ps6l5JoZH5QvbQ0pXghi == null;

    internal static PropertyHandlerAttribute Ivaq0ToZ7BGWFaeAC6Mb() => PropertyHandlerAttribute.ps6l5JoZH5QvbQ0pXghi;
  }
}
