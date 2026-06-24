using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Model;

namespace EleWise.ELMA.Services;

[ServiceContract]
public interface ICheckMetadataService
{
	CheckMetadataResult CheckProperty(ClassMetadata metadataDto, PropertyMetadata property);
}
