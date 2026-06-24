// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.IConfigurationImportFactory
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Import;

namespace EleWise.ELMA.Deploy
{
  /// <summary>
  /// Сервис-фабрика объектов для проверки и импорта конфигураций
  /// </summary>
  public interface IConfigurationImportFactory
  {
    /// <summary>Создать объект для проверки конфигурации</summary>
    /// <param name="importSettings">Настройки импорта</param>
    IConfigurationTester CreateTester(IImportSettings importSettings);

    /// <summary>Создать объект для импорта конфигурации</summary>
    /// <param name="importSettings">Настройки импорта</param>
    IConfigurationImporter CreateImporter(IImportSettings importSettings);
  }
}
