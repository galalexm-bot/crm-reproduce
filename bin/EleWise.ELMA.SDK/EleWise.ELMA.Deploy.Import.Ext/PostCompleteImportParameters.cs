using System.Collections.Generic;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

public class PostCompleteImportParameters : ImportExtensionParameters
{
	public new string TreeUid { get; }

	public PostCompleteImportParameters(List<DeployLogMessage> messages, List<DeploySystemMessage> systemMessages, string serverFolderName, Dictionary<string, string> serviceData, ElmaStoreComponentManifest manifest, int importStep, string treeUid)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(messages, systemMessages, serverFolderName, serviceData, manifest, importStep);
		TreeUid = treeUid;
	}
}
