// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Impl.AutofacLocatorImpl
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using Autofac.Builder;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Services.Impl
{
  /// <summary>Реализация менеджера служб для Autofac</summary>
  public class AutofacLocatorImpl : ILocatorImpl
  {
    private readonly IContainer container;
    private readonly object lockObject;
    internal static AutofacLocatorImpl B8xABBBJZ3lWiYubl1dx;

    /// <summary>
    /// </summary>
    /// <param name="container"></param>
    public AutofacLocatorImpl(IContainer container)
    {
      AutofacLocatorImpl.gdRCMfBJVJhOutA0w579();
      this.lockObject = new object();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            this.AddService(AutofacLocatorImpl.WtqTPgBJST8xbMpSjbEH(__typeref (IContainer)), (object) container, true);
            num = 4;
            continue;
          case 2:
            if (container != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 3:
            goto label_8;
          case 4:
            goto label_4;
          default:
            this.container = container;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 1;
            continue;
        }
      }
label_8:
      return;
label_4:
      return;
label_3:;
    }

    public virtual object GetService(Type type, string name)
    {
      int num = 2;
      object instance;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 3:
            this.container.TryResolve(type, out instance);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 3 : 4;
            continue;
          case 2:
            if (AutofacLocatorImpl.P21JGdBJio9TubCXksYG((object) name))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 1;
              continue;
            }
            break;
          case 4:
          case 5:
            goto label_6;
        }
        this.container.TryResolveNamed(name, type, out instance);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 5;
      }
label_6:
      return instance;
    }

    public void AddService(Type type, object obj, bool resolve)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            AutofacLocatorImpl.AiVjC5BJRGdMZ0m5jNSC((object) this, type, obj, resolve);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    protected virtual void AddServiceInternal(Type type, object obj, bool resolve)
    {
      int num1 = 3;
      object lockObject;
      ContainerBuilder builder;
      bool lockTaken;
      while (true)
      {
        IRegistrationBuilder<object, SimpleActivatorData, SingleRegistrationStyle> registration;
        switch (num1)
        {
          case 1:
            if (resolve)
            {
              num1 = 7;
              continue;
            }
            break;
          case 2:
            registration = builder.RegisterInstance<object>(obj).As(type).SingleInstance();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 1 : 0;
            continue;
          case 3:
            builder = new ContainerBuilder();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 1 : 2;
            continue;
          case 4:
            goto label_18;
          case 5:
            lockTaken = false;
            num1 = 6;
            continue;
          case 6:
            goto label_5;
          case 7:
            registration.PropertiesAutowired<object, SimpleActivatorData, SingleRegistrationStyle>(PropertyWiringOptions.AllowCircularDependencies);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
            continue;
        }
        lockObject = this.lockObject;
        num1 = 5;
      }
label_18:
      return;
label_5:
      try
      {
        Monitor.Enter(lockObject, ref lockTaken);
        int num2 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
          num2 = 2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_13;
            case 2:
              builder.Update(this.container);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
              continue;
            case 3:
              ((ComponentManager) AutofacLocatorImpl.c0NJw1BJqjnIAR6GN8GT()).ResetCache();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 0;
              continue;
            default:
              if (ComponentManager.Initialized)
              {
                num2 = 3;
                continue;
              }
              goto label_8;
          }
        }
label_13:
        return;
label_8:;
      }
      finally
      {
        if (lockTaken)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_20;
              default:
                Monitor.Exit(lockObject);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 1;
                continue;
            }
          }
        }
label_20:;
      }
    }

    public virtual void RemoveService(Type type) => throw new NotImplementedException();

    internal static void gdRCMfBJVJhOutA0w579() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type WtqTPgBJST8xbMpSjbEH([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool TIoFPZBJu59PhYwIMUIu() => AutofacLocatorImpl.B8xABBBJZ3lWiYubl1dx == null;

    internal static AutofacLocatorImpl QXHIZ3BJI0qK9y7LrRFs() => AutofacLocatorImpl.B8xABBBJZ3lWiYubl1dx;

    internal static bool P21JGdBJio9TubCXksYG([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void AiVjC5BJRGdMZ0m5jNSC([In] object obj0, Type type, [In] object obj2, bool resolve) => ((AutofacLocatorImpl) obj0).AddServiceInternal(type, obj2, resolve);

    internal static object c0NJw1BJqjnIAR6GN8GT() => (object) ComponentManager.Current;
  }
}
