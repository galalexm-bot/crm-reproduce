// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.IConditionOperandEvaluator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Вычислитель значения операнда для табличного условия</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IConditionOperandEvaluator
  {
    /// <summary>
    /// Уникальный идентификатор вычислителя. Соответствует значению свойства CustomTypeUid в операнде
    /// </summary>
    Guid Uid { get; }

    /// <summary>Вычислить значение операнда</summary>
    /// <param name="operand">Операнд</param>
    /// <param name="obj">Объект, для которого проверяется условие</param>
    /// <param name="additionalParams">Дополнительные параметры</param>
    /// <returns>Значение операнда</returns>
    ConditionTableEvaluator.OperandValue Evaluate(
      ConditionTable.Operand operand,
      object obj,
      Dictionary<string, object> additionalParams);
  }
}
