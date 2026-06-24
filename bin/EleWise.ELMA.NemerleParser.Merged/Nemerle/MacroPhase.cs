using System;

namespace Nemerle;

[Flags]
public enum MacroPhase
{
	None = 0,
	BeforeInheritance = 1,
	BeforeTypedMembers = 2,
	WithTypedMembers = 3
}
