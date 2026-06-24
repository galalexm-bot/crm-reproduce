// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.IConfigImportExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для импорта и проверки файла выгрузки конфигурации (или файла компонента ELMA Store)
  /// </summary>
  [ExtensionPoint(ComponentType.Server)]
  public interface IConfigImportExtension
  {
    /// <summary>После проверки файла</summary>
    /// <param name="parameters"></param>
    void OnPostCompleteTest(PostCompleteTestImportParameters parameters);

    /// <summary>Перед стартом импорта</summary>
    /// <param name="parameters"></param>
    void OnPreStartImport(PreStartImportParameters parameters);

    /// <summary>Перед чтением пакетов</summary>
    /// <param name="parameters"></param>
    void OnPreReadPackets(PreReadPacketsParameters parameters);

    /// <summary>После чтения пакетов</summary>
    /// <param name="parameters"></param>
    void OnPostReadPackets(PostReadPacketsParameters parameters);

    /// <summary>
    /// Выполнить необходимые действия после завершения импорта
    /// </summary>
    /// <param name="parameters"></param>
    void OnPostCompleteImport(PostCompleteImportParameters parameters);

    /// <summary>При удачном завершении импорта</summary>
    /// <param name="parameters">Параметры действия</param>
    void OnImportSuccessfull(ImportSuccessfullParameters parameters);
  }
}
