// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.WordContentLoader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Aspose.Words;
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
  /// <summary>Извлекатель текста из документов Word.</summary>
  [Component(Order = 20)]
  public class WordContentLoader : BaseFileContentLoader
  {
    internal static WordContentLoader cb70R1GTe6gwWT9EXWya;

    /// <summary>Расширения файлов</summary>
    public override List<string> Extensions => new List<string>()
    {
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088386180),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917207098),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082448320)
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
            Document document = new Document(fileName);
            string str1 = (string) WordContentLoader.stcO0FGTNgVg6M5LytRY();
            fileName1 = string.Format((string) WordContentLoader.MDXiwGGT39KfntoAjaU8(2045296739 + 1688595713 ^ -561164856), (object) str1);
            string str2 = fileName1;
            WordContentLoader.gh2Rs1GTpCYqFkNtlgii((object) document, (object) str2, SaveFormat.Html);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return base.GetText(fileName1);
    }

    /// <summary>
    /// Получение текстового содержимого из потока. При завершении извлечения текста поток будет закрыт и уничтожен.
    /// </summary>
    /// <param name="stream">Поток с неким контентом.</param>
    /// <returns>Текстовое содержимое контента.</returns>
    public override string GetText(Stream stream)
    {
      int num1 = 2;
      Document document;
      MemoryStream memoryStream;
      Stream stream1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            try
            {
              document = new Document(stream);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_22;
              }
            }
            finally
            {
              int num3;
              if (stream1 == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
              else
                goto label_18;
label_17:
              switch (num3)
              {
                case 2:
                  break;
                default:
              }
label_18:
              WordContentLoader.mXMRlYGTaXtro4HLogJ2((object) stream1);
              num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
              {
                num3 = 1;
                goto label_17;
              }
              else
                goto label_17;
            }
          case 2:
            stream1 = stream;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          case 4:
label_22:
            memoryStream = MemoryHelper.GetMemoryStream();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 3;
            continue;
          default:
            goto label_21;
        }
      }
label_2:
      string text;
      try
      {
        WordContentLoader.gC80OtGTDiaZ1t0Rs68K((object) document, (object) memoryStream, SaveFormat.Html);
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              text = base.GetText((Stream) memoryStream);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 2 : 2;
              continue;
            case 2:
              goto label_21;
            default:
              WordContentLoader.cvTvTLGTt5LlqyKkPuxV((object) memoryStream, 0L);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 1;
              continue;
          }
        }
      }
      finally
      {
        int num5;
        if (memoryStream == null)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 1 : 1;
        else
          goto label_10;
label_9:
        switch (num5)
        {
          case 1:
          case 2:
        }
label_10:
        WordContentLoader.mXMRlYGTaXtro4HLogJ2((object) memoryStream);
        num5 = 2;
        goto label_9;
      }
label_21:
      return text;
    }

    public WordContentLoader()
    {
      WordContentLoader.qQw4n0GTw1M1pCn1ZiuO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object stcO0FGTNgVg6M5LytRY() => (object) IOExtensions.GetTempFileName();

    internal static object MDXiwGGT39KfntoAjaU8(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object gh2Rs1GTpCYqFkNtlgii([In] object obj0, [In] object obj1, [In] SaveFormat obj2) => (object) ((Document) obj0).Save((string) obj1, obj2);

    internal static bool u7pVBoGTP6QskggiflLQ() => WordContentLoader.cb70R1GTe6gwWT9EXWya == null;

    internal static WordContentLoader lJZIuJGT16JYbPQ7ljZD() => WordContentLoader.cb70R1GTe6gwWT9EXWya;

    internal static void mXMRlYGTaXtro4HLogJ2([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object gC80OtGTDiaZ1t0Rs68K([In] object obj0, [In] object obj1, [In] SaveFormat obj2) => (object) ((Document) obj0).Save((Stream) obj1, obj2);

    internal static void cvTvTLGTt5LlqyKkPuxV([In] object obj0, [In] long obj1) => ((Stream) obj0).Position = obj1;

    internal static void qQw4n0GTw1M1pCn1ZiuO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
