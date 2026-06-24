// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.BinaryFileExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Files;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  /// <summary>Методы расширения для BinaryFile.</summary>
  public static class BinaryFileExtensions
  {
    internal static BinaryFileExtensions Ju6m2CGpakA0ftqVGwiB;

    /// <summary>
    /// Сохранить контент BinaryFile в указанный файл на локальной файловой системе.
    /// </summary>
    /// <param name="binaryFile">BinaryFile.</param>
    /// <param name="path">Путь к файлу.</param>
    public static void SaveToLocalPath(this BinaryFile binaryFile, string path)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            BinaryFileExtensions.sM4dVIGpws5LrwZArBiN((object) binaryFile.GetContent(GetContentOptions.NonSeekable), (object) new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Сохранить контент BinaryFile во временный файл на локальной файловой системе.
    /// </summary>
    /// <param name="binaryFile">BinaryFile.</param>
    /// <returns>Путь к временному файлу.</returns>
    public static string SaveToLocalTempPath(this BinaryFile binaryFile)
    {
      int num = 1;
      string path;
      while (true)
      {
        switch (num)
        {
          case 1:
            path = (string) BinaryFileExtensions.x0ebneGp4nGmbWmbGO5J((object) binaryFile.Extension);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            binaryFile.SaveToLocalPath(path);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 2 : 2;
            continue;
        }
      }
label_4:
      return path;
    }

    /// <summary>Преобразовать содержимое файла к массиву байт</summary>
    /// <param name="binaryFile">Файл</param>
    public static byte[] ToByteArray(this BinaryFile binaryFile)
    {
      int num1 = 1;
      Stream content;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (binaryFile != null)
            {
              content = binaryFile.GetContent();
              num1 = 3;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            goto label_5;
          default:
            goto label_3;
        }
      }
label_2:
      byte[] byteArray;
      return byteArray;
label_3:
      return (byte[]) null;
label_5:
      try
      {
        byteArray = content.ReadAllBytes();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_2;
        }
      }
      finally
      {
        int num3;
        if (content == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 1;
        else
          goto label_11;
label_10:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_11:
        BinaryFileExtensions.lrtbdDGp6gSYBvHNaYv9((object) content);
        num3 = 2;
        goto label_10;
      }
    }

    internal static void sM4dVIGpws5LrwZArBiN([In] object obj0, [In] object obj1) => ((Stream) obj0).CopyAllBytesToStream((Stream) obj1);

    internal static bool O2SZ8BGpD2sqoTEhO5Gy() => BinaryFileExtensions.Ju6m2CGpakA0ftqVGwiB == null;

    internal static BinaryFileExtensions ROf5uqGpt3lelb1nH29r() => BinaryFileExtensions.Ju6m2CGpakA0ftqVGwiB;

    internal static object x0ebneGp4nGmbWmbGO5J([In] object obj0) => (object) IOExtensions.GetTempFileName((string) obj0);

    internal static void lrtbdDGp6gSYBvHNaYv9([In] object obj0) => ((IDisposable) obj0).Dispose();
  }
}
