// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Remoting.RemotingServiceRegistrar
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;

namespace EleWise.ELMA.Remoting
{
  /// <summary>Класс для регистрации сервиса через Remoting</summary>
  public static class RemotingServiceRegistrar
  {
    private static bool remotingRegistered;
    private static Dictionary<Type, RemotingServiceRegistrar.ConfiguredInfo> configuredInfos;
    internal static RemotingServiceRegistrar eV0MeokEQyHPujk3uDa;

    /// <summary>Получить порт зарегистрированного сервиса</summary>
    /// <typeparam name="TService">Тип сервиса</typeparam>
    /// <returns>Порт, или -1, если сервис не зарегистрирован</returns>
    public static int GetRegisterdPort<TService>() => RemotingServiceRegistrar.GetRegisterdPort(typeof (TService));

    /// <summary>Получить порт зарегистрированного сервиса</summary>
    /// <param name="serviceType">Тип сервиса</param>
    /// <returns>Порт, или -1, если сервис не зарегистрирован</returns>
    public static int GetRegisterdPort(Type serviceType)
    {
      int num = 3;
      RemotingServiceRegistrar.ConfiguredInfo configuredInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (!RemotingServiceRegistrar.configuredInfos.TryGetValue(serviceType, out configuredInfo))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 3:
            RemotingServiceRegistrar.AKLnVmkvUQKQ3Sl9dPH((object) serviceType, RemotingServiceRegistrar.HV2CuhkCxDC5BCRMc8e(647913418 ^ 647904016));
            num = 2;
            continue;
          default:
            goto label_3;
        }
      }
label_2:
      return RemotingServiceRegistrar.SmgxQBk88iNuqvfri3K((object) configuredInfo);
label_3:
      return -1;
    }

    /// <summary>Зарегистрировать Remoting-сервис</summary>
    /// <typeparam name="TService">Тип сервиса</typeparam>
    /// <param name="port">Порт</param>
    /// <param name="serviceName">Имя, под которым нужно зарегистрировать сервис</param>
    /// <param name="host">Имя хоста сервера</param>
    public static bool Register<TService>(int port, string serviceName, string host) where TService : MarshalByRefObject => RemotingServiceRegistrar.Register(typeof (TService), port, serviceName, host);

    /// <summary>Зарегистрировать Remoting-сервис</summary>
    /// <param name="serviceType">Тип сервиса</param>
    /// <param name="port">Порт</param>
    /// <param name="serviceName">Имя, под которым нужно зарегистрировать сервис</param>
    /// <param name="host">Имя хоста сервера</param>
    public static bool Register(Type serviceType, int port, string serviceName, string host)
    {
      int num1 = 1;
      RemotingServiceRegistrar.ConfiguredInfo info;
      while (true)
      {
        switch (num1)
        {
          case 1:
            RemotingServiceRegistrar.AKLnVmkvUQKQ3Sl9dPH((object) serviceType, RemotingServiceRegistrar.HV2CuhkCxDC5BCRMc8e(132912447 ^ 132936165));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
            continue;
          case 2:
            if (RemotingServiceRegistrar.configuredInfos.TryGetValue(serviceType, out info))
            {
              num1 = 7;
              continue;
            }
            goto case 11;
          case 3:
          case 4:
            RemotingServiceRegistrar.Unregister((object) info);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 11 : 10;
            continue;
          case 5:
            goto label_15;
          case 6:
            goto label_13;
          case 7:
            if (RemotingServiceRegistrar.SmgxQBk88iNuqvfri3K((object) info) == port)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 7 : 10;
              continue;
            }
            goto case 3;
          case 8:
            if (!(info.Host == host))
            {
              num1 = 4;
              continue;
            }
            goto label_13;
          case 9:
            goto label_6;
          case 10:
            if (!((string) RemotingServiceRegistrar.aaDLYnkZnEYnQI2XeKM((object) info) == serviceName))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 3 : 3;
              continue;
            }
            goto case 8;
          case 11:
            num1 = 5;
            continue;
          default:
            Contract.CheckArgument(typeof (MarshalByRefObject).IsAssignableFrom(serviceType), (string) RemotingServiceRegistrar.HV2CuhkCxDC5BCRMc8e(-2106517564 ^ -2106494160));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 2;
            continue;
        }
      }
label_6:
      bool flag;
      return flag;
label_13:
      return true;
label_15:
      try
      {
        IChannel channel = (IChannel) RemotingServiceRegistrar.TKKNACkI7CJR4LWKymY(RemotingServiceRegistrar.pufqIQkubMhpK4tSeo6((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757139030), (object) serviceName), port, (object) host);
        int num2 = 5;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 6:
              if (info != null)
              {
                num2 = 3;
                continue;
              }
              goto case 4;
            case 2:
              RemotingServiceRegistrar.remotingRegistered = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 6;
              continue;
            case 3:
              if (!RemotingServiceRegistrar.tm1iaakSLda5YbMWRdp(RemotingServiceRegistrar.aaDLYnkZnEYnQI2XeKM((object) info), (object) serviceName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 9 : 9;
                continue;
              }
              goto case 4;
            case 4:
              RemotingConfiguration.RegisterWellKnownServiceType(serviceType, serviceName, WellKnownObjectMode.Singleton);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 7 : 1;
              continue;
            case 5:
              if (RemotingServiceRegistrar.remotingRegistered)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 1;
                continue;
              }
              goto case 8;
            case 7:
            case 9:
              Dictionary<Type, RemotingServiceRegistrar.ConfiguredInfo> configuredInfos = RemotingServiceRegistrar.configuredInfos;
              Type key = serviceType;
              RemotingServiceRegistrar.ConfiguredInfo configuredInfo = new RemotingServiceRegistrar.ConfiguredInfo();
              configuredInfo.ServiceType = serviceType;
              RemotingServiceRegistrar.ysJGXPki9xvwKoQt0f8((object) configuredInfo, port);
              RemotingServiceRegistrar.H2TTCxkRqlql72QICMG((object) configuredInfo, (object) serviceName);
              RemotingServiceRegistrar.XMAfWjkqoMdeaXVxh57((object) configuredInfo, (object) channel);
              configuredInfos[key] = configuredInfo;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
              continue;
            case 8:
              RemotingServiceRegistrar.b74xcXkVyHX2IXYt6CH(CustomErrorsModes.Off);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 2;
              continue;
            case 10:
              goto label_6;
            default:
              flag = true;
              num2 = 10;
              continue;
          }
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 1:
              RemotingServiceRegistrar.zUj18KkKHjiH8SjBYW0((object) Logger.Log, RemotingServiceRegistrar.HV2CuhkCxDC5BCRMc8e(1251470110 >> 2 ^ 312844115), (object) ex);
              num3 = 2;
              continue;
            case 2:
              flag = false;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
              continue;
            default:
              goto label_6;
          }
        }
      }
    }

    private static void Unregister(object info)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (info != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            goto label_15;
          case 3:
            goto label_2;
          case 4:
            goto label_16;
          default:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 3 : 0;
            continue;
        }
      }
label_15:
      return;
label_16:
      return;
label_2:
      try
      {
        int num2;
        if (((RemotingServiceRegistrar.ConfiguredInfo) info).Channel != null)
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 1;
        else
          goto label_7;
label_4:
        while (true)
        {
          switch (num2)
          {
            case 1:
              RemotingServiceRegistrar.juFUkEkTRsekFvGsmDv(RemotingServiceRegistrar.rTY29XkXnC0OwSIjIw7(info));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_14;
            default:
              goto label_7;
          }
        }
label_14:
        return;
label_7:
        RemotingServiceRegistrar.XMAfWjkqoMdeaXVxh57(info, (object) null);
        num2 = 2;
        goto label_4;
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_12;
            case 1:
              ((ILogger) RemotingServiceRegistrar.BBOtk5kk6lWJEkxyZOn()).Error(RemotingServiceRegistrar.HV2CuhkCxDC5BCRMc8e(1917256330 ^ 1917282124), ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
              continue;
            default:
              goto label_8;
          }
        }
label_12:
        return;
label_8:
        return;
      }
label_5:;
    }

    static RemotingServiceRegistrar()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            RemotingServiceRegistrar.configuredInfos = new Dictionary<Type, RemotingServiceRegistrar.ConfiguredInfo>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
            continue;
          case 2:
            RemotingServiceRegistrar.dHVadxknClkK7eLJQPy();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object HV2CuhkCxDC5BCRMc8e(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void AKLnVmkvUQKQ3Sl9dPH([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static int SmgxQBk88iNuqvfri3K([In] object obj0) => ((RemotingServiceRegistrar.ConfiguredInfo) obj0).Port;

    internal static bool M2RX7ekfAshnjjYve1s() => RemotingServiceRegistrar.eV0MeokEQyHPujk3uDa == null;

    internal static RemotingServiceRegistrar saEHKUkQy6dcL15eFMG() => RemotingServiceRegistrar.eV0MeokEQyHPujk3uDa;

    internal static object aaDLYnkZnEYnQI2XeKM([In] object obj0) => (object) ((RemotingServiceRegistrar.ConfiguredInfo) obj0).ServiceName;

    internal static object pufqIQkubMhpK4tSeo6([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object TKKNACkI7CJR4LWKymY([In] object obj0, int port, [In] object obj2) => (object) RemotingConfigurator.ConfigureRemotingServer((string) obj0, port, (string) obj2);

    internal static void b74xcXkVyHX2IXYt6CH([In] CustomErrorsModes obj0) => RemotingConfiguration.CustomErrorsMode = obj0;

    internal static bool tm1iaakSLda5YbMWRdp([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static void ysJGXPki9xvwKoQt0f8([In] object obj0, int value) => ((RemotingServiceRegistrar.ConfiguredInfo) obj0).Port = value;

    internal static void H2TTCxkRqlql72QICMG([In] object obj0, [In] object obj1) => ((RemotingServiceRegistrar.ConfiguredInfo) obj0).ServiceName = (string) obj1;

    internal static void XMAfWjkqoMdeaXVxh57([In] object obj0, [In] object obj1) => ((RemotingServiceRegistrar.ConfiguredInfo) obj0).Channel = (IChannel) obj1;

    internal static void zUj18KkKHjiH8SjBYW0([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static object rTY29XkXnC0OwSIjIw7([In] object obj0) => (object) ((RemotingServiceRegistrar.ConfiguredInfo) obj0).Channel;

    internal static void juFUkEkTRsekFvGsmDv([In] object obj0) => ChannelServices.UnregisterChannel((IChannel) obj0);

    internal static object BBOtk5kk6lWJEkxyZOn() => (object) Logger.Log;

    internal static void dHVadxknClkK7eLJQPy() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    private class ConfiguredInfo
    {
      private static object DdsdLNf0lTTRd1P6MJdk;

      public Type ServiceType
      {
        get => this.\u003CServiceType\u003Ek__BackingField;
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
                this.\u003CServiceType\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
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

      public int Port
      {
        get => this.\u003CPort\u003Ek__BackingField;
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
                this.\u003CPort\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
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

      public string ServiceName
      {
        get => this.\u003CServiceName\u003Ek__BackingField;
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
                this.\u003CServiceName\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
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

      public IChannel Channel
      {
        get => this.\u003CChannel\u003Ek__BackingField;
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
                this.\u003CChannel\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
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

      public string Host
      {
        get => this.\u003CHost\u003Ek__BackingField;
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
                this.\u003CHost\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
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

      public ConfiguredInfo()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool m17BTGf0rXTJXjdIsZTp() => RemotingServiceRegistrar.ConfiguredInfo.DdsdLNf0lTTRd1P6MJdk == null;

      internal static RemotingServiceRegistrar.ConfiguredInfo mVRLhcf0g9L8ad9AltF8() => (RemotingServiceRegistrar.ConfiguredInfo) RemotingServiceRegistrar.ConfiguredInfo.DdsdLNf0lTTRd1P6MJdk;
    }
  }
}
