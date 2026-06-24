// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.GuiLocalizationUtility
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Globalization
{
  /// <summary>Вспомогательный класс для локализации контролов</summary>
  public static class GuiLocalizationUtility
  {
    public static string TemplateInCodeRes;
    internal static GuiLocalizationUtility fgtQM2Gfvfa3S2lyhq3g;

    static GuiLocalizationUtility()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            GuiLocalizationUtility.TemplateInCodeRes = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97865780);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            GuiLocalizationUtility.XLCyDpGfuDJDDiJtC3De(true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 3;
            continue;
        }
      }
label_2:;
    }

    public static bool CheckDesignMode { get; set; }

    public static bool DesignMode
    {
      get
      {
        int num1 = 2;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_5;
            case 2:
              if (GuiLocalizationUtility.pC14RyGfIvCNg2fPduLH())
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 1;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_4:
        return false;
label_5:
        object source = GuiLocalizationUtility.TyRIRRGfVUi9NSbkR3kl((object) new StackTrace());
        Func<StackFrame, bool> func = GuiLocalizationUtility.\u003C\u003Ec.\u003C\u003E9__6_0;
        Func<StackFrame, bool> predicate;
        if (func == null)
          GuiLocalizationUtility.\u003C\u003Ec.\u003C\u003E9__6_0 = predicate = (Func<StackFrame, bool>) (f =>
          {
            int num2 = 5;
            while (true)
            {
              switch (num2)
              {
                case 1:
                  if (!(GuiLocalizationUtility.\u003C\u003Ec.YpC1cjv5nlf919G3UVyG(GuiLocalizationUtility.\u003C\u003Ec.gGLMDfv5TTP1vIxtBb1e((object) f)) != (Type) null))
                  {
                    num2 = 3;
                    continue;
                  }
                  goto case 2;
                case 2:
                  if (GuiLocalizationUtility.\u003C\u003Ec.BoMEydv527srSXAjoCbV((object) GuiLocalizationUtility.\u003C\u003Ec.YpC1cjv5nlf919G3UVyG(GuiLocalizationUtility.\u003C\u003Ec.gGLMDfv5TTP1vIxtBb1e((object) f)).FullName, GuiLocalizationUtility.\u003C\u003Ec.w30GO5v5OymHXEV8PkB7(-1837662597 ^ -1837979177)))
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
                    continue;
                  }
                  goto label_5;
                case 3:
                case 4:
                  goto label_5;
                case 5:
                  if (!GuiLocalizationUtility.\u003C\u003Ec.UUIApRv5kqSYC7BIbSga(GuiLocalizationUtility.\u003C\u003Ec.gGLMDfv5TTP1vIxtBb1e((object) f), (object) null))
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 4 : 2;
                    continue;
                  }
                  goto case 1;
                default:
                  goto label_4;
              }
            }
label_4:
            return GuiLocalizationUtility.\u003C\u003Ec.BoMEydv527srSXAjoCbV(GuiLocalizationUtility.\u003C\u003Ec.hFgWdGv5exKLMuVXBWYx((object) f.GetMethod()), GuiLocalizationUtility.\u003C\u003Ec.w30GO5v5OymHXEV8PkB7(-420743386 ^ -420597920));
label_5:
            return false;
          });
        else
          goto label_6;
label_8:
        return ((IEnumerable<StackFrame>) source).Count<StackFrame>(predicate) > 0;
label_6:
        predicate = func;
        goto label_8;
      }
    }

    public static string GetString(string resourcesString)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (GuiLocalizationUtility.O8gfP3GfSxWqZG2sOx3n())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      ResourceString resourceString = new ResourceString();
      GuiLocalizationUtility.tBS54nGfi2U9IufP8AwN((object) resourceString, (object) resourcesString);
      return (string) GuiLocalizationUtility.VpHNfSGfRIFuonu8q16R((object) resourceString);
label_5:
      return string.Format((string) GuiLocalizationUtility.phbgp5Gfq8JxJxRomWIe(864270449 << 6 ^ -521296912), (object) resourcesString);
    }

    internal static void XLCyDpGfuDJDDiJtC3De(bool value) => GuiLocalizationUtility.CheckDesignMode = value;

    internal static bool x43LgCGf8ejhcdUeD8rk() => GuiLocalizationUtility.fgtQM2Gfvfa3S2lyhq3g == null;

    internal static GuiLocalizationUtility BwjqE5GfZelm8TdP9VgG() => GuiLocalizationUtility.fgtQM2Gfvfa3S2lyhq3g;

    internal static bool pC14RyGfIvCNg2fPduLH() => GuiLocalizationUtility.CheckDesignMode;

    internal static object TyRIRRGfVUi9NSbkR3kl([In] object obj0) => (object) ((StackTrace) obj0).GetFrames();

    internal static bool O8gfP3GfSxWqZG2sOx3n() => GuiLocalizationUtility.DesignMode;

    internal static void tBS54nGfi2U9IufP8AwN([In] object obj0, [In] object obj1) => ((ResourceString) obj0).Parse((string) obj1);

    internal static object VpHNfSGfRIFuonu8q16R([In] object obj0) => (object) ((ResourceString) obj0).Value;

    internal static object phbgp5Gfq8JxJxRomWIe(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
