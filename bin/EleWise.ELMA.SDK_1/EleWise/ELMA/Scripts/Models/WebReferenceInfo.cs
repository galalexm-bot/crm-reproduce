// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scripts.Models.WebReferenceInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Scripts.Models
{
  /// <summary>Класс с информацией о веб-сервисе</summary>
  public sealed class WebReferenceInfo
  {
    private static WebReferenceInfo rO8VocWBDvCI4avZAqMR;

    /// <summary>Имя ссылки на веб-сервис</summary>
    public string WebReferenceName
    {
      get => this.\u003CWebReferenceName\u003Ek__BackingField;
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
              this.\u003CWebReferenceName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
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

    /// <summary>Путь до файла с кодом сервиса</summary>
    public string CodeFilePath
    {
      get => this.\u003CCodeFilePath\u003Ek__BackingField;
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
              this.\u003CCodeFilePath\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
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

    public WebReferenceInfo()
    {
      WebReferenceInfo.eUayTXWB4qAQs7uINWE9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool VjgusyWBtPCZXgn6taYV() => WebReferenceInfo.rO8VocWBDvCI4avZAqMR == null;

    internal static WebReferenceInfo iYncahWBwGErhpFJDVnD() => WebReferenceInfo.rO8VocWBDvCI4avZAqMR;

    internal static void eUayTXWB4qAQs7uINWE9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
