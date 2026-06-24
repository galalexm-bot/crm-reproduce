namespace EleWise.ELMA.Documents.API.Service.Agent;

internal interface IAgentPathsResolver
{
	string GetAgentVersionFilePath();

	string GetAgentWindowsInstallerPath();

	string GetAgentLinuxInstallerPath();

	string GetAgentMacInstallerPath();
}
