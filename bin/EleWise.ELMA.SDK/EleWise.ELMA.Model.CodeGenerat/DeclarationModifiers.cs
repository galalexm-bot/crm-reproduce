using System;

namespace EleWise.ELMA.Model.CodeGeneration;

[Flags]
public enum DeclarationModifiers
{
	None = 0,
	Abstract = 1,
	New = 2,
	Sealed = 4,
	Override = 8,
	Virtual = 0x10,
	Static = 0x20,
	Async = 0x40,
	Const = 0x80,
	ReadOnly = 0x100,
	Unsafe = 0x200,
	Partial = 0x400
}
