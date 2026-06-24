// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Licensing.ILicenseInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Licensing
{
  /// <summary>Информация о текущем состоянии лицензии</summary>
  public interface ILicenseInfo
  {
    /// <summary>Статус активации лицензии</summary>
    LicenseStatus Status { get; }

    /// <summary>Описание состояния лицензии</summary>
    string Description { get; }

    /// <summary>Тип лицензии</summary>
    byte LicenseType { get; }
  }
}
