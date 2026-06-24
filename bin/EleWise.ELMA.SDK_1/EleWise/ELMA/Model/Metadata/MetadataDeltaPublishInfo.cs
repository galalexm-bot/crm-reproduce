// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.MetadataDeltaPublishInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>
  /// Результат проверки метаданных на возможность мягкой публикации или дельта-публикации
  /// </summary>
  internal class MetadataDeltaPublishInfo
  {
    private static MetadataDeltaPublishInfo vLopx5b3HDvFD7qkO6mF;

    /// <summary>Ctor</summary>
    /// <param name="isAllow">Допускаются ли оба вида публикации</param>
    public MetadataDeltaPublishInfo(bool isAllow)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.IsDeltaAllow = isAllow;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
            continue;
          case 2:
            this.IsSoftAllow = isAllow;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Ctor</summary>
    /// <param name="isSoftAllow">Допускается ли мягкая публикация</param>
    /// <param name="isDeltaAllow">Допускается ли дельта-публикация</param>
    public MetadataDeltaPublishInfo(bool isSoftAllow, bool isDeltaAllow)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.IsDeltaAllow = isDeltaAllow;
            num = 2;
            continue;
          case 2:
            goto label_3;
          default:
            this.IsSoftAllow = isSoftAllow;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Результат сравнения допускает мягкую публикацию</summary>
    public bool IsSoftAllow { get; }

    /// <summary>Результат сравнения допускает дельта-публикацию</summary>
    public bool IsDeltaAllow { get; }

    internal static bool sxee5wb3A4tas4eMCFZV() => MetadataDeltaPublishInfo.vLopx5b3HDvFD7qkO6mF == null;

    internal static MetadataDeltaPublishInfo YiYqaFb37d2wlLjvEuuW() => MetadataDeltaPublishInfo.vLopx5b3HDvFD7qkO6mF;
  }
}
