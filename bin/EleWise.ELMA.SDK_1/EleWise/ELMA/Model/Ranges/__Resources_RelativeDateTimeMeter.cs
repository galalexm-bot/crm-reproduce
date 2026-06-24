// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Ranges.__Resources_RelativeDateTimeMeter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Helpers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Ranges
{
  internal class __Resources_RelativeDateTimeMeter
  {
    internal static __Resources_RelativeDateTimeMeter BwvQVcWzqxoGqPhwKVV8;

    public static string DisplayName => (string) __Resources_RelativeDateTimeMeter.WcQPmOWzTcPa13aPGHNi((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70186104));

    public static string P_Hour_DisplayName => (string) __Resources_RelativeDateTimeMeter.epfABoWzkPdKQieHmvOl();

    public static string P_Day_DisplayName => RelativeDateTimeParser.Day;

    public static string P_Week_DisplayName => (string) __Resources_RelativeDateTimeMeter.yWxnydWznlgg9cqIEDHw();

    public static string P_Month_DisplayName => (string) __Resources_RelativeDateTimeMeter.V8FciyWzOCXBSJCkZtuK();

    public static string P_Year_DisplayName => (string) __Resources_RelativeDateTimeMeter.sBWSVXWz2mQSFyQFB15l();

    public __Resources_RelativeDateTimeMeter()
    {
      __Resources_RelativeDateTimeMeter.xMOaucWzeBfPu5lSRCL7();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object WcQPmOWzTcPa13aPGHNi([In] object obj0) => (object) SR.T((string) obj0);

    internal static bool J44PFIWzKYGkMXwOktEl() => __Resources_RelativeDateTimeMeter.BwvQVcWzqxoGqPhwKVV8 == null;

    internal static __Resources_RelativeDateTimeMeter l4iDCjWzXRvN1X042kry() => __Resources_RelativeDateTimeMeter.BwvQVcWzqxoGqPhwKVV8;

    internal static object epfABoWzkPdKQieHmvOl() => (object) RelativeDateTimeParser.Hour;

    internal static object yWxnydWznlgg9cqIEDHw() => (object) RelativeDateTimeParser.Week;

    internal static object V8FciyWzOCXBSJCkZtuK() => (object) RelativeDateTimeParser.Month;

    internal static object sBWSVXWz2mQSFyQFB15l() => (object) RelativeDateTimeParser.Year;

    internal static void xMOaucWzeBfPu5lSRCL7() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
