// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.Exceptions.ModulesMissingException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Modules.Exceptions
{
  /// <summary>Вызывается при ошибке лицензирования</summary>
  [Serializable]
  public class ModulesMissingException : Exception
  {
    internal static ModulesMissingException ULJDFB1TFFCoIZqfQBO;

    public ModulesMissingException(string message)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected ModulesMissingException(SerializationInfo info, StreamingContext context)
    {
      ModulesMissingException.TkF4gt1OYD7pfnntdRG();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool UTDDKK1kuC1VIQByPPf() => ModulesMissingException.ULJDFB1TFFCoIZqfQBO == null;

    internal static ModulesMissingException XsVHmA1nw0wNgJZxAm2() => ModulesMissingException.ULJDFB1TFFCoIZqfQBO;

    internal static void TkF4gt1OYD7pfnntdRG() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
