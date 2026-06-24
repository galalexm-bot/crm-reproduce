// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.StartStatus
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Runtime
{
  /// <summary>Статус запуска приложения</summary>
  [Serializable]
  public enum StartStatus
  {
    /// <summary>Идет запуск</summary>
    Running = 0,
    /// <summary>Приложение запущено</summary>
    Started = 1,
    /// <summary>Приложение не активировано</summary>
    NotActivated = 2,
    /// <summary>Приложение не запущено (произошли ошибки)</summary>
    NotStarted = 3,
    /// <summary>Не пройдены некоторые предварительные проверки</summary>
    PrerequisitesCheckFault = 100, // 0x00000064
    /// <summary>Требуется выполнить резервное копирование</summary>
    BackupNeeded = 101, // 0x00000065
  }
}
