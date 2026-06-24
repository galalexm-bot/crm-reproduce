// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Logging.LoggingModule
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using Autofac.Core;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Logging
{
  public class LoggingModule : Module
  {
    private readonly ConcurrentDictionary<string, ILogger> loggerCache;
    private static readonly Type LoggerType;
    internal static LoggingModule JKIVNQhl2kReexWkVsRB;

    public LoggingModule()
    {
      LoggingModule.Fp57o5hl1Wd6kXwp146X();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.loggerCache = new ConcurrentDictionary<string, ILogger>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    protected override void Load(ContainerBuilder moduleBuilder)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            moduleBuilder.Register<ILogger>(new Func<IComponentContext, IEnumerable<Parameter>, ILogger>(LoggingModule.CreateLogger)).As(LoggingModule.LoggerType).InstancePerDependency();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
            continue;
          case 2:
            moduleBuilder.RegisterType<Log4NetFactory>().As<ILoggerFactory>().SingleInstance();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    protected override void AttachToComponentRegistration(
      IComponentRegistry componentRegistry,
      IComponentRegistration registration)
    {
      int num = 1;
      Type limitType;
      Action<IComponentContext, object>[] injectors;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          case 3:
            if (((IEnumerable<Action<IComponentContext, object>>) injectors).Any<Action<IComponentContext, object>>())
            {
              registration.Activated += (EventHandler<ActivatedEventArgs<object>>) ((s, e) =>
              {
                foreach (Action<IComponentContext, object> action in injectors)
                  action(e.Context, e.Instance);
              });
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 2 : 2;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 4;
            continue;
          case 4:
            goto label_2;
          case 5:
            injectors = this.BuildLoggerInjectors(limitType).ToArray<Action<IComponentContext, object>>();
            num = 3;
            continue;
          default:
            limitType = registration.Activator.LimitType;
            num = 5;
            continue;
        }
      }
label_4:
      return;
label_2:;
    }

    private IEnumerable<Action<IComponentContext, object>> BuildLoggerInjectors(Type componentType) => (IEnumerable<Action<IComponentContext, object>>) new LoggingModule.\u003CBuildLoggerInjectors\u003Ed__5(-2)
    {
      \u003C\u003E4__this = this,
      \u003C\u003E3__componentType = componentType
    };

    private static ILogger CreateLogger(object context, Type componentType)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            LoggingModule.sCTZ7ehlNQNMNioADNB9(context, LoggingModule.LoggerType, (object) new Parameter[1]
            {
              (Parameter) TypedParameter.From<Type>(componentType)
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (ILogger) LoggingModule.bok1nlhl3KpRwFeTNRUX((object) ((IComponentContext) context).Resolve<ILoggerFactory>(), componentType);
    }

    private static ILogger CreateLogger(object context, IEnumerable<Parameter> parameters)
    {
      TypedParameter[] array = parameters.OfType<TypedParameter>().ToArray<TypedParameter>();
      return ((IComponentContext) context).Resolve<ILoggerFactory>().CreateLogger(array.Length != 0 ? ((IEnumerable<Parameter>) array).TypedAs<Type>() : typeof (Logger));
    }

    static LoggingModule()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            LoggingModule.LoggerType = typeof (ILogger);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
            continue;
          case 2:
            LoggingModule.Fp57o5hl1Wd6kXwp146X();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void Fp57o5hl1Wd6kXwp146X() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool HXaMvkhlej0VBw6uXgQ2() => LoggingModule.JKIVNQhl2kReexWkVsRB == null;

    internal static LoggingModule lHTMVbhlPtNnmtDXxoPn() => LoggingModule.JKIVNQhl2kReexWkVsRB;

    internal static object sCTZ7ehlNQNMNioADNB9([In] object obj0, [In] Type obj1, [In] object obj2) => ((IComponentContext) obj0).Resolve(obj1, (Parameter[]) obj2);

    internal static object bok1nlhl3KpRwFeTNRUX([In] object obj0, Type type) => (object) ((ILoggerFactory) obj0).CreateLogger(type);
  }
}
