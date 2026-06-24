// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.ISignedExportParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Models.Certificates;

namespace EleWise.ELMA.Deploy
{
  /// <summary>
  /// Интерфейс параметров экспорта, поддерживающих подписание и шифрование
  /// </summary>
  internal interface ISignedExportParameters
  {
    /// <summary>Контейнер для управления сертификатами</summary>
    ICertificateContainer CertificateContainer { get; }
  }
}
