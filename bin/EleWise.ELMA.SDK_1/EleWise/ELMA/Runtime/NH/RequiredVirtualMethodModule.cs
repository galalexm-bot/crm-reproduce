// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.RequiredVirtualMethodModule
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac.Core;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.Cache;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH
{
  public class RequiredVirtualMethodModule : Autofac.Module
  {
    private readonly Func<Type, IEnumerable<MethodInfo>> methodsFunc;
    private readonly Func<Type, MethodInfo, string> message;
    private readonly ApplicationStartCache applicationStartCache;
    internal static RequiredVirtualMethodModule dhrlZEW6vNXZjhg9MglN;

    public RequiredVirtualMethodModule(
      Func<Type, IEnumerable<MethodInfo>> methodsFunc,
      Func<Type, MethodInfo, string> message,
      ApplicationStartCache applicationStartCache = null)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.methodsFunc = methodsFunc;
      this.message = message;
      this.applicationStartCache = applicationStartCache;
    }

    protected override void AttachToComponentRegistration(
      IComponentRegistry componentRegistry,
      IComponentRegistration registration)
    {
      int num1 = 4;
      Type nonProxyType;
      IEnumerator<MethodInfo> enumerator;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          IEnumerable<MethodInfo> methodInfos;
          AssemblyInfoCache assemblyInfoCache1;
          AssemblyInfoCache assemblyInfoCache2;
          switch (num2)
          {
            case 0:
              goto label_21;
            case 1:
              if (RequiredVirtualMethodModule.uoePfFW6SpwGa3FZc3U9(nonProxyType, (Type) null))
              {
                num2 = 17;
                continue;
              }
              goto case 7;
            case 2:
              if (!nonProxyType.IsValueType)
              {
                num2 = 11;
                continue;
              }
              goto label_37;
            case 3:
              nonProxyType = this.GetNonProxyType(RequiredVirtualMethodModule.bBlEe5W6VtmAeYnw0uEA(RequiredVirtualMethodModule.c18kLMW6Iq3eFOorICYq((object) registration)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
              continue;
            case 4:
              RequiredVirtualMethodModule.m8jiEAW6uSbU7gZIv944((object) this, (object) componentRegistry, (object) registration);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 3 : 1;
              continue;
            case 5:
              goto label_49;
            case 6:
              goto label_25;
            case 7:
              if (!nonProxyType.IsSealed)
              {
                num2 = 10;
                continue;
              }
              goto label_42;
            case 8:
              goto label_28;
            case 9:
              methodInfos = this.methodsFunc(nonProxyType);
              num2 = 18;
              continue;
            case 10:
              if (nonProxyType.IsEnum)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 5 : 0;
                continue;
              }
              goto case 2;
            case 11:
              if (this.applicationStartCache == null)
                goto case 14;
              else
                goto label_14;
            case 12:
              if (assemblyInfoCache1 != null)
              {
                num2 = 15;
                continue;
              }
              goto case 9;
            case 13:
              assemblyInfoCache2 = this.applicationStartCache.GetAssemblyInfo(nonProxyType.Assembly);
              break;
            case 14:
              assemblyInfoCache2 = (AssemblyInfoCache) null;
              break;
            case 15:
              if (assemblyInfoCache1._changed)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 9 : 0;
                continue;
              }
              goto label_17;
            case 16:
              goto label_12;
            case 17:
              goto label_27;
            case 18:
              if (methodInfos == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
                continue;
              }
              enumerator = methodInfos.GetEnumerator();
              num2 = 6;
              continue;
            default:
              goto label_5;
          }
          assemblyInfoCache1 = assemblyInfoCache2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 12 : 5;
        }
label_14:
        num1 = 13;
      }
label_21:
      return;
label_49:
      return;
label_28:
      return;
label_12:
      return;
label_27:
      return;
label_5:
      return;
label_42:
      return;
label_17:
      return;
label_25:
      try
      {
label_32:
        if (enumerator.MoveNext())
          goto label_34;
        else
          goto label_33;
label_26:
        MethodInfo current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 2:
              if (!RequiredVirtualMethodModule.WKWVjgW6ieycqBNfQwYC((object) current))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
                continue;
              }
              goto case 5;
            case 3:
              goto label_16;
            case 4:
              goto label_34;
            case 5:
              if (RequiredVirtualMethodModule.Yr483dW6Rqxgv7oPWJJr((object) current))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 1;
                continue;
              }
              goto label_32;
            default:
              goto label_31;
          }
        }
label_16:
        return;
label_31:
        throw new InvalidOperationException(this.message(nonProxyType, current));
label_33:
        num3 = 3;
        goto label_26;
label_34:
        current = enumerator.Current;
        num3 = 2;
        goto label_26;
      }
      finally
      {
        if (enumerator != null)
        {
          int num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
            num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 1:
                RequiredVirtualMethodModule.SEw4unW6qgWPidkH1EDe((object) enumerator);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
                continue;
              default:
                goto label_44;
            }
          }
        }
label_44:;
      }
label_37:;
    }

    private Type GetNonProxyType(Type type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 2:
            if (!(type == (Type) null))
            {
              if (RequiredVirtualMethodModule.Ph45K3W6K5rjq369MLCL((object) type.Assembly))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 4 : 3;
                continue;
              }
              goto label_5;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
              continue;
            }
          case 3:
            goto label_5;
          case 4:
            type = type.BaseType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 2 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (Type) null;
label_5:
      return type;
    }

    internal static void m8jiEAW6uSbU7gZIv944([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((Autofac.Module) obj0).AttachToComponentRegistration((IComponentRegistry) obj1, (IComponentRegistration) obj2));

    internal static object c18kLMW6Iq3eFOorICYq([In] object obj0) => (object) ((IComponentRegistration) obj0).Activator;

    internal static Type bBlEe5W6VtmAeYnw0uEA([In] object obj0) => ((IInstanceActivator) obj0).LimitType;

    internal static bool uoePfFW6SpwGa3FZc3U9([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static bool WKWVjgW6ieycqBNfQwYC([In] object obj0) => ((MethodBase) obj0).IsVirtual;

    internal static bool Yr483dW6Rqxgv7oPWJJr([In] object obj0) => ((MethodBase) obj0).IsFinal;

    internal static void SEw4unW6qgWPidkH1EDe([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool e7YMm9W68EfeoZoJ3Rfc() => RequiredVirtualMethodModule.dhrlZEW6vNXZjhg9MglN == null;

    internal static RequiredVirtualMethodModule twMbnTW6Z8BOqUDF3d16() => RequiredVirtualMethodModule.dhrlZEW6vNXZjhg9MglN;

    internal static bool Ph45K3W6K5rjq369MLCL([In] object obj0) => InterceptionRegistrationExtensions.IsProxyAssembly((Assembly) obj0);
  }
}
