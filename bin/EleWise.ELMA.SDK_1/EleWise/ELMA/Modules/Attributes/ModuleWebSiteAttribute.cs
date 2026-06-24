// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.Attributes.ModuleWebSiteAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Modules.Attributes
{
  /// <summary>Указывает веб-сайт модуля ELMA</summary>
  [AttributeUsage(AttributeTargets.Assembly)]
  public class ModuleWebSiteAttribute : Attribute
  {
    private string webSite;
    internal static ModuleWebSiteAttribute CvCfhjaXdh3yRhrUKu2;

    /// <summary>Ctor</summary>
    /// <param name="webSite">Веб-сайт модуля ELMA</param>
    public ModuleWebSiteAttribute(string webSite)
    {
      ModuleWebSiteAttribute.Q3njd5anp24ShvgVJrr();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.webSite = webSite;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Веб-сайт модуля ELMA</summary>
    public string WebSite => this.webSite;

    internal static void Q3njd5anp24ShvgVJrr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool SboMmCaTXnefHudvdbD() => ModuleWebSiteAttribute.CvCfhjaXdh3yRhrUKu2 == null;

    internal static ModuleWebSiteAttribute Gg19H0akOEvg1ILX06p() => ModuleWebSiteAttribute.CvCfhjaXdh3yRhrUKu2;
  }
}
