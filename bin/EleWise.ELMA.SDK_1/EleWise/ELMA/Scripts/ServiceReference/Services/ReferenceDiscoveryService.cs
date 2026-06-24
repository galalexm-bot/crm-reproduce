// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scripts.ServiceReference.Services.ReferenceDiscoveryService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Scripts.ServiceReference.Models;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Scripts.ServiceReference.Services
{
  /// <inheritdoc cref="T:EleWise.ELMA.Scripts.ServiceReference.Services.IReferenceDiscoveryService" />
  [Service]
  internal sealed class ReferenceDiscoveryService : IReferenceDiscoveryService
  {
    internal static ReferenceDiscoveryService sL5kgNWFL5Ye7RaU0MWq;

    /// <inheritdoc />
    public ServiceDiscoveryResponse DiscoverServiceReference(DiscoveryRequest request) => (ServiceDiscoveryResponse) null;

    /// <inheritdoc />
    public WebReferenceDiscoveryResponse DiscoverWebReference(DiscoveryRequest request) => (WebReferenceDiscoveryResponse) null;

    /// <summary>Получить информацию о веб-сервисе</summary>
    /// <remarks>
    /// Метод для поддержки IAssemblyReferenceService, удалить при удалении IAssemblyReferenceService
    /// </remarks>
    /// <param name="request">Запрос</param>
    /// <param name="validUri">Url</param>
    internal ServiceReferenceDiscoverer GetServiceReferenceDiscover(
      DiscoveryRequest request,
      Uri validUri)
    {
      return (ServiceReferenceDiscoverer) null;
    }

    /// <summary>Получить информацию о веб-ссылке</summary>
    /// <remarks>
    /// Метод для поддержки IAssemblyReferenceService, удалить при удалении IAssemblyReferenceService
    /// </remarks>
    /// <param name="request">Запрос</param>
    /// <param name="validUri">Url</param>
    internal WebReferenceDiscoverer GetWebReferenceDiscover(DiscoveryRequest request, Uri validUri) => (WebReferenceDiscoverer) null;

    public ReferenceDiscoveryService()
    {
      ReferenceDiscoveryService.DolhtKWFcd9PRmg5gRKY();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void DolhtKWFcd9PRmg5gRKY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool kOj1oCWFUF5vS7Upsfki() => ReferenceDiscoveryService.sL5kgNWFL5Ye7RaU0MWq == null;

    internal static ReferenceDiscoveryService vUshqWWFsXSHyjs49a8r() => ReferenceDiscoveryService.sL5kgNWFL5Ye7RaU0MWq;
  }
}
