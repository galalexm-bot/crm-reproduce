using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Models.ConvertType;

public class DocTypeMappingInfo : TypeMappingInfo
{
	public string NameTemplate { get; set; }

	public bool IsNoNeedToGenerateNameByTemplate { get; set; }

	public new static DocTypeMappingInfo GetDefaultMapping(EntityMetadata sourceTypeMetadata, EntityMetadata targetTypeMetadata)
	{
		TypeMappingInfo defaultMapping = TypeMappingInfo.GetDefaultMapping(sourceTypeMetadata, targetTypeMetadata);
		return new DocTypeMappingInfo
		{
			IsNoNeedToGenerateNameByTemplate = true,
			NameTemplate = ((DocumentMetadata)targetTypeMetadata).TemplateName,
			PropertyMappings = defaultMapping.PropertyMappings,
			SourcePropertiesInfos = defaultMapping.SourcePropertiesInfos,
			SourceTypeInfo = defaultMapping.SourceTypeInfo,
			TargetTypeInfo = defaultMapping.TargetTypeInfo
		};
	}
}
