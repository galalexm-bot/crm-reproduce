// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Collections.IInheritedSet
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Iesi.Collections;
using System.Collections;

namespace EleWise.ELMA.Collections
{
  /// <summary>Интерфейс унаследованного набора</summary>
  public interface IInheritedSet : ISet, ICollection, IEnumerable
  {
    /// <summary>Получить оригинальный набор</summary>
    /// <returns></returns>
    ISet GetSourceSet();

    /// <summary>Инициализирована ли коллекция</summary>
    bool WasInitialized { get; }
  }
}
