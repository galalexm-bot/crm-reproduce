// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.ICodeGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>Интерфейс генератора кода на основе метаданных</summary>
  public interface ICodeGenerator
  {
    /// <summary>Метаданные</summary>
    IMetadata Metadata { get; set; }

    /// <summary>Параметры генерации</summary>
    GenerationParams GenerationParams { get; set; }

    /// <summary>Сгенерировать основной файл (это должен быть CS файл)</summary>
    /// <returns>Массив содержимого файла</returns>
    GeneratedFileInfo GenerateMainFile();

    /// <summary>Сгенерировать файлы (основной и дополнительные)</summary>
    /// <returns>Массив с информацией о сгенерированных файлах</returns>
    GeneratedFileInfo[] Generate();

    /// <summary>Сгенерировать дополнительные файлы</summary>
    /// <returns>Массив с информацией о сгенерированных файлах</returns>
    GeneratedFileInfo[] GenerateAdditionalFiles();
  }
}
