// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.ModuleDisabledReason
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Modules
{
  /// <summary>Тип причины отключения модуля</summary>
  public enum ModuleDisabledReason
  {
    /// <summary>Неизвестна</summary>
    Unknown,
    /// <summary>Недоступен на сервере</summary>
    DisabledOnServer,
    /// <summary>Отключен вручную</summary>
    DisabledManually,
    /// <summary>Не активирован</summary>
    Activation,
    /// <summary>
    /// Нет в списке активированных модулей в БД (применяется для демо-версии)
    /// </summary>
    ActivationInDb,
    /// <summary>Недоступен один из зависимых модулей</summary>
    Dependency,
    /// <summary>Пакет модуля не установлен</summary>
    PackageNotInstalled,
    /// <summary>Не был подключен в данной конфигурации</summary>
    NotUsedInDb,
    /// <summary>Устарел</summary>
    Deprecated,
  }
}
