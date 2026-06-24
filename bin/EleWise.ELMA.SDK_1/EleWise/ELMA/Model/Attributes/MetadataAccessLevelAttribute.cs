// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.MetadataAccessLevelAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Атрибут, указывающий уровень доступа к метаданным</summary>
  [Obsolete("Уровень доступа к метаданным больше не используется")]
  [AttributeUsage(AttributeTargets.All)]
  public class MetadataAccessLevelAttribute : Attribute
  {
    private MetadataAccessLevel level;
    internal static MetadataAccessLevelAttribute wYxO99ouOio5mJv1Ncxs;

    public MetadataAccessLevelAttribute(MetadataAccessLevel level)
    {
      MetadataAccessLevelAttribute.HwohIxouPobJ08P3aAYj();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.level = level;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Уровень</summary>
    public MetadataAccessLevel Level => this.level;

    internal static void HwohIxouPobJ08P3aAYj() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool V0kwBdou2tn783croWcl() => MetadataAccessLevelAttribute.wYxO99ouOio5mJv1Ncxs == null;

    internal static MetadataAccessLevelAttribute Y7MB60oue0BJfaFRxx1Y() => MetadataAccessLevelAttribute.wYxO99ouOio5mJv1Ncxs;
  }
}
