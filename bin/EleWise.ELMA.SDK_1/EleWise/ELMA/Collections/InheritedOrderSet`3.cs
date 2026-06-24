// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Collections.InheritedOrderSet`3
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Services;
using Iesi.Collections;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace EleWise.ELMA.Collections
{
  [Obsolete("Use InheritedSet<TSource, TTarget> instead", true)]
  public class InheritedOrderSet<TSource, TTarget, TKey> : 
    InheritedSet<TSource, TTarget>,
    Iesi.Collections.Generic.ISet<TTarget>,
    System.Collections.Generic.ISet<TTarget>,
    ICollection<TTarget>,
    IEnumerable<TTarget>,
    IEnumerable,
    IInheritedSet,
    ISet,
    ICollection
    where TSource : class
    where TTarget : class
  {
    private readonly IComparer<TSource> comparer;
    private static object nrwqlw0gBBABULEre58;

    public InheritedOrderSet(
      Iesi.Collections.Generic.ISet<TSource> source,
      Guid typeUidProperty,
      Guid subTypeUidProperty,
      Func<TSource, TKey> propertyExpression,
      ListSortDirection order)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(source);
      ITypeDescriptor typeDescriptor = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeDescriptor(typeUidProperty, subTypeUidProperty);
      if (!(typeDescriptor is ISortedProperty sortedProperty))
        throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488840517), (object) typeDescriptor.GetType().FullName));
      this.comparer = sortedProperty.GetComparer<TSource, TKey>(propertyExpression, order);
      if (this.comparer == null)
        throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633538631), (object) typeDescriptor.GetType().FullName));
    }

    public override IEnumerator<TTarget> GetEnumerator() => (IEnumerator<TTarget>) new InheritedSet<TSource, TTarget>.EnumeratorT((IEnumerator<TSource>) new SortedSet<TSource>((IEnumerable<TSource>) this.source, this.comparer).GetEnumerator());

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) new SortedSet<TSource>((IEnumerable<TSource>) this.source, this.comparer).GetEnumerator();

    internal static bool seQ7jh056PjwhZLhe8o() => InheritedOrderSet<TSource, TTarget, TKey>.nrwqlw0gBBABULEre58 == null;

    internal static object ey2Adr0j2h33llIgM4u() => InheritedOrderSet<TSource, TTarget, TKey>.nrwqlw0gBBABULEre58;
  }
}
