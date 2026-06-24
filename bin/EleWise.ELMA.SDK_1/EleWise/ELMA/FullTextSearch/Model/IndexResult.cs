// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Model.IndexResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.FullTextSearch.Model
{
  /// <summary>Результат индексирования</summary>
  public class IndexResult
  {
    private static IndexResult nvVpWWGipttAgli7pfGF;

    /// <summary>Попытка индексирвоания успешна</summary>
    public bool Result
    {
      get => this.\u003CResult\u003Ek__BackingField;
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
              this.\u003CResult\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
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

    /// <summary>Все экземпляры сущности проиндексированы</summary>
    public bool IndexAllEntities
    {
      get => this.\u003CIndexAllEntities\u003Ek__BackingField;
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
              this.\u003CIndexAllEntities\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
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

    /// <summary>
    /// Прогресс выполнения, для переиндексирования по типу или полного
    /// </summary>
    internal ContinueInfo ContinueInfo
    {
      get => this.\u003CContinueInfo\u003Ek__BackingField;
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
              this.\u003CContinueInfo\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
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

    public IndexResult()
    {
      IndexResult.wqEcbtGitP9edFTWsCIA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool iE2LQUGiaufypfGfl8IQ() => IndexResult.nvVpWWGipttAgli7pfGF == null;

    internal static IndexResult tEnbksGiDPN115bC5vA2() => IndexResult.nvVpWWGipttAgli7pfGF;

    internal static void wqEcbtGitP9edFTWsCIA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
