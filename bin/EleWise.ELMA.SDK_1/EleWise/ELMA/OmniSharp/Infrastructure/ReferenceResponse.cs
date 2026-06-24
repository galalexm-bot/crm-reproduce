// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.OmniSharp.Infrastructure.ReferenceResponse
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.OmniSharp.Infrastructure
{
  /// <summary>Ответ операции omnisharp с дополнительными ссылками</summary>
  internal class ReferenceResponse
  {
    private static ReferenceResponse QbqwqcWrKqtXKa3hSPFh;

    /// <summary>Флаг успеха</summary>
    public bool Success
    {
      get => this.\u003CSuccess\u003Ek__BackingField;
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
              this.\u003CSuccess\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
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

    /// <summary>Флаг "повторите позже"</summary>
    /// <remarks>
    /// Встречается, когда проект ещё не загрузился, а запрос уже пришёл
    /// </remarks>
    public bool ShouldRetryLater
    {
      get => this.\u003CShouldRetryLater\u003Ek__BackingField;
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
              this.\u003CShouldRetryLater\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
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

    /// <summary>Описание</summary>
    public string Description
    {
      get => this.\u003CDescription\u003Ek__BackingField;
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
              this.\u003CDescription\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
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

    public ReferenceResponse()
    {
      ReferenceResponse.yqG9PlWrkak3J80rQ4nM();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool KKyjUKWrXfJ0PbhKCQKl() => ReferenceResponse.QbqwqcWrKqtXKa3hSPFh == null;

    internal static ReferenceResponse FZl19PWrT6oHCgTjsR3h() => ReferenceResponse.QbqwqcWrKqtXKa3hSPFh;

    internal static void yqG9PlWrkak3J80rQ4nM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
