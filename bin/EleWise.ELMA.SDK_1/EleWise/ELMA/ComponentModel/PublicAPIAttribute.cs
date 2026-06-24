// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.PublicAPIAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// This attribute is intended to mark publicly available API
  /// which should not be removed and so is treated as used.
  /// </summary>
  [MeansImplicitUse(ImplicitUseTargetFlags.WithMembers)]
  public sealed class PublicAPIAttribute : Attribute
  {
    private static PublicAPIAttribute Aua0mqffdQM6Zh6h6xoq;

    public PublicAPIAttribute()
    {
      PublicAPIAttribute.ala8cpffg5xCNnoht9VL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public PublicAPIAttribute([NotNull] string comment)
    {
      PublicAPIAttribute.ala8cpffg5xCNnoht9VL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Comment = comment;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    public string Comment
    {
      get => this.\u003CComment\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CComment\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    internal static void ala8cpffg5xCNnoht9VL() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool D2tEEcfflIPLSD0nOAd7() => PublicAPIAttribute.Aua0mqffdQM6Zh6h6xoq == null;

    internal static PublicAPIAttribute oYdqAdffrq1aVhKVTVLD() => PublicAPIAttribute.Aua0mqffdQM6Zh6h6xoq;
  }
}
