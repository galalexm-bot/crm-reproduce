// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.FilePreviewArchiverService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Services;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>Архивирование превьюшек</summary>
  [Service]
  public class FilePreviewArchiverService : IFilePreviewArchiverService
  {
    /// <summary>Формирование архива одного за раз</summary>
    private object _lockObj;
    private object _lockDeleteObj;
    private static FilePreviewArchiverService NbGckhGehTZQZERdCHte;

    /// <summary>Получить путь до архива с превьюхой</summary>
    /// <param name="file">Файла</param>
    /// <returns></returns>
    public string GetArchive(BinaryFile file)
    {
      int num1 = 5;
      string archive;
      string str;
      object lockObj;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_7;
          case 2:
            lockObj = this._lockObj;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 1 : 7;
            continue;
          case 3:
            if (FilePreviewArchiverService.YqpgOHGevgEJjRdQryoW((object) archive))
            {
              num1 = 6;
              continue;
            }
            goto case 2;
          case 4:
            archive = (string) FilePreviewArchiverService.PsfAncGeCaZOfZuvvaOn((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837751535), (object) str);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 3 : 3;
            continue;
          case 5:
            str = (string) FilePreviewArchiverService.QjYhM7GeQkv9W6e04Iug((object) ((IFilePreviewCreator) FilePreviewArchiverService.daSLlpGefNS6KQ5Bx8mE((object) Locator.GetServiceNotNull<IFilePreviewService>(), (object) file)).GetMainFileName(file));
            num1 = 4;
            continue;
          case 7:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return archive;
label_7:
      try
      {
        Monitor.Enter(lockObj, ref lockTaken);
        int num2 = 4;
        ZipOutputStream zipOutputStream;
        int folderOffset;
        while (true)
        {
          switch (num2)
          {
            case 1:
              FilePreviewArchiverService.heLA7hGeIBVmlWfjFP2Z((object) str, (object) zipOutputStream, folderOffset);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 2 : 3;
              continue;
            case 2:
              folderOffset = str.Length + (!FilePreviewArchiverService.tPmr1IGeud0HDrThdNpi((object) str, FilePreviewArchiverService.YsAmMgGeZR9uhSslK8em(1819636893 << 3 ^ 1672199070)) ? 1 : 0);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 1 : 1;
              continue;
            case 3:
              FilePreviewArchiverService.U2JAaFGeVF0u91IV8iAo((object) zipOutputStream, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
              continue;
            case 4:
              zipOutputStream = new ZipOutputStream((Stream) FilePreviewArchiverService.lUE5xrGe8Lo4Z07MjIWH((object) archive));
              num2 = 2;
              continue;
            case 5:
              goto label_2;
            default:
              FilePreviewArchiverService.m8JcHQGeSkOdVEjQJ2wW((object) zipOutputStream);
              num2 = 5;
              continue;
          }
        }
      }
      finally
      {
        int num3;
        if (!lockTaken)
          num3 = 2;
        else
          goto label_17;
label_16:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_17:
        FilePreviewArchiverService.A77slPGeir14CcDZYNqA(lockObj);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
        {
          num3 = 0;
          goto label_16;
        }
        else
          goto label_16;
      }
    }

    /// <summary>Удалить архив с превьюхой</summary>
    /// <param name="file"></param>
    public void ClearArchive(BinaryFile file)
    {
      int num1 = 1;
      string str1;
      string str2;
      object lockDeleteObj;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 1:
            str2 = (string) FilePreviewArchiverService.QjYhM7GeQkv9W6e04Iug(FilePreviewArchiverService.JMIgJOGeRdrkHrvNlCUb((object) Locator.GetServiceNotNull<IFilePreviewService>().GetPreviewCreator(file), (object) file));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
            continue;
          case 2:
            lockTaken = false;
            num1 = 6;
            continue;
          case 3:
            goto label_25;
          case 4:
            goto label_20;
          case 5:
            lockDeleteObj = this._lockDeleteObj;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 2 : 0;
            continue;
          case 6:
            goto label_5;
          case 7:
            if (!FilePreviewArchiverService.YqpgOHGevgEJjRdQryoW((object) str1))
            {
              num1 = 3;
              continue;
            }
            goto case 5;
          default:
            str1 = string.Format((string) FilePreviewArchiverService.YsAmMgGeZR9uhSslK8em(--1867379187 ^ 1867295897), (object) str2);
            num1 = 7;
            continue;
        }
      }
label_25:
      return;
label_20:
      return;
label_5:
      try
      {
        Monitor.Enter(lockDeleteObj, ref lockTaken);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              FilePreviewArchiverService.okQakYGeqhpMS9r2B2cS((object) str1);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
                num3 = 0;
              switch (num3)
              {
                case 0:
                  return;
                default:
                  return;
              }
            }
            catch (Exception ex)
            {
              int num4 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
                num4 = 0;
              while (true)
              {
                switch (num4)
                {
                  case 0:
                    goto label_13;
                  case 1:
                    FilePreviewArchiverService.jfM7KDGeXdPfs0E3nwxN((object) Logger.Log, FilePreviewArchiverService.diQAaLGeKgZnAP9yYGvm((object) ex), (object) ex);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_8;
                }
              }
label_13:
              break;
label_8:
              break;
            }
        }
      }
      finally
      {
        if (lockTaken)
        {
          int num5 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                Monitor.Exit(lockDeleteObj);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
                continue;
              default:
                goto label_27;
            }
          }
        }
label_27:;
      }
    }

    public FilePreviewArchiverService()
    {
      FilePreviewArchiverService.o49836GeTAMJOKKbbIWa();
      this._lockObj = new object();
      this._lockDeleteObj = new object();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object daSLlpGefNS6KQ5Bx8mE([In] object obj0, [In] object obj1) => (object) ((IFilePreviewService) obj0).GetPreviewCreator((BinaryFile) obj1);

    internal static object QjYhM7GeQkv9W6e04Iug([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static object PsfAncGeCaZOfZuvvaOn([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static bool YqpgOHGevgEJjRdQryoW([In] object obj0) => File.Exists((string) obj0);

    internal static object lUE5xrGe8Lo4Z07MjIWH([In] object obj0) => (object) File.Create((string) obj0);

    internal static object YsAmMgGeZR9uhSslK8em(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool tPmr1IGeud0HDrThdNpi([In] object obj0, [In] object obj1) => ((string) obj0).EndsWith((string) obj1);

    internal static void heLA7hGeIBVmlWfjFP2Z([In] object obj0, [In] object obj1, int folderOffset) => FileUtils.CompressFolder((string) obj0, (ZipOutputStream) obj1, folderOffset);

    internal static void U2JAaFGeVF0u91IV8iAo([In] object obj0, [In] bool obj1) => ((DeflaterOutputStream) obj0).IsStreamOwner = obj1;

    internal static void m8JcHQGeSkOdVEjQJ2wW([In] object obj0) => ((Stream) obj0).Close();

    internal static void A77slPGeir14CcDZYNqA([In] object obj0) => Monitor.Exit(obj0);

    internal static bool yFVcM3GeGbjFBDa81A8e() => FilePreviewArchiverService.NbGckhGehTZQZERdCHte == null;

    internal static FilePreviewArchiverService WDBAt2GeE9inUt7yd0sa() => FilePreviewArchiverService.NbGckhGehTZQZERdCHte;

    internal static object JMIgJOGeRdrkHrvNlCUb([In] object obj0, [In] object obj1) => (object) ((IFilePreviewCreator) obj0).GetMainFileName((BinaryFile) obj1);

    internal static void okQakYGeqhpMS9r2B2cS([In] object obj0) => File.Delete((string) obj0);

    internal static object diQAaLGeKgZnAP9yYGvm([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static void jfM7KDGeXdPfs0E3nwxN([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void o49836GeTAMJOKKbbIWa() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
