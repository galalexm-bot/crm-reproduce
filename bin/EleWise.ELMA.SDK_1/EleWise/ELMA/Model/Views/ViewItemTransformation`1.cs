// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ViewItemTransformation`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Globalization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace EleWise.ELMA.Model.Views
{
  public class ViewItemTransformation<TItem> where TItem : ViewItem
  {
    private static object i1vHTSo13KuaeVtUiaXN;

    /// <summary>Изменить параметры элемента формы</summary>
    /// <param name="itemUid">Для какого элемента формы менять параметры</param>
    /// <param name="property">Свойство</param>
    /// <param name="value">Новое значение</param>
    /// <returns></returns>
    public static ViewItemTransformationChange SetPropertyValue<T>(
      Guid itemUid,
      Expression<Func<TItem, T>> property,
      T value)
    {
      MemberExpression memberExpression = property != null ? LinqUtils.GetMemberExpression((LambdaExpression) property) : (MemberExpression) null;
      bool flag = false;
      if (memberExpression != null && memberExpression.Member != (MemberInfo) null && memberExpression.Member.IsDefined(typeof (LocalizableAttribute), true))
        flag = true;
      ViewItemTransformationChange transformationChange = new ViewItemTransformationChange();
      transformationChange.Uid = itemUid;
      transformationChange.PropertyName = LinqUtils.FullNameOf<TItem, T>(property);
      transformationChange.Localizable = flag;
      transformationChange.Value = (object) value;
      return transformationChange;
    }

    public ViewItemTransformation()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Q7LDNyo1psu5sEcwVIia() => ViewItemTransformation<TItem>.i1vHTSo13KuaeVtUiaXN == null;

    internal static object lPLGWRo1aUEy6fnkDHbl() => ViewItemTransformation<TItem>.i1vHTSo13KuaeVtUiaXN;
  }
}
