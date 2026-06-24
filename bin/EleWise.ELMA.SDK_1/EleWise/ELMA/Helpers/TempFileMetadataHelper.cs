// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.TempFileMetadataHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Helpers
{
  /// <summary>
  /// Помощник при работе с метаданными временных файлов для провайдера на локальной файловой системе.
  /// </summary>
  public static class TempFileMetadataHelper
  {
    private static TempFileMetadataHelper tYUkh0hYOAI28JJnu86G;

    /// <summary>Получить оригинальное имя файла из файла метаданных.</summary>
    /// <param name="metadataFilePath">Путь к файлу с метаданными.</param>
    /// <returns>Оригинальное имя файла.</returns>
    public static string GetFilename(string metadataFilePath) => (string) TempFileMetadataHelper.i2K2aehYNWJvPZsU0rQn((object) Encoding.UTF8, TempFileMetadataHelper.y5SGiIhY1daWojQ3jJ8X(TempFileMetadataHelper.YHi3D4hYP0M1HVLikr5H((object) metadataFilePath)));

    /// <summary>Сохранить оригинальное имя файла в файл метаданных.</summary>
    /// <param name="metadataFilePath">Путь к файлу с метаданными.</param>
    /// <param name="filename">Оригинальное имя файла.</param>
    public static void PutFilename(string metadataFilePath, string filename)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            TempFileMetadataHelper.kyds19hY3I2ZqNjF5qjR((object) metadataFilePath, (object) filename.ToBase64String());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static object YHi3D4hYP0M1HVLikr5H([In] object obj0) => (object) File.ReadAllText((string) obj0);

    internal static object y5SGiIhY1daWojQ3jJ8X([In] object obj0) => (object) Convert.FromBase64String((string) obj0);

    internal static object i2K2aehYNWJvPZsU0rQn([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetString((byte[]) obj1);

    internal static bool nFr2VnhY2AIXLvS2iiXW() => TempFileMetadataHelper.tYUkh0hYOAI28JJnu86G == null;

    internal static TempFileMetadataHelper QRwuxchYeAsXH8utm8VL() => TempFileMetadataHelper.tYUkh0hYOAI28JJnu86G;

    internal static void kyds19hY3I2ZqNjF5qjR([In] object obj0, [In] object obj1) => File.WriteAllText((string) obj0, (string) obj1);
  }
}
