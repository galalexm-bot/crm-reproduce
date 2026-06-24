// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Remoting.RemotingConfigurator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Remoting.Security;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Serialization.Formatters;

namespace EleWise.ELMA.Remoting
{
  /// <summary>Конфигуратор Remoting-а</summary>
  public static class RemotingConfigurator
  {
    private static bool remotingClientConfigured;
    /// <summary>Клиентский канал</summary>
    internal static HttpChannel clientChannel;
    /// <summary>Показать окно авторизации</summary>
    internal static Func<bool> ShowLoginDialog;
    internal static RemotingConfigurator yniP6qTL1I0dhBZnGBZ;

    /// <summary>
    /// Сконфигурировать параметры для клиентского приложения Remoting
    /// </summary>
    public static void ConfigureRemotingClient()
    {
      int num = 1;
      BinaryClientFormatterSinkProvider clientSinkProvider;
      ClientChannelSinkProvider channelSinkProvider;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_8;
          case 1:
            if (RemotingConfigurator.remotingClientConfigured)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
              continue;
            }
            RemotingConfigurator.remotingClientConfigured = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 5 : 5;
            continue;
          case 2:
            RemotingConfigurator.SHomAQTcdbP3pjA1irE((object) clientSinkProvider, (object) channelSinkProvider);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 2 : 3;
            continue;
          case 3:
            Hashtable properties = new Hashtable();
            properties[(object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870889439)] = RemotingConfigurator.XPsVOSTz7LhReREq1K9(-1350312861 << 3 ^ 2082375494);
            RemotingConfigurator.twNn56kF10GN8SxU1ga((object) properties, RemotingConfigurator.XPsVOSTz7LhReREq1K9(-1876063057 ^ -1876039645), (object) 0);
            RemotingConfigurator.twNn56kF10GN8SxU1ga((object) properties, RemotingConfigurator.XPsVOSTz7LhReREq1K9(-1867198571 ^ -1867207923), (object) "");
            properties[(object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477165194)] = (object) "";
            RemotingConfigurator.clientChannel = new HttpChannel((IDictionary) properties, (IClientChannelSinkProvider) clientSinkProvider, (IServerChannelSinkProvider) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 4 : 1;
            continue;
          case 4:
            RemotingConfigurator.UrWuIVkBEGB5PS4PwWY((object) RemotingConfigurator.clientChannel, false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 6 : 6;
            continue;
          case 5:
            channelSinkProvider = new ClientChannelSinkProvider();
            num = 7;
            continue;
          case 6:
            goto label_2;
          case 7:
            clientSinkProvider = new BinaryClientFormatterSinkProvider();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 2;
            continue;
          default:
            goto label_12;
        }
      }
label_8:
      return;
label_2:
      return;
label_12:;
    }

    /// <summary>
    /// Переконфигурировать параметры для клиентского приложения Remoting
    /// </summary>
    internal static void ReConfigureRemotingClient()
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              RemotingConfigurator.remotingClientConfigured = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
              continue;
            case 2:
              RemotingConfigurator.zYd7BGkW22daKkHKLLB((object) RemotingConfigurator.clientChannel);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 1 : 1;
              continue;
            case 3:
              if (RemotingConfigurator.clientChannel != null)
              {
                num2 = 2;
                continue;
              }
              goto case 1;
            case 4:
              goto label_3;
            default:
              goto label_5;
          }
        }
label_5:
        RemotingConfigurator.JcOHjdko5bNAw8YLGYE();
        num1 = 4;
      }
label_3:;
    }

    /// <summary>
    /// Сконфигурировать параметры для серверного приложения Remoting
    /// </summary>
    public static IChannel ConfigureRemotingServer(string channelName, int port, string host)
    {
      int num = 10;
      IDictionary properties;
      BinaryServerFormatterSinkProvider formatterSinkProvider;
      ServerChannelSinkProvider serverSinkProvider;
      while (true)
      {
        switch (num)
        {
          case 1:
            RemotingConfigurator.DpYmYLkbY5dm9b18OED((object) formatterSinkProvider, TypeFilterLevel.Full);
            num = 7;
            continue;
          case 2:
            RemotingConfigurator.twNn56kF10GN8SxU1ga((object) properties, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107987822), (object) port);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 3 : 3;
            continue;
          case 3:
            if (string.IsNullOrEmpty(host))
            {
              num = 4;
              continue;
            }
            goto case 8;
          case 5:
            properties = (IDictionary) new Hashtable();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 6 : 6;
            continue;
          case 6:
            RemotingConfigurator.twNn56kF10GN8SxU1ga((object) properties, RemotingConfigurator.XPsVOSTz7LhReREq1K9(-1876063057 ^ -1876066119), (object) channelName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 2;
            continue;
          case 7:
            RemotingConfigurator.pUsCX2khwKuYxKYpGrA((object) serverSinkProvider, (object) formatterSinkProvider);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 5 : 1;
            continue;
          case 8:
            properties[RemotingConfigurator.XPsVOSTz7LhReREq1K9(1581325282 << 3 ^ -234308656)] = (object) host;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
            continue;
          case 9:
            formatterSinkProvider = new BinaryServerFormatterSinkProvider();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 1 : 1;
            continue;
          case 10:
            serverSinkProvider = new ServerChannelSinkProvider();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 5 : 9;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      HttpChannel chnl = new HttpChannel(properties, (IClientChannelSinkProvider) null, (IServerChannelSinkProvider) serverSinkProvider);
      ChannelServices.RegisterChannel((IChannel) chnl, false);
      return (IChannel) chnl;
    }

    static RemotingConfigurator() => RemotingConfigurator.xiMySskGwy8veaFcbhI();

    internal static void SHomAQTcdbP3pjA1irE([In] object obj0, [In] object obj1) => ((BinaryClientFormatterSinkProvider) obj0).Next = (IClientChannelSinkProvider) obj1;

    internal static object XPsVOSTz7LhReREq1K9(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void twNn56kF10GN8SxU1ga([In] object obj0, [In] object obj1, [In] object obj2) => ((IDictionary) obj0)[obj1] = obj2;

    internal static void UrWuIVkBEGB5PS4PwWY([In] object obj0, [In] bool obj1) => ChannelServices.RegisterChannel((IChannel) obj0, obj1);

    internal static bool Lew76UTUrgdu3vJwC5K() => RemotingConfigurator.yniP6qTL1I0dhBZnGBZ == null;

    internal static RemotingConfigurator rkPVcFTsvIMa7XGpX7X() => RemotingConfigurator.yniP6qTL1I0dhBZnGBZ;

    internal static void zYd7BGkW22daKkHKLLB([In] object obj0) => ChannelServices.UnregisterChannel((IChannel) obj0);

    internal static void JcOHjdko5bNAw8YLGYE() => RemotingConfigurator.ConfigureRemotingClient();

    internal static void DpYmYLkbY5dm9b18OED([In] object obj0, [In] TypeFilterLevel obj1) => ((BinaryServerFormatterSinkProvider) obj0).TypeFilterLevel = obj1;

    internal static void pUsCX2khwKuYxKYpGrA([In] object obj0, [In] object obj1) => ((ServerChannelSinkProvider) obj0).Next = (IServerChannelSinkProvider) obj1;

    internal static void xiMySskGwy8veaFcbhI() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
