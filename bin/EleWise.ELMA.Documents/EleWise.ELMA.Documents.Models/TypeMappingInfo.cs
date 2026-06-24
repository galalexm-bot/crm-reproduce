using System;
using System.Linq;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Models.ConvertType;

public class TypeMappingInfo
{
	public TypeInfo SourceTypeInfo { get; set; }

	public TypeInfo TargetTypeInfo { get; set; }

	public PropertyMappingInfo[] PropertyMappings { get; set; }

	public PropertyInfo[] SourcePropertiesInfos { get; set; }

	public static TypeMappingInfo GetDefaultMapping(EntityMetadata sourceTypeMetadata, EntityMetadata targetTypeMetadata)
	{
		PropertyInfo[] propertiesInfosForType = PropertyInfo.GetPropertiesInfosForType(targetTypeMetadata);
		DocTypeMappingInfo docTypeMappingInfo = new DocTypeMappingInfo
		{
			SourceTypeInfo = new TypeInfo
			{
				Uid = sourceTypeMetadata.Uid,
				DisplayName = sourceTypeMetadata.DisplayName,
				Name = sourceTypeMetadata.Name
			},
			TargetTypeInfo = new TypeInfo
			{
				Uid = targetTypeMetadata.Uid,
				DisplayName = targetTypeMetadata.DisplayName,
				Name = targetTypeMetadata.DisplayName
			},
			SourcePropertiesInfos = PropertyInfo.Sort(PropertyInfo.GetChildPropsAndBlocks(sourceTypeMetadata, sourceTypeMetadata.Uid, 0, new Guid[0], string.Empty)),
			PropertyMappings = propertiesInfosForType.Select((PropertyInfo prop) => new PropertyMappingInfo
			{
				NewPropertyInfo = prop,
				OldPropertyInfo = new PropertyInfo(),
				EnableConvert = true
			}).ToArray()
		};
		PropertyMappingInfo[] propertyMappings = docTypeMappingInfo.PropertyMappings;
		foreach (PropertyMappingInfo propMapping in propertyMappings)
		{
			PropertyInfo propertyInfo = docTypeMappingInfo.SourcePropertiesInfos.FirstOrDefault((PropertyInfo m) => m.Uid == propMapping.NewPropertyInfo.Uid) ?? docTypeMappingInfo.SourcePropertiesInfos.FirstOrDefault((PropertyInfo m) => m.Name == propMapping.NewPropertyInfo.Name && m.TypeUid == propMapping.NewPropertyInfo.TypeUid && m.SubTypeUid == propMapping.NewPropertyInfo.SubTypeUid && m.ParentBlockUid == propMapping.NewPropertyInfo.ParentBlockUid);
			if (propertyInfo != null)
			{
				propMapping.OldPropertyInfo = propertyInfo;
			}
		}
		return docTypeMappingInfo;
	}
}
