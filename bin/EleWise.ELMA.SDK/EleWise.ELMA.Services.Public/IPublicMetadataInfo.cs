using System;
using EleWise.ELMA.Common;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Services.Public;

public interface IPublicMetadataInfo
{
	Guid Uid { get; }

	Guid GroupUid { get; }

	string Name { get; }

	string DisplayName { get; }

	IMetadata GetMetadata();

	void ProcessPropertyDescriptor(IPropertyMetadata propMetadata, TypeSerializationItemDescriptor propDescriptor);
}
