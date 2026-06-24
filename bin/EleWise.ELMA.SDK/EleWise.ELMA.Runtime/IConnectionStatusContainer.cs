using EleWise.ELMA.Runtime.Db;

namespace EleWise.ELMA.Runtime;

internal interface IConnectionStatusContainer
{
	DbConnectionStatus Status { get; }
}
