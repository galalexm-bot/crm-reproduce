using System.Collections.Generic;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Scripts;

public interface IMetadataUpdateResult
{
	IMetadata Metadata { get; }

	IList<ScriptModule> ScriptModules { get; }

	IList<IEntity> Entities { get; }
}
