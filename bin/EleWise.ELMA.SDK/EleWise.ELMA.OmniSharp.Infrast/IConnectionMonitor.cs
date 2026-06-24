namespace EleWise.ELMA.OmniSharp.Infrastructure;

internal interface IConnectionMonitor
{
	bool IsOffline { get; }
}
