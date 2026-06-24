// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scripts.ServiceReference.Models.ServiceDiscoveryResponse
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Scripts.ServiceReference.Models
{
  /// <summary>Ответ на запрос получения информации о веб-сервисе</summary>
  public sealed class ServiceDiscoveryResponse
  {
    internal static ServiceDiscoveryResponse FIAdNaWBCCyKbxMNZctW;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
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
    /// Информация о веб-сервисе для вывода на экран пользователю
    /// </summary>
    public ServiceReferenceInfo ServiceReferenceInfo
    {
      get => this.\u003CServiceReferenceInfo\u003Ek__BackingField;
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
              this.\u003CServiceReferenceInfo\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
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

    public ServiceDiscoveryResponse()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool SBnFK3WBv5AyLdvbqty9() => ServiceDiscoveryResponse.FIAdNaWBCCyKbxMNZctW == null;

    internal static ServiceDiscoveryResponse qjImWFWB8Lr7RbiRegx4() => ServiceDiscoveryResponse.FIAdNaWBCCyKbxMNZctW;
  }
}
