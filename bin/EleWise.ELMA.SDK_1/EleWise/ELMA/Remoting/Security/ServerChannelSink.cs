// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Remoting.Security.ServerChannelSink
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
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
using System.Threading;

namespace EleWise.ELMA.Remoting.Security
{
  internal class ServerChannelSink : 
    BaseChannelObjectWithProperties,
    IServerChannelSink,
    IChannelSinkBase
  {
    private IServerChannelSink _nextSink;
    private static ServerChannelSink PXduOKnftfiov8BBAlM;

    public ServerChannelSink(IServerChannelSink nextSink)
    {
      ServerChannelSink.fVTNdQnvjxQcsZX6Zex();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this._nextSink = nextSink;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    public ServerChannelSink(IChannelReceiver channel, IServerChannelSink nextSink)
    {
      ServerChannelSink.fVTNdQnvjxQcsZX6Zex();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this._nextSink = nextSink;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
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
      IDisposable disposable;
      while (true)
      {
        switch (num1)
        {
          case 1:
            disposable = (IDisposable) ServerChannelSink.xFRMAxn8BNc6tR8SJUD();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      ServerProcessing serverProcessing;
      return serverProcessing;
label_3:
      try
      {
        responseHeaders = (ITransportHeaders) null;
        int num2 = 2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              responseMsg = (IMessage) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
              continue;
            case 2:
              responseStream = (Stream) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 0;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        try
        {
          int num3;
          if (!ServerChannelSink.f1AMxsnZMRv4QsvWtVc())
            num3 = 13;
          else
            goto label_14;
label_12:
          Version version1;
          while (true)
          {
            int num4;
            CallContextSessionOwner contextSessionOwner;
            CultureInfo cultureInfo1;
            CultureInfo cultureInfo2;
            string str1;
            Guid token;
            string str2;
            IUser user;
            bool flag;
            Guid guid1;
            Guid guid2;
            switch (num3)
            {
              case 1:
                int num5 = (int) this._nextSink.ProcessMessage(sinkStack, requestMsg, requestHeaders, requestStream, out responseMsg, out responseHeaders, out responseStream);
                sinkStack.Pop((IServerChannelSink) this);
                if (ServerChannelSink.wO0OJqn7jn9oOct2iCc(guid1, Guid.Empty))
                {
                  if (responseHeaders == null)
                    responseHeaders = (ITransportHeaders) new TransportHeaders();
                  ServerChannelSink.WUlanwnxT1gTZvdHmEC((object) responseHeaders, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867208421), (object) guid1.ToString());
                  ServerChannelSink.WUlanwnxT1gTZvdHmEC((object) responseHeaders, ServerChannelSink.Rri1kknVcfi3DfnRYN5(1251470110 >> 2 ^ 312840727), (object) ServerChannelSink.vBrt4jn019c1clGcYfi((object) user).ToString());
                }
                if (num5 == 0)
                {
                  serverProcessing = ServerProcessing.Complete;
                  num3 = 31;
                  continue;
                }
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 4 : 30;
                continue;
              case 2:
                guid2 = Guid.Empty;
                goto label_86;
              case 3:
                goto label_61;
              case 4:
                guid1 = Guid.Empty;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 6;
                continue;
              case 5:
                cultureInfo2 = (CultureInfo) null;
                num3 = 29;
                continue;
              case 6:
                if (ServerChannelSink.LKS0qWneMZCofE6vZ8C(token, Guid.Empty))
                {
                  num3 = 28;
                  continue;
                }
                goto case 15;
              case 7:
              case 17:
                cultureInfo2 = (CultureInfo) ServerChannelSink.vJGefXnTxstr50fSqC1();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 20 : 3;
                continue;
              case 8:
                cultureInfo2 = (CultureInfo) ServerChannelSink.AcBuYVnXKPJkQHFGmyL((object) ServerChannelSink.Ob1fIDnS9t1rHbiKkLo((object) requestHeaders, ServerChannelSink.Rri1kknVcfi3DfnRYN5(1051802738 - -1831968059 ^ -1411203081)).ToString());
                num3 = 22;
                continue;
              case 9:
                flag = true;
                num3 = 25;
                continue;
              case 10:
                goto label_16;
              case 11:
              case 13:
                string version2 = (string) ServerChannelSink.Ob1fIDnS9t1rHbiKkLo((object) requestHeaders, ServerChannelSink.Rri1kknVcfi3DfnRYN5(589593376 ^ -1977315327 ^ -1459581673));
                if (!string.IsNullOrEmpty(version2))
                {
                  Version version3 = new Version(version2);
                  version1 = VersionInfo.GetVersion<EleWise.ELMA.SR>();
                  Version version4 = version1;
                  if (!ServerChannelSink.Bp1LDgnRaDjtq1aZdPW((object) version3, (object) version4))
                  {
                    num3 = 36;
                    continue;
                  }
                  goto label_16;
                }
                else
                  goto label_82;
              case 12:
                if (ServerChannelSink.Q7g87xnnN6hJXsOqWRA(ServerChannelSink.WmZk6mnkAk1mH2HtDmp((object) cultureInfo1), ServerChannelSink.WmZk6mnkAk1mH2HtDmp((object) cultureInfo2), StringComparison.OrdinalIgnoreCase))
                {
                  num3 = 19;
                  continue;
                }
                goto case 26;
              case 14:
              case 19:
              case 33:
                if (ServerChannelSink.Ob1fIDnS9t1rHbiKkLo((object) requestHeaders, ServerChannelSink.Rri1kknVcfi3DfnRYN5(92412609 - 1050237057 ^ -957831986)) != null)
                {
                  num3 = 27;
                  continue;
                }
                goto case 2;
              case 15:
                contextSessionOwner = (CallContextSessionOwner) ServerChannelSink.LFg4ECn6t3T8jQYOrrO();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 23 : 9;
                continue;
              case 16:
                if (requestHeaders[ServerChannelSink.Rri1kknVcfi3DfnRYN5(-1120607109 - 305487170 ^ -1426071197)] == null)
                {
                  num3 = 17;
                  continue;
                }
                goto case 8;
              case 18:
                str2 = (string) ServerChannelSink.NcnW4PnNHbqfXWHXYZj((object) Encoding.UTF8, ServerChannelSink.yrQWUen1UnFEZYIItVr((object) (string) requestHeaders[ServerChannelSink.Rri1kknVcfi3DfnRYN5(1021410165 ^ 1021386145)]));
                num3 = 32;
                continue;
              case 20:
              case 25:
                if (cultureInfo2 == null)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 17 : 33;
                  continue;
                }
                goto case 12;
              case 21:
                contextSessionOwner = CallContextSessionOwner.Create();
                num3 = 37;
                continue;
              case 22:
                if (cultureInfo2 != null)
                {
                  num4 = 9;
                  break;
                }
                goto case 20;
              case 23:
                try
                {
                  user = (IUser) ServerChannelSink.pLCdoHnHrcFjjJfmuRP((object) Locator.GetServiceNotNull<IAuthenticationTokenService>(), token);
                  int num6 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
                    num6 = 0;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        ServerChannelSink.aQ4FQRnwcekNIBtg66a((object) Locator.GetServiceNotNull<IAuthenticationService>(), (object) user);
                        num6 = 2;
                        continue;
                      case 2:
                        goto label_78;
                      case 3:
                        goto label_66;
                      default:
                        if (user != null)
                        {
                          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 1;
                          continue;
                        }
                        goto label_66;
                    }
                  }
label_66:
                  throw new AuthenticationException(EleWise.ELMA.SR.T((string) ServerChannelSink.Rri1kknVcfi3DfnRYN5(1514961705 ^ 1514934727)));
                }
                finally
                {
                  if (contextSessionOwner != null)
                  {
                    int num7 = 1;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
                      num7 = 1;
                    while (true)
                    {
                      switch (num7)
                      {
                        case 1:
                          contextSessionOwner.Dispose();
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_75;
                      }
                    }
                  }
label_75:;
                }
              case 24:
                goto label_14;
              case 26:
                cultureInfo1 = cultureInfo2;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 35 : 9;
                continue;
              case 27:
                guid2 = new Guid((string) ServerChannelSink.Ob1fIDnS9t1rHbiKkLo((object) requestHeaders, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858877649)));
                goto label_86;
              case 28:
                str1 = (string) ServerChannelSink.NcnW4PnNHbqfXWHXYZj(ServerChannelSink.JbEcYDnPmspFxChKglN(), ServerChannelSink.yrQWUen1UnFEZYIItVr((object) (string) ServerChannelSink.Ob1fIDnS9t1rHbiKkLo((object) requestHeaders, ServerChannelSink.Rri1kknVcfi3DfnRYN5(-342626196 - 1290888215 ^ -1633490181))));
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 18 : 0;
                continue;
              case 29:
                flag = false;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 16 : 3;
                continue;
              case 30:
                goto label_59;
              case 31:
                goto label_2;
              case 32:
                if (str1 != null)
                {
                  num3 = 21;
                  continue;
                }
                goto label_61;
              case 34:
label_78:
                ServerChannelSink.WBZZkOnAfYP4iOZ85FQ((object) sinkStack, (object) this, (object) null);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 1;
                continue;
              case 35:
                ServerChannelSink.je8R1nnOvd2jdkRX9LL(ServerChannelSink.lSdZDnnqihADkH9AGpD(), (object) cultureInfo2);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
                continue;
              case 36:
                cultureInfo1 = (CultureInfo) ServerChannelSink.SygmHBnKlVeLVEqW5Mt(ServerChannelSink.lSdZDnnqihADkH9AGpD());
                num4 = 5;
                break;
              case 37:
                try
                {
                  IMembershipService serviceNotNull = Locator.GetServiceNotNull<IMembershipService>();
                  string userNameOrEmail = str1;
                  string str3 = str2;
                  string password = str3 == null ? string.Empty : str3;
                  user = serviceNotNull.ValidateUser(userNameOrEmail, password);
                  if (user == null)
                    throw new AuthenticationException((string) ServerChannelSink.bEB90MniN9cESnLTMWA(ServerChannelSink.Rri1kknVcfi3DfnRYN5(1917256330 ^ 1917282458)));
                  if (!flag && !ServerChannelSink.KBrXtJn3GOuOnmeHVcn((object) user.Lang))
                  {
                    cultureInfo2 = (CultureInfo) ServerChannelSink.AcBuYVnXKPJkQHFGmyL(ServerChannelSink.HhUbgAnpwe1NCiWHtN7((object) user));
                    if (cultureInfo2 != null && !ServerChannelSink.Q7g87xnnN6hJXsOqWRA((object) cultureInfo1.Name, ServerChannelSink.WmZk6mnkAk1mH2HtDmp((object) cultureInfo2), StringComparison.OrdinalIgnoreCase))
                    {
                      ServerChannelSink.je8R1nnOvd2jdkRX9LL(ServerChannelSink.lSdZDnnqihADkH9AGpD(), (object) cultureInfo2);
                      ServerChannelSink.xbab6BnaDj63H5KhNse((object) Thread.CurrentThread, (object) CultureInfo.CreateSpecificCulture(cultureInfo2.Name));
                    }
                  }
                  guid1 = ServerChannelSink.DyG76anDtLOIbLeoUva((object) Locator.GetServiceNotNull<ISecurityService>(), (object) user, (object) CommonPermissions.DesignerAccessPermission) ? Locator.GetServiceNotNull<IAuthenticationTokenService>().CreateToken(user) : throw new SecurityException((string) ServerChannelSink.bEB90MniN9cESnLTMWA(ServerChannelSink.Rri1kknVcfi3DfnRYN5(-740338220 ^ -740343928)));
                  if (ServerChannelSink.LKS0qWneMZCofE6vZ8C(guid1, Guid.Empty))
                    throw new AuthenticationException((string) ServerChannelSink.Rri1kknVcfi3DfnRYN5(1319452732 ^ 1319447182));
                  ServerChannelSink.cC1aeHntdJaya5YNrUo((object) serviceNotNull, user.GetId());
                  int num8 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
                    num8 = 1;
                  while (true)
                  {
                    switch (num8)
                    {
                      case 1:
                        ServerChannelSink.aQ4FQRnwcekNIBtg66a((object) Locator.GetServiceNotNull<IAuthenticationService>(), (object) user);
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_78;
                    }
                  }
                }
                finally
                {
                  if (contextSessionOwner != null)
                  {
                    int num9 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
                      num9 = 1;
                    while (true)
                    {
                      switch (num9)
                      {
                        case 1:
                          ServerChannelSink.XPT60hn4ACnYAccKFmm((object) contextSessionOwner);
                          num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_41;
                      }
                    }
                  }
label_41:;
                }
              default:
                ((Thread) ServerChannelSink.lSdZDnnqihADkH9AGpD()).CurrentCulture = (CultureInfo) ServerChannelSink.L64WBpn27YIkChJ6vTP(ServerChannelSink.WmZk6mnkAk1mH2HtDmp((object) cultureInfo2));
                num3 = 14;
                continue;
            }
            num3 = num4;
            continue;
label_86:
            token = guid2;
            num3 = 4;
          }
label_16:
          throw new IncompatibleVersionException(EleWise.ELMA.SR.T((string) ServerChannelSink.Rri1kknVcfi3DfnRYN5(-1852837372 ^ -1852859550), (object) version1));
label_59:
          throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876039801));
label_61:
          throw new AuthenticationException(EleWise.ELMA.SR.T((string) ServerChannelSink.Rri1kknVcfi3DfnRYN5(87862435 ^ 87868789)));
label_82:
          throw new IncompatibleVersionException((string) ServerChannelSink.bEB90MniN9cESnLTMWA(ServerChannelSink.Rri1kknVcfi3DfnRYN5(1319452732 ^ 1319446734)));
label_14:
          ServerChannelSink.vW5HISnIDZ85lUhJnAS(ServerChannelSink.BU3CCQnuJu9kjSFZXYH(), true);
          num3 = 11;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
          {
            num3 = 1;
            goto label_12;
          }
          else
            goto label_12;
        }
        catch (Exception ex)
        {
          int num10 = 2;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
            num10 = 2;
          while (true)
          {
            Exception exception;
            switch (num10)
            {
              case 1:
                ServerChannelSink.WUlanwnxT1gTZvdHmEC((object) responseHeaders, ServerChannelSink.Rri1kknVcfi3DfnRYN5(-345420348 ^ -345429480), (object) ((string) ServerChannelSink.QdVQ6AnyDRGlY7bqYOK((object) exception)).ToBase64String());
                num10 = 5;
                continue;
              case 2:
                Logger.Log.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951492068), ex);
                num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 3 : 0;
                continue;
              case 3:
                if (responseHeaders != null)
                {
                  num10 = 7;
                  continue;
                }
                break;
              case 4:
                ServerChannelSink.WUlanwnxT1gTZvdHmEC((object) responseHeaders, ServerChannelSink.Rri1kknVcfi3DfnRYN5(1021410165 ^ 1021385945), ServerChannelSink.vvGnsGnmAKSOpith6fy((object) exception.GetType()));
                num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 1;
                continue;
              case 5:
                serverProcessing = ServerProcessing.Complete;
                num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 6 : 2;
                continue;
              case 6:
                goto label_2;
              case 7:
              case 8:
                exception = this.UnwrapException(ex);
                num10 = 4;
                continue;
            }
            responseHeaders = (ITransportHeaders) new TransportHeaders();
            num10 = 8;
          }
        }
      }
      finally
      {
        if (disposable != null)
        {
          int num11 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
            num11 = 1;
          while (true)
          {
            switch (num11)
            {
              case 1:
                ServerChannelSink.XPT60hn4ACnYAccKFmm((object) disposable);
                num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
                continue;
              default:
                goto label_109;
            }
          }
        }
label_109:;
      }
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
            ServerChannelSink.CrwP95nMG4XFeaexqha((object) sinkStack, (object) msg, (object) headers, (object) stream);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
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

    private Exception UnwrapException(Exception ex)
    {
      int num = 1;
      TargetInvocationException invocationException;
      while (true)
      {
        switch (num)
        {
          case 1:
            invocationException = ex as TargetInvocationException;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          case 3:
            if (ServerChannelSink.JF6lrZnJphW86GIUNkM((object) invocationException) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 2 : 2;
              continue;
            }
            goto label_5;
          case 4:
            goto label_5;
          default:
            if (invocationException == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 4 : 3;
              continue;
            }
            goto case 3;
        }
      }
label_4:
      return this.UnwrapException(invocationException.InnerException);
label_5:
      return ex;
    }

    internal static void fVTNdQnvjxQcsZX6Zex() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool OpIuNUnQhLlaiuHTm8H() => ServerChannelSink.PXduOKnftfiov8BBAlM == null;

    internal static ServerChannelSink c6T75vnCqpxwFq1TeeA() => ServerChannelSink.PXduOKnftfiov8BBAlM;

    internal static object xFRMAxn8BNc6tR8SJUD() => (object) ELMAContext.Create();

    internal static bool f1AMxsnZMRv4QsvWtVc() => Locator.Initialized;

    internal static object BU3CCQnuJu9kjSFZXYH() => (object) TranslateService.Instance;

    internal static void vW5HISnIDZ85lUhJnAS([In] object obj0, bool value) => ((TranslateService) obj0).InLineDisabled = value;

    internal static object Rri1kknVcfi3DfnRYN5(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Ob1fIDnS9t1rHbiKkLo([In] object obj0, [In] object obj1) => ((ITransportHeaders) obj0)[obj1];

    internal static object bEB90MniN9cESnLTMWA([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool Bp1LDgnRaDjtq1aZdPW([In] object obj0, [In] object obj1) => (Version) obj0 != (Version) obj1;

    internal static object lSdZDnnqihADkH9AGpD() => (object) Thread.CurrentThread;

    internal static object SygmHBnKlVeLVEqW5Mt([In] object obj0) => (object) ((Thread) obj0).CurrentCulture;

    internal static object AcBuYVnXKPJkQHFGmyL([In] object obj0) => (object) EleWise.ELMA.SR.GetCultureByName((string) obj0);

    internal static object vJGefXnTxstr50fSqC1() => (object) EleWise.ELMA.SR.GetDefaultCulture();

    internal static object WmZk6mnkAk1mH2HtDmp([In] object obj0) => (object) ((CultureInfo) obj0).Name;

    internal static bool Q7g87xnnN6hJXsOqWRA([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);

    internal static void je8R1nnOvd2jdkRX9LL([In] object obj0, [In] object obj1) => ((Thread) obj0).CurrentUICulture = (CultureInfo) obj1;

    internal static object L64WBpn27YIkChJ6vTP([In] object obj0) => (object) CultureInfo.CreateSpecificCulture((string) obj0);

    internal static bool LKS0qWneMZCofE6vZ8C([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object JbEcYDnPmspFxChKglN() => (object) Encoding.UTF8;

    internal static object yrQWUen1UnFEZYIItVr([In] object obj0) => (object) Convert.FromBase64String((string) obj0);

    internal static object NcnW4PnNHbqfXWHXYZj([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetString((byte[]) obj1);

    internal static bool KBrXtJn3GOuOnmeHVcn([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object HhUbgAnpwe1NCiWHtN7([In] object obj0) => (object) ((IUser) obj0).Lang;

    internal static void xbab6BnaDj63H5KhNse([In] object obj0, [In] object obj1) => ((Thread) obj0).CurrentCulture = (CultureInfo) obj1;

    internal static bool DyG76anDtLOIbLeoUva([In] object obj0, [In] object obj1, [In] object obj2) => ((ISecurityService) obj0).HasPermission((IUser) obj1, (Permission) obj2);

    internal static void cC1aeHntdJaya5YNrUo([In] object obj0, [In] object obj1) => ((IMembershipService) obj0).CheckRequireChangePassword(obj1);

    internal static void aQ4FQRnwcekNIBtg66a([In] object obj0, [In] object obj1) => ((IAuthenticationService) obj0).SetAuthenticatedUserForRequest((IUser) obj1);

    internal static void XPT60hn4ACnYAccKFmm([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object LFg4ECn6t3T8jQYOrrO() => (object) CallContextSessionOwner.Create();

    internal static object pLCdoHnHrcFjjJfmuRP([In] object obj0, Guid token) => (object) ((IAuthenticationTokenService) obj0).GetUser(token);

    internal static void WBZZkOnAfYP4iOZ85FQ([In] object obj0, [In] object obj1, [In] object obj2) => ((IServerChannelSinkStack) obj0).Push((IServerChannelSink) obj1, obj2);

    internal static bool wO0OJqn7jn9oOct2iCc([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static void WUlanwnxT1gTZvdHmEC([In] object obj0, [In] object obj1, [In] object obj2) => ((ITransportHeaders) obj0)[obj1] = obj2;

    internal static object vBrt4jn019c1clGcYfi([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static object vvGnsGnmAKSOpith6fy([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object QdVQ6AnyDRGlY7bqYOK([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static void CrwP95nMG4XFeaexqha([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((IServerResponseChannelSinkStack) obj0).AsyncProcessResponse((IMessage) obj1, (ITransportHeaders) obj2, (Stream) obj3);

    internal static object JF6lrZnJphW86GIUNkM([In] object obj0) => (object) ((Exception) obj0).InnerException;
  }
}
