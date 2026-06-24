// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.ISortedProperty
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>
  /// Дополнительный интерфейс описания типа данных, предоставляющий методы для сортируемых свойств
  /// </summary>
  public interface ISortedProperty
  {
    /// <summary>Поддерживает сортировку</summary>
    /// <returns></returns>
    bool IsSupportSort();

    /// <summary>
    /// Компаратор сравнения для свойства (вызывается для NHibernate)
    /// </summary>
    /// <param name="sourceType"></param>
    /// <param name="propertyFunc"></param>
    /// <param name="order"></param>
    /// <returns></returns>
    IComparer GetComparer(Type sourceType, LambdaExpression propertyFunc, ListSortDirection order);

    /// <summary>Компаратор сравнения для свойства</summary>
    /// <typeparam name="TSource"></typeparam>
    /// <typeparam name="TKey"></typeparam>
    /// <param name="propertyFunc"></param>
    /// <param name="order"></param>
    /// <returns></returns>
    IComparer<TSource> GetComparer<TSource, TKey>(
      Func<TSource, TKey> propertyFunc,
      ListSortDirection order);
  }
}
