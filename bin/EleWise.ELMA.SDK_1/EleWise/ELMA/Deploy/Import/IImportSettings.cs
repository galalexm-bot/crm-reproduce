// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.IImportSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Import
{
  /// <summary>Базовый интерфейс настроек импорта</summary>
  public interface IImportSettings
  {
    /// <summary>Этап импорта</summary>
    int ImportStep { get; set; }

    /// <summary>Список сообщений при тесте импорта</summary>
    ICollection<TestImportMessages> TestResult { get; }
  }
}
