using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.Model.Scripts.DTO.Models;

namespace EleWise.ELMA.Model.Managers;

public interface IModelManager : IConfigurationService
{
	AssemblyModelsMetadata GetAssemblyModelsMetadata(string assemblyName);

	IEnumerable<AssemblyModelsMetadata> GetAssemblyModelsMetadataList();

	byte[] GetAssemblyModelsMetadataCompressed();

	bool IsElmaApiTreeInitialized();

	byte[] GetElmaApiTree();

	IEnumerable<MetadataItemDTO> GetMetadataItems();

	List<MetadataItemDTO> SaveMetadataItems(List<MetadataItemDTO> metadataItems);

	void DeleteMetadataItem(long metadataItemId);

	MetadataPublishResult Publish(string comment, params long[] headerIds);

	MetadataItemDTO LoadMetadataItemByHeaderId(long headerId);

	bool IsMetadataStarted(Guid metadataUid);

	List<Guid> GetMetadataStarted();

	bool IsPublishedProperty(Guid metadataUid, Guid propertyUid);

	bool IsDbReservedWord(string name);

	List<Guid> GetRestartRequiredMetadataUids();

	[Obsolete("Not used", true)]
	ScriptModuleDTO GetModelScriptModule();

	[Obsolete("Not used", true)]
	void SaveModelScriptModule(ScriptModuleDTO scriptModuleDto);

	[Obsolete("Not used", true)]
	void AddModelScriptModuleReferences(IEnumerable<string> references);

	EntityInfo GetEntityInfo(Guid typeUid, string id);

	MetadataItemDTO GetPublishedMetadataByUid(Guid uid);
}
