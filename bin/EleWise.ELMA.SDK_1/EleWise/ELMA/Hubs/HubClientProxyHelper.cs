// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Hubs.HubClientProxyHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Hubs
{
  /// <summary>Хелпер для работы с прокси клиентов хабов</summary>
  internal static class HubClientProxyHelper
  {
    /// <summary>
    /// Карта Тип интерфейса клиента - (Тип прокси-интерфейса клиента, Фабрика обертки над прокси)
    /// </summary>
    private static readonly IDictionary<Type, (Type proxyType, Func<object, IClient> wrapperFactory)> ClientToClientProxyMap;
    internal static HubClientProxyHelper Wgq8qBhgtfNUb1CkKXgX;

    /// <summary>Добавить информацию о прокси для клиента</summary>
    /// <param name="clientType">Тип клиента</param>
    /// <param name="clientProxyType">Тип прокси клиента</param>
    /// <param name="wrapperFactory">Фабрика оболочки прокси клиента</param>
    public static void AddProxy(
      Type clientType,
      Type clientProxyType,
      Func<object, IClient> wrapperFactory)
    {
      HubClientProxyHelper.ClientToClientProxyMap[clientType] = (clientProxyType, wrapperFactory);
    }

    /// <summary>Получить тип прокси для клиента</summary>
    /// <param name="clientType">Тип клиента</param>
    /// <returns>Тип прокси</returns>
    public static Type GetProxyType(Type clientType) => HubClientProxyHelper.ClientToClientProxyMap[clientType].proxyType;

    /// <summary>Получить фабрику оболочки прокси для клиента</summary>
    /// <param name="clientType">Тип клиента</param>
    /// <returns>Фабрика оболочки</returns>
    public static Func<object, IClient> GetProxyWrapperFactory(Type clientType) => HubClientProxyHelper.ClientToClientProxyMap[clientType].wrapperFactory;

    static HubClientProxyHelper()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            HubClientProxyHelper.MDsr2mhg6lmldkOYnTow();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            HubClientProxyHelper.ClientToClientProxyMap = (IDictionary<Type, (Type, Func<object, IClient>)>) new Dictionary<Type, (Type, Func<object, IClient>)>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool Qu8Y36hgwn5WE5fpHbok() => HubClientProxyHelper.Wgq8qBhgtfNUb1CkKXgX == null;

    internal static HubClientProxyHelper YA7KHbhg4KqQIUY8fXEA() => HubClientProxyHelper.Wgq8qBhgtfNUb1CkKXgX;

    internal static void MDsr2mhg6lmldkOYnTow() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
