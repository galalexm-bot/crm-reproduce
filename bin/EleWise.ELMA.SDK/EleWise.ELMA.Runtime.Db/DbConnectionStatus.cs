using System;

namespace EleWise.ELMA.Runtime.Db;

[Flags]
public enum DbConnectionStatus
{
	Unknown = 0,
	Starting = 1,
	Started = 2,
	ConfigurationScriptsRecompileRequired = 4
}
