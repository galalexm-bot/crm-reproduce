// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Remoting.NH.NHServerChannelSinkProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;

namespace EleWise.ELMA.Remoting.NH
{
  public class NHServerChannelSinkProvider : IServerChannelSinkProvider
  {
    private IServerChannelSinkProvider _next;
    private static NHServerChannelSinkProvider axMxY2OWPHMHnRoUWSX;

    public NHServerChannelSinkProvider()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public NHServerChannelSinkProvider(IDictionary properties, ICollection providerData)
    {
      NHServerChannelSinkProvider.IeQp85OhgamJlXG4hXw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
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
      int num = 1;
      IServerChannelSink nextSink;
      while (true)
      {
        switch (num)
        {
          case 1:
            nextSink = (IServerChannelSink) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
            continue;
          case 2:
          case 3:
            goto label_6;
          case 4:
            nextSink = (IServerChannelSink) NHServerChannelSinkProvider.OVxlTOOGfK8HZPkZewO((object) this._next, (object) channel);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 2 : 2;
            continue;
          default:
            if (this._next == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 3 : 3;
              continue;
            }
            goto case 4;
        }
      }
label_6:
      return (IServerChannelSink) new NHServerChannelSink(nextSink);
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
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

    internal static bool cFhVrAOo9gKX6MdkNFn() => NHServerChannelSinkProvider.axMxY2OWPHMHnRoUWSX == null;

    internal static NHServerChannelSinkProvider hC4Jb1ObNm3wBhlNdbk() => NHServerChannelSinkProvider.axMxY2OWPHMHnRoUWSX;

    internal static void IeQp85OhgamJlXG4hXw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object OVxlTOOGfK8HZPkZewO([In] object obj0, [In] object obj1) => (object) ((IServerChannelSinkProvider) obj0).CreateSink((IChannelReceiver) obj1);
  }
}
