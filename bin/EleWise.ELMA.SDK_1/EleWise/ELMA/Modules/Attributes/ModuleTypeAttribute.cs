// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.Attributes.ModuleTypeAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Modules.Attributes
{
  /// <summary>Указывает тип модуля ELMA</summary>
  [AttributeUsage(AttributeTargets.Assembly)]
  public class ModuleTypeAttribute : Attribute
  {
    private ModuleType moduleType;
    private static ModuleTypeAttribute RFcbgwaRdyp5LevlE6H;

    /// <summary>Ctor</summary>
    /// <param name="moduleType">Тип модуля</param>
    public ModuleTypeAttribute(ModuleType moduleType)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.moduleType = moduleType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Тип модуля</summary>
    public ModuleType ModuleType => this.moduleType;

    internal static bool b6FNs6aq1ZG5GyVGQuN() => ModuleTypeAttribute.RFcbgwaRdyp5LevlE6H == null;

    internal static ModuleTypeAttribute fWUXdSaKNssg0WqvC1f() => ModuleTypeAttribute.RFcbgwaRdyp5LevlE6H;
  }
}
