// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.AppRestartHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Hosting;

namespace EleWise.ELMA.Runtime
{
  /// <summary>Класс-помощник для перезапуска сервера ELMA</summary>
  public static class AppRestartHelper
  {
    private static AppRestartHelper u8hUnwWWm20l9WMv9TiY;

    /// <summary>Перезапустить сервер ELMA (рестарт пула)</summary>
    public static void RestartAppDomain()
    {
      int num1 = 4;
      while (true)
      {
        int num2;
        switch (num1)
        {
          case 1:
            goto label_10;
          case 2:
            num2 = AppRestartHelper.e2yxJ2WWlRClL8HLukFf() ? 1 : 0;
            break;
          case 3:
            if (!AppRestartHelper.BM3PU8WWdCHOtpe4m30O())
            {
              num1 = 2;
              continue;
            }
            num2 = 1;
            break;
          case 4:
            if (!AppRestartHelper.c1IU19WWJJlIOmMGISjX())
            {
              num1 = 3;
              continue;
            }
            goto case 6;
          case 5:
            goto label_2;
          case 6:
            AppRestartHelper.lcYslGWW93xYVYI8YHi1();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 1 : 1;
            continue;
          default:
            goto label_6;
        }
        if (num2 != 0)
          num1 = 5;
        else
          goto label_6;
      }
label_10:
      return;
label_2:
      return;
label_6:
      throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475826821), AppRestartHelper.XsbpcGWWryM4oC0JCwJJ(322893104 - -1992822529 ^ -1979283275), AppRestartHelper.XsbpcGWWryM4oC0JCwJJ(-477139494 ^ -477175440)));
    }

    private static bool IsFullTrust
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (AppDomain.CurrentDomain.IsHomogenous)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        return AppRestartHelper.plohSFWW510BGhglhgN2(AppRestartHelper.FFV88TWWgA2SS7uiuFPq());
label_3:
        return false;
      }
    }

    private static bool TryWriteWebConfig()
    {
      bool flag;
      switch (1)
      {
        case 1:
          try
          {
            AppRestartHelper.TQJHhdWWLktPywCSaxAF(AppRestartHelper.e9bmYsWWjuJgD20wOA2X(AppRestartHelper.XsbpcGWWryM4oC0JCwJJ(-740338220 ^ -740370050)), AppRestartHelper.ki8FxvWWYNioLYPp7RTX());
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_1;
                default:
                  flag = true;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 1;
                  continue;
              }
            }
          }
          catch
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_1;
                default:
                  flag = false;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 1;
                  continue;
              }
            }
          }
      }
label_1:
      return flag;
    }

    private static bool TryWriteBinFolder()
    {
      bool flag;
      switch (1)
      {
        case 1:
          try
          {
            object obj = AppRestartHelper.e9bmYsWWjuJgD20wOA2X(AppRestartHelper.XsbpcGWWryM4oC0JCwJJ(~-397266137 ^ 397164636));
            AppRestartHelper.gZDoZYWWUj778v7pmefM(obj);
            StreamWriter streamWriter = (StreamWriter) AppRestartHelper.gdP8RRWWc6BTH8rsRvlq(AppRestartHelper.QqS3Z5WWshs8bi1hWkiI(obj, AppRestartHelper.XsbpcGWWryM4oC0JCwJJ(-606654180 ^ -606683686)));
            int num1 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
              num1 = 2;
            while (true)
            {
              switch (num1)
              {
                case 1:
label_5:
                  flag = true;
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
                  continue;
                case 2:
                  try
                  {
                    AppRestartHelper.UVTb3XWWzYrchdrnKHN0((object) streamWriter, AppRestartHelper.XsbpcGWWryM4oC0JCwJJ(-1710575414 ^ -1710539756), (object) DateTime.UtcNow);
                    int num2 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
                      num2 = 0;
                    while (true)
                    {
                      switch (num2)
                      {
                        case 1:
                          goto label_5;
                        default:
                          streamWriter.Flush();
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 1;
                          continue;
                      }
                    }
                  }
                  finally
                  {
                    if (streamWriter != null)
                    {
                      int num3 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
                        num3 = 0;
                      while (true)
                      {
                        switch (num3)
                        {
                          case 1:
                            streamWriter.Dispose();
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_15;
                        }
                      }
                    }
label_15:;
                  }
                default:
                  goto label_1;
              }
            }
          }
          catch
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_1;
                default:
                  flag = false;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 1 : 0;
                  continue;
              }
            }
          }
      }
label_1:
      return flag;
    }

    internal static bool c1IU19WWJJlIOmMGISjX() => AppRestartHelper.IsFullTrust;

    internal static void lcYslGWW93xYVYI8YHi1() => HttpRuntime.UnloadAppDomain();

    internal static bool BM3PU8WWdCHOtpe4m30O() => AppRestartHelper.TryWriteBinFolder();

    internal static bool e2yxJ2WWlRClL8HLukFf() => AppRestartHelper.TryWriteWebConfig();

    internal static object XsbpcGWWryM4oC0JCwJJ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool xo4VbZWWyBKgfrHCfk2J() => AppRestartHelper.u8hUnwWWm20l9WMv9TiY == null;

    internal static AppRestartHelper pRCBejWWMlrQw1gP3BIj() => AppRestartHelper.u8hUnwWWm20l9WMv9TiY;

    internal static object FFV88TWWgA2SS7uiuFPq() => (object) AppDomain.CurrentDomain;

    internal static bool plohSFWW510BGhglhgN2([In] object obj0) => ((AppDomain) obj0).IsFullyTrusted;

    internal static object e9bmYsWWjuJgD20wOA2X([In] object obj0) => (object) HostingEnvironment.MapPath((string) obj0);

    internal static DateTime ki8FxvWWYNioLYPp7RTX() => DateTime.UtcNow;

    internal static void TQJHhdWWLktPywCSaxAF([In] object obj0, [In] DateTime obj1) => File.SetLastWriteTimeUtc((string) obj0, obj1);

    internal static object gZDoZYWWUj778v7pmefM([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static object QqS3Z5WWshs8bi1hWkiI([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object gdP8RRWWc6BTH8rsRvlq([In] object obj0) => (object) File.CreateText((string) obj0);

    internal static void UVTb3XWWzYrchdrnKHN0([In] object obj0, [In] object obj1, [In] object obj2) => ((TextWriter) obj0).WriteLine((string) obj1, obj2);
  }
}
