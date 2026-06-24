// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ISystemImportSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Deploy.Import
{
  /// <summary>Настройки системного кастомного импорта</summary>
  internal interface ISystemImportSettings : IImportSettings
  {
    /// <summary>Текст файла экспорта конфигурации</summary>
    string FileText { get; set; }
  }
}
