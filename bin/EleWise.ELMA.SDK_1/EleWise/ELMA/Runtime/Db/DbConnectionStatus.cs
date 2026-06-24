// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.DbConnectionStatus
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Runtime.Db
{
  /// <summary>Статус сервера</summary>
  [Flags]
  public enum DbConnectionStatus
  {
    /// <summary>Неизвестен</summary>
    Unknown = 0,
    /// <summary>Запуск сервера</summary>
    Starting = 1,
    /// <summary>Сервер запущен</summary>
    Started = 2,
    /// <summary>Требуется перекомпиляция сценариев модели дизайнера</summary>
    ConfigurationScriptsRecompileRequired = 4,
  }
}
