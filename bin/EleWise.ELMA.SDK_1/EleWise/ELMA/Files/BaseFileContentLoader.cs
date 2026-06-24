// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.BaseFileContentLoader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Files
{
  /// <summary>Базовый класс для извлекателей текста из документов.</summary>
  public abstract class BaseFileContentLoader : IFileContentLoader, ITextContentExtractor
  {
    internal static BaseFileContentLoader B2f8Q2GTbrSuUb8siLbm;

    /// <summary>Расширения файлов</summary>
    public abstract List<string> Extensions { get; }

    /// <summary>Нужно ли чистить HTML после получения из файла</summary>
    public virtual bool NeedHtmlClear => true;

    /// <summary>Получение текстового содержимого файла</summary>
    /// <param name="fileName">Имя файла</param>
    /// <returns>Текстовое содержимое файла</returns>
    public virtual string GetText(string fileName) => (string) BaseFileContentLoader.esCWRJGTExrcF8OfcpRQ((object) fileName);

    /// <summary>
    /// Получение текстового содержимого из потока. При завершении извлечения текста поток будет закрыт и уничтожен.
    /// </summary>
    /// <param name="stream">Поток с неким контентом.</param>
    /// <returns>Текстовое содержимое контента.</returns>
    public virtual string GetText(Stream stream)
    {
      int num1 = 1;
      StreamReader streamReader1;
      StreamReader streamReader2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            streamReader1 = new StreamReader(stream, (Encoding) BaseFileContentLoader.OUusUFGTf2ux3ySHO9pr());
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_13;
          case 3:
            goto label_3;
          default:
            streamReader2 = streamReader1;
            num1 = 3;
            continue;
        }
      }
label_3:
      string text;
      try
      {
        text = (string) BaseFileContentLoader.rs9hNPGTQSLUfIOQYFdq((object) streamReader1);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        int num3;
        if (streamReader2 == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 1;
        else
          goto label_9;
label_8:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_9:
        BaseFileContentLoader.jLyCm2GTCqvuAaifBPx7((object) streamReader2);
        num3 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
        {
          num3 = 2;
          goto label_8;
        }
        else
          goto label_8;
      }
label_13:
      return text;
    }

    protected BaseFileContentLoader()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object esCWRJGTExrcF8OfcpRQ([In] object obj0) => (object) File.ReadAllText((string) obj0);

    internal static object OUusUFGTf2ux3ySHO9pr() => (object) Encoding.UTF8;

    internal static object rs9hNPGTQSLUfIOQYFdq([In] object obj0) => (object) ((TextReader) obj0).ReadToEnd();

    internal static void jLyCm2GTCqvuAaifBPx7([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool tFGgxhGThLTV56m2QuuJ() => BaseFileContentLoader.B2f8Q2GTbrSuUb8siLbm == null;

    internal static BaseFileContentLoader jX7GSBGTGfTTKtDvPKGx() => BaseFileContentLoader.B2f8Q2GTbrSuUb8siLbm;
  }
}
