// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ISetExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA
{
  /// <summary>Расширения для ISet</summary>
  public static class ISetExtensions
  {
    public static bool AddAll<T>(this ISet<T> source, IEnumerable<T> newElements) => newElements.Aggregate<T, bool>(false, (Func<bool, T, bool>) ((current, o) => current | source.Add(o)));

    public static bool RemoveAll<T>(this ISet<T> source, IEnumerable<T> removedElements) => removedElements.Aggregate<T, bool>(false, (Func<bool, T, bool>) ((current, o) => current | ((ICollection<T>) source).Remove(o)));

    public static bool ContainsAll<T>(this ISet<T> source, IEnumerable<T> collection) => collection.All<T>(new Func<T, bool>(((ICollection<T>) source).Contains));
  }
}
