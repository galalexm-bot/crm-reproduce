// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Remoting.Security.ClientChannelSinkProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;

namespace EleWise.ELMA.Remoting.Security
{
  internal class ClientChannelSinkProvider : IClientChannelSinkProvider
  {
    private IClientChannelSinkProvider _next;
    private static ClientChannelSinkProvider S2AmsCnov0etfyrGJsw;

    public ClientChannelSinkProvider()
    {
      ClientChannelSinkProvider.BkBHf1nGaEDWkEMRFnn();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ClientChannelSinkProvider(IDictionary properties, ICollection providerData)
    {
      ClientChannelSinkProvider.BkBHf1nGaEDWkEMRFnn();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public IClientChannelSink CreateSink(
      IChannelSender channel,
      string url,
      object remoteChannelData)
    {
      int num = 4;
      IClientChannelSink nextSink;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (nextSink != null)
            {
              num = 5;
              continue;
            }
            goto label_4;
          case 2:
            nextSink = (IClientChannelSink) ClientChannelSinkProvider.NfspIwnEWSn2fe6MSfW((object) this._next, (object) channel, (object) url, remoteChannelData);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 1;
            continue;
          case 3:
            if (this._next != null)
            {
              num = 2;
              continue;
            }
            goto label_5;
          case 4:
            nextSink = (IClientChannelSink) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 3 : 2;
            continue;
          case 5:
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (IClientChannelSink) null;
label_5:
      return (IClientChannelSink) new ClientChannelSink(url, nextSink);
    }

    public IClientChannelSinkProvider Next
    {
      get => this._next;
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
              this._next = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
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

    internal static void BkBHf1nGaEDWkEMRFnn() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool lmbNj1nbuMr7gwFIW8d() => ClientChannelSinkProvider.S2AmsCnov0etfyrGJsw == null;

    internal static ClientChannelSinkProvider VEDY3vnhHl1LxSGVedd() => ClientChannelSinkProvider.S2AmsCnov0etfyrGJsw;

    internal static object NfspIwnEWSn2fe6MSfW([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) ((IClientChannelSinkProvider) obj0).CreateSink((IChannelSender) obj1, (string) obj2, obj3);
  }
}
