using System;

namespace EleWise.ELMA.ComponentModel;

[Flags]
public enum ComponentType
{
	All = 0x10C7,
	Server = 1,
	WebServer = 2,
	Web = 4,
	DesignServer = 0x40,
	Design = 0x80,
	Test = 0x1000
}
