using System.Collections.Generic;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

public class PostReadPacketsParameters : ImportExtensionParameters
{
	public List<long> HeaderIds { get; set; }

	public PostReadPacketsParameters(List<DeployLogMessage> messages, List<DeploySystemMessage> systemMessages, string serverFolderName, Dictionary<string, string> serviceData, ElmaStoreComponentManifest manifest, int importStep, List<long> headerIds, string treeUid)
	{
		SingletonReader.JJCZtPuTvSt();
		HeaderIds = new List<long>();
		base._002Ector(messages, systemMessages, serverFolderName, serviceData, manifest, importStep, treeUid);
		HeaderIds = headerIds;
	}
}
