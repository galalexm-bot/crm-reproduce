// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Licensing.IConcurrentLicenseInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Licensing
{
  /// <summary>Информация о конкурентной лицензии</summary>
  public interface IConcurrentLicenseInfo : IWorkplaceLicenseInfo, ILicenseInfo
  {
    /// <summary>Является ли текущая лицензия конкурентной</summary>
    bool IsConcurrent { get; }

    /// <summary>Количество активированных привилегированных лицензий</summary>
    uint? PrivilegeCount { get; }

    /// <summary>Количество используемых привилегированных лицензий</summary>
    uint UsedPrivilegeCount { get; }
  }
}
