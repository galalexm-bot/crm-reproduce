// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Context.IAbstractBoundVariableServiceExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Runtime.Context
{
  /// <summary>
  /// Расширение для всех наследников IAbstractBoundVariableService
  /// </summary>
  public static class IAbstractBoundVariableServiceExtensions
  {
    /// <summary>
    /// Получить значение из сервиса, или установить если ничего не найдено
    /// </summary>
    /// <typeparam name="T">Тип значения</typeparam>
    /// <param name="contextObjects">Контекст</param>
    /// <param name="name">Ключ</param>
    /// <param name="factory">Функция получения значения, если ничего не найдено</param>
    /// <exception cref="T:System.ArgumentNullException">Если <c>contextObjects</c>,<c>name</c>,<c>factory</c> равно <c>null</c></exception>
    /// <returns>Значение переменной</returns>
    public static T GetOrAdd<T>(
      [NotNull] this IAbstractBoundVariableService contextObjects,
      [NotNull] string name,
      [NotNull] Func<T> factory)
    {
      Contract.ArgumentNotNull((object) contextObjects, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939506480));
      Contract.ArgumentNotNullOrEmpty(name, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420742352));
      Contract.ArgumentNotNull((object) factory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1200075889));
      T orAdd1;
      if (contextObjects.TryGetValue<T>(name, out orAdd1))
        return orAdd1;
      T orAdd2 = factory();
      contextObjects.Set(name, (object) orAdd2);
      return orAdd2;
    }
  }
}
