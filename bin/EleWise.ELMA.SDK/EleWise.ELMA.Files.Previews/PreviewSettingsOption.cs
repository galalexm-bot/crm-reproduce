using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Files.Previews;

[DisplayName(typeof(__Resources_PreviewSettingsOption), "DisplayName")]
[MetadataType(typeof(EnumMetadata))]
[Uid("fc1585a0-66b9-46ea-857c-16ba2e44723c")]
public enum PreviewSettingsOption
{
	[DisplayName(typeof(__Resources_PreviewSettingsOption), "P_HideSelector_DisplayName")]
	[Uid("74da11a3-792b-4175-b733-420678830728")]
	HideSelector
}
