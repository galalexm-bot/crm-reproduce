// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Packaging.AutoDeployComponentStatus
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Packaging
{
  /// <summary>Статус авторазвертывания компонента ELMA</summary>
  public enum AutoDeployComponentStatus
  {
    /// <summary>Неопределен</summary>
    None = 0,
    /// <summary>Установка проведена</summary>
    Complete = 2,
    /// <summary>Установка проведена с ошибками</summary>
    Failed = 3,
    /// <summary>Предварительный этап</summary>
    Step0 = 100, // 0x00000064
    /// <summary>Первый этап импорта (метаданные)</summary>
    Step1 = 101, // 0x00000065
    /// <summary>Второй этап импорта (данные)</summary>
    Step2 = 102, // 0x00000066
  }
}
