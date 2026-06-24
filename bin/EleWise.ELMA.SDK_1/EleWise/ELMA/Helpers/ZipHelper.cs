// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.ZipHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Memory;
using ICSharpCode.SharpZipLib.Zip;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Helpers
{
  /// <summary>Helper архивации/разархивации</summary>
  internal class ZipHelper
  {
    private static ZipHelper pFM3Gihj6KYBSCMfl97A;

    /// <summary>Архивировать папку</summary>
    /// <param name="sourceDirectory">Путь к папке</param>
    /// <param name="fileFilter">Фильтр файлов</param>
    /// <returns>Массив байт zip архива</returns>
    internal static byte[] CreateZipByteArrayFromFolder(string sourceDirectory, string fileFilter = null)
    {
      int num1 = 7;
      FastZip fastZip;
      MemoryStream memoryStream;
      ZipEntryFactory entryFactory;
      while (true)
      {
        switch (num1)
        {
          case 1:
            ZipHelper.KJeYnhhjM8OhpdaIsWZW((object) fastZip, true);
            num1 = 9;
            continue;
          case 2:
            fastZip = new FastZip();
            num1 = 3;
            continue;
          case 3:
            entryFactory = fastZip.EntryFactory as ZipEntryFactory;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_3;
          case 5:
            ZipHelper.hPBrPVhjyfBEpQrHgohP((object) entryFactory, true);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
            continue;
          case 6:
            Contract.CheckArgument(ZipHelper.IoFwJfhjmFlJwRTXNcWx((object) sourceDirectory), (string) ZipHelper.vV1peXhjxh59s0eoVIi3(1461625753 ^ 1461701365));
            num1 = 2;
            continue;
          case 7:
            ZipHelper.P48QGFhj0lPDYJpVFJ6l(!ZipHelper.CEDCZyhj72tsTSlTk0ke((object) sourceDirectory), ZipHelper.vV1peXhjxh59s0eoVIi3(-1638402543 ^ -1638490327));
            num1 = 6;
            continue;
          case 8:
            goto label_2;
          case 9:
            memoryStream = MemoryHelper.GetMemoryStream();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 2 : 4;
            continue;
          default:
            if (entryFactory != null)
            {
              num1 = 5;
              continue;
            }
            goto case 1;
        }
      }
label_2:
      byte[] byteArrayFromFolder;
      return byteArrayFromFolder;
label_3:
      try
      {
        fastZip.CreateZip((Stream) ZipHelper.MqZkfUhjJoeS6Q9p49Kd((object) memoryStream), sourceDirectory, true, fileFilter, (string) null);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_2;
            default:
              byteArrayFromFolder = (byte[]) ZipHelper.QoGmYDhj9CoQiIu1MGHA((object) memoryStream);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 1 : 1;
              continue;
          }
        }
      }
      finally
      {
        if (memoryStream != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                ZipHelper.TJWol9hjdNM9sLdlpZeC((object) memoryStream);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
                continue;
              default:
                goto label_12;
            }
          }
        }
label_12:;
      }
    }

    /// <summary>Распаковать архив в папку</summary>
    /// <param name="content">Содержимое архива</param>
    /// <param name="destinationDirectory">Путь к папке, куда должны быть распакованы файлы</param>
    internal static void ExtractZipFolder(byte[] content, string destinationDirectory)
    {
      int num1 = 3;
      MemoryStream memoryStream;
      FastZip fastZip;
      while (true)
      {
        int num2;
        switch (num1)
        {
          case 1:
            ZipHelper.P48QGFhj0lPDYJpVFJ6l(ZipHelper.IoFwJfhjmFlJwRTXNcWx((object) destinationDirectory), ZipHelper.vV1peXhjxh59s0eoVIi3(-35995181 ^ -36084779));
            num1 = 4;
            continue;
          case 2:
            num2 = content.Length != 0 ? 1 : 0;
            break;
          case 3:
            if (content != null)
            {
              num1 = 2;
              continue;
            }
            num2 = 0;
            break;
          case 4:
            fastZip = new FastZip();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 5 : 4;
            continue;
          case 5:
            memoryStream = (MemoryStream) ZipHelper.AByf7yhjl1MuAoDeDHjC((object) content, false);
            num1 = 7;
            continue;
          case 6:
            goto label_17;
          case 7:
            goto label_7;
          default:
            ZipHelper.P48QGFhj0lPDYJpVFJ6l(!ZipHelper.CEDCZyhj72tsTSlTk0ke((object) destinationDirectory), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272386237));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 1;
            continue;
        }
        string str = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669543021);
        ZipHelper.P48QGFhj0lPDYJpVFJ6l(num2 != 0, (object) str);
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
      }
label_17:
      return;
label_7:
      try
      {
        fastZip.ExtractZip((Stream) ZipHelper.MqZkfUhjJoeS6Q9p49Kd((object) memoryStream), destinationDirectory, FastZip.Overwrite.Always, (FastZip.ConfirmOverwriteDelegate) null, (string) null, (string) null, false, false);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
      finally
      {
        int num4;
        if (memoryStream == null)
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 1 : 2;
        else
          goto label_15;
label_13:
        switch (num4)
        {
          case 1:
          case 2:
        }
label_15:
        memoryStream.Dispose();
        num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
        {
          num4 = 1;
          goto label_13;
        }
        else
          goto label_13;
      }
    }

    public ZipHelper()
    {
      ZipHelper.BIAMjihjrVWy4bPnjdGk();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool CEDCZyhj72tsTSlTk0ke([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object vV1peXhjxh59s0eoVIi3(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void P48QGFhj0lPDYJpVFJ6l(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static bool IoFwJfhjmFlJwRTXNcWx([In] object obj0) => Directory.Exists((string) obj0);

    internal static void hPBrPVhjyfBEpQrHgohP([In] object obj0, [In] bool obj1) => ((ZipEntryFactory) obj0).IsUnicodeText = obj1;

    internal static void KJeYnhhjM8OhpdaIsWZW([In] object obj0, [In] bool obj1) => ((FastZip) obj0).CreateEmptyDirectories = obj1;

    internal static object MqZkfUhjJoeS6Q9p49Kd([In] object obj0) => (object) ((MemoryStream) obj0).AsNoClose();

    internal static object QoGmYDhj9CoQiIu1MGHA([In] object obj0) => (object) ((MemoryStream) obj0).ToArray();

    internal static void TJWol9hjdNM9sLdlpZeC([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool JHHRuUhjHPRgSQCH6LAl() => ZipHelper.pFM3Gihj6KYBSCMfl97A == null;

    internal static ZipHelper Rk8FUkhjAEX35Tx4dvev() => ZipHelper.pFM3Gihj6KYBSCMfl97A;

    internal static object AByf7yhjl1MuAoDeDHjC([In] object obj0, bool writable) => (object) MemoryHelper.GetMemoryStream((byte[]) obj0, writable);

    internal static void BIAMjihjrVWy4bPnjdGk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
