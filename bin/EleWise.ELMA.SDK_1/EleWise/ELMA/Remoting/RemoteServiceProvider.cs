// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Remoting.RemoteServiceProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using Castle.DynamicProxy;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Design;
using EleWise.ELMA.Design.Components;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.Components.Web;
using EleWise.ELMA.Packaging.Components.Web.Settings;
using EleWise.ELMA.ServerInfoReference;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security.Authentication;
using System.Text;
using System.Threading;

namespace EleWise.ELMA.Remoting
{
  /// <summary>Провайдер для регистрации Remoting-сервисов</summary>
  public class RemoteServiceProvider : IInitHandler
  {
    private string url;
    private string remotingServiceName;
    private bool? isWebServiceUrl;
    internal IEnumerable<object> services;
    private ConfigurationServiceProvider cfgServiceProvider;
    private Dictionary<Type, object> proxies;
    private bool reconnecting;
    private static RemoteServiceProvider P8YYLFXsoqPuboIWZme;

    /// <summary>Ctor</summary>
    /// <param name="url">URL remoting-сервиса ELMA</param>
    /// <param name="remotingServiceName">Имя сервиса</param>
    /// <param name="isWebServiceUrl">Является ли параметр <paramref name="url" /> адресом веб-сервиса</param>
    public RemoteServiceProvider(string url, string remotingServiceName, bool? isWebServiceUrl = null)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.proxies = new Dictionary<Type, object>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      RemotingConfigurator.ConfigureRemotingClient();
      this.url = url;
      this.remotingServiceName = remotingServiceName;
      this.isWebServiceUrl = isWebServiceUrl;
    }

    /// <summary>Действие по созданию прогресс-диалога</summary>
    public Func<string, IProgressDialog> CreateProgressDialog { get; set; }

    /// <summary>Действие для показа вопроса</summary>
    public Func<string, bool> ShowQuestion { get; set; }

    /// <summary>Показать исключение</summary>
    public Action<string, Exception> ShowException { get; set; }

    /// <summary>Показать предупреждение</summary>
    public Action<string> ShowWarning { get; set; }

    /// <summary>
    /// Показать сообщение о необходимости выполнить резервное копирование
    /// </summary>
    public Action<bool> ShowBackupMessage { get; set; }

    /// <summary>Проверять ли установленные в дизайнер пакеты</summary>
    public bool CheckDesignerPackages
    {
      get => this.\u003CCheckDesignerPackages\u003Ek__BackingField;
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
              this.\u003CCheckDesignerPackages\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
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

    /// <summary>Отключить запрос логина</summary>
    public bool DisableLoginScreen
    {
      get => this.\u003CDisableLoginScreen\u003Ek__BackingField;
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
              this.\u003CDisableLoginScreen\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
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

    /// <summary>URL для подключения</summary>
    public string Url => this.url;

    /// <summary>Является ли URL адресом веб-сервера</summary>
    public bool IsWebServiceUrl
    {
      get => this.\u003CIsWebServiceUrl\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CIsWebServiceUrl\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
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

    /// <summary>Выполнить подключение</summary>
    public void Connect(bool ignoreDemoStart = false)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.services = this.GetServices(ignoreDemoStart, false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Выполнить переподключение Remoting-сервисов</summary>
    public void Reconnect()
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            if (!this.reconnecting)
            {
              this.reconnecting = true;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_37;
          default:
            goto label_3;
        }
      }
label_2:
      return;
label_37:
      return;
label_3:
      try
      {
        IEnumerable<object> first = this.GetServices(false, true);
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
          num2 = 1;
        while (true)
        {
          IEnumerator<object> enumerator;
          switch (num2)
          {
            case 1:
              if (first == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 2:
              first = (IEnumerable<object>) first.Union<object>((IEnumerable<object>) new RemotingAssemblyResolverService[1]
              {
                new RemotingAssemblyResolverService(this.cfgServiceProvider, this)
              }).ToList<object>();
              num2 = 6;
              continue;
            case 4:
              try
              {
label_21:
                if (RemoteServiceProvider.LnaNjkTFOTSyLlBOxm9((object) enumerator))
                  goto label_14;
                else
                  goto label_22;
label_13:
                object current;
                IProxyTargetAccessor proxyTargetAccessor;
                RemoteServiceProxyBuilder.Interceptor interceptor;
                object obj;
                Type type;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_14;
                    case 2:
                    case 9:
                      goto label_21;
                    case 3:
                      if (!this.proxies.TryGetValue(type, out obj))
                      {
                        num3 = 2;
                        continue;
                      }
                      goto case 7;
                    case 4:
                      interceptor = proxyTargetAccessor.GetInterceptors().OfType<RemoteServiceProxyBuilder.Interceptor>().FirstOrDefault<RemoteServiceProxyBuilder.Interceptor>();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
                      continue;
                    case 5:
                      if (proxyTargetAccessor != null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 4 : 0;
                        continue;
                      }
                      goto label_21;
                    case 6:
                      goto label_7;
                    case 7:
                      proxyTargetAccessor = obj as IProxyTargetAccessor;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 2 : 5;
                      continue;
                    case 8:
                      type = current.GetType();
                      num3 = 3;
                      continue;
                    case 10:
                      interceptor.Service = current;
                      num3 = 9;
                      continue;
                    default:
                      if (interceptor != null)
                      {
                        num3 = 10;
                        continue;
                      }
                      goto label_21;
                  }
                }
label_14:
                current = enumerator.Current;
                num3 = 8;
                goto label_13;
label_22:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 5 : 6;
                goto label_13;
              }
              finally
              {
                int num4;
                if (enumerator == null)
                  num4 = 2;
                else
                  goto label_30;
label_29:
                switch (num4)
                {
                  case 1:
                    break;
                  default:
                }
label_30:
                RemoteServiceProvider.kLMf0OTB5MA6YxjSSLt((object) enumerator);
                num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
                {
                  num4 = 0;
                  goto label_29;
                }
                else
                  goto label_29;
              }
            case 5:
              goto label_33;
            case 6:
              enumerator = first.GetEnumerator();
              num2 = 4;
              continue;
          }
label_7:
          this.services = first;
          num2 = 5;
        }
label_33:;
      }
      finally
      {
        this.reconnecting = false;
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
          num5 = 0;
        switch (num5)
        {
          default:
        }
      }
    }

    /// <summary>Выполняется ли в данный момент переподключение</summary>
    public bool Reconnecting => this.reconnecting;

    /// <summary>Получить сервис без прокси-обертки</summary>
    /// <typeparam name="T">Тип сервиса</typeparam>
    /// <returns></returns>
    public T GetServiceWithoutProxy<T>() where T : class => this.services == null ? default (T) : this.services.OfType<T>().FirstOrDefault<T>();

    /// <summary>Получение статуса сервера (для стартера Демо)</summary>
    /// <param name="remoteUrl"></param>
    /// <returns></returns>
    public static StartInformation GetServerStatus(string remoteUrl)
    {
      int num1 = 1;
      ServerInfo serverInfo;
      while (true)
      {
        switch (num1)
        {
          case 1:
            serverInfo = (ServerInfo) RemoteServiceProvider.hHmSXgTWi5FIGmV4R5p((object) remoteUrl);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      return (StartInformation) null;
label_5:
      StartInformation informationLocalized;
      try
      {
        CultureInfo cultureInfo = RemoteServiceProvider.CurrentCultureInfo();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              informationLocalized = serverInfo.GetStartInformationLocalized(cultureInfo != null ? cultureInfo.Name : string.Empty);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
      }
      catch
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
          num3 = 0;
        switch (num3)
        {
          default:
            goto label_2;
        }
      }
label_3:
      return informationLocalized;
    }

    public static bool StartDemoServer(
      string url,
      Func<string, IProgressDialog> createProgressDialog,
      Action<string> showProgressMessage,
      out bool adminHasEmptyPassword,
      out string errorMessage)
    {
      errorMessage = "";
      Exception exception = (Exception) null;
      int num = RemoteServiceProvider.StartDemoServer(url, createProgressDialog, showProgressMessage, out adminHasEmptyPassword, out exception) ? 1 : 0;
      if (exception == null)
        return num != 0;
      errorMessage = exception.Message;
      return num != 0;
    }

    /// <summary>Запустить демонстрационный сервер</summary>
    /// <param name="url">Адрес сервера</param>
    public static bool StartDemoServer(
      string url,
      Func<string, IProgressDialog> createProgressDialog,
      Action<string> showProgressMessage,
      out bool adminHasEmptyPassword,
      out Exception exception)
    {
      exception = (Exception) null;
      adminHasEmptyPassword = false;
      string host = UrlHelper.GetHost(url);
      if (host != z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978497040) && host.ToLower() != z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979460774))
      {
        exception = new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281855082)));
        return false;
      }
      if (showProgressMessage != null)
        showProgressMessage(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 222148822)));
      RemoteServiceProvider.WaitWebStartResult waitWebStartResult = RemoteServiceProvider.WaitForWebStarted((object) url, TimeSpan.FromSeconds(5.0), TimeSpan.FromSeconds(60.0));
      if (waitWebStartResult == RemoteServiceProvider.WaitWebStartResult.RequestFailed)
      {
        exception = new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234321674)));
        return false;
      }
      using (IProgressDialog progress = createProgressDialog != null ? createProgressDialog(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917278904))) : (IProgressDialog) null)
      {
        if (waitWebStartResult == RemoteServiceProvider.WaitWebStartResult.PortClosed)
        {
          using (ComponentManager componentManager = new ComponentManager(ComponentType.Design))
          {
            componentManager.PackageService.ComponentName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979460542);
            componentManager.InitLicensing(new string[1]
            {
              AppDomain.CurrentDomain.BaseDirectory
            }, DesignEnvironment.WorkDir, true);
            PackageService packageService = componentManager.PackageService;
            WebComponent component1 = packageService.Initialized ? packageService.GetComponent(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29242943)) as WebComponent : (WebComponent) null;
            if (component1 != null && component1.IsInstalled())
            {
              bool flag = true;
              WebComponentSettings componentSettings = component1.LoadSettings();
              if (componentSettings != null && componentSettings.HostingType == HostingType.InternalServer)
              {
                IElmaComponent component2 = packageService.GetComponent(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306463992));
                if (component2 != null)
                  flag = !component2.IsStarted();
              }
              if (flag)
                component1.Start();
            }
            else
            {
              exception = new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822900630)));
              return false;
            }
          }
          if (showProgressMessage != null)
            showProgressMessage(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099769411)));
          switch (RemoteServiceProvider.WaitForWebStarted((object) url, TimeSpan.FromSeconds(30.0), TimeSpan.FromSeconds(30.0)))
          {
            case RemoteServiceProvider.WaitWebStartResult.PortClosed:
              Logger.Log.Error((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178228254), (object) url));
              exception = new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138170622)));
              return false;
            case RemoteServiceProvider.WaitWebStartResult.RequestFailed:
              exception = new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858865039)));
              return false;
          }
        }
        try
        {
          bool? isWebServiceUrl = new bool?();
          RemoteServiceProvider.WaitForWebInitialized((object) url, false, ref isWebServiceUrl, out int? _, out adminHasEmptyPassword, (Func<string, IProgressDialog>) (msg =>
          {
            int num = 2;
            while (true)
            {
              switch (num)
              {
                case 1:
                case 3:
                  goto label_4;
                case 2:
                  if (progress == null)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 1;
                    continue;
                  }
                  break;
              }
              // ISSUE: reference to a compiler-generated method
              RemoteServiceProvider.\u003C\u003Ec__DisplayClass42_0.CullPKf00hLDom9oUmkY((object) progress, (object) msg);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 3 : 2;
            }
label_4:
            return progress;
          }), showProgressMessage);
        }
        catch (Exception ex)
        {
          Logger.Log.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576127504), ex);
          exception = ex;
          return false;
        }
      }
      return true;
    }

    void IInitHandler.Init()
    {
      int num1 = 6;
      RemotingAssemblyResolverService assemblyResolverService;
      IEnumerator<object> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_26;
          case 1:
            try
            {
label_12:
              if (enumerator.MoveNext())
                goto label_14;
              else
                goto label_13;
label_8:
              Type[] array;
              object current;
              Type type;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    Type[] interfaces = type.GetInterfaces();
                    // ISSUE: reference to a compiler-generated field
                    Func<Type, bool> func = RemoteServiceProvider.\u003C\u003Ec.\u003C\u003E9__43_0;
                    Func<Type, bool> predicate;
                    if (func == null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      RemoteServiceProvider.\u003C\u003Ec.\u003C\u003E9__43_0 = predicate = (Func<Type, bool>) (intf =>
                      {
                        int num3 = 1;
                        while (true)
                        {
                          switch (num3)
                          {
                            case 1:
                              // ISSUE: type reference
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              if (RemoteServiceProvider.\u003C\u003Ec.Ywfx7Pf0dcGeXpgFAhLc(intf, RemoteServiceProvider.\u003C\u003Ec.Dk6bTBf09MXOcpyTguDM(__typeref (IConfigurationService))))
                              {
                                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
                                continue;
                              }
                              goto label_3;
                            default:
                              goto label_2;
                          }
                        }
label_2:
                        return typeof (IConfigurationService).IsAssignableFrom(intf);
label_3:
                        return false;
                      });
                    }
                    else
                      goto label_28;
label_19:
                    array = ((IEnumerable<Type>) interfaces).Where<Type>(predicate).ToArray<Type>();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 3 : 3;
                    continue;
label_28:
                    predicate = func;
                    goto label_19;
                  case 2:
                    this.proxies[type] = RemoteServiceProvider.RegisterProxiedService(current, (object) array);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
                    continue;
                  case 3:
                    if (array.Length == 0)
                    {
                      num2 = 4;
                      continue;
                    }
                    goto case 2;
                  case 5:
                    type = current.GetType();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
                    continue;
                  case 6:
                    goto label_14;
                  case 7:
                    goto label_4;
                  default:
                    goto label_12;
                }
              }
label_13:
              num2 = 7;
              goto label_8;
label_14:
              current = enumerator.Current;
              num2 = 5;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
              {
                num2 = 2;
                goto label_8;
              }
              else
                goto label_8;
            }
            finally
            {
              int num4;
              if (enumerator == null)
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 0;
              else
                goto label_24;
label_22:
              switch (num4)
              {
                case 2:
                  break;
                default:
              }
label_24:
              RemoteServiceProvider.kLMf0OTB5MA6YxjSSLt((object) enumerator);
              num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
              {
                num4 = 0;
                goto label_22;
              }
              else
                goto label_22;
            }
          case 2:
            enumerator = this.services.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 1 : 1;
            continue;
          case 3:
          case 5:
label_4:
            assemblyResolverService = new RemotingAssemblyResolverService(this.cfgServiceProvider, this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 4;
            continue;
          case 4:
            // ISSUE: type reference
            this.proxies[assemblyResolverService.GetType()] = RemoteServiceProvider.uqkfE3TbNIPXXmPyl6d((object) assemblyResolverService, (object) new Type[1]
            {
              RemoteServiceProvider.jDO85WToXOkfx6KraNE(__typeref (IRemotingAssemblyResolverService))
            });
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
            continue;
          case 6:
            if (this.services == null)
            {
              num1 = 5;
              continue;
            }
            goto case 2;
          default:
            goto label_23;
        }
      }
label_26:
      return;
label_23:;
    }

    void IInitHandler.InitComplete()
    {
    }

    private static object RegisterProxiedService(object service, object intfs)
    {
      int num = 1;
      object instance;
      while (true)
      {
        switch (num)
        {
          case 1:
            instance = RemoteServiceProxyBuilder.Build(service, (Type[]) intfs);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ((ContainerBuilder) RemoteServiceProvider.p4x08xThg6xfAQ81LIc()).RegisterInstance<object>(instance).As(((IEnumerable<Type>) intfs).ToArray<Type>());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      return instance;
    }

    private static bool IsPortOpened(int port)
    {
      int num = 4;
      IPEndPoint[] ipEndPointArray;
      int index;
      bool flag;
      while (true)
      {
        switch (num)
        {
          case 1:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 3 : 10;
            continue;
          case 2:
            flag = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
            continue;
          case 3:
            ipEndPointArray = (IPEndPoint[]) RemoteServiceProvider.xG0D1QTEYMtvn71gQMI(RemoteServiceProvider.o45GNbTGWuJgGHx6d6T());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 6;
            continue;
          case 4:
            flag = false;
            num = 3;
            continue;
          case 5:
          case 7:
            if (ipEndPointArray[index].Port == port)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 2;
              continue;
            }
            goto case 1;
          case 6:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 6 : 9;
            continue;
          case 9:
          case 10:
            if (index < ipEndPointArray.Length)
            {
              num = 7;
              continue;
            }
            goto label_6;
          default:
            goto label_6;
        }
      }
label_6:
      return flag;
    }

    /// <summary>Получемние текущей культуры</summary>
    /// <returns></returns>
    private static CultureInfo CurrentCultureInfo()
    {
      int num = 2;
      string settingsFile;
      LanguageHolder languageHolder;
      CultureInfo defaultCulture;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!System.IO.File.Exists(settingsFile))
            {
              num = 7;
              continue;
            }
            goto case 6;
          case 2:
            settingsFile = EleWise.ELMA.SR.GetSettingsFile(fileName: (string) RemoteServiceProvider.CKZDLiTfgtQl902oYtA(-1290212282 ^ -644262414 ^ 1786878360));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_12;
          case 4:
            defaultCulture = EleWise.ELMA.SR.GetDefaultCulture();
            if (defaultCulture == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 3 : 5;
              continue;
            }
            goto label_4;
          case 5:
            goto label_11;
          case 6:
            languageHolder = (LanguageHolder) RemoteServiceProvider.M7lT8MTQtmQ0k9o3W5y((object) settingsFile);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
            continue;
          case 7:
            goto label_13;
          default:
            if (languageHolder != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 3 : 3;
              continue;
            }
            goto case 4;
        }
      }
label_4:
      return defaultCulture;
label_11:
      return (CultureInfo) RemoteServiceProvider.hEt1qQTC2NsCihMmj7v();
label_12:
      return (CultureInfo) RemoteServiceProvider.h68hpeTvDJHs6SHt9p8((object) languageHolder);
label_13:
      return (CultureInfo) null;
    }

    private static void WaitForWebInitialized(
      object url,
      bool isReconnecting,
      ref bool? isWebServiceUrl,
      out int? port,
      out bool adminHasEmptyPassword,
      Func<string, IProgressDialog> createProgressDialog = null,
      Action<string> showProgressMessage = null,
      Action<bool> showBackupMessage = null)
    {
      port = new int?();
      adminHasEmptyPassword = false;
      ServerInfo serverInfoService = RemoteServiceProvider.CreateServerInfoService(url);
      CultureInfo cultureInfo1 = RemoteServiceProvider.CurrentCultureInfo();
      if (cultureInfo1 != null)
      {
        Thread.CurrentThread.CurrentUICulture = cultureInfo1;
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureInfo1.Name);
      }
      IProgressDialog progressDialog1 = createProgressDialog == null || isReconnecting ? (IProgressDialog) null : createProgressDialog(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70017661)));
      bool flag1 = true;
      try
      {
        WebRequest updatePackageStatus = RemoteServiceProvider.CreateServerUpdatePackageStatus(url);
        Logger.Log.Debug((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858864297) + (string) url));
        while (true)
        {
          Logger.Log.Debug((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106503980) + (string) url));
          using (Stream responseStream = updatePackageStatus.GetResponse().GetResponseStream())
          {
            Logger.Log.Debug((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021386817) + (string) url));
            string str1 = Encoding.UTF8.GetString(responseStream.ReadAllBytes());
            Logger.Log.Debug((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088319302) + str1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -629862824) + (string) url));
            string[] strArray = str1.Split(new string[1]
            {
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837684057)
            }, StringSplitOptions.RemoveEmptyEntries);
            string str2 = strArray[0];
            if (!(str2 == z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306464552)))
            {
              if (str2 == z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 873989575))
              {
                flag1 = false;
                break;
              }
              if (progressDialog1 == null && createProgressDialog != null)
                progressDialog1 = createProgressDialog(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113876621)));
              if (progressDialog1 != null)
                progressDialog1.Message = strArray.Length == 3 ? strArray[2] : str1;
              if (showProgressMessage != null)
                showProgressMessage(strArray.Length == 3 ? strArray[2] : str1);
            }
            else
              break;
          }
          updatePackageStatus = RemoteServiceProvider.CreateServerUpdatePackageStatus(url);
        }
      }
      catch (Exception ex)
      {
        Logger.Log.Debug((object) ex.Message, ex);
      }
      finally
      {
        if (flag1 && progressDialog1 != null)
          progressDialog1.Dispose();
      }
      if (!isWebServiceUrl.HasValue)
      {
        isWebServiceUrl = new bool?(true);
        try
        {
          serverInfoService.GetStartInformationLocalized(cultureInfo1 != null ? cultureInfo1.Name : string.Empty);
        }
        catch (Exception ex)
        {
          Logger.Log.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408916310), ex);
          isWebServiceUrl = new bool?(false);
        }
      }
      if (!isWebServiceUrl.Value)
        return;
      StartInformation startInformation = serverInfoService.GetStartInformationLocalized(cultureInfo1 != null ? cultureInfo1.Name : string.Empty);
      bool flag2 = true;
      int num1 = 0;
      while (flag2)
      {
        ++num1;
        if (startInformation.Status == StartStatus.Running || startInformation.Status == StartStatus.BackupNeeded)
        {
          IProgressDialog progressDialog2 = createProgressDialog != null ? createProgressDialog(startInformation.Message) : (IProgressDialog) null;
          if (showProgressMessage != null)
            showProgressMessage(startInformation.Message);
          try
          {
            while (true)
            {
              do
              {
                if (startInformation.Status != StartStatus.Running)
                  goto label_40;
label_33:
                Thread.Sleep(1000);
                CultureInfo cultureInfo2 = RemoteServiceProvider.CurrentCultureInfo();
                startInformation = serverInfoService.GetStartInformationLocalized(cultureInfo2 != null ? cultureInfo2.Name : string.Empty);
                if (progressDialog2 != null)
                  progressDialog2.Message = startInformation.Message;
                if (showProgressMessage != null)
                  showProgressMessage(startInformation.Message);
                continue;
label_40:
                if (startInformation.Status == StartStatus.BackupNeeded)
                  goto label_33;
                else
                  goto label_47;
              }
              while (showBackupMessage == null);
              showBackupMessage(startInformation.Status == StartStatus.BackupNeeded);
            }
          }
          finally
          {
            if (showBackupMessage != null)
              showBackupMessage(false);
            progressDialog2?.Dispose();
          }
        }
label_47:
        flag2 = false;
        if (startInformation.Status == StartStatus.NotActivated)
        {
          if (num1 <= 3)
          {
            try
            {
              startInformation = serverInfoService.Reactivate();
              flag2 = true;
            }
            catch (Exception ex)
            {
              Logger.Log.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236089899), ex);
            }
          }
        }
      }
      if (startInformation.Status == StartStatus.NotStarted && startInformation.ErrorType != StartErrorType.ConfigurationScriptsRecompileRequired)
        throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1642877098)));
      if (startInformation.Status == StartStatus.NotActivated)
        throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712494053)));
      port = new int?(serverInfoService.GetRemotingPort());
      int? nullable = port;
      int num2 = 0;
      if (nullable.GetValueOrDefault() <= num2 & nullable.HasValue)
        throw new DesignerPortOccupiedException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289729814)));
      try
      {
        adminHasEmptyPassword = serverInfoService.AdminHasEmptyPassword();
      }
      catch
      {
      }
    }

    private IEnumerable<object> GetServices(bool ignoreDemoStart, bool isReconnecting)
    {
      bool adminHasEmptyPassword;
      string errorMessage;
      if (!ignoreDemoStart && !RemoteServiceProvider.StartDemoServer(this.url, this.CreateProgressDialog, (Action<string>) null, out adminHasEmptyPassword, out errorMessage))
        throw new InvalidOperationException(errorMessage);
      bool? isWebServiceUrl = this.isWebServiceUrl;
      int? port;
      RemoteServiceProvider.WaitForWebInitialized((object) this.url, isReconnecting, ref isWebServiceUrl, out port, out adminHasEmptyPassword, this.CreateProgressDialog, showBackupMessage: this.ShowBackupMessage);
      this.IsWebServiceUrl = isWebServiceUrl.HasValue && isWebServiceUrl.Value;
      if (isWebServiceUrl.HasValue && isWebServiceUrl.Value && this.CheckDesignerPackages && !isReconnecting)
        this.CheckPackages(this.url);
      string url1 = UrlHelper.PrepareUrl(this.url, port, this.remotingServiceName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909159963));
      if (Logger.Log.IsDebugEnabled())
        Logger.Log.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561057566));
      this.cfgServiceProvider = (ConfigurationServiceProvider) Activator.GetObject(typeof (ConfigurationServiceProvider), url1);
      if (Logger.Log.IsDebugEnabled())
        Logger.Log.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475881171));
      if (Logger.Log.IsDebugEnabled())
        Logger.Log.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319444002));
      int count;
      try
      {
        count = this.cfgServiceProvider.Count;
      }
      catch (AuthenticationException ex)
      {
        if (RemotingClientSecurityContext.Current == null || RemotingClientSecurityContext.Current.Token == Guid.Empty)
        {
          throw;
        }
        else
        {
          RemotingClientSecurityContext.Current.Token = Guid.Empty;
          count = this.cfgServiceProvider.Count;
        }
      }
      if (Logger.Log.IsDebugEnabled())
        Logger.Log.Debug((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951494770), (object) count));
      List<object> services = new List<object>();
      for (int index = 0; index < count; ++index)
      {
        RemoteServiceInfo remoteServiceInfo;
        try
        {
          remoteServiceInfo = this.cfgServiceProvider.Get(index);
        }
        catch (AuthenticationException ex1)
        {
          if (RemotingClientSecurityContext.Current == null || RemotingClientSecurityContext.Current.Token == Guid.Empty)
          {
            throw;
          }
          else
          {
            RemotingClientSecurityContext.Current.Token = Guid.Empty;
            try
            {
              remoteServiceInfo = this.cfgServiceProvider.Get(index);
            }
            catch (RemotingException ex2)
            {
              throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123621162)));
            }
          }
        }
        catch (RemotingException ex)
        {
          throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323099290)));
        }
        if (remoteServiceInfo != null)
        {
          Type type;
          try
          {
            type = Type.GetType(remoteServiceInfo.AssemblyQualifiedTypeName);
            if (type == (Type) null)
              throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082389074));
          }
          catch (Exception ex)
          {
            Logger.Log.Error((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372742979) + remoteServiceInfo.AssemblyQualifiedTypeName), ex);
            continue;
          }
          string url2 = UrlHelper.PrepareUrl(this.url, port, RemotingServices.GetObjectUri((MarshalByRefObject) remoteServiceInfo.Reference), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787468257));
          if (Logger.Log.IsDebugEnabled())
            Logger.Log.Debug((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333751180), (object) index, (object) remoteServiceInfo.AssemblyQualifiedTypeName, (object) url2));
          object obj = Activator.GetObject(type, url2);
          if (Logger.Log.IsDebugEnabled())
            Logger.Log.Debug((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138934302), (object) index));
          services.Add(obj);
        }
        else if (Logger.Log.IsDebugEnabled())
          Logger.Log.Debug((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1012095117), (object) index));
      }
      return (IEnumerable<object>) services;
    }

    private void CheckPackages(string url)
    {
      int num1 = 3;
      IEnumerable<ElmaPackageInfo> elmaPackageInfos;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_11;
          case 2:
            try
            {
              elmaPackageInfos = new PackageDataServiceClient(new Uri(UrlHelper.PrepareUrl(url, new int?(), (string) RemoteServiceProvider.CKZDLiTfgtQl902oYtA(95909607 + 343705423 ^ 439590530), (string) null))).GetInstalledPackages();
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0)
                num2 = 0;
              switch (num2)
              {
              }
            }
            catch (Exception ex)
            {
              int num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
                num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    RemoteServiceProvider.DN3IDHTuXj2WcJcZ29l(RemoteServiceProvider.BwPNVXT808Y8BmmmgQu(), RemoteServiceProvider.BFxFohTZLM0LMF1lYE2(RemoteServiceProvider.CKZDLiTfgtQl902oYtA(44884861 ^ 44860335)), (object) ex);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_47;
                }
              }
            }
            break;
          case 3:
            elmaPackageInfos = (IEnumerable<ElmaPackageInfo>) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 2;
            continue;
          case 4:
            goto label_46;
        }
label_47:
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 1;
      }
label_46:
      return;
label_11:
      try
      {
        if (elmaPackageInfos == null)
          return;
        int num4 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
          num4 = 2;
        PackageService packageService;
        IEnumerable<PackageOperationInfo> requiredOperations;
        string str1;
        while (true)
        {
          switch (num4)
          {
            case 1:
              RemoteServiceProvider.Rw0fXyTqy0C26ETV4fZ(RemoteServiceProvider.ki7jaUTRpukxSED8XK5());
              num4 = 6;
              continue;
            case 2:
              if (elmaPackageInfos.Any<ElmaPackageInfo>())
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 3 : 2;
                continue;
              }
              goto label_15;
            case 3:
              packageService = new PackageService();
              num4 = 13;
              continue;
            case 4:
              RemoteServiceProvider.qgXYRjTSaGPXrEXUEQg((object) packageService);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 7 : 4;
              continue;
            case 5:
              RemoteServiceProvider.wdLXtMTVQ1bAV6Ekbnt((object) packageService, false);
              num4 = 4;
              continue;
            case 6:
              goto label_37;
            case 7:
              requiredOperations = packageService.GetRequiredOperations(elmaPackageInfos);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 11 : 6;
              continue;
            case 8:
              str1 = UrlHelper.PrepareUrl(url, new int?(), (string) RemoteServiceProvider.CKZDLiTfgtQl902oYtA(--1867379187 ^ 1867354439), (string) null);
              num4 = 9;
              continue;
            case 9:
              packageService.ExecuteOperations(requiredOperations, new PackageOperationOptions()
              {
                PackageServerUrl = str1,
                StartAfterUpdate = true
              });
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 1 : 1;
              continue;
            case 11:
              if (requiredOperations.Any<PackageOperationInfo>())
              {
                num4 = 12;
                continue;
              }
              goto label_25;
            case 12:
              if (this.ShowQuestion == null)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
                continue;
              }
              goto case 14;
            case 13:
              RemoteServiceProvider.PIy40eTIN30OxG2o7yo((object) packageService, RemoteServiceProvider.CKZDLiTfgtQl902oYtA(1470998129 - 231418599 ^ 1239560074));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 5 : 3;
              continue;
            case 14:
              if (this.ShowQuestion((string) RemoteServiceProvider.BFxFohTZLM0LMF1lYE2(RemoteServiceProvider.CKZDLiTfgtQl902oYtA(-1998538950 ^ -1998530956))))
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 10 : 2;
                continue;
              }
              goto label_34;
            default:
              ILogger log = Logger.Log;
              object obj1 = RemoteServiceProvider.CKZDLiTfgtQl902oYtA(1253244298 - 1829393894 ^ -576142000);
              object separator = RemoteServiceProvider.CKZDLiTfgtQl902oYtA(~1767720452 ^ -1767712059);
              IEnumerable<PackageOperationInfo> source = requiredOperations;
              // ISSUE: reference to a compiler-generated field
              Func<PackageOperationInfo, string> func = RemoteServiceProvider.\u003C\u003Ec.\u003C\u003E9__57_0;
              Func<PackageOperationInfo, string> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                RemoteServiceProvider.\u003C\u003Ec.\u003C\u003E9__57_0 = selector = (Func<PackageOperationInfo, string>) (o => o.ToString());
              }
              else
                goto label_49;
label_36:
              IEnumerable<string> values = source.Select<PackageOperationInfo, string>(selector);
              string str2 = string.Join((string) separator, values);
              object obj2 = RemoteServiceProvider.BFxFohTZLM0LMF1lYE2((object) ((string) obj1 + str2));
              RemoteServiceProvider.ItUimoTiV9FN5KFrb28((object) log, obj2);
              num4 = 8;
              continue;
label_49:
              selector = func;
              goto label_36;
          }
        }
label_37:
        return;
label_34:
        return;
label_25:
        return;
label_15:;
      }
      catch (Exception ex)
      {
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
          num5 = 3;
        while (true)
        {
          switch (num5)
          {
            case 0:
              goto label_10;
            case 1:
              this.ShowWarning((string) RemoteServiceProvider.TLe71wTXQQbmigkHs7r(RemoteServiceProvider.BFxFohTZLM0LMF1lYE2(RemoteServiceProvider.CKZDLiTfgtQl902oYtA(1218962250 ^ 1218936844)), RemoteServiceProvider.CKZDLiTfgtQl902oYtA(654297945 ^ 654288999), RemoteServiceProvider.uqL8W2TKPqqFZoTeulx((object) ex)));
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 2 : 0;
              continue;
            case 2:
              ((ILogger) RemoteServiceProvider.BwPNVXT808Y8BmmmgQu()).Warn(RemoteServiceProvider.BFxFohTZLM0LMF1lYE2(RemoteServiceProvider.CKZDLiTfgtQl902oYtA(-680446928 - -370807692 ^ -309648134)), ex);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
              continue;
            case 3:
              if (this.ShowWarning != null)
              {
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 1;
                continue;
              }
              goto case 2;
            default:
              goto label_8;
          }
        }
label_10:
        return;
label_8:;
      }
    }

    private static ServerInfo CreateServerInfoService(object url)
    {
      int num = 2;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            str = UrlHelper.PrepareUrl((string) url, new int?(), (string) RemoteServiceProvider.CKZDLiTfgtQl902oYtA(1218962250 ^ 1218937062), (string) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
            continue;
          case 2:
            ProxySettings proxySettings = new ProxySettings();
            RemoteServiceProvider.MsjXWiTTYcDLEqODFC9((object) proxySettings);
            // ISSUE: reference to a compiler-generated field
            RemoteCertificateValidationCallback validationCallback1 = RemoteServiceProvider.\u003C\u003Ec.\u003C\u003E9__58_0;
            RemoteCertificateValidationCallback validationCallback2;
            if (validationCallback1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              RemoteServiceProvider.\u003C\u003Ec.\u003C\u003E9__58_0 = validationCallback2 = (RemoteCertificateValidationCallback) ((sender, certificate, chain, sslPolicyErrors) => true);
            }
            else
              goto label_7;
label_6:
            RemoteServiceProvider.FMWaxvTk6gmbAUsnIFX((object) validationCallback2);
            RemoteServiceProvider.B4rwXETORlMi17nHpk5(RemoteServiceProvider.QCUNOaTnglQ8F7CVuse((object) proxySettings));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 1;
            continue;
label_7:
            validationCallback2 = validationCallback1;
            goto label_6;
          default:
            goto label_3;
        }
      }
label_3:
      ServerInfo serverInfoService = new ServerInfo();
      RemoteServiceProvider.h50kuqT2hkc54ReCbSL((object) serverInfoService, (object) str);
      return serverInfoService;
    }

    private static WebRequest CreateServerUpdatePackageStatus(object url)
    {
      int num1 = 5;
      string str;
      while (true)
      {
        int num2 = num1;
        CultureInfo cultureInfo;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_7;
            case 2:
              if (cultureInfo != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 3:
              goto label_3;
            case 4:
              str = UrlHelper.PrepareUrl((string) url, new int?(), (string) RemoteServiceProvider.CKZDLiTfgtQl902oYtA(1149433385 + 173655049 ^ 1323096572), (string) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 1;
              continue;
            case 5:
              ProxySettings proxySettings = new ProxySettings();
              RemoteServiceProvider.MsjXWiTTYcDLEqODFC9((object) proxySettings);
              RemoteServiceProvider.FMWaxvTk6gmbAUsnIFX((object) (RemoteCertificateValidationCallback) ((sender, certificate, chain, sslPolicyErrors) => true));
              RemoteServiceProvider.B4rwXETORlMi17nHpk5(RemoteServiceProvider.QCUNOaTnglQ8F7CVuse((object) proxySettings));
              num2 = 4;
              continue;
            default:
              str = (string) RemoteServiceProvider.TLe71wTXQQbmigkHs7r((object) str, RemoteServiceProvider.CKZDLiTfgtQl902oYtA(-1317790512 ^ -1317766952), (object) cultureInfo.Name);
              num2 = 3;
              continue;
          }
        }
label_7:
        cultureInfo = RemoteServiceProvider.CurrentCultureInfo();
        num1 = 2;
      }
label_3:
      return (WebRequest) RemoteServiceProvider.tLmjyJTeKvBuTL2XZPe((object) str);
    }

    private static RemoteServiceProvider.WaitWebStartResult WaitForWebStarted(
      object url,
      TimeSpan portOpenTimeout,
      TimeSpan webServiceTimeout)
    {
      int num1 = 1;
      RemoteServiceProvider.WaitWebStartResult waitWebStartResult;
      while (true)
      {
        int num2 = num1;
        int port;
        CultureInfo cultureInfo;
        DateTime dateTime;
        ServerInfo serverInfo1;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
              port = UrlHelper.GetPort((string) url);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
              continue;
            case 2:
              ServerInfo serverInfo2 = new ServerInfo();
              RemoteServiceProvider.h50kuqT2hkc54ReCbSL((object) serverInfo2, (object) str);
              serverInfo1 = serverInfo2;
              num2 = 13;
              continue;
            case 3:
              goto label_4;
            case 4:
              cultureInfo = (CultureInfo) RemoteServiceProvider.ARlkFFTNccABXmlTE68();
              num2 = 11;
              continue;
            case 5:
            case 9:
              if (RemoteServiceProvider.G5FfRrT1muLdnRKP55v(port))
              {
                num2 = 4;
                continue;
              }
              goto case 8;
            case 6:
              try
              {
                RemoteServiceProvider.PecqpvTp8abqV3TL8Vd((object) serverInfo1, cultureInfo == null ? (object) string.Empty : RemoteServiceProvider.ckuX2ST3Yf9rwwfqSye((object) cultureInfo));
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_4;
                }
              }
              catch (Exception ex)
              {
                int num4 = 4;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
                  num4 = 6;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_5;
                    case 2:
                      RemoteServiceProvider.gEv3k0TaiDDcYGeltbv((object) Logger.Log, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470462150), (object) ex);
                      num4 = 5;
                      continue;
                    case 3:
                      ((ILogger) RemoteServiceProvider.BwPNVXT808Y8BmmmgQu()).Warn(RemoteServiceProvider.CKZDLiTfgtQl902oYtA(-342626196 - 1290888215 ^ -1633495091), ex);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 4 : 0;
                      continue;
                    case 4:
                      RemoteServiceProvider.LDMITYTD4hZ2x5wP8Da(1000);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
                      continue;
                    case 5:
                      waitWebStartResult = RemoteServiceProvider.WaitWebStartResult.RequestFailed;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 1 : 1;
                      continue;
                    case 6:
                      if (RemoteServiceProvider.QSliLwTPrnbrT33F4jn() - dateTime > webServiceTimeout)
                      {
                        num4 = 2;
                        continue;
                      }
                      goto case 3;
                    default:
                      goto label_29;
                  }
                }
              }
            case 7:
label_29:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 6 : 4;
              continue;
            case 8:
              if (!(RemoteServiceProvider.QSliLwTPrnbrT33F4jn() - dateTime > portOpenTimeout))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 12 : 4;
                continue;
              }
              goto label_7;
            case 10:
              goto label_7;
            case 11:
              str = UrlHelper.PrepareUrl((string) url, new int?(), (string) RemoteServiceProvider.CKZDLiTfgtQl902oYtA(712480695 ^ 712504347), (string) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 2 : 2;
              continue;
            case 12:
              Thread.Sleep(1000);
              num2 = 9;
              continue;
            case 13:
              dateTime = DateTime.Now;
              num2 = 7;
              continue;
            default:
              goto label_11;
          }
        }
label_11:
        dateTime = RemoteServiceProvider.QSliLwTPrnbrT33F4jn();
        num1 = 5;
      }
label_4:
      return RemoteServiceProvider.WaitWebStartResult.Success;
label_5:
      return waitWebStartResult;
label_7:
      return RemoteServiceProvider.WaitWebStartResult.PortClosed;
    }

    internal static bool byGCAiXcn59htuY5vwA() => RemoteServiceProvider.P8YYLFXsoqPuboIWZme == null;

    internal static RemoteServiceProvider O9R8MEXzxC8nxC2R2Eo() => RemoteServiceProvider.P8YYLFXsoqPuboIWZme;

    internal static bool LnaNjkTFOTSyLlBOxm9([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void kLMf0OTB5MA6YxjSSLt([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object hHmSXgTWi5FIGmV4R5p([In] object obj0) => (object) RemoteServiceProvider.CreateServerInfoService(obj0);

    internal static Type jDO85WToXOkfx6KraNE([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object uqkfE3TbNIPXXmPyl6d([In] object obj0, [In] object obj1) => RemoteServiceProvider.RegisterProxiedService(obj0, obj1);

    internal static object p4x08xThg6xfAQ81LIc() => (object) ComponentManager.Builder;

    internal static object o45GNbTGWuJgGHx6d6T() => (object) IPGlobalProperties.GetIPGlobalProperties();

    internal static object xG0D1QTEYMtvn71gQMI([In] object obj0) => (object) ((IPGlobalProperties) obj0).GetActiveTcpListeners();

    internal static object CKZDLiTfgtQl902oYtA(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object M7lT8MTQtmQ0k9o3W5y([In] object obj0) => (object) EleWise.ELMA.SR.ReadFromFile((string) obj0);

    internal static object hEt1qQTC2NsCihMmj7v() => (object) EleWise.ELMA.SR.KeyCultureInfo;

    internal static object h68hpeTvDJHs6SHt9p8([In] object obj0) => (object) ((LanguageHolder) obj0).GetCulture();

    internal static object BwPNVXT808Y8BmmmgQu() => (object) Logger.Log;

    internal static object BFxFohTZLM0LMF1lYE2([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void DN3IDHTuXj2WcJcZ29l([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Warn(obj1, (Exception) obj2);

    internal static void PIy40eTIN30OxG2o7yo([In] object obj0, [In] object obj1) => ((PackageService) obj0).ComponentName = (string) obj1;

    internal static void wdLXtMTVQ1bAV6Ekbnt([In] object obj0, bool value) => ((PackageService) obj0).UseConsole = value;

    internal static void qgXYRjTSaGPXrEXUEQg([In] object obj0) => ((PackageService) obj0).Initialize();

    internal static void ItUimoTiV9FN5KFrb28([In] object obj0, [In] object obj1) => ((ILogger) obj0).Debug(obj1);

    internal static object ki7jaUTRpukxSED8XK5() => (object) Process.GetCurrentProcess();

    internal static void Rw0fXyTqy0C26ETV4fZ([In] object obj0) => ((Process) obj0).Kill();

    internal static object uqL8W2TKPqqFZoTeulx([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static object TLe71wTXQQbmigkHs7r([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static void MsjXWiTTYcDLEqODFC9([In] object obj0) => ((ProxySettings) obj0).Load();

    internal static void FMWaxvTk6gmbAUsnIFX([In] object obj0) => ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback) obj0;

    internal static object QCUNOaTnglQ8F7CVuse([In] object obj0) => (object) ((ProxySettings) obj0).GenerateProxy();

    internal static void B4rwXETORlMi17nHpk5([In] object obj0) => WebRequest.DefaultWebProxy = (IWebProxy) obj0;

    internal static void h50kuqT2hkc54ReCbSL([In] object obj0, [In] object obj1) => ((ServerInfo) obj0).Url = (string) obj1;

    internal static object tLmjyJTeKvBuTL2XZPe([In] object obj0) => (object) WebRequest.Create((string) obj0);

    internal static DateTime QSliLwTPrnbrT33F4jn() => DateTime.Now;

    internal static bool G5FfRrT1muLdnRKP55v(int port) => RemoteServiceProvider.IsPortOpened(port);

    internal static object ARlkFFTNccABXmlTE68() => (object) RemoteServiceProvider.CurrentCultureInfo();

    internal static object ckuX2ST3Yf9rwwfqSye([In] object obj0) => (object) ((CultureInfo) obj0).Name;

    internal static object PecqpvTp8abqV3TL8Vd([In] object obj0, [In] object obj1) => (object) ((ServerInfo) obj0).GetStartInformationLocalized((string) obj1);

    internal static void gEv3k0TaiDDcYGeltbv([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void LDMITYTD4hZ2x5wP8Da([In] int obj0) => Thread.Sleep(obj0);

    private enum WaitWebStartResult
    {
      Success,
      PortClosed,
      RequestFailed,
    }
  }
}
