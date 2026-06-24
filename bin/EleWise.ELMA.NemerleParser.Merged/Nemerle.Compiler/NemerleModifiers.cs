using System;

namespace Nemerle.Compiler;

[Flags]
public enum NemerleModifiers
{
	None = 0,
	Public = 1,
	Private = 2,
	New = 4,
	Protected = 8,
	Abstract = 0x10,
	Virtual = 0x20,
	Sealed = 0x40,
	Static = 0x80,
	Mutable = 0x100,
	Internal = 0x200,
	Override = 0x400,
	Struct = 0x1000,
	Macro = 0x2000,
	Volatile = 0x4000,
	SpecialName = 0x8000,
	Partial = 0x10000,
	Extern = 0x20000,
	CompilerMutable = 0x40000,
	VirtualityModifiers = 0x434,
	OverrideModifiers = 0x430,
	AccessModifiers = 0x20B
}
