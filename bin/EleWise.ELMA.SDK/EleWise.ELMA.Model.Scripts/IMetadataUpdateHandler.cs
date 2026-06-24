using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Scripts;

[ExtensionPoint(ComponentType.All)]
public interface IMetadataUpdateHandler
{
	bool Check(IMetadata metadata);

	void UpdateMetadata(IMetadataUpdateResult updateResult);

	void UpdateForm(IMetadataUpdateResult updateResult, Guid formUid);

	void UpdateScriptModules(IMetadataUpdateResult updateResult);
}
