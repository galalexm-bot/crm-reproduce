// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.IValueContainerObjectInternal
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;
using System.ComponentModel;

namespace EleWise.ELMA.Model.Entities
{
  /// <summary>
  /// Интерфейс контейнерного объекта
  /// Объект хранит значения своих свойств во внутреннем контейнере
  /// </summary>
  [EditorBrowsable(EditorBrowsableState.Never)]
  public interface IValueContainerObjectInternal
  {
    /// <summary>Получить контейнеры с данными</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    IEnumerable<object> GetData();
  }
}
