// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Scope.IExecutionScopeBuilder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Services.Scope
{
  /// <summary>Построитель контекста выполнения</summary>
  public interface IExecutionScopeBuilder
  {
    /// <summary>Создать модель регистрации</summary>
    /// <param name="type">Тип</param>
    /// <param name="registerTypes">Список типов, под которыми будет зарагистрирован <see cref="!:type" /></param>
    /// <returns>Построитель контекста выполнения</returns>
    IExecutionScopeBuilder AddRegistration(Type type, params Type[] registerTypes);

    /// <summary>Создать модель регистрации</summary>
    /// <param name="type">Тип</param>
    /// <param name="registerTypes">Список типов, под которыми будет зарагистрирован <see cref="!:type" /></param>
    /// <returns>Построитель контекста выполнения</returns>
    IExecutionScopeBuilder AddRegistration(Type type, IEnumerable<Type> registerTypes);

    /// <summary>Создать модель регистрации</summary>
    /// <param name="instance">Экземпляр объекта</param>
    /// <param name="registerTypes">Список типов, под которыми будет зарагистрирован <see cref="!:instance" /></param>
    /// <returns>Построитель контекста выполнения</returns>
    IExecutionScopeBuilder AddRegistration(object instance, params Type[] registerTypes);

    /// <summary>Создать модель регистрации</summary>
    /// <param name="instance">Экземпляр объекта</param>
    /// <param name="registerTypes">Список типов, под которыми будет зарагистрирован <see cref="!:instance" /></param>
    /// <returns>Построитель контекста выполнения</returns>
    IExecutionScopeBuilder AddRegistration(object instance, IEnumerable<Type> registerTypes);

    /// <summary>Запустить построитель контекста выполнения</summary>
    /// <returns>Контекст выполнения</returns>
    IExecutionScope StartScope();
  }
}
