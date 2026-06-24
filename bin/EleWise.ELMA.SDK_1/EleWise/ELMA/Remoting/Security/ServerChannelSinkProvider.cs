// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Remoting.Security.ServerChannelSinkProvider
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
  internal class ServerChannelSinkProvider : IServerChannelSinkProvider
  {
    private IServerChannelSinkProvider _next;
    internal static ServerChannelSinkProvider uRE7lcn9ysqWyTfhIDO;

    public ServerChannelSinkProvider()
    {
      ServerChannelSinkProvider.lsZYRdnrn1RArqjxUMF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ServerChannelSinkProvider(IDictionary properties, ICollection providerData)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public void GetChannelData(IChannelDataStore channelData)
    {
    }

    public IServerChannelSink CreateSink(IChannelReceiver channel)
    {
      int num = 4;
      IServerChannelSink nextSink;
      while (true)
      {
        switch (num)
        {
          case 1:
            nextSink = (IServerChannelSink) ServerChannelSinkProvider.pq6lJingBfxrQc6xxH7((object) this._next, (object) channel);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
            continue;
          case 3:
            if (this._next == null)
            {
              num = 2;
              continue;
            }
            goto case 1;
          case 4:
            nextSink = (IServerChannelSink) null;
            num = 3;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return (IServerChannelSink) new ServerChannelSink(nextSink);
    }

    public IServerChannelSinkProvider Next
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
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

    internal static void lsZYRdnrn1RArqjxUMF() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ybXpNindwHQJNAbuvQG() => ServerChannelSinkProvider.uRE7lcn9ysqWyTfhIDO == null;

    internal static ServerChannelSinkProvider QpJZrLnl9pfsFIqZA3a() => ServerChannelSinkProvider.uRE7lcn9ysqWyTfhIDO;

    internal static object pq6lJingBfxrQc6xxH7([In] object obj0, [In] object obj1) => (object) ((IServerChannelSinkProvider) obj0).CreateSink((IChannelReceiver) obj1);
  }
}
