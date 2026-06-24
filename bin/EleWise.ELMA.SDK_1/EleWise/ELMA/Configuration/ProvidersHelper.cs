// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Configuration.ProvidersHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.Configuration;
using System.Configuration.Provider;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Configuration
{
  /// <summary>
  /// Класс - помошник, для обработки провайдеров в конфигурации
  /// </summary>
  public static class ProvidersHelper
  {
    private static ProvidersHelper kLSS99fWDBTQe2OYHRsN;

    /// <summary>Получить экземпляр провайдера по настройкам</summary>
    /// <param name="providerSettings">Настройки</param>
    /// <param name="providerType">Тип базового провайдера</param>
    /// <returns>Экземпляр провайдера</returns>
    public static ProviderBase InstantiateProvider(
      ProviderSettings providerSettings,
      Type providerType)
    {
      int num1 = 2;
      ProviderBase providerBase;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            providerBase = (ProviderBase) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 1;
            continue;
          default:
            goto label_43;
        }
      }
label_2:
      try
      {
        int num2;
        if (ProvidersHelper.aDiFehfW4MZWhFDEZftB((object) providerSettings) != null)
          num2 = 9;
        else
          goto label_26;
label_4:
        Type type;
        while (true)
        {
          NameValueCollection parameters;
          IEnumerator enumerator;
          NameValueCollection config;
          object obj1;
          switch (num2)
          {
            case 1:
              try
              {
label_11:
                if (ProvidersHelper.bJUE0OfW9GQcFfpe2K7s((object) enumerator))
                  goto label_14;
                else
                  goto label_12;
label_10:
                string str;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_25;
                    case 2:
                      goto label_11;
                    case 3:
                      goto label_14;
                    default:
                      ProvidersHelper.EHGeQjfWJ9QgpEEUvYG2((object) config, (object) str, ProvidersHelper.NCM1AffWMDAob1avkDtd((object) parameters, (object) str));
                      num3 = 2;
                      continue;
                  }
                }
label_12:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 1;
                goto label_10;
label_14:
                str = (string) ProvidersHelper.l0MjiqfWyr0dFcsWwn1B((object) enumerator);
                num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
                {
                  num3 = 0;
                  goto label_10;
                }
                else
                  goto label_10;
              }
              finally
              {
                IDisposable disposable = enumerator as IDisposable;
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      ProvidersHelper.mFfqePfWd4jJkbo5c5pd((object) disposable);
                      num4 = 2;
                      continue;
                    case 2:
                      goto label_22;
                    default:
                      if (disposable != null)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 1;
                        continue;
                      }
                      goto label_22;
                  }
                }
label_22:;
              }
            case 2:
              obj1 = Activator.CreateInstance(type);
              break;
            case 3:
              object obj2 = ProvidersHelper.QpRsNVfWxLPx8LQbQdtT(ProvidersHelper.eOm2yifW7uFC2TK33Su2(), type);
              if (obj2 == null)
              {
                num2 = 2;
                continue;
              }
              obj1 = obj2;
              break;
            case 4:
              if (providerType.IsAssignableFrom(type))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 3;
                continue;
              }
              goto label_30;
            case 5:
              goto label_43;
            case 6:
              goto label_30;
            case 7:
label_25:
              providerBase.Initialize((string) ProvidersHelper.vmqbHtfWlLfSbPUUDInk((object) providerSettings), config);
              num2 = 5;
              continue;
            case 8:
              enumerator = parameters.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 1;
              continue;
            case 9:
              goto label_23;
            case 10:
              parameters = providerSettings.Parameters;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
              continue;
            default:
              config = new NameValueCollection(ProvidersHelper.lya3yifW0uQsaKRRXDg2((object) parameters), (IEqualityComparer) ProvidersHelper.TyK4eafWmNQDJqRHP52L());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 8 : 5;
              continue;
          }
          providerBase = (ProviderBase) obj1;
          num2 = 10;
        }
label_23:
        string str1 = ((string) ProvidersHelper.aDiFehfW4MZWhFDEZftB((object) providerSettings)).Trim();
        goto label_27;
label_30:
        throw new ArgumentException(EleWise.ELMA.SR.T((string) ProvidersHelper.GYsJaQfWHmqGG7lfdUfI(1051802738 - -1831968059 ^ -1410872487), (object) providerType));
label_26:
        str1 = (string) null;
label_27:
        type = !ProvidersHelper.G0IXtIfW66n5cymiQa5H((object) str1) ? ProvidersHelper.uca59nfWAk2Txm2CQ8ne((object) str1, true, true) : throw new ArgumentException(EleWise.ELMA.SR.T((string) ProvidersHelper.GYsJaQfWHmqGG7lfdUfI(-951514650 ^ -951313584)));
        num2 = 4;
        goto label_4;
      }
      catch (Exception ex)
      {
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
          num5 = 0;
        while (true)
        {
          switch (num5)
          {
            case 1:
              goto label_41;
            case 2:
              goto label_40;
            default:
              if (!(ex is ConfigurationException))
              {
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 1 : 1;
                continue;
              }
              goto label_40;
          }
        }
label_40:
        throw;
label_41:
        throw new ConfigurationErrorsException((string) ProvidersHelper.oT3o8MfWr8IvC2wrhe47((object) ex), ex, (string) ProvidersHelper.u4u1udfWjbmbyr11p6Dn(ProvidersHelper.Q27rvnfW5he1MdooTVVB((object) ((ElementInformation) ProvidersHelper.BUmmS5fWgTpJtGMRKS7O((object) providerSettings)).Properties, ProvidersHelper.GYsJaQfWHmqGG7lfdUfI(-2099751081 ^ -2099750027))), ProvidersHelper.llZtuTfWYNjYoxy3vlbS(ProvidersHelper.Q27rvnfW5he1MdooTVVB((object) ((ElementInformation) ProvidersHelper.BUmmS5fWgTpJtGMRKS7O((object) providerSettings)).Properties, ProvidersHelper.GYsJaQfWHmqGG7lfdUfI(372753449 ^ 372754443))));
      }
label_43:
      return providerBase;
    }

    /// <summary>Инициализировать экземпляры провайдеров из настроек</summary>
    /// <param name="configProviders">Коллекция настроек</param>
    /// <param name="providers">Список провайдеров</param>
    /// <param name="providerType">Тип базового провайдера</param>
    public static void InstantiateProviders(
      ProviderSettingsCollection configProviders,
      ProviderCollection providers,
      Type providerType)
    {
      int num1 = 2;
      IEnumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_14;
          case 1:
            goto label_3;
          case 2:
            enumerator = (IEnumerator) ProvidersHelper.JH5FjtfWLTPKXqW7r6WT((object) configProviders);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 1 : 1;
            continue;
          default:
            goto label_10;
        }
      }
label_14:
      return;
label_10:
      return;
label_3:
      try
      {
label_7:
        if (ProvidersHelper.bJUE0OfW9GQcFfpe2K7s((object) enumerator))
          goto label_6;
        else
          goto label_8;
label_4:
        ProviderSettings current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_5;
            case 1:
              goto label_7;
            case 2:
              providers.Add((ProviderBase) ProvidersHelper.GWIgJRfWU80O3v4V3nIq((object) current, providerType));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_6;
            default:
              goto label_2;
          }
        }
label_5:
        return;
label_2:
        return;
label_6:
        current = (ProviderSettings) enumerator.Current;
        num2 = 2;
        goto label_4;
label_8:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
        goto label_4;
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              disposable.Dispose();
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 2 : 2;
              continue;
            case 2:
              goto label_18;
            default:
              if (disposable != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 0;
                continue;
              }
              goto label_18;
          }
        }
label_18:;
      }
    }

    internal static object aDiFehfW4MZWhFDEZftB([In] object obj0) => (object) ((ProviderSettings) obj0).Type;

    internal static bool G0IXtIfW66n5cymiQa5H([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object GYsJaQfWHmqGG7lfdUfI(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type uca59nfWAk2Txm2CQ8ne([In] object obj0, [In] bool obj1, [In] bool obj2) => Type.GetType((string) obj0, obj1, obj2);

    internal static object eOm2yifW7uFC2TK33Su2() => (object) ComponentManager.Current;

    internal static object QpRsNVfWxLPx8LQbQdtT([In] object obj0, Type type) => ((ComponentManager) obj0).GetExtensionPointByType(type);

    internal static int lya3yifW0uQsaKRRXDg2([In] object obj0) => ((NameObjectCollectionBase) obj0).Count;

    internal static object TyK4eafWmNQDJqRHP52L() => (object) StringComparer.Ordinal;

    internal static object l0MjiqfWyr0dFcsWwn1B([In] object obj0) => ((IEnumerator) obj0).Current;

    internal static object NCM1AffWMDAob1avkDtd([In] object obj0, [In] object obj1) => (object) ((NameValueCollection) obj0)[(string) obj1];

    internal static void EHGeQjfWJ9QgpEEUvYG2([In] object obj0, [In] object obj1, [In] object obj2) => ((NameValueCollection) obj0)[(string) obj1] = (string) obj2;

    internal static bool bJUE0OfW9GQcFfpe2K7s([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void mFfqePfWd4jJkbo5c5pd([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object vmqbHtfWlLfSbPUUDInk([In] object obj0) => (object) ((ProviderSettings) obj0).Name;

    internal static object oT3o8MfWr8IvC2wrhe47([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static object BUmmS5fWgTpJtGMRKS7O([In] object obj0) => (object) ((ConfigurationElement) obj0).ElementInformation;

    internal static object Q27rvnfW5he1MdooTVVB([In] object obj0, [In] object obj1) => (object) ((PropertyInformationCollection) obj0)[(string) obj1];

    internal static object u4u1udfWjbmbyr11p6Dn([In] object obj0) => (object) ((PropertyInformation) obj0).Source;

    internal static int llZtuTfWYNjYoxy3vlbS([In] object obj0) => ((PropertyInformation) obj0).LineNumber;

    internal static bool OXfaAMfWtjrYYlnlYdg4() => ProvidersHelper.kLSS99fWDBTQe2OYHRsN == null;

    internal static ProvidersHelper P9JtR7fWwvmubtmQMBib() => ProvidersHelper.kLSS99fWDBTQe2OYHRsN;

    internal static object JH5FjtfWLTPKXqW7r6WT([In] object obj0) => (object) ((ConfigurationElementCollection) obj0).GetEnumerator();

    internal static object GWIgJRfWU80O3v4V3nIq([In] object obj0, Type providerType) => (object) ProvidersHelper.InstantiateProvider((ProviderSettings) obj0, providerType);
  }
}
