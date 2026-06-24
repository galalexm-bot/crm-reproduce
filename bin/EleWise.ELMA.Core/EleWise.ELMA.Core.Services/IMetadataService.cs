using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Core.Services;

[ServiceContract]
internal interface IMetadataService
{
	IMetadata GetMetadata(Guid moduleUid, Guid metadataUid);

	System.Collections.Generic.IEnumerable<ClassMetadata> GetBaseClasses(Guid moduleUid, Guid metadataUid);

	System.Threading.Tasks.Task<IMetadata> GetMetadataAsync(Guid moduleUid, Guid metadataUid);

	IMetadata GetMetadataByHash(Guid moduleUid, string hash);

	System.Collections.Generic.IEnumerable<IMetadata> GetMetadataList(Guid moduleUid);

	IMetadata LoadMetadata(Guid moduleUid, System.Type type);

	void DeleteMetadata(Guid moduleUid, Guid uid);

	System.Collections.Generic.IEnumerable<NamespaceMetadata> GetNamespaceMetadataList(Guid moduleUid);

	System.Collections.Generic.IEnumerable<NamespaceInfo> GetNamespaceInfoList(Guid moduleUid);

	IPropertyMetadata GetProperty(Guid moduleUid, ClassMetadata metadataDto, Guid propertyUid);

	System.Collections.Generic.IEnumerable<IPropertyMetadata> GetProperties(Guid moduleUid, ClassMetadata metadataDto, bool includeBase);
}
