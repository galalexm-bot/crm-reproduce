// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Remoting.NH.NHServerChannelSink
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.NH.SessionProviders;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;

namespace EleWise.ELMA.Remoting.NH
{
  public class NHServerChannelSink : 
    BaseChannelObjectWithProperties,
    IServerChannelSink,
    IChannelSinkBase
  {
    private IServerChannelSink _nextSink;
    private static NHServerChannelSink Ba1glGn5axVVjfOu2kH;

    public NHServerChannelSink(IServerChannelSink nextSink)
    {
      NHServerChannelSink.t5wXkmnL42ZiPvJwRVx();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this._nextSink = nextSink;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public NHServerChannelSink(IChannelReceiver channel, IServerChannelSink nextSink)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this._nextSink = nextSink;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public ServerProcessing ProcessMessage(
      IServerChannelSinkStack sinkStack,
      IMessage requestMsg,
      ITransportHeaders requestHeaders,
      Stream requestStream,
      out IMessage responseMsg,
      out ITransportHeaders responseHeaders,
      out Stream responseStream)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            responseHeaders = (ITransportHeaders) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
            continue;
          case 2:
            NHServerChannelSink.WRnQTNnUKcIMFXlJjkS();
            num1 = 3;
            continue;
          case 3:
            NHServerChannelSink.lGO3bdnsxiRhCITdt19((object) sinkStack, (object) this, (object) null);
            num1 = 6;
            continue;
          case 4:
            goto label_7;
          case 5:
            responseMsg = (IMessage) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 2 : 0;
            continue;
          case 6:
            int num2 = (int) this._nextSink.ProcessMessage(sinkStack, requestMsg, requestHeaders, requestStream, out responseMsg, out responseHeaders, out responseStream);
            NHServerChannelSink.xnHFXCncmUi4Ywv9iFe((object) sinkStack, (object) this);
            NHServerChannelSink.mKdoLdnzGukSLT8tL1V();
            responseHeaders = (ITransportHeaders) new TransportHeaders();
            if (num2 == 0)
            {
              num1 = 4;
              continue;
            }
            goto label_6;
          case 7:
            goto label_6;
          default:
            responseStream = (Stream) null;
            num1 = 5;
            continue;
        }
      }
label_6:
      throw new Exception((string) NHServerChannelSink.M2KsIYOFRXD3VZyKnBl(-2138160520 ^ -2138166960));
label_7:
      return ServerProcessing.Complete;
    }

    public void AsyncProcessResponse(
      IServerResponseChannelSinkStack sinkStack,
      object state,
      IMessage msg,
      ITransportHeaders headers,
      Stream stream)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            NHServerChannelSink.aInuYgOBD2LbnrffUy6((object) sinkStack, (object) msg, (object) headers, (object) stream);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public Stream GetResponseStream(
      IServerResponseChannelSinkStack sinkStack,
      object state,
      IMessage msg,
      ITransportHeaders headers)
    {
      return (Stream) null;
    }

    public IServerChannelSink NextChannelSink => this._nextSink;

    internal static void t5wXkmnL42ZiPvJwRVx() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool xs3aCLnj5VaJBCnmbir() => NHServerChannelSink.Ba1glGn5axVVjfOu2kH == null;

    internal static NHServerChannelSink cOg0jynYamLWTegS4JT() => NHServerChannelSink.Ba1glGn5axVVjfOu2kH;

    internal static void WRnQTNnUKcIMFXlJjkS() => WebSessionModule.InitSessions();

    internal static void lGO3bdnsxiRhCITdt19([In] object obj0, [In] object obj1, [In] object obj2) => ((IServerChannelSinkStack) obj0).Push((IServerChannelSink) obj1, obj2);

    internal static object xnHFXCncmUi4Ywv9iFe([In] object obj0, [In] object obj1) => ((IServerChannelSinkStack) obj0).Pop((IServerChannelSink) obj1);

    internal static void mKdoLdnzGukSLT8tL1V() => WebSessionModule.ReleaseSessions();

    internal static object M2KsIYOFRXD3VZyKnBl(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void aInuYgOBD2LbnrffUy6([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((IServerResponseChannelSinkStack) obj0).AsyncProcessResponse((IMessage) obj1, (ITransportHeaders) obj2, (Stream) obj3);
  }
}
