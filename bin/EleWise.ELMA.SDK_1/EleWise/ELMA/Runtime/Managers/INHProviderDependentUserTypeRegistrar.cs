// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Managers.INHProviderDependentUserTypeRegistrar
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;

namespace EleWise.ELMA.Runtime.Managers
{
  /// <summary>
  /// Регистратор пользовательского типа NHibernate, зависящего от провайдера БД
  /// </summary>
  [ExtensionPoint(ComponentType.Server)]
  internal interface INHProviderDependentUserTypeRegistrar
  {
    /// <summary>Уникальный идентификатор провайдера БД</summary>
    Guid ProviderUid { get; }

    /// <summary>
    /// Зарегистрировать пользовательский тип NHibernate в контейнере Autofac
    /// </summary>
    void Register();
  }
}
