using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Services;

public interface IMetadataService
{
	IMetadata GetMetadata(Guid metadataUid, bool loadImplementation = true);

	IEnumerable<IMetadata> GetMetadataList();

	bool IsSystem(Guid typeUid);

	bool IsConfig(Guid typeUid);

	IEnumerable<ITypeDescriptor> GetTypeDescriptors();

	ITypeDescriptor GetTypeDescriptor(Guid typeUid, Guid subTypeUid);

	ITypeDescriptor GetTypeDescriptor(Type runtimeType);

	IEnumerable<ITypeDescriptor> GetIdTypeDescriptors();

	ITypeDescriptor GetIdTypeDescriptor(Guid typeUid);
}
