// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.IFormDependency
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>
  /// Интерфейс элемента, который может содержать ссылки на формы
  /// </summary>
  public interface IFormDependency
  {
    /// <summary>Имя элемента</summary>
    string Name { get; }

    /// <summary>Идентификаторы используемых форм</summary>
    IList<Guid> FormUids { get; }

    /// <summary>Зависимость по умолчанию</summary>
    bool DefaultDependency { get; set; }
  }
}
