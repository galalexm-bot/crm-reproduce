// Decompiled with JetBrains decompiler
// Type: Autofac.AutofacExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac.Builder;
using EleWise.ELMA.ComponentModel;
using SG9KiyIbtdgGDf12qr;
using System;

namespace Autofac
{
  /// <summary>Расширения для Autofac</summary>
  public static class AutofacExtensions
  {
    /// <summary>Установить жизненный цикл</summary>
    /// <param name="register">Регистрация компонента</param>
    /// <param name="scope">Жизненный цикл</param>
    public static void SetScope<TLimit, TActivatorData, TRegistrationStyle>(
      this IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> register,
      ServiceScope scope)
    {
      switch (scope)
      {
        case ServiceScope.Shell:
          register.SingleInstance();
          break;
        case ServiceScope.Application:
          register.SingleInstance();
          break;
        case ServiceScope.Transient:
          register.InstancePerDependency();
          break;
        case ServiceScope.UnitOfWork:
          register.InstancePerMatchingLifetimeScope((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124640716));
          break;
        default:
          throw new InvalidOperationException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105197908) + (object) scope);
      }
    }
  }
}
