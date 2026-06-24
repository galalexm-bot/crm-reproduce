// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Comparers.Comparer`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;

namespace EleWise.ELMA.Model.Types.Comparers
{
  /// <summary>Сравниватель для InheritedOrderSet</summary>
  /// <typeparam name="TSource"></typeparam>
  /// <typeparam name="TKey"></typeparam>
  public class Comparer<TSource, TKey> : IComparer<TSource>, IComparer
  {
    private readonly Func<TSource, TKey> propertyFunc;
    private readonly ListSortDirection order;
    private readonly int orderInt;
    internal static object aR5spNoUp83Nn8fuHGLI;

    /// <summary>Ctor</summary>
    /// <param name="propertyFunc"></param>
    /// <param name="order"></param>
    public Comparer(Func<TSource, TKey> propertyFunc, ListSortDirection order)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.propertyFunc = propertyFunc;
      this.order = order;
      this.orderInt = this.order == ListSortDirection.Descending ? -1 : 1;
    }

    /// <summary>Ctor</summary>
    /// <param name="expression"></param>
    /// <param name="order"></param>
    public Comparer(LambdaExpression expression, ListSortDirection order)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector((Func<TSource, TKey>) expression.Compile(), order);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Сравнивание по ключам</summary>
    /// <param name="keyX"></param>
    /// <param name="keyY"></param>
    /// <returns></returns>
    protected virtual int Compare(TKey keyX, TKey keyY)
    {
      if ((object) keyX == null)
        return 1;
      int num = (object) keyX is IComparable ? ((IComparable) (object) keyX).CompareTo((object) keyY) : throw new ArgumentException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239473692), (object) typeof (TKey).FullName));
      return num != 0 ? num : 1;
    }

    /// <summary>Сравнить</summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public virtual int Compare(TSource x, TSource y) => object.Equals((object) x, (object) y) ? 0 : this.orderInt * this.Compare(this.propertyFunc(x), this.propertyFunc(y));

    /// <summary>Сравнить</summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public int Compare(object x, object y) => this.Compare((TSource) x, (TSource) y);

    internal static bool vIjMVYoUaMLbFDjgxa02() => Comparer<TSource, TKey>.aR5spNoUp83Nn8fuHGLI == null;

    internal static object UsSnMLoUDI0kNpyYquob() => Comparer<TSource, TKey>.aR5spNoUp83Nn8fuHGLI;
  }
}
