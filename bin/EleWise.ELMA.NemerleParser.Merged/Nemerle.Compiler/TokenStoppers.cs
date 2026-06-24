using System;

namespace Nemerle.Compiler;

[Flags]
public enum TokenStoppers
{
	None = 0,
	Pipe = 1,
	Equal = 2,
	Braces = 4,
	Arrow = 8,
	Colon = 0x10,
	Dollar = 0x20,
	Where = 0x40,
	All = 0x4F
}
