using System;
using System.IO;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using EleWise.ELMA.Runtime.NH.SessionProviders;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Remoting.NH;

public class NHServerChannelSink : BaseChannelObjectWithProperties, IServerChannelSink, IChannelSinkBase
{
	private IServerChannelSink _nextSink;

	private static NHServerChannelSink Ba1glGn5axVVjfOu2kH;

	public IServerChannelSink NextChannelSink => _nextSink;

	public NHServerChannelSink(IServerChannelSink nextSink)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		t5wXkmnL42ZiPvJwRVx();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			_nextSink = nextSink;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
			{
				num = 1;
			}
		}
	}

	public NHServerChannelSink(IChannelReceiver channel, IServerChannelSink nextSink)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			_nextSink = nextSink;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
			{
				num = 1;
			}
		}
	}

	public ServerProcessing ProcessMessage(IServerChannelSinkStack sinkStack, IMessage requestMsg, ITransportHeaders requestHeaders, Stream requestStream, out IMessage responseMsg, out ITransportHeaders responseHeaders, out Stream responseStream)
	{
		//Discarded unreachable code: IL_00c1
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				WRnQTNnUKcIMFXlJjkS();
				num2 = 3;
				break;
			case 5:
				responseMsg = null;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
			{
				ServerProcessing num3 = _nextSink.ProcessMessage(sinkStack, requestMsg, requestHeaders, requestStream, out responseMsg, out responseHeaders, out responseStream);
				xnHFXCncmUi4Ywv9iFe(sinkStack, this);
				mKdoLdnzGukSLT8tL1V();
				responseHeaders = new TransportHeaders();
				if (num3 == ServerProcessing.Complete)
				{
					num2 = 4;
					break;
				}
				goto case 7;
			}
			case 7:
				throw new Exception((string)M2KsIYOFRXD3VZyKnBl(-2138160520 ^ -2138166960));
			case 4:
				return ServerProcessing.Complete;
			default:
				responseStream = null;
				num2 = 5;
				break;
			case 3:
				lGO3bdnsxiRhCITdt19(sinkStack, this, null);
				num2 = 6;
				break;
			case 1:
				responseHeaders = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void AsyncProcessResponse(IServerResponseChannelSinkStack sinkStack, object state, IMessage msg, ITransportHeaders headers, Stream stream)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				aInuYgOBD2LbnrffUy6(sinkStack, msg, headers, stream);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public Stream GetResponseStream(IServerResponseChannelSinkStack sinkStack, object state, IMessage msg, ITransportHeaders headers)
	{
		return null;
	}

	internal static void t5wXkmnL42ZiPvJwRVx()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool xs3aCLnj5VaJBCnmbir()
	{
		return Ba1glGn5axVVjfOu2kH == null;
	}

	internal static NHServerChannelSink cOg0jynYamLWTegS4JT()
	{
		return Ba1glGn5axVVjfOu2kH;
	}

	internal static void WRnQTNnUKcIMFXlJjkS()
	{
		WebSessionModule.InitSessions();
	}

	internal static void lGO3bdnsxiRhCITdt19(object P_0, object P_1, object P_2)
	{
		((IServerChannelSinkStack)P_0).Push((IServerChannelSink)P_1, P_2);
	}

	internal static object xnHFXCncmUi4Ywv9iFe(object P_0, object P_1)
	{
		return ((IServerChannelSinkStack)P_0).Pop((IServerChannelSink)P_1);
	}

	internal static void mKdoLdnzGukSLT8tL1V()
	{
		WebSessionModule.ReleaseSessions();
	}

	internal static object M2KsIYOFRXD3VZyKnBl(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void aInuYgOBD2LbnrffUy6(object P_0, object P_1, object P_2, object P_3)
	{
		((IServerResponseChannelSinkStack)P_0).AsyncProcessResponse((IMessage)P_1, (ITransportHeaders)P_2, (Stream)P_3);
	}
}
