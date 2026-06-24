namespace EleWise.ELMA.Services;

public interface IRemotingAssemblyResolverService
{
	byte[] ResolveAssembly(string assemblyName, bool isFullName);
}
