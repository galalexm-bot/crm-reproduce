using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Core.Services;

[ServiceContract]
public interface IMetadataServiceContext
{
	IMetadata GetMetadata(Guid metadataUid);

	System.Collections.Generic.IEnumerable<ClassMetadata> GetBaseClasses(Guid metadataUid);

	System.Threading.Tasks.Task<IMetadata> GetMetadataAsync(Guid metadataUid);

	IMetadata GetMetadataByHash(string hash);

	System.Collections.Generic.IEnumerable<MetadataHeader> GetMetadataHeaders(bool withDrafts);

	System.Collections.Generic.IEnumerable<IMetadata> GetMetadataList();

	IMetadata LoadMetadata(System.Type type);

	void DeleteMetadata(Guid uid);

	System.Collections.Generic.IEnumerable<NamespaceMetadata> GetNamespaceMetadataList();

	System.Collections.Generic.IEnumerable<NamespaceInfo> GetNamespaceInfoList();

	IPropertyMetadata GetProperty(ClassMetadata metadataDto, Guid propertyUid);

	ValueTuple<ClassMetadata, IPropertyMetadata> GetPropertyWithOwner(ClassMetadata metadataDto, Guid propertyUid);

	ValueTuple<PropertyMetadata, DataClassMetadata> FindProperty(DataClassMetadata dataClassMetadata, Guid propertyUid);

	System.Collections.Generic.IEnumerable<IPropertyMetadata> GetProperties(ClassMetadata metadataDto, bool includeBase);

	PropertyInfoExpression GetPropertyExpression(IPropertyMetadata property, ClassMetadata metadata);

	System.Threading.Tasks.Task InitHeaders();

	System.Threading.Tasks.Task<MetadataHeader> GetMetadataHeader(Guid metadataUid);

	System.Threading.Tasks.Task<bool> CheckChanges();

	DataClassMetadata GetViewModelMetadata(EntityMetadata entityMetadata);

	System.Threading.Tasks.Task<DataClassMetadata> GetViewModelMetadataAsync(EntityMetadata entityMetadata);

	System.Threading.Tasks.Task<List<ExtendMetadataModel>> GetMetadataListWithParents(EntityMetadata metadata);

	EntityMetadata GetTablePartRoot(TablePartMetadata tablePartMetadata);
}
