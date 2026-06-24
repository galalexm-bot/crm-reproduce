// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.Attributes.ModuleHtmlDescriptionAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Modules.Attributes
{
  /// <summary>Указывает HTML-описание модуля ELMA</summary>
  [AttributeUsage(AttributeTargets.Assembly)]
  public class ModuleHtmlDescriptionAttribute : Attribute
  {
    private string description;
    private static ModuleHtmlDescriptionAttribute mRgBMDavVgjYGH6Qpgy;

    /// <summary>Ctor</summary>
    /// <param name="description">HTML-описание модуля</param>
    public ModuleHtmlDescriptionAttribute(string description)
    {
      ModuleHtmlDescriptionAttribute.Txkns0aupJI23fx5n50();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.description = description;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>HTML-описание модуля</summary>
    public string Description => this.description;

    internal static void Txkns0aupJI23fx5n50() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool jjdmvXa8qdhy77H3uNx() => ModuleHtmlDescriptionAttribute.mRgBMDavVgjYGH6Qpgy == null;

    internal static ModuleHtmlDescriptionAttribute Xr53ecaZuvPeNWZsw3m() => ModuleHtmlDescriptionAttribute.mRgBMDavVgjYGH6Qpgy;
  }
}
