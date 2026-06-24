// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.ElmaGenericSortedSetType`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>
  /// An <see cref="T:NHibernate.Type.IType" /> that maps a sorted <see cref="T:System.Collections.Generic.ISet`1" /> collection
  /// to the database.
  /// </summary>
  [Serializable]
  public class ElmaGenericSortedSetType<T> : NHibernate.Type.GenericSetType<T>
  {
    private readonly IComparer<T> comparer;
    private static object V6DA5xWpesoKljIjxOsm;

    /// <summary>
    /// Initializes a new instance of a <see cref="T:EleWise.ELMA.Runtime.NH.ElmaGenericSortedSetType`1" /> class for
    /// a specific role.
    /// </summary>
    /// <param name="role">The role the persistent collection is in.</param>
    /// <param name="propertyRef">The name of the property in the
    /// owner object containing the collection ID, or <see langword="null" /> if it is
    /// the primary key.</param>
    /// <param name="comparer">The <see cref="T:System.Collections.Generic.IComparer`1" /> to use to compare
    /// set elements.</param>
    public ElmaGenericSortedSetType(string role, string propertyRef, IComparer<T> comparer)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(role, propertyRef);
      this.comparer = comparer;
    }

    public IComparer<T> Comparer => this.comparer;

    public override object Instantiate(int anticipatedSize) => (object) new IesiSortedSet<T>(this.comparer);

    internal static bool tYZfvQWpPMHANc9CDuv5() => ElmaGenericSortedSetType<T>.V6DA5xWpesoKljIjxOsm == null;

    internal static object f7Fon9Wp1r9jEoUjJVSJ() => ElmaGenericSortedSetType<T>.V6DA5xWpesoKljIjxOsm;
  }
}
