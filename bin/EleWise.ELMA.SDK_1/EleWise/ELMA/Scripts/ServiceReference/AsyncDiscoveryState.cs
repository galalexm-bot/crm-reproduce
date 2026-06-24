// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scripts.ServiceReference.AsyncDiscoveryState
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Scripts.ServiceReference
{
  /// <summary>
  /// Holds information needed when an async web discovery call has completed.
  /// </summary>
  public class AsyncDiscoveryState
  {
    private WebServiceDiscoveryClientProtocol protocol;
    private Uri uri;
    private DiscoveryNetworkCredential credential;
    private static AsyncDiscoveryState fnXNqUBce0EEJdQEyJwb;

    /// <summary>Протокол обнаружения веб-служб XML</summary>
    public WebServiceDiscoveryClientProtocol Protocol => this.protocol;

    /// <summary>Ссылка на службу</summary>
    public Uri Uri => this.uri;

    /// <summary>Учетные данные</summary>
    public DiscoveryNetworkCredential Credential => this.credential;

    /// <summary>Ctor</summary>
    /// <param name="protocol">Протокол обнаружения веб-служб XML</param>
    /// <param name="uri">Ссылка на службу</param>
    /// <param name="credential">Учетные данные</param>
    public AsyncDiscoveryState(
      WebServiceDiscoveryClientProtocol protocol,
      Uri uri,
      DiscoveryNetworkCredential credential)
    {
      AsyncDiscoveryState.RwcBTiBcNePSUU32cOQf();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.credential = credential;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 0;
            continue;
          case 3:
            this.uri = uri;
            num = 2;
            continue;
          default:
            this.protocol = protocol;
            num = 3;
            continue;
        }
      }
label_3:;
    }

    internal static void RwcBTiBcNePSUU32cOQf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool NX6vpsBcPgHcv7Ef6dkf() => AsyncDiscoveryState.fnXNqUBce0EEJdQEyJwb == null;

    internal static AsyncDiscoveryState EpmUeOBc1PB4PLmDUIuW() => AsyncDiscoveryState.fnXNqUBce0EEJdQEyJwb;
  }
}
