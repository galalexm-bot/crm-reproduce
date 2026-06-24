namespace EleWise.ELMA.Runtime;

public enum StartErrorType
{
	Fatal = 0,
	OlderVersion = 1,
	OtherConnections = 2,
	LastUpdateFault = 3,
	ConfigurationScriptsRecompileRequired = 10
}
