// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Configuration.ConfigurationServiceProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Remoting;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Configuration
{
  /// <summary>Провайдер сервисов конфигурирования приложений ELMA</summary>
  internal class ConfigurationServiceProvider : EternalRefObject
  {
    /// <summary>Имя сервиса, зарегистрированного через Remoting</summary>
    public const string RemotingServiceName = "ConfigurationServiceProvider.asmx";
    private List<EternalRefObject> services;
    private static bool registering;
    internal static ConfigurationServiceProvider Wmx0l6fF5ECKnEOw8Ff8;

    /// <summary>Зарегистрировать (или перерегистрировать сервис)</summary>
    public static void Register()
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_47;
            case 1:
              if (ConfigurationServiceProvider.registering)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_3;
            case 3:
              goto label_7;
            default:
              goto label_43;
          }
        }
label_4:
        ConfigurationServiceProvider.registering = true;
        num1 = 3;
      }
label_47:
      return;
label_3:
      return;
label_43:
      return;
label_7:
      try
      {
        CommonSettingsModule serviceNotNull = Locator.GetServiceNotNull<CommonSettingsModule>();
        int num3 = 6;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0)
          num3 = 20;
        while (true)
        {
          int num4;
          int port;
          string host;
          bool flag;
          int num5;
          switch (num3)
          {
            case 1:
              goto label_28;
            case 2:
              if (ConfigurationServiceProvider.DcAPlufBWHu2gPYZ36MO(ConfigurationServiceProvider.U7OgycfBoEFucvgGRpxf((object) host), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124617622)))
              {
                num3 = 16;
                continue;
              }
              goto case 8;
            case 3:
              ++port;
              num3 = 22;
              continue;
            case 4:
              if (host != null)
              {
                num3 = 19;
                continue;
              }
              goto case 8;
            case 5:
              if (port > 65000)
              {
                num4 = 9;
                break;
              }
              goto case 18;
            case 6:
            case 16:
              host = (string) null;
              num3 = 8;
              continue;
            case 7:
            case 12:
              if (num5 > 0)
              {
                num3 = 14;
                continue;
              }
              goto label_22;
            case 8:
              flag = false;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
              continue;
            case 9:
              goto label_19;
            case 10:
              if (!flag)
              {
                num3 = 3;
                continue;
              }
              goto case 17;
            case 11:
              host = (string) ConfigurationServiceProvider.jFU0vkfBF5RfWBnvM5HI((object) new Uri(serviceNotNull.Settings.ApplicationBaseUrl, UriKind.RelativeOrAbsolute));
              num3 = 4;
              continue;
            case 13:
              num5 = ConfigurationServiceProvider.uOFENmfFUeH7ciPvvQRT((object) serviceNotNull.Settings);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 12 : 12;
              continue;
            case 14:
              host = (string) null;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 15 : 1;
              continue;
            case 15:
              if (ConfigurationServiceProvider.y0yM0OfFsOyJX32Tl7o1((object) serviceNotNull.Settings))
              {
                num3 = 21;
                continue;
              }
              goto case 8;
            case 17:
            case 22:
              if (flag)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 1;
                continue;
              }
              goto case 5;
            case 18:
              flag = RemotingServiceRegistrar.Register<ConfigurationServiceProvider>(port, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811829364), host);
              num3 = 10;
              continue;
            case 19:
              if (ConfigurationServiceProvider.DcAPlufBWHu2gPYZ36MO((object) host, ConfigurationServiceProvider.KK5b0qfBBHkJPmxqPoDx(1319452732 ^ 1319442238)))
              {
                num3 = 6;
                continue;
              }
              goto case 2;
            case 20:
              num5 = ConfigurationServiceProvider.pjgTdMfFL4KrcAoMDwtR((object) serviceNotNull.Settings);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 23 : 11;
              continue;
            case 21:
              if (!ConfigurationServiceProvider.VCrNEUfFz9l9jXHVgWU8(ConfigurationServiceProvider.GFkFiufFcc8JxqZudVKm((object) serviceNotNull.Settings)))
              {
                num4 = 11;
                break;
              }
              goto case 8;
            case 23:
              if (num5 > 0)
              {
                num3 = 7;
                continue;
              }
              goto case 13;
            default:
              port = num5;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 10 : 17;
              continue;
          }
          num3 = num4;
        }
label_28:
        return;
label_19:
        return;
label_22:;
      }
      finally
      {
        ConfigurationServiceProvider.registering = false;
        int num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
          num6 = 0;
        switch (num6)
        {
          default:
        }
      }
    }

    /// <summary>Ctor</summary>
    public ConfigurationServiceProvider()
    {
      ConfigurationServiceProvider.Nb6bJjfBbHNvuU7LNqdT();
      this.services = new List<EternalRefObject>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
        num1 = 1;
      IEnumerator<Type> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_18;
          case 1:
            enumerator = ((ComponentManager) ConfigurationServiceProvider.BD4lJvfBhlXqqJ3ChFbT()).GetExtensionPointTypes<IConfigurationService>().GetEnumerator();
            num1 = 2;
            continue;
          case 2:
            goto label_4;
          default:
            goto label_13;
        }
      }
label_18:
      return;
label_13:
      return;
label_4:
      try
      {
label_9:
        if (ConfigurationServiceProvider.XoQ9SDfBGVhyGwCtq8en((object) enumerator))
          goto label_8;
        else
          goto label_10;
label_5:
        EternalRefObject service;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            case 3:
              if (service == null)
              {
                num2 = 2;
                continue;
              }
              goto case 4;
            case 4:
              this.services.Add(service);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
              continue;
            case 5:
              goto label_7;
            default:
              goto label_9;
          }
        }
label_7:
        return;
label_8:
        service = Locator.GetService(enumerator.Current) as EternalRefObject;
        num2 = 3;
        goto label_5;
label_10:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 2 : 5;
        goto label_5;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                enumerator.Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
                continue;
              default:
                goto label_20;
            }
          }
        }
label_20:;
      }
    }

    /// <summary>Количество сервисов</summary>
    public int Count => ConfigurationServiceProvider.qM1UXrfBEsIUcm8w2QT8((object) this.services);

    /// <summary>Получить сервис по индексу (0..Count-1)</summary>
    /// <param name="index">Индекс сервиса</param>
    /// <returns>Сервис</returns>
    public RemoteServiceInfo Get(int index) => this.GetItem(index);

    /// <summary>Получить сервис по индексу (0..Count-1)</summary>
    /// <param name="index">Индекс сервиса</param>
    /// <returns>Сервис</returns>
    public RemoteServiceInfo GetItem(int index)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (index < ConfigurationServiceProvider.qM1UXrfBEsIUcm8w2QT8((object) this.services))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
          case 4:
            goto label_4;
          case 3:
            if (index < 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 2;
              continue;
            }
            goto case 1;
          default:
            goto label_5;
        }
      }
label_4:
      return (RemoteServiceInfo) null;
label_5:
      return new RemoteServiceInfo(this.services[index]);
    }

    /// <summary>
    /// Получить Raw загруженной сборки. Если не найдена - возвращается null.
    /// </summary>
    /// <param name="assemblyName">Имя сборки</param>
    /// <param name="isFullName">True, если поиск ведется по полному имени сборки</param>
    /// <returns>Raw загруженной сборки</returns>
    public byte[] ResolveAssembly(string assemblyName, bool isFullName)
    {
      int num1 = 9;
      Assembly assembly;
      while (true)
      {
        int num2 = num1;
        bool isFullName1;
        string assemblyName1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 10:
              goto label_5;
            case 2:
              goto label_12;
            case 3:
              assemblyName1 = assemblyName;
              num2 = 6;
              continue;
            case 4:
              goto label_8;
            case 5:
              goto label_6;
            case 6:
              assembly = ((IEnumerable<Assembly>) ConfigurationServiceProvider.x7TSDSfBf6FAUos7Ral1()).FirstOrDefault<Assembly>((Func<Assembly, bool>) (a =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      if (!isFullName1)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
                        continue;
                      }
                      goto case 3;
                    case 2:
                      goto label_2;
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (!ConfigurationServiceProvider.\u003C\u003Ec__DisplayClass8_0.syS1jo89ISLxgvZDgBck(ConfigurationServiceProvider.\u003C\u003Ec__DisplayClass8_0.GtjpJ989uFjZVlZR0Evt((object) a), (object) assemblyName1))
                      {
                        num3 = 4;
                        continue;
                      }
                      goto label_4;
                    default:
                      if (!isFullName1)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 2 : 2;
                        continue;
                      }
                      goto label_3;
                  }
                }
label_2:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return ConfigurationServiceProvider.\u003C\u003Ec__DisplayClass8_0.syS1jo89ISLxgvZDgBck(ConfigurationServiceProvider.\u003C\u003Ec__DisplayClass8_0.TmgnJK89ViOMp3TDTvTS((object) a), (object) assemblyName1);
label_3:
                return false;
label_4:
                return true;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
              continue;
            case 7:
              if (assembly.IsDynamic)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 1;
                continue;
              }
              goto label_6;
            case 8:
              isFullName1 = isFullName;
              num2 = 3;
              continue;
            case 9:
              num2 = 8;
              continue;
            case 11:
              goto label_4;
            default:
              if (!(assembly == (Assembly) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 7;
                continue;
              }
              goto label_12;
          }
        }
label_6:
        if (!string.IsNullOrEmpty(assembly.Location))
        {
          num1 = 4;
          continue;
        }
        goto label_5;
label_8:
        if (!ConfigurationServiceProvider.bURk4hfBCESiAcuEn4r1(ConfigurationServiceProvider.enL0V1fBQosh8XNiBGBW((object) assembly)))
          num1 = 10;
        else
          break;
      }
label_4:
      return (byte[]) ConfigurationServiceProvider.aUXN1cfBvaJeSyp3Qs2l(ConfigurationServiceProvider.enL0V1fBQosh8XNiBGBW((object) assembly));
label_5:
      return ComponentManager.GetLoadedAssemblyRaw(assembly);
label_12:
      return (byte[]) null;
    }

    internal static int pjgTdMfFL4KrcAoMDwtR([In] object obj0) => ((CommonSettings) obj0).GetRealRemotingPort();

    internal static int uOFENmfFUeH7ciPvvQRT([In] object obj0) => ((CommonSettings) obj0).RemotingPort;

    internal static bool y0yM0OfFsOyJX32Tl7o1([In] object obj0) => ((CommonSettings) obj0).UseBaseUrlForRemoting;

    internal static object GFkFiufFcc8JxqZudVKm([In] object obj0) => (object) ((CommonSettings) obj0).ApplicationBaseUrl;

    internal static bool VCrNEUfFz9l9jXHVgWU8([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object jFU0vkfBF5RfWBnvM5HI([In] object obj0) => (object) ((Uri) obj0).Host;

    internal static object KK5b0qfBBHkJPmxqPoDx(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool DcAPlufBWHu2gPYZ36MO([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object U7OgycfBoEFucvgGRpxf([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static bool Sdq0V7fFjHZeGQrOKRs1() => ConfigurationServiceProvider.Wmx0l6fF5ECKnEOw8Ff8 == null;

    internal static ConfigurationServiceProvider BOyR6jfFY4L1T9KrGdiM() => ConfigurationServiceProvider.Wmx0l6fF5ECKnEOw8Ff8;

    internal static void Nb6bJjfBbHNvuU7LNqdT() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object BD4lJvfBhlXqqJ3ChFbT() => (object) ComponentManager.Current;

    internal static bool XoQ9SDfBGVhyGwCtq8en([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static int qM1UXrfBEsIUcm8w2QT8([In] object obj0) => ((List<EternalRefObject>) obj0).Count;

    internal static object x7TSDSfBf6FAUos7Ral1() => (object) ComponentManager.GetAssemblies();

    internal static object enL0V1fBQosh8XNiBGBW([In] object obj0) => (object) ((Assembly) obj0).Location;

    internal static bool bURk4hfBCESiAcuEn4r1([In] object obj0) => File.Exists((string) obj0);

    internal static object aUXN1cfBvaJeSyp3Qs2l([In] object obj0) => (object) File.ReadAllBytes((string) obj0);

    /// <summary>Регистратор провайдера</summary>
    [Component(Type = ComponentType.WebServer)]
    internal class RemotingRegistrar : IModuleContainerEvents
    {
      internal static ConfigurationServiceProvider.RemotingRegistrar Jlbn9n89ELLqyg74PUIi;

      public void Activated() => ConfigurationServiceProvider.Register();

      public void Terminating()
      {
      }

      public RemotingRegistrar()
      {
        ConfigurationServiceProvider.RemotingRegistrar.JqiLru89CCUvKdGZ4yWp();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void JqiLru89CCUvKdGZ4yWp() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool ulu3kE89f9xA5PvhVxCL() => ConfigurationServiceProvider.RemotingRegistrar.Jlbn9n89ELLqyg74PUIi == null;

      internal static ConfigurationServiceProvider.RemotingRegistrar x4oEae89QuUqkYtQfugh() => ConfigurationServiceProvider.RemotingRegistrar.Jlbn9n89ELLqyg74PUIi;
    }
  }
}
