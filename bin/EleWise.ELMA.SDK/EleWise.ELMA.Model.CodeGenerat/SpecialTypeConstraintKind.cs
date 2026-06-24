using System;

namespace EleWise.ELMA.Model.CodeGeneration;

[Flags]
public enum SpecialTypeConstraintKind
{
	None = 0,
	ReferenceType = 1,
	ValueType = 2,
	Constructor = 4
}
