// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Logging.DiagnosticsPatternConverter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Diagnostics;
using j3AmrhgkCleVTGdEwA;
using log4net.Util;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Logging
{
  /// <summary>Преобразователь шаблона диагностики</summary>
  internal class DiagnosticsPatternConverter : PatternConverter
  {
    internal static DiagnosticsPatternConverter wI8VadhJjcD1RC8ofsDt;

    /// <inheritdoc />
    protected override void Convert(TextWriter writer, object state)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        Guid? currentCallContextUid;
        long? currentCallId;
        while (true)
        {
          switch (num2)
          {
            case 1:
              currentCallContextUid = DiagnosticsManager.GetCurrentCallContextUid();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
              continue;
            case 2:
              if (currentCallId.HasValue)
              {
                num2 = 3;
                continue;
              }
              goto label_3;
            case 3:
              goto label_7;
            case 4:
              goto label_6;
            case 5:
              goto label_13;
            case 6:
              currentCallId = DiagnosticsManager.GetCurrentCallId();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 2 : 0;
              continue;
            case 7:
              writer.Write((string) DiagnosticsPatternConverter.beO6gNhJsvGRtXVIwPFd(DiagnosticsPatternConverter.VU92OthJUCSardiWIH3J(-1858887263 ^ -1859112205), (object) currentCallContextUid.Value, DiagnosticsPatternConverter.VU92OthJUCSardiWIH3J(864270449 << 6 ^ -521213272)));
              num2 = 6;
              continue;
            default:
              if (!currentCallContextUid.HasValue)
              {
                num2 = 4;
                continue;
              }
              goto case 7;
          }
        }
label_7:
        DiagnosticsPatternConverter.tW2A4qhJcjVBOp0KedsG((object) writer, DiagnosticsPatternConverter.beO6gNhJsvGRtXVIwPFd((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1114087797), (object) currentCallId.Value, DiagnosticsPatternConverter.VU92OthJUCSardiWIH3J(964881585 - -1459193222 ^ -1870887713)));
        num1 = 5;
      }
label_6:
      return;
label_13:
      return;
label_3:;
    }

    public DiagnosticsPatternConverter()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object VU92OthJUCSardiWIH3J(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object beO6gNhJsvGRtXVIwPFd([In] object obj0, [In] object obj1, [In] object obj2) => (object) (obj0.ToString() + obj1 + obj2);

    internal static void tW2A4qhJcjVBOp0KedsG([In] object obj0, [In] object obj1) => ((TextWriter) obj0).Write((string) obj1);

    internal static bool O506X3hJYRXiQSl1Wmg1() => DiagnosticsPatternConverter.wI8VadhJjcD1RC8ofsDt == null;

    internal static DiagnosticsPatternConverter Jo5CwZhJLkg7eWEcAkcf() => DiagnosticsPatternConverter.wI8VadhJjcD1RC8ofsDt;
  }
}
