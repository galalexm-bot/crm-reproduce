using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Managers;

namespace EleWise.ELMA.Model.Metadata.Managers;

internal interface IFunctionMetadataItemManager : IEntityManager<FunctionMetadataItem, long>, IEntityManager<FunctionMetadataItem>, IEntityManager
{
	FunctionMetadataItem Create(Guid moduleUid, Guid group, string displayName);

	FunctionMetadataItem Copy(Guid headerUid);

	IEnumerable<FunctionMetadataItem> GetCandidates(Guid headerUid);

	UIMetadataPublishResult Publish(Guid headerUid, string comment);

	string UpdateScriptCode(FunctionMetadata newMetadata, FunctionMetadata oldMetadata, string newSource);

	GenerateFunctionCodeResponse GenerateCode(GenerateFunctionCodeRequest request);
}
