// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Managers.NHProviderDependentUserTypeRegistrar`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using NHibernate.UserTypes;
using System;

namespace EleWise.ELMA.Runtime.Managers
{
  /// <summary>
  /// Базовая класс регистратора типов данных NHibernate, зависящих от провайдера БД
  /// </summary>
  /// <typeparam name="TUserTypeImpl">Тип реализиации типа данных NHibernate</typeparam>
  /// <typeparam name="TUserTypeBase">Базовый тип типа данных NHibernate</typeparam>
  [Component(Type = ComponentType.Server, InjectProerties = false, EnableInterceptors = false)]
  public abstract class NHProviderDependentUserTypeRegistrar<TUserTypeImpl, TUserTypeBase> : 
    INHProviderDependentUserTypeRegistrar
    where TUserTypeImpl : TUserTypeBase
    where TUserTypeBase : IUserType
  {
    internal static object lnSev0WMhevsY5Ktrhg0;

    /// <inheritdoc />
    public abstract Guid ProviderUid { get; }

    /// <inheritdoc />
    void INHProviderDependentUserTypeRegistrar.Register() => NHProviderDependentUserTypes.Register<TUserTypeBase, TUserTypeImpl>();

    protected NHProviderDependentUserTypeRegistrar()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool fkcsCcWMGgi8QCgQC1Oq() => NHProviderDependentUserTypeRegistrar<TUserTypeImpl, TUserTypeBase>.lnSev0WMhevsY5Ktrhg0 == null;

    internal static object nDlYTsWMEKlLdKYBdxfp() => NHProviderDependentUserTypeRegistrar<TUserTypeImpl, TUserTypeBase>.lnSev0WMhevsY5Ktrhg0;
  }
}
