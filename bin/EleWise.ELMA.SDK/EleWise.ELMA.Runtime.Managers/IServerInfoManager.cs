using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Modules;

namespace EleWise.ELMA.Runtime.Managers;

public interface IServerInfoManager : IConfigurationService
{
	AssemblyHashInfo[] GetBinaryHashInfos();

	byte[] GetAssemblyRaw(string assemblyName);

	string GetMainProviderType();

	string GetEdition();

	ModuleStatusInfo[] GetModuleStatuses();
}
