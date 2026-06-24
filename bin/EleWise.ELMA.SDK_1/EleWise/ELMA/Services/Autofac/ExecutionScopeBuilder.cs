// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Autofac.ExecutionScopeBuilder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using Autofac.Builder;
using Autofac.Core;
using EleWise.ELMA.Services.Scope;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services.Autofac
{
  /// <inheritdoc />
  internal sealed class ExecutionScopeBuilder : IExecutionScopeBuilder
  {
    private readonly ILifetimeScope globalScope;
    private readonly List<IComponentRegistration> registrations;
    internal static ExecutionScopeBuilder UuE38jBmd6Ksstdy2RC6;

    /// <summary>Ctor</summary>
    /// <param name="globalScope">Глобальный контекст выполнения</param>
    internal ExecutionScopeBuilder(ILifetimeScope globalScope)
    {
      ExecutionScopeBuilder.q2oEilBmg1LKUbTMTSWI();
      this.registrations = new List<IComponentRegistration>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.globalScope = globalScope;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public IExecutionScopeBuilder AddRegistration(Type type, params Type[] registerTypes)
    {
      int num = 6;
      IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle> registrationBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 7:
            this.registrations.Add(registrationBuilder.CreateRegistration<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>());
            num = 9;
            continue;
          case 2:
          case 4:
            registrationBuilder.AsSelf<object, ConcreteReflectionActivatorData>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 0;
            continue;
          case 3:
            if (registerTypes.Length != 0)
            {
              num = 8;
              continue;
            }
            goto case 2;
          case 5:
            registrationBuilder = RegistrationBuilder.ForType(type).PropertiesAutowired<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(PropertyWiringOptions.AllowCircularDependencies);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
            continue;
          case 6:
            ExecutionScopeBuilder.bSQJ53Bm51U90jA29v2T((object) type, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132913437));
            num = 5;
            continue;
          case 8:
            registrationBuilder.As(registerTypes);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 6 : 7;
            continue;
          case 9:
            goto label_7;
          default:
            if (registerTypes == null)
            {
              num = 2;
              continue;
            }
            goto case 3;
        }
      }
label_7:
      return (IExecutionScopeBuilder) this;
    }

    /// <inheritdoc />
    public IExecutionScopeBuilder AddRegistration(Type type, IEnumerable<Type> registerTypes) => this.AddRegistration(type, (registerTypes != null ? registerTypes.ToArray<Type>() : (Type[]) null) ?? Array.Empty<Type>());

    /// <inheritdoc />
    public IExecutionScopeBuilder AddRegistration(object instance, params Type[] registerTypes)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        IRegistrationBuilder<object, SimpleActivatorData, SingleRegistrationStyle> registrationBuilder;
        object instance1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 2:
              this.registrations.Add(registrationBuilder.CreateRegistration<object, SimpleActivatorData, SingleRegistrationStyle>());
              num2 = 11;
              continue;
            case 3:
            case 5:
              registrationBuilder.AsSelf<object, SimpleActivatorData>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 1;
              continue;
            case 4:
              registrationBuilder.As(registerTypes);
              num2 = 2;
              continue;
            case 6:
              if (registerTypes != null)
              {
                num2 = 9;
                continue;
              }
              goto case 3;
            case 7:
              instance1 = instance;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
              continue;
            case 8:
              num2 = 7;
              continue;
            case 9:
              if (registerTypes.Length == 0)
              {
                num2 = 5;
                continue;
              }
              goto case 4;
            case 10:
              registrationBuilder = RegistrationBuilder.ForDelegate(instance1.GetType(), (Func<IComponentContext, IEnumerable<Parameter>, object>) ((context, parameters) => instance1)).PropertiesAutowired<object, SimpleActivatorData, SingleRegistrationStyle>(PropertyWiringOptions.AllowCircularDependencies);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 1 : 6;
              continue;
            case 11:
              goto label_8;
            default:
              goto label_12;
          }
        }
label_12:
        Contract.ArgumentNotNull(instance1, (string) ExecutionScopeBuilder.U03VfbBmjR7mTLj91uXg(964881585 - -1459193222 ^ -1870851817));
        num1 = 10;
      }
label_8:
      return (IExecutionScopeBuilder) this;
    }

    /// <inheritdoc />
    public IExecutionScopeBuilder AddRegistration(object instance, IEnumerable<Type> registerTypes) => this.AddRegistration(instance, (registerTypes != null ? registerTypes.ToArray<Type>() : (Type[]) null) ?? Array.Empty<Type>());

    /// <inheritdoc />
    public IExecutionScope StartScope() => (IExecutionScope) new ExecutionScope(this.globalScope, (IEnumerable<IComponentRegistration>) this.registrations);

    internal static void q2oEilBmg1LKUbTMTSWI() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool IUhf8fBmlEptrKvrralf() => ExecutionScopeBuilder.UuE38jBmd6Ksstdy2RC6 == null;

    internal static ExecutionScopeBuilder kpvbsoBmrBhXp8eGdI5x() => ExecutionScopeBuilder.UuE38jBmd6Ksstdy2RC6;

    internal static void bSQJ53Bm51U90jA29v2T([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object U03VfbBmjR7mTLj91uXg(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
