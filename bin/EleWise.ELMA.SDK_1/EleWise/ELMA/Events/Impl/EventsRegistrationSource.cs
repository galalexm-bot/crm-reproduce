// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Impl.EventsRegistrationSource
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using Autofac.Builder;
using Autofac.Core;
using Castle.DynamicProxy;
using EleWise.ELMA.Collections;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Events.Impl
{
  public class EventsRegistrationSource : IRegistrationSource
  {
    private readonly DefaultProxyBuilder _proxyBuilder;
    internal static EventsRegistrationSource NiEqXRGLKLnX7F6M9itt;

    public EventsRegistrationSource()
    {
      EventsRegistrationSource.LmKRFiGLkRZrrKZiAA7H();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this._proxyBuilder = new DefaultProxyBuilder();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public bool IsAdapterForIndividualComponents => false;

    public IEnumerable<IComponentRegistration> RegistrationsFor(
      Service service,
      Func<Service, IEnumerable<IComponentRegistration>> registrationAccessor)
    {
      if (!(service is IServiceWithType serviceWithType))
        return (IEnumerable<IComponentRegistration>) new IComponentRegistration[0];
      Type serviceType = serviceWithType.ServiceType;
      if (!serviceType.IsInterface || !typeof (IEventHandler).IsAssignableFrom(serviceType) || !(serviceType != typeof (IEventHandler)))
        return (IEnumerable<IComponentRegistration>) new IComponentRegistration[0];
      Type interfaceProxyType = this._proxyBuilder.CreateInterfaceProxyTypeWithoutTarget(serviceType, new Type[0], ProxyGenerationOptions.Default);
      return (IEnumerable<IComponentRegistration>) new IComponentRegistration[1]
      {
        RegistrationBuilder.ForDelegate<object>((Func<IComponentContext, IEnumerable<Parameter>, object>) ((ctx, parameters) =>
        {
          object[] objArray = new object[2]
          {
            (object) new IInterceptor[1]
            {
              (IInterceptor) new EventsInterceptor((IEnumerable<IEventBus>) ctx.Resolve<IEnumerable<IEventBus>>().Distinct<IEventBus>((IEqualityComparer<IEventBus>) new ObjectTypeEqualityComparer<IEventBus>()).ToArray<IEventBus>(), (IEnumerable<IEventBusAsync>) ctx.Resolve<IEnumerable<IEventBusAsync>>().Distinct<IEventBusAsync>((IEqualityComparer<IEventBusAsync>) new ObjectTypeEqualityComparer<IEventBusAsync>()).ToArray<IEventBusAsync>())
            },
            null
          };
          return Activator.CreateInstance(interfaceProxyType, objArray);
        })).As(service).CreateRegistration<object, SimpleActivatorData, SingleRegistrationStyle>()
      };
    }

    internal static void LmKRFiGLkRZrrKZiAA7H() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool hgBumoGLXh4wMaFWkfAM() => EventsRegistrationSource.NiEqXRGLKLnX7F6M9itt == null;

    internal static EventsRegistrationSource Ve8We9GLTJFwZK3UjpYj() => EventsRegistrationSource.NiEqXRGLKLnX7F6M9itt;
  }
}
