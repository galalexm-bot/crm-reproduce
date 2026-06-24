// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.ExcelContentLoader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Aspose.Cells;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Memory;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Files
{
  /// <summary>Извлекатель текста из документов Excel.</summary>
  [Component(Order = 30)]
  public class ExcelContentLoader : BaseFileContentLoader
  {
    internal static ExcelContentLoader Q33vDeGTvNIRjW0JVbrY;

    /// <summary>Расширения файлов</summary>
    public override List<string> Extensions => new List<string>()
    {
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909226975),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787403345)
    };

    /// <summary>Получение текстового содержимого файла</summary>
    /// <param name="fileName">Имя файла</param>
    /// <returns>Текстовое содержимое файла</returns>
    public override string GetText(string fileName)
    {
      int num = 1;
      string fileName1;
      while (true)
      {
        switch (num)
        {
          case 1:
            Workbook workbook = new Workbook(fileName);
            string str1 = (string) ExcelContentLoader.epirHVGTu4lX6diI3ueP();
            fileName1 = (string) ExcelContentLoader.zGyYL2GTVZ4naATewAJP(ExcelContentLoader.xJwubGGTIeF54fPUc77S(1113862659 ^ 1114100399), (object) str1);
            HtmlSaveOptions htmlSaveOptions1 = new HtmlSaveOptions(SaveFormat.Html);
            ExcelContentLoader.yG4L8tGTSLrxQZyYxeJ3((object) htmlSaveOptions1, true);
            string str2 = fileName1;
            HtmlSaveOptions htmlSaveOptions2 = htmlSaveOptions1;
            ExcelContentLoader.BJ8mqtGTixucdJDYTbkq((object) workbook, (object) str2, (object) htmlSaveOptions2);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return base.GetText(fileName1);
    }

    /// <summary>
    /// Получение текстового содержимого из потока. При завершении извлечения текста поток будет закрыт и уничтожен.
    /// </summary>
    /// <param name="stream">Поток с неким контентом.</param>
    /// <returns>Текстовое содержимое контента.</returns>
    public override string GetText(Stream stream)
    {
      int num1 = 1;
      Stream stream1;
      Workbook workbook;
      HtmlSaveOptions htmlSaveOptions;
      MemoryStream memoryStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            stream1 = stream;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_13;
          case 3:
            memoryStream = (MemoryStream) ExcelContentLoader.B7msGMGTRmXJLJUGpy95();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 2 : 5;
            continue;
          case 4:
label_14:
            htmlSaveOptions = new HtmlSaveOptions(SaveFormat.Html)
            {
              ExportActiveWorksheetOnly = true
            };
            num1 = 3;
            continue;
          case 5:
            goto label_16;
          default:
            try
            {
              workbook = new Workbook(stream);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_14;
              }
            }
            finally
            {
              int num3;
              if (stream1 == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 0;
              else
                goto label_10;
label_9:
              switch (num3)
              {
                case 2:
                  break;
                default:
              }
label_10:
              stream1.Dispose();
              num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
              {
                num3 = 0;
                goto label_9;
              }
              else
                goto label_9;
            }
        }
      }
label_13:
      string text;
      return text;
label_16:
      try
      {
        ExcelContentLoader.fR98RNGTqZRRiMLm7v18((object) workbook, (object) memoryStream, (object) htmlSaveOptions);
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              text = base.GetText((Stream) memoryStream);
              num4 = 2;
              continue;
            case 2:
              goto label_13;
            default:
              ExcelContentLoader.ymSK9SGTK3f9TLfGyZR9((object) memoryStream, 0L);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 1;
              continue;
          }
        }
      }
      finally
      {
        int num5;
        if (memoryStream == null)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 1;
        else
          goto label_24;
label_23:
        switch (num5)
        {
          case 1:
          case 2:
        }
label_24:
        ExcelContentLoader.fa83HoGTXenB4sHKAtYa((object) memoryStream);
        num5 = 2;
        goto label_23;
      }
    }

    public ExcelContentLoader()
    {
      ExcelContentLoader.KaosrSGTTI2LUsdBhUc9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object epirHVGTu4lX6diI3ueP() => (object) IOExtensions.GetTempFileName();

    internal static object xJwubGGTIeF54fPUc77S(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object zGyYL2GTVZ4naATewAJP([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void yG4L8tGTSLrxQZyYxeJ3([In] object obj0, [In] bool obj1) => ((HtmlSaveOptions) obj0).ExportActiveWorksheetOnly = obj1;

    internal static void BJ8mqtGTixucdJDYTbkq([In] object obj0, [In] object obj1, [In] object obj2) => ((Workbook) obj0).Save((string) obj1, (SaveOptions) obj2);

    internal static bool OkjDTOGT8ccIRnKuVPVB() => ExcelContentLoader.Q33vDeGTvNIRjW0JVbrY == null;

    internal static ExcelContentLoader a4cGftGTZdISHw2wIbaq() => ExcelContentLoader.Q33vDeGTvNIRjW0JVbrY;

    internal static object B7msGMGTRmXJLJUGpy95() => (object) MemoryHelper.GetMemoryStream();

    internal static void fR98RNGTqZRRiMLm7v18([In] object obj0, [In] object obj1, [In] object obj2) => ((Workbook) obj0).Save((Stream) obj1, (SaveOptions) obj2);

    internal static void ymSK9SGTK3f9TLfGyZR9([In] object obj0, [In] long obj1) => ((Stream) obj0).Position = obj1;

    internal static void fa83HoGTXenB4sHKAtYa([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void KaosrSGTTI2LUsdBhUc9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
