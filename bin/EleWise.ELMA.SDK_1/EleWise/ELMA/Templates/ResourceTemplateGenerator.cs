// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Templates.ResourceTemplateGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;

namespace EleWise.ELMA.Templates
{
  /// <summary>
  /// Класс для генерации текста из шаблонов, расположенных в ресурсах сборки
  /// </summary>
  public static class ResourceTemplateGenerator
  {
    /// <summary>Сгенерировать файл из шаблона в файл</summary>
    /// <typeparam name="T">Тип, из сборки которого берутся ресурсы. Кроме того, к имени ресурса в начало добавляется его пространство имен</typeparam>
    /// <param name="resourceName">Имя ресурса</param>
    /// <param name="fileName">Имя файла, в который нужно сгенерировать шаблон</param>
    /// <param name="conversions">Преобразования с текстом шаблона</param>
    public static void GenerateTemplate<T>(
      string resourceName,
      string fileName,
      Func<string, string> conversions = null)
    {
      string directoryName = Path.GetDirectoryName(fileName);
      if (!Directory.Exists(directoryName))
        Directory.CreateDirectory(directoryName);
      using (FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
        ResourceTemplateGenerator.GenerateTemplate<T>(resourceName, (Stream) fileStream, conversions);
    }

    /// <summary>Сгенерировать файл из шаблона в поток</summary>
    /// <typeparam name="T">Тип, из сборки которого берутся ресурсы. Кроме того, к имени ресурса в начало добавляется его пространство имен</typeparam>
    /// <param name="resourceName">Имя ресурса</param>
    /// <param name="stream">Поток, в который нужно сгенерировать шаблон</param>
    /// <param name="conversions">Преобразования с текстом шаблона</param>
    public static void GenerateTemplate<T>(
      string resourceName,
      Stream stream,
      Func<string, string> conversions = null)
    {
      using (StreamWriter streamWriter = new StreamWriter(stream))
        streamWriter.Write(ResourceTemplateGenerator.GenerateTemplate<T>(resourceName, conversions));
    }

    /// <summary>Сгенерировать файл из шаблона в строку</summary>
    /// <typeparam name="T">Тип, из сборки которого берутся ресурсы. Кроме того, к имени ресурса в начало добавляется его пространство имен</typeparam>
    /// <param name="resourceName">Имя ресурса</param>
    /// <param name="conversions">Преобразования с текстом шаблона</param>
    /// <returns>Сгенерированный шаблон</returns>
    public static string GenerateTemplate<T>(string resourceName, Func<string, string> conversions = null)
    {
      using (Stream manifestResourceStream = typeof (T).Assembly.GetManifestResourceStream(typeof (T).Namespace + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146503193) + resourceName))
      {
        using (StreamReader streamReader = new StreamReader(manifestResourceStream))
        {
          string end = streamReader.ReadToEnd();
          return conversions != null ? conversions(end) : end;
        }
      }
    }
  }
}
