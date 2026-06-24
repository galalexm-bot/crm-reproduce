using System;

namespace EleWise.ELMA.XmlSerializers;

[Flags]
public enum XmlMappingAccess
{
	None = 0,
	Read = 1,
	Write = 2
}
