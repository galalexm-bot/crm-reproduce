// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPM.Mvc.Application.Orchard.ELMAEnviromentStarter
// Assembly: EleWise.ELMA.BPM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EE1B80B5-F464-4FFF-85CF-6A69B66F676D
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.BPM.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.BPM.xml

using Autofac;
using Autofac.Builder;
using Autofac.Integration.Web;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.BPM.Mvc.Application.Orchard.Security;
using EleWise.ELMA.BPM.Properties;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Events.Impl;
using EleWise.ELMA.Extensions.PostgreSQL;
using EleWise.ELMA.Files;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Licensing.Storages;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.Server;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.SessionProviders;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Impl;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Binders;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.MarkupRendering;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Models.Portal;
using EleWise.ELMA.Web.Mvc.Services;
using EleWise.ELMA.Web.Mvc.Util;
using EleWise.ELMA.Web.Orchard.Enviroment.Configuration;
using EleWise.ELMA.Web.Orchard.Security;
using EleWise.ELMA.WebCompiler;
using j3AmrhgkCleVTGdEwA;
using Orchard.Environment;
using Orchard.Environment.Configuration;
using Orchard.Security;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Compilation;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.WebPages.Razor;
using System.Xml;
using System.Xml.Xsl;

namespace EleWise.ELMA.BPM.Mvc.Application.Orchard
{
  /// <summary>Класс для запуска приложения</summary>
  public static class ELMAEnviromentStarter
  {
    private static readonly object StartLockObject;
    private static string[] _assembiesPath;
    private static string _configurationFileName;
    private static readonly Type SessionsContainerProviderType;
    private static ContainerBuilder _containerBuilder;
    private static bool _initializedVirtualPathProviders;
    private static ComponentManager _componentManager;
    private static ELMAEnviromentStarter.StartStep _startStep;
    private static IStartControl startControl;
    private static ELMAEnviromentStarter bcGJgaiTgsV2UUoT6jM;

    /// <summary>
    /// Инициализация провайдеров метаданных. По умолчанию создается ElmaModelMetadataProvider
    /// </summary>
    public static void InitMetadataProviders() => ELMAEnviromentStarter.ci2E8QillRR6NDSAqR7((object) new ElmaModelMetadataProvider());

    /// <summary>Провайдер контейнера Autofac</summary>
    public static IContainerProvider ContainerProvider { get; private set; }

    /// <summary>Текст ошибки запуска приложения</summary>
    public static string StartupExceptionText { get; private set; }

    /// <summary>Ошибка запуска приложения</summary>
    public static Exception StartupException { get; private set; }

    /// <summary>Хост Orchard-а</summary>
    public static IOrchardHost OrchardHost { get; private set; }

    /// <summary>Инициализировано ли приложение</summary>
    public static bool Initialized => ELMAEnviromentStarter._startStep == ELMAEnviromentStarter.StartStep.Complete;

    /// <summary>
    /// Запустить приложение или возобновить его запуск (например, после ошибки лицензирования) в отдельном потоке
    /// </summary>
    public static void StartApplication()
    {
      int num1 = 5;
      while (true)
      {
        ThreadStart start;
        switch (num1)
        {
          case 1:
            goto label_11;
          case 2:
            goto label_5;
          case 3:
            // ISSUE: reference to a compiler-generated field
            ELMAEnviromentStarter.<>c.<>9__19_0 = start = (ThreadStart) (() =>
            {
              int num2 = 2;
              object startLockObject;
              bool lockTaken;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    lockTaken = false;
                    num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_aa29a0a33c2e4af7b4d50c14e116e14e != 0 ? 0 : 0;
                    continue;
                  case 2:
                    startLockObject = ELMAEnviromentStarter.StartLockObject;
                    num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_ad2a81f32dcf4a9dabeb5a77049960b6 == 0 ? 1 : 1;
                    continue;
                  case 3:
                    goto label_13;
                  default:
                    goto label_2;
                }
              }
label_13:
              return;
label_2:
              try
              {
                Monitor.Enter(startLockObject, ref lockTaken);
                int num3 = 0;
                if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_2af84c7d16434d6bb9d7477c8de31530 != 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_10;
                    default:
                      // ISSUE: reference to a compiler-generated method
                      ELMAEnviromentStarter.<>c.cepndwAIEjTLugYVX0R();
                      num3 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_96725b0c498d48b0811257a7f5ebec9b == 0 ? 1 : 1;
                      continue;
                  }
                }
label_10:;
              }
              finally
              {
                int num4;
                if (!lockTaken)
                  num4 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_97b683f617e640659cafc539b8e993b2 != 0 ? 0 : 0;
                else
                  goto label_11;
label_9:
                switch (num4)
                {
                  case 1:
                    break;
                  default:
                }
label_11:
                // ISSUE: reference to a compiler-generated method
                ELMAEnviromentStarter.<>c.SrWwREApMhRKfV0UGNu(startLockObject);
                num4 = 2;
                if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_5af002e0863d4b95bd3930e3b7dabcc8 == 0)
                {
                  num4 = 1;
                  goto label_9;
                }
                else
                  goto label_9;
              }
            });
            break;
          case 4:
            if (ELMAEnviromentStarter.hqO3kHi3t0D6tfpldKa((object) StartInformation.Root) != StartStatus.Started)
            {
              num1 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_7696b2a1c8a74f81a5f18299c2ab5f1f == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 5:
            ELMAEnviromentStarter.tIZjQfibdUomU6NE2yQ();
            num1 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_bc1caf7c63e343118488ccfdd03f17f1 != 0 ? 2 : 4;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            ThreadStart threadStart = ELMAEnviromentStarter.<>c.<>9__19_0;
            if (threadStart == null)
            {
              num1 = 3;
              continue;
            }
            start = threadStart;
            break;
          default:
            if (((StartInformation) ELMAEnviromentStarter.Ta26CZixVY6sQR1VtTl()).Status == StartStatus.NotStarted)
            {
              num1 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_dd156353ddc1435bb580bfff814a7c9a != 0 ? 1 : 1;
              continue;
            }
            ELMAEnviromentStarter.VIM0miicGGjfLPTCoku(ELMAEnviromentStarter.Ta26CZixVY6sQR1VtTl(), StartStatus.Running);
            num1 = 6;
            continue;
        }
        Thread thread = new Thread(start);
        ELMAEnviromentStarter.NIHRCSiFcb8pjR2ZcPS((object) thread, (object) (CultureInfo) ELMAEnviromentStarter.XXVr5OiNd8N4iTPnccI(ELMAEnviromentStarter.HMaZMIiWI5jTF6niulj(ELMAEnviromentStarter.Ug62Tsi9v6XGxoNyO1v())));
        ELMAEnviromentStarter.sgdyRViwFp8P5V5Lgyl((object) thread, (object) (CultureInfo) ELMAEnviromentStarter.XXVr5OiNd8N4iTPnccI(ELMAEnviromentStarter.h41geCiZspua1BD2RT7(ELMAEnviromentStarter.Ug62Tsi9v6XGxoNyO1v())));
        thread.Start();
        num1 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_ba2e33edfd5c4d10910c526ce19c8d72 != 0 ? 2 : 0;
      }
label_11:
      return;
label_5:
      return;
label_2:;
    }

    /// <summary>
    /// Продолжить запуск сервера с того места, где приостановились
    /// </summary>
    public static void Continue()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (ELMAEnviromentStarter.hqO3kHi3t0D6tfpldKa(ELMAEnviromentStarter.Ta26CZixVY6sQR1VtTl()) != StartStatus.Started)
            {
              num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_548d43c65bbe47f0899304a136990dba == 0 ? 0 : 0;
              continue;
            }
            goto label_9;
          case 2:
            goto label_2;
          case 3:
            goto label_7;
          default:
            if (ELMAEnviromentStarter.hqO3kHi3t0D6tfpldKa((object) StartInformation.Root) == StartStatus.NotStarted)
            {
              num = 3;
              continue;
            }
            ELMAEnviromentStarter.bSfxpLikMjLDe1pCrON((object) ELMAEnviromentStarter.startControl);
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_dd156353ddc1435bb580bfff814a7c9a != 0 ? 2 : 1;
            continue;
        }
      }
label_2:
      return;
label_7:
      return;
label_9:;
    }

    /// <summary>
    /// Запустить приложение или возобновить его запуск (например, после ошибки лицензирования)
    /// </summary>
    private static void StartApplicationInThread()
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        CallContextSessionOwner contextSessionOwner;
        TLSContextBoundVariableService instance1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_117;
            case 1:
              try
              {
                ContainerBuilder builder = new ContainerBuilder();
                ELMAEnviromentStarter.Db1vhniYTyJj0dNR428((object) builder, (object) new LoggingModule());
                builder.RegisterModule((Autofac.Core.IModule) new LazyResolverModule());
                ELMAEnviromentStarter.Db1vhniYTyJj0dNR428((object) builder, ELMAEnviromentStarter.WFJeZQiBJr6MMu0Dkst());
                IContainer container = (IContainer) ELMAEnviromentStarter.P1Z1JLihT61uHScYmTV((object) builder, ContainerBuildOptions.None);
                int num3 = 0;
                if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_3a7a324caceb407fb2d6bf16404557bb == 0)
                  num3 = 2;
                IStartInformation startInformation1;
                IStartInformation startInformation2;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_7;
                    case 2:
                      ELMAEnviromentStarter.NZQqIOi1PmAv627oSlm((object) new AutofacLocatorImpl(container));
                      num3 = 5;
                      continue;
                    case 3:
                      ELMAEnviromentStarter.VIM0miicGGjfLPTCoku(ELMAEnviromentStarter.Ta26CZixVY6sQR1VtTl(), StartStatus.Started);
                      num3 = 7;
                      continue;
                    case 4:
                      try
                      {
                        int num4 = 0;
                        if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_cd867fd8e34648a7a62174a6af9dc6dd != 0)
                          num4 = 0;
                        Scheduler service;
                        IOrchardHost orchardHost;
                        ShellSettings shellSettings;
                        while (true)
                        {
                          switch (num4)
                          {
                            case 1:
                              ELMAEnviromentStarter.InitRazorCompileEvents();
                              num4 = 22;
                              continue;
                            case 2:
                              ELMAEnviromentStarter.HGanInuydlEJRiciPN1((object) orchardHost);
                              num4 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_40efb04ff6e44269a2aef7173a630bc9 != 0 ? 9 : 9;
                              continue;
                            case 3:
                              shellSettings = container.Resolve<ELMAShellSettingsManager>().LoadSettings().First<ShellSettings>();
                              num4 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_095e2fcf55f94b538dd6bcd94ba4bb6c == 0 ? 2 : 0;
                              continue;
                            case 4:
                              ELMAEnviromentStarter.ContainerProvider = (IContainerProvider) new Autofac.Integration.Web.ContainerProvider(container);
                              num4 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_36dd3da07e034b65bf22c31089e30166 == 0 ? 3 : 5;
                              continue;
                            case 5:
                              orchardHost = container.Resolve<IOrchardHost>();
                              num4 = 3;
                              continue;
                            case 6:
                              ELMAEnviromentStarter.SUdBapu0PjcRl5q4BHi((object) Locator.GetServiceNotNull<IAutoDeployService>());
                              num4 = 21;
                              continue;
                            case 7:
                              ELMAEnviromentStarter.yoQ1Bxu5SblRno4kds2();
                              num4 = 15;
                              continue;
                            case 8:
                              ELMAEnviromentStarter.PEVOpRun2KgPeJ8KHma((object) shellSettings, TenantState.Running);
                              num4 = 11;
                              continue;
                            case 9:
                              ELMAEnviromentStarter.D6GrtDuAIFxapwpnd04((object) Locator.GetServiceNotNull<IRuntimeApplication>());
                              num4 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_156094dc453849b0aac6aa735e572dfe != 0 ? 2 : 6;
                              continue;
                            case 10:
                              ELMAEnviromentStarter.S42sZ0u7e3rguQYOAT2((object) ((ComponentManager) ELMAEnviromentStarter.crlRt9ufCri9dYEZFJB()).GetExtensionPoints<IActorInitHandler>().Select<IActorInitHandler, Task>((Func<IActorInitHandler, Task>) (h =>
                              {
                                int num5 = 6;
                                // ISSUE: variable of a compiler-generated type
                                ELMAEnviromentStarter.<>c__DisplayClass32_1.\u003C\u003CStartApplicationInThread\u003Eb__1\u003Ed stateMachine;
                                while (true)
                                {
                                  int num6 = num5;
                                  AsyncTaskMethodBuilder tBuilder;
                                  while (true)
                                  {
                                    switch (num6)
                                    {
                                      case 1:
                                        goto label_6;
                                      case 2:
                                        tBuilder.Start<ELMAEnviromentStarter.<>c__DisplayClass32_1.\u003C\u003CStartApplicationInThread\u003Eb__1\u003Ed>(ref stateMachine);
                                        num6 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_c2c4269a248d4bc299a5490bd62bc8f3 != 0 ? 1 : 1;
                                        continue;
                                      case 3:
                                        // ISSUE: reference to a compiler-generated field
                                        tBuilder = stateMachine.<>t__builder;
                                        num6 = 2;
                                        continue;
                                      case 4:
                                        // ISSUE: reference to a compiler-generated field
                                        stateMachine.<>1__state = -1;
                                        num6 = 3;
                                        continue;
                                      case 5:
                                        // ISSUE: reference to a compiler-generated field
                                        stateMachine.h = (object) h;
                                        num6 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_7e0aea3ee18648ebaa860fcd5264d37f != 0 ? 0 : 0;
                                        continue;
                                      case 6:
                                        goto label_8;
                                      default:
                                        // ISSUE: reference to a compiler-generated field
                                        stateMachine.<>t__builder = AsyncTaskMethodBuilder.Create();
                                        num6 = 4;
                                        continue;
                                    }
                                  }
label_8:
                                  // ISSUE: reference to a compiler-generated field
                                  stateMachine.<>4__this = (object) this;
                                  num5 = 5;
                                }
label_6:
                                // ISSUE: reference to a compiler-generated field
                                return stateMachine.<>t__builder.Task;
                              })).ToArray<Task>());
                              num4 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_09d6ea8f51184538876ee96c32a45b45 == 0 ? 5 : 8;
                              continue;
                            case 11:
                              ELMAEnviromentStarter.MulpSEutcSrN9Sprsf4((object) orchardHost);
                              num4 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_2513aaffd25e4974936a273e23bdb4fc != 0 ? 7 : 13;
                              continue;
                            case 12:
                              ELMAEnviromentStarter.FCyvDku8sBRxusqqwEW((object) ELMAEnviromentStarter._componentManager);
                              num4 = 14;
                              continue;
                            case 13:
                              goto label_89;
                            case 14:
                              service = Locator.GetService<Scheduler>();
                              num4 = 16;
                              continue;
                            case 15:
                              ELMAEnviromentStarter.EN23SjuP2AvyFhYZBn0();
                              num4 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_4658b846616d4b809f44001e9422aa59 != 0 ? 20 : 2;
                              continue;
                            case 16:
                              if (service == null)
                              {
                                num4 = 19;
                                continue;
                              }
                              goto case 18;
                            case 17:
                            case 19:
                              IActorModelRuntime actorModelRuntime = Locator.GetServiceNotNull<IActorModelRuntime>();
                              num4 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_11df0b0286bd46b6a8780d914c7488e8 != 0 ? 10 : 8;
                              continue;
                            case 18:
                              ELMAEnviromentStarter.TH5ccCuMaojGNNXVE7a((object) service);
                              num4 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_e3c5f5fc1e564390911b44e74f171948 != 0 ? 11 : 17;
                              continue;
                            case 20:
                              ELMAEnviromentStarter.EGulP3uXpZ6k6X7mGvn();
                              num4 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_2513aaffd25e4974936a273e23bdb4fc != 0 ? 0 : 1;
                              continue;
                            case 21:
                              ELMAEnviromentStarter.lW4SDruahVcmVvnA9n1((object) container);
                              num4 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_2af84c7d16434d6bb9d7477c8de31530 != 0 ? 7 : 1;
                              continue;
                            case 22:
                              ELMAEnviromentStarter.uJ4fpWuUJBMNeUYcYno();
                              num4 = 12;
                              continue;
                            default:
                              ELMAEnviromentStarter.OQJqV1uVcDg868Z6YcX((object) container);
                              num4 = 4;
                              continue;
                          }
                        }
                      }
                      finally
                      {
                        int num7;
                        if (startInformation2 == null)
                          num7 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_a42be3548a0b4e9e83b37d0bf541ae98 != 0 ? 0 : 0;
                        else
                          goto label_84;
label_83:
                        switch (num7)
                        {
                          case 2:
                            break;
                          default:
                        }
label_84:
                        ELMAEnviromentStarter.p0WMT8uurcn6cVETnhK((object) startInformation2);
                        num7 = 0;
                        if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_64d949edaec444e99f80ad55ba91e956 == 0)
                        {
                          num7 = 1;
                          goto label_83;
                        }
                        else
                          goto label_83;
                      }
                    case 5:
                      startInformation1 = (IStartInformation) ELMAEnviromentStarter.KpBULniRK8kZaoP4x5U(88.0, ELMAEnviromentStarter.JBLVfeimJU7IXTcvCTV(ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-1211322258 ^ -1211321350)));
                      num3 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_cd867fd8e34648a7a62174a6af9dc6dd != 0 ? 0 : 0;
                      continue;
                    case 6:
label_89:
                      ((StartInformation) ELMAEnviromentStarter.Ta26CZixVY6sQR1VtTl()).SetInfo(100.0, EleWise.ELMA.SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1989827099 ^ 1989828215)));
                      num3 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_d19ebe6f48644904ab62fb4bb255c02a != 0 ? 3 : 3;
                      continue;
                    case 7:
                      ELMAEnviromentStarter._startStep = ELMAEnviromentStarter.StartStep.Complete;
                      num3 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_8a3a8efb220d4e37a7dc5c6ebb6ec931 != 0 ? 1 : 0;
                      continue;
                    case 8:
label_54:
                      startInformation2 = (IStartInformation) ELMAEnviromentStarter.KpBULniRK8kZaoP4x5U(100.0, ELMAEnviromentStarter.JBLVfeimJU7IXTcvCTV(ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-463184181 - 913717236 ^ -1376902401)));
                      num3 = 4;
                      continue;
                    default:
                      try
                      {
                        int num8 = 1;
                        if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_5af002e0863d4b95bd3930e3b7dabcc8 == 0)
                          num8 = 1;
                        while (true)
                        {
                          int num9;
                          ComponentManager componentManager;
                          WebSessionBoundVariableService instance2;
                          PackageService packageService;
                          switch (num8)
                          {
                            case 1:
                              if (ELMAEnviromentStarter._startStep == ELMAEnviromentStarter.StartStep.Beginning)
                              {
                                num8 = 27;
                                continue;
                              }
                              goto case 17;
                            case 2:
                              PackageServerRoutes.MapRoutes((RouteCollection) ELMAEnviromentStarter.nh0mLpiQARNDmTL6IB3(), (Func<IEnumerable<ElmaPackageInfo>>) (() => packageService.GetInstalledPackagesInfos()));
                              num8 = 18;
                              continue;
                            case 3:
                              ELMAEnviromentStarter.kNXHwuipvHgk8nq42OT((object) ELMAEnviromentStarter._componentManager, (object) ELMAEnviromentStarter._assembiesPath, ELMAEnviromentStarter.dKoVOOiIFewWiGOlRv5((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-492443955 << 3 ^ 355415442)));
                              num8 = 20;
                              continue;
                            case 4:
                              goto label_54;
                            case 5:
                            case 10:
                              ELMAEnviromentStarter.PgBLMJizgNO3MB3OwLl((object) packageService);
                              num9 = 7;
                              break;
                            case 6:
                              componentManager.ActivationKeyStorages = (IEnumerable<IActivationKeyStorage>) new FileSystemActivationKeyStorage[1]
                              {
                                new FileSystemActivationKeyStorage(HostingEnvironment.MapPath((string) ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(~1800431842 ^ -1800432427)))
                              };
                              num8 = 28;
                              continue;
                            case 7:
                              ELMAEnviromentStarter.ySUa96uiLyHl0vKLFTf(ELMAEnviromentStarter.TbggiuudkFsB314PB0l((object) ELMAEnviromentStarter._componentManager));
                              num8 = 4;
                              continue;
                            case 8:
                              EleWise.ELMA.Web.Orchard.OrchardStarter.BuildContainer(ELMAEnviromentStarter._containerBuilder, new Action<ContainerBuilder>(ELMAEnviromentStarter.MvcSingletons));
                              num8 = 9;
                              continue;
                            case 9:
                              ELMAEnviromentStarter.iGIMxqiCXknlpxuLsRp();
                              num9 = 25;
                              break;
                            case 11:
                              ((PackageServerSettings) ELMAEnviromentStarter.l5Y924iqpAllsHQUbVL()).PackagesPath = (string) ELMAEnviromentStarter.POH0XUirYDXFA7UI13R((object) packageService);
                              num8 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_a42be3548a0b4e9e83b37d0bf541ae98 != 0 ? 2 : 0;
                              continue;
                            case 12:
                              ELMAEnviromentStarter.zIjZUXi6RiDfwF0Kp1H((object) instance2);
                              num8 = 19;
                              continue;
                            case 13:
                              ELMAEnviromentStarter.r6P1iKig7Nfh2afjhPC((object) packageService, (object) Path.ChangeExtension(ELMAEnviromentStarter._configurationFileName, (string) ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-1801939602 ^ -1801940612)));
                              num8 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_36dd3da07e034b65bf22c31089e30166 == 0 ? 5 : 5;
                              continue;
                            case 14:
                              ELMAEnviromentStarter._containerBuilder = new ContainerBuilder();
                              num8 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_aa54a61f50a144bab587b55f0c6b0d70 == 0 ? 0 : 0;
                              continue;
                            case 15:
                              ELMAEnviromentStarter.RegisterRoutes((object) RouteTable.Routes);
                              num8 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_740ef59153ff4ad09b1da3c952318a34 == 0 ? 26 : 21;
                              continue;
                            case 16:
                              componentManager = new ComponentManager(ComponentType.Server | ComponentType.WebServer | ComponentType.Web, ELMAEnviromentStarter.startControl, ELMAEnviromentStarter._containerBuilder);
                              num8 = 6;
                              continue;
                            case 17:
                              ELMAEnviromentStarter.hOUBGMisg38xwRW5DG7((object) ELMAEnviromentStarter._componentManager);
                              num8 = 3;
                              continue;
                            case 18:
                              if (!ELMAEnviromentStarter.R2hn14iHhVjbSd9RyaZ((object) Locator.GetServiceNotNull<IRuntimeApplication>()))
                              {
                                num8 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_af15875e39ef47b5a9d9cbc7c3416cda == 0 ? 1 : 10;
                                continue;
                              }
                              goto case 13;
                            case 19:
                              ELMAEnviromentStarter.FPrjJPiePH88ZECE72r();
                              num8 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_8bb670bf0c514ecb87c6e60e7438e06f != 0 ? 2 : 14;
                              continue;
                            case 20:
                              packageService = (PackageService) ELMAEnviromentStarter.dOosBSiJjeuiYTjrX2v((object) ELMAEnviromentStarter._componentManager);
                              num8 = 21;
                              continue;
                            case 21:
                              if (ELMAEnviromentStarter.TBicKliGoT7H7DPIUxU((object) packageService))
                              {
                                num8 = 11;
                                continue;
                              }
                              goto case 7;
                            case 22:
                              ELMAEnviromentStarter._containerBuilder.RegisterInstance<WebSessionBoundVariableService>(instance2).As<ISessionBoundVariableService>();
                              num8 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_5fc6cb15dbd84be7b6f01c9d3d0dc6f3 == 0 ? 7 : 8;
                              continue;
                            case 23:
                              ELMAEnviromentStarter.PYMcKsijS0jBnMckFpN((object) ELMAEnviromentStarter._componentManager, (object) ELMAEnviromentStarter._assembiesPath);
                              num9 = 17;
                              break;
                            case 24:
                              ELMAEnviromentStarter.Ow6Ze4iOxbdIE7IruLu(ELMAEnviromentStarter.dOosBSiJjeuiYTjrX2v((object) ELMAEnviromentStarter._componentManager), ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(1426076321 ^ 1426075985));
                              num8 = 23;
                              continue;
                            case 25:
                              ELMAEnviromentStarter.startControl = (IStartControl) new WebStartControl();
                              num8 = 16;
                              continue;
                            case 26:
                              instance2 = new WebSessionBoundVariableService((IHttpContextAccessor) new HttpContextAccessor());
                              num8 = 12;
                              continue;
                            case 27:
                              ELMAEnviromentStarter.QuTKbGiD5GXqIvDoTLM(false);
                              num8 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_a42be3548a0b4e9e83b37d0bf541ae98 == 0 ? 15 : 15;
                              continue;
                            case 28:
                              ELMAEnviromentStarter._componentManager = componentManager;
                              num8 = 24;
                              continue;
                            default:
                              ELMAEnviromentStarter._containerBuilder.RegisterInstance<TLSContextBoundVariableService>(instance1).As<IContextBoundVariableService>();
                              num8 = 22;
                              continue;
                          }
                          num8 = num9;
                        }
                      }
                      finally
                      {
                        if (startInformation1 != null)
                        {
                          int num10 = 0;
                          if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_fd3679bc010041e3a8928acd2f20039d == 0)
                            num10 = 0;
                          while (true)
                          {
                            switch (num10)
                            {
                              case 1:
                                goto label_53;
                              default:
                                ELMAEnviromentStarter.p0WMT8uurcn6cVETnhK((object) startInformation1);
                                num10 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_2e6b66a525ef416896f51ed50ad0cc95 != 0 ? 0 : 1;
                                continue;
                            }
                          }
                        }
label_53:;
                      }
                  }
                }
              }
              catch (Exception ex1)
              {
                int num11 = 9;
                Action<Exception> action;
                RequiredInstallStoreComponentsException componentsException;
                while (true)
                {
                  Exception exception;
                  switch (num11)
                  {
                    case 1:
                    case 6:
                      action(exception);
                      num11 = 4;
                      continue;
                    case 2:
                      goto label_111;
                    case 3:
                      if (componentsException == null)
                      {
                        num11 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_a2d1cecc368149d18a15dc8b377c30d5 == 0 ? 0 : 1;
                        continue;
                      }
                      break;
                    case 4:
                      goto label_96;
                    case 5:
                      goto label_101;
                    case 7:
                      action = (Action<Exception>) (ex =>
                      {
                        int num12 = 7;
                        ReflectionTypeLoadException typeLoadException;
                        string message;
                        while (true)
                        {
                          switch (num12)
                          {
                            case 1:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              ELMAEnviromentStarter.<>c__DisplayClass32_2.oZkHbg0l3ClSjXbxXGL(ELMAEnviromentStarter.<>c__DisplayClass32_2.qQQtdR04WhTEVXPOOEH(), StartErrorType.Fatal);
                              num12 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_fc100e2d814f4e7192dfe01b010266e6 == 0 ? 12 : 3;
                              continue;
                            case 2:
                              // ISSUE: reference to a compiler-generated method
                              object obj = ELMAEnviromentStarter.<>c__DisplayClass32_2.n9S1NK08EhB6VRsd5Jn(1871800628 ^ 1871804656);
                              // ISSUE: reference to a compiler-generated method
                              object source = ELMAEnviromentStarter.<>c__DisplayClass32_2.GigMgt0MvTe3doH2P38((object) typeLoadException);
                              // ISSUE: reference to a compiler-generated field
                              Func<Exception, string> func = ELMAEnviromentStarter.<>c.<>9__32_3;
                              Func<Exception, string> selector;
                              if (func == null)
                              {
                                // ISSUE: reference to a compiler-generated field
                                ELMAEnviromentStarter.<>c.<>9__32_3 = selector = (Func<Exception, string>) (e => e.ToString());
                              }
                              else
                                goto label_22;
label_20:
                              string[] array = ((IEnumerable<Exception>) source).Select<Exception, string>(selector).ToArray<string>();
                              // ISSUE: reference to a compiler-generated method
                              message = (string) ELMAEnviromentStarter.<>c__DisplayClass32_2.wnWbk80fE1mbpohxxj4(obj, (object) array);
                              num12 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_ab8d580240e141e78a71cd5bb0b681e7 != 0 ? 10 : 4;
                              continue;
label_22:
                              selector = func;
                              goto label_20;
                            case 3:
                            case 11:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              ELMAEnviromentStarter.<>c__DisplayClass32_2.N2eVrW0tLM4Pv8xS030(ELMAEnviromentStarter.<>c__DisplayClass32_2.oJYH9P07ZdyrmjSIDHE(), (object) ex);
                              num12 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_56d8b8d7dcf34e22b9d74eac50c9d637 == 0 ? 0 : 5;
                              continue;
                            case 4:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              ELMAEnviromentStarter.<>c__DisplayClass32_2.btpJom0LHGpL4THR432(ELMAEnviromentStarter.<>c__DisplayClass32_2.qQQtdR04WhTEVXPOOEH(), ELMAEnviromentStarter.<>c__DisplayClass32_2.HcUftG0KsAuHqiJMvRg((object) ex));
                              num12 = 14;
                              continue;
                            case 5:
                              ELMAEnviromentStarter._startStep = ELMAEnviromentStarter.StartStep.FatalError;
                              num12 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_ad2a81f32dcf4a9dabeb5a77049960b6 != 0 ? 5 : 15;
                              continue;
                            case 6:
                              if (typeLoadException == null)
                              {
                                num12 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_5dcd693abeec43fab3651cd27dc827f6 != 0 ? 3 : 2;
                                continue;
                              }
                              goto case 2;
                            case 7:
                              typeLoadException = ex as ReflectionTypeLoadException;
                              num12 = 6;
                              continue;
                            case 8:
                              goto label_18;
                            case 9:
                              ex = (Exception) new ApplicationException(message);
                              num12 = 11;
                              continue;
                            case 10:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              ELMAEnviromentStarter.<>c__DisplayClass32_2.wXG5dG0ne85FyV7tc2k(ELMAEnviromentStarter.<>c__DisplayClass32_2.oJYH9P07ZdyrmjSIDHE(), (object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1091253946 >> 4 ^ -68199074) + message), (object) exception);
                              num12 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_5fc6cb15dbd84be7b6f01c9d3d0dc6f3 != 0 ? 9 : 9;
                              continue;
                            case 12:
                              if (!(Locator.GetService<IRuntimeApplication>() is IDisposable service2))
                              {
                                num12 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_a72bc60a96cc47d38d9a08c9d2375255 == 0 ? 13 : 8;
                                continue;
                              }
                              // ISSUE: reference to a compiler-generated method
                              ELMAEnviromentStarter.<>c__DisplayClass32_2.AX6eyQ0bxcFogoHKbvk((object) service2);
                              num12 = 8;
                              continue;
                            case 13:
                              goto label_11;
                            case 14:
                              // ISSUE: reference to a compiler-generated method
                              ((StartInformation) ELMAEnviromentStarter.<>c__DisplayClass32_2.qQQtdR04WhTEVXPOOEH()).Status = StartStatus.NotStarted;
                              num12 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_156094dc453849b0aac6aa735e572dfe != 0 ? 0 : 1;
                              continue;
                            case 15:
                              // ISSUE: reference to a compiler-generated method
                              ELMAEnviromentStarter.<>c__DisplayClass32_2.kDSJRg02TZKvoB3F3u5((object) ex);
                              num12 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_d31d5b2f5dd84087974bba620422adc4 != 0 ? 0 : 0;
                              continue;
                            default:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              ELMAEnviromentStarter.<>c__DisplayClass32_2.EVWyQT0TqZTtiwr2s4l((object) (ex.ToString() + ELMAEnviromentStarter.<>c__DisplayClass32_2.n9S1NK08EhB6VRsd5Jn(1561482429 ^ 1561478837) + ELMAEnviromentStarter.<>c__DisplayClass32_2.HcUftG0KsAuHqiJMvRg((object) ex) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2029288941 ^ -1405279196 ^ 725005375) + ELMAEnviromentStarter.<>c__DisplayClass32_2.Xc6fsE0vLTIU7Mn9STZ((object) ex) + ELMAEnviromentStarter.<>c__DisplayClass32_2.n9S1NK08EhB6VRsd5Jn(-648254717 ^ -648251125) + ELMAEnviromentStarter.<>c__DisplayClass32_2.jyVqZZ0SekIb8LehuDW((object) ex)));
                              num12 = 4;
                              continue;
                          }
                        }
label_18:
                        return;
label_11:;
                      });
                      num11 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_289810c0c3734c9ab735510ba793157a != 0 ? 8 : 1;
                      continue;
                    case 8:
                      componentsException = exception as RequiredInstallStoreComponentsException;
                      num11 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_1fa223eab32142609596a8548a5ae713 != 0 ? 3 : 3;
                      continue;
                    case 9:
                      exception = ex1;
                      num11 = 7;
                      continue;
                  }
                  ELMAEnviromentStarter.naAha8u2Bk3D2sMiBSr((object) StartInformation.Root, ELMAEnviromentStarter.JBLVfeimJU7IXTcvCTV(ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(592025051 ^ 592023895)));
                  num11 = 5;
                }
label_111:
                return;
label_96:
                return;
label_101:
                try
                {
                  ((PackageService) ELMAEnviromentStarter.dOosBSiJjeuiYTjrX2v((object) ELMAEnviromentStarter._componentManager)).InstallStoreComponents(componentsException.ComponentsInfo, ELMAEnviromentStarter.uqCCT7uKBb91Rp6b7tt(), false);
                  int num13 = 0;
                  if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_2513aaffd25e4974936a273e23bdb4fc != 0)
                    num13 = 0;
                  switch (num13)
                  {
                    case 0:
                      return;
                    default:
                      return;
                  }
                }
                catch (Exception ex2)
                {
                  int num14 = 0;
                  if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_90d5c0398ebf4c45ac16be46887eda04 != 0)
                    num14 = 0;
                  while (true)
                  {
                    switch (num14)
                    {
                      case 1:
                        goto label_104;
                      default:
                        action(ex2);
                        num14 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_6453e511cd4a4b6394f4dead0bc7bd76 == 0 ? 1 : 1;
                        continue;
                    }
                  }
label_104:
                  return;
                }
              }
              finally
              {
                ELMAEnviromentStarter.w32fm7uveCfaXisasrw((object) contextSessionOwner);
                int num15 = 0;
                if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_36dd3da07e034b65bf22c31089e30166 != 0)
                  num15 = 0;
                switch (num15)
                {
                  default:
                }
              }
            case 2:
label_7:
              ELMAEnviromentStarter.Y90kBguTbViAqbJUwqf(ELMAEnviromentStarter.dPMEKyuSeC6hJyZrLlF(), ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-1663575568 ^ -1663574766));
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_1f1bf1fb830545b89c7d7c5edeff1500 != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_3;
            case 4:
              if (ELMAEnviromentStarter._startStep != ELMAEnviromentStarter.StartStep.FatalError)
              {
                instance1 = new TLSContextBoundVariableService();
                num2 = 6;
                continue;
              }
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_09d6ea8f51184538876ee96c32a45b45 != 0 ? 3 : 1;
              continue;
            case 5:
              if (ELMAEnviromentStarter._startStep != ELMAEnviromentStarter.StartStep.Complete)
              {
                num2 = 4;
                continue;
              }
              goto label_95;
            case 6:
              goto label_6;
            case 7:
              contextSessionOwner = CallContextSessionOwner.Create();
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_2e6b66a525ef416896f51ed50ad0cc95 == 0 ? 1 : 0;
              continue;
            default:
              goto label_113;
          }
        }
label_6:
        ELMAEnviromentStarter.WYd6cYiEyDp7q10LogD((object) instance1);
        num1 = 7;
      }
label_117:
      return;
label_3:
      return;
label_113:
      return;
label_95:;
    }

    /// <summary>
    /// Зарегистрируем событие для обработки компиляции представлений
    /// </summary>
    private static void InitRazorCompileEvents()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ELMAEnviromentStarter.WsxdEXu43QcUo3LRL9Q((object) new EventHandler(ELMAEnviromentStarter.RazorBuildProviderCodeGenerationStarted));
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_506d1ddb63bc485196e8152411b402a4 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private static void RazorBuildProviderCodeGenerationStarted(object sender, object e)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        Assembly loadedAssembly;
        Assembly assembly;
        RazorBuildProvider provider;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_11;
            case 1:
              // ISSUE: reference to a compiler-generated method
              if (!((ComponentManager) ELMAEnviromentStarter.crlRt9ufCri9dYEZFJB()).GetExtensionPoints<IDynamicAssemblyIgnore>().Any<IDynamicAssemblyIgnore>((Func<IDynamicAssemblyIgnore, bool>) (ep => ep.ShouldIgnore((string) ELMAEnviromentStarter.<>c__DisplayClass34_0.eipA5y09Oi3CAwRLZxl((object) provider)))))
              {
                num2 = 4;
                continue;
              }
              goto label_19;
            case 2:
            case 7:
              assembly = (Assembly) ELMAEnviromentStarter.tII3S1u3vDRYZegWl9Y(ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(574126904 ^ 574127734), false);
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_6453e511cd4a4b6394f4dead0bc7bd76 == 0 ? 3 : 2;
              continue;
            case 3:
              if (ELMAEnviromentStarter.Cxl69luLGaJYQlIS8tY((object) assembly, (object) null))
              {
                num2 = 9;
                continue;
              }
              goto label_4;
            case 4:
              loadedAssembly = ComponentManager.FindLoadedAssembly(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1114125150 ^ 1114125906), false);
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_1f1bf1fb830545b89c7d7c5edeff1500 == 0 ? 10 : 10;
              continue;
            case 5:
              provider = (RazorBuildProvider) sender;
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_09d6ea8f51184538876ee96c32a45b45 == 0 ? 1 : 1;
              continue;
            case 6:
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_f48d22e37b594f439dff2aec8625848e != 0 ? 1 : 5;
              continue;
            case 8:
              ELMAEnviromentStarter.Vc9Qx7ub7PfijNOLFW5(ELMAEnviromentStarter.Qt3tXCulvtyysHYTWwi((object) provider), (object) loadedAssembly);
              num2 = 2;
              continue;
            case 9:
              ELMAEnviromentStarter.Vc9Qx7ub7PfijNOLFW5((object) provider.AssemblyBuilder, (object) assembly);
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_90d5c0398ebf4c45ac16be46887eda04 == 0 ? 0 : 0;
              continue;
            case 10:
              if (ELMAEnviromentStarter.Cxl69luLGaJYQlIS8tY((object) loadedAssembly, (object) null))
                goto case 8;
              else
                goto label_6;
            case 11:
              goto label_7;
            default:
              goto label_3;
          }
        }
label_6:
        num1 = 7;
      }
label_11:
      return;
label_7:
      return;
label_3:
      return;
label_19:
      return;
label_4:;
    }

    private static void InitEnvironment()
    {
      int num1 = 12;
      MethodInfo method;
      while (true)
      {
        string configurationDirectory;
        string path2;
        string str;
        switch (num1)
        {
          case 1:
            goto label_29;
          case 2:
            ELMAEnviromentStarter.efE2GcuZicSqtM4dXSS(ELMAEnviromentStarter.baAsYNuWiy6YZBjOo1F());
            num1 = 9;
            continue;
          case 3:
            str = Path.Combine(((AppDomain) ELMAEnviromentStarter.baAsYNuWiy6YZBjOo1F()).BaseDirectory, path2);
            break;
          case 4:
            ELMAEnviromentStarter.HwYiQGu15qvwJJWS93r(ELMAEnviromentStarter.dPMEKyuSeC6hJyZrLlF(), ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(459505216 ^ 459503654));
            num1 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_506d1ddb63bc485196e8152411b402a4 == 0 ? 1 : 1;
            continue;
          case 5:
            if (ELMAEnviromentStarter.MyJINbuYvJxfVGEdafS((object) method, (object) null))
            {
              num1 = 8;
              continue;
            }
            goto case 4;
          case 6:
            // ISSUE: type reference
            // ISSUE: explicit non-virtual call
            method = __nonvirtual (ELMAEnviromentStarter.noJBbauECk2r2sQgtRp(__typeref (HttpRuntime)).GetMethod((string) ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-78510068 ^ -78508576), BindingFlags.Static | BindingFlags.NonPublic));
            num1 = 5;
            continue;
          case 7:
            if (ELMAEnviromentStarter.YLjODBuF2KssQwAOvsi((object) configurationDirectory, ELMAEnviromentStarter.dKoVOOiIFewWiGOlRv5(ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-1998014674 ^ -1998015868))) | ELMAEnviromentStarter.ApplyConfigTransformation((object) configurationDirectory, ELMAEnviromentStarter.dKoVOOiIFewWiGOlRv5(ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(1241559407 - 4511379 ^ 1237049100))))
            {
              num1 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_7cc517639737482092c19f0a25007f36 != 0 ? 1 : 2;
              continue;
            }
            string[] strArray = new string[1];
            object obj = ELMAEnviromentStarter.AxuY1tuwgrYGCBXr7yJ((object) AppDomain.CurrentDomain);
            strArray[0] = (string) (obj == null ? (object) ((AppDomain) ELMAEnviromentStarter.baAsYNuWiy6YZBjOo1F()).BaseDirectory : obj);
            ELMAEnviromentStarter._assembiesPath = strArray;
            num1 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_dc915391d7c84058a674014d8d1edd8c != 0 ? 1 : 10;
            continue;
          case 8:
            goto label_4;
          case 9:
            goto label_15;
          case 10:
            ELMAEnviromentStarter.d0LhqrukYYictdvFrap((object) ELMAEnviromentStarter._configurationFileName);
            num1 = 6;
            continue;
          case 11:
            if (ELMAEnviromentStarter.cN46U5u9CtwX1wilDj4((object) path2))
            {
              num1 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_bc1caf7c63e343118488ccfdd03f17f1 != 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 12:
            path2 = (string) ELMAEnviromentStarter.YUmBGauc9lv1K9DMZHx(ELMAEnviromentStarter.TY2fA1uxH9a271KDKEK((object) ConfigurationManager.ConnectionStrings, ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-918445578 ^ -918444942)));
            num1 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_ab8d580240e141e78a71cd5bb0b681e7 != 0 ? 11 : 8;
            continue;
          case 13:
            configurationDirectory = (string) ELMAEnviromentStarter.IjPUBsuN9yLeQZUn3Yi((object) ELMAEnviromentStarter._configurationFileName);
            num1 = 7;
            continue;
          default:
            str = path2;
            break;
        }
        ELMAEnviromentStarter._configurationFileName = str;
        num1 = 13;
      }
label_29:
      return;
label_15:
      return;
label_4:
      try
      {
        ELMAEnviromentStarter.frOkvJuBRrmciNpHyCA((object) method, (object) null, (object) new object[1]
        {
          (object) new BuildManagerHostUnloadEventHandler(ELMAEnviromentStarter.OnUnload)
        });
        int num2 = 0;
        if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_eede9d1a8a2948e2a5c225086f16a231 != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_b7021a7940804dbe80770e0d7373c78c != 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_10;
            default:
              ELMAEnviromentStarter.pm0VWyuhTDoKx6CqshA(ELMAEnviromentStarter.dPMEKyuSeC6hJyZrLlF(), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1370191569 ^ 1370190027), (object) ex);
              num3 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_1f1bf1fb830545b89c7d7c5edeff1500 != 0 ? 1 : 1;
              continue;
          }
        }
label_10:;
      }
    }

    private static void OnUnload(object sender, object e)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ELMAEnviromentStarter.XAeyaCuRTVvuW2BJOSI(ELMAEnviromentStarter.dPMEKyuSeC6hJyZrLlF(), ELMAEnviromentStarter.R3Xpprum7dXTeJQna3b(ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(768634488 ^ 768633032), e != null ? (object) ELMAEnviromentStarter.xkltpjuomXVl3WGFdeM(e).ToString() : ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-105446640 << 2 ^ -421786996)));
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_64d949edaec444e99f80ad55ba91e956 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private static void ActivateExternalLicenses() => ELMAEnviromentStarter.Pp78D8uDGn3ua2bXNU1();

    private static void CreateConfigFileIfNotExists(object configurationFileName)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            goto label_3;
          case 2:
            if (!ELMAEnviromentStarter.bF9rLau688Sas23oC9p(configurationFileName))
            {
              object obj = ELMAEnviromentStarter.iHjpi4uexHA0pm5sDig(configurationFileName);
              PostgreSQLSettingsSection sqlSettingsSection = new PostgreSQLSettingsSection();
              // ISSUE: type reference
              sqlSettingsSection.ProviderType = ELMAEnviromentStarter.noJBbauECk2r2sQgtRp(__typeref (PostgreSQLProvider));
              ELMAEnviromentStarter.j94mwwuC5Mru2YFk82k(obj, (object) sqlSettingsSection);
              ELMAEnviromentStarter.mMAWK1uj2OwZD3vRTs3(ELMAEnviromentStarter.zqF5EIuJH5wb7TDGsLb(obj), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(21574782 >> 2 ^ 5393345), ELMAEnviromentStarter.WQTp0UuOXfATYwm0sm5((object) new PostgreSQLConnectionSettings()));
              ((RuntimeConfiguration) obj).Save((string) configurationFileName);
              num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_d19ebe6f48644904ab62fb4bb255c02a == 0 ? 0 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_af15875e39ef47b5a9d9cbc7c3416cda == 0 ? 0 : 1;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_3:
      return;
label_7:;
    }

    private static void RegisterComponents(object componentManager)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            ((ComponentManager) componentManager).RegisterComponent((object) new RuntimeApplication(ELMAEnviromentStarter._configurationFileName, ELMAEnviromentStarter.SessionsContainerProviderType, ELMAEnviromentStarter._assembiesPath, ELMAEnviromentStarter.startControl));
            num = 3;
            continue;
          case 2:
            if (componentManager != null)
            {
              num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_39ab3eb3910c4f408567739982d91be6 != 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          case 3:
            goto label_6;
          default:
            goto label_2;
        }
      }
label_6:
      return;
label_2:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1541009453 ^ -1541011139));
    }

    private static void InitModelValidatorProviders()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ELMAEnviromentStarter.RHaJVIusYcsDl6iFVdj((object) ModelValidatorProviders.Providers);
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_e6f96a787f924f559d55835012f65621 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ((Collection<ModelValidatorProvider>) ELMAEnviromentStarter.u3jejQuIV0rauVNdVyu()).Add((ModelValidatorProvider) new ElmaModelValidatorProvider());
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_548d43c65bbe47f0899304a136990dba != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    private static void InitModelBinders()
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            ELMAEnviromentStarter.quIjBjuGE46S0x1oc3f(ELMAEnviromentStarter.JnhGcZuptcYSnJd0L6e(), typeof (EditableListModel), (object) new EditableListModelBinder());
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_a8d19b8ac515491596472bbbe20cf06b == 0 ? 9 : 5;
            continue;
          case 2:
            // ISSUE: type reference
            ((ModelBinderDictionary) ELMAEnviromentStarter.JnhGcZuptcYSnJd0L6e()).Add(ELMAEnviromentStarter.noJBbauECk2r2sQgtRp(__typeref (Money)), (IModelBinder) new MoneyBinder());
            num = 11;
            continue;
          case 3:
            ((ModelBinderDictionary) ELMAEnviromentStarter.JnhGcZuptcYSnJd0L6e()).Add(typeof (GridState), (IModelBinder) new GridStateModelBinder());
            num = 6;
            continue;
          case 4:
            // ISSUE: type reference
            ModelBinders.Binders.Add(ELMAEnviromentStarter.noJBbauECk2r2sQgtRp(__typeref (DropDownItem)), (IModelBinder) new DropDownItemModelBinder());
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_2e6b66a525ef416896f51ed50ad0cc95 == 0 ? 13 : 10;
            continue;
          case 5:
            // ISSUE: type reference
            ELMAEnviromentStarter.quIjBjuGE46S0x1oc3f(ELMAEnviromentStarter.JnhGcZuptcYSnJd0L6e(), ELMAEnviromentStarter.noJBbauECk2r2sQgtRp(__typeref (HtmlString)), (object) new HtmlStringModelBinder());
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_1b033f19d5da41409a3eb4a638228449 != 0 ? 0 : 4;
            continue;
          case 6:
            // ISSUE: type reference
            ELMAEnviromentStarter.quIjBjuGE46S0x1oc3f(ELMAEnviromentStarter.JnhGcZuptcYSnJd0L6e(), ELMAEnviromentStarter.noJBbauECk2r2sQgtRp(__typeref (ReferenceOnEntityType)), (object) new ReferenceOnEntityTypeBinder());
            num = 7;
            continue;
          case 7:
            // ISSUE: type reference
            ((ModelBinderDictionary) ELMAEnviromentStarter.JnhGcZuptcYSnJd0L6e()).Add(ELMAEnviromentStarter.noJBbauECk2r2sQgtRp(__typeref (ReferenceOnEntity)), (IModelBinder) new ReferenceOnEntityBinder());
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_64d949edaec444e99f80ad55ba91e956 == 0 ? 0 : 0;
            continue;
          case 8:
            // ISSUE: type reference
            ELMAEnviromentStarter.quIjBjuGE46S0x1oc3f((object) ModelBinders.Binders, ELMAEnviromentStarter.noJBbauECk2r2sQgtRp(__typeref (Type)), (object) new TypeBinder());
            num = 3;
            continue;
          case 9:
            // ISSUE: type reference
            ELMAEnviromentStarter.quIjBjuGE46S0x1oc3f(ELMAEnviromentStarter.JnhGcZuptcYSnJd0L6e(), ELMAEnviromentStarter.noJBbauECk2r2sQgtRp(__typeref (DateTime)), (object) new DateTimeBinder());
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_8bb670bf0c514ecb87c6e60e7438e06f != 0 ? 9 : 12;
            continue;
          case 10:
            goto label_2;
          case 11:
            // ISSUE: type reference
            ELMAEnviromentStarter.quIjBjuGE46S0x1oc3f(ELMAEnviromentStarter.JnhGcZuptcYSnJd0L6e(), ELMAEnviromentStarter.noJBbauECk2r2sQgtRp(__typeref (PortalModel)), (object) new PortalModelBinder());
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_d3c92aa8b2de4fa6b7d7008c5b9e8bb8 == 0 ? 1 : 0;
            continue;
          case 12:
            // ISSUE: type reference
            ELMAEnviromentStarter.quIjBjuGE46S0x1oc3f((object) ModelBinders.Binders, ELMAEnviromentStarter.noJBbauECk2r2sQgtRp(__typeref (DateTime?)), (object) new NullableDateTimeBinder());
            num = 8;
            continue;
          case 13:
            // ISSUE: type reference
            ModelBinders.Binders.Add(ELMAEnviromentStarter.noJBbauECk2r2sQgtRp(__typeref (BinaryFile)), (IModelBinder) new FilesModelBinder());
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_dc915391d7c84058a674014d8d1edd8c != 0 ? 2 : 2;
            continue;
          default:
            ELMAEnviromentStarter.RtjYsWuqG3LXfRkL7OQ(ELMAEnviromentStarter.JnhGcZuptcYSnJd0L6e(), (object) new ElmaModelBinder());
            num = 10;
            continue;
        }
      }
label_2:;
    }

    private static void InitVirtualPathProviders(object container)
    {
      int num1 = 22;
      while (true)
      {
        int num2 = num1;
        string path;
        bool flag;
        string str1;
        string str2;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 14:
              ELMAEnviromentStarter.hLRdPeug5CkjCOZTkyw((object) new DirectoryMapVirtualPathProvider((IDictionary<string, string>) new Dictionary<string, string>()
              {
                {
                  (string) ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-788178853 ^ -788180849),
                  (string) ELMAEnviromentStarter.R3Xpprum7dXTeJQna3b((object) str1, ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-1998014674 ^ -1998012476))
                },
                {
                  (string) ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-78510068 ^ -78511886),
                  (string) ELMAEnviromentStarter.R3Xpprum7dXTeJQna3b((object) str1, ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-1278372248 ^ -1278369924))
                }
              }));
              num2 = 6;
              continue;
            case 2:
              ELMAEnviromentStarter.fOiS0puzXA5f0imVXfE(ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-1347357619 ^ -1347355535));
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_90d5c0398ebf4c45ac16be46887eda04 != 0 ? 1 : 12;
              continue;
            case 3:
              ELMAEnviromentStarter.lQhQwSuHOGkE4cbjvqK((object) ((IComponentContext) container).Resolve<ApplicationDirectoryFileWatcher>(), ELMAEnviromentStarter.EErW5kurHuM6OEjwUL8(ELMAEnviromentStarter.BuXdYXuQlb9duFt1yRW(ELMAEnviromentStarter.dKoVOOiIFewWiGOlRv5(ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(230249011 ^ 230249805)), ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-1159094452 ^ -1159096118))));
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_eede9d1a8a2948e2a5c225086f16a231 == 0 ? 4 : 3;
              continue;
            case 4:
              str1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1903117678 << 4 ^ -385110342);
              num2 = 20;
              continue;
            case 5:
              EleWise.ELMA.WebCompiler.BuildManager.Init(HostingEnvironment.MapPath((string) ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-918872692 ^ -918873442)), Path.Combine(str2, (string) ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-1266583950 ^ -1266585238)), (ICompiler) new WebCompilerCompiler(), new AssemblyLoader(ComponentManager.LoadAssembly), (ICompilerConsole) new WebCompilerConsole());
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_fd5d0b0e0b504f3d993007bf914ac481 != 0 ? 5 : 11;
              continue;
            case 6:
              HostingEnvironment.RegisterVirtualPathProvider((VirtualPathProvider) new ConfigDirectoryMapVirtualPathProvider(new string[5]
              {
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(487544033 - 1707708025 ^ -1220161728),
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(1732745317 ^ 1732743515),
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-1258710890 ^ 1258713021),
                (string) ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-1347357619 ^ -1347355469),
                (string) ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(~1800431842 ^ -1800430001)
              }));
              num2 = 16;
              continue;
            case 7:
              ELMAEnviromentStarter.hLRdPeug5CkjCOZTkyw((object) ((IComponentContext) container).Resolve<ExtendableVirtualPathProvider>());
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_a4a0d03145aa4a86bff873b4ae1fb8c0 == 0 ? 18 : 9;
              continue;
            case 8:
              goto label_30;
            case 9:
              path = (string) ELMAEnviromentStarter.EErW5kurHuM6OEjwUL8((object) Path.Combine((string) ELMAEnviromentStarter.dKoVOOiIFewWiGOlRv5(ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(--159677755 ^ 159676969)), (string) ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-2043838496 << 1 ^ 207288568)));
              num2 = 19;
              continue;
            case 10:
              HostingEnvironment.RegisterVirtualPathProvider((VirtualPathProvider) new EleWise.ELMA.Web.Mvc.MapPathBasedVirtualPathProvider());
              num2 = 9;
              continue;
            case 11:
              ((IComponentContext) container).Resolve<EleWise.ELMA.Services.ConfigurationDirectoryFileWatcher>().Init(str2);
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_64d949edaec444e99f80ad55ba91e956 != 0 ? 0 : 10;
              continue;
            case 12:
              CompilingModuleInfo compilingModuleInfo = new CompilingModuleInfo();
              compilingModuleInfo.PhysicalPath = (string) ELMAEnviromentStarter.EErW5kurHuM6OEjwUL8((object) path);
              ELMAEnviromentStarter.LLJVRsVdW9m03ewyatW((object) compilingModuleInfo, ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-1129262482 ^ -1129260522));
              ELMAEnviromentStarter.GfT7CAViLCQaRAT1nf1((object) compilingModuleInfo, ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-993813907 ^ -993815845));
              ELMAEnviromentStarter.CvZLHwVuMfu6WmVKXAQ((object) compilingModuleInfo);
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_b9eca6dfe8884732a6827cac36373c67 != 0 ? 1 : 1;
              continue;
            case 13:
label_28:
              if (!flag)
              {
                num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_d9a87c470c1f44ac8f183ec4ee9ecd32 == 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 16:
              ELMAEnviromentStarter.hLRdPeug5CkjCOZTkyw((object) new OnTheFlyVirtualPathProvider());
              num2 = 7;
              continue;
            case 17:
              goto label_17;
            case 18:
              ELMAEnviromentStarter._initializedVirtualPathProviders = true;
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_7e0aea3ee18648ebaa860fcd5264d37f != 0 ? 17 : 5;
              continue;
            case 19:
              try
              {
                flag = Directory.Exists(path);
                int num3 = 0;
                if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_2464724164964761ae144e148281de96 != 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_28;
                }
              }
              catch
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_2513aaffd25e4974936a273e23bdb4fc == 0)
                  num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      flag = false;
                      num4 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_dc915391d7c84058a674014d8d1edd8c == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_28;
                  }
                }
              }
            case 20:
              ELMAEnviromentStarter.hLRdPeug5CkjCOZTkyw((object) new DirectoryMapVirtualPathProvider((IDictionary<string, string>) new Dictionary<string, string>()
              {
                {
                  (string) ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(23940103 ^ -391120056 ^ -373116749),
                  str1
                }
              }));
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_05dd5584c291425186f18d13c4d42cc8 != 0 ? 0 : 2;
              continue;
            case 21:
              goto label_31;
            case 22:
              if (!ELMAEnviromentStarter._initializedVirtualPathProviders)
              {
                str2 = (string) ELMAEnviromentStarter.IjPUBsuN9yLeQZUn3Yi((object) ELMAEnviromentStarter._configurationFileName);
                num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_1654cf321678466eb4f0d0fa81f71c57 == 0 ? 5 : 0;
                continue;
              }
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_aa29a0a33c2e4af7b4d50c14e116e14e == 0 ? 14 : 21;
              continue;
            default:
              ELMAEnviromentStarter.lQhQwSuHOGkE4cbjvqK((object) ((IComponentContext) container).Resolve<ApplicationDirectoryFileWatcher>(), ELMAEnviromentStarter.dKoVOOiIFewWiGOlRv5(ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-251119897 << 2 ^ -1004479262)));
              num2 = 8;
              continue;
          }
        }
label_30:
        str1 = (string) ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(1082386042 << 2 ^ 34574804);
        num1 = 14;
      }
label_17:
      return;
label_31:;
    }

    private static void MvcSingletons(object builder)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            ((ContainerBuilder) builder).RegisterType<AuthenticationService>().As<IAuthenticationService>().SetScope<AuthenticationService, ConcreteReflectionActivatorData, SingleRegistrationStyle>(ServiceScope.Shell);
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_fd5d0b0e0b504f3d993007bf914ac481 == 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated method
            ((ContainerBuilder) builder).Register<ModelBinderDictionary>((Func<IComponentContext, ModelBinderDictionary>) (ctx => (ModelBinderDictionary) ELMAEnviromentStarter.<>c.CfkoX9AqaFuFFgcnQx7())).SingleInstance();
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_f48d22e37b594f439dff2aec8625848e != 0 ? 3 : 5;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated method
            ((ContainerBuilder) builder).Register<RouteCollection>((Func<IComponentContext, RouteCollection>) (ctx => (RouteCollection) ELMAEnviromentStarter.<>c.WbAF35AGVLtLJULRm4I())).SingleInstance();
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_64d949edaec444e99f80ad55ba91e956 == 0 ? 2 : 2;
            continue;
          case 4:
            goto label_7;
          case 5:
            object builder1 = builder;
            // ISSUE: reference to a compiler-generated field
            Func<IComponentContext, ViewEngineCollection> func = ELMAEnviromentStarter.<>c.<>9__43_2;
            Func<IComponentContext, ViewEngineCollection> @delegate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              ELMAEnviromentStarter.<>c.<>9__43_2 = @delegate = (Func<IComponentContext, ViewEngineCollection>) (ctx => (ViewEngineCollection) ELMAEnviromentStarter.<>c.c711KjArlA6Gn6eTqi4());
            }
            else
              goto label_10;
label_9:
            ((ContainerBuilder) builder1).Register<ViewEngineCollection>(@delegate).SingleInstance();
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_af15875e39ef47b5a9d9cbc7c3416cda == 0 ? 0 : 1;
            continue;
label_10:
            @delegate = func;
            goto label_9;
          default:
            ((ContainerBuilder) builder).RegisterType<AuthorizeService>().As<IAuthorizationService>().SetScope<AuthorizeService, ConcreteReflectionActivatorData, SingleRegistrationStyle>(ServiceScope.Shell);
            num = 4;
            continue;
        }
      }
label_7:;
    }

    private static void RegisterRoutes(object routes)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ELMAEnviromentStarter.LCkAKIVVoXKt2PYNQWn(routes, ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-1372383459 - 1174808806 ^ 1747773267));
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_14c1f3814bb4448e843101334e2cace6 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private static bool ApplyConfigTransformation(
      object configurationDirectory,
      object originalFile)
    {
      int num1 = 3;
      FileStream inStream;
      string str;
      string path;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              Directory.CreateDirectory(Path.GetDirectoryName(str));
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_66d49fdeecf54e10a77a49f850a37630 != 0 ? 11 : 10;
              continue;
            case 2:
              path = (string) ELMAEnviromentStarter.lqXanGVAfmHEa85HCM6(configurationDirectory, ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-508321835 ^ -508323635), ELMAEnviromentStarter.iFbBLSV0PBvSEvihqve((object) System.Environment.MachineName, ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-1445050060 ^ -1445052258), ELMAEnviromentStarter.oyLxcXVyCQx1FkZ1ois(originalFile), ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(--2124594382 ^ 2124592466)));
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_40efb04ff6e44269a2aef7173a630bc9 == 0 ? 2 : 6;
              continue;
            case 3:
              str = (string) ELMAEnviromentStarter.lqXanGVAfmHEa85HCM6(configurationDirectory, ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-2029288941 ^ -1405279196 ^ 725000495), ELMAEnviromentStarter.R3Xpprum7dXTeJQna3b(ELMAEnviromentStarter.oyLxcXVyCQx1FkZ1ois(originalFile), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1091253946 >> 4 ^ -68205304)));
              num2 = 2;
              continue;
            case 4:
              inStream = new FileStream((string) originalFile, FileMode.Open, FileAccess.ReadWrite);
              num2 = 9;
              continue;
            case 5:
            case 11:
              ELMAEnviromentStarter.nmyoOAV88Or8uDGOUoD((object) (str + (string) ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(623835580 >> 5 ^ 19496573)), ELMAEnviromentStarter.PZr6YRVUTiv0SOPUWbo(ELMAEnviromentStarter.PZr6YRVUTiv0SOPUWbo(ELMAEnviromentStarter.aqg2I4VPvNq7Rie5cij((object) Encoding.UTF8, ELMAEnviromentStarter.U3b8UuV5CBV6wkLviea()), ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-1233675613 ^ -1694390725 ^ 762721630), ELMAEnviromentStarter.E9WddYVX4Y1p08cVCwL(64)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1871800628 ^ 1871798492), ELMAEnviromentStarter.E9WddYVX4Y1p08cVCwL(32)));
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_96725b0c498d48b0811257a7f5ebec9b != 0 ? 11 : 13;
              continue;
            case 6:
              if (ELMAEnviromentStarter.bF9rLau688Sas23oC9p((object) str))
              {
                num2 = 4;
                continue;
              }
              goto case 12;
            case 7:
              if (ELMAEnviromentStarter.pID4AQVaMPCW0r1ges8(ELMAEnviromentStarter.IjPUBsuN9yLeQZUn3Yi((object) str)))
              {
                num2 = 5;
                continue;
              }
              goto case 1;
            case 8:
              goto label_7;
            case 9:
              goto label_18;
            case 10:
            case 13:
              goto label_3;
            case 12:
              if (!File.Exists(path))
              {
                num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_506d1ddb63bc485196e8152411b402a4 != 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            default:
              if (!ELMAEnviromentStarter.bF9rLau688Sas23oC9p((object) (str + (string) ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(1839841176 ^ 1839838760))))
                goto case 7;
              else
                goto label_10;
          }
        }
label_10:
        num1 = 10;
      }
label_3:
      return false;
label_7:
      bool flag;
      return flag;
label_18:
      try
      {
        Stream outStream = (Stream) ELMAEnviromentStarter.PMA7j9VMMRvmTMt7w3I();
        int num3 = 0;
        if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_c4b7427125ef4533ab1e2a6a836611d3 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
            try
            {
              int num4;
              if (!Apply((object) str, (object) inStream, (object) outStream))
                num4 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_c4b7427125ef4533ab1e2a6a836611d3 == 0 ? 19 : 4;
              else
                goto label_42;
label_24:
              Stream stream;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    ELMAEnviromentStarter.d5Riq6VndrvtjbrZxwT((object) stream);
                    num4 = 2;
                    continue;
                  case 2:
                  case 18:
                    ELMAEnviromentStarter.BirG9eVf0UXD5h1jlVs((object) inStream, 0L, SeekOrigin.Begin);
                    num4 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_7c40ac701de4410b93c2e183fd3d2a4f != 0 ? 22 : 6;
                    continue;
                  case 3:
                    outStream.Dispose();
                    num4 = 25;
                    continue;
                  case 4:
                    if (!ELMAEnviromentStarter.qhvHIoVtgU83V9L2kZJ((object) inStream, (object) outStream))
                    {
                      num4 = 13;
                      continue;
                    }
                    goto case 12;
                  case 5:
                  case 13:
                    inStream.SetLength(0L);
                    num4 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_506d1ddb63bc485196e8152411b402a4 != 0 ? 10 : 0;
                    continue;
                  case 6:
                  case 9:
                    ELMAEnviromentStarter.BirG9eVf0UXD5h1jlVs((object) stream, 0L, SeekOrigin.Begin);
                    num4 = 17;
                    continue;
                  case 7:
                  case 8:
                  case 11:
                    goto label_7;
                  case 10:
                    ELMAEnviromentStarter.BirG9eVf0UXD5h1jlVs((object) outStream, 0L, SeekOrigin.Begin);
                    num4 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_d31d5b2f5dd84087974bba620422adc4 == 0 ? 14 : 10;
                    continue;
                  case 12:
                    flag = false;
                    num4 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_5dcd693abeec43fab3651cd27dc827f6 != 0 ? 11 : 8;
                    continue;
                  case 14:
                    ELMAEnviromentStarter.HaBtghV2LWnSW2I9g3V((object) outStream, (object) inStream);
                    num4 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_962090912078457cb15ebe6f9b5fadf9 != 0 ? 11 : 20;
                    continue;
                  case 15:
                  case 16:
                    if (stream != inStream)
                    {
                      num4 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_e6f08215bca1461baf0a083db17b54f3 != 0 ? 0 : 1;
                      continue;
                    }
                    goto case 2;
                  case 17:
                    if (ELMAEnviromentStarter.huJxnSV7KQiPHslYOO9((object) path, (object) stream, (object) outStream))
                    {
                      num4 = 15;
                      continue;
                    }
                    goto case 23;
                  case 19:
                  case 24:
                    stream = (Stream) inStream;
                    num4 = 9;
                    continue;
                  case 20:
                    flag = true;
                    num4 = 8;
                    continue;
                  case 21:
                    goto label_42;
                  case 22:
                    ELMAEnviromentStarter.BirG9eVf0UXD5h1jlVs((object) outStream, 0L, SeekOrigin.Begin);
                    num4 = 4;
                    continue;
                  case 23:
                    if (stream == inStream)
                    {
                      num4 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_ba2e33edfd5c4d10910c526ce19c8d72 != 0 ? 0 : 0;
                      continue;
                    }
                    goto case 3;
                  case 25:
                    outStream = stream;
                    num4 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_0595b787e6c04ce0b75955c2cfb98f12 != 0 ? 18 : 16;
                    continue;
                  case 26:
                    outStream = (Stream) ELMAEnviromentStarter.PMA7j9VMMRvmTMt7w3I();
                    num4 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_ab8f72009ce842dcb89f3b07799e8f31 != 0 ? 6 : 2;
                    continue;
                  default:
                    flag = false;
                    num4 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_1a002da92eea49dc9ab414b7afe61297 != 0 ? 6 : 7;
                    continue;
                }
              }
label_42:
              stream = outStream;
              num4 = 26;
              goto label_24;
            }
            finally
            {
              ELMAEnviromentStarter.d5Riq6VndrvtjbrZxwT((object) outStream);
              int num5 = 0;
              if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_7696b2a1c8a74f81a5f18299c2ab5f1f != 0)
                num5 = 0;
              switch (num5)
              {
                default:
              }
            }
        }
      }
      finally
      {
        int num6;
        if (inStream == null)
          num6 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_09d6ea8f51184538876ee96c32a45b45 != 0 ? 1 : 1;
        else
          goto label_55;
label_54:
        switch (num6)
        {
          case 1:
          case 2:
        }
label_55:
        ELMAEnviromentStarter.p0WMT8uurcn6cVETnhK((object) inStream);
        num6 = 2;
        goto label_54;
      }

      static bool Apply(object xsltPath, object inStream, object outStream)
      {
        int num1 = 5;
        XslCompiledTransform compiledTransform1;
        XmlReader xmlReader;
        while (true)
        {
          switch (num1)
          {
            case 1:
              XslCompiledTransform compiledTransform2 = compiledTransform1;
              object obj1 = xsltPath;
              XsltSettings xsltSettings = new XsltSettings();
              ELMAEnviromentStarter.TXLc8NVxqmGPYUu7uAg((object) xsltSettings, true);
              ELMAEnviromentStarter.Cy4fMdVcTqi7mY14orW((object) compiledTransform2, obj1, (object) xsltSettings, (object) null);
              num1 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_50d154664afc4b2f8f6da5de661b4a33 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_26;
            case 3:
              goto label_5;
            case 4:
              compiledTransform1 = new XslCompiledTransform();
              num1 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_14d3ba5c3cce406d89f5b3bd64118b88 != 0 ? 0 : 1;
              continue;
            case 5:
              if (File.Exists((string) xsltPath))
              {
                num1 = 4;
                continue;
              }
              goto label_26;
            case 6:
              goto label_6;
            default:
              object obj2 = inStream;
              XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
              ELMAEnviromentStarter.jRAl0tV9gIs3jbmm3Ci((object) xmlReaderSettings, false);
              xmlReader = (XmlReader) ELMAEnviromentStarter.shfBIJVWMTMwucBAu6K(obj2, (object) xmlReaderSettings);
              num1 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_e6f96a787f924f559d55835012f65621 != 0 ? 6 : 1;
              continue;
          }
        }
label_5:
        return true;
label_6:
        try
        {
          object output = outStream;
          XmlWriterSettings settings = new XmlWriterSettings();
          ELMAEnviromentStarter.jcKM8DVNM6MC6ifOJXI((object) settings, false);
          XmlWriter xmlWriter = XmlWriter.Create((Stream) output, settings);
          int num2 = 0;
          if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_d9a87c470c1f44ac8f183ec4ee9ecd32 == 0)
            num2 = 0;
          switch (num2)
          {
            default:
              try
              {
                ELMAEnviromentStarter.NREhCIVFJSZc0ZKDuiA((object) compiledTransform1, (object) xmlReader, (object) xmlWriter);
                int num3 = 0;
                if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_5fc6cb15dbd84be7b6f01c9d3d0dc6f3 == 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_5;
                }
              }
              finally
              {
                int num4;
                if (xmlWriter == null)
                  num4 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_3a7a324caceb407fb2d6bf16404557bb == 0 ? 1 : 0;
                else
                  goto label_16;
label_15:
                switch (num4)
                {
                  case 1:
                  case 2:
                }
label_16:
                ELMAEnviromentStarter.p0WMT8uurcn6cVETnhK((object) xmlWriter);
                num4 = 2;
                if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_1a002da92eea49dc9ab414b7afe61297 != 0)
                {
                  num4 = 2;
                  goto label_15;
                }
                else
                  goto label_15;
              }
          }
        }
        finally
        {
          int num5;
          if (xmlReader == null)
            num5 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_dc6d5d9a4d9744a18d669405ae5070a8 == 0 ? 0 : 0;
          else
            goto label_22;
label_21:
          switch (num5)
          {
            case 1:
              break;
            default:
          }
label_22:
          xmlReader.Dispose();
          num5 = 2;
          if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_740ef59153ff4ad09b1da3c952318a34 == 0)
          {
            num5 = 2;
            goto label_21;
          }
          else
            goto label_21;
        }
label_26:
        return false;
      }
    }

    private static bool ApplySettingsTransformation(
      object configurationDirectory,
      object originalFile)
    {
      int num1 = 15;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          string newFilePath;
          // ISSUE: variable of a compiler-generated type
          ELMAEnviromentStarter.<>c__DisplayClass46_0 cDisplayClass460;
          string str;
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              ELMAEnviromentStarter.OxkWCnVSggd5BKcStv4((object) cDisplayClass460.doc, originalFile);
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_dd156353ddc1435bb580bfff814a7c9a != 0 ? 18 : 0;
              continue;
            case 2:
              if (ELMAEnviromentStarter.bF9rLau688Sas23oC9p((object) newFilePath))
              {
                num2 = 16;
                continue;
              }
              goto case 8;
            case 3:
              // ISSUE: reference to a compiler-generated field
              if (cDisplayClass460.settingsNode == null)
              {
                num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_8bb670bf0c514ecb87c6e60e7438e06f == 0 ? 13 : 10;
                continue;
              }
              if (ELMAEnviromentStarter.\u003CApplySettingsTransformation\u003Eg__Apply\u007C46_3((object) str, ref cDisplayClass460) | ELMAEnviromentStarter.\u003CApplySettingsTransformation\u003Eg__Apply\u007C46_3((object) newFilePath, ref cDisplayClass460))
                break;
              goto label_20;
            case 4:
              goto label_23;
            case 5:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              cDisplayClass460.settingsNode = cDisplayClass460.doc.SelectNodes((string) ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-1418111850 ^ -1418109256)).Cast<XmlElement>().FirstOrDefault<XmlElement>();
              num2 = 3;
              continue;
            case 6:
              goto label_22;
            case 7:
            case 17:
              goto label_8;
            case 8:
              if (ELMAEnviromentStarter.bF9rLau688Sas23oC9p((object) (str + (string) ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-220259925 ^ -220262373))))
              {
                num2 = 17;
                continue;
              }
              goto case 12;
            case 9:
              File.WriteAllBytes(str + (string) ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(-1372383459 - 1174808806 ^ 1747773319), Resources.settings_config);
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_dd156353ddc1435bb580bfff814a7c9a != 0 ? 7 : 2;
              continue;
            case 10:
              Directory.CreateDirectory(Path.GetDirectoryName(str));
              num2 = 9;
              continue;
            case 11:
              if (!ELMAEnviromentStarter.bF9rLau688Sas23oC9p((object) str))
              {
                num2 = 2;
                continue;
              }
              goto case 16;
            case 12:
              if (!ELMAEnviromentStarter.pID4AQVaMPCW0r1ges8(ELMAEnviromentStarter.IjPUBsuN9yLeQZUn3Yi((object) str)))
              {
                num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_11df0b0286bd46b6a8780d914c7488e8 == 0 ? 8 : 10;
                continue;
              }
              goto case 9;
            case 13:
              goto label_18;
            case 14:
              newFilePath = Path.Combine((string) configurationDirectory, (string) ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(1743907988 ^ -1465399602 ^ -816435902), (string) ELMAEnviromentStarter.bRdRGpVv1bfe5RCVqZE(ELMAEnviromentStarter.xaDVopVKyQXhjpXG1gX(), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-894499343 - 376403504 ^ -1270905237), ELMAEnviromentStarter.oyLxcXVyCQx1FkZ1ois(originalFile)));
              num2 = 11;
              continue;
            case 15:
              str = (string) ELMAEnviromentStarter.lqXanGVAfmHEa85HCM6(configurationDirectory, ELMAEnviromentStarter.Nrc3quioPwr0AaDBCky(782114265 ^ 782113473), (object) Path.GetFileName((string) originalFile));
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_5fc6cb15dbd84be7b6f01c9d3d0dc6f3 == 0 ? 6 : 14;
              continue;
            case 16:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass460.doc = new XmlDocument();
              num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_156094dc453849b0aac6aa735e572dfe != 0 ? 1 : 1;
              continue;
            case 18:
              ref ELMAEnviromentStarter.<>c__DisplayClass46_0 local = ref cDisplayClass460;
              // ISSUE: reference to a compiler-generated field
              IEnumerable<XmlElement> source1 = ((IEnumerable) ELMAEnviromentStarter.OHFeIHVTUXxWtGIAKCA((object) cDisplayClass460.doc, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1508925951 ^ -123517655 ^ -1588384036))).OfType<XmlElement>();
              // ISSUE: reference to a compiler-generated field
              Func<XmlElement, bool> func1 = ELMAEnviromentStarter.<>c.<>9__46_0;
              Func<XmlElement, bool> predicate;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                ELMAEnviromentStarter.<>c.<>9__46_0 = predicate = (Func<XmlElement, bool>) (e =>
                {
                  int num3 = 1;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        if (ELMAEnviromentStarter.<>c.KZjEekAg5HBj9PqaapL(ELMAEnviromentStarter.<>c.fJAR7RAHjDB4XR44PfJ((object) e), ELMAEnviromentStarter.<>c.kcbGrfAQUL3qKDaAhu7(1743907988 ^ -1465399602 ^ -816439282)) != null)
                        {
                          num3 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_cd867fd8e34648a7a62174a6af9dc6dd != 0 ? 0 : 0;
                          continue;
                        }
                        goto label_5;
                      default:
                        goto label_4;
                    }
                  }
label_4:
                  // ISSUE: reference to a compiler-generated method
                  return ((XmlAttributeCollection) ELMAEnviromentStarter.<>c.fJAR7RAHjDB4XR44PfJ((object) e))[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1801939602 ^ -1801937104)] != null;
label_5:
                  return false;
                });
              }
              else
                goto label_33;
label_29:
              IEnumerable<XmlElement> source2 = source1.Where<XmlElement>(predicate);
              // ISSUE: reference to a compiler-generated field
              Func<XmlElement, string> func2 = ELMAEnviromentStarter.<>c.<>9__46_1;
              Func<XmlElement, string> keySelector;
              if (func2 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                ELMAEnviromentStarter.<>c.<>9__46_1 = keySelector = (Func<XmlElement, string>) (e => (string) ELMAEnviromentStarter.<>c.JEbMfMAz6x6rZlPOhd5(ELMAEnviromentStarter.<>c.KZjEekAg5HBj9PqaapL((object) e.Attributes, ELMAEnviromentStarter.<>c.kcbGrfAQUL3qKDaAhu7(1743907988 ^ -1465399602 ^ -816439282))));
              }
              else
                goto label_32;
label_31:
              Dictionary<string, XmlElement> dictionary = source2.ToDictionary<XmlElement, string, XmlElement>(keySelector, (Func<XmlElement, XmlElement>) (e => e));
              // ISSUE: reference to a compiler-generated field
              local.existingValues = dictionary;
              num2 = 5;
              continue;
label_32:
              keySelector = func2;
              goto label_31;
label_33:
              predicate = func1;
              goto label_29;
          }
          // ISSUE: reference to a compiler-generated field
          ELMAEnviromentStarter.i83NGqV4OY5eoMck3KL((object) cDisplayClass460.doc, originalFile);
          num2 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_505866aff0204b659e1cc72dbf89c08c != 0 ? 6 : 4;
        }
label_20:
        num1 = 4;
      }
label_8:
      return false;
label_18:
      return false;
label_22:
      return true;
label_23:
      return false;
    }

    private static bool ByteArrayCompare(object a1, object a2) => ((IStructuralEquatable) a1).Equals(a2, (IEqualityComparer) ELMAEnviromentStarter.Ig9PORVLOl3tkJu65IU());

    /// <summary>
    /// Вызывается в потоке инициализации приложения при запуске
    /// </summary>
    internal static Action OnStart { get; set; }

    private static void InvokeOnStart()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            goto label_5;
          case 2:
            object obj = ELMAEnviromentStarter.ooa2eCVlyNOG6b3JT5J();
            if (obj == null)
            {
              num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_09d6ea8f51184538876ee96c32a45b45 != 0 ? 1 : 1;
              continue;
            }
            ((Action) obj)();
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_11df0b0286bd46b6a8780d914c7488e8 == 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_5:
      return;
label_7:;
    }

    static ELMAEnviromentStarter()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            ELMAEnviromentStarter.StartLockObject = new object();
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_d29fb13b4bfb40c582cdc083433bd5f0 != 0 ? 0 : 0;
            continue;
          case 2:
            ELMAEnviromentStarter.wSF4BnVbiK4nJkLEeeE();
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_ab8f72009ce842dcb89f3b07799e8f31 != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_2;
          case 4:
            ELMAEnviromentStarter._startStep = ELMAEnviromentStarter.StartStep.Beginning;
            num = 3;
            continue;
          default:
            ELMAEnviromentStarter.SessionsContainerProviderType = typeof (WebSessionProvider);
            num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_5dd9092c888d47e082e13b5fa5305e45 == 0 ? 2 : 4;
            continue;
        }
      }
label_2:;
    }

    internal static void ci2E8QillRR6NDSAqR7([In] object obj0) => ModelMetadataProviders.Current = (ModelMetadataProvider) obj0;

    internal static bool XiHn7li4VgpX2XguLdK() => ELMAEnviromentStarter.bcGJgaiTgsV2UUoT6jM == null;

    internal static ELMAEnviromentStarter VyPqNNiLaPR1dnM23GY() => ELMAEnviromentStarter.bcGJgaiTgsV2UUoT6jM;

    internal static void tIZjQfibdUomU6NE2yQ() => EleWise.ELMA.SR.SetDefaultCultureFromAppSettings();

    internal static StartStatus hqO3kHi3t0D6tfpldKa([In] object obj0) => ((StartInformation) obj0).Status;

    internal static object Ta26CZixVY6sQR1VtTl() => (object) StartInformation.Root;

    internal static void VIM0miicGGjfLPTCoku([In] object obj0, [In] StartStatus obj1) => ((StartInformation) obj0).Status = obj1;

    internal static object Ug62Tsi9v6XGxoNyO1v() => (object) Thread.CurrentThread;

    internal static object HMaZMIiWI5jTF6niulj([In] object obj0) => (object) ((Thread) obj0).CurrentUICulture;

    internal static object XXVr5OiNd8N4iTPnccI([In] object obj0) => ((CultureInfo) obj0).Clone();

    internal static void NIHRCSiFcb8pjR2ZcPS([In] object obj0, [In] object obj1) => ((Thread) obj0).CurrentUICulture = (CultureInfo) obj1;

    internal static object h41geCiZspua1BD2RT7([In] object obj0) => (object) ((Thread) obj0).CurrentCulture;

    internal static void sgdyRViwFp8P5V5Lgyl([In] object obj0, [In] object obj1) => ((Thread) obj0).CurrentCulture = (CultureInfo) obj1;

    internal static void bSfxpLikMjLDe1pCrON([In] object obj0) => ((IStartControl) obj0).Continue();

    internal static void WYd6cYiEyDp7q10LogD([In] object obj0) => ContextVars.SetImpl((IContextBoundVariableService) obj0);

    internal static object Db1vhniYTyJj0dNR428([In] object obj0, [In] object obj1) => (object) ((ContainerBuilder) obj0).RegisterModule((Autofac.Core.IModule) obj1);

    internal static object WFJeZQiBJr6MMu0Dkst() => (object) EventsModuleFactory.Create();

    internal static object P1Z1JLihT61uHScYmTV([In] object obj0, [In] ContainerBuildOptions obj1) => (object) ((ContainerBuilder) obj0).Build(obj1);

    internal static void NZQqIOi1PmAv627oSlm([In] object obj0) => Locator.SetImpl((ILocatorImpl) obj0);

    internal static object Nrc3quioPwr0AaDBCky(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object JBLVfeimJU7IXTcvCTV([In] object obj0) => (object) EleWise.ELMA.SR.M((string) obj0);

    internal static object KpBULniRK8kZaoP4x5U([In] double obj0, [In] object obj1) => (object) StartInformation.Operation(obj0, (string) obj1);

    internal static void QuTKbGiD5GXqIvDoTLM([In] bool obj0) => GuiLocalizationUtility.CheckDesignMode = obj0;

    internal static void zIjZUXi6RiDfwF0Kp1H([In] object obj0) => SessionVars.SetImpl((ISessionBoundVariableService) obj0);

    internal static void FPrjJPiePH88ZECE72r() => ELMAEnviromentStarter.ActivateExternalLicenses();

    internal static void iGIMxqiCXknlpxuLsRp() => ELMAEnviromentStarter.InitEnvironment();

    internal static object dOosBSiJjeuiYTjrX2v([In] object obj0) => (object) ((ComponentManager) obj0).PackageService;

    internal static void Ow6Ze4iOxbdIE7IruLu([In] object obj0, [In] object obj1) => ((PackageService) obj0).ComponentName = (string) obj1;

    internal static void PYMcKsijS0jBnMckFpN([In] object obj0, [In] object obj1) => ((ComponentManager) obj0).LoadAssemblies((string[]) obj1);

    internal static void hOUBGMisg38xwRW5DG7([In] object obj0) => ELMAEnviromentStarter.RegisterComponents(obj0);

    internal static object dKoVOOiIFewWiGOlRv5([In] object obj0) => (object) HostingEnvironment.MapPath((string) obj0);

    internal static void kNXHwuipvHgk8nq42OT([In] object obj0, [In] object obj1, [In] object obj2) => ((ComponentManager) obj0).Init((string[]) obj1, (string) obj2);

    internal static bool TBicKliGoT7H7DPIUxU([In] object obj0) => ((PackageService) obj0).Initialized;

    internal static object l5Y924iqpAllsHQUbVL() => (object) PackageServerSettings.Current;

    internal static object POH0XUirYDXFA7UI13R([In] object obj0) => (object) ((PackageService) obj0).LocalRepositoryPath;

    internal static object nh0mLpiQARNDmTL6IB3() => (object) RouteTable.Routes;

    internal static bool R2hn14iHhVjbSd9RyaZ([In] object obj0) => ((IRuntimeApplication) obj0).IsFirstServerInCluster;

    internal static void r6P1iKig7Nfh2afjhPC([In] object obj0, [In] object obj1) => ((PackageService) obj0).SaveConfigurationPackages((string) obj1);

    internal static void PgBLMJizgNO3MB3OwLl([In] object obj0) => ((PackageService) obj0).Complete();

    internal static object TbggiuudkFsB314PB0l([In] object obj0) => (object) ((ComponentManager) obj0).ModuleManager;

    internal static void ySUa96uiLyHl0vKLFTf([In] object obj0) => ((IModuleManager) obj0).SaveStartedModuleInfos();

    internal static void p0WMT8uurcn6cVETnhK([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void OQJqV1uVcDg868Z6YcX([In] object obj0) => EleWise.ELMA.Web.Orchard.OrchardStarter.OnBuildContainer((IContainer) obj0);

    internal static void HGanInuydlEJRiciPN1([In] object obj0) => ((IOrchardHost) obj0).Initialize();

    internal static void D6GrtDuAIFxapwpnd04([In] object obj0) => ((IRuntimeApplication) obj0).OnApplicationStarted();

    internal static void SUdBapu0PjcRl5q4BHi([In] object obj0) => ((IAutoDeployService) obj0).RunAutoDeploy();

    internal static void lW4SDruahVcmVvnA9n1([In] object obj0) => ELMAEnviromentStarter.InitVirtualPathProviders(obj0);

    internal static void yoQ1Bxu5SblRno4kds2() => ELMAEnviromentStarter.InitMetadataProviders();

    internal static void EN23SjuP2AvyFhYZBn0() => ELMAEnviromentStarter.InitModelValidatorProviders();

    internal static void EGulP3uXpZ6k6X7mGvn() => ELMAEnviromentStarter.InitModelBinders();

    internal static void uJ4fpWuUJBMNeUYcYno() => ELMAEnviromentStarter.InvokeOnStart();

    internal static void FCyvDku8sBRxusqqwEW([In] object obj0) => ((ComponentManager) obj0).StartCache();

    internal static void TH5ccCuMaojGNNXVE7a([In] object obj0) => ((Scheduler) obj0).Start();

    internal static object crlRt9ufCri9dYEZFJB() => (object) ComponentManager.Current;

    internal static void S42sZ0u7e3rguQYOAT2([In] object obj0) => Task.WaitAll((Task[]) obj0);

    internal static void PEVOpRun2KgPeJ8KHma([In] object obj0, [In] TenantState obj1) => ((ShellSettings) obj0).State = obj1;

    internal static void MulpSEutcSrN9Sprsf4([In] object obj0) => ELMAEnviromentStarter.OrchardHost = (IOrchardHost) obj0;

    internal static void naAha8u2Bk3D2sMiBSr([In] object obj0, [In] object obj1) => ((StartInformation) obj0).Message = (string) obj1;

    internal static Guid uqCCT7uKBb91Rp6b7tt() => Guid.NewGuid();

    internal static void w32fm7uveCfaXisasrw([In] object obj0) => ((CallContextSessionOwner) obj0).Dispose();

    internal static object dPMEKyuSeC6hJyZrLlF() => (object) Logger.Log;

    internal static void Y90kBguTbViAqbJUwqf([In] object obj0, [In] object obj1) => ((ILogger) obj0).Info(obj1);

    internal static void WsxdEXu43QcUo3LRL9Q([In] object obj0) => RazorBuildProvider.CodeGenerationStarted += (EventHandler) obj0;

    internal static bool Cxl69luLGaJYQlIS8tY([In] object obj0, [In] object obj1) => (Assembly) obj0 != (Assembly) obj1;

    internal static object Qt3tXCulvtyysHYTWwi([In] object obj0) => (object) ((RazorBuildProvider) obj0).AssemblyBuilder;

    internal static void Vc9Qx7ub7PfijNOLFW5([In] object obj0, [In] object obj1) => ((System.Web.Compilation.AssemblyBuilder) obj0).AddAssemblyReference((Assembly) obj1);

    internal static object tII3S1u3vDRYZegWl9Y([In] object obj0, [In] bool obj1) => (object) ComponentManager.FindLoadedAssembly((string) obj0, obj1);

    internal static object TY2fA1uxH9a271KDKEK([In] object obj0, [In] object obj1) => (object) ((ConnectionStringSettingsCollection) obj0)[(string) obj1];

    internal static object YUmBGauc9lv1K9DMZHx([In] object obj0) => (object) ((ConnectionStringSettings) obj0).ConnectionString;

    internal static bool cN46U5u9CtwX1wilDj4([In] object obj0) => Path.IsPathRooted((string) obj0);

    internal static object baAsYNuWiy6YZBjOo1F() => (object) AppDomain.CurrentDomain;

    internal static object IjPUBsuN9yLeQZUn3Yi([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static bool YLjODBuF2KssQwAOvsi([In] object obj0, [In] object obj1) => ELMAEnviromentStarter.ApplySettingsTransformation(obj0, obj1);

    internal static void efE2GcuZicSqtM4dXSS([In] object obj0) => AppDomain.Unload((AppDomain) obj0);

    internal static object AxuY1tuwgrYGCBXr7yJ([In] object obj0) => (object) ((AppDomain) obj0).RelativeSearchPath;

    internal static void d0LhqrukYYictdvFrap([In] object obj0) => ELMAEnviromentStarter.CreateConfigFileIfNotExists(obj0);

    internal static Type noJBbauECk2r2sQgtRp([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool MyJINbuYvJxfVGEdafS([In] object obj0, [In] object obj1) => (MethodInfo) obj0 != (MethodInfo) obj1;

    internal static object frOkvJuBRrmciNpHyCA([In] object obj0, [In] object obj1, [In] object obj2) => ((MethodBase) obj0).Invoke(obj1, (object[]) obj2);

    internal static void pm0VWyuhTDoKx6CqshA([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void HwYiQGu15qvwJJWS93r([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static ApplicationShutdownReason xkltpjuomXVl3WGFdeM([In] object obj0) => ((BuildManagerHostUnloadEventArgs) obj0).Reason;

    internal static object R3Xpprum7dXTeJQna3b([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void XAeyaCuRTVvuW2BJOSI([In] object obj0, [In] object obj1) => ((ILogger) obj0).Fatal(obj1);

    internal static void Pp78D8uDGn3ua2bXNU1() => LM.Init();

    internal static bool bF9rLau688Sas23oC9p([In] object obj0) => File.Exists((string) obj0);

    internal static object iHjpi4uexHA0pm5sDig([In] object obj0) => (object) RuntimeConfiguration.Load((string) obj0);

    internal static void j94mwwuC5Mru2YFk82k([In] object obj0, [In] object obj1) => ((RuntimeConfiguration) obj0).MainDB = (IMainBaseSettingsSection) obj1;

    internal static object zqF5EIuJH5wb7TDGsLb([In] object obj0) => (object) ((RuntimeConfiguration) obj0).MainDB;

    internal static object WQTp0UuOXfATYwm0sm5([In] object obj0) => (object) ((PostgreSQLConnectionSettings) obj0).BuildConnectionString();

    internal static void mMAWK1uj2OwZD3vRTs3([In] object obj0, [In] object obj1, [In] object obj2) => ((IDataBaseSettingsSection) obj0).SetConnectionString((string) obj1, (string) obj2);

    internal static void RHaJVIusYcsDl6iFVdj([In] object obj0) => ((Collection<ModelValidatorProvider>) obj0).Clear();

    internal static object u3jejQuIV0rauVNdVyu() => (object) ModelValidatorProviders.Providers;

    internal static object JnhGcZuptcYSnJd0L6e() => (object) ModelBinders.Binders;

    internal static void quIjBjuGE46S0x1oc3f([In] object obj0, [In] Type obj1, [In] object obj2) => ((ModelBinderDictionary) obj0).Add(obj1, (IModelBinder) obj2);

    internal static void RtjYsWuqG3LXfRkL7OQ([In] object obj0, [In] object obj1) => ((ModelBinderDictionary) obj0).DefaultBinder = (IModelBinder) obj1;

    internal static object EErW5kurHuM6OEjwUL8([In] object obj0) => (object) Path.GetFullPath((string) obj0);

    internal static object BuXdYXuQlb9duFt1yRW([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static void lQhQwSuHOGkE4cbjvqK([In] object obj0, [In] object obj1) => ((ApplicationDirectoryFileWatcher) obj0).Init((string) obj1);

    internal static void hLRdPeug5CkjCOZTkyw([In] object obj0) => HostingEnvironment.RegisterVirtualPathProvider((VirtualPathProvider) obj0);

    internal static void fOiS0puzXA5f0imVXfE([In] object obj0) => EleWise.ELMA.WebCompiler.BuildManager.AddIgnoreModule((string) obj0);

    internal static void LLJVRsVdW9m03ewyatW([In] object obj0, [In] object obj1) => ((CompilingModuleInfo) obj0).VirtualPath = (string) obj1;

    internal static void GfT7CAViLCQaRAT1nf1([In] object obj0, [In] object obj1) => ((CompilingModuleInfo) obj0).RelativePhysicalPath = (string) obj1;

    internal static void CvZLHwVuMfu6WmVKXAQ([In] object obj0) => EleWise.ELMA.WebCompiler.BuildManager.AddAdditionalModule((CompilingModuleInfo) obj0);

    internal static void LCkAKIVVoXKt2PYNQWn([In] object obj0, [In] object obj1) => ((RouteCollection) obj0).IgnoreRoute((string) obj1);

    internal static object oyLxcXVyCQx1FkZ1ois([In] object obj0) => (object) Path.GetFileName((string) obj0);

    internal static object lqXanGVAfmHEa85HCM6([In] object obj0, [In] object obj1, [In] object obj2) => (object) Path.Combine((string) obj0, (string) obj1, (string) obj2);

    internal static object iFbBLSV0PBvSEvihqve([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);

    internal static bool pID4AQVaMPCW0r1ges8([In] object obj0) => Directory.Exists((string) obj0);

    internal static object U3b8UuV5CBV6wkLviea() => (object) Resources.web_config_xslt;

    internal static object aqg2I4VPvNq7Rie5cij([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetString((byte[]) obj1);

    internal static object E9WddYVX4Y1p08cVCwL(int length)
    {
      return (object) GetRandomKey(length);

      static string GetRandomKey(int length)
      {
        int num = 2;
        byte[] numArray;
        while (true)
        {
          switch (num)
          {
            case 1:
              ELMAEnviromentStarter.ccbhG3V3cF4lwqXEe9G((object) new RNGCryptoServiceProvider(), (object) numArray);
              num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_0595b787e6c04ce0b75955c2cfb98f12 == 0 ? 0 : 0;
              continue;
            case 2:
              numArray = new byte[length];
              num = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_a4a0d03145aa4a86bff873b4ae1fb8c0 == 0 ? 1 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        byte[] source = numArray;
        // ISSUE: reference to a compiler-generated field
        Func<byte, string> func = ELMAEnviromentStarter.<>c.<>9__45_2;
        Func<byte, string> selector;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          ELMAEnviromentStarter.<>c.<>9__45_2 = selector = (Func<byte, string>) (b => b.ToString((string) ELMAEnviromentStarter.<>c.kcbGrfAQUL3qKDaAhu7(-938268191 ^ -938264483)));
        }
        else
          goto label_5;
label_7:
        return string.Concat(((IEnumerable<byte>) source).Select<byte, string>(selector));
label_5:
        selector = func;
        goto label_7;
      }
    }

    internal static object PZr6YRVUTiv0SOPUWbo([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static void nmyoOAV88Or8uDGOUoD([In] object obj0, [In] object obj1) => File.WriteAllText((string) obj0, (string) obj1);

    internal static object PMA7j9VMMRvmTMt7w3I() => (object) MemoryHelper.GetMemoryStream();

    internal static long BirG9eVf0UXD5h1jlVs([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static bool huJxnSV7KQiPHslYOO9([In] object obj0, [In] object obj1, [In] object obj2)
    {
      return Apply(obj0, obj1, obj2);

      static bool Apply(object xsltPath, object inStream, object outStream)
      {
        int num1 = 5;
        XslCompiledTransform compiledTransform1;
        XmlReader xmlReader;
        while (true)
        {
          switch (num1)
          {
            case 1:
              XslCompiledTransform compiledTransform2 = compiledTransform1;
              object obj1 = xsltPath;
              XsltSettings xsltSettings = new XsltSettings();
              ELMAEnviromentStarter.TXLc8NVxqmGPYUu7uAg((object) xsltSettings, true);
              ELMAEnviromentStarter.Cy4fMdVcTqi7mY14orW((object) compiledTransform2, obj1, (object) xsltSettings, (object) null);
              num1 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_50d154664afc4b2f8f6da5de661b4a33 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_26;
            case 3:
              goto label_5;
            case 4:
              compiledTransform1 = new XslCompiledTransform();
              num1 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_14d3ba5c3cce406d89f5b3bd64118b88 != 0 ? 0 : 1;
              continue;
            case 5:
              if (File.Exists((string) xsltPath))
              {
                num1 = 4;
                continue;
              }
              goto label_26;
            case 6:
              goto label_6;
            default:
              object obj2 = inStream;
              XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
              ELMAEnviromentStarter.jRAl0tV9gIs3jbmm3Ci((object) xmlReaderSettings, false);
              xmlReader = (XmlReader) ELMAEnviromentStarter.shfBIJVWMTMwucBAu6K(obj2, (object) xmlReaderSettings);
              num1 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_e6f96a787f924f559d55835012f65621 != 0 ? 6 : 1;
              continue;
          }
        }
label_5:
        return true;
label_6:
        try
        {
          object output = outStream;
          XmlWriterSettings settings = new XmlWriterSettings();
          ELMAEnviromentStarter.jcKM8DVNM6MC6ifOJXI((object) settings, false);
          XmlWriter xmlWriter = XmlWriter.Create((Stream) output, settings);
          int num2 = 0;
          if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_d9a87c470c1f44ac8f183ec4ee9ecd32 == 0)
            num2 = 0;
          switch (num2)
          {
            default:
              try
              {
                ELMAEnviromentStarter.NREhCIVFJSZc0ZKDuiA((object) compiledTransform1, (object) xmlReader, (object) xmlWriter);
                int num3 = 0;
                if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_5fc6cb15dbd84be7b6f01c9d3d0dc6f3 == 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_5;
                }
              }
              finally
              {
                int num4;
                if (xmlWriter == null)
                  num4 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_3a7a324caceb407fb2d6bf16404557bb == 0 ? 1 : 0;
                else
                  goto label_16;
label_15:
                switch (num4)
                {
                  case 1:
                  case 2:
                }
label_16:
                ELMAEnviromentStarter.p0WMT8uurcn6cVETnhK((object) xmlWriter);
                num4 = 2;
                if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_1a002da92eea49dc9ab414b7afe61297 != 0)
                {
                  num4 = 2;
                  goto label_15;
                }
                else
                  goto label_15;
              }
          }
        }
        finally
        {
          int num5;
          if (xmlReader == null)
            num5 = \u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_dc6d5d9a4d9744a18d669405ae5070a8 == 0 ? 0 : 0;
          else
            goto label_22;
label_21:
          switch (num5)
          {
            case 1:
              break;
            default:
          }
label_22:
          xmlReader.Dispose();
          num5 = 2;
          if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_740ef59153ff4ad09b1da3c952318a34 == 0)
          {
            num5 = 2;
            goto label_21;
          }
          else
            goto label_21;
        }
label_26:
        return false;
      }
    }

    internal static void d5Riq6VndrvtjbrZxwT([In] object obj0) => ((Stream) obj0).Dispose();

    internal static bool qhvHIoVtgU83V9L2kZJ([In] object obj0, [In] object obj1) => MemoryHelper.StreamEquals((Stream) obj0, (Stream) obj1);

    internal static void HaBtghV2LWnSW2I9g3V([In] object obj0, [In] object obj1) => ((Stream) obj0).CopyTo((Stream) obj1);

    internal static object xaDVopVKyQXhjpXG1gX() => (object) System.Environment.MachineName;

    internal static object bRdRGpVv1bfe5RCVqZE([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static void OxkWCnVSggd5BKcStv4([In] object obj0, [In] object obj1) => ((XmlDocument) obj0).Load((string) obj1);

    internal static object OHFeIHVTUXxWtGIAKCA([In] object obj0, [In] object obj1) => (object) ((XmlNode) obj0).SelectNodes((string) obj1);

    internal static void i83NGqV4OY5eoMck3KL([In] object obj0, [In] object obj1) => ((XmlDocument) obj0).Save((string) obj1);

    internal static object Ig9PORVLOl3tkJu65IU() => (object) StructuralComparisons.StructuralEqualityComparer;

    internal static object ooa2eCVlyNOG6b3JT5J() => (object) ELMAEnviromentStarter.OnStart;

    internal static void wSF4BnVbiK4nJkLEeeE() => TKW1L3mlUyvXmg29jA.RWk58XigPN();

    internal static void ccbhG3V3cF4lwqXEe9G([In] object obj0, [In] object obj1) => ((RandomNumberGenerator) obj0).GetBytes((byte[]) obj1);

    internal static void TXLc8NVxqmGPYUu7uAg([In] object obj0, [In] bool obj1) => ((XsltSettings) obj0).EnableDocumentFunction = obj1;

    internal static void Cy4fMdVcTqi7mY14orW([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((XslCompiledTransform) obj0).Load((string) obj1, (XsltSettings) obj2, (XmlResolver) obj3);

    internal static void jRAl0tV9gIs3jbmm3Ci([In] object obj0, [In] bool obj1) => ((XmlReaderSettings) obj0).CloseInput = obj1;

    internal static object shfBIJVWMTMwucBAu6K([In] object obj0, [In] object obj1) => (object) XmlReader.Create((Stream) obj0, (XmlReaderSettings) obj1);

    internal static void jcKM8DVNM6MC6ifOJXI([In] object obj0, [In] bool obj1) => ((XmlWriterSettings) obj0).CloseOutput = obj1;

    internal static void NREhCIVFJSZc0ZKDuiA([In] object obj0, [In] object obj1, [In] object obj2) => ((XslCompiledTransform) obj0).Transform((XmlReader) obj1, (XmlWriter) obj2);

    internal static object Fm2Bv1VZtZnejOfLmIA([In] object obj0, [In] object obj1) => (object) ((XmlDocument) obj0).CreateElement((string) obj1);

    internal static void TJvQSeVwPlm5ypZxSv9([In] object obj0, [In] object obj1, [In] object obj2) => ((XmlElement) obj0).SetAttribute((string) obj1, (string) obj2);

    internal static object ijdrEdVkwUC06tSskeT([In] object obj0, [In] object obj1) => (object) ((XmlNode) obj0).AppendChild((XmlNode) obj1);

    internal static object rfn9bLVESZBMelZANQJ([In] object obj0, [In] object obj1) => (object) ((XmlAttributeCollection) obj0)[(string) obj1];

    internal static object Fik5UOVYvAwPHrunrUK([In] object obj0) => (object) ((XmlNode) obj0).Value;

    internal static bool XOdYuTVBZmFEVNowujC([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    private enum StartStep
    {
      /// <summary>Начало инициализации</summary>
      Beginning,
      /// <summary>Инициализация завершена, приложение работает</summary>
      Complete,
      /// <summary>Критическая ошибка приложения</summary>
      FatalError,
    }
  }
}
