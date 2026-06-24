using EleWise.ELMA.Documents.API.Service.Agent;

namespace EleWise.ELMA.Agent.Services;

internal abstract class AgentPathsAbstractResolver : IAgentPathsResolver
{
	public abstract string GetAgentLinuxInstallerPath();

	public abstract string GetAgentMacInstallerPath();

	public abstract string GetAgentVersionFilePath();

	public abstract string GetAgentWindowsInstallerPath();
}
