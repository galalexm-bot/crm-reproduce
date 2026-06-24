// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.PutContentOptions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Files
{
  /// <summary>
  /// Параметры для получения потока записи контента BinaryFile.
  /// </summary>
  public class PutContentOptions
  {
    /// <summary>Парамерты по умолчанию.</summary>
    public static readonly PutContentOptions Default;
    /// <summary>
    /// Параметры для создания потока для асинхронных операций.
    /// </summary>
    public static readonly PutContentOptions Async;
    internal static PutContentOptions SMxfT3GXSCPvZ5sxHcap;

    /// <summary>Ctor</summary>
    public PutContentOptions()
    {
      PutContentOptions.pEX0KtGXqQuIg2VAhWDG();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.ForAsync = false;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Поток необходим для совершения асинхронных операций?</summary>
    public bool ForAsync
    {
      get => this.\u003CForAsync\u003Ek__BackingField;
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
              this.\u003CForAsync\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
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
    /// Расширение файла с контентом. Может понадобиться для обеспечения совместимости.
    /// </summary>
    public string Extension
    {
      get => this.\u003CExtension\u003Ek__BackingField;
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
              this.\u003CExtension\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
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

    static PutContentOptions()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            PutContentOptions.pEX0KtGXqQuIg2VAhWDG();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            PutContentOptions putContentOptions = new PutContentOptions();
            PutContentOptions.qjVZPxGXKsUwb1KqUkdB((object) putContentOptions, true);
            PutContentOptions.Async = putContentOptions;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 2 : 1;
            continue;
          default:
            PutContentOptions.Default = new PutContentOptions();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 3;
            continue;
        }
      }
label_2:;
    }

    internal static void pEX0KtGXqQuIg2VAhWDG() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool GJR8cSGXig3HY8C9ypIL() => PutContentOptions.SMxfT3GXSCPvZ5sxHcap == null;

    internal static PutContentOptions tSR2kgGXRpt4TADnT8nN() => PutContentOptions.SMxfT3GXSCPvZ5sxHcap;

    internal static void qjVZPxGXKsUwb1KqUkdB([In] object obj0, bool value) => ((PutContentOptions) obj0).ForAsync = value;
  }
}
