// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.NHRegisterExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using Autofac.Builder;
using EleWise.ELMA.ComponentModel;
using System;

namespace EleWise.ELMA.Extensions
{
  public static class NHRegisterExtensions
  {
    /// <summary>
    /// Зарегистрировать менеджер NHibernate типа <see cref="T:EleWise.ELMA.Runtime.Managers.NHManager" />
    /// </summary>
    /// <remarks>
    /// Вызывает внутри методы: RegisterType(managerType).PropertiesAutowired(false) и активириует перехватчики
    /// </remarks>
    /// <param name="builder">Текущий билдер</param>
    /// <param name="managerType">Тип менеджера</param>
    /// <returns>Регистратор</returns>
    public static IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle> RegisterNHManager(
      this ContainerBuilder builder,
      Type managerType)
    {
      IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle> registrar = builder.RegisterType(managerType).PropertiesAutowired<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(PropertyWiringOptions.AllowCircularDependencies);
      ComponentManager.Current.SetupInterceptors(managerType, registrar);
      return registrar;
    }
  }
}
