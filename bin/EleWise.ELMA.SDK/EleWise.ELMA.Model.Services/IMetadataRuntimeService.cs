using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Services;

[ExtensionPoint(ComponentType.Server)]
public interface IMetadataRuntimeService : IMetadataService
{
	bool ConfigurationScriptsRecompileRequired { get; }

	string ConfigurationScriptsErrors { get; }

	IMetadata GetParentMetadata(Guid metadataUid);

	Type GetTypeByUid(Guid uid, bool loadImplementation = true);

	Type GetTypeByUidOrNull(Guid uid, bool loadImplementation = true);

	void RegisterType(Type type);

	void RegisterType(Type type, bool asEntity);

	void RegisterTypes(IEnumerable<Type> types, Action<Type, Exception> registrationException = null);

	void RegisterTypes(IEnumerable<Type> types, bool asEntity, Action<Type, Exception> registrationException = null);

	void RegisterTypes(IEnumerable<Type> types, IDictionary<Type, string> entityNames, Action<Type, Exception> registrationException = null);

	IEnumerable<AssemblyModelsMetadata> GetAssemblyModelsMetadataList();

	IEnumerable<AssemblyModelsMetadata> GetPreviousAssemblyModelsMetadataList();

	new bool IsSystem(Guid typeUid);

	new bool IsConfig(Guid typeUid);
}
