// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.IComputedValue
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Вычисляемое значение</summary>
  public interface IComputedValue
  {
    /// <summary>Имя свойства</summary>
    string Name { get; set; }

    /// <summary>Значение</summary>
    object Value { get; set; }

    /// <summary>Имя функции</summary>
    string MethodName { get; set; }

    /// <summary>Вычисляемый скрипт</summary>
    string CalculateScript { get; set; }

    /// <summary>Выбранные тип вычисления значения</summary>
    ComputedValueType ComputedValueType { get; set; }

    /// <summary>
    /// Идентификатор выбранного свойства
    /// Используется если ComputedValueType.Property
    /// </summary>
    Guid PropertyUid { get; set; }

    /// <summary>
    /// Идентификаторы вложенных свойств
    /// Используется если ComputedValueType.Property
    /// </summary>
    List<Guid> PropertyParents { get; set; }
  }
}
