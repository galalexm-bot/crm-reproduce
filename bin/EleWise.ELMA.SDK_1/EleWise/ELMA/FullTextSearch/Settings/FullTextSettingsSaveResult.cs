// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Settings.FullTextSettingsSaveResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.FullTextSearch.Settings
{
  /// <summary>Результат сохранения глобальных настроек</summary>
  [Serializable]
  public sealed class FullTextSettingsSaveResult
  {
    private static FullTextSettingsSaveResult edwTjJGQnNL1IxD5I04W;

    /// <summary>Выполнена ли операция сохранения успешно</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
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
    /// Сообщение об ошибке при сохранении.
    /// Если ошибок не было, должно быть <c>null</c>
    /// </summary>
    public string ErrorMessage
    {
      get => this.\u003CErrorMessage\u003Ek__BackingField;
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
              this.\u003CErrorMessage\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
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

    public FullTextSettingsSaveResult()
    {
      FullTextSettingsSaveResult.FvhxkDGQeHeyqnrsRkLF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool tIjOuGGQOA3ycOechyCn() => FullTextSettingsSaveResult.edwTjJGQnNL1IxD5I04W == null;

    internal static FullTextSettingsSaveResult sZ804nGQ25Ty9dhSujCc() => FullTextSettingsSaveResult.edwTjJGQnNL1IxD5I04W;

    internal static void FvhxkDGQeHeyqnrsRkLF() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
