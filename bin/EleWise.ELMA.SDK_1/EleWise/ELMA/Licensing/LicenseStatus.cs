// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Licensing.LicenseStatus
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Licensing
{
  /// <summary>Статус активации лицензии</summary>
  public enum LicenseStatus
  {
    /// <summary>Активирована</summary>
    Activated,
    /// <summary>Не активирована</summary>
    NotActivated,
    /// <summary>Истек срок использования</summary>
    DateExpired,
    /// <summary>Требуется перезапуск сервера</summary>
    NeedRestart,
  }
}
