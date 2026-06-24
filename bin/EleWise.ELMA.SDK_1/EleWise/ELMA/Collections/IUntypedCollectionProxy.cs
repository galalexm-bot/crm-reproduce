// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Collections.IUntypedCollectionProxy
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections;

namespace EleWise.ELMA.Collections
{
  public interface IUntypedCollectionProxy : IEnumerable
  {
    /// <summary>Добавить элемент</summary>
    /// <param name="o">Элемент</param>
    /// <returns></returns>
    void Add(object o);

    /// <summary>Удалить элемент</summary>
    /// <param name="o">Элемент</param>
    /// <returns></returns>
    bool Remove(object o);

    /// <summary>Очистить список</summary>
    void Clear();

    /// <summary>Определяет содержит ли список элемент</summary>
    /// <param name="o">Элемент</param>
    bool Contains(object o);
  }
}
