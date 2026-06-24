using System;

namespace Nemerle.Compiler.Typedtree;

[Flags]
internal enum TExprFlags
{
	IsAssigned = 1,
	Visited = 2,
	Throws = 4,
	ThrowsComputed = 8,
	NeedAddress = 0x10,
	Addressable = 0x20,
	AddressableComputed = 0x40,
	JumpTarget = 0x80,
	Constrained = 0x100,
	GenerateTail = 0x200,
	SkipWriteCheck = 0x400,
	NeedsEmptyStack = 0x800,
	NeedsEmptyStackComputed = 0x1000
}
