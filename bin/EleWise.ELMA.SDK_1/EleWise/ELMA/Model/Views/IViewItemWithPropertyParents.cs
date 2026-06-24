// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.IViewItemWithPropertyParents
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Элемент представления со списком родительских свойств</summary>
  public interface IViewItemWithPropertyParents
  {
    /// <summary>
    /// Список родителей свойства
    /// <remarks>
    /// Список пустой, если свойство расположено на первом уровне (взято напрямую из списка контекстных переменных)
    /// Список заполнен, если это вложенное свойство Сущности/DataClass
    /// Список заполнен в прямом порядке: первым элементом является контекстная переменная
    /// </remarks>
    /// </summary>
    List<Guid> PropertyParents { get; set; }
  }
}
