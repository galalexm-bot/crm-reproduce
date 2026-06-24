// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.GetContentOptions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Files
{
  /// <summary>
  /// Параметры для получения потока чтения контента BinaryFile.
  /// </summary>
  public class GetContentOptions
  {
    /// <summary>Парамерты по умолчанию.</summary>
    public static readonly GetContentOptions Default;
    /// <summary>
    /// Параметры для создания потока без поддержки позиционирования.
    /// </summary>
    public static readonly GetContentOptions NonSeekable;
    /// <summary>
    /// Параметры для создания потока без поддержки позиционирования и для асинхронных операций.
    /// </summary>
    public static readonly GetContentOptions NonSeekableForAsync;
    internal static GetContentOptions E3V9xrGXvaCt0cpga9Bc;

    /// <summary>Ctor</summary>
    public GetContentOptions()
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
            this.Seekable = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
            continue;
          case 2:
            this.ForAsync = false;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
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

    /// <summary>Необходим поток, поддерживающий позиционирование?</summary>
    public bool Seekable
    {
      get => this.\u003CSeekable\u003Ek__BackingField;
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
              this.\u003CSeekable\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
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

    static GetContentOptions()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            GetContentOptions.I5UIRUGXuaVGOkJvnTMC();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
            continue;
          case 2:
            GetContentOptions getContentOptions = new GetContentOptions();
            GetContentOptions.nqd3amGXIsEnZgAoSX6Z((object) getContentOptions, false);
            GetContentOptions.tCy62bGXVq2oYbyo3A9n((object) getContentOptions, true);
            GetContentOptions.NonSeekableForAsync = getContentOptions;
            num = 3;
            continue;
          case 3:
            goto label_2;
          case 4:
            GetContentOptions.NonSeekable = new GetContentOptions()
            {
              Seekable = false
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 2 : 2;
            continue;
          default:
            GetContentOptions.Default = new GetContentOptions();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 4 : 4;
            continue;
        }
      }
label_2:;
    }

    internal static bool otOBbHGX8VSj2DoiGqR8() => GetContentOptions.E3V9xrGXvaCt0cpga9Bc == null;

    internal static GetContentOptions c36PLuGXZDUGY6Mw8Cge() => GetContentOptions.E3V9xrGXvaCt0cpga9Bc;

    internal static void I5UIRUGXuaVGOkJvnTMC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void nqd3amGXIsEnZgAoSX6Z([In] object obj0, bool value) => ((GetContentOptions) obj0).Seekable = value;

    internal static void tCy62bGXVq2oYbyo3A9n([In] object obj0, bool value) => ((GetContentOptions) obj0).ForAsync = value;
  }
}
