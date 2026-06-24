// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Remoting.RemoteServiceProxyBuilder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Castle.DynamicProxy;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security.Authentication;

namespace EleWise.ELMA.Remoting
{
  /// <summary>
  /// Построитель прокси-объекта для Remoting-сервиса на стороне клиента
  /// </summary>
  /// <remarks>
  /// Прокси нужен, чтобы отслеживать перезапуск сервера.
  /// В этом случае осуществляется попытка автоматического переподключения.
  /// Также отслеживаются ошибки авторизации.
  /// </remarks>
  public static class RemoteServiceProxyBuilder
  {
    private static RemoteServiceProxyBuilder vG5YDhX5Xep79T84fjd;

    /// <summary>Построить прокси-обертку для сервиса</summary>
    /// <param name="service">Сервис</param>
    /// <param name="interfaces">Интерфейсы сервиса</param>
    /// <returns>Прокси-обертка</returns>
    public static object Build(object service, Type[] interfaces)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      ProxyGenerator proxyGenerator = new ProxyGenerator();
      Type firstIntf = ((IEnumerable<Type>) interfaces).First<Type>();
      // ISSUE: reference to a compiler-generated method
      List<Type> list = ((IEnumerable<Type>) interfaces).Where<Type>((Func<Type, bool>) (i => RemoteServiceProxyBuilder.\u003C\u003Ec__DisplayClass0_0.FfSVJ0f0trZQa9tkHN0t(i, firstIntf))).ToList<Type>();
      return Activator.CreateInstance(RemoteServiceProxyBuilder.bPEKYYXU8muoq91iQgT((object) proxyGenerator.ProxyBuilder, firstIntf, RemoteServiceProxyBuilder.RnesKyXLOFtxBeQTjnF((object) list), (object) new ProxyGenerationOptions()), (object) new IInterceptor[1]
      {
        (IInterceptor) new RemoteServiceProxyBuilder.Interceptor(service)
      }, null);
    }

    internal static object RnesKyXLOFtxBeQTjnF([In] object obj0) => (object) ((List<Type>) obj0).ToArray();

    internal static Type bPEKYYXU8muoq91iQgT([In] object obj0, [In] Type obj1, [In] object obj2, [In] object obj3) => ((IProxyBuilder) obj0).CreateInterfaceProxyTypeWithoutTarget(obj1, (Type[]) obj2, (ProxyGenerationOptions) obj3);

    internal static bool SVxSu8Xj1JuhpKhXt5S() => RemoteServiceProxyBuilder.vG5YDhX5Xep79T84fjd == null;

    internal static RemoteServiceProxyBuilder Go0lysXYAnvjHc3qFgN() => RemoteServiceProxyBuilder.vG5YDhX5Xep79T84fjd;

    /// <summary>
    /// Перехватчик вызовов прокси-объекта для Remoting-сервиса
    /// </summary>
    internal class Interceptor : IInterceptor
    {
      private object service;
      internal static RemoteServiceProxyBuilder.Interceptor T26iKrf0S1DLvrtXGqcA;

      /// <summary>Ctor</summary>
      /// <param name="service">Реализация сервиса</param>
      public Interceptor(object service)
      {
        RemoteServiceProxyBuilder.Interceptor.HW76Gbf0qZ5rTJh3mO5R();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.service = service;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 1;
              continue;
          }
        }
label_3:;
      }

      /// <summary>Реализация сервиса</summary>
      public object Service
      {
        get => this.service;
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
                this.service = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
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

      /// <summary>Вызов метода сервиса</summary>
      /// <param name="invocation"></param>
      public void Intercept(IInvocation invocation)
      {
        switch (1)
        {
          case 1:
            try
            {
              RemoteServiceProxyBuilder.Interceptor.D7Nujmf0XsFNdKrugfAB((object) invocation, RemoteServiceProxyBuilder.Interceptor.prrlb8f0KSrGsLn3Vrc6((object) invocation.Method, this.service, (object) invocation.Arguments));
              int num = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
                num = 0;
              switch (num)
              {
                case 0:
                  return;
                default:
                  return;
              }
            }
            catch (Exception ex)
            {
              int num = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
                num = 0;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    goto label_1;
                  default:
                    this.ProcessMainException(invocation, this.UnwrapException(ex));
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 1;
                    continue;
                }
              }
label_1:
              break;
            }
        }
      }

      private void ProcessMainException(IInvocation invocation, Exception ex)
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!(ex is SocketException))
              {
                if (ex is AuthenticationException)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 6 : 0;
                  continue;
                }
                goto label_8;
              }
              else
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 2 : 7;
                continue;
              }
            case 2:
              if (ex is RemotingException)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
                continue;
              }
              goto case 1;
            case 3:
              if (!(ex is WebException))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 2 : 0;
                continue;
              }
              break;
            case 4:
              goto label_9;
            case 5:
              goto label_2;
            case 6:
              this.ProcessAuthenticationError(invocation, ex, false);
              num = 5;
              continue;
          }
          this.ProcessNetworkError(invocation, ex);
          num = 4;
        }
label_9:
        return;
label_2:
        return;
label_8:
        throw ex;
      }

      private Exception CreateNetworkException(Exception innerException) => (Exception) new RemotingException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979652648)), innerException);

      private void ProcessNetworkError(IInvocation invocation, Exception ex)
      {
        int num1 = 2;
        RemoteServiceProvider service;
        while (true)
        {
          switch (num1)
          {
            case 1:
              if (RemoteServiceProxyBuilder.Interceptor.cYMwpWf0kHPRLShXLT8g())
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 1 : 7;
                continue;
              }
              goto label_3;
            case 2:
              RemoteServiceProxyBuilder.Interceptor.agSXLsf0TStARAwpYeU4((object) Logger.Log, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957504434), (object) ex);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_27;
            case 4:
              if (service != null)
              {
                num1 = 5;
                continue;
              }
              goto label_5;
            case 5:
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
              continue;
            case 6:
              goto label_3;
            case 7:
              service = Locator.GetService<RemoteServiceProvider>();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 4;
              continue;
            case 8:
              goto label_5;
            default:
              goto label_7;
          }
        }
label_27:
        return;
label_3:
        throw this.CreateNetworkException(ex);
label_5:
        throw this.CreateNetworkException(ex);
label_7:
        try
        {
          int num2;
          if (RemotingClientSecurityContext.Current != null)
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
          else
            goto label_11;
label_10:
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_24;
              case 2:
                RemoteServiceProxyBuilder.Interceptor.D7Nujmf0XsFNdKrugfAB((object) invocation, ((MethodBase) RemoteServiceProxyBuilder.Interceptor.gFyrASf02Mtteq45u4hs((object) invocation)).Invoke(this.service, (object[]) RemoteServiceProxyBuilder.Interceptor.NNPBQQf0eUCAXyHMaVLC((object) invocation)));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
                continue;
              case 3:
                goto label_11;
              default:
                RemoteServiceProxyBuilder.Interceptor.Tbyn1uf0nN5oVoQmfdRo((object) RemotingClientSecurityContext.Current, Guid.Empty);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 3 : 1;
                continue;
            }
          }
label_24:
          return;
label_11:
          RemoteServiceProxyBuilder.Interceptor.AsPEdef0OAhwJINc8FAc((object) service);
          num2 = 2;
          goto label_10;
        }
        catch (Exception ex1)
        {
          int num3 = 2;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0)
            num3 = 4;
          Exception ex2;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_22;
              case 2:
              case 3:
                goto label_23;
              case 4:
                ex2 = this.UnwrapException(ex1);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 6 : 1;
                continue;
              case 5:
                this.ProcessAuthenticationError(invocation, ex2, true);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 0;
                continue;
              case 6:
                this.ThrowIfNetworkException(invocation, ex2);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
                continue;
              default:
                if (!(ex2 is AuthenticationException))
                {
                  num3 = 3;
                  continue;
                }
                goto case 5;
            }
          }
label_22:
          return;
label_23:
          throw;
        }
      }

      private void ThrowIfNetworkException(IInvocation invocation, Exception ex)
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
            case 2:
            case 4:
              RemoteServiceProxyBuilder.Interceptor.agSXLsf0TStARAwpYeU4(RemoteServiceProxyBuilder.Interceptor.LksQ1mf0PO73QPEtxtEL(), RemoteServiceProxyBuilder.Interceptor.zfSEW8f01KNpZgNvCRvL(-1426456882 ^ 2009939514 ^ -583948624), (object) ex);
              num = 6;
              continue;
            case 3:
              if (ex is WebException)
              {
                num = 2;
                continue;
              }
              goto case 5;
            case 5:
              if (ex is RemotingException)
              {
                num = 4;
                continue;
              }
              break;
            case 6:
              goto label_10;
          }
          if (ex is SocketException)
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 1;
          else
            break;
        }
        return;
label_10:
        throw this.CreateNetworkException(ex);
      }

      private void ProcessAuthenticationError(
        IInvocation invocation,
        Exception ex,
        bool showLoginDialog)
      {
        int num1 = 13;
        RemoteServiceProvider service;
        while (true)
        {
          switch (num1)
          {
            case 1:
              if (!showLoginDialog)
              {
                num1 = 2;
                continue;
              }
              goto case 5;
            case 2:
            case 6:
              num1 = 4;
              continue;
            case 3:
              if (service != null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 1;
                continue;
              }
              goto label_25;
            case 4:
              goto label_3;
            case 5:
              if (!service.DisableLoginScreen)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 7:
              goto label_25;
            case 8:
              goto label_29;
            case 9:
              if (RemotingConfigurator.ShowLoginDialog())
              {
                num1 = 6;
                continue;
              }
              goto label_30;
            case 10:
              goto label_40;
            case 11:
              goto label_30;
            case 12:
              if (!RemoteServiceProxyBuilder.Interceptor.cYMwpWf0kHPRLShXLT8g())
              {
                num1 = 10;
                continue;
              }
              service = Locator.GetService<RemoteServiceProvider>();
              num1 = 3;
              continue;
            case 13:
              ((ILogger) RemoteServiceProxyBuilder.Interceptor.LksQ1mf0PO73QPEtxtEL()).Warn(RemoteServiceProxyBuilder.Interceptor.zfSEW8f01KNpZgNvCRvL(-2106517564 ^ -2106297934), ex);
              num1 = 12;
              continue;
            default:
              if (RemotingConfigurator.ShowLoginDialog != null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 9 : 9;
                continue;
              }
              goto label_30;
          }
        }
label_29:
        return;
label_3:
        try
        {
          int num2;
          if (RemotingClientSecurityContext.Current != null)
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 1;
          else
            goto label_8;
label_5:
          while (true)
          {
            switch (num2)
            {
              case 1:
                RemoteServiceProxyBuilder.Interceptor.Tbyn1uf0nN5oVoQmfdRo((object) RemotingClientSecurityContext.Current, Guid.Empty);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 2 : 2;
                continue;
              case 2:
                goto label_8;
              case 3:
                goto label_28;
              default:
                invocation.ReturnValue = RemoteServiceProxyBuilder.Interceptor.prrlb8f0KSrGsLn3Vrc6((object) invocation.Method, this.service, RemoteServiceProxyBuilder.Interceptor.NNPBQQf0eUCAXyHMaVLC((object) invocation));
                num2 = 3;
                continue;
            }
          }
label_28:
          return;
label_8:
          RemoteServiceProxyBuilder.Interceptor.AsPEdef0OAhwJINc8FAc((object) service);
          num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
          {
            num2 = 0;
            goto label_5;
          }
          else
            goto label_5;
        }
        catch (Exception ex1)
        {
          int num3 = 2;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
            num3 = 0;
          Exception ex2;
          while (true)
          {
            switch (num3)
            {
              case 0:
                goto label_22;
              case 1:
              case 5:
                goto label_20;
              case 2:
                ex2 = this.UnwrapException(ex1);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 5 : 7;
                continue;
              case 3:
                if (ex2 is AuthenticationException)
                {
                  num3 = 4;
                  continue;
                }
                goto label_20;
              case 4:
                this.ProcessAuthenticationError(invocation, ex2, true);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
                continue;
              case 6:
                if (showLoginDialog)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 1 : 0;
                  continue;
                }
                goto case 3;
              case 7:
                this.ThrowIfNetworkException(invocation, ex2);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 6 : 6;
                continue;
              default:
                goto label_21;
            }
          }
label_22:
          return;
label_21:
          return;
label_20:
          throw;
        }
label_25:
        throw ex;
label_30:
        throw ex;
label_40:
        throw ex;
      }

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            case 3:
              if (RemoteServiceProxyBuilder.Interceptor.Rs5SEif0N0FiVAJMJOoI((object) invocationException) != null)
              {
                num = 4;
                continue;
              }
              goto label_3;
            case 4:
              goto label_2;
            default:
              if (invocationException == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 2 : 0;
                continue;
              }
              goto case 3;
          }
        }
label_2:
        return this.UnwrapException((Exception) RemoteServiceProxyBuilder.Interceptor.Rs5SEif0N0FiVAJMJOoI((object) invocationException));
label_3:
        return ex;
      }

      internal static void HW76Gbf0qZ5rTJh3mO5R() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool SxwaXjf0i3f5E0qqooL5() => RemoteServiceProxyBuilder.Interceptor.T26iKrf0S1DLvrtXGqcA == null;

      internal static RemoteServiceProxyBuilder.Interceptor wrCsmZf0R5YPjMVLBDeq() => RemoteServiceProxyBuilder.Interceptor.T26iKrf0S1DLvrtXGqcA;

      internal static object prrlb8f0KSrGsLn3Vrc6([In] object obj0, [In] object obj1, [In] object obj2) => ((MethodBase) obj0).Invoke(obj1, (object[]) obj2);

      internal static void D7Nujmf0XsFNdKrugfAB([In] object obj0, [In] object obj1) => ((IInvocation) obj0).ReturnValue = obj1;

      internal static void agSXLsf0TStARAwpYeU4([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Warn(obj1, (Exception) obj2);

      internal static bool cYMwpWf0kHPRLShXLT8g() => Locator.Initialized;

      internal static void Tbyn1uf0nN5oVoQmfdRo([In] object obj0, Guid value) => ((RemotingClientSecurityContext) obj0).Token = value;

      internal static void AsPEdef0OAhwJINc8FAc([In] object obj0) => ((RemoteServiceProvider) obj0).Reconnect();

      internal static object gFyrASf02Mtteq45u4hs([In] object obj0) => (object) ((IInvocation) obj0).Method;

      internal static object NNPBQQf0eUCAXyHMaVLC([In] object obj0) => (object) ((IInvocation) obj0).Arguments;

      internal static object LksQ1mf0PO73QPEtxtEL() => (object) Logger.Log;

      internal static object zfSEW8f01KNpZgNvCRvL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object Rs5SEif0N0FiVAJMJOoI([In] object obj0) => (object) ((Exception) obj0).InnerException;
    }
  }
}
