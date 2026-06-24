// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.API.Models.PublicApplicationCompatibilityError
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.API.Models
{
  /// <summary>
  /// Результат совместимости какого-либо объекта системы со внешними приложениями (ошибка или предупреждение)
  /// </summary>
  public class PublicApplicationCompatibilityError : IPublicApplicationCompatibilityError
  {
    internal static PublicApplicationCompatibilityError qRmgYpf3GomUdSVXEGlb;

    public PublicApplicationCompatibilityError()
    {
      PublicApplicationCompatibilityError.hsCBtsf3QU2pUBJ1NHoQ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.IsError = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Сообщение</summary>
    public string Message
    {
      get => this.\u003CMessage\u003Ek__BackingField;
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
              this.\u003CMessage\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
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
    /// True, если это ошибка. False, если это предупреждение.
    /// </summary>
    public bool IsError
    {
      get => this.\u003CIsError\u003Ek__BackingField;
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
              this.\u003CIsError\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
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

    internal static void hsCBtsf3QU2pUBJ1NHoQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool KXoxIVf3EYO3qYDqgj9U() => PublicApplicationCompatibilityError.qRmgYpf3GomUdSVXEGlb == null;

    internal static PublicApplicationCompatibilityError mH6Rnaf3fUoE8IP5t5Xu() => PublicApplicationCompatibilityError.qRmgYpf3GomUdSVXEGlb;
  }
}
