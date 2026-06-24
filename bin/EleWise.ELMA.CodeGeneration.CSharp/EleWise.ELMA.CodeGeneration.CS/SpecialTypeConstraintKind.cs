using System;

namespace EleWise.ELMA.CodeGeneration.CSharp.Enums;

[Flags]
public enum SpecialTypeConstraintKind
{
	None = 0,
	ReferenceType = 1,
	ValueType = 2,
	Constructor = 4
}
