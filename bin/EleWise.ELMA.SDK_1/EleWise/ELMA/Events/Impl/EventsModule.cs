// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Impl.EventsModule
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using Autofac.Builder;
using Autofac.Core;
using EleWise.ELMA.Events.Audit.Impl;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Events.Impl
{
  /// <summary>Модуль событий</summary>
  internal class EventsModule : Autofac.Module
  {
    internal static EventsModule CkahViGLvEJIYZrTjnrV;

    /// <inheritdoc />
    protected override void Load(ContainerBuilder builder)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            EventsModule.diTpMvGLuVohwu6D3tHi((object) builder, (object) new EventsRegistrationSource());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
            continue;
          case 2:
            EventsModule.Bt6Q6aGLIIXDcGj8ZkGN((object) this, (object) builder);
            num = 4;
            continue;
          case 3:
            builder.RegisterType<AuditEventBus>().As<IEventBus>().As<IEventBusAsync>().SingleInstance();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 2 : 2;
            continue;
          case 4:
            goto label_2;
          default:
            builder.RegisterType<DefaultEventBus>().As<IEventBus>().As<IEventBusAsync>().As<IEventHandlerSubscribeService>().SingleInstance();
            num = 3;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    protected override void AttachToComponentRegistration(
      IComponentRegistry componentRegistry,
      IComponentRegistration registration)
    {
      int num1 = 3;
      IComponentRegistration registration1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            EventsModule.pGgSnvGLVqS6EZu3MOFe((object) componentRegistry, (object) RegistrationBuilder.ForDelegate<LazyEventHandler>((Func<IComponentContext, IEnumerable<Parameter>, LazyEventHandler>) ((c, p) =>
            {
              IComponentContext context = c.Resolve<IComponentContext>();
              object obj;
              registration1.Metadata.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195945441), out obj);
              return new LazyEventHandler((Func<IEventHandler>) (() => (IEventHandler) context.ResolveComponent(registration1, p)), registration1.Activator.LimitType, (int?) obj ?? 0);
            })).Targeting<LazyEventHandler, SimpleActivatorData, SingleRegistrationStyle>(registration1).CreateRegistration<LazyEventHandler, SimpleActivatorData, SingleRegistrationStyle>());
            num1 = 4;
            continue;
          case 2:
            registration1 = registration;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
            continue;
          case 3:
            num1 = 2;
            continue;
          case 4:
            goto label_2;
          default:
            if (registration1.Services.Any<Service>((Func<Service, bool>) (s =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    if (!(s is IServiceWithType serviceWithType2))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_4;
                  case 2:
                    goto label_4;
                  default:
                    goto label_5;
                }
              }
label_4:
              // ISSUE: reference to a compiler-generated method
              return EventsModule.\u003C\u003Ec.dbdxN78urS6JssVtoTPX((object) serviceWithType2) == TypeOf<IEventHandler>.Raw;
label_5:
              return false;
            })))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 0;
              continue;
            }
            goto label_8;
        }
      }
label_2:
      return;
label_8:;
    }

    public EventsModule()
    {
      EventsModule.o0v675GLSFrRXx2iZgsf();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void diTpMvGLuVohwu6D3tHi([In] object obj0, [In] object obj1) => ((ContainerBuilder) obj0).RegisterSource((IRegistrationSource) obj1);

    internal static void Bt6Q6aGLIIXDcGj8ZkGN([In] object obj0, [In] object obj1) => __nonvirtual (((Autofac.Module) obj0).Load((ContainerBuilder) obj1));

    internal static bool B455BYGL8biiqRlmTrcg() => EventsModule.CkahViGLvEJIYZrTjnrV == null;

    internal static EventsModule se5WG0GLZoKTgHJWFsgV() => EventsModule.CkahViGLvEJIYZrTjnrV;

    internal static void pGgSnvGLVqS6EZu3MOFe([In] object obj0, [In] object obj1) => ((IComponentRegistry) obj0).Register((IComponentRegistration) obj1);

    internal static void o0v675GLSFrRXx2iZgsf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
