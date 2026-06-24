using System.Collections.Generic;

namespace EleWise.ELMA.CAB.Configuration;

public interface IModuleInfo
{
	string AssemblyFile { get; }

	string UpdateLocation { get; }

	IList<string> AllowedRoles { get; }
}
