// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Packaging.PackageStatus
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Packaging
{
  /// <summary>Статус пакета</summary>
  public enum PackageStatus
  {
    /// <summary>Любой</summary>
    Any,
    /// <summary>Установлен</summary>
    Installed,
    /// <summary>Установлен и есть доступное обновление</summary>
    InstalledHasUpdate,
    /// <summary>Не установленные</summary>
    NotInstalled,
  }
}
