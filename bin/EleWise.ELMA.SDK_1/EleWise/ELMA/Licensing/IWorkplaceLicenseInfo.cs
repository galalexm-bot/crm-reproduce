// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Licensing.IWorkplaceLicenseInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Licensing
{
  /// <summary>
  /// Информация о лицензии, выдаваемой на опредленное количество рабочих мест
  /// </summary>
  public interface IWorkplaceLicenseInfo : ILicenseInfo
  {
    /// <summary>Количество рабочих мест. Если null - неограничено.</summary>
    uint? WorkplaceCount { get; }

    /// <summary>Количество используемых рабочих мест.</summary>
    uint UsedLicenseCount { get; }
  }
}
