// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.ProjectionsExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using NHibernate.Criterion;
using NHibernate.Impl;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.Extensions
{
  /// <summary>Расширение проекций NHibernate</summary>
  public static class ProjectionsExtensions
  {
    /// <summary>Группировка по свойству</summary>
    /// <typeparam name="T">Тип объекта</typeparam>
    /// <typeparam name="TResult">Тип результата выражения</typeparam>
    /// <param name="expression">Выражение</param>
    /// <returns>Проекция</returns>
    public static PropertyProjection Group<T, TResult>(Expression<Func<T, TResult>> expression) => Projections.GroupProperty(ExpressionProcessor.FindMemberExpression(expression.Body));
  }
}
