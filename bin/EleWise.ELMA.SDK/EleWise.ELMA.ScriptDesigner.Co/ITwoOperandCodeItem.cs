using System;
using System.CodeDom;
using System.Collections.Generic;
using EleWise.ELMA.ScriptDesigner.Enums;

namespace EleWise.ELMA.ScriptDesigner.CodeItems;

public interface ITwoOperandCodeItem : ICompositeCodeItem, ICodeItem
{
	CodeItem OperandOne { get; set; }

	CodeItem OperandTwo { get; set; }

	string Operator { get; set; }

	List<Type> GetTypesByOperand(OperandDirection direction);

	CodeBinaryOperatorType GetOperatorType();
}
