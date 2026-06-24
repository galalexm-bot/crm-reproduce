using System;

namespace EleWise.ELMA.Model.Metadata.Services;

internal interface IModuleAssemblyLoader
{
	ClientBuildResult GetClientAssembly(Guid moduleUid, Guid versionUid);

	ServerBuildResult GetServerAssembly(Guid moduleUid, Guid versionUid);
}
