// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.IConfigImportActionExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для импорта и проверки файла выгрузки конфигурации перед тестированием
  /// </summary>
  [ExtensionPoint(ComponentType.Server)]
  public interface IConfigImportActionExtension
  {
    /// <summary>Перед проверкой файла</summary>
    /// <param name="parameters">Параметры</param>
    void OnPreStartTest(PreStartTestImportParameters parameters);

    /// <summary>Чтение менаданных</summary>
    /// <param name="parameters">Параметры</param>
    /// <param name="isTestRead">Тестовое чтение</param>
    /// <returns>Результат чтения метаданных</returns>
    /// <remarks>
    /// Как только один из компонентов вернет результат отличный от <see langword="null" />, дальнейшая обработка прекращается
    /// </remarks>
    IReadMetadataResult OnReadMetadata(ReadMetadataParameters parameters, bool isTestRead);

    /// <summary>Перед публикации объектов</summary>
    /// <param name="parameters">Параметры</param>
    void OnPrePublish(PrePublishParameters parameters);

    /// <summary>После публикации объектов</summary>
    /// <param name="parameters">Параметры</param>
    void OnPostPublish(PostPublishParameters parameters);
  }
}
