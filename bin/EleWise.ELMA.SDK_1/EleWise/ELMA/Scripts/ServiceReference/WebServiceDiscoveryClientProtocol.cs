// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scripts.ServiceReference.WebServiceDiscoveryClientProtocol
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Net;
using System.Runtime.InteropServices;
using System.Web.Services.Discovery;
using System.Web.Services.Protocols;

namespace EleWise.ELMA.Scripts.ServiceReference
{
  /// <summary>
  /// Custom DiscoveryClientProtocol that determines whether user authentication
  /// is required.
  /// </summary>
  public class WebServiceDiscoveryClientProtocol : DiscoveryClientProtocol
  {
    private HttpWebResponse lastResponseReceived;
    private static WebServiceDiscoveryClientProtocol qwj45HWFJIQ3DMkJLjbJ;

    /// <summary>cTOR</summary>
    public WebServiceDiscoveryClientProtocol()
    {
      WebServiceDiscoveryClientProtocol.NNXF3pWFldljj5cZV3sY();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Получить заголовок авторизации</summary>
    public HttpAuthenticationHeader GetAuthenticationHeader()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (this.lastResponseReceived == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return new HttpAuthenticationHeader(this.lastResponseReceived.Headers);
label_5:
      return (HttpAuthenticationHeader) null;
    }

    /// <summary>Авторизация необходима</summary>
    public bool IsAuthenticationRequired
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.lastResponseReceived != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return WebServiceDiscoveryClientProtocol.W77XD8WFrw7rwmITxYkG((object) this.lastResponseReceived) == HttpStatusCode.Unauthorized;
label_5:
        return false;
      }
    }

    /// <summary>Получить ответ веб-запроса</summary>
    /// <param name="request">Веб-запрос</param>
    protected override WebResponse GetWebResponse(WebRequest request)
    {
      int num = 1;
      WebResponse webResponse;
      while (true)
      {
        switch (num)
        {
          case 1:
            webResponse = (WebResponse) WebServiceDiscoveryClientProtocol.CK2II2WFgaqh3QeSeFJU((object) this, (object) request);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.lastResponseReceived = webResponse as HttpWebResponse;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 2 : 2;
            continue;
        }
      }
label_3:
      return webResponse;
    }

    internal static void NNXF3pWFldljj5cZV3sY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool SvrKHhWF9PNNMtsxs8ue() => WebServiceDiscoveryClientProtocol.qwj45HWFJIQ3DMkJLjbJ == null;

    internal static WebServiceDiscoveryClientProtocol W7dB5xWFdfMG8wyZdD3t() => WebServiceDiscoveryClientProtocol.qwj45HWFJIQ3DMkJLjbJ;

    internal static HttpStatusCode W77XD8WFrw7rwmITxYkG([In] object obj0) => ((HttpWebResponse) obj0).StatusCode;

    internal static object CK2II2WFgaqh3QeSeFJU([In] object obj0, [In] object obj1) => (object) __nonvirtual (((HttpWebClientProtocol) obj0).GetWebResponse((WebRequest) obj1));
  }
}
