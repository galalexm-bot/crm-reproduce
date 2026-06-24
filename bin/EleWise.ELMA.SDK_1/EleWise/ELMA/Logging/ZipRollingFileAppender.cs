// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Logging.ZipRollingFileAppender
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Zip.Compression;
using j3AmrhgkCleVTGdEwA;
using log4net.Appender;
using log4net.Core;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Logging
{
  /// <summary>
  /// Appender that rolls and zip log files based on size or date or both.
  /// </summary>
  public class ZipRollingFileAppender : RollingFileAppender
  {
    private static readonly Type declaringType;
    internal static ZipRollingFileAppender gxp2sihJVEVyLopppoUM;

    /// <inheritdoc />
    public override bool StaticLogFileName
    {
      get => false;
      set
      {
      }
    }

    /// <inheritdoc />
    protected override void RollOverIfDateBoundaryCrossing(string lastFile, DateTime lastDate)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            base.RollOverIfDateBoundaryCrossing(lastFile, lastDate);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_12;
          case 3:
            goto label_2;
          case 4:
            if (!lastDate.ToString(this.DatePattern, (IFormatProvider) ZipRollingFileAppender.aFZ1NlhJRE71ZGAqpkWD()).Equals(this.m_now.ToString(this.DatePattern, (IFormatProvider) ZipRollingFileAppender.aFZ1NlhJRE71ZGAqpkWD())))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 3 : 7;
              continue;
            }
            goto label_3;
          case 5:
            if (lastFile == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 1 : 2;
              continue;
            }
            goto case 4;
          case 6:
            goto label_13;
          case 7:
            this.ZipFiles(lastFile);
            num = 6;
            continue;
          default:
            if (!this.m_rollDate)
            {
              num = 3;
              continue;
            }
            goto case 5;
        }
      }
label_12:
      return;
label_2:
      return;
label_13:
      return;
label_3:;
    }

    /// <inheritdoc />
    protected override void RollOverTime(bool fileIsOpen)
    {
      int num1 = 1;
      IDisposable disposable;
      ZipRollingFileAppender rollingFileAppender;
      string fileName;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
            continue;
          case 2:
            base.RollOverTime(fileIsOpen);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 4 : 1;
            continue;
          case 3:
            fileName = this.m_scheduledFilename;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 2 : 0;
            continue;
          case 4:
            disposable = ((SecurityContext) ZipRollingFileAppender.S8RmoThJqnbIRQtnGCWI((object) this)).Impersonate((object) this);
            num1 = 6;
            continue;
          case 5:
            goto label_25;
          case 6:
            goto label_6;
          default:
            rollingFileAppender = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 3 : 3;
            continue;
        }
      }
label_25:
      return;
label_6:
      try
      {
        int num2;
        if (!ZipRollingFileAppender.dme6tjhJKHXXSUogwWRn((object) fileName))
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 2 : 1;
        else
          goto label_15;
label_8:
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!ZipRollingFileAppender.yTg5eshJX4BGrjIxi0Dg((object) this))
              {
                num2 = 6;
                continue;
              }
              goto label_10;
            case 2:
              goto label_20;
            case 3:
            case 4:
              goto label_10;
            case 5:
              if (num3 < 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 3 : 4;
                continue;
              }
              goto case 8;
            case 6:
              num3 = ZipRollingFileAppender.utqGjehJkyd6GjqT9MFy((object) fileName, ZipRollingFileAppender.AjJO3QhJTsei4EMFym7D(-1334993905 ^ -1334999349));
              num2 = 5;
              continue;
            case 7:
              goto label_19;
            case 8:
              fileName = (string) ZipRollingFileAppender.V7OOlVhJnlkeCIT3or4O((object) fileName, 0, num3);
              num2 = 3;
              continue;
            default:
              goto label_15;
          }
        }
label_20:
        return;
label_19:
        return;
label_10:
        ZipRollingFileAppender.KAujiNhJO8FDvMaj3LTN((object) (System.Action) (() =>
        {
          int num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 0:
                goto label_2;
              case 1:
                rollingFileAppender.ZipFiles(fileName);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        num2 = 7;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
        {
          num2 = 2;
          goto label_8;
        }
        else
          goto label_8;
label_15:
        if (this.CountDirection >= 0)
        {
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 1;
          goto label_8;
        }
        else
          goto label_10;
      }
      finally
      {
        if (disposable != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_27;
              default:
                ZipRollingFileAppender.l5R0cIhJ2OlQ2bD8SZSS((object) disposable);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_27:;
      }
    }

    private void ZipFiles(string baseFileName)
    {
      int num1 = 2;
      IDisposable disposable;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_31;
          case 1:
            goto label_2;
          case 2:
            disposable = ((SecurityContext) ZipRollingFileAppender.S8RmoThJqnbIRQtnGCWI((object) this)).Impersonate((object) this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 1;
            continue;
          default:
            goto label_25;
        }
      }
label_31:
      return;
label_25:
      return;
label_2:
      try
      {
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
          num2 = 0;
        List<string>.Enumerator enumerator;
        List<string> filesToRemove;
        while (true)
        {
          switch (num2)
          {
            case 1:
              filesToRemove = new List<string>();
              num2 = 3;
              continue;
            case 2:
              goto label_8;
            case 3:
              FastZip fastZip = new FastZip(new FastZipEvents()
              {
                ProcessFile = (ProcessFileHandler) ((s, a) =>
                {
                  int num3 = 3;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        goto label_2;
                      case 2:
                        // ISSUE: reference to a compiler-generated method
                        if (ZipRollingFileAppender.\u003C\u003Ec__DisplayClass6_0.XapsK2v6sFRt9IhVW4Xp((object) a))
                        {
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
                          continue;
                        }
                        goto label_7;
                      case 3:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        ZipRollingFileAppender.\u003C\u003Ec__DisplayClass6_0.Y6DvsSv6U1ft8Z2shSFr((object) a, !ZipRollingFileAppender.\u003C\u003Ec__DisplayClass6_0.BYKSQav6LU7a8j9YZNSk(ZipRollingFileAppender.\u003C\u003Ec__DisplayClass6_0.dSxr9uv6Y7UnLmkqnIGx(ZipRollingFileAppender.\u003C\u003Ec__DisplayClass6_0.jqSYRav6j7NPZH3MvjNu((object) a)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099694537), StringComparison.OrdinalIgnoreCase));
                        num3 = 2;
                        continue;
                      default:
                        // ISSUE: reference to a compiler-generated method
                        filesToRemove.Add((string) ZipRollingFileAppender.\u003C\u003Ec__DisplayClass6_0.jqSYRav6j7NPZH3MvjNu((object) a));
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 1 : 1;
                        continue;
                    }
                  }
label_2:
                  return;
label_7:;
                })
              });
              ZipRollingFileAppender.pkecTGhJewCl3Jbsydpt((object) fastZip, Deflater.CompressionLevel.BEST_COMPRESSION);
              fastZip.CreateZip((string) ZipRollingFileAppender.ikhRpvhJP9a6sinW0Q8T((object) baseFileName, ZipRollingFileAppender.AjJO3QhJTsei4EMFym7D(236071375 ^ 236145327)), (string) ZipRollingFileAppender.U3F2tjhJ1ucawpUHRP05((object) baseFileName), false, (string) ZipRollingFileAppender.ikhRpvhJP9a6sinW0Q8T(ZipRollingFileAppender.MraEEQhJNLqMkOOJuc7q((object) baseFileName), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824297165)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
              continue;
            default:
              enumerator = filesToRemove.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 2 : 0;
              continue;
          }
        }
label_8:
        try
        {
label_19:
          if (enumerator.MoveNext())
            goto label_10;
          else
            goto label_20;
label_9:
          string current;
          int num4;
          switch (num4)
          {
            case 1:
              return;
            case 2:
              break;
            case 3:
              goto label_19;
            default:
              try
              {
                ZipRollingFileAppender.MNKHOvhJ3GAYbnuM12mF((object) current);
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
                  num5 = 0;
                switch (num5)
                {
                  default:
                    goto label_19;
                }
              }
              catch (IOException ex)
              {
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                    goto label_19;
                }
              }
          }
label_10:
          current = enumerator.Current;
          num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
          {
            num4 = 0;
            goto label_9;
          }
          else
            goto label_9;
label_20:
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 0;
          goto label_9;
        }
        finally
        {
          enumerator.Dispose();
          int num7 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
            num7 = 0;
          switch (num7)
          {
            default:
          }
        }
      }
      finally
      {
        if (disposable != null)
        {
          int num8 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
            num8 = 0;
          while (true)
          {
            switch (num8)
            {
              case 1:
                ZipRollingFileAppender.l5R0cIhJ2OlQ2bD8SZSS((object) disposable);
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
                continue;
              default:
                goto label_33;
            }
          }
        }
label_33:;
      }
    }

    public ZipRollingFileAppender()
    {
      ZipRollingFileAppender.LoYtXVhJpso3spFxkXrq();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ZipRollingFileAppender()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            // ISSUE: type reference
            ZipRollingFileAppender.declaringType = ZipRollingFileAppender.hA5jc6hJaKPOO10fDvhD(__typeref (ZipRollingFileAppender));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static object aFZ1NlhJRE71ZGAqpkWD() => (object) DateTimeFormatInfo.InvariantInfo;

    internal static bool DhMxq6hJSIhbsuAvK7lh() => ZipRollingFileAppender.gxp2sihJVEVyLopppoUM == null;

    internal static ZipRollingFileAppender jQOUtBhJiw5GkZ3oOSco() => ZipRollingFileAppender.gxp2sihJVEVyLopppoUM;

    internal static object S8RmoThJqnbIRQtnGCWI([In] object obj0) => (object) ((FileAppender) obj0).SecurityContext;

    internal static bool dme6tjhJKHXXSUogwWRn([In] object obj0) => System.IO.File.Exists((string) obj0);

    internal static bool yTg5eshJX4BGrjIxi0Dg([In] object obj0) => ((RollingFileAppender) obj0).StaticLogFileName;

    internal static object AjJO3QhJTsei4EMFym7D(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static int utqGjehJkyd6GjqT9MFy([In] object obj0, [In] object obj1) => ((string) obj0).LastIndexOf((string) obj1);

    internal static object V7OOlVhJnlkeCIT3or4O([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static object KAujiNhJO8FDvMaj3LTN([In] object obj0) => (object) Task.Run((System.Action) obj0);

    internal static void l5R0cIhJ2OlQ2bD8SZSS([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void pkecTGhJewCl3Jbsydpt([In] object obj0, [In] Deflater.CompressionLevel obj1) => ((FastZip) obj0).CompressionLevel = obj1;

    internal static object ikhRpvhJP9a6sinW0Q8T([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object U3F2tjhJ1ucawpUHRP05([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static object MraEEQhJNLqMkOOJuc7q([In] object obj0) => (object) Path.GetFileName((string) obj0);

    internal static void MNKHOvhJ3GAYbnuM12mF([In] object obj0) => System.IO.File.Delete((string) obj0);

    internal static void LoYtXVhJpso3spFxkXrq() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type hA5jc6hJaKPOO10fDvhD([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    private struct LogFileInfo
    {
      public string FileName;
      public DateTime FileTime;
    }
  }
}
