// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Impl.FileCleaner
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Scheduling;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services.Impl
{
  [Component]
  internal class FileCleaner : ISweepHandler
  {
    internal static TimeSpan cacheDuration;
    private DateTime lastRun;
    private static string _cacheFilesDirectory;
    private static ILogger logger;
    internal static FileCleaner PnnQReBMT2GDJbK1U3u6;

    public void Execute()
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!FileCleaner.SybmiMBMpUSDy4wfupZM((object) str, (object) FileCleaner._cacheFilesDirectory, StringComparison.InvariantCultureIgnoreCase))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_5;
            case 3:
            case 4:
              str = (string) FileCleaner.lOxUhmBM3w8du4EhGLb8();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 1;
              continue;
            case 5:
              goto label_15;
            case 6:
              goto label_16;
            case 7:
              goto label_7;
            case 8:
              if (FileCleaner.j1GMNYBM1nAupSYKgZSo((object) FileCleaner._cacheFilesDirectory))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 3 : 3;
                continue;
              }
              goto case 9;
            case 9:
              FileCleaner.rcafMWBMNX8cRuu57ODT((object) FileCleaner._cacheFilesDirectory);
              num2 = 4;
              continue;
            default:
              FileCleaner.rcafMWBMNX8cRuu57ODT((object) str);
              num2 = 5;
              continue;
          }
        }
label_7:
        if (!FileCleaner.B7NbeeBMPwqMYc1WLSPW(FileCleaner.M8U2iWBM2SBAeF1KRn75(FileCleaner.MBqAjyBMOrWgBgse2xet(), this.lastRun), FileCleaner.WJL80uBMexEmAi26IByZ(1.0)))
        {
          num1 = 6;
          continue;
        }
        goto label_3;
label_16:
        this.lastRun = DateTime.Now;
        num1 = 8;
      }
label_5:
      return;
label_15:
      return;
label_3:
      return;
label_4:;
    }

    internal static void SetCacheFilesDirectory(string dir) => FileCleaner._cacheFilesDirectory = dir;

    internal static void CleanFiles(string cacheDir)
    {
      int num1 = 13;
      while (true)
      {
        int num2 = num1;
        FileInfo fileInfo;
        DateTime dateTime1;
        string fileName;
        string[] files;
        int index;
        string path2;
        while (true)
        {
          switch (num2)
          {
            case 2:
              try
              {
                DateTime dateTime2 = FileCleaner.wwsq9NBMtJHyX7FBIGIJ((object) fileInfo);
                int num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
                  num3 = 3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      FileCleaner.EYqoR7BM48OvC0J5F2sF((object) fileInfo);
                      num3 = 2;
                      continue;
                    case 2:
                      goto label_32;
                    case 3:
                      if (FileCleaner.M8U2iWBM2SBAeF1KRn75(dateTime1, dateTime2) > FileCleaner.cacheDuration)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_32;
                    default:
                      FileCleaner.Logger.InfoFormat((string) FileCleaner.tZCvJKBMwd8BQTmxj6Ke(-882126494 ^ -882198384), (object) fileName, (object) dateTime2);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 1;
                      continue;
                  }
                }
              }
              catch (Exception ex)
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_32;
                    default:
                      FileCleaner.Logger.Warn((object) ex);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 0;
                      continue;
                  }
                }
              }
            case 3:
              files = Directory.GetFiles(cacheDir);
              num2 = 7;
              continue;
            case 4:
label_32:
              ++index;
              num2 = 9;
              continue;
            case 5:
              goto label_27;
            case 6:
              dateTime1 = FileCleaner.MBqAjyBMOrWgBgse2xet();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 3 : 0;
              continue;
            case 7:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 15;
              continue;
            case 8:
              goto label_20;
            case 9:
            case 15:
              if (index < files.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 1 : 0;
                continue;
              }
              goto label_17;
            case 10:
              fileName = Path.Combine(cacheDir, path2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 14;
              continue;
            case 11:
              if (!FileCleaner.HfRr24BMD9JdGPpQH1as((object) fileInfo))
                goto case 4;
              else
                goto label_19;
            case 12:
              goto label_26;
            case 13:
              if (!FileCleaner.j1GMNYBM1nAupSYKgZSo((object) cacheDir))
              {
                if (FileCleaner.YNFMPOBMaUwgoifg7J0S((object) cacheDir))
                {
                  num2 = 6;
                  continue;
                }
                goto label_23;
              }
              else
              {
                num2 = 12;
                continue;
              }
            case 14:
              fileInfo = new FileInfo(fileName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 4 : 11;
              continue;
            default:
              path2 = files[index];
              num2 = 10;
              continue;
          }
        }
label_19:
        num1 = 2;
      }
label_27:
      return;
label_20:
      return;
label_26:
      return;
label_17:
      return;
label_23:;
    }

    private static ILogger Logger
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              FileCleaner.logger = (ILogger) FileCleaner.q15QHlBM6LAslacZ5Wow(FileCleaner.tZCvJKBMwd8BQTmxj6Ke(1251470110 >> 2 ^ 312776975));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
              continue;
            case 2:
              if (FileCleaner.logger == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 1 : 1;
                continue;
              }
              goto label_3;
            default:
              goto label_3;
          }
        }
label_3:
        return FileCleaner.logger;
      }
    }

    public FileCleaner()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.lastRun = DateTime.MinValue;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static FileCleaner()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FileCleaner.cacheDuration = FileCleaner.VP1QScBMH2jcerpGFRqO(1.0);
            num = 3;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 1;
            continue;
          case 3:
            FileCleaner._cacheFilesDirectory = "";
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    internal static DateTime MBqAjyBMOrWgBgse2xet() => DateTime.Now;

    internal static TimeSpan M8U2iWBM2SBAeF1KRn75([In] DateTime obj0, [In] DateTime obj1) => obj0 - obj1;

    internal static TimeSpan WJL80uBMexEmAi26IByZ([In] double obj0) => TimeSpan.FromHours(obj0);

    internal static bool B7NbeeBMPwqMYc1WLSPW([In] TimeSpan obj0, [In] TimeSpan obj1) => obj0 < obj1;

    internal static bool j1GMNYBM1nAupSYKgZSo([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static void rcafMWBMNX8cRuu57ODT([In] object obj0) => FileCleaner.CleanFiles((string) obj0);

    internal static object lOxUhmBM3w8du4EhGLb8() => (object) IOExtensions.GetTempPath();

    internal static bool SybmiMBMpUSDy4wfupZM([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);

    internal static bool g4JqpQBMkZfGnMjxhtwu() => FileCleaner.PnnQReBMT2GDJbK1U3u6 == null;

    internal static FileCleaner YRPw1eBMnLrlhHoXTdmL() => FileCleaner.PnnQReBMT2GDJbK1U3u6;

    internal static bool YNFMPOBMaUwgoifg7J0S([In] object obj0) => Directory.Exists((string) obj0);

    internal static bool HfRr24BMD9JdGPpQH1as([In] object obj0) => ((FileSystemInfo) obj0).Exists;

    internal static DateTime wwsq9NBMtJHyX7FBIGIJ([In] object obj0) => ((FileSystemInfo) obj0).LastWriteTime;

    internal static object tZCvJKBMwd8BQTmxj6Ke(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void EYqoR7BM48OvC0J5F2sF([In] object obj0) => ((FileSystemInfo) obj0).Delete();

    internal static object q15QHlBM6LAslacZ5Wow([In] object obj0) => (object) EleWise.ELMA.Logging.Logger.GetLogger((string) obj0);

    internal static TimeSpan VP1QScBMH2jcerpGFRqO([In] double obj0) => TimeSpan.FromDays(obj0);
  }
}
