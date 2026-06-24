// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scripts.ServiceReference.Models.WebReferenceDiscoveryResponse
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Scripts.ServiceReference.Models
{
  /// <summary>Ответ на запрос получения информации о веб-ссылке</summary>
  public sealed class WebReferenceDiscoveryResponse
  {
    internal static WebReferenceDiscoveryResponse KqJLuxWFzMELkWSFuQyu;

    /// <summary>Базовая часть ответа</summary>
    public DiscoveryResponse DiscoveryResponse
    {
      get => this.\u003CDiscoveryResponse\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CDiscoveryResponse\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>
    /// Строка с xml-форматом сервиса или html-страница для вывода на экран пользователю
    /// </summary>
    public string ServiceString
    {
      get => this.\u003CServiceString\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CServiceString\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public WebReferenceDiscoveryResponse()
    {
      WebReferenceDiscoveryResponse.NZw4uRWBWt22OThZ2PUq();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool GeFftdWBFSksp3iSIIMI() => WebReferenceDiscoveryResponse.KqJLuxWFzMELkWSFuQyu == null;

    internal static WebReferenceDiscoveryResponse LZIC6xWBBqUwOZqHb541() => WebReferenceDiscoveryResponse.KqJLuxWFzMELkWSFuQyu;

    internal static void NZw4uRWBWt22OThZ2PUq() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
