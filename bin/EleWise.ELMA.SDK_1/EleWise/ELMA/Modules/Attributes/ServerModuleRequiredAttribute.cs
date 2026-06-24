// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.Attributes.ServerModuleRequiredAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Modules.Attributes
{
  /// <summary>
  /// Указывает, что для модуля в дизайнере требуется, чтобы он был доступен на сервере
  /// </summary>
  [AttributeUsage(AttributeTargets.Assembly)]
  public class ServerModuleRequiredAttribute : Attribute
  {
    private static ServerModuleRequiredAttribute cBDeGkaOEXTJmQHDjqE;

    public ServerModuleRequiredAttribute()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Q4HO1fa2gg8kFoGWcuK() => ServerModuleRequiredAttribute.cBDeGkaOEXTJmQHDjqE == null;

    internal static ServerModuleRequiredAttribute H3pjPMaeII6yDsUnhqk() => ServerModuleRequiredAttribute.cBDeGkaOEXTJmQHDjqE;
  }
}
