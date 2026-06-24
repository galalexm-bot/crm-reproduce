// Decompiled with JetBrains decompiler
// Type: System.Linq.Dynamic.DynamicExpression
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace System.Linq.Dynamic
{
  public static class DynamicExpression
  {
    internal static DynamicExpression QUr4lbbylougZgBfITT;

    public static Expression Parse(Type resultType, string expression, params object[] values) => (Expression) DynamicExpression.T80HJWb9UamySHCNitv((object) new ExpressionParser((ParameterExpression[]) null, expression, values), resultType);

    public static LambdaExpression ParseLambda(
      Type itType,
      Type resultType,
      string expression,
      params object[] values)
    {
      return DynamicExpression.ParseLambda(new ParameterExpression[1]
      {
        (ParameterExpression) DynamicExpression.vVlfNqbdPeXu3iWDnjT(itType, (object) "")
      }, resultType, expression, values);
    }

    public static LambdaExpression ParseLambda(
      ParameterExpression[] parameters,
      Type resultType,
      string expression,
      params object[] values)
    {
      return Expression.Lambda((Expression) DynamicExpression.T80HJWb9UamySHCNitv((object) new ExpressionParser(parameters, expression, values), resultType), parameters);
    }

    public static Expression<Func<T, S>> ParseLambda<T, S>(
      string expression,
      params object[] values)
    {
      return (Expression<Func<T, S>>) DynamicExpression.ParseLambda(typeof (T), typeof (S), expression, values);
    }

    public static Type CreateClass(params DynamicProperty[] properties) => ClassFactory.Instance.GetDynamicClass((IEnumerable<DynamicProperty>) properties);

    public static Type CreateClass(IEnumerable<DynamicProperty> properties) => ClassFactory.Instance.GetDynamicClass(properties);

    internal static object T80HJWb9UamySHCNitv([In] object obj0, Type resultType) => (object) ((ExpressionParser) obj0).Parse(resultType);

    internal static bool FhNCD7bMcmITMMv5Ucf() => DynamicExpression.QUr4lbbylougZgBfITT == null;

    internal static DynamicExpression w81283bJGlTexX2n0YP() => DynamicExpression.QUr4lbbylougZgBfITT;

    internal static object vVlfNqbdPeXu3iWDnjT([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);
  }
}
