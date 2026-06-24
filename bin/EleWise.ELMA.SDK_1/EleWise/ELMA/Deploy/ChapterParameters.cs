// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.ChapterParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy
{
  /// <summary>Параметры построения элементов BPM-App`а</summary>
  public sealed class ChapterParameters : IChapterParameters
  {
    internal static ChapterParameters pJfYS6EOwlKH64vRJav7;

    /// <summary>Включить пустые заголовки</summary>
    public bool WithEmptyChapters
    {
      get => this.\u003CWithEmptyChapters\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CWithEmptyChapters\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
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

    public ChapterParameters()
    {
      ChapterParameters.EHt4oDEOHpGm7jN9BCbu();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool k3Q3XTEO4AjIGNVspbEh() => ChapterParameters.pJfYS6EOwlKH64vRJav7 == null;

    internal static ChapterParameters KhZsLKEO6igHm5r3SWeh() => ChapterParameters.pJfYS6EOwlKH64vRJav7;

    internal static void EHt4oDEOHpGm7jN9BCbu() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
