using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Scripts;

[ExtensionPoint(ComponentType.All)]
public interface IMetadataUpdateDataHandler
{
	bool Check(IMetadata metadata);

	IEnumerable<ScriptModule> GetScriptModules(IMetadataUpdateResult updateResult);

	IEnumerable<Guid> GetFormUids(IMetadataUpdateResult updateResult);
}
