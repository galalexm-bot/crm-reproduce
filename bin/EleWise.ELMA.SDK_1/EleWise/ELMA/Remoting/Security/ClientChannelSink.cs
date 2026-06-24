// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Remoting.Security.ClientChannelSink
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Security.Authentication;
using System.Text;

namespace EleWise.ELMA.Remoting.Security
{
  /// <summary>
  /// Sink для передачи в запрос через Remoting параметров авторизации
  /// </summary>
  internal class ClientChannelSink : 
    BaseChannelObjectWithProperties,
    IClientChannelSink,
    IChannelSinkBase
  {
    public static long totalBytes;
    private string _url;
    private IClientChannelSink _nextSink;
    private static ClientChannelSink unmbWxkapDUsEAMfg3r;

    public ClientChannelSink(string url, IClientChannelSink nextSink)
    {
      ClientChannelSink.pslDn8kwDYcFKLqnXDF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this._url = url;
            num = 2;
            continue;
          case 2:
            this._nextSink = nextSink;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    public ClientChannelSink(
      IChannelSender channel,
      string url,
      object remoteChannelData,
      IClientChannelSink nextSink)
    {
      ClientChannelSink.pslDn8kwDYcFKLqnXDF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this._nextSink = nextSink;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public void ProcessMessage(
      IMessage msg,
      ITransportHeaders requestHeaders,
      Stream requestStream,
      out ITransportHeaders responseHeaders,
      out Stream responseStream)
    {
      int num1 = 37;
      string message;
      while (true)
      {
        int num2 = num1;
        string str;
        CultureInfo currentCulture;
        long result;
        RemotingClientSecurityContext current;
        IMethodMessage methodMessage;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_70;
            case 1:
              if (current == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 13 : 7;
                continue;
              }
              goto case 7;
            case 2:
              if (ClientChannelSink.p947KGkynelKAqowUjD((object) Logger.Log))
              {
                num2 = 41;
                continue;
              }
              goto case 33;
            case 3:
              ClientChannelSink.JGLxVhnF2gvbMq2Ckij((object) current, responseHeaders[ClientChannelSink.Q7pRrlkHbQbenn1h1HL(1251470110 >> 2 ^ 312840727)] != null ? long.Parse((string) responseHeaders[ClientChannelSink.Q7pRrlkHbQbenn1h1HL(-488881205 ^ -488887525)]) : 0L);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
              continue;
            case 4:
            case 32:
              this._nextSink.ProcessMessage(msg, requestHeaders, requestStream, out responseHeaders, out responseStream);
              num2 = 2;
              continue;
            case 5:
              current.Token = ClientChannelSink.EIQMKFk53h8RQ0MyrFA((object) responseHeaders, ClientChannelSink.Q7pRrlkHbQbenn1h1HL(-1998538950 ^ -1998532172)) == null ? Guid.Empty : new Guid((string) ClientChannelSink.EIQMKFk53h8RQ0MyrFA((object) responseHeaders, ClientChannelSink.Q7pRrlkHbQbenn1h1HL(-630932142 - 1120244082 ^ -1751167634)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 6 : 12;
              continue;
            case 6:
              if (!ClientChannelSink.t878mfk6GLDUWgeuEfR())
              {
                num2 = 44;
                continue;
              }
              goto case 28;
            case 7:
              if (!ClientChannelSink.Uq4Pgck04JerQpgUvO1(ClientChannelSink.hPa9hvkxwMFSSuu5ee8((object) current), Guid.Empty))
                goto case 30;
              else
                goto label_23;
            case 8:
              goto label_60;
            case 9:
              ClientChannelSink.P5OJ6uk7SRf6bYcjymr((object) requestHeaders, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132936683), (object) ((string) ClientChannelSink.CPApWFkmSoMTxV031eu((object) current)).ToBase64String());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 11 : 19;
              continue;
            case 10:
              if (!ClientChannelSink.DETKICkjQHnR0Es8bvH((object) str))
              {
                num2 = 47;
                continue;
              }
              goto case 29;
            case 11:
              if (methodMessage != null)
              {
                num2 = 21;
                continue;
              }
              goto case 4;
            case 12:
              if (!(current.Token == Guid.Empty))
              {
                num2 = 3;
                continue;
              }
              goto label_71;
            case 13:
            case 19:
            case 25:
              methodMessage = msg as IMethodMessage;
              num2 = 24;
              continue;
            case 14:
              if (!ClientChannelSink.DETKICkjQHnR0Es8bvH((object) message))
              {
                num2 = 35;
                continue;
              }
              goto case 10;
            case 15:
              currentCulture = EleWise.ELMA.SR.GetCurrentCulture();
              num2 = 34;
              continue;
            case 16:
              result = 0L;
              num2 = 43;
              continue;
            case 17:
            case 38:
              current = RemotingClientSecurityContext.Current;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 1;
              continue;
            case 18:
              goto label_16;
            case 20:
              requestHeaders[ClientChannelSink.Q7pRrlkHbQbenn1h1HL(-2107978722 ^ -2107987312)] = (object) current.Token.ToString();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 25 : 2;
              continue;
            case 21:
              ClientChannelSink.rFCopBkgKHNAt6KYjlT(ClientChannelSink.vbShGckMuZd380wfdFS(), ClientChannelSink.zflCTJkrJWkuUlgakgN((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461634403), ClientChannelSink.S6HjCvkJQyKluRygFH5((object) methodMessage), ClientChannelSink.rlERm2k9y7iqn6tkynM((object) methodMessage) == null || methodMessage.Args.Length == 0 ? (object) "" : ClientChannelSink.Vwjx2iklGWfHJ760vHt(ClientChannelSink.Q7pRrlkHbQbenn1h1HL(712480695 ^ 712503453), ClientChannelSink.KYxuplkdknbVmBwoVwm(ClientChannelSink.Q7pRrlkHbQbenn1h1HL(-951514650 ^ -951515676), ClientChannelSink.rlERm2k9y7iqn6tkynM((object) methodMessage)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29261089))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 7 : 32;
              continue;
            case 22:
              if (ClientChannelSink.GDNSeWksIgMDYmfCRdS((object) str, ClientChannelSink.BfNObdkUeUcwndoee8X((object) typeof (AuthenticationException))))
              {
                num2 = 45;
                continue;
              }
              if (!ClientChannelSink.GDNSeWksIgMDYmfCRdS((object) str, ClientChannelSink.BfNObdkUeUcwndoee8X((object) typeof (SecurityException))))
              {
                num2 = 23;
                continue;
              }
              goto label_5;
            case 23:
              // ISSUE: type reference
              if (ClientChannelSink.GDNSeWksIgMDYmfCRdS((object) str, ClientChannelSink.BfNObdkUeUcwndoee8X((object) ClientChannelSink.vCRkTqkcmM6ZTF7mhAe(__typeref (IncompatibleVersionException)))))
              {
                num2 = 18;
                continue;
              }
              if (!ClientChannelSink.GDNSeWksIgMDYmfCRdS((object) str, ClientChannelSink.BfNObdkUeUcwndoee8X((object) typeof (RequireChangePasswordException))))
              {
                num2 = 8;
                continue;
              }
              goto label_59;
            case 24:
              if (!ClientChannelSink.p947KGkynelKAqowUjD((object) Logger.Log))
              {
                num2 = 4;
                continue;
              }
              goto case 11;
            case 26:
            case 40:
            case 51:
              ClientChannelSink.rFCopBkgKHNAt6KYjlT(ClientChannelSink.vbShGckMuZd380wfdFS(), ClientChannelSink.zflCTJkrJWkuUlgakgN((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113871697), (object) methodMessage.MethodBase, result > 0L ? ClientChannelSink.zflCTJkrJWkuUlgakgN(ClientChannelSink.Q7pRrlkHbQbenn1h1HL(813604817 ^ 813627567), (object) result, ClientChannelSink.Q7pRrlkHbQbenn1h1HL(-2112703338 ^ -2112695540)) : (object) ""));
              num2 = 33;
              continue;
            case 27:
              if (!ClientChannelSink.L0f3Cok4kioUEnnlbRc())
              {
                num2 = 28;
                continue;
              }
              goto case 6;
            case 28:
              requestHeaders[ClientChannelSink.Q7pRrlkHbQbenn1h1HL(-1380439818 << 3 ^ 1841373574)] = (object) VersionInfo.GetVersion<EleWise.ELMA.SR>().ToString();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 15 : 1;
              continue;
            case 29:
              if (ClientChannelSink.hPa9hvkxwMFSSuu5ee8((object) current) == Guid.Empty)
              {
                num2 = 5;
                continue;
              }
              goto label_67;
            case 30:
              requestHeaders[ClientChannelSink.Q7pRrlkHbQbenn1h1HL(~541731958 ^ -541739737)] = (object) current.UserName.ToBase64String();
              num2 = 9;
              continue;
            case 31:
              goto label_5;
            case 33:
              str = (string) ClientChannelSink.EIQMKFk53h8RQ0MyrFA((object) responseHeaders, ClientChannelSink.Q7pRrlkHbQbenn1h1HL(323422137 << 2 ^ 1293711688));
              num2 = 42;
              continue;
            case 34:
              if (currentCulture == null)
              {
                num2 = 38;
                continue;
              }
              goto case 39;
            case 35:
              message = ((Encoding) ClientChannelSink.A3l3iDkYoxNkuvF5KNk()).GetString((byte[]) ClientChannelSink.EEr2klkLPO5bEPbp33S((object) message));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 10 : 8;
              continue;
            case 36:
              responseStream = (Stream) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 12 : 27;
              continue;
            case 37:
              responseHeaders = (ITransportHeaders) null;
              num2 = 36;
              continue;
            case 39:
              ClientChannelSink.P5OJ6uk7SRf6bYcjymr((object) requestHeaders, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210700903), ClientChannelSink.l67iefkAJXxIjbNlNce((object) currentCulture));
              num2 = 17;
              continue;
            case 41:
              if (methodMessage != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 16 : 7;
                continue;
              }
              goto case 33;
            case 42:
              message = (string) ClientChannelSink.EIQMKFk53h8RQ0MyrFA((object) responseHeaders, ClientChannelSink.Q7pRrlkHbQbenn1h1HL(-882126494 ^ -882133314));
              num2 = 14;
              continue;
            case 43:
              if (ClientChannelSink.EIQMKFk53h8RQ0MyrFA((object) responseHeaders, ClientChannelSink.Q7pRrlkHbQbenn1h1HL(1925118608 << 2 ^ -889483918)) == null)
              {
                num2 = 51;
                continue;
              }
              goto case 49;
            case 44:
              goto label_63;
            case 45:
              goto label_43;
            case 46:
              goto label_59;
            case 47:
              if (ClientChannelSink.DETKICkjQHnR0Es8bvH((object) message))
              {
                num2 = 29;
                continue;
              }
              goto case 22;
            case 48:
              result = 0L;
              num2 = 26;
              continue;
            case 49:
              if (long.TryParse(ClientChannelSink.EIQMKFk53h8RQ0MyrFA((object) responseHeaders, ClientChannelSink.Q7pRrlkHbQbenn1h1HL(1642859704 ^ 1642883978)).ToString(), out result))
              {
                num2 = 40;
                continue;
              }
              goto case 48;
            case 50:
              goto label_71;
            default:
              goto label_65;
          }
        }
label_23:
        num1 = 20;
      }
label_70:
      return;
label_65:
      return;
label_5:
      throw new SecurityException(message);
label_16:
      throw new IncompatibleVersionException(message);
label_43:
      throw new AuthenticationException(message);
label_59:
      throw new RequireChangePasswordException();
label_60:
      throw new Exception(EleWise.ELMA.SR.T((string) ClientChannelSink.Q7pRrlkHbQbenn1h1HL(-2107978722 ^ -2107988980)) + (string) ClientChannelSink.Q7pRrlkHbQbenn1h1HL(2008901894 << 3 ^ -1108664220) + message);
label_67:
      return;
label_63:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) ClientChannelSink.Q7pRrlkHbQbenn1h1HL(1917256330 ^ 1917281412)));
label_71:
      throw new AuthenticationException((string) ClientChannelSink.ODgq60kz9CxjIRSnixQ(ClientChannelSink.Q7pRrlkHbQbenn1h1HL(-1872275253 >> 6 ^ -29231809)));
    }

    public void AsyncProcessRequest(
      IClientChannelSinkStack sinkStack,
      IMessage msg,
      ITransportHeaders headers,
      Stream stream)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ClientChannelSink.dCopDnnBFEx1qw2569X((object) sinkStack, (object) this, (object) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this._nextSink.AsyncProcessRequest(sinkStack, msg, headers, stream);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    public void AsyncProcessResponse(
      IClientResponseChannelSinkStack sinkStack,
      object state,
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
            ClientChannelSink.eaZpttnW8Zv8oYBB6M6((object) sinkStack, (object) headers, (object) stream);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public Stream GetRequestStream(IMessage msg, ITransportHeaders headers) => (Stream) null;

    public IClientChannelSink NextChannelSink => this._nextSink;

    internal static void pslDn8kwDYcFKLqnXDF() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool sJEmtckD5u42kFCPiDi() => ClientChannelSink.unmbWxkapDUsEAMfg3r == null;

    internal static ClientChannelSink i7isQWktFjve0VXGX4w() => ClientChannelSink.unmbWxkapDUsEAMfg3r;

    internal static bool L0f3Cok4kioUEnnlbRc() => RemotingClientParameters.IsDebugging;

    internal static bool t878mfk6GLDUWgeuEfR() => RemotingClientParameters.TryStopDebugging();

    internal static object Q7pRrlkHbQbenn1h1HL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object l67iefkAJXxIjbNlNce([In] object obj0) => (object) ((CultureInfo) obj0).Name;

    internal static void P5OJ6uk7SRf6bYcjymr([In] object obj0, [In] object obj1, [In] object obj2) => ((ITransportHeaders) obj0)[obj1] = obj2;

    internal static Guid hPa9hvkxwMFSSuu5ee8([In] object obj0) => ((RemotingClientSecurityContext) obj0).Token;

    internal static bool Uq4Pgck04JerQpgUvO1([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object CPApWFkmSoMTxV031eu([In] object obj0) => (object) ((RemotingClientSecurityContext) obj0).Password;

    internal static bool p947KGkynelKAqowUjD([In] object obj0) => ((ILogger) obj0).IsDebugEnabled();

    internal static object vbShGckMuZd380wfdFS() => (object) Logger.Log;

    internal static object S6HjCvkJQyKluRygFH5([In] object obj0) => (object) ((IMethodMessage) obj0).MethodBase;

    internal static object rlERm2k9y7iqn6tkynM([In] object obj0) => (object) ((IMethodMessage) obj0).Args;

    internal static object KYxuplkdknbVmBwoVwm([In] object obj0, [In] object obj1) => (object) string.Join((string) obj0, (object[]) obj1);

    internal static object Vwjx2iklGWfHJ760vHt([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object zflCTJkrJWkuUlgakgN([In] object obj0, [In] object obj1, [In] object obj2) => (object) (obj0.ToString() + obj1 + obj2);

    internal static void rFCopBkgKHNAt6KYjlT([In] object obj0, [In] object obj1) => ((ILogger) obj0).Debug(obj1);

    internal static object EIQMKFk53h8RQ0MyrFA([In] object obj0, [In] object obj1) => ((ITransportHeaders) obj0)[obj1];

    internal static bool DETKICkjQHnR0Es8bvH([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object A3l3iDkYoxNkuvF5KNk() => (object) Encoding.UTF8;

    internal static object EEr2klkLPO5bEPbp33S([In] object obj0) => (object) Convert.FromBase64String((string) obj0);

    internal static object BfNObdkUeUcwndoee8X([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static bool GDNSeWksIgMDYmfCRdS([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static Type vCRkTqkcmM6ZTF7mhAe([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object ODgq60kz9CxjIRSnixQ([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void JGLxVhnF2gvbMq2Ckij([In] object obj0, long value) => ((RemotingClientSecurityContext) obj0).UserId = value;

    internal static void dCopDnnBFEx1qw2569X([In] object obj0, [In] object obj1, [In] object obj2) => ((IClientChannelSinkStack) obj0).Push((IClientChannelSink) obj1, obj2);

    internal static void eaZpttnW8Zv8oYBB6M6([In] object obj0, [In] object obj1, [In] object obj2) => ((IClientResponseChannelSinkStack) obj0).AsyncProcessResponse((ITransportHeaders) obj1, (Stream) obj2);
  }
}
