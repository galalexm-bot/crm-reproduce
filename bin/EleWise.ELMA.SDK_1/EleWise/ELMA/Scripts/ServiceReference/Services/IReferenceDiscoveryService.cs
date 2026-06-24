// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scripts.ServiceReference.Services.IReferenceDiscoveryService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Scripts.ServiceReference.Models;

namespace EleWise.ELMA.Scripts.ServiceReference.Services
{
  /// <summary>Сервис для работы с ссылками на сервисы</summary>
  public interface IReferenceDiscoveryService
  {
    /// <summary>Получить информацию о веб-сервисе</summary>
    /// <param name="request">Запрос</param>
    ServiceDiscoveryResponse DiscoverServiceReference(DiscoveryRequest request);

    /// <summary>Получить информацию о веб-ссылке</summary>
    /// <param name="request">Запрос</param>
    WebReferenceDiscoveryResponse DiscoverWebReference(DiscoveryRequest request);
  }
}
