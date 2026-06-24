using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Model.Scripts;

[ExtensionPoint(ComponentType.All)]
public interface IConditionOperandEvaluator
{
	Guid Uid { get; }

	ConditionTableEvaluator.OperandValue Evaluate(ConditionTable.Operand operand, object obj, Dictionary<string, object> additionalParams);
}
