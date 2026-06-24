using EleWise.ELMA.CAB.Configuration;

namespace EleWise.ELMA.CAB.Services;

public interface IModuleEnumerator
{
	IModuleInfo[] EnumerateModules();
}
