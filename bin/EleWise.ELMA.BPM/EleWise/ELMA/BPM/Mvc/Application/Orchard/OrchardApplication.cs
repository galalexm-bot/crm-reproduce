// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPM.Mvc.Application.Orchard.OrchardApplication
// Assembly: EleWise.ELMA.BPM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EE1B80B5-F464-4FFF-85CF-6A69B66F676D
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.BPM.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.BPM.xml

using Autofac.Integration.Web;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Rebranding;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Telerik;
using EleWise.ELMA.Web.Orchard.Mvc.ViewEngines.Razor;
using EleWise.ELMA.Web.Service;
using NHibernate;
using Orchard;
using Orchard.Environment;
using Orchard.Mvc;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Routing;

namespace EleWise.ELMA.BPM.Mvc.Application.Orchard
{
  /// <summary>Main Web Application</summary>
  public class OrchardApplication : HttpApplication, IContainerProviderAccessor
  {
    private static ViewEngineCollection _errorPageViewEngines;
    private static OrchardApplication RV59KlVhrRdNJPFM3QU;

    /// <summary>Инициализировано ли приложение</summary>
    public static bool Initialized => OrchardApplication.GpWijDVmQhNJtBYHvAd();

    /// <summary>Текст ошибки при запуске приложения</summary>
    public static string StartupExceptionText => (string) OrchardApplication.yanULUVRBstqYp0bOgA();

    /// <summary>Провайдер контейнера Autofac</summary>
    public IContainerProvider ContainerProvider => ELMAEnviromentStarter.ContainerProvider;

    /// <summary>Возвращает страницу с бэкапом</summary>
    public static string MakeBackupPage => (string) OrchardApplication.rwAs0gVDEfiFL35YQTG(1024791542 << 4 ^ -783207156);

    /// <summary>Страница "Повторить проверку"</summary>
    public static string PrerequisitesPage => (string) OrchardApplication.rwAs0gVDEfiFL35YQTG(1735661122 >> 2 ^ 433917726);

    /// <summary>
    /// Страница "Требуется исправить сценарии в объектах в дизайнере"
    /// </summary>
    public static string ConfigurationScriptsErrorPage => (string) OrchardApplication.rwAs0gVDEfiFL35YQTG(-1998014674 ^ -1998013032);

    /// <summary>
    /// true, если должна использоваться сквозная Windows-авторизация из текущего запроса (без редиректа на внешний SSPI)
    /// </summary>
    protected static bool UseInPlaceWinAuth => WindowsAuthenticationSettings.IsInPlaceWinAuthEnabled();

    /// <summary>Страница активации</summary>
    public static string ActivationPage => (string) OrchardApplication.rwAs0gVDEfiFL35YQTG(~-333395280 ^ 333397945);

    /// <summary>Старт приложения</summary>
    protected void Application_Start()
    {
      int num = 4;
      while (true)
      {
        RemoteCertificateValidationCallback validationCallback;
        switch (num)
        {
          case 0:
            goto label_13;
          case 1:
            OrchardApplication.jNYP75VJ5RVSo59dO0Z();
            num = 7;
            continue;
          case 2:
            ((StartInformation) OrchardApplication.jYGIndVer0fPXUWs7cH()).Status = StartStatus.Running;
            num = 8;
            continue;
          case 3:
            OrchardApplication.d4XDhSV6J8OMjba33tf(false);
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_e241167d2aeb47efaa952914a1d3a235 == 0 ? 9 : 6;
            continue;
          case 4:
            MvcHandler.DisableMvcResponseHeader = true;
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_50d154664afc4b2f8f6da5de661b4a33 != 0 ? 0 : 3;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            validationCallback = OrchardApplication.\u003C\u003Ec.\u003C\u003E9__16_0;
            if (validationCallback == null)
            {
              num = 10;
              continue;
            }
            break;
          case 6:
            AntiForgeryConfig.SuppressXFrameOptionsHeader = true;
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_1eeecee56c2b4f4c8ddb598cc5980193 != 0 ? 8 : 11;
            continue;
          case 7:
            ELMAEnviromentStarter.StartApplication();
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_e241167d2aeb47efaa952914a1d3a235 != 0 ? 0 : 0;
            continue;
          case 8:
            ((StartInformation) OrchardApplication.jYGIndVer0fPXUWs7cH()).SetInfo(0.0, EleWise.ELMA.SR.M((string) OrchardApplication.rwAs0gVDEfiFL35YQTG(2131690852 >> 2 ^ 532923085)));
            num = 6;
            continue;
          case 9:
            OrchardApplication._errorPageViewEngines = new ViewEngineCollection((IList<IViewEngine>) new IViewEngine[1]
            {
              (IViewEngine) new CachedRazorViewEngine()
            });
            num = 2;
            continue;
          case 10:
            // ISSUE: reference to a compiler-generated field
            validationCallback = OrchardApplication.\u003C\u003Ec.\u003C\u003E9__16_0 = (RemoteCertificateValidationCallback) ((sender, certificate, chain, sslPolicyErrors) => true);
            break;
          case 11:
            OrchardApplication.ciKnOGVC2jGl3XIOr6b(SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12);
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_bf3ac584e9344c009585e64487f14994 != 0 ? 5 : 1;
            continue;
          default:
            goto label_2;
        }
        ServicePointManager.ServerCertificateValidationCallback = validationCallback;
        num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_2464724164964761ae144e148281de96 != 0 ? 0 : 1;
      }
label_13:
      return;
label_2:;
    }

    /// <summary>Старт сессии</summary>
    /// <param name="sender">Объект</param>
    /// <param name="e"></param>
    protected void Session_Start(object sender, EventArgs e)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            goto label_7;
          case 2:
            OrchardApplication.hD8UysVpJhoerG3B1vL(OrchardApplication.OvaLuSVI2YSPcvh7E3T(OrchardApplication.W4hJBjVsSkgtSYxiqH4(OrchardApplication.GDvHZqVjeW4hluwoUla((object) this)), OrchardApplication.rwAs0gVDEfiFL35YQTG(-788178853 ^ -788180101)), false);
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_6de5b059e3e943538866ae42d8dba72e != 0 ? 1 : 1;
            continue;
          case 3:
            if (!((HttpRequest) OrchardApplication.wxW28HVOQsogp2CSyeu((object) this)).IsSecureConnection)
            {
              num = 2;
              continue;
            }
            goto case 4;
          case 4:
            OrchardApplication.hD8UysVpJhoerG3B1vL(OrchardApplication.OvaLuSVI2YSPcvh7E3T(OrchardApplication.W4hJBjVsSkgtSYxiqH4(OrchardApplication.GDvHZqVjeW4hluwoUla((object) this)), OrchardApplication.rwAs0gVDEfiFL35YQTG(-488803655 ^ -488801895)), true);
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_9b81d414ebfb4006961c5e16b583c908 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_5:
      return;
label_7:
      return;
label_2:;
    }

    /// <summary>Ошибка старта приложения</summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Application_Error(object sender, EventArgs e)
    {
      int num = 27;
      while (true)
      {
        HttpContext httpContext;
        ViewResult viewResult;
        ControllerContext context;
        HttpException httpException;
        Exception ex;
        switch (num)
        {
          case 0:
            goto label_37;
          case 1:
          case 14:
            OrchardApplication.awap8wyPoaJv8ujdlgK(OrchardApplication.RC37K6yyb7dvoA9OgKM((object) httpContext), OrchardApplication.rwAs0gVDEfiFL35YQTG(-788178853 ^ -788180085));
            num = 13;
            continue;
          case 2:
            goto label_42;
          case 3:
          case 29:
            if (OrchardApplication.PbpZHMVgLE2bqyC2A5K(OrchardApplication.DjRBvBVHgcvHYeK83S0()))
            {
              num = 11;
              continue;
            }
            goto case 15;
          case 4:
            httpException = ex as HttpException;
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_8bb670bf0c514ecb87c6e60e7438e06f != 0 ? 6 : 12;
            continue;
          case 5:
            goto label_32;
          case 6:
            if (!(OrchardApplication.PosUxhyAbHGZxcyJXyC((object) httpContext) is IHasRequestContext))
            {
              num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_c1cf4a7dd0874037bf022e5737b29d28 == 0 ? 2 : 1;
              continue;
            }
            context = new ControllerContext((RequestContext) OrchardApplication.aoQBHCy0mgoWkiN0jLH((object) (IHasRequestContext) OrchardApplication.PosUxhyAbHGZxcyJXyC((object) httpContext)), (ControllerBase) new BPMController());
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_a42be3548a0b4e9e83b37d0bf541ae98 == 0 ? 1 : 18;
            continue;
          case 7:
            if (!OrchardApplication.y6Xl7LVqE4ZKrqmnOf7())
            {
              num = 29;
              continue;
            }
            goto case 17;
          case 8:
            goto label_16;
          case 9:
            ((HttpServerUtility) OrchardApplication.L5pLHVVGHJ3YfJDiBGM((object) this)).Transfer((string) OrchardApplication.rwAs0gVDEfiFL35YQTG(-2029288941 ^ -1405279196 ^ 725003585));
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_1f1bf1fb830545b89c7d7c5edeff1500 != 0 ? 0 : 0;
            continue;
          case 10:
            ((HttpResponse) OrchardApplication.RC37K6yyb7dvoA9OgKM((object) httpContext)).Clear();
            num = 6;
            continue;
          case 11:
            Logger.Log.Error(OrchardApplication.rwAs0gVDEfiFL35YQTG(1940199829 ^ -1444342727 ^ -632551702), (Exception) OrchardApplication.JFLQ1MVzL1EAplWBUUk((object) ex));
            num = 15;
            continue;
          case 12:
            if (httpException != null)
            {
              num = 24;
              continue;
            }
            goto case 19;
          case 13:
            OrchardApplication.Ti1ud5yXndcBt0wKjX0((object) viewResult, (object) OrchardApplication._errorPageViewEngines);
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_740ef59153ff4ad09b1da3c952318a34 != 0 ? 19 : 23;
            continue;
          case 15:
            if (!OrchardApplication.jbR5sSydXjAsB3WRbM4())
            {
              num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_14d3ba5c3cce406d89f5b3bd64118b88 != 0 ? 14 : 25;
              continue;
            }
            break;
          case 16:
            OrchardApplication.FUyHhJy7Xbs7n33xpAK(OrchardApplication.rUTSV5yfRt0Uk8iALam((object) httpContext));
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_fd5d0b0e0b504f3d993007bf914ac481 != 0 ? 3 : 8;
            continue;
          case 17:
            ((DiagnosticsManager) OrchardApplication.Fyo8T2VrLvriGVO4lmw()).WebRequestError((HttpContext) OrchardApplication.qDGHliVQAIsWcEB4hPy((object) this), ex);
            num = 3;
            continue;
          case 18:
            viewResult = new ViewResult();
            num = 4;
            continue;
          case 19:
            OrchardApplication.HsCmY5y5XS0PtAAkbtX((object) viewResult, OrchardApplication.rwAs0gVDEfiFL35YQTG(-894499343 - 376403504 ^ -1270905853));
            num = 14;
            continue;
          case 20:
            OrchardApplication.HsCmY5y5XS0PtAAkbtX((object) viewResult, OrchardApplication.rwAs0gVDEfiFL35YQTG(-1884179472 << 2 ^ 1053213806));
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_e6f08215bca1461baf0a083db17b54f3 != 0 ? 1 : 1;
            continue;
          case 21:
            viewResult.ExecuteResult(context);
            num = 16;
            continue;
          case 22:
            goto label_26;
          case 23:
            ((ViewDataDictionary) OrchardApplication.VXmFQIyUmkGradkUZCl((object) viewResult)).Model = (object) new HandleErrorInfo(ex, (string) OrchardApplication.zgjjQvy82HibnQqr1wJ((object) context.RouteData, OrchardApplication.rwAs0gVDEfiFL35YQTG(-251119897 << 2 ^ -1004480616)), (string) OrchardApplication.zgjjQvy82HibnQqr1wJ(OrchardApplication.hoGn0GyMknRgLSjxNhC((object) context), OrchardApplication.rwAs0gVDEfiFL35YQTG(-918445578 ^ -918442518)));
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_64d949edaec444e99f80ad55ba91e956 != 0 ? 5 : 21;
            continue;
          case 24:
            if (OrchardApplication.JGNbkGyaRTZHMpTXJB4((object) httpException) == 404)
            {
              num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_05dd5584c291425186f18d13c4d42cc8 != 0 ? 1 : 20;
              continue;
            }
            goto case 19;
          case 25:
            if (OrchardApplication.iKxbjxyiLl60cSVC2yB() != null)
            {
              num = 9;
              continue;
            }
            break;
          case 26:
            ex = ((HttpServerUtility) OrchardApplication.L5pLHVVGHJ3YfJDiBGM((object) this)).GetLastError();
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_36272c74e7c649b4a13a370d9d5dd2a1 != 0 ? 7 : 0;
            continue;
          case 27:
            num = 26;
            continue;
          case 28:
            if (!EleWise.ELMA.SR.GetSetting<bool>((string) OrchardApplication.rwAs0gVDEfiFL35YQTG(~-646362130 ^ 646365105)))
            {
              httpContext = (HttpContext) OrchardApplication.SRpNFSyVT2MMJsQWqWn();
              num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_e6f08215bca1461baf0a083db17b54f3 == 0 ? 10 : 8;
              continue;
            }
            num = 22;
            continue;
          default:
            goto label_30;
        }
        IEnumerable<IExceptionIgnoreProvider> extensionPoints = ((ComponentManager) OrchardApplication.Jjfvthyu7hqcB7cX2Zw()).GetExtensionPoints<IExceptionIgnoreProvider>();
        // ISSUE: reference to a compiler-generated field
        Func<IExceptionIgnoreProvider, IEnumerable<Type>> func = OrchardApplication.\u003C\u003Ec.\u003C\u003E9__18_0;
        Func<IExceptionIgnoreProvider, IEnumerable<Type>> selector;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          OrchardApplication.\u003C\u003Ec.\u003C\u003E9__18_0 = selector = (Func<IExceptionIgnoreProvider, IEnumerable<Type>>) (provider => provider.Exceptions);
        }
        else
          goto label_46;
label_44:
        if (!extensionPoints.SelectMany<IExceptionIgnoreProvider, Type>(selector).Any<Type>((Func<Type, bool>) (p => p.IsInstanceOfType((object) ex))))
        {
          num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_11df0b0286bd46b6a8780d914c7488e8 != 0 ? 28 : 15;
          continue;
        }
        goto label_35;
label_46:
        selector = func;
        goto label_44;
      }
label_37:
      return;
label_42:
      return;
label_32:
      return;
label_16:
      return;
label_26:
      return;
label_30:
      return;
label_35:;
    }

    /// <summary>Начало запроса в приложении</summary>
    protected void Application_BeginRequest()
    {
      int num1 = 52;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          IOrchardHost orchardHost;
          ILicenseInfo licenseInfo;
          ILicensedUnit mainLicensedUnit;
          object obj;
          int num3;
          switch (num2)
          {
            case 0:
              goto label_75;
            case 1:
              obj = (object) null;
              goto label_86;
            case 2:
              if (((HttpRequest) OrchardApplication.wxW28HVOQsogp2CSyeu((object) this)).RawUrl.ToLower().StartsWith((string) OrchardApplication.rwAs0gVDEfiFL35YQTG(1383689112 ^ 1383687740)))
              {
                num2 = 57;
                continue;
              }
              goto case 10;
            case 3:
            case 4:
            case 26:
            case 51:
            case 57:
              num3 = 0;
              break;
            case 5:
              if (licenseInfo == null)
              {
                num2 = 23;
                continue;
              }
              goto case 33;
            case 6:
              goto label_63;
            case 7:
              if (!OrchardApplication.y6Xl7LVqE4ZKrqmnOf7())
              {
                num2 = 50;
                continue;
              }
              goto case 28;
            case 8:
              if (!OrchardApplication.QfSLBNy2o3HSiIiXyIC(OrchardApplication.qJxp9eytBGUQRobb42m(OrchardApplication.XwAyW8ynguPdv1EgDGQ(OrchardApplication.wxW28HVOQsogp2CSyeu((object) this))), OrchardApplication.rwAs0gVDEfiFL35YQTG(-94309570 ^ -94306450)))
              {
                num2 = 35;
                continue;
              }
              goto case 3;
            case 9:
            case 50:
              if (orchardHost == null)
              {
                num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_7e0aea3ee18648ebaa860fcd5264d37f != 0 ? 25 : 13;
                continue;
              }
              goto case 22;
            case 10:
              if (!OrchardApplication.QfSLBNy2o3HSiIiXyIC(OrchardApplication.qJxp9eytBGUQRobb42m(OrchardApplication.XwAyW8ynguPdv1EgDGQ(OrchardApplication.wxW28HVOQsogp2CSyeu((object) this))), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1893701021 ^ 680255391 ^ -1481918438)))
              {
                num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_bc1caf7c63e343118488ccfdd03f17f1 != 0 ? 24 : 47;
                continue;
              }
              goto case 3;
            case 11:
              OrchardApplication.fDMpIMyEUxrS2vPDJ38(OrchardApplication.HSc4dtykHWxdmJKhrBm(OrchardApplication.qDGHliVQAIsWcEB4hPy((object) this)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(387711279 ^ 1966154423 ^ 1647127920), (object) orchardHost);
              num2 = 7;
              continue;
            case 12:
              if (!OrchardApplication.TG0XYCyN3ZSMVubvIYS((object) Locator.GetServiceNotNull<IConfigurationScriptsErrorService>()))
              {
                num2 = 27;
                continue;
              }
              goto case 21;
            case 13:
              if (OrchardApplication.QfSLBNy2o3HSiIiXyIC(OrchardApplication.qJxp9eytBGUQRobb42m(OrchardApplication.XwAyW8ynguPdv1EgDGQ(OrchardApplication.wxW28HVOQsogp2CSyeu((object) this))), OrchardApplication.rwAs0gVDEfiFL35YQTG(-1929249797 ^ -1929251023)))
              {
                num2 = 3;
                continue;
              }
              goto case 36;
            case 14:
              goto label_78;
            case 15:
              OrchardApplication.EvouZGyL1iuO0T0V9rA((object) this);
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_a1e2ce46a3c14aecb61f860a8c97e677 != 0 ? 6 : 0;
              continue;
            case 16:
              OrchardApplication.Q9umM5y4AOWyTkllG3y((object) this.Response, OrchardApplication.qi9AsQyTG0MZUKURZqR(OrchardApplication.rwAs0gVDEfiFL35YQTG(1366008131 - 634700387 ^ 731306398), OrchardApplication.tXRTLIyl8JAuToZpyEB(), OrchardApplication.rwAs0gVDEfiFL35YQTG(-696320555 - 201693151 ^ -898012238), OrchardApplication.FjMyn4ybHXNLG3KOucy(OrchardApplication.XwAyW8ynguPdv1EgDGQ(OrchardApplication.wxW28HVOQsogp2CSyeu((object) this)), OrchardApplication.TPW3c4ySSnidEAMwDxg(OrchardApplication.wxW28HVOQsogp2CSyeu((object) this)))), false);
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_a42be3548a0b4e9e83b37d0bf541ae98 == 0 ? 0 : 20;
              continue;
            case 17:
            case 23:
            case 34:
              if (OrchardApplication.rcDDJ1yWPdfsZbXw99A((object) MetadataServiceContext.MetadataRuntimeService))
              {
                num2 = 12;
                continue;
              }
              goto case 21;
            case 18:
              obj = OrchardApplication.M98xN3ywt2xy9kKWivD();
              goto label_86;
            case 19:
              this.CompleteRequest();
              num2 = 56;
              continue;
            case 20:
              OrchardApplication.EvouZGyL1iuO0T0V9rA((object) this);
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_a72bc60a96cc47d38d9a08c9d2375255 == 0 ? 32 : 12;
              continue;
            case 21:
              if (OrchardApplication.jbR5sSydXjAsB3WRbM4())
              {
                num2 = 18;
                continue;
              }
              goto case 1;
            case 22:
              orchardHost.BeginRequest();
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_ba2e33edfd5c4d10910c526ce19c8d72 != 0 ? 0 : 0;
              continue;
            case 24:
              if (!OrchardApplication.QfSLBNy2o3HSiIiXyIC(OrchardApplication.qJxp9eytBGUQRobb42m((object) ((HttpRequest) OrchardApplication.wxW28HVOQsogp2CSyeu((object) this)).RawUrl), OrchardApplication.rwAs0gVDEfiFL35YQTG(1732745317 ^ 1732744447)))
              {
                num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_dc915391d7c84058a674014d8d1edd8c != 0 ? 9 : 13;
                continue;
              }
              goto case 3;
            case 25:
              goto label_57;
            case 27:
              ((HttpResponse) OrchardApplication.GDvHZqVjeW4hluwoUla((object) this)).Redirect((string) OrchardApplication.X5tjVayZjrYoNMQWyI4(OrchardApplication.rwAs0gVDEfiFL35YQTG(-1261809685 ^ -1261811563), OrchardApplication.waefEKyFpNl7LOSODIB()), false);
              num2 = 15;
              continue;
            case 28:
              OrchardApplication.Gbmga6yY3T4t5M4WxPQ(OrchardApplication.Fyo8T2VrLvriGVO4lmw(), (object) this.Context);
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_b7021a7940804dbe80770e0d7373c78c != 0 ? 9 : 3;
              continue;
            case 29:
              ((HttpContext) OrchardApplication.qDGHliVQAIsWcEB4hPy((object) this)).Items[(object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-508321835 ^ -508325525)] = (object) this.Context;
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_f48d22e37b594f439dff2aec8625848e == 0 ? 11 : 7;
              continue;
            case 30:
label_60:
              if (!OrchardApplication.jbR5sSydXjAsB3WRbM4())
              {
                num2 = 40;
                continue;
              }
              if (OrchardApplication.zKodsUyx39QyBefsZPR())
              {
                num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_289810c0c3734c9ab735510ba793157a != 0 ? 42 : 3;
                continue;
              }
              goto case 17;
            case 31:
              goto label_34;
            case 32:
              goto label_53;
            case 33:
              if (OrchardApplication.ntoOEHy98n7BQG5JEmJ((object) licenseInfo) == LicenseStatus.Activated)
              {
                num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_962090912078457cb15ebe6f9b5fadf9 != 0 ? 28 : 34;
                continue;
              }
              goto label_34;
            case 35:
              if (OrchardApplication.QfSLBNy2o3HSiIiXyIC(OrchardApplication.qJxp9eytBGUQRobb42m(OrchardApplication.XwAyW8ynguPdv1EgDGQ(OrchardApplication.wxW28HVOQsogp2CSyeu((object) this))), OrchardApplication.rwAs0gVDEfiFL35YQTG(-1372383459 - 1174808806 ^ 1747771983)))
              {
                num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_cd867fd8e34648a7a62174a6af9dc6dd == 0 ? 0 : 4;
                continue;
              }
              goto case 24;
            case 36:
              if (OrchardApplication.QfSLBNy2o3HSiIiXyIC(OrchardApplication.qJxp9eytBGUQRobb42m(OrchardApplication.XwAyW8ynguPdv1EgDGQ((object) this.Request)), OrchardApplication.rwAs0gVDEfiFL35YQTG(1743907988 ^ -1465399602 ^ -816437412)))
              {
                num2 = 26;
                continue;
              }
              goto case 54;
            case 37:
              if (mainLicensedUnit == null)
              {
                num2 = 17;
                continue;
              }
              goto case 48;
            case 38:
              ((HttpResponse) OrchardApplication.GDvHZqVjeW4hluwoUla((object) this)).Redirect((string) OrchardApplication.rwAs0gVDEfiFL35YQTG(~-646362130 ^ 646361967) + (string) OrchardApplication.hS1D7by3duT0HCb3fen() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1541009453 ^ -1541013097) + (string) OrchardApplication.FjMyn4ybHXNLG3KOucy(OrchardApplication.XwAyW8ynguPdv1EgDGQ(OrchardApplication.wxW28HVOQsogp2CSyeu((object) this)), OrchardApplication.TPW3c4ySSnidEAMwDxg(OrchardApplication.wxW28HVOQsogp2CSyeu((object) this))), false);
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_484aac012cc14f88bba8189db0fd7673 == 0 ? 49 : 20;
              continue;
            case 39:
              OrchardApplication.Q9umM5y4AOWyTkllG3y(OrchardApplication.GDvHZqVjeW4hluwoUla((object) this), OrchardApplication.qi9AsQyTG0MZUKURZqR(OrchardApplication.rwAs0gVDEfiFL35YQTG(1794821756 ^ 1794820354), OrchardApplication.bnEE1DyvP6muiX76n0X(), OrchardApplication.rwAs0gVDEfiFL35YQTG(-1816077962 ^ -1816078542), (object) HttpUtility.UrlEncode((string) OrchardApplication.XwAyW8ynguPdv1EgDGQ(OrchardApplication.wxW28HVOQsogp2CSyeu((object) this)), (Encoding) OrchardApplication.TPW3c4ySSnidEAMwDxg(OrchardApplication.wxW28HVOQsogp2CSyeu((object) this)))), false);
              num2 = 46;
              continue;
            case 40:
              if (OrchardApplication.AYIrnAyK22GJSpqp6kc(OrchardApplication.jYGIndVer0fPXUWs7cH()) != StartStatus.PrerequisitesCheckFault)
              {
                if (((StartInformation) OrchardApplication.jYGIndVer0fPXUWs7cH()).Status == StartStatus.NotActivated)
                {
                  num2 = 16;
                  continue;
                }
                if (OrchardApplication.AYIrnAyK22GJSpqp6kc(OrchardApplication.jYGIndVer0fPXUWs7cH()) == StartStatus.BackupNeeded)
                {
                  num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_f6056d356ee34c899b766b291a16a2b3 != 0 ? 38 : 1;
                  continue;
                }
                goto label_70;
              }
              else
              {
                num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_40efb04ff6e44269a2aef7173a630bc9 == 0 ? 26 : 39;
                continue;
              }
            case 41:
              goto label_66;
            case 42:
              mainLicensedUnit = ((ComponentManager) OrchardApplication.Jjfvthyu7hqcB7cX2Zw()).ModuleManager.MainLicensedUnit;
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_2464724164964761ae144e148281de96 != 0 ? 30 : 37;
              continue;
            case 43:
              num3 = !OrchardApplication.QfSLBNy2o3HSiIiXyIC(OrchardApplication.qJxp9eytBGUQRobb42m(OrchardApplication.XwAyW8ynguPdv1EgDGQ((object) this.Request)), OrchardApplication.rwAs0gVDEfiFL35YQTG(-1230097389 ^ -1230095811)) ? 1 : 0;
              break;
            case 44:
              if (OrchardApplication.QfSLBNy2o3HSiIiXyIC(OrchardApplication.qJxp9eytBGUQRobb42m(OrchardApplication.XwAyW8ynguPdv1EgDGQ(OrchardApplication.wxW28HVOQsogp2CSyeu((object) this))), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1303464861 ^ -1303463655)))
                goto case 3;
              else
                goto label_42;
            case 45:
              if (!OrchardApplication.QfSLBNy2o3HSiIiXyIC(OrchardApplication.qJxp9eytBGUQRobb42m(OrchardApplication.XwAyW8ynguPdv1EgDGQ((object) this.Request)), OrchardApplication.rwAs0gVDEfiFL35YQTG(-105446640 << 2 ^ -421789426)))
              {
                num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_a72bc60a96cc47d38d9a08c9d2375255 == 0 ? 44 : 2;
                continue;
              }
              goto case 3;
            case 46:
              OrchardApplication.EvouZGyL1iuO0T0V9rA((object) this);
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_1eeecee56c2b4f4c8ddb598cc5980193 != 0 ? 46 : 55;
              continue;
            case 47:
              if (!OrchardApplication.QfSLBNy2o3HSiIiXyIC(OrchardApplication.qJxp9eytBGUQRobb42m(OrchardApplication.XwAyW8ynguPdv1EgDGQ((object) this.Request)), OrchardApplication.rwAs0gVDEfiFL35YQTG(~1800431842 ^ -1800431355)))
              {
                num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_7c40ac701de4410b93c2e183fd3d2a4f != 0 ? 43 : 36;
                continue;
              }
              goto case 3;
            case 48:
              licenseInfo = (ILicenseInfo) OrchardApplication.yH8ZjiycrvrK5DMrSk2((object) mainLicensedUnit);
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_558ee6781aad4afebb973927343954e1 != 0 ? 5 : 3;
              continue;
            case 49:
              this.CompleteRequest();
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_05dd5584c291425186f18d13c4d42cc8 == 0 ? 41 : 30;
              continue;
            case 52:
              if (OrchardApplication.QfSLBNy2o3HSiIiXyIC(OrchardApplication.qJxp9eytBGUQRobb42m(OrchardApplication.XwAyW8ynguPdv1EgDGQ(OrchardApplication.wxW28HVOQsogp2CSyeu((object) this))), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(230249011 ^ 230252063)))
              {
                num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_1b033f19d5da41409a3eb4a638228449 != 0 ? 30 : 51;
                continue;
              }
              goto case 8;
            case 53:
              OrchardApplication.EvouZGyL1iuO0T0V9rA((object) this);
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_fd5d0b0e0b504f3d993007bf914ac481 != 0 ? 3 : 14;
              continue;
            case 54:
              if (!OrchardApplication.QfSLBNy2o3HSiIiXyIC((object) ((string) OrchardApplication.XwAyW8ynguPdv1EgDGQ(OrchardApplication.wxW28HVOQsogp2CSyeu((object) this))).ToLower(), OrchardApplication.rwAs0gVDEfiFL35YQTG(834840208 ^ -1029053631 ^ -211072773)))
              {
                num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_e241167d2aeb47efaa952914a1d3a235 != 0 ? 39 : 45;
                continue;
              }
              goto case 3;
            case 55:
              goto label_19;
            case 56:
              goto label_69;
            default:
              goto label_47;
          }
          if (num3 == 0)
          {
            num2 = 21;
            continue;
          }
          goto label_60;
label_86:
          orchardHost = (IOrchardHost) obj;
          num2 = 29;
        }
label_34:
        OrchardApplication.Q9umM5y4AOWyTkllG3y((object) this.Response, OrchardApplication.rwAs0gVDEfiFL35YQTG(1859810385 ^ -816524181 ^ -1584484702), false);
        num1 = 53;
        continue;
label_42:
        num1 = 2;
        continue;
label_70:
        OrchardApplication.Q9umM5y4AOWyTkllG3y((object) this.Response, (object) ((string) OrchardApplication.rwAs0gVDEfiFL35YQTG(-94309570 ^ -94306976) + (string) OrchardApplication.FjMyn4ybHXNLG3KOucy(OrchardApplication.XwAyW8ynguPdv1EgDGQ(OrchardApplication.wxW28HVOQsogp2CSyeu((object) this)), OrchardApplication.TPW3c4ySSnidEAMwDxg(OrchardApplication.wxW28HVOQsogp2CSyeu((object) this)))), false);
        num1 = 19;
      }
label_75:
      return;
label_63:
      return;
label_78:
      return;
label_57:
      return;
label_53:
      return;
label_66:
      return;
label_19:
      return;
label_69:
      return;
label_47:;
    }

    /// <summary>Окончание запроса</summary>
    protected void Application_EndRequest()
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        IOrchardHost orchardHost1;
        while (true)
        {
          HttpContext httpContext;
          IOrchardHost orchardHost2;
          switch (num2)
          {
            case 0:
              goto label_14;
            case 1:
              if (httpContext == null)
              {
                num2 = 8;
                continue;
              }
              orchardHost2 = (IOrchardHost) httpContext.Items[OrchardApplication.rwAs0gVDEfiFL35YQTG(-788178853 ^ -788179277)];
              break;
            case 2:
              httpContext = (HttpContext) ((IDictionary) OrchardApplication.HSc4dtykHWxdmJKhrBm(OrchardApplication.qDGHliVQAIsWcEB4hPy((object) this)))[OrchardApplication.rwAs0gVDEfiFL35YQTG(459505216 ^ 459501822)];
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_aa29a0a33c2e4af7b4d50c14e116e14e != 0 ? 1 : 0;
              continue;
            case 3:
            case 6:
              goto label_5;
            case 4:
              OrchardApplication.kAMHGryhid7T9Ld0eeV(OrchardApplication.Fyo8T2VrLvriGVO4lmw(), OrchardApplication.qDGHliVQAIsWcEB4hPy((object) this));
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_aa54a61f50a144bab587b55f0c6b0d70 != 0 ? 0 : 0;
              continue;
            case 5:
              if (orchardHost1 == null)
              {
                num2 = 3;
                continue;
              }
              goto label_13;
            case 7:
              goto label_13;
            case 8:
              orchardHost2 = (IOrchardHost) null;
              break;
            default:
              goto label_17;
          }
          orchardHost1 = orchardHost2;
          num2 = 5;
        }
label_5:
        if (DiagnosticsManager.Initialized)
        {
          num1 = 4;
          continue;
        }
        goto label_3;
label_13:
        OrchardApplication.BBG9YIyBFYAeFPi9jpV((object) orchardHost1);
        num1 = 6;
      }
label_14:
      return;
label_17:
      return;
label_3:;
    }

    /// <summary>Запрос аутентификации</summary>
    protected void Application_AuthenticateRequest()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (OrchardApplication.T76Cffy1uQQQf8dmirt(OrchardApplication.qDGHliVQAIsWcEB4hPy((object) this)) != null)
            {
              num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_558ee6781aad4afebb973927343954e1 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_8;
          case 3:
            goto label_9;
          case 4:
            OrchardApplication.mo8wfRyDhALMF9MexNC(OrchardApplication.cUXfTkyRWds7AANMTvI(OrchardApplication.H3aZniyorMGeGPItPeI(OrchardApplication.T76Cffy1uQQQf8dmirt(OrchardApplication.qDGHliVQAIsWcEB4hPy((object) this)))));
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_ab8d580240e141e78a71cd5bb0b681e7 == 0 ? 0 : 2;
            continue;
          default:
            if (!OrchardApplication.cQGFrRymcEcCO8VTa6q(OrchardApplication.H3aZniyorMGeGPItPeI(OrchardApplication.T76Cffy1uQQQf8dmirt(OrchardApplication.qDGHliVQAIsWcEB4hPy((object) this)))))
            {
              num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_56d8b8d7dcf34e22b9d74eac50c9d637 != 0 ? 3 : 0;
              continue;
            }
            goto case 4;
        }
      }
label_8:
      return;
label_9:
      return;
label_2:;
    }

    /// <summary>Запрос на получение CultureInfo</summary>
    /// <param name="context">Http контекст</param>
    /// <returns></returns>
    public static CultureInfo GetRequestCultureInfo(HttpContext context = null)
    {
      int num1 = 15;
      CultureInfo requestCultureInfo;
      IUser user;
      while (true)
      {
        switch (num1)
        {
          case 1:
          case 18:
          case 19:
            requestCultureInfo = OrchardApplication.GetCultureFromCookies(context);
            num1 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_687508cbf3c6435893cc34fc10b7ba5c == 0 ? 12 : 13;
            continue;
          case 2:
            goto label_6;
          case 3:
            if (user != null)
            {
              num1 = 16;
              continue;
            }
            goto case 1;
          case 4:
            if (OrchardApplication.osmVCoyejehWMGZSkWF((object) context) != null)
            {
              num1 = 3;
              continue;
            }
            goto case 1;
          case 5:
            context = (HttpContext) OrchardApplication.SRpNFSyVT2MMJsQWqWn();
            num1 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_d9a87c470c1f44ac8f183ec4ee9ecd32 == 0 ? 0 : 0;
            continue;
          case 6:
          case 8:
            if (requestCultureInfo == null)
            {
              num1 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_dc6d5d9a4d9744a18d669405ae5070a8 != 0 ? 17 : 6;
              continue;
            }
            goto label_6;
          case 7:
            if (!OrchardApplication.befty5y62JIwpErmwZQ())
            {
              num1 = 18;
              continue;
            }
            goto case 4;
          case 9:
            try
            {
              if (OrchardApplication.Initialized)
              {
                int num2 = 1;
                if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_fc100e2d814f4e7192dfe01b010266e6 == 0)
                  num2 = 1;
                IAuthenticationService service1;
                ISession session;
                ISessionProvider service2;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      if (!OrchardApplication.befty5y62JIwpErmwZQ())
                      {
                        num2 = 14;
                        continue;
                      }
                      goto case 10;
                    case 3:
                      if (service1 != null)
                      {
                        num2 = 12;
                        continue;
                      }
                      goto label_7;
                    case 5:
                      service2 = Locator.GetService<ISessionProvider>();
                      num2 = 11;
                      continue;
                    case 6:
                      session = (ISession) OrchardApplication.tYOBlHyCMV19Q8smfBq((object) service2, (object) "");
                      num2 = 8;
                      continue;
                    case 7:
                      if (!OrchardApplication.hQMZ71yJ6FoHwLFMD5U((object) session))
                      {
                        num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_1fa223eab32142609596a8548a5ae713 != 0 ? 2 : 2;
                        continue;
                      }
                      goto case 9;
                    case 8:
                      if (session != null)
                      {
                        num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_bc1caf7c63e343118488ccfdd03f17f1 != 0 ? 5 : 7;
                        continue;
                      }
                      goto label_7;
                    case 9:
                      service1 = Locator.GetService<IAuthenticationService>();
                      num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_9b81d414ebfb4006961c5e16b583c908 != 0 ? 2 : 3;
                      continue;
                    case 10:
                      if (OrchardApplication.osmVCoyejehWMGZSkWF((object) context) == null)
                      {
                        num2 = 4;
                        continue;
                      }
                      goto case 5;
                    case 11:
                      if (service2 != null)
                      {
                        num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_2464724164964761ae144e148281de96 != 0 ? 5 : 6;
                        continue;
                      }
                      goto label_7;
                    case 12:
                      if (Locator.GetService<SessionFactoryHolder>() != null)
                      {
                        num2 = 13;
                        continue;
                      }
                      goto label_7;
                    case 13:
                      user = service1.GetCurrentUser();
                      num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_09d6ea8f51184538876ee96c32a45b45 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_7;
                  }
                }
              }
              else
                goto case 11;
            }
            catch (Exception ex)
            {
              int num3 = 0;
              if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_6453e511cd4a4b6394f4dead0bc7bd76 == 0)
                num3 = 0;
              switch (num3)
              {
                default:
                  goto label_7;
              }
            }
          case 10:
            user = (IUser) null;
            num1 = 9;
            continue;
          case 11:
label_7:
            if (!OrchardApplication.jbR5sSydXjAsB3WRbM4())
            {
              num1 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_ba2e33edfd5c4d10910c526ce19c8d72 == 0 ? 1 : 1;
              continue;
            }
            goto case 7;
          case 12:
            requestCultureInfo = (CultureInfo) OrchardApplication.lp0lX4yjn98TVZGJclQ();
            num1 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_fd5d0b0e0b504f3d993007bf914ac481 == 0 ? 6 : 5;
            continue;
          case 13:
label_47:
            if (requestCultureInfo != null)
            {
              num1 = 8;
              continue;
            }
            goto case 12;
          case 15:
            if (context != null)
            {
              num1 = 14;
              continue;
            }
            goto case 5;
          case 16:
            try
            {
              requestCultureInfo = (CultureInfo) OrchardApplication.nxXV3lyOXKpPV428gKQ();
              int num4 = 0;
              if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_5fc6cb15dbd84be7b6f01c9d3d0dc6f3 == 0)
                num4 = 0;
              switch (num4)
              {
                default:
                  goto label_47;
              }
            }
            catch (Exception ex)
            {
              int num5 = 0;
              if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_4857ff0c85a64b17b36a438afd6598b1 != 0)
                num5 = 0;
              switch (num5)
              {
                default:
                  goto label_47;
              }
            }
          case 17:
            requestCultureInfo = (CultureInfo) OrchardApplication.MCiFUOysL6C8fWiohbL((object) context);
            num1 = 2;
            continue;
          default:
            requestCultureInfo = (CultureInfo) null;
            num1 = 10;
            continue;
        }
      }
label_6:
      return requestCultureInfo;
    }

    /// <summary>Получить состояние</summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Application_AcquireRequestState(object sender, EventArgs e)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        CultureInfo requestCultureInfo;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_9;
            case 1:
              OrchardApplication.SetCultureToCookies();
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_554df24f17e6425aa0fa1f122cedd090 == 0 ? 3 : 6;
              continue;
            case 2:
              ((Thread) OrchardApplication.JDJi0Ryp1NeBOExlly6()).CurrentCulture = (CultureInfo) OrchardApplication.Tq3U5HyqfWqJGgPUt21(OrchardApplication.IQRVmOyGpDgQX3yoxxF((object) requestCultureInfo));
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_197cf3efcc1b453abc9035f3f338797e != 0 ? 1 : 1;
              continue;
            case 3:
              OrchardApplication.Gj72rlyIe2gvZK60Hh7((object) Thread.CurrentThread, (object) requestCultureInfo);
              num2 = 2;
              continue;
            case 4:
              goto label_4;
            case 5:
              this.SetDefaultOrchardWorkContext();
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_e3c5f5fc1e564390911b44e74f171948 != 0 ? 0 : 0;
              continue;
            case 6:
              OrchardApplication.a675BWyrUkGcC5Pe3tu();
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_c4b7427125ef4533ab1e2a6a836611d3 != 0 ? 3 : 5;
              continue;
            case 7:
              requestCultureInfo = OrchardApplication.GetRequestCultureInfo();
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_11df0b0286bd46b6a8780d914c7488e8 != 0 ? 3 : 3;
              continue;
            case 8:
              goto label_6;
            default:
              goto label_3;
          }
        }
label_6:
        if (OrchardApplication.Initialized)
          num1 = 7;
        else
          goto label_14;
      }
label_9:
      return;
label_4:
      return;
label_3:
      return;
label_14:;
    }

    private void SetDefaultOrchardWorkContext()
    {
      int num = 4;
      IWorkContextAccessor service;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_9;
          case 1:
            OrchardApplication.OqFuDUyQ7w6rvh7VKiH((object) service);
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_36dd3da07e034b65bf22c31089e30166 != 0 ? 0 : 0;
            continue;
          case 2:
            if (service == null)
            {
              num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_095e2fcf55f94b538dd6bcd94ba4bb6c != 0 ? 6 : 7;
              continue;
            }
            goto case 1;
          case 3:
            if (!OrchardApplication.befty5y62JIwpErmwZQ())
            {
              num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_f6056d356ee34c899b766b291a16a2b3 == 0 ? 4 : 6;
              continue;
            }
            goto case 5;
          case 4:
            if (OrchardApplication.jbR5sSydXjAsB3WRbM4())
            {
              num = 3;
              continue;
            }
            goto label_8;
          case 5:
            service = Locator.GetService<IWorkContextAccessor>();
            num = 2;
            continue;
          case 6:
            goto label_2;
          case 7:
            goto label_13;
          default:
            goto label_14;
        }
      }
label_9:
      return;
label_2:
      return;
label_13:
      return;
label_14:
      return;
label_8:;
    }

    /// <summary>Установить куки смещений часовых поясов</summary>
    private static void SetTimeZoneOffsetsToCookies()
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        HttpContext httpContext;
        HttpCookie httpCookie1;
        HttpCookie httpCookie2;
        HttpCookie httpCookie3;
        HttpCookie httpCookie4;
        long? blockedTimeZoneOffset;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (OrchardApplication.UseInPlaceWinAuth)
                goto case 8;
              else
                goto label_18;
            case 2:
              goto label_29;
            case 3:
              if (((IIdentity) OrchardApplication.H3aZniyorMGeGPItPeI(OrchardApplication.T76Cffy1uQQQf8dmirt((object) httpContext))).IsAuthenticated)
              {
                num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_cd867fd8e34648a7a62174a6af9dc6dd == 0 ? 1 : 1;
                continue;
              }
              goto label_8;
            case 4:
              httpContext = (HttpContext) OrchardApplication.SRpNFSyVT2MMJsQWqWn();
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_56d8b8d7dcf34e22b9d74eac50c9d637 != 0 ? 3 : 1;
              continue;
            case 5:
              httpCookie1 = new HttpCookie((string) OrchardApplication.rwAs0gVDEfiFL35YQTG(1241559407 - 4511379 ^ 1237046610));
              num2 = 2;
              continue;
            case 6:
              goto label_38;
            case 7:
              OrchardApplication.DkcjeTAuBdByZduOJpX(OrchardApplication.W4hJBjVsSkgtSYxiqH4(OrchardApplication.RC37K6yyb7dvoA9OgKM((object) httpContext)), (object) httpCookie1);
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_39ab3eb3910c4f408567739982d91be6 == 0 ? 4 : 6;
              continue;
            case 8:
              if (AuthenticationService.GetCurrentUser() != null)
              {
                num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_50d154664afc4b2f8f6da5de661b4a33 != 0 ? 0 : 0;
                continue;
              }
              goto label_25;
            case 9:
              httpCookie2 = new HttpCookie((string) OrchardApplication.rwAs0gVDEfiFL35YQTG(-217044389 ^ -982687180 ^ 914179895));
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_740ef59153ff4ad09b1da3c952318a34 != 0 ? 4 : 13;
              continue;
            case 10:
              httpCookie4 = new HttpCookie((string) OrchardApplication.rwAs0gVDEfiFL35YQTG(-1418111850 ^ -1418110366));
              num2 = 21;
              continue;
            case 12:
              blockedTimeZoneOffset = Locator.GetServiceNotNull<ITimeZoneService>().GetBlockedTimeZoneOffset();
              num2 = 20;
              continue;
            case 13:
              OrchardApplication.B7LmOvAiioEpVishgSa((object) httpCookie2, (object) OrchardApplication.ekO2KUAAxvSfHxpLpB5().ToString());
              num2 = 17;
              continue;
            case 14:
              OrchardApplication.B7LmOvAiioEpVishgSa((object) httpCookie3, (object) OrchardApplication.WPGMfOAyFqlYdCoNi5R().ToString());
              num2 = 26;
              continue;
            case 15:
              if (OrchardApplication.OvaLuSVI2YSPcvh7E3T(OrchardApplication.i7W76WyHC6FtWw1Qt3m(OrchardApplication.p6RDrkAVgolg8uSF1sf((object) httpContext)), OrchardApplication.rwAs0gVDEfiFL35YQTG(1024791542 << 4 ^ -783208210)) == null)
                goto case 12;
              else
                goto label_37;
            case 16:
            case 19:
              if (OrchardApplication.OvaLuSVI2YSPcvh7E3T(OrchardApplication.i7W76WyHC6FtWw1Qt3m((object) httpContext.Request), OrchardApplication.rwAs0gVDEfiFL35YQTG(~-1258710890 ^ 1258711117)) != null)
              {
                num2 = 27;
                continue;
              }
              goto case 18;
            case 17:
              OrchardApplication.DkcjeTAuBdByZduOJpX(OrchardApplication.W4hJBjVsSkgtSYxiqH4(OrchardApplication.RC37K6yyb7dvoA9OgKM((object) httpContext)), (object) httpCookie2);
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_5af002e0863d4b95bd3930e3b7dabcc8 != 0 ? 15 : 0;
              continue;
            case 18:
              httpCookie3 = new HttpCookie((string) OrchardApplication.rwAs0gVDEfiFL35YQTG(623835580 >> 5 ^ 19495145));
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_740ef59153ff4ad09b1da3c952318a34 != 0 ? 14 : 14;
              continue;
            case 20:
              if (!blockedTimeZoneOffset.HasValue)
              {
                num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_4658b846616d4b809f44001e9422aa59 == 0 ? 12 : 25;
                continue;
              }
              goto case 5;
            case 21:
              OrchardApplication.B7LmOvAiioEpVishgSa((object) httpCookie4, (object) OrchardApplication.h4viqQAdQZfn8tHVk35().ToString());
              num2 = 23;
              continue;
            case 22:
              if (!OrchardApplication.bjfXkayz2dF9pkanor3(OrchardApplication.nFsndfygos0QQwSC2e6(OrchardApplication.OvaLuSVI2YSPcvh7E3T((object) httpContext.Request.Cookies, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-508321835 ^ -508325599)))))
              {
                num2 = 16;
                continue;
              }
              goto case 10;
            case 23:
              OrchardApplication.DkcjeTAuBdByZduOJpX(OrchardApplication.W4hJBjVsSkgtSYxiqH4(OrchardApplication.RC37K6yyb7dvoA9OgKM((object) httpContext)), (object) httpCookie4);
              num2 = 19;
              continue;
            case 24:
              if (string.IsNullOrWhiteSpace((string) OrchardApplication.nFsndfygos0QQwSC2e6(OrchardApplication.OvaLuSVI2YSPcvh7E3T(OrchardApplication.i7W76WyHC6FtWw1Qt3m(OrchardApplication.p6RDrkAVgolg8uSF1sf((object) httpContext)), OrchardApplication.rwAs0gVDEfiFL35YQTG(1561482429 ^ 1561484083)))))
              {
                num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_d3c92aa8b2de4fa6b7d7008c5b9e8bb8 == 0 ? 12 : 10;
                continue;
              }
              goto label_3;
            case 25:
              goto label_41;
            case 26:
              OrchardApplication.DkcjeTAuBdByZduOJpX(OrchardApplication.W4hJBjVsSkgtSYxiqH4(OrchardApplication.RC37K6yyb7dvoA9OgKM((object) httpContext)), (object) httpCookie3);
              num2 = 9;
              continue;
            case 27:
              if (string.IsNullOrWhiteSpace((string) OrchardApplication.nFsndfygos0QQwSC2e6((object) ((HttpCookieCollection) OrchardApplication.i7W76WyHC6FtWw1Qt3m(OrchardApplication.p6RDrkAVgolg8uSF1sf((object) httpContext)))[(string) OrchardApplication.rwAs0gVDEfiFL35YQTG(-488803655 ^ -488800867)])))
              {
                num2 = 18;
                continue;
              }
              goto case 9;
            default:
              if (OrchardApplication.OvaLuSVI2YSPcvh7E3T(OrchardApplication.i7W76WyHC6FtWw1Qt3m((object) httpContext.Request), OrchardApplication.rwAs0gVDEfiFL35YQTG(1537431158 >> 6 ^ 24019885)) != null)
              {
                num2 = 22;
                continue;
              }
              goto case 10;
          }
        }
label_18:
        num1 = 11;
        continue;
label_29:
        OrchardApplication.B7LmOvAiioEpVishgSa((object) httpCookie1, (object) blockedTimeZoneOffset.ToString());
        num1 = 7;
        continue;
label_37:
        num1 = 24;
      }
label_38:
      return;
label_41:
      return;
label_25:
      return;
label_8:
      return;
label_3:;
    }

    /// <summary>Достать культуру из куки</summary>
    /// <returns></returns>
    protected static CultureInfo GetCultureFromCookies(HttpContext context = null)
    {
      int num1 = 7;
      HttpCookie httpCookie;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              httpCookie = ((HttpCookieCollection) OrchardApplication.i7W76WyHC6FtWw1Qt3m(OrchardApplication.p6RDrkAVgolg8uSF1sf((object) context))).Get((string) OrchardApplication.rwAs0gVDEfiFL35YQTG(1989827099 ^ 1989826015));
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_dc915391d7c84058a674014d8d1edd8c == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_5;
            case 3:
            case 6:
              if (OrchardApplication.cTvZjXA0LBfgJAtyHqg(OrchardApplication.i7W76WyHC6FtWw1Qt3m(OrchardApplication.p6RDrkAVgolg8uSF1sf((object) context)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-200877415 ^ -200878755)) == null)
              {
                num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_90d5c0398ebf4c45ac16be46887eda04 == 0 ? 4 : 3;
                continue;
              }
              goto case 1;
            case 4:
              goto label_9;
            case 5:
              if (!OrchardApplication.mo8wfRyDhALMF9MexNC(OrchardApplication.nFsndfygos0QQwSC2e6((object) httpCookie)))
              {
                num2 = 8;
                continue;
              }
              goto label_9;
            case 7:
              if (context != null)
              {
                num2 = 6;
                continue;
              }
              goto label_5;
            case 8:
              goto label_8;
            default:
              if (httpCookie != null)
              {
                num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_6453e511cd4a4b6394f4dead0bc7bd76 != 0 ? 3 : 5;
                continue;
              }
              goto label_9;
          }
        }
label_5:
        context = (HttpContext) OrchardApplication.SRpNFSyVT2MMJsQWqWn();
        num1 = 3;
      }
label_8:
      return new CultureInfo((string) OrchardApplication.nFsndfygos0QQwSC2e6((object) httpCookie));
label_9:
      return (CultureInfo) null;
    }

    /// <summary>Положить культуру в куку</summary>
    protected static void SetCultureToCookies(HttpContext context = null)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        HttpCookie httpCookie;
        while (true)
        {
          switch (num2)
          {
            case 1:
              httpCookie = new HttpCookie((string) OrchardApplication.rwAs0gVDEfiFL35YQTG(782114265 ^ 782111261));
              num2 = 12;
              continue;
            case 2:
              context = (HttpContext) OrchardApplication.SRpNFSyVT2MMJsQWqWn();
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_aefe3a0b23ba485b84a708e5b83dd041 == 0 ? 0 : 11;
              continue;
            case 3:
            case 11:
              httpCookie = (HttpCookie) OrchardApplication.cTvZjXA0LBfgJAtyHqg(OrchardApplication.W4hJBjVsSkgtSYxiqH4(OrchardApplication.RC37K6yyb7dvoA9OgKM((object) HttpContext.Current)), OrchardApplication.rwAs0gVDEfiFL35YQTG(1370191569 ^ 1370192149));
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_1458bc8da34547e98dc4ade0a8bd6573 == 0 ? 4 : 6;
              continue;
            case 4:
              if (context != null)
              {
                num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_fd5d0b0e0b504f3d993007bf914ac481 != 0 ? 3 : 3;
                continue;
              }
              goto case 2;
            case 5:
              OrchardApplication.in1gkIAXrJN7RqRUU0I((object) httpCookie, OrchardApplication.bdHRNJAPJsoo8aJRQOm().AddDays(365.0));
              num2 = 10;
              continue;
            case 6:
              if (httpCookie == null)
                goto case 1;
              else
                goto label_15;
            case 7:
              ((HttpCookieCollection) OrchardApplication.W4hJBjVsSkgtSYxiqH4((object) context.Response)).Remove(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1564551535 ^ 1564550827));
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_c1cf4a7dd0874037bf022e5737b29d28 != 0 ? 0 : 0;
              continue;
            case 8:
            case 12:
              if (OrchardApplication.nUWC5rA5jchxh2JONxq(OrchardApplication.IQRVmOyGpDgQX3yoxxF(OrchardApplication.P0YmpUAafI9LJoYhVRD(OrchardApplication.JDJi0Ryp1NeBOExlly6())), OrchardApplication.nFsndfygos0QQwSC2e6((object) httpCookie)))
              {
                num2 = 9;
                continue;
              }
              goto case 5;
            case 9:
              goto label_17;
            case 10:
              OrchardApplication.B7LmOvAiioEpVishgSa((object) httpCookie, OrchardApplication.IQRVmOyGpDgQX3yoxxF((object) ((Thread) OrchardApplication.JDJi0Ryp1NeBOExlly6()).CurrentCulture));
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_532ff7b375b7428794d86da99b25ab19 != 0 ? 2 : 13;
              continue;
            case 13:
              OrchardApplication.aavAEqAU3x8QbOPhl7p((object) httpCookie, true);
              num2 = 7;
              continue;
            case 14:
              goto label_16;
            default:
              OrchardApplication.DkcjeTAuBdByZduOJpX(OrchardApplication.W4hJBjVsSkgtSYxiqH4(OrchardApplication.RC37K6yyb7dvoA9OgKM((object) context)), (object) httpCookie);
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_aa54a61f50a144bab587b55f0c6b0d70 == 0 ? 8 : 14;
              continue;
          }
        }
label_15:
        num1 = 8;
      }
label_17:
      return;
label_16:;
    }

    /// <summary>Достать культуру с клиента</summary>
    /// <returns></returns>
    protected static CultureInfo GetCultureFromClient(HttpContext context)
    {
      int num1 = 9;
      CultureInfo cultureFromClient;
      while (true)
      {
        int num2 = num1;
        string langName;
        while (true)
        {
          switch (num2)
          {
            case 1:
              langName = ((HttpRequest) OrchardApplication.p6RDrkAVgolg8uSF1sf((object) context)).UserLanguages[0];
              num2 = 10;
              continue;
            case 2:
              langName = ((CultureInfo) OrchardApplication.otJGiCA8KZPVH5hDb2E()).Name;
              num2 = 11;
              continue;
            case 3:
              goto label_18;
            case 4:
            case 6:
            case 7:
            case 10:
              goto label_12;
            case 5:
              context = (HttpContext) OrchardApplication.SRpNFSyVT2MMJsQWqWn();
              num2 = 2;
              continue;
            case 8:
              if (context == null)
              {
                num2 = 5;
                continue;
              }
              goto case 2;
            case 9:
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_97b683f617e640659cafc539b8e993b2 != 0 ? 1 : 8;
              continue;
            case 11:
              if (OrchardApplication.osmVCoyejehWMGZSkWF((object) HttpContext.Current) == null)
              {
                num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_1654cf321678466eb4f0d0fa81f71c57 == 0 ? 7 : 5;
                continue;
              }
              goto default;
            case 12:
              if (((HttpRequest) OrchardApplication.p6RDrkAVgolg8uSF1sf((object) context)).UserLanguages.Length == 0)
              {
                num2 = 6;
                continue;
              }
              goto case 1;
            default:
              if (OrchardApplication.RmfrurAM2q5EjHI7cWh(OrchardApplication.p6RDrkAVgolg8uSF1sf((object) context)) == null)
              {
                num2 = 4;
                continue;
              }
              goto case 12;
          }
        }
label_12:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        cultureFromClient = EleWise.ELMA.SR.GetCultureNames().FirstOrDefault<CultureInfo>((Func<CultureInfo, bool>) (c => OrchardApplication.\u003C\u003Ec__DisplayClass28_0.HqF6kD06fuE1MvdDsZr(OrchardApplication.\u003C\u003Ec__DisplayClass28_0.uaTDb10DI2yXkJegsiR((object) c), (object) langName)));
        if (cultureFromClient == null)
          num1 = 3;
        else
          break;
      }
      return cultureFromClient;
label_18:
      return (CultureInfo) OrchardApplication.otJGiCA8KZPVH5hDb2E();
    }

    /// <inheritdoc />
    public override string GetVaryByCustomString(HttpContext context, string arg)
    {
      int num = 4;
      HttpCookie httpCookie;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 3:
            goto label_7;
          case 2:
            if (httpCookie == null)
            {
              num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_962090912078457cb15ebe6f9b5fadf9 == 0 ? 1 : 1;
              continue;
            }
            goto label_6;
          case 4:
            if (!OrchardApplication.u4bqUFAf79Tm7NK1kIy((object) arg, OrchardApplication.rwAs0gVDEfiFL35YQTG(1564551535 ^ 1564550833)))
            {
              num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_56d8b8d7dcf34e22b9d74eac50c9d637 != 0 ? 3 : 0;
              continue;
            }
            break;
          case 5:
            goto label_6;
          case 6:
            httpCookie = (HttpCookie) OrchardApplication.OvaLuSVI2YSPcvh7E3T(OrchardApplication.i7W76WyHC6FtWw1Qt3m((object) context.Request), OrchardApplication.rwAs0gVDEfiFL35YQTG(-578217651 ^ 1588856930 ^ -2093146149));
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_505866aff0204b659e1cc72dbf89c08c != 0 ? 2 : 1;
            continue;
        }
        if (context != null)
          num = 6;
        else
          goto label_7;
      }
label_6:
      return (string) OrchardApplication.X5tjVayZjrYoNMQWyI4((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(21574782 >> 2 ^ 5391085), OrchardApplication.nFsndfygos0QQwSC2e6((object) httpCookie));
label_7:
      return (string) OrchardApplication.a7DH6SA7DCenqYb8S2J((object) this, (object) context, (object) arg);
    }

    internal static bool GpWijDVmQhNJtBYHvAd() => ELMAEnviromentStarter.Initialized;

    internal static object yanULUVRBstqYp0bOgA() => (object) ELMAEnviromentStarter.StartupExceptionText;

    internal static object rwAs0gVDEfiFL35YQTG(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool jWA4ehV1uaw9PAdYvcO() => OrchardApplication.RV59KlVhrRdNJPFM3QU == null;

    internal static OrchardApplication lE9LMHVoxb6UNlDQmHM() => OrchardApplication.RV59KlVhrRdNJPFM3QU;

    internal static void d4XDhSV6J8OMjba33tf([In] bool obj0) => BrandResourceManager.InstallPackage(obj0);

    internal static object jYGIndVer0fPXUWs7cH() => (object) StartInformation.Root;

    internal static void ciKnOGVC2jGl3XIOr6b([In] SecurityProtocolType obj0) => ServicePointManager.SecurityProtocol = obj0;

    internal static void jNYP75VJ5RVSo59dO0Z() => ElmaTelerikInitializer.Init();

    internal static object wxW28HVOQsogp2CSyeu([In] object obj0) => (object) ((HttpApplication) obj0).Request;

    internal static object GDvHZqVjeW4hluwoUla([In] object obj0) => (object) ((HttpApplication) obj0).Response;

    internal static object W4hJBjVsSkgtSYxiqH4([In] object obj0) => (object) ((HttpResponse) obj0).Cookies;

    internal static object OvaLuSVI2YSPcvh7E3T([In] object obj0, [In] object obj1) => (object) ((HttpCookieCollection) obj0)[(string) obj1];

    internal static void hD8UysVpJhoerG3B1vL([In] object obj0, [In] bool obj1) => ((HttpCookie) obj0).Secure = obj1;

    internal static object L5pLHVVGHJ3YfJDiBGM([In] object obj0) => (object) ((HttpApplication) obj0).Server;

    internal static bool y6Xl7LVqE4ZKrqmnOf7() => DiagnosticsManager.Initialized;

    internal static object Fyo8T2VrLvriGVO4lmw() => (object) DiagnosticsManager.Instance;

    internal static object qDGHliVQAIsWcEB4hPy([In] object obj0) => (object) ((HttpApplication) obj0).Context;

    internal static object DjRBvBVHgcvHYeK83S0() => (object) Logger.Log;

    internal static bool PbpZHMVgLE2bqyC2A5K([In] object obj0) => ((ILogger) obj0).IsErrorEnabled();

    internal static object JFLQ1MVzL1EAplWBUUk([In] object obj0) => (object) ((Exception) obj0).GetBaseException();

    internal static bool jbR5sSydXjAsB3WRbM4() => OrchardApplication.Initialized;

    internal static object iKxbjxyiLl60cSVC2yB() => (object) OrchardApplication.StartupExceptionText;

    internal static object Jjfvthyu7hqcB7cX2Zw() => (object) ComponentManager.Current;

    internal static object SRpNFSyVT2MMJsQWqWn() => (object) HttpContext.Current;

    internal static object RC37K6yyb7dvoA9OgKM([In] object obj0) => (object) ((HttpContext) obj0).Response;

    internal static object PosUxhyAbHGZxcyJXyC([In] object obj0) => (object) ((HttpContext) obj0).CurrentHandler;

    internal static object aoQBHCy0mgoWkiN0jLH([In] object obj0) => (object) ((IHasRequestContext) obj0).RequestContext;

    internal static int JGNbkGyaRTZHMpTXJB4([In] object obj0) => ((HttpException) obj0).GetHttpCode();

    internal static void HsCmY5y5XS0PtAAkbtX([In] object obj0, [In] object obj1) => ((ViewResultBase) obj0).ViewName = (string) obj1;

    internal static void awap8wyPoaJv8ujdlgK([In] object obj0, [In] object obj1) => ((HttpResponse) obj0).ContentType = (string) obj1;

    internal static void Ti1ud5yXndcBt0wKjX0([In] object obj0, [In] object obj1) => ((ViewResultBase) obj0).ViewEngineCollection = (ViewEngineCollection) obj1;

    internal static object VXmFQIyUmkGradkUZCl([In] object obj0) => (object) ((ViewResultBase) obj0).ViewData;

    internal static object zgjjQvy82HibnQqr1wJ([In] object obj0, [In] object obj1) => (object) ((RouteData) obj0).GetRequiredString((string) obj1);

    internal static object hoGn0GyMknRgLSjxNhC([In] object obj0) => (object) ((ControllerContext) obj0).RouteData;

    internal static object rUTSV5yfRt0Uk8iALam([In] object obj0) => (object) ((HttpContext) obj0).Server;

    internal static void FUyHhJy7Xbs7n33xpAK([In] object obj0) => ((HttpServerUtility) obj0).ClearError();

    internal static object XwAyW8ynguPdv1EgDGQ([In] object obj0) => (object) ((HttpRequest) obj0).RawUrl;

    internal static object qJxp9eytBGUQRobb42m([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static bool QfSLBNy2o3HSiIiXyIC([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);

    internal static StartStatus AYIrnAyK22GJSpqp6kc([In] object obj0) => ((StartInformation) obj0).Status;

    internal static object bnEE1DyvP6muiX76n0X() => (object) OrchardApplication.PrerequisitesPage;

    internal static object TPW3c4ySSnidEAMwDxg([In] object obj0) => (object) ((HttpRequest) obj0).ContentEncoding;

    internal static object qi9AsQyTG0MZUKURZqR([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);

    internal static void Q9umM5y4AOWyTkllG3y([In] object obj0, [In] object obj1, [In] bool obj2) => ((HttpResponse) obj0).Redirect((string) obj1, obj2);

    internal static void EvouZGyL1iuO0T0V9rA([In] object obj0) => ((HttpApplication) obj0).CompleteRequest();

    internal static object tXRTLIyl8JAuToZpyEB() => (object) OrchardApplication.ActivationPage;

    internal static object FjMyn4ybHXNLG3KOucy([In] object obj0, [In] object obj1) => (object) HttpUtility.UrlEncode((string) obj0, (Encoding) obj1);

    internal static object hS1D7by3duT0HCb3fen() => (object) OrchardApplication.MakeBackupPage;

    internal static bool zKodsUyx39QyBefsZPR() => ComponentManager.Initialized;

    internal static object yH8ZjiycrvrK5DMrSk2([In] object obj0) => (object) ((ILicensedUnit) obj0).GetLicenseInfo();

    internal static LicenseStatus ntoOEHy98n7BQG5JEmJ([In] object obj0) => ((ILicenseInfo) obj0).Status;

    internal static bool rcDDJ1yWPdfsZbXw99A([In] object obj0) => ((IMetadataRuntimeService) obj0).ConfigurationScriptsRecompileRequired;

    internal static bool TG0XYCyN3ZSMVubvIYS([In] object obj0) => ((IConfigurationScriptsErrorService) obj0).IsValidCurrent();

    internal static object waefEKyFpNl7LOSODIB() => (object) OrchardApplication.ConfigurationScriptsErrorPage;

    internal static object X5tjVayZjrYoNMQWyI4([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object M98xN3ywt2xy9kKWivD() => (object) ELMAEnviromentStarter.OrchardHost;

    internal static object HSc4dtykHWxdmJKhrBm([In] object obj0) => (object) ((HttpContext) obj0).Items;

    internal static void fDMpIMyEUxrS2vPDJ38([In] object obj0, [In] object obj1, [In] object obj2) => ((IDictionary) obj0)[obj1] = obj2;

    internal static void Gbmga6yY3T4t5M4WxPQ([In] object obj0, [In] object obj1) => ((DiagnosticsManager) obj0).WebRequestStart((HttpContext) obj1);

    internal static void BBG9YIyBFYAeFPi9jpV([In] object obj0) => ((IOrchardHost) obj0).EndRequest();

    internal static void kAMHGryhid7T9Ld0eeV([In] object obj0, [In] object obj1) => ((DiagnosticsManager) obj0).WebRequestEnd((HttpContext) obj1);

    internal static object T76Cffy1uQQQf8dmirt([In] object obj0) => (object) ((HttpContext) obj0).User;

    internal static object H3aZniyorMGeGPItPeI([In] object obj0) => (object) ((IPrincipal) obj0).Identity;

    internal static bool cQGFrRymcEcCO8VTa6q([In] object obj0) => ((IIdentity) obj0).IsAuthenticated;

    internal static object cUXfTkyRWds7AANMTvI([In] object obj0) => (object) ((IIdentity) obj0).Name;

    internal static bool mo8wfRyDhALMF9MexNC([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static bool befty5y62JIwpErmwZQ() => Locator.Initialized;

    internal static object osmVCoyejehWMGZSkWF([In] object obj0) => (object) ((HttpContext) obj0).Session;

    internal static object tYOBlHyCMV19Q8smfBq([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static bool hQMZ71yJ6FoHwLFMD5U([In] object obj0) => ((ISession) obj0).IsConnected;

    internal static object nxXV3lyOXKpPV428gKQ() => (object) EleWise.ELMA.SR.GetCurrentCulture();

    internal static object lp0lX4yjn98TVZGJclQ() => (object) EleWise.ELMA.SR.GetCultureFromSettings();

    internal static object MCiFUOysL6C8fWiohbL([In] object obj0) => (object) OrchardApplication.GetCultureFromClient((HttpContext) obj0);

    internal static void Gj72rlyIe2gvZK60Hh7([In] object obj0, [In] object obj1) => ((Thread) obj0).CurrentUICulture = (CultureInfo) obj1;

    internal static object JDJi0Ryp1NeBOExlly6() => (object) Thread.CurrentThread;

    internal static object IQRVmOyGpDgQX3yoxxF([In] object obj0) => (object) ((CultureInfo) obj0).Name;

    internal static object Tq3U5HyqfWqJGgPUt21([In] object obj0) => (object) CultureInfo.CreateSpecificCulture((string) obj0);

    internal static void a675BWyrUkGcC5Pe3tu() => OrchardApplication.SetTimeZoneOffsetsToCookies();

    internal static object OqFuDUyQ7w6rvh7VKiH([In] object obj0) => (object) ((IWorkContextAccessor) obj0).GetContext();

    internal static object i7W76WyHC6FtWw1Qt3m([In] object obj0) => (object) ((HttpRequest) obj0).Cookies;

    internal static object nFsndfygos0QQwSC2e6([In] object obj0) => (object) ((HttpCookie) obj0).Value;

    internal static bool bjfXkayz2dF9pkanor3([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static int h4viqQAdQZfn8tHVk35() => TZ.ClientOffset;

    internal static void B7LmOvAiioEpVishgSa([In] object obj0, [In] object obj1) => ((HttpCookie) obj0).Value = (string) obj1;

    internal static void DkcjeTAuBdByZduOJpX([In] object obj0, [In] object obj1) => ((HttpCookieCollection) obj0).Add((HttpCookie) obj1);

    internal static object p6RDrkAVgolg8uSF1sf([In] object obj0) => (object) ((HttpContext) obj0).Request;

    internal static int WPGMfOAyFqlYdCoNi5R() => TZ.ServerOffset;

    internal static int ekO2KUAAxvSfHxpLpB5() => TZ.RuntimeOffset;

    internal static object cTvZjXA0LBfgJAtyHqg([In] object obj0, [In] object obj1) => (object) ((HttpCookieCollection) obj0).Get((string) obj1);

    internal static object P0YmpUAafI9LJoYhVRD([In] object obj0) => (object) ((Thread) obj0).CurrentCulture;

    internal static bool nUWC5rA5jchxh2JONxq([In] object obj0, [In] object obj1) => ((string) obj0).Equals((string) obj1);

    internal static DateTime bdHRNJAPJsoo8aJRQOm() => DateTime.Now;

    internal static void in1gkIAXrJN7RqRUU0I([In] object obj0, [In] DateTime obj1) => ((HttpCookie) obj0).Expires = obj1;

    internal static void aavAEqAU3x8QbOPhl7p([In] object obj0, [In] bool obj1) => ((HttpCookie) obj0).HttpOnly = obj1;

    internal static object otJGiCA8KZPVH5hDb2E() => (object) EleWise.ELMA.SR.KeyCultureInfo;

    internal static object RmfrurAM2q5EjHI7cWh([In] object obj0) => (object) ((HttpRequest) obj0).UserLanguages;

    internal static bool u4bqUFAf79Tm7NK1kIy([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object a7DH6SA7DCenqYb8S2J([In] object obj0, [In] object obj1, [In] object obj2) => (object) __nonvirtual (((HttpApplication) obj0).GetVaryByCustomString((HttpContext) obj1, (string) obj2));
  }
}
