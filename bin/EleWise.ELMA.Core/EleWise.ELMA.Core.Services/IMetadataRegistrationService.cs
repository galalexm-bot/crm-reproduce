using System.Collections.Generic;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Core.Services;

[ServiceContract]
public interface IMetadataRegistrationService
{
	void Register(IMetadata metadataDto);

	void Register(System.Collections.Generic.IEnumerable<IMetadata> metadataList);
}
