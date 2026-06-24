using System.Collections.Generic;
using EleWise.ELMA.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;

namespace EleWise.ELMA.Model.CodeGeneration;

public interface IModelAssemblyBuilderHandler : IEventHandler
{
	void ConfigurationModelAssemblyBuilt(IEnumerable<AbstractMetadata> publishMetadataList);

	void DynamicModelAssemblyBuilt(IEnumerable<EntityMetadata> systemMetadata);

	void AfterAll(IEnumerable<AbstractMetadata> publishMetadataList, IEnumerable<ScriptModule> scriptModules, IEnumerable<ScriptModule> clientScriptModules);
}
