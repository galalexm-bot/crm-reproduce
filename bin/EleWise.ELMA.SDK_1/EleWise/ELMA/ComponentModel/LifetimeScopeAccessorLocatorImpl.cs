// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.LifetimeScopeAccessorLocatorImpl
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using Autofac.Core;
using Autofac.Core.Lifetime;
using EleWise.ELMA.Services.Impl;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.ComponentModel
{
  public class LifetimeScopeAccessorLocatorImpl : AutofacLocatorImpl
  {
    private readonly ConcurrentDictionary<Service, object> singletonServices;
    private readonly ConcurrentDictionary<Service, bool> isSingletonServices;
    private readonly ILifetimeScopeAccessor lifetimeScopeAccessor;
    private static LifetimeScopeAccessorLocatorImpl UIFr2YfZm58WeSlGQBwV;

    public LifetimeScopeAccessorLocatorImpl(
      IContainer rootContainer,
      ILifetimeScopeAccessor lifetimeScopeAccessor)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.singletonServices = new ConcurrentDictionary<Service, object>();
      this.isSingletonServices = new ConcurrentDictionary<Service, bool>();
      // ISSUE: explicit constructor call
      base.\u002Ector(rootContainer);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            if (lifetimeScopeAccessor != null)
            {
              this.lifetimeScopeAccessor = lifetimeScopeAccessor;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
              continue;
            }
            num = 2;
            continue;
          case 2:
            goto label_4;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_8:
      return;
label_4:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426408553));
    }

    public override object GetService(Type type, string name)
    {
      int num = 10;
      object instance;
      while (true)
      {
        ILifetimeScope lifetimeScope;
        Service service1;
        Service service2;
        switch (num)
        {
          case 1:
            service2 = (Service) new TypedService(type);
            break;
          case 2:
          case 6:
          case 7:
          case 8:
          case 13:
            goto label_7;
          case 3:
            if (!this.IsSingleton(service1, lifetimeScope))
            {
              num = 12;
              continue;
            }
            goto case 11;
          case 4:
            if (instance == null)
            {
              num = 2;
              continue;
            }
            goto default;
          case 5:
            if (!lifetimeScope.TryResolveService(service1, out instance))
            {
              num = 8;
              continue;
            }
            goto case 4;
          case 9:
            service2 = (Service) new KeyedService((object) name, type);
            break;
          case 10:
            if (!LifetimeScopeAccessorLocatorImpl.MniU77fZJ0gqsVl8TQLW((object) name))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 3 : 9;
              continue;
            }
            goto case 1;
          case 11:
            if (this.singletonServices.TryGetValue(service1, out instance))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 3 : 6;
              continue;
            }
            goto case 5;
          case 12:
          case 15:
            lifetimeScope.TryResolveService(service1, out instance);
            num = 13;
            continue;
          case 14:
            if (!this.singletonServices.TryGetValue(service1, out instance))
            {
              lifetimeScope = (ILifetimeScope) LifetimeScopeAccessorLocatorImpl.ndaUyFfZ9GE1AZFeCg1V((object) this.lifetimeScopeAccessor);
              num = 3;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 9 : 16;
            continue;
          case 16:
            goto label_2;
          default:
            this.singletonServices.TryAdd(service1, instance);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 7 : 2;
            continue;
        }
        service1 = service2;
        num = 14;
      }
label_2:
      return instance;
label_7:
      return instance;
    }

    private bool IsSingleton(Service svc, ILifetimeScope lifetimeScope)
    {
      int num = 1;
      bool flag;
      IComponentRegistration componentRegistration;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.isSingletonServices.TryGetValue(svc, out flag))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 2:
            this.isSingletonServices.TryAdd(svc, flag);
            num = 6;
            continue;
          case 3:
            goto label_8;
          case 4:
            if (componentRegistration != null)
            {
              num = 7;
              continue;
            }
            goto label_2;
          case 5:
            goto label_2;
          case 6:
            goto label_12;
          case 7:
            flag = true;
            num = 9;
            continue;
          case 8:
            flag &= LifetimeScopeAccessorLocatorImpl.U7Tx1mfZlSPOmArLBN7h((object) componentRegistration) == InstanceSharing.Shared;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 2 : 2;
            continue;
          case 9:
            flag &= componentRegistration.Lifetime is RootScopeLifetime;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 7 : 8;
            continue;
          default:
            componentRegistration = ((IComponentRegistry) LifetimeScopeAccessorLocatorImpl.eo0ogsfZd1L0w3yusdMx((object) lifetimeScope)).RegistrationsFor(svc).FirstOrDefault<IComponentRegistration>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 4 : 0;
            continue;
        }
      }
label_2:
      return false;
label_8:
      return flag;
label_12:
      return flag;
    }

    internal static bool wTjakWfZyVr75qEqK6aq() => LifetimeScopeAccessorLocatorImpl.UIFr2YfZm58WeSlGQBwV == null;

    internal static LifetimeScopeAccessorLocatorImpl PK76NDfZMNgEcdYdxbaw() => LifetimeScopeAccessorLocatorImpl.UIFr2YfZm58WeSlGQBwV;

    internal static bool MniU77fZJ0gqsVl8TQLW([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object ndaUyFfZ9GE1AZFeCg1V([In] object obj0) => (object) ((ILifetimeScopeAccessor) obj0).Current;

    internal static object eo0ogsfZd1L0w3yusdMx([In] object obj0) => (object) ((IComponentContext) obj0).ComponentRegistry;

    internal static InstanceSharing U7Tx1mfZlSPOmArLBN7h([In] object obj0) => ((IComponentRegistration) obj0).Sharing;
  }
}
